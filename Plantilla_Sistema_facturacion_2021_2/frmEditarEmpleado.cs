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
        public string UsuarioModifica { get; set; }

        clsEmpleado empleado = new clsEmpleado();
        public frmEditarEmpleado()
        {
            InitializeComponent();
        }

        private Boolean Validar()
        {
            Boolean errorCampos = true;

            if (txtNombreEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreEmpleado, "Debe ingresar el nombre del empleado");
                txtNombreEmpleado.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtNombreEmpleado, "");
            }

            if (txtDocumentoEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtDocumentoEmpleado, "Debe ingresar documento del empleado");
                txtDocumentoEmpleado.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtDocumentoEmpleado, "");
            }

            if (txtDireccionEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtDireccionEmpleado, "Debe ingresar la direccion del empleado");
                txtDireccionEmpleado.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtDireccionEmpleado, "");
            }

            if (txtTelefonoEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtTelefonoEmpleado, "Debe ingresar el telefono del empleado");
                txtTelefonoEmpleado.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtTelefonoEmpleado, "");
            }

            if (txtEmailEmpleado.Text == string.Empty)
            {
                MensajeError.SetError(txtEmailEmpleado, "Debe ingresar el E-mail del empleado");
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

        private void LlenarComboEmpleados(string filtro = "")
        {
            // LLENAMOS EL COMBOBOX CON LOS DATOS DE SEGURIDAD DE LOS EMPLEADOS
            try
            {
                cmbRolEmpleado.Items.Clear();
                DataTable dt = empleado.ConsultarEmpleado("TBLROLES", filtro);
                cmbRolEmpleado.DataSource = dt;
                cmbRolEmpleado.DisplayMember = "StrDescripcion";
                cmbRolEmpleado.ValueMember = "IdRolEmpleado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGA LOS DATOS " + ex);
            }
        }

        private void frmEditarEmpleado_Load(object sender, EventArgs e)
        {
            LlenarComboEmpleados();
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
                txtDatosAdicionales.Text = DatosAdicionales;


                int x = (Convert.ToInt32(Size.Width) / 2) - (Convert.ToInt32(lblEditarEmpleado.Size.Width) / 2);
                int y = lblEditarEmpleado.Location.Y;
                lblEditarEmpleado.Location = new Point(x, y);
            }
        }
        public bool Guadar()
        {
            Boolean Actualizado = false;
            if (Validar())
            {
                try
                {
                    empleado.C_IdEmpleado = IdEmpleado;
                    empleado.C_Empleado = txtNombreEmpleado.Text;
                    empleado.C_Documento = Convert.ToInt32(txtDocumentoEmpleado.Text);
                    empleado.C_Direccion = txtDireccionEmpleado.Text;
                    empleado.C_Telefono = txtTelefonoEmpleado.Text;
                    empleado.C_Email = txtEmailEmpleado.Text;
                    empleado.C_IdRolEmpleado = Convert.ToInt32(cmbRolEmpleado.SelectedValue);
                    empleado.C_DtmIngreso = dtpFechaIngreso.Value;
                    empleado.C_DtmRetiro = dtpFechaRetiro.Value;
                    empleado.C_DatosAdicionales = txtDatosAdicionales.Text;
                    empleado.C_UsuarioModifica = "Javier";

                    string Mensaje = empleado.ActualizarEmpleado();
                    MessageBox.Show(Mensaje);
                    Actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falló la actualización " + ex);
                    Actualizado = false;
                }
            }
            return Actualizado;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guadar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
