using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaLogicaDeNegocios
{
    public class clsEmpleado
    {
        //DEFINIMOS LOS ATRIBUTOS DE LA CLASE
        public int C_IdEmpleado { get; set; }
        public string C_Empleado { get; set; }
        public int C_Documento { get; set; }
        public string C_Direccion { get; set; }
        public string C_Telefono { get; set; }
        public string C_Email { get; set; }
        public int C_IdRolEmpleado { get; set; }
        public DateTime C_DtmIngreso { get; set; }
        public DateTime C_DtmRetiro { get; set; }
        public string C_DatosAdicionales { get; set; }
        public string C_UsuarioModifica { get; set; }

        clsAccesoDatos clsAcceso = new clsAccesoDatos();

        public string ActualizarEmpleado()
        {
            string Mensaje = "";

            try
            {
                List<clsParametros> parametros = new List<clsParametros>();
                parametros.Add(new clsParametros("@IdEmpleado", C_IdEmpleado));
                parametros.Add(new clsParametros("@strNombre", C_Empleado));
                parametros.Add(new clsParametros("@NumDocumento", C_Documento));
                parametros.Add(new clsParametros("@StrDireccion", C_Direccion));
                parametros.Add(new clsParametros("@StrTelefono", C_Telefono));
                parametros.Add(new clsParametros("@StrEmail", C_Email));
                parametros.Add(new clsParametros("@IdRolEmpleado", C_IdRolEmpleado));
                parametros.Add(new clsParametros("@DtmIngreso", C_DtmIngreso));
                parametros.Add(new clsParametros("@DtmRetiro", C_DtmRetiro));
                parametros.Add(new clsParametros("@strDatosAdicionales", C_DatosAdicionales));
                parametros.Add(new clsParametros("@DtmFechaModifica", DateTime.Now));
                parametros.Add(new clsParametros("@StrUsuarioModifico", C_UsuarioModifica));

                Mensaje = clsAcceso.ejecutarProcedimento("actualizar_Empleado", parametros);
            }
            catch (Exception ex)
            {
                Mensaje = "FALLÓ LA ACTUALIZACIÓN DEL CLIENTE " + ex;
            }

            return Mensaje;
        }

        public string EliminarEmpleado()
        {
            string Mensaje = "";

            try
            {
                string Sentencia = $"Exec Eliminar_Empleado {C_IdEmpleado}";
                Mensaje = clsAcceso.ejecutarComando(Sentencia);
            }
            catch (Exception ex)
            {
                Mensaje = "FALLÓ EL BORRADO DEL CLIENTE " + ex;
            }

            return Mensaje;
        }

        public DataTable ConsultarEmpleado(string tabla, string filtro)
        {
            string Sentencia;

            try
            {
                if (filtro == string.Empty)
                {
                    Sentencia = $"SELECT * FROM {tabla}";
                }
                else
                {
                    Sentencia = $"SELECT * FROM TBLEMPLEADO WHERE strNombre like '%{filtro}%'";
                }
                DataTable dataTable = new DataTable();
                dataTable = clsAcceso.ejecutarConsulta(Sentencia);
                return dataTable;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
