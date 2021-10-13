
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
            this.lblAdminProductos = new MaterialSkin.Controls.MaterialLabel();
            this.gpbBusProducto = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.btnBuscarProductos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strFoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gpbBusProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
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
            // gpbBusProducto
            // 
            this.gpbBusProducto.Controls.Add(this.btnNuevo);
            this.gpbBusProducto.Controls.Add(this.dgProductos);
            this.gpbBusProducto.Controls.Add(this.btnBuscarProductos);
            this.gpbBusProducto.Controls.Add(this.txtBuscarProducto);
            this.gpbBusProducto.Location = new System.Drawing.Point(12, 115);
            this.gpbBusProducto.Name = "gpbBusProducto";
            this.gpbBusProducto.Size = new System.Drawing.Size(906, 311);
            this.gpbBusProducto.TabIndex = 15;
            this.gpbBusProducto.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(616, 20);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(78, 24);
            this.btnNuevo.TabIndex = 19;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgProductos
            // 
            this.dgProductos.AllowUserToAddRows = false;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.StrNombre,
            this.StrCodigo,
            this.NumPrecioCompra,
            this.NumPrecioVenta,
            this.IdCategoria,
            this.StrDetalle,
            this.strFoto,
            this.NumStock,
            this.btnEditar,
            this.btnBorrar});
            this.dgProductos.Location = new System.Drawing.Point(15, 50);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.Size = new System.Drawing.Size(885, 227);
            this.dgProductos.TabIndex = 18;
            this.dgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellContentClick);
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
            this.btnBuscarProductos.Click += new System.EventHandler(this.btnBuscarProductos_Click);
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
            // IdProducto
            // 
            this.IdProducto.HeaderText = "ID";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Width = 35;
            // 
            // StrNombre
            // 
            this.StrNombre.HeaderText = "PRODUCTO";
            this.StrNombre.Name = "StrNombre";
            this.StrNombre.ReadOnly = true;
            this.StrNombre.Width = 120;
            // 
            // StrCodigo
            // 
            this.StrCodigo.HeaderText = "CODIGO";
            this.StrCodigo.Name = "StrCodigo";
            this.StrCodigo.ReadOnly = true;
            this.StrCodigo.Width = 60;
            // 
            // NumPrecioCompra
            // 
            this.NumPrecioCompra.HeaderText = "PRECIO COMPRA";
            this.NumPrecioCompra.Name = "NumPrecioCompra";
            this.NumPrecioCompra.ReadOnly = true;
            this.NumPrecioCompra.Width = 80;
            // 
            // NumPrecioVenta
            // 
            this.NumPrecioVenta.HeaderText = "PRECIO VENTA";
            this.NumPrecioVenta.Name = "NumPrecioVenta";
            this.NumPrecioVenta.ReadOnly = true;
            this.NumPrecioVenta.Width = 80;
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "CATEGORIA";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Width = 75;
            // 
            // StrDetalle
            // 
            this.StrDetalle.HeaderText = "DETALLE";
            this.StrDetalle.Name = "StrDetalle";
            this.StrDetalle.ReadOnly = true;
            // 
            // strFoto
            // 
            this.strFoto.HeaderText = "FOTO";
            this.strFoto.Name = "strFoto";
            this.strFoto.ReadOnly = true;
            // 
            // NumStock
            // 
            this.NumStock.HeaderText = "STOCK";
            this.NumStock.Name = "NumStock";
            this.NumStock.ReadOnly = true;
            this.NumStock.Width = 50;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 70;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.ReadOnly = true;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            this.btnBorrar.Width = 70;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 625);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gpbBusProducto);
            this.Controls.Add(this.lblAdminProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.gpbBusProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblAdminProductos;
        private System.Windows.Forms.GroupBox gpbBusProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarProducto;
        private System.Windows.Forms.DataGridView dgProductos;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarProductos;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn strFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumStock;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}