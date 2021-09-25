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
    public partial class frmEditarCliente : Form
    {
        public int IdCliente { get; set; }
        public string strCliente { get; set; }
        public string strDocumento { get; set; }
        public string strTelefono { get; set; }
        public string strDireccion { get; set; }
        public string strEmail { get; set; }

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

                lblEditarCliente.Text = "MODIFICAR CLIENTE";
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
