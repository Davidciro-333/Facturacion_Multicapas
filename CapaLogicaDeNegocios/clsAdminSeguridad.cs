using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaAccesoDatos;

namespace CapaLogicaDeNegocios
{
    public class clsAdminSeguridad
    {
        // DEFINIMOS LO ATRIBUTOS DE LA CLASE
        public int C_IdEmpleado { get; set; }
        public string C_StrUsuario { get; set; }
        public string C_StrClave { get; set; }
        public string C_UsuarioModifica { get; set; }

        clsAccesoDatos datos = new clsAccesoDatos();
        
        // METODO PARA ACTUALIZAR LOS DATOS DE SEGUIRAD DEL EMPLEADO
        public string ActualizarSeguridad()
        {
            string Mensaje = "";
            try
            {
                List<clsParametros> parametros = new List<clsParametros>();
                parametros.Add(new clsParametros("@IdEmpleado", C_IdEmpleado));
                parametros.Add(new clsParametros("@StrUsuario", C_StrUsuario));
                parametros.Add(new clsParametros("@StrClave", C_StrClave));
                parametros.Add(new clsParametros("@DtmFechaModifica", DateTime.Now));
                parametros.Add(new clsParametros("@StrUsuarioModifico", C_UsuarioModifica));

                Mensaje = datos.ejecutarProcedimento("actualizar_Seguridad", parametros);
            }
            catch (Exception ex)
            {
                Mensaje = "FALLÓ LA ACTUALIZACIÓ DEL CLIENTE " + ex;
            }

            return Mensaje;
        }

        // METODO PARA BORRAR LOS DATOS DE SEGUIRAD DEL EMPLEADO
        public string EliminarSeguridad()
        {
            string Mensaje = "";

            try
            {
                string Sentencia = $"Exec Eliminar_Seguridad {C_IdEmpleado}";
                Mensaje = datos.ejecutarComando(Sentencia);
            }
            catch (Exception ex)
            {
                Mensaje = "FALLÓ EL BORRADO DEL CLIENTE " + ex;
            }

            return Mensaje;
        }

        public DataTable ConsultarSeguridad(string filtro)
        {
            string Sentencia;

            try
            {
                if (filtro == string.Empty)
                {
                    Sentencia = "SELECT * FROM TBLSEGURIDAD";
                }
                else
                {
                    Sentencia = "SELECT StrUsuario, StrClave FROM TBLSEGURIDAD WHERE IdEmpleado = " + filtro;

                }
                DataTable dataTable = new DataTable();
                dataTable = datos.ejecutarConsulta(Sentencia);
                return dataTable;
            }
            catch (Exception)
            {
                return null;
            }
        }


    }
}
