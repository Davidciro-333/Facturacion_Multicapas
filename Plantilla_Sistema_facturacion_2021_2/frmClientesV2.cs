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
    public partial class frmClientesV2 : Form
    {
        clsClientes clientes = new clsClientes();

        frmEditarCliente editarCliente = new frmEditarCliente();

        public frmClientesV2()
        {
            InitializeComponent();
        }

        private void frmClientesV2_Load(object sender, EventArgs e)
        {
            LLENAR_GRID();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            editarCliente.IdCliente = 0;
            editarCliente.ShowDialog();
            LLENAR_GRID();
        }

        public void LLENAR_GRID(string filtro="")
        {
            // LLENAMOS EL GRID CON LOS CLIENTES REGISTRADOS
            try
            {
                dgvClientesCRUD2.Rows.Clear();
                DataTable dt = clientes.ConsultarCliente(filtro);
                foreach (DataRow fila in dt.Rows)
                {
                    dgvClientesCRUD2.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], fila[5]);
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

        private void dgvClientesCRUD2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientesCRUD2.Columns[e.ColumnIndex].Name == "btnBorrar")
            {

                int posActual = dgvClientesCRUD2.CurrentRow.Index;
                if (MessageBox.Show($"¿Quieres borrar el cliente { dgvClientesCRUD2[1, posActual].Value.ToString()}?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                    
                    clientes.C_IdCliente = Convert.ToInt32(dgvClientesCRUD2[0, posActual].Value.ToString());
                    string Mensaje = clientes.EliminarCliente();
                    if (Mensaje == "Los datos fueron actualizados")
                    {
                        MessageBox.Show($"CLIENTE { dgvClientesCRUD2[1, posActual].Value.ToString()} BORRADO");
                    }
                    else
                    {
                        MessageBox.Show($"FALLA AL BORRAR EL CLIENTE { dgvClientesCRUD2[1, posActual].Value.ToString()}, " + "¡¡EL CLIENTE TIENE FACTURAS ASOCIADAS!!");
                    }
                }
            }
            if (dgvClientesCRUD2.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActualFila = dgvClientesCRUD2.CurrentRow.Index;
                editarCliente.IdCliente = int.Parse(dgvClientesCRUD2[0, posActualFila].Value.ToString());
                editarCliente.strCliente = dgvClientesCRUD2[1, posActualFila].Value.ToString();
                editarCliente.strDocumento = int.Parse(dgvClientesCRUD2[2, posActualFila].Value.ToString());
                editarCliente.strDireccion = dgvClientesCRUD2[3, posActualFila].Value.ToString();
                editarCliente.strTelefono = dgvClientesCRUD2[4, posActualFila].Value.ToString();
                editarCliente.strEmail = dgvClientesCRUD2[5, posActualFila].Value.ToString();
                editarCliente.ShowDialog();
            }
            LLENAR_GRID();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtBuscarCliente.Text != string.Empty) LLENAR_GRID(txtBuscarCliente.Text); else LLENAR_GRID();
            txtBuscarCliente.Text = "";
        }
    }
}
