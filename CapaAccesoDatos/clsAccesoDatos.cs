using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{

    public class clsParametros
    {
        public string Nombre { get; set; }
        public object Valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public Int32 Tamaño { get; set; }
        public ParameterDirection direccionParametro { get; set; }

        // Constructor parametros de entrada
        public clsParametros(string objNombre, Object objValor)
        {
            Nombre = objNombre;
            Valor = objValor;
            direccionParametro = ParameterDirection.Input;
        }

        // Constructor parametros de salida
        public clsParametros(string objNombre, SqlDbType objTipoDato, Int32 objTamaño)
        {
            Nombre = objNombre;
            TipoDato = objTipoDato;
            Tamaño = objTamaño;
            direccionParametro = ParameterDirection.Output;
        }

    }

    public class clsAccesoDatos
    {
        SqlConnection Connection;  // Se define la variable para la conexion de tipo SqlConnection
        SqlCommand cmd;              //Se define la variable para los cambios en la Base de datos
        SqlDataReader lectorDatos = null;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        DataSet dataSet;

        public string AbrirBD()       //Metodo para abrir la base de datos
        {
            string Respuesta = "";
            try         //Permite capturar el error en caso de que se presente, evitando que se cierre la aplicación
            {
                // Creamos un objeto tipo SqlConnection a la base de datos y se pasa como parametro la cadena de conexion
                Connection = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = [DBFACTURAS]; Integrated Security = True");
                Connection.Open();
            }
            catch (Exception ex)   //Si hay un error se presenta el siguiente mensaje
            {
                Respuesta = "Error al abrir la conexión" + ex;
            }

            return Respuesta;
        }

        public string CerrarBD()    //Metodo para cerrar la base de datos
        {
            string Respuesta = "";
            try
            {
                Connection.Close(); //Invocamos metodo para cerrar la base de datos
            }
            catch (Exception ex)    // Si hay algún problema se muestra este mensaje
            {
                Respuesta = "Error al cerrar la conexión" + ex;
            }

            return Respuesta;
        }

        // PERMITE EJECUTAR PROCEDIMIENTOS EN LA BASE DE DATOS, LOS PARAMETROS SE PASAN POR MEDIO DE UNA LISTA
        public string ejecutarProcedimento(string procedimiento, List<clsParametros> lst)
        {
            string Salida = "";
            try
            {
                int Retornado;

                SqlCommand command = new SqlCommand(procedimiento, Connection);
                command.CommandType = CommandType.StoredProcedure;

                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].direccionParametro == ParameterDirection.Input)
                        {
                            command.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        }
                        if (lst[i].direccionParametro == ParameterDirection.Output)
                        {
                            command.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño);
                        }
                    }
                }

                Retornado = command.ExecuteNonQuery();
                CerrarBD();

                if (Retornado > 0)
                {
                    Salida = "Los datos fueron actualizados";
                }
                else
                {
                    Salida = "Los datos no fueron actualizado";
                }
            }
            catch (Exception ex)
            {
                Salida = "Falló la operacion " + ex;
            }
            return Salida;
        }

        // UTILIZADO PARA UPDATE, INSERT Y DELETE, RETORNA MENSAJE INDICANDO SI SE ACTUALIZÓ O NO
        public string ejecutarComando(string Sentencia)
        {
            string Salida = "";
            try
            {
                int Retornado;

                AbrirBD();
                cmd = new SqlCommand(Sentencia, Connection); // Usado para el UPDATE, INSERT, DELETE
                Retornado = cmd.ExecuteNonQuery();           // Recibe el numero de filas afectadas
                CerrarBD();

                if (Retornado > 0)
                {
                    Salida = "Los datos fueron actualizados";
                }
                else
                {
                    Salida = "Los datos no fuerna actualizados";
                }
            }
            catch (Exception ex)
            {
                Salida = "Falló la operacion " + ex;
            }
            return Salida;
        }

        // METODO QUE PERMITE REALIZAR UNA CONSULTA EN UNA O VARIAS TABLAS
        // Y RETORNA UN CONJUNTO DE REGISTROS EN UNA DATATABLE (IDEAL PARA LLENAR EL DATAGRID Y LOS COMBOBOXES)
        public DataTable ejecutarConsulta(string cmd)
        {
            try
            {
                AbrirBD();
                dataAdapter = new SqlDataAdapter(cmd, Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                CerrarBD();
                return dataTable;

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
