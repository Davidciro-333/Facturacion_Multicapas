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
        public string strDocumento { get; set; }
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
            frmEditarCliente editarCliente = new frmEditarCliente();
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
                    txtDocumento.Text = strDocumento;
                    txtDireccion.Text = strDireccion;
                    txtTelefono.Text = strTelefono;
                    txtEmail.Text = strEmail;

                int x = (Convert.ToInt32(Size.Width) / 2) - (Convert.ToInt32(lblEditarCliente.Size.Width) / 2);
                int y = lblEditarCliente.Location.Y;
                lblEditarCliente.Location = new Point(x, y);
            }


        }

        public bool Guardar()
        {
            Boolean Actualizar = false;
            if (true)
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
