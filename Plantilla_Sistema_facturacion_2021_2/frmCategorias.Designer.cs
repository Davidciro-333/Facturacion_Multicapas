
namespace Plantilla_Sistema_facturacion_2021_2
{
    partial class frmCategorias
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
            this.lblCategorias = new MaterialSkin.Controls.MaterialLabel();
            this.gbpDetalleCategoria = new System.Windows.Forms.GroupBox();
            this.txtCodigoCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gbpBuscarCategoria = new System.Windows.Forms.GroupBox();
            this.dgCategorias = new System.Windows.Forms.DataGridView();
            this.btnBuscarCategoria = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gbpDetalleCategoria.SuspendLayout();
            this.gbpBuscarCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Depth = 0;
            this.lblCategorias.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategorias.Location = new System.Drawing.Point(359, 13);
            this.lblCategorias.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(212, 19);
            this.lblCategorias.TabIndex = 0;
            this.lblCategorias.Text = "CATEGORIAS DE PRODUCTOS";
            // 
            // gbpDetalleCategoria
            // 
            this.gbpDetalleCategoria.Controls.Add(this.txtNombreCategoria);
            this.gbpDetalleCategoria.Controls.Add(this.txtCodigoCategoria);
            this.gbpDetalleCategoria.Location = new System.Drawing.Point(70, 75);
            this.gbpDetalleCategoria.Name = "gbpDetalleCategoria";
            this.gbpDetalleCategoria.Size = new System.Drawing.Size(623, 268);
            this.gbpDetalleCategoria.TabIndex = 1;
            this.gbpDetalleCategoria.TabStop = false;
            // 
            // txtCodigoCategoria
            // 
            this.txtCodigoCategoria.Depth = 0;
            this.txtCodigoCategoria.Hint = "Código categoría";
            this.txtCodigoCategoria.Location = new System.Drawing.Point(15, 25);
            this.txtCodigoCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigoCategoria.Name = "txtCodigoCategoria";
            this.txtCodigoCategoria.PasswordChar = '\0';
            this.txtCodigoCategoria.SelectedText = "";
            this.txtCodigoCategoria.SelectionLength = 0;
            this.txtCodigoCategoria.SelectionStart = 0;
            this.txtCodigoCategoria.Size = new System.Drawing.Size(124, 23);
            this.txtCodigoCategoria.TabIndex = 2;
            this.txtCodigoCategoria.UseSystemPasswordChar = false;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Depth = 0;
            this.txtNombreCategoria.Hint = "Nombre categoría";
            this.txtNombreCategoria.Location = new System.Drawing.Point(15, 54);
            this.txtNombreCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.PasswordChar = '\0';
            this.txtNombreCategoria.SelectedText = "";
            this.txtNombreCategoria.SelectionLength = 0;
            this.txtNombreCategoria.SelectionStart = 0;
            this.txtNombreCategoria.Size = new System.Drawing.Size(300, 23);
            this.txtNombreCategoria.TabIndex = 3;
            this.txtNombreCategoria.UseSystemPasswordChar = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(760, 200);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = true;
            this.btnEliminar.Size = new System.Drawing.Size(111, 32);
            this.btnEliminar.TabIndex = 11;
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
            this.btnActualizar.TabIndex = 10;
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
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // gbpBuscarCategoria
            // 
            this.gbpBuscarCategoria.Controls.Add(this.dgCategorias);
            this.gbpBuscarCategoria.Controls.Add(this.btnBuscarCategoria);
            this.gbpBuscarCategoria.Controls.Add(this.txtBuscarCategoria);
            this.gbpBuscarCategoria.Location = new System.Drawing.Point(70, 350);
            this.gbpBuscarCategoria.Name = "gbpBuscarCategoria";
            this.gbpBuscarCategoria.Size = new System.Drawing.Size(623, 246);
            this.gbpBuscarCategoria.TabIndex = 12;
            this.gbpBuscarCategoria.TabStop = false;
            // 
            // dgCategorias
            // 
            this.dgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategorias.Location = new System.Drawing.Point(15, 50);
            this.dgCategorias.Name = "dgCategorias";
            this.dgCategorias.Size = new System.Drawing.Size(563, 170);
            this.dgCategorias.TabIndex = 15;
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Depth = 0;
            this.btnBuscarCategoria.Location = new System.Drawing.Point(500, 20);
            this.btnBuscarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Primary = true;
            this.btnBuscarCategoria.Size = new System.Drawing.Size(78, 23);
            this.btnBuscarCategoria.TabIndex = 14;
            this.btnBuscarCategoria.Text = "BUSCAR";
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.Depth = 0;
            this.txtBuscarCategoria.Hint = "Buscar categoria";
            this.txtBuscarCategoria.Location = new System.Drawing.Point(15, 20);
            this.txtBuscarCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.PasswordChar = '\0';
            this.txtBuscarCategoria.SelectedText = "";
            this.txtBuscarCategoria.SelectionLength = 0;
            this.txtBuscarCategoria.SelectionStart = 0;
            this.txtBuscarCategoria.Size = new System.Drawing.Size(476, 23);
            this.txtBuscarCategoria.TabIndex = 13;
            this.txtBuscarCategoria.UseSystemPasswordChar = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(780, 534);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 625);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbpBuscarCategoria);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbpDetalleCategoria);
            this.Controls.Add(this.lblCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategorias";
            this.Text = "frmCategorias";
            this.gbpDetalleCategoria.ResumeLayout(false);
            this.gbpBuscarCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblCategorias;
        private System.Windows.Forms.GroupBox gbpDetalleCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigoCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private System.Windows.Forms.GroupBox gbpBuscarCategoria;
        private System.Windows.Forms.DataGridView dgCategorias;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
    }
}