using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaAccesoDatos;
using System.Data;

namespace CapaLogicaDeNegocios
{
    public class clsProductos
    {
        //DEFINIMOS LOS ATRIBUTOS DE LA CLASE
        public int C_IdProducto { get; set; }
        public string C_StrNombre { get; set; }
        public string C_StrCodigo { get; set; }
        public float C_NumPrecioCompra { get; set; }
        public float C_NumPrecioVenta { get; set; }
        public int C_IdCategoria { get; set; }
        public string C_StrDetalle { get; set; }
        public string C_strFoto { get; set; }
        public int C_NumStock { get; set; }
        public string C_StrUsuarioModifica { get; set; }

        clsAccesoDatos clsAcceso = new clsAccesoDatos();

        public string ActualizarProducto()
        {
            string Mensaje = "";

            try
            {
                List<clsParametros> parametros = new List<clsParametros>();
                parametros.Add(new clsParametros("@IdProducto", C_IdProducto));
                parametros.Add(new clsParametros("@StrNombre", C_StrNombre));
                parametros.Add(new clsParametros("@StrCodigo", C_StrCodigo));
                parametros.Add(new clsParametros("@NumPrecioCompra", C_NumPrecioCompra));
                parametros.Add(new clsParametros("@NumPrecioVenta", C_NumPrecioVenta));
                parametros.Add(new clsParametros("@IdCategoria", C_IdCategoria));
                parametros.Add(new clsParametros("@StrDetalle", C_StrDetalle));
                parametros.Add(new clsParametros("@strFoto", C_strFoto));
                parametros.Add(new clsParametros("@NumStock", C_NumStock));
                parametros.Add(new clsParametros("@DtmFechaModifica", DateTime.Now));
                parametros.Add(new clsParametros("@StrUsuarioModifica", C_StrUsuarioModifica));

                Mensaje = clsAcceso.ejecutarProcedimento("actualizar_Producto", parametros);
            }
            catch (Exception ex)
            {
                Mensaje = "FALLÓ LA ACTUALIZACIÓN DEL PRODUCTO " + ex;
            }

            return Mensaje;
        }

        public string EliminarProducto()
        {
            string Mensaje = "";

            try
            {
                string Sentencia = $"Exec Eliminar_Producto {C_IdProducto}";
                Mensaje = clsAcceso.ejecutarComando(Sentencia);
            }
            catch (Exception ex)
            {
                Mensaje = "FALLÓ EL BORRADO DEL PRODUCTO " + ex;
            }

            return Mensaje;
        }

        public DataTable ConsultarProducto(string tabla, string filtro)
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
                    Sentencia = $"SELECT * FROM TBLPRODUCTO WHERE StrNombre like '%{filtro}%'";
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
