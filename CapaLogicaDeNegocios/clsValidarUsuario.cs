using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using System.Data;

namespace CapaLogicaDeNegocios
{
    class clsValidarUsuario
    {
        // DEFINIMOS LOS ATRIBUTOS DE LA CLASE
        public string C_StrUsuario { get; set; }
        public string C_StrClave { get; set; }
        public Int32 C_IdEmpleado { get; set; }

        clsAccesoDatos clsAcceso = new clsAccesoDatos();

        public void ValidarUsuario()
        {
            try
            {
                string Sentencia = $"SELECT IdEmpleado, StrUsuario FROM TBLSEGURIDAD WHERE StrUsuario = {C_StrUsuario} AND StrClave = {C_StrClave}";
                DataTable dataTable = new DataTable();
                dataTable = clsAcceso.ejecutarConsulta(Sentencia);

                foreach (DataRow fila in dataTable.Rows)
                    C_IdEmpleado = int.Parse(fila[0].ToString());
            }
            catch (Exception ex)
            {

                throw(ex);
            }
        }
    }
}
