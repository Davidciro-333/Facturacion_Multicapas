using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantilla_Sistema_facturacion_2021_2
{
    public partial class frmClientesV2 : Form
    {
        public frmClientesV2()
        {
            InitializeComponent();
        }

        private void frmClientesV2_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                dgvClientesCRUD2.Rows.Add(i, $"Nombre {i} Apellido 1, Apellido 2", $"{i * 4327823}", $"Direccion {i}",  $"{i * 24892321}", $"Nombre{i}@gmail.com");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarCliente editarCliente = new frmEditarCliente();
            editarCliente.IdCliente = 0;
            editarCliente.ShowDialog();
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
                if (MessageBox.Show($"¿Quieres borrar el ID { dgvClientesCRUD2[0, posActual].Value.ToString()}?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                    MessageBox.Show($"ID { dgvClientesCRUD2[0, posActual].Value.ToString()} BORRADO");
}
            if (dgvClientesCRUD2.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActualFila = dgvClientesCRUD2.CurrentRow.Index;
                frmEditarCliente editarCliente = new frmEditarCliente();
                editarCliente.IdCliente = int.Parse(dgvClientesCRUD2[0, posActualFila].Value.ToString());
                editarCliente.strCliente = dgvClientesCRUD2[1, posActualFila].Value.ToString();
                editarCliente.strDocumento = dgvClientesCRUD2[2, posActualFila].Value.ToString();
                editarCliente.strDireccion = dgvClientesCRUD2[3, posActualFila].Value.ToString();
                editarCliente.strTelefono = dgvClientesCRUD2[4, posActualFila].Value.ToString();
                editarCliente.strEmail = dgvClientesCRUD2[5, posActualFila].Value.ToString();
                editarCliente.ShowDialog();
            }
        }
    }
}
