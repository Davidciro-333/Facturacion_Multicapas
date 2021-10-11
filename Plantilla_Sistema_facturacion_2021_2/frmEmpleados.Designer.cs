
namespace Plantilla_Sistema_facturacion_2021_2
{
    partial class frmEmpleados
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
            this.lblTituloEmpleados = new MaterialSkin.Controls.MaterialLabel();
            this.gbpBuscarEmpleado = new System.Windows.Forms.GroupBox();
            this.dgBuscarEmpleado = new System.Windows.Forms.DataGridView();
            this.btnBuscarEmpleado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnEliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gbpBuscarEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuscarEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloEmpleados
            // 
            this.lblTituloEmpleados.AutoSize = true;
            this.lblTituloEmpleados.Depth = 0;
            this.lblTituloEmpleados.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloEmpleados.Location = new System.Drawing.Point(342, 10);
            this.lblTituloEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloEmpleados.Name = "lblTituloEmpleados";
            this.lblTituloEmpleados.Size = new System.Drawing.Size(247, 19);
            this.lblTituloEmpleados.TabIndex = 1;
            this.lblTituloEmpleados.Text = "ADMINISTRACIÓN DE EMPLEADOS";
            // 
            // gbpBuscarEmpleado
            // 
            this.gbpBuscarEmpleado.Controls.Add(this.dgBuscarEmpleado);
            this.gbpBuscarEmpleado.Controls.Add(this.btnBuscarEmpleado);
            this.gbpBuscarEmpleado.Controls.Add(this.txtBuscarEmpleado);
            this.gbpBuscarEmpleado.Location = new System.Drawing.Point(70, 347);
            this.gbpBuscarEmpleado.Name = "gbpBuscarEmpleado";
            this.gbpBuscarEmpleado.Size = new System.Drawing.Size(623, 246);
            this.gbpBuscarEmpleado.TabIndex = 3;
            this.gbpBuscarEmpleado.TabStop = false;
            // 
            // dgBuscarEmpleado
            // 
            this.dgBuscarEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuscarEmpleado.Location = new System.Drawing.Point(15, 50);
            this.dgBuscarEmpleado.Name = "dgBuscarEmpleado";
            this.dgBuscarEmpleado.Size = new System.Drawing.Size(563, 150);
            this.dgBuscarEmpleado.TabIndex = 15;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Depth = 0;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(500, 20);
            this.btnBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Primary = true;
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(78, 23);
            this.btnBuscarEmpleado.TabIndex = 14;
            this.btnBuscarEmpleado.Text = "BUSCAR";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.Depth = 0;
            this.txtBuscarEmpleado.Hint = "Buscar empleado";
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(15, 20);
            this.txtBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.PasswordChar = '\0';
            this.txtBuscarEmpleado.SelectedText = "";
            this.txtBuscarEmpleado.SelectionLength = 0;
            this.txtBuscarEmpleado.SelectionStart = 0;
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(479, 23);
            this.txtBuscarEmpleado.TabIndex = 13;
            this.txtBuscarEmpleado.UseSystemPasswordChar = false;
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
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(780, 534);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 625);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbpBuscarEmpleado);
            this.Controls.Add(this.lblTituloEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.gbpBuscarEmpleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBuscarEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloEmpleados;
        private System.Windows.Forms.GroupBox gbpBuscarEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarEmpleado;
        private System.Windows.Forms.DataGridView dgBuscarEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
    }
}