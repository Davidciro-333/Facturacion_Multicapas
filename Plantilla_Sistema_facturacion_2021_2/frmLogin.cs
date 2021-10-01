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
    public partial class frmLogin : Form
    {
        clsValidarUsuario clsValidar = new clsValidarUsuario();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != string.Empty || txtPassword.Text != string.Empty)
            {
                clsValidar.C_StrUsuario = txtUsuario.Text;
                clsValidar.C_StrClave = txtPassword.Text;
                clsValidar.ValidarUsuario();

                if (clsValidar.C_IdEmpleado != 0)
                {
                    MessageBox.Show("¡Bienvenidio: " + clsValidar.C_StrUsuario + "! Validación aceptada");
                    frmPrincipal principal = new frmPrincipal();
                    this.Hide();
                    principal.Show();
                }
                else
                {
                    txtUsuario.Text = string.Empty;
                    txtUsuario.Focus();
                    txtPassword.Text = string.Empty;
                    MessageBox.Show("¡ERROR USUARIO Y CONTRASEÑA NO ENCONTRADOS!");
                }
            }
            else
            {
                MessageBox.Show("¡ERROR, Los campos de Usuario y contraseña no deben de estar vacíos!");
                txtUsuario.Focus();
            }

        }
    }
}
