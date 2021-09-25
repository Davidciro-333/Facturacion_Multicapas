
namespace Plantilla_Sistema_facturacion_2021_2
{
    partial class frmProductos
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
            this.txtNombreProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodReferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCantidadStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblAdminProductos = new MaterialSkin.Controls.MaterialLabel();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtRutaImagen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDetalles = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gpbDetalles = new System.Windows.Forms.GroupBox();
            this.gpbBusProducto = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscarProductos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbDetalles.SuspendLayout();
            this.gpbBusProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Depth = 0;
            this.txtNombreProducto.Hint = "Nombre producto";
            this.txtNombreProducto.Location = new System.Drawing.Point(85, 100);
            this.txtNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PasswordChar = '\0';
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.SelectionLength = 0;
            this.txtNombreProducto.SelectionStart = 0;
            this.txtNombreProducto.Size = new System.Drawing.Size(210, 23);
            this.txtNombreProducto.TabIndex = 0;
            this.txtNombreProducto.UseSystemPasswordChar = false;
            // 
            // txtCodReferencia
            // 
            this.txtCodReferencia.Depth = 0;
            this.txtCodReferencia.Hint = "Codigo referencia";
            this.txtCodReferencia.Location = new System.Drawing.Point(15, 54);
            this.txtCodReferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodReferencia.Name = "txtCodReferencia";
            this.txtCodReferencia.PasswordChar = '\0';
            this.txtCodReferencia.SelectedText = "";
            this.txtCodReferencia.SelectionLength = 0;
            this.txtCodReferencia.SelectionStart = 0;
            this.txtCodReferencia.Size = new System.Drawing.Size(126, 23);
            this.txtCodReferencia.TabIndex = 1;
            this.txtCodReferencia.UseSystemPasswordChar = false;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Depth = 0;
            this.txtPrecioCompra.Hint = "Precio compra";
            this.txtPrecioCompra.Location = new System.Drawing.Point(15, 83);
            this.txtPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.PasswordChar = '\0';
            this.txtPrecioCompra.SelectedText = "";
            this.txtPrecioCompra.SelectionLength = 0;
            this.txtPrecioCompra.SelectionStart = 0;
            this.txtPrecioCompra.Size = new System.Drawing.Size(210, 23);
            this.txtPrecioCompra.TabIndex = 2;
            this.txtPrecioCompra.UseSystemPasswordChar = false;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Depth = 0;
            this.txtPrecioVenta.Hint = "Precio venta";
            this.txtPrecioVenta.Location = new System.Drawing.Point(15, 112);
            this.txtPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.PasswordChar = '\0';
            this.txtPrecioVenta.SelectedText = "";
            this.txtPrecioVenta.SelectionLength = 0;
            this.txtPrecioVenta.SelectionStart = 0;
            this.txtPrecioVenta.Size = new System.Drawing.Size(210, 23);
            this.txtPrecioVenta.TabIndex = 3;
            this.txtPrecioVenta.UseSystemPasswordChar = false;
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Depth = 0;
            this.txtCantidadStock.Hint = "Cantidad stock";
            this.txtCantidadStock.Location = new System.Drawing.Point(15, 141);
            this.txtCantidadStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.PasswordChar = '\0';
            this.txtCantidadStock.SelectedText = "";
            this.txtCantidadStock.SelectionLength = 0;
            this.txtCantidadStock.SelectionStart = 0;
            this.txtCantidadStock.Size = new System.Drawing.Size(126, 23);
            this.txtCantidadStock.TabIndex = 4;
            this.txtCantidadStock.UseSystemPasswordChar = false;
            // 
            // lblAdminProductos
            // 
            this.lblAdminProductos.AutoSize = true;
            this.lblAdminProductos.Depth = 0;
            this.lblAdminProductos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAdminProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAdminProductos.Location = new System.Drawing.Point(369, 10);
            this.lblAdminProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAdminProductos.Name = "lblAdminProductos";
            this.lblAdminProductos.Size = new System.Drawing.Size(246, 19);
            this.lblAdminProductos.TabIndex = 5;
            this.lblAdminProductos.Text = "ADMINISTRACIÓN DE PRODUCTOS";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoria.Location = new System.Drawing.Point(417, 97);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 19);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoría:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Carne",
            "Papa",
            "Arroz",
            "Plátano"});
            this.cmbCategoria.Location = new System.Drawing.Point(522, 97);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 7;
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.Depth = 0;
            this.txtRutaImagen.Hint = "Ruta imagen";
            this.txtRutaImagen.Location = new System.Drawing.Point(421, 146);
            this.txtRutaImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.PasswordChar = '\0';
            this.txtRutaImagen.SelectedText = "";
            this.txtRutaImagen.SelectionLength = 0;
            this.txtRutaImagen.SelectionStart = 0;
            this.txtRutaImagen.Size = new System.Drawing.Size(222, 23);
            this.txtRutaImagen.TabIndex = 8;
            this.txtRutaImagen.UseSystemPasswordChar = false;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Depth = 0;
            this.lblDetalles.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetalles.Location = new System.Drawing.Point(417, 188);
            this.lblDetalles.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(152, 19);
            this.lblDetalles.TabIndex = 9;
            this.lblDetalles.Text = "Detalles del producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(421, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 114);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(760, 200);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(111, 32);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(760, 150);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(111, 32);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(760, 100);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(111, 32);
            this.btnNuevo.TabIndex = 11;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // gpbDetalles
            // 
            this.gpbDetalles.Controls.Add(this.txtCodReferencia);
            this.gpbDetalles.Controls.Add(this.txtPrecioCompra);
            this.gpbDetalles.Controls.Add(this.txtPrecioVenta);
            this.gpbDetalles.Controls.Add(this.txtCantidadStock);
            this.gpbDetalles.Location = new System.Drawing.Point(70, 75);
            this.gpbDetalles.Name = "gpbDetalles";
            this.gpbDetalles.Size = new System.Drawing.Size(623, 268);
            this.gpbDetalles.TabIndex = 14;
            this.gpbDetalles.TabStop = false;
            // 
            // gpbBusProducto
            // 
            this.gpbBusProducto.Controls.Add(this.dataGridView1);
            this.gpbBusProducto.Controls.Add(this.btnBuscarProductos);
            this.gpbBusProducto.Controls.Add(this.txtBuscarProducto);
            this.gpbBusProducto.Location = new System.Drawing.Point(70, 347);
            this.gpbBusProducto.Name = "gpbBusProducto";
            this.gpbBusProducto.Size = new System.Drawing.Size(623, 246);
            this.gpbBusProducto.TabIndex = 15;
            this.gpbBusProducto.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 170);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnBuscarProductos
            // 
            this.btnBuscarProductos.Depth = 0;
            this.btnBuscarProductos.Location = new System.Drawing.Point(500, 20);
            this.btnBuscarProductos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarProductos.Name = "btnBuscarProductos";
            this.btnBuscarProductos.Primary = true;
            this.btnBuscarProductos.Size = new System.Drawing.Size(78, 24);
            this.btnBuscarProductos.TabIndex = 17;
            this.btnBuscarProductos.Text = "BUSCAR";
            this.btnBuscarProductos.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Depth = 0;
            this.txtBuscarProducto.Hint = "Buscar producto";
            this.txtBuscarProducto.Location = new System.Drawing.Point(15, 20);
            this.txtBuscarProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.PasswordChar = '\0';
            this.txtBuscarProducto.SelectedText = "";
            this.txtBuscarProducto.SelectionLength = 0;
            this.txtBuscarProducto.SelectionStart = 0;
            this.txtBuscarProducto.Size = new System.Drawing.Size(476, 23);
            this.txtBuscarProducto.TabIndex = 16;
            this.txtBuscarProducto.UseSystemPasswordChar = false;
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
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 625);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gpbBusProducto);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.txtRutaImagen);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblAdminProductos);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.gpbDetalles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbDetalles.ResumeLayout(false);
            this.gpbBusProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodReferencia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCantidadStock;
        private MaterialSkin.Controls.MaterialLabel lblAdminProductos;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRutaImagen;
        private MaterialSkin.Controls.MaterialLabel lblDetalles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private System.Windows.Forms.GroupBox gpbDetalles;
        private System.Windows.Forms.GroupBox gpbBusProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarProductos;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
    }
}