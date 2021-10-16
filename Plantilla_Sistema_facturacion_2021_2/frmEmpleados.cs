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
    public partial class frmEmpleados : Form
    {
        clsEmpleado empleado = new clsEmpleado();
        frmEditarEmpleado editarEmpleado = new frmEditarEmpleado();
        public frmEmpleados()
        {
            InitializeComponent();
        }

        public void LLENAR_GRID(string filtro = "")
        {
            // LLENAMOS EL GRID CON LOS CLIENTES REGISTRADOS
            try
            {
                dgBuscarEmpleado.Rows.Clear();
                DataTable dt = empleado.ConsultarEmpleado("TBLEMPLEADO", filtro);
                foreach (DataRow fila in dt.Rows)
                {
                    dgBuscarEmpleado.Rows.Add(fila[0], fila[1], fila[2], fila[3], fila[4], fila[5], fila[6], fila[7], fila[8], fila[9]);
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

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            LLENAR_GRID();
        }

        private void dgBuscarEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgBuscarEmpleado.Columns[e.ColumnIndex].Name == "btnBorrar")
            {

                int posActual = dgBuscarEmpleado.CurrentRow.Index;
                if (MessageBox.Show($"¿Quieres borrar el empleado { dgBuscarEmpleado[1, posActual].Value}?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    empleado.C_IdEmpleado = Convert.ToInt32(dgBuscarEmpleado[0, posActual].Value.ToString());
                    string Mensaje = empleado.EliminarEmpleado();
                    if (Mensaje == "Los datos fueron actualizados")
                    {
                        MessageBox.Show($"EMPLEADO { dgBuscarEmpleado[1, posActual].Value} BORRADO");
                    }
                    else
                    {
                        MessageBox.Show($"FALLA AL BORRAR EL EMPLEADO { dgBuscarEmpleado[1, posActual].Value}, " + "¡¡EL EMPLEADO TIENE FACTURAS ASOCIADAS!!");
                    }
                }
            }
            if (dgBuscarEmpleado.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int posActualFila = dgBuscarEmpleado.CurrentRow.Index;
                editarEmpleado.IdEmpleado = int.Parse(dgBuscarEmpleado[0, posActualFila].Value.ToString());
                editarEmpleado.strEmpleado = dgBuscarEmpleado[1, posActualFila].Value.ToString();
                editarEmpleado.NumDocumento = int.Parse(dgBuscarEmpleado[2, posActualFila].Value.ToString());
                editarEmpleado.StrDireccion = dgBuscarEmpleado[3, posActualFila].Value.ToString();
                editarEmpleado.StrTelefono = dgBuscarEmpleado[4, posActualFila].Value.ToString();
                editarEmpleado.strEmail = dgBuscarEmpleado[5, posActualFila].Value.ToString();
                editarEmpleado.IdRolEmpleado = Convert.ToInt32(dgBuscarEmpleado[6, posActualFila].Value.ToString());
                editarEmpleado.DtmIngreso = Convert.ToDateTime(dgBuscarEmpleado[7, posActualFila].Value.ToString());
                editarEmpleado.DtmRetiro = Convert.ToDateTime(dgBuscarEmpleado[8, posActualFila].Value.ToString());
                editarEmpleado.DatosAdicionales = dgBuscarEmpleado[9, posActualFila].Value.ToString();
                editarEmpleado.ShowDialog();
            }
            LLENAR_GRID();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditarEmpleado editar = new frmEditarEmpleado();
            editar.IdEmpleado = 0;
            editar.ShowDialog();
            LLENAR_GRID();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            if (txtBuscarEmpleado.Text != string.Empty) LLENAR_GRID(txtBuscarEmpleado.Text); else LLENAR_GRID();
            txtBuscarEmpleado.Text = "";
        }
    }
}
