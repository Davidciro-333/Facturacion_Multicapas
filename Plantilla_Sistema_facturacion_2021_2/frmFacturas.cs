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
    public partial class frmFacturas : Form
    {
        clsFacturas facturas = new clsFacturas();
        frmEditarFactura editarFactura = new frmEditarFactura();
        public frmFacturas()
        {
            InitializeComponent();
        }

        public void LLENAR_GRID(string filtro = "")
        {
            // LLENAMOS EL GRID CON LOS CLIENTES REGISTRADOS
            try
            {
                dgFacturas.Rows.Clear();
                DataTable dt = facturas.ConsultarFactura("TBLFACTURA", filtro);
                foreach (DataRow fila in dt.Rows)
                {
                    dgFacturas.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], fila[5], fila[6], fila[7]);
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

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            LLENAR_GRID();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarFactura editar = new frmEditarFactura();
            editar.IdFactura = 0;
            editar.ShowDialog();
            LLENAR_GRID();
        }

        private void dgFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgFacturas.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActualFila = dgFacturas.CurrentRow.Index;
                editarFactura.IdFactura = Convert.ToInt32(dgFacturas[0, posActualFila].Value.ToString());
                editarFactura.DtmFecha = Convert.ToDateTime(dgFacturas[1, posActualFila].Value.ToString());
                editarFactura.IdCliente = Convert.ToInt32(dgFacturas[2, posActualFila].Value.ToString());
                editarFactura.IdEmpleado = Convert.ToInt32(dgFacturas[3, posActualFila].Value.ToString());
                editarFactura.NumDescuento = float.Parse(dgFacturas[4, posActualFila].Value.ToString());
                editarFactura.NumImpuesto = float.Parse(dgFacturas[5, posActualFila].Value.ToString());
                editarFactura.NumValorTotal = float.Parse(dgFacturas[6, posActualFila].Value.ToString());
                editarFactura.IdEstado = Convert.ToInt32(dgFacturas[7, posActualFila].Value.ToString());
                editarFactura.ShowDialog();
            }
            LLENAR_GRID();

        }
    }
}
