﻿using System;
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
        frmFacturas facturas = new frmFacturas();
        frmEmpleados empleados = new frmEmpleados();

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
            frmClientesV2 clientesV2 = new frmClientesV2();
            AbrirForm(clientesV2);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            AbrirForm(productos);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias categorias = new frmCategorias();
            AbrirForm(categorias);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmFacturas facturas = new frmFacturas();
            AbrirForm(facturas);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            frmInformeFactura informeFactura = new frmInformeFactura();
            AbrirForm(informeFactura);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados empleados = new frmEmpleados();
            AbrirForm(empleados);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            frmRoles roles = new frmRoles();
            AbrirForm(roles);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            frmSeguridad seguridad = new frmSeguridad();
            AbrirForm(seguridad);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            frmAyuda ayuda = new frmAyuda();
            AbrirForm(ayuda);
        }

        private void tbpMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbpMenu.SelectedIndex)
            {
                case 0:
                    this.pnlContenedor.Visible = false;
                    break;
                case 1:
                    this.pnlContenedor.Visible = true;
                    AbrirForm(clientesV2);
                    break;
                case 2:
                    this.pnlContenedor.Visible = true;
                    AbrirForm(facturas);
                    break;
                case 3:
                    this.pnlContenedor.Visible = true;
                    AbrirForm(empleados);
                    break;
                case 4:
                    this.pnlContenedor.Visible = true;
                    frmAyuda ayuda = new frmAyuda();
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
