using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using System.Data;

namespace CapaLogicaDeNegocios
{
    public class clsClientes
    {
        // DEFINIMOS LO ATRIBUTOS DE LA CLASE
        public int C_IdCliente { get; set; }
        public string C_Nombre { get; set; }
        public double C_Documento { get; set; }
        public string C_Direccion { get; set; }
        public string C_Telefono { get; set; }
        public string C_Email { get; set; }
        public string C_UsuarioModifica { get; set; }

        clsAccesoDatos clsAcceso = new clsAccesoDatos();

        public string ActualizarCliente()
        {
            string Mensaje = "";

            try
            {
                List<clsParametros> parametros = new List<clsParametros>();
                parametros.Add(new clsParametros("@IdCliente", C_IdCliente));
                parametros.Add(new clsParametros("@StrNombre", C_Nombre));
                parametros.Add(new clsParametros("@NumDocumento", C_Documento));
                parametros.Add(new clsParametros("@StrDireccion", C_Direccion));
                parametros.Add(new clsParametros("@StrTelefono", C_Telefono));
                parametros.Add(new clsParametros("@StrEmail", C_Email));
                parametros.Add(new clsParametros("@DtmFechaModifica", DateTime.Now));
                parametros.Add(new clsParametros("@StrUsuarioModifica", C_UsuarioModifica));

                Mensaje = clsAcceso.ejecutarProcedimento("actualizar_Cliente", parametros);
            }
            catch (Exception ex)
            {
                Mensaje = "FALLÓ LA ACTUALIZACIÓN DEL CLIENTE " + ex;
            }

            return Mensaje;
        }

        public string EliminarCliente()
        {
            string Mensaje = "";

            try
            {
                string Sentencia = $"Exec Eliminar_Cliente {C_IdCliente}";
                Mensaje = clsAcceso.ejecutarComando(Sentencia);
            }
            catch (Exception ex)
            {
                Mensaje = "FALLÓ EL BORRADO DEL CLIENTE " + ex;
            }

            return Mensaje;
        }

        public DataTable ConsultarCliente(string filtro)
        {
            string Sentencia;

            try
            {
                if (filtro == string.Empty)
                {
                    Sentencia = "SELECT * FROM TBLCLIENTES";
                }
                else
                {
                    Sentencia = $"SELECT * FROM TBLCLIENTES WHERE StrNombre like '%{filtro}%'";
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
