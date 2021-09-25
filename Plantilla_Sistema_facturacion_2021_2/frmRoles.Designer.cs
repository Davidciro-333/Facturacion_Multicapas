
namespace Plantilla_Sistema_facturacion_2021_2
{
    partial class frmRoles
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
            this.lblTituloRoles = new MaterialSkin.Controls.MaterialLabel();
            this.gbpRol = new System.Windows.Forms.GroupBox();
            this.txtNombreRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblDescripcionRol = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescripcionRol = new System.Windows.Forms.TextBox();
            this.gpbBuscarRol = new System.Windows.Forms.GroupBox();
            this.btnBuscarRol = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgRol = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gbpRol.SuspendLayout();
            this.gpbBuscarRol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRol)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloRoles
            // 
            this.lblTituloRoles.AutoSize = true;
            this.lblTituloRoles.Depth = 0;
            this.lblTituloRoles.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloRoles.Location = new System.Drawing.Point(390, 10);
            this.lblTituloRoles.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloRoles.Name = "lblTituloRoles";
            this.lblTituloRoles.Size = new System.Drawing.Size(150, 19);
            this.lblTituloRoles.TabIndex = 2;
            this.lblTituloRoles.Text = "ROL DE EMPLEADOS";
            // 
            // gbpRol
            // 
            this.gbpRol.Controls.Add(this.txtDescripcionRol);
            this.gbpRol.Controls.Add(this.lblDescripcionRol);
            this.gbpRol.Controls.Add(this.txtNombreRol);
            this.gbpRol.Location = new System.Drawing.Point(70, 75);
            this.gbpRol.Name = "gbpRol";
            this.gbpRol.Size = new System.Drawing.Size(623, 268);
            this.gbpRol.TabIndex = 3;
            this.gbpRol.TabStop = false;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Depth = 0;
            this.txtNombreRol.Hint = "Nombre rol";
            this.txtNombreRol.Location = new System.Drawing.Point(15, 25);
            this.txtNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.PasswordChar = '\0';
            this.txtNombreRol.SelectedText = "";
            this.txtNombreRol.SelectionLength = 0;
            this.txtNombreRol.SelectionStart = 0;
            this.txtNombreRol.Size = new System.Drawing.Size(217, 23);
            this.txtNombreRol.TabIndex = 1;
            this.txtNombreRol.UseSystemPasswordChar = false;
            // 
            // lblDescripcionRol
            // 
            this.lblDescripcionRol.AutoSize = true;
            this.lblDescripcionRol.Depth = 0;
            this.lblDescripcionRol.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDescripcionRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescripcionRol.Location = new System.Drawing.Point(15, 83);
            this.lblDescripcionRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescripcionRol.Name = "lblDescripcionRol";
            this.lblDescripcionRol.Size = new System.Drawing.Size(176, 19);
            this.lblDescripcionRol.TabIndex = 2;
            this.lblDescripcionRol.Text = "Descripción detallada rol";
            // 
            // txtDescripcionRol
            // 
            this.txtDescripcionRol.Location = new System.Drawing.Point(19, 106);
            this.txtDescripcionRol.Multiline = true;
            this.txtDescripcionRol.Name = "txtDescripcionRol";
            this.txtDescripcionRol.Size = new System.Drawing.Size(350, 100);
            this.txtDescripcionRol.TabIndex = 3;
            // 
            // gpbBuscarRol
            // 
            this.gpbBuscarRol.Controls.Add(this.dgRol);
            this.gpbBuscarRol.Controls.Add(this.btnBuscarRol);
            this.gpbBuscarRol.Controls.Add(this.txtBuscarRol);
            this.gpbBuscarRol.Location = new System.Drawing.Point(70, 370);
            this.gpbBuscarRol.Name = "gpbBuscarRol";
            this.gpbBuscarRol.Size = new System.Drawing.Size(623, 246);
            this.gpbBuscarRol.TabIndex = 4;
            this.gpbBuscarRol.TabStop = false;
            // 
            // btnBuscarRol
            // 
            this.btnBuscarRol.Depth = 0;
            this.btnBuscarRol.Location = new System.Drawing.Point(500, 20);
            this.btnBuscarRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarRol.Name = "btnBuscarRol";
            this.btnBuscarRol.Primary = true;
            this.btnBuscarRol.Size = new System.Drawing.Size(78, 23);
            this.btnBuscarRol.TabIndex = 16;
            this.btnBuscarRol.Text = "BUSCAR";
            this.btnBuscarRol.UseVisualStyleBackColor = true;
            // 
            // txtBuscarRol
            // 
            this.txtBuscarRol.Depth = 0;
            this.txtBuscarRol.Hint = "Buscar rol";
            this.txtBuscarRol.Location = new System.Drawing.Point(15, 20);
            this.txtBuscarRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarRol.Name = "txtBuscarRol";
            this.txtBuscarRol.PasswordChar = '\0';
            this.txtBuscarRol.SelectedText = "";
            this.txtBuscarRol.SelectionLength = 0;
            this.txtBuscarRol.SelectionStart = 0;
            this.txtBuscarRol.Size = new System.Drawing.Size(479, 23);
            this.txtBuscarRol.TabIndex = 15;
            this.txtBuscarRol.UseSystemPasswordChar = false;
            // 
            // dgRol
            // 
            this.dgRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRol.Location = new System.Drawing.Point(15, 50);
            this.dgRol.Name = "dgRol";
            this.dgRol.Size = new System.Drawing.Size(563, 150);
            this.dgRol.TabIndex = 17;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(760, 200);
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
            this.btnActualizar.Location = new System.Drawing.Point(760, 150);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(111, 32);
            this.btnActualizar.TabIndex = 13;
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
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(780, 534);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 625);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gpbBuscarRol);
            this.Controls.Add(this.gbpRol);
            this.Controls.Add(this.lblTituloRoles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRoles";
            this.Text = "frmRoles";
            this.gbpRol.ResumeLayout(false);
            this.gbpRol.PerformLayout();
            this.gpbBuscarRol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloRoles;
        private System.Windows.Forms.GroupBox gbpRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreRol;
        private MaterialSkin.Controls.MaterialLabel lblDescripcionRol;
        private System.Windows.Forms.TextBox txtDescripcionRol;
        private System.Windows.Forms.GroupBox gpbBuscarRol;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarRol;
        private System.Windows.Forms.DataGridView dgRol;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
    }
}