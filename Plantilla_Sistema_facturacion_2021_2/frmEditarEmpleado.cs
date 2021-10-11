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
    public partial class frmEditarEmpleado : MaterialForm
    {
        public int IdEmpleado { get; set; }
        public string strEmpleado { get; set; }
        public int NumDocumento { get; set; }
        public string StrDireccion { get; set; }
        public string StrTelefono { get; set; }
        public string strEmail { get; set; }
        public int IdRolEmpleado { get; set; }
        public DateTime DtmIngreso { get; set; }
        public DateTime DtmRetiro { get; set; }
        public string DatosAdicionales { get; set; }

        public frmEditarEmpleado()
        {
            InitializeComponent();
        }

        private void frmEditarEmpleado_Load(object sender, EventArgs e)
        {
            if (IdEmpleado == 0)
            {
                //Registro nuevo
                lblEditarEmpleado.Text = "INGRESO NUEVO EMPLEADO";

                int x = (Convert.ToInt32(Size.Width) / 2) - (Convert.ToInt32(lblEditarEmpleado.Size.Width) / 2);
                int y = lblEditarEmpleado.Location.Y;
                lblEditarEmpleado.Location = new Point(x, y);
            }
            else
            {
                //Actualizar registro con el ID pasado

                lblEditarEmpleado.Text = "EDITAR EMPLEADO";
                txtIdEmpleado.Text = IdEmpleado.ToString();
                txtNombreEmpleado.Text = strEmpleado;
                txtDocumentoEmpleado.Text = NumDocumento.ToString();
                txtDireccionEmpleado.Text = StrDireccion;
                txtTelefonoEmpleado.Text = StrTelefono;
                txtEmailEmpleado.Text = strEmail;
                cmbRolEmpleado.SelectedValue = IdRolEmpleado;
                dtpFechaIngreso.Value = DtmIngreso;
                dtpFechaRetiro.Value = DtmRetiro;

                int x = (Convert.ToInt32(Size.Width) / 2) - (Convert.ToInt32(lblEditarEmpleado.Size.Width) / 2);
                int y = lblEditarEmpleado.Location.Y;
                lblEditarEmpleado.Location = new Point(x, y);
            }
        }
        private Boolean Validar()
        {
            Boolean errorCampos = true;

            if (txtNombreEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreEmpleado, "Debe ingresar el nombre del cliente");
                txtNombreEmpleado.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtNombreEmpleado, "");
            }

            if (txtDocumentoEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtDocumentoEmpleado, "Debe ingresar documento del cliente");
                txtDocumentoEmpleado.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtDocumentoEmpleado, "");
            }

            if (txtDireccionEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtDireccionEmpleado, "Debe ingresar la direccion del cliente");
                txtDireccionEmpleado.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtDireccionEmpleado, "");
            }

            if (txtTelefonoEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtTelefonoEmpleado, "Debe ingresar el telefono del cliente");
                txtTelefonoEmpleado.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtTelefonoEmpleado, "");
            }

            if (txtEmailEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtEmailEmpleado, "Debe ingresar el E-mail del cliente");
                txtEmailEmpleado.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtEmailEmpleado, "");
            }

            if (!esNumerico(txtDocumentoEmpleado.Text))
            {
                MensajeError.SetError(txtDocumentoEmpleado, "El documento debe ser numérico");
                txtDocumentoEmpleado.Focus();
                return false;
            }
            else
            {
                MensajeError.SetError(txtDocumentoEmpleado, "");
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

        public bool Guadar()
        {
            Boolean Actualizado = false;

            return Actualizado;
        }
    }
}
