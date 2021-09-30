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
    public partial class frmSeguridad : Form
    {
        clsAdminSeguridad seguridad = new clsAdminSeguridad();
        public frmSeguridad()
        {
            InitializeComponent();
        }
        private bool Validar()
        {
            Boolean errorCampos = true;


            if (txtUsuario.Text == string.Empty)
            {
                MensajeError.SetError(txtUsuario, "Debe ingresar el nombre de usuario");
                txtUsuario.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtUsuario, "");
            }

            if (txtClave.Text == string.Empty)
            {
                MensajeError.SetError(txtClave, "Debe ingresar la clave");
                txtClave.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtClave, "");
            }

            return errorCampos;
        }

        private void LlenarComboEmpleados(string filtro = "")
        {
            // LLENAMOS EL COMBOBOX CON LOS DATOS DE SEGURIDAD DE LOS EMPLEADOS
            try
            {
                cmbEmpleado.Items.Clear();
                DataTable dt = seguridad.ConsultarSeguridad(filtro);
                cmbEmpleado.DataSource = dt;
                cmbEmpleado.DisplayMember = "StrUsuario";
                cmbEmpleado.ValueMember = "IdEmpleado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGA LOS DATOS " + ex);
            }
        }

        private void Consultar()
        {
            string filtro = cmbEmpleado.SelectedValue.ToString();
            try
            {
                DataTable dt = seguridad.ConsultarSeguridad(filtro);
                if (dt.Rows.Count > 0)
                {
                    txtUsuario.Text = dt.Rows[0]["StrUsuario"].ToString();
                    txtClave.Text = dt.Rows[0]["StrClave"].ToString();
                }
                else
                {
                    MessageBox.Show("El usuario no dispone de datos de ingreso");
                    txtUsuario.Text = "";
                    txtClave.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CONSULTAR LOS DATOS DE SEGURIDAD DEL EMPLEADO " + ex);
            }
        }

        private void Actualizar()
        {
            Boolean Actualizar = false;

            if (Validar())
            {
                try
                {
                    seguridad.C_IdEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue);
                    seguridad.C_StrUsuario = txtUsuario.Text;
                    seguridad.C_StrClave = txtClave.Text;
                    seguridad.C_UsuarioModifica = "Javier";

                    string Mensaje = seguridad.ActualizarSeguridad();
                    MessageBox.Show(Mensaje);
                    Actualizar = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL ACTUALIZAR LOS DATOS " + ex);
                    Actualizar = false;
                }
            }
        }

        public void Eliminar()
        {
            string Mensaje = "";
            try
            {
                if (MessageBox.Show($"¿Quieres borrar el cliente { cmbEmpleado.Text}?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                
                    seguridad.C_IdEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue);
                    Mensaje = seguridad.EliminarSeguridad();

                    if (Mensaje == "Los datos fueron actualizados")
                    {
                        MessageBox.Show($"CLIENTE { cmbEmpleado.Text} BORRADO");
                    }
                    else
                    {
                        MessageBox.Show($"FALLA AL BORRAR EL CLIENTE { cmbEmpleado.Text}, " + "¡¡EL CLIENTE TIENE FACTURAS ASOCIADAS!!");
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void frmSeguridad_Load(object sender, EventArgs e)
        {
            LlenarComboEmpleados();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
