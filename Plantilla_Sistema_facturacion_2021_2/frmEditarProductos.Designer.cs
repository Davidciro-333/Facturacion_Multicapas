
namespace Plantilla_Sistema_facturacion_2021_2
{
    partial class frmEditarProductos
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
            this.gpbDetalles = new System.Windows.Forms.GroupBox();
            this.txtCodReferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCantidadStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.lblDetalles = new MaterialSkin.Controls.MaterialLabel();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtRutaImagen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEditarEmpleado = new System.Windows.Forms.Label();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gpbDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDetalles
            // 
            this.gpbDetalles.Controls.Add(this.txtCodReferencia);
            this.gpbDetalles.Controls.Add(this.txtPrecioCompra);
            this.gpbDetalles.Controls.Add(this.txtPrecioVenta);
            this.gpbDetalles.Controls.Add(this.txtCantidadStock);
            this.gpbDetalles.Controls.Add(this.txtNombreProducto);
            this.gpbDetalles.Controls.Add(this.pictureBox1);
            this.gpbDetalles.Controls.Add(this.lblCategoria);
            this.gpbDetalles.Controls.Add(this.lblDetalles);
            this.gpbDetalles.Controls.Add(this.cmbCategoria);
            this.gpbDetalles.Controls.Add(this.txtRutaImagen);
            this.gpbDetalles.Location = new System.Drawing.Point(88, 120);
            this.gpbDetalles.Name = "gpbDetalles";
            this.gpbDetalles.Size = new System.Drawing.Size(623, 268);
            this.gpbDetalles.TabIndex = 15;
            this.gpbDetalles.TabStop = false;
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
            // txtNombreProducto
            // 
            this.txtNombreProducto.Depth = 0;
            this.txtNombreProducto.Hint = "Nombre producto";
            this.txtNombreProducto.Location = new System.Drawing.Point(15, 25);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(351, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 114);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoria.Location = new System.Drawing.Point(347, 25);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 19);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Depth = 0;
            this.lblDetalles.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDetalles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDetalles.Location = new System.Drawing.Point(347, 112);
            this.lblDetalles.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(152, 19);
            this.lblDetalles.TabIndex = 9;
            this.lblDetalles.Text = "Detalles del producto";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Carne",
            "Papa",
            "Arroz",
            "Plátano"});
            this.cmbCategoria.Location = new System.Drawing.Point(452, 23);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 7;
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.Depth = 0;
            this.txtRutaImagen.Hint = "Ruta imagen";
            this.txtRutaImagen.Location = new System.Drawing.Point(351, 75);
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
            // lblEditarEmpleado
            // 
            this.lblEditarEmpleado.AutoSize = true;
            this.lblEditarEmpleado.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarEmpleado.ForeColor = System.Drawing.Color.Red;
            this.lblEditarEmpleado.Location = new System.Drawing.Point(289, 80);
            this.lblEditarEmpleado.Name = "lblEditarEmpleado";
            this.lblEditarEmpleado.Size = new System.Drawing.Size(221, 28);
            this.lblEditarEmpleado.TabIndex = 16;
            this.lblEditarEmpleado.Text = "EDITAR PRODUCTO";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(264, 394);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(111, 32);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(439, 394);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmEditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblEditarEmpleado);
            this.Controls.Add(this.gpbDetalles);
            this.Name = "frmEditarProductos";
            this.Text = "frmEditarProductos";
            this.gpbDetalles.ResumeLayout(false);
            this.gpbDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDetalles;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodReferencia;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioVenta;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCantidadStock;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private MaterialSkin.Controls.MaterialLabel lblDetalles;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRutaImagen;
        private System.Windows.Forms.Label lblEditarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
    }
}