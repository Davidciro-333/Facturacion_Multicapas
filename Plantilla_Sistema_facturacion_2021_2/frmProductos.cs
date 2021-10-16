using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaDeNegocios;

namespace Plantilla_Sistema_facturacion_2021_2
{
    public partial class frmProductos : Form
    {
        clsProductos productos = new clsProductos();
        frmEditarProductos editarProductos = new frmEditarProductos();
        public frmProductos()
        {
            InitializeComponent();
        }

        public void LLENAR_GRID(string filtro = "")
        {
            // LLENAMOS EL GRID CON LOS CLIENTES REGISTRADOS
            try
            {
                dgProductos.Rows.Clear();
                DataTable dt = productos.ConsultarProducto("TBLPRODUCTO", filtro);
                foreach (DataRow fila in dt.Rows)
                {
                    dgProductos.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], fila[5], fila[6], fila[7], fila[8]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presentó un error al consultar los datos " + ex);
            }

        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            LLENAR_GRID();
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgProductos.Columns[e.ColumnIndex].Name == "btnBorrar")
            {

                int posActual = dgProductos.CurrentRow.Index;
                if (MessageBox.Show($"¿Quieres borrar el producto { dgProductos[1, posActual].Value}?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    productos.C_IdProducto = Convert.ToInt32(dgProductos[0, posActual].Value.ToString());
                    string Mensaje = productos.EliminarProducto();
                    if (Mensaje == "Los datos fueron actualizados")
                    {
                        MessageBox.Show($"PRODUCTO { dgProductos[1, posActual].Value} BORRADO");
                    }
                    else
                    {
                        MessageBox.Show($"FALLA AL BORRAR EL PRODUCTO { dgProductos[1, posActual].Value}, " + "¡¡EL PRODUCTO TIENE FACTURAS ASOCIADAS!!");
                    }
                }
            }
            if (dgProductos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActualFila = dgProductos.CurrentRow.Index;
                editarProductos.IdProducto = int.Parse(dgProductos[0, posActualFila].Value.ToString());
                editarProductos.StrNombre = dgProductos[1, posActualFila].Value.ToString();
                editarProductos.StrCodigo = dgProductos[2, posActualFila].Value.ToString();
                editarProductos.NumPrecioCompra = float.Parse(dgProductos[3, posActualFila].Value.ToString());
                editarProductos.NumPrecioVenta = float.Parse(dgProductos[4, posActualFila].Value.ToString());
                editarProductos.IdCategoria = Convert.ToInt32(dgProductos[5, posActualFila].Value.ToString());
                editarProductos.StrDetalle = dgProductos[6, posActualFila].Value.ToString();
                editarProductos.strFoto = dgProductos[7, posActualFila].Value.ToString();
                editarProductos.NumStock = Convert.ToInt32(dgProductos[8, posActualFila].Value.ToString());
                editarProductos.ShowDialog();
            }
            LLENAR_GRID();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarProductos editar = new frmEditarProductos();
            editar.IdProducto = 0;
            editar.ShowDialog();
            LLENAR_GRID();
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Text != string.Empty) LLENAR_GRID(txtBuscarProducto.Text); else LLENAR_GRID();
            txtBuscarProducto.Text = "";
        }
    }
}
