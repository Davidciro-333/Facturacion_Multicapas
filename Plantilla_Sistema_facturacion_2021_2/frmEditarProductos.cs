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
    public partial class frmEditarProductos : MaterialForm
    {
        public int IdProducto { get; set; }
        public string StrNombre { get; set; }
        public string StrCodigo { get; set; }
        public float NumPrecioCompra { get; set; }
        public float NumPrecioVenta { get; set; }
        public int IdCategoria { get; set; }
        public string StrDetalle { get; set; }
        public string strFoto { get; set; }
        public int NumStock { get; set; }
        public string StrUsuarioModifica { get; set; }

        clsProductos productos = new clsProductos();

        public frmEditarProductos()
        {
            InitializeComponent();
        }

        private Boolean Validar()
        {
            Boolean errorCampos = true;

            if (txtNombreProducto.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreProducto, "Debe ingresar el nombre del producto");
                txtNombreProducto.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtNombreProducto, "");
            }

            if (txtCodReferencia.Text == string.Empty)
            {
                MensajeError.SetError(txtCodReferencia, "Debe ingresar Código de referencia");
                txtCodReferencia.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtCodReferencia, "");
            }

            if (txtPrecioCompra.Text == string.Empty)
            {
                MensajeError.SetError(txtPrecioCompra, "Debe ingresar el precio de compra");
                txtPrecioCompra.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtPrecioCompra, "");
            }

            if (txtPrecioVenta.Text == string.Empty)
            {
                MensajeError.SetError(txtPrecioVenta, "Debe ingresar el precio de venta");
                txtPrecioVenta.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtPrecioVenta, "");
            }

            if (txtCantidadStock.Text == string.Empty)
            {
                MensajeError.SetError(txtCantidadStock, "Debe ingresar la cantidad en Stock");
                txtCantidadStock.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtCantidadStock, "");
            }

            if (txtRutaImagen.Text == string.Empty)
            {
                MensajeError.SetError(txtRutaImagen, "Debe ingresar la ruta de la imagen");
                txtRutaImagen.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtCantidadStock, "");
            }

            if (!esNumerico(txtCodReferencia.Text))
            {
                MensajeError.SetError(txtCodReferencia, "El código de referencia debe ser númerico");
                txtCodReferencia.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtCodReferencia, "");
            }

            if (!esNumerico(txtPrecioCompra.Text))
            {
                MensajeError.SetError(txtPrecioCompra, "El precio de compra debe ser númerico");
                txtPrecioCompra.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtPrecioCompra, "");
            }

            if (!esNumerico(txtPrecioVenta.Text))
            {
                MensajeError.SetError(txtPrecioVenta, "El precio de venta debe ser númerico");
                txtPrecioVenta.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtPrecioVenta, "");
            }

            if (!esNumerico(txtCantidadStock.Text))
            {
                MensajeError.SetError(txtCantidadStock, "La cantidad en Stock debe ser númerica");
                txtCantidadStock.Focus();
                errorCampos = false;
            }
            else
            {
                MensajeError.SetError(txtCantidadStock, "");
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

        private void LlenarComboCategoria(string filtro = "")
        {
            // LLENAMOS EL COMBOBOX CON LOS DATOS DE SEGURIDAD DE LOS EMPLEADOS
            try
            {
                cmbCategoria.Items.Clear();
                DataTable dt = productos.ConsultarProducto("TBLCATEGORIA_PROD", filtro);
                cmbCategoria.DataSource = dt;
                cmbCategoria.DisplayMember = "StrDescripcion";
                cmbCategoria.ValueMember = "IdCategoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR LOS DATOS " + ex);
            }
        }

        private void frmEditarProductos_Load(object sender, EventArgs e)
        {
            LlenarComboCategoria();
            if (IdProducto == 0)
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
                txtIdProducto.Text = IdProducto.ToString();
                txtNombreProducto.Text = StrNombre;
                txtCodReferencia.Text = StrCodigo;
                txtPrecioCompra.Text = NumPrecioCompra.ToString();
                txtPrecioVenta.Text = NumPrecioVenta.ToString();
                txtCantidadStock.Text = NumStock.ToString();
                txtDetalleProducto.Text = StrDetalle;
                cmbCategoria.SelectedValue = IdCategoria;
                txtRutaImagen.Text = strFoto;
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
                    productos.C_IdProducto = IdProducto;
                    productos.C_StrNombre = txtNombreProducto.Text;
                    productos.C_StrCodigo = txtCodReferencia.Text;
                    productos.C_NumPrecioCompra = float.Parse(txtPrecioCompra.Text);
                    productos.C_NumPrecioVenta = float.Parse(txtPrecioVenta.Text);
                    productos.C_IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                    productos.C_StrDetalle = txtDetalleProducto.Text;
                    productos.C_strFoto = txtRutaImagen.Text;
                    productos.C_NumStock = Convert.ToInt32(txtCantidadStock.Text);
                    productos.C_StrUsuarioModifica = "Javier";

                    string Mensaje = productos.ActualizarProducto();
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



        /* 
* 
* 
* 
* 
* 
* 
* 
* 
* 
* 
* 
* 
* 
* 
* 
* 
* 
* 
* 
* 
* 
* 
* 
* david     esta     viajandoaon    demarsial
* 
*/
    }
}