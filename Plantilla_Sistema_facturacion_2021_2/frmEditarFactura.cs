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
    public partial class frmEditarFactura : MaterialForm
    {
        //DEFINIMOS LOS ATRIBUTOS DE LA CLASE
        public int IdFactura { get; set; }
        public DateTime DtmFecha { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public float NumDescuento { get; set; }
        public float NumImpuesto { get; set; }
        public float NumValorTotal { get; set; }
        public int IdEstado { get; set; }
        public string StrUsuarioModifica { get; set; }

        clsFacturas facturas = new clsFacturas();

        public frmEditarFactura()
        {
            InitializeComponent();
        }

        private Boolean Validar()
        {
            Boolean errorCampos = true;

            if (txtNumeroFactura.Text == string.Empty)
            {
                MensajeError.SetError(txtNumeroFactura, "Debe ingresar el nombre del producto");
                txtNumeroFactura.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtNumeroFactura, "");
            }

            if (txtDescuento.Text == string.Empty)
            {
                MensajeError.SetError(txtDescuento, "Debe ingresar Código de referencia");
                txtDescuento.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtDescuento, "");
            }

            if (txtTotalIVA.Text == string.Empty)
            {
                MensajeError.SetError(txtTotalIVA, "Debe ingresar el precio de compra");
                txtTotalIVA.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtTotalIVA, "");
            }

            if (txtTotalFactura.Text == string.Empty)
            {
                MensajeError.SetError(txtTotalFactura, "Debe ingresar el precio de venta");
                txtTotalFactura.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtTotalFactura, "");
            }

            if (!esNumerico(txtNumeroFactura.Text))
            {
                MensajeError.SetError(txtNumeroFactura, "El numero de factura debe ser númerica");
                txtNumeroFactura.Focus();
                return false;
            }
            else
            {
                MensajeError.SetError(txtNumeroFactura, "");
            }

            if (!esNumerico(txtDescuento.Text))
            {
                MensajeError.SetError(txtDescuento, "El descuento debe ser númerico");
                txtDescuento.Focus();
                return false;
            }
            else
            {
                MensajeError.SetError(txtDescuento, "");
            }

            if (!esNumerico(txtTotalIVA.Text))
            {
                MensajeError.SetError(txtTotalIVA, "El IVA debe ser númerico");
                txtTotalIVA.Focus();
                return false;
            }
            else
            {
                MensajeError.SetError(txtTotalIVA, "");
            }

            if (!esNumerico(txtTotalFactura.Text))
            {
                MensajeError.SetError(txtTotalFactura, "El total de la factura debe ser númerica");
                txtTotalFactura.Focus();
                return false;
            }
            else
            {
                MensajeError.SetError(txtTotalFactura, "");
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

        private void LlenarComboCliente(string filtro = "")
        {
            // LLENAMOS EL COMBOBOX CON LOS DATOS DE SEGURIDAD DE LOS EMPLEADOS
            try
            {
                cmbCliente.DataSource = null;
                cmbCliente.Items.Clear();
                DataTable dt = facturas.ConsultarFactura("TBLCLIENTES", filtro);
                cmbCliente.DataSource = dt;
                cmbCliente.DisplayMember = "StrNombre";
                cmbCliente.ValueMember = "IdCliente";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR LOS DATOS " + ex);
            }
        }

        private void LlenarComboEmpleado(string filtro = "")
        {
            // LLENAMOS EL COMBOBOX CON LOS DATOS DE SEGURIDAD DE LOS EMPLEADOS
            try
            {
                cmbEmpleado.DataSource = null;
                cmbEmpleado.Items.Clear();
                DataTable datat = facturas.ConsultarFactura("TBLEMPLEADO", filtro);
                cmbEmpleado.DataSource = datat;
                cmbEmpleado.DisplayMember = "strNombre";
                cmbEmpleado.ValueMember = "IdEmpleado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR LOS DATOS " + ex);
            }
        }

        private void LlenarComboEstado(string filtro = "")
        {
            // LLENAMOS EL COMBOBOX CON LOS DATOS DE SEGURIDAD DE LOS EMPLEADOS
            try
            {
                cmbEstado.DataSource = null;
                cmbEstado.Items.Clear();
                DataTable dtable = facturas.ConsultarFactura("TBLESTADO_FACTURA", filtro);
                cmbEstado.DataSource = dtable;
                cmbEstado.DisplayMember = "StrDescripcion";
                cmbEstado.ValueMember = "IdEstadoFactura";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR LOS DATOS " + ex);
            }
        }

        private void frmEditarFactura_Load(object sender, EventArgs e)
        {
            LlenarComboCliente();
            LlenarComboEmpleado();
            LlenarComboEstado();

            if (IdFactura == 0)
            {
                //Registro nuevo
                lblTitulo.Text = "INGRESO NUEVO PRODUCTO";

                int x = (Convert.ToInt32(Size.Width) / 2) - (Convert.ToInt32(lblTitulo.Size.Width) / 2);
                int y = lblTitulo.Location.Y;
                lblTitulo.Location = new Point(x, y);
            }
            else
            {
                //Actualizar registro con el ID pasado
                lblTitulo.Text = "EDITAR PRODUCTO";
                txtNumeroFactura.Text = IdFactura.ToString();
                cmbCliente.SelectedValue = IdCliente;
                cmbEmpleado.SelectedValue = IdEmpleado;
                txtDescuento.Text = NumDescuento.ToString();
                txtTotalIVA.Text = NumImpuesto.ToString();
                txtTotalFactura.Text = NumValorTotal.ToString();
                cmbEstado.SelectedValue = IdEstado;
                StrUsuarioModifica = "Javier";

                int x = (Convert.ToInt32(Size.Width) / 2) - (Convert.ToInt32(lblTitulo.Size.Width) / 2);
                int y = lblTitulo.Location.Y;
                lblTitulo.Location = new Point(x, y);
            }
        }

        public bool Guardar()
    {
            Boolean Actualizado = false;
            if (Validar())
            {
                try
                {
                    facturas.C_IdFactura = IdFactura;
                    facturas.C_IdCliente = Convert.ToInt32(cmbCliente.SelectedValue);
                    facturas.C_IdEmpleado = Convert.ToInt32(cmbEmpleado.SelectedValue);
                    facturas.C_NumDescuento = float.Parse(txtDescuento.Text);
                    facturas.C_NumImpuesto = float.Parse(txtTotalIVA.Text);
                    facturas.C_NumValorTotal = float.Parse(txtTotalFactura.Text);
                    facturas.C_DtmFecha = dtpFechaRegistro.Value;
                    facturas.C_IdEstado = Convert.ToInt32(cmbEstado.SelectedValue);
                    facturas.C_StrUsuarioModifica = "Javier";

                    string Mensaje = facturas.ActualizarFactura();
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
            Guardar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
