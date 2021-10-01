using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using CapaLogicaDeNegocios;

namespace Plantilla_Sistema_facturacion_2021_2
{
    public partial class frmEditarCliente : MaterialForm
    {
        public int IdCliente { get; set; }
        public string strCliente { get; set; }
        public int strDocumento { get; set; }
        public string strTelefono { get; set; }
        public string strDireccion { get; set; }
        public string strEmail { get; set; }

        clsClientes clientes = new clsClientes();
        public frmEditarCliente()
        {
            InitializeComponent();
        }

        private void frmEditarCliente_Load(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {
                //Registro nuevo
                lblEditarCliente.Text = "INGRESO NUEVO CLIENTE";

                int x = (Convert.ToInt32(Size.Width) / 2) - (Convert.ToInt32(lblEditarCliente.Size.Width) / 2);
                int y = lblEditarCliente.Location.Y;
                lblEditarCliente.Location = new Point(x, y);
            }
            else
            {
                //Actualizar registro con el ID pasado

                lblEditarCliente.Text = "EDITAR CLIENTE";
                txtIdCliente.Text = IdCliente.ToString();
                txtNombreCliente.Text = strCliente;
                txtDocumento.Text = strDocumento.ToString();
                txtDireccion.Text = strDireccion;
                txtTelefono.Text = strTelefono;
                txtEmail.Text = strEmail;

                int x = (Convert.ToInt32(Size.Width) / 2) - (Convert.ToInt32(lblEditarCliente.Size.Width) / 2);
                int y = lblEditarCliente.Location.Y;
                lblEditarCliente.Location = new Point(x, y);
            }


        }

        private Boolean Validar()
        {
            Boolean errorCampos = true;

            if (txtNombreCliente.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreCliente, "Debe ingresar el nombre del cliente");
                txtNombreCliente.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtNombreCliente, "");
            }

            if (txtDocumento.Text == string.Empty)
            {
                MensajeError.SetError(txtDocumento, "Debe ingresar documento del cliente");
                txtDocumento.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtDocumento, "");
            }

            if (txtDireccion.Text == string.Empty)
            {
                MensajeError.SetError(txtDireccion, "Debe ingresar la direccion del cliente");
                txtDireccion.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtDireccion, "");
            }

            if (txtTelefono.Text == string.Empty)
            {
                MensajeError.SetError(txtTelefono, "Debe ingresar el telefono del cliente");
                txtTelefono.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtTelefono, "");
            }

            if (txtEmail.Text == string.Empty)
            {
                MensajeError.SetError(txtEmail, "Debe ingresar el E-mail del cliente");
                txtEmail.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtEmail, "");
            }

            if (!esNumerico(txtDocumento.Text))
            {
                MensajeError.SetError(txtDocumento, "El documento debe ser numérico");
                txtDocumento.Focus();
                return false;
            }
            else
            {
                MensajeError.SetError(txtDocumento, "");
            }

            return errorCampos;
        }

        // Funcion para validar si un valor dado es númerico
        private bool esNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Guardar()
        {
            Boolean Actualizar = false;
            if (Validar())
            {
                try
                {
                    clientes.C_IdCliente = IdCliente;
                    clientes.C_Nombre = txtNombreCliente.Text;
                    clientes.C_Documento = Convert.ToDouble(txtDocumento.Text);
                    clientes.C_Direccion = txtDireccion.Text;
                    clientes.C_Telefono = txtTelefono.Text;
                    clientes.C_Email = txtEmail.Text;
                    clientes.C_UsuarioModifica = "Javier";

                    string Mensaje = clientes.ActualizarCliente();
                    MessageBox.Show(Mensaje);
                    Actualizar = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falló la actualización: " + ex);
                    Actualizar = false;
                }
            }
            return Actualizar;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
