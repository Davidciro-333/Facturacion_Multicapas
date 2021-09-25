
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
            this.gpbInfoFactura = new System.Windows.Forms.GroupBox();
            this.txtNumeroFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNumeroFactura = new MaterialSkin.Controls.MaterialLabel();
            this.lblCliente = new MaterialSkin.Controls.MaterialLabel();
            this.lblEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTotalIVA = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTotalFactura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblFechaRegistro = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblEstadoFactura = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gpbDetalleFactura = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gpbInfoFactura.SuspendLayout();
            this.gpbDetalleFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // gpbInfoFactura
            // 
            this.gpbInfoFactura.Controls.Add(this.lblEstadoFactura);
            this.gpbInfoFactura.Controls.Add(this.dtpFechaRegistro);
            this.gpbInfoFactura.Controls.Add(this.lblFechaRegistro);
            this.gpbInfoFactura.Controls.Add(this.cmbEmpleado);
            this.gpbInfoFactura.Controls.Add(this.cmbCliente);
            this.gpbInfoFactura.Controls.Add(this.txtTotalFactura);
            this.gpbInfoFactura.Controls.Add(this.txtTotalIVA);
            this.gpbInfoFactura.Controls.Add(this.txtDescuento);
            this.gpbInfoFactura.Controls.Add(this.lblEmpleado);
            this.gpbInfoFactura.Controls.Add(this.lblCliente);
            this.gpbInfoFactura.Controls.Add(this.txtNumeroFactura);
            this.gpbInfoFactura.Controls.Add(this.lblNumeroFactura);
            this.gpbInfoFactura.Location = new System.Drawing.Point(70, 75);
            this.gpbInfoFactura.Name = "gpbInfoFactura";
            this.gpbInfoFactura.Size = new System.Drawing.Size(623, 268);
            this.gpbInfoFactura.TabIndex = 1;
            this.gpbInfoFactura.TabStop = false;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumeroFactura.Depth = 0;
            this.txtNumeroFactura.Hint = "";
            this.txtNumeroFactura.Location = new System.Drawing.Point(110, 25);
            this.txtNumeroFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.PasswordChar = '\0';
            this.txtNumeroFactura.SelectedText = "";
            this.txtNumeroFactura.SelectionLength = 0;
            this.txtNumeroFactura.SelectionStart = 0;
            this.txtNumeroFactura.Size = new System.Drawing.Size(71, 23);
            this.txtNumeroFactura.TabIndex = 1;
            this.txtNumeroFactura.UseSystemPasswordChar = false;
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Depth = 0;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNumeroFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumeroFactura.Location = new System.Drawing.Point(15, 25);
            this.lblNumeroFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(89, 19);
            this.lblNumeroFactura.TabIndex = 0;
            this.lblNumeroFactura.Text = "Nro factura ";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Depth = 0;
            this.lblCliente.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCliente.Location = new System.Drawing.Point(15, 54);
            this.lblCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(56, 19);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Depth = 0;
            this.lblEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmpleado.Location = new System.Drawing.Point(15, 83);
            this.lblEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(76, 19);
            this.lblEmpleado.TabIndex = 3;
            this.lblEmpleado.Text = "Empleado";
            // 
            // txtDescuento
            // 
            this.txtDescuento.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Hint = "Descuento";
            this.txtDescuento.Location = new System.Drawing.Point(15, 112);
            this.txtDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.PasswordChar = '\0';
            this.txtDescuento.SelectedText = "";
            this.txtDescuento.SelectionLength = 0;
            this.txtDescuento.SelectionStart = 0;
            this.txtDescuento.Size = new System.Drawing.Size(89, 23);
            this.txtDescuento.TabIndex = 6;
            this.txtDescuento.UseSystemPasswordChar = false;
            // 
            // txtTotalIVA
            // 
            this.txtTotalIVA.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalIVA.Depth = 0;
            this.txtTotalIVA.Hint = "Total IVA";
            this.txtTotalIVA.Location = new System.Drawing.Point(15, 141);
            this.txtTotalIVA.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotalIVA.Name = "txtTotalIVA";
            this.txtTotalIVA.PasswordChar = '\0';
            this.txtTotalIVA.SelectedText = "";
            this.txtTotalIVA.SelectionLength = 0;
            this.txtTotalIVA.SelectionStart = 0;
            this.txtTotalIVA.Size = new System.Drawing.Size(89, 23);
            this.txtTotalIVA.TabIndex = 7;
            this.txtTotalIVA.UseSystemPasswordChar = false;
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalFactura.Depth = 0;
            this.txtTotalFactura.Hint = "Total factura";
            this.txtTotalFactura.Location = new System.Drawing.Point(15, 170);
            this.txtTotalFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.PasswordChar = '\0';
            this.txtTotalFactura.SelectedText = "";
            this.txtTotalFactura.SelectionLength = 0;
            this.txtTotalFactura.SelectionStart = 0;
            this.txtTotalFactura.Size = new System.Drawing.Size(89, 23);
            this.txtTotalFactura.TabIndex = 8;
            this.txtTotalFactura.UseSystemPasswordChar = false;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(110, 54);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(248, 21);
            this.cmbCliente.TabIndex = 4;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(110, 83);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(248, 21);
            this.cmbEmpleado.TabIndex = 5;
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Depth = 0;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaRegistro.Location = new System.Drawing.Point(458, 25);
            this.lblFechaRegistro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(105, 19);
            this.lblFechaRegistro.TabIndex = 9;
            this.lblFechaRegistro.Text = "Fecha registro";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(462, 48);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(101, 20);
            this.dtpFechaRegistro.TabIndex = 10;
            // 
            // lblEstadoFactura
            // 
            this.lblEstadoFactura.AutoSize = true;
            this.lblEstadoFactura.Depth = 0;
            this.lblEstadoFactura.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstadoFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstadoFactura.Location = new System.Drawing.Point(458, 82);
            this.lblEstadoFactura.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstadoFactura.Name = "lblEstadoFactura";
            this.lblEstadoFactura.Size = new System.Drawing.Size(107, 19);
            this.lblEstadoFactura.TabIndex = 11;
            this.lblEstadoFactura.Text = "Estado factura";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(532, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(760, 150);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(111, 32);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(760, 100);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(111, 32);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // gpbDetalleFactura
            // 
            this.gpbDetalleFactura.Controls.Add(this.dataGridView1);
            this.gpbDetalleFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDetalleFactura.Location = new System.Drawing.Point(70, 347);
            this.gpbDetalleFactura.Name = "gpbDetalleFactura";
            this.gpbDetalleFactura.Size = new System.Drawing.Size(623, 246);
            this.gpbDetalleFactura.TabIndex = 15;
            this.gpbDetalleFactura.TabStop = false;
            this.gpbDetalleFactura.Text = "DETALLE FACTURA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(582, 203);
            this.dataGridView1.TabIndex = 0;
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
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 625);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gpbDetalleFactura);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gpbInfoFactura);
            this.Controls.Add(this.lblTituloFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturas";
            this.Text = "frmFacturas";
            this.gpbInfoFactura.ResumeLayout(false);
            this.gpbInfoFactura.PerformLayout();
            this.gpbDetalleFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloFacturas;
        private System.Windows.Forms.GroupBox gpbInfoFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumeroFactura;
        private MaterialSkin.Controls.MaterialLabel lblNumeroFactura;
        private MaterialSkin.Controls.MaterialLabel lblCliente;
        private MaterialSkin.Controls.MaterialLabel lblEmpleado;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotalFactura;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotalIVA;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescuento;
        private MaterialSkin.Controls.MaterialLabel lblEstadoFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private MaterialSkin.Controls.MaterialLabel lblFechaRegistro;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private System.Windows.Forms.GroupBox gpbDetalleFactura;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
    }
}