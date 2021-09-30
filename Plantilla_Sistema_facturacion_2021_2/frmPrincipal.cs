using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Plantilla_Sistema_facturacion_2021_2
{
    public partial class frmPrincipal : MaterialForm
    {
        frmClientesV2 clientesV2 = new frmClientesV2();
        frmProductos productos = new frmProductos();
        frmCategorias categorias = new frmCategorias();
        frmFacturas facturas = new frmFacturas();
        frmInformeFactura informeFactura = new frmInformeFactura();
        frmEmpleados empleados = new frmEmpleados();
        frmRoles roles = new frmRoles();
        frmSeguridad seguridad = new frmSeguridad();
        frmAyuda ayuda = new frmAyuda();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirForm(Form formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            /*frmClientes clientes = new frmClientes();
            AbrirForm(clientes);*/

            AbrirForm(clientesV2);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirForm(productos);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirForm(categorias);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            AbrirForm(facturas);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            AbrirForm(informeFactura);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirForm(empleados);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            AbrirForm(roles);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            AbrirForm(seguridad);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AbrirForm(ayuda);
        }

        private void tbpMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbpMenu.SelectedIndex)
            {
                case 1:
                    AbrirForm(clientesV2);
                    break;
                case 2:
                    AbrirForm(facturas);
                    break;
                case 3:
                    AbrirForm(empleados);
                    break;
                case 4:
                    AbrirForm(ayuda);
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
