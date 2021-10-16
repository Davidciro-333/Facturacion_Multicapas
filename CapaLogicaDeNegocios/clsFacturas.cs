using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaAccesoDatos;

namespace CapaLogicaDeNegocios
{
    public class clsFacturas
    {
        //DEFINIMOS LOS ATRIBUTOS DE LA CLASE
        public int C_IdFactura { get; set; }
        public DateTime C_DtmFecha { get; set; }
        public int C_IdCliente { get; set; }
        public int C_IdEmpleado { get; set; }
        public float C_NumDescuento { get; set; }
        public float C_NumImpuesto { get; set; }
        public float C_NumValorTotal { get; set; }
        public int C_IdEstado { get; set; }
        public string C_StrUsuarioModifica { get; set; }

        clsAccesoDatos clsAcceso = new clsAccesoDatos();

        public string ActualizarFactura()
        {
            string Mensaje = "";

            try
            {
                List<clsParametros> parametros = new List<clsParametros>();
                parametros.Add(new clsParametros("@IdFactura", C_IdFactura));
                parametros.Add(new clsParametros("@DtmFecha", C_DtmFecha));
                parametros.Add(new clsParametros("@IdCliente", C_IdCliente));
                parametros.Add(new clsParametros("@IdEmpleado", C_IdEmpleado));
                parametros.Add(new clsParametros("@NumDescuento", C_NumDescuento));
                parametros.Add(new clsParametros("@NumImpuesto", C_NumImpuesto));
                parametros.Add(new clsParametros("@NumValorTotal", C_NumValorTotal));
                parametros.Add(new clsParametros("@IdEstado", C_IdEstado));
                parametros.Add(new clsParametros("@DtmFechaModifica", DateTime.Now));
                parametros.Add(new clsParametros("@StrUsuarioModifica", C_StrUsuarioModifica));

                Mensaje = clsAcceso.ejecutarProcedimento("actualizar_Factura", parametros);
            }
            catch (Exception ex)
            {
                Mensaje = "FALLÓ LA ACTUALIZACIÓN DEL PRODUCTO " + ex;
            }

            return Mensaje;
        }

        public DataTable ConsultarFactura(string tabla, string filtro)
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
                    Sentencia = $"SELECT * FROM TBLFACTURA WHERE StrNombre like '%{filtro}%'";
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
