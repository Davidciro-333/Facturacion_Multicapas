
namespace Plantilla_Sistema_facturacion_2021_2
{
    partial class frmFacturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTituloFacturas = new MaterialSkin.Controls.MaterialLabel();
            this.gpbDetalleFactura = new System.Windows.Forms.GroupBox();
            this.dgFacturas = new System.Windows.Forms.DataGridView();
            this.NroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gpbDetalleFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloFacturas
            // 
            this.lblTituloFacturas.AutoSize = true;
            this.lblTituloFacturas.Depth = 0;
            this.lblTituloFacturas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloFacturas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloFacturas.Location = new System.Drawing.Point(359, 10);
            this.lblTituloFacturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloFacturas.Name = "lblTituloFacturas";
            this.lblTituloFacturas.Size = new System.Drawing.Size(212, 19);
            this.lblTituloFacturas.TabIndex = 0;
            this.lblTituloFacturas.Text = "ADMINISTRACIÓN FACTURAS";
            // 
            // gpbDetalleFactura
            // 
            this.gpbDetalleFactura.Controls.Add(this.dgFacturas);
            this.gpbDetalleFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDetalleFactura.Location = new System.Drawing.Point(12, 97);
            this.gpbDetalleFactura.Name = "gpbDetalleFactura";
            this.gpbDetalleFactura.Size = new System.Drawing.Size(906, 311);
            this.gpbDetalleFactura.TabIndex = 15;
            this.gpbDetalleFactura.TabStop = false;
            this.gpbDetalleFactura.Text = "DETALLE FACTURA";
            // 
            // dgFacturas
            // 
            this.dgFacturas.AllowUserToAddRows = false;
            this.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroFactura,
            this.DtmFecha,
            this.IdCliente,
            this.IdEmpleado,
            this.NumDescuento,
            this.NumImpuesto,
            this.NumValorTotal,
            this.IdEstado,
            this.btnEditar});
            this.dgFacturas.Location = new System.Drawing.Point(15, 22);
            this.dgFacturas.Name = "dgFacturas";
            this.dgFacturas.Size = new System.Drawing.Size(885, 265);
            this.dgFacturas.TabIndex = 0;
            this.dgFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFacturas_CellContentClick);
            // 
            // NroFactura
            // 
            this.NroFactura.HeaderText = "NRO FACTURA";
            this.NroFactura.Name = "NroFactura";
            this.NroFactura.ReadOnly = true;
            this.NroFactura.Width = 80;
            // 
            // DtmFecha
            // 
            this.DtmFecha.HeaderText = "FECHA";
            this.DtmFecha.Name = "DtmFecha";
            this.DtmFecha.ReadOnly = true;
            this.DtmFecha.Width = 130;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "ID CLIENTE";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Width = 70;
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.HeaderText = "ID EMPLEADO";
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.ReadOnly = true;
            this.IdEmpleado.Width = 90;
            // 
            // NumDescuento
            // 
            this.NumDescuento.HeaderText = "DESCUENTO";
            this.NumDescuento.Name = "NumDescuento";
            this.NumDescuento.ReadOnly = true;
            // 
            // NumImpuesto
            // 
            this.NumImpuesto.HeaderText = "IMPUESTO";
            this.NumImpuesto.Name = "NumImpuesto";
            this.NumImpuesto.ReadOnly = true;
            // 
            // NumValorTotal
            // 
            this.NumValorTotal.HeaderText = "VALOR TOTAL ";
            this.NumValorTotal.Name = "NumValorTotal";
            this.NumValorTotal.ReadOnly = true;
            // 
            // IdEstado
            // 
            this.IdEstado.HeaderText = "ID ESTADO";
            this.IdEstado.Name = "IdEstado";
            this.IdEstado.ReadOnly = true;
            this.IdEstado.Width = 70;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 80;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(780, 534);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(777, 67);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(78, 24);
            this.btnNuevo.TabIndex = 20;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 625);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gpbDetalleFactura);
            this.Controls.Add(this.lblTituloFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturas";
            this.Text = "frmFacturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.gpbDetalleFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloFacturas;
        private System.Windows.Forms.GroupBox gpbDetalleFactura;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumValorTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEstado;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridView dgFacturas;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
    }
}