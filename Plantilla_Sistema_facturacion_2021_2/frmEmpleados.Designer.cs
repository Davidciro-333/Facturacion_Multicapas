
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
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRolEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtmIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtmRetiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrDatosAdicionales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.lblTituloEmpleados.Location = new System.Drawing.Point(476, 10);
            this.lblTituloEmpleados.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloEmpleados.Name = "lblTituloEmpleados";
            this.lblTituloEmpleados.Size = new System.Drawing.Size(247, 19);
            this.lblTituloEmpleados.TabIndex = 1;
            this.lblTituloEmpleados.Text = "ADMINISTRACIÓN DE EMPLEADOS";
            // 
            // gbpBuscarEmpleado
            // 
            this.gbpBuscarEmpleado.Controls.Add(this.btnNuevo);
            this.gbpBuscarEmpleado.Controls.Add(this.dgBuscarEmpleado);
            this.gbpBuscarEmpleado.Controls.Add(this.btnBuscarEmpleado);
            this.gbpBuscarEmpleado.Controls.Add(this.txtBuscarEmpleado);
            this.gbpBuscarEmpleado.Location = new System.Drawing.Point(12, 75);
            this.gbpBuscarEmpleado.Name = "gbpBuscarEmpleado";
            this.gbpBuscarEmpleado.Size = new System.Drawing.Size(1180, 368);
            this.gbpBuscarEmpleado.TabIndex = 3;
            this.gbpBuscarEmpleado.TabStop = false;
            // 
            // dgBuscarEmpleado
            // 
            this.dgBuscarEmpleado.AllowUserToAddRows = false;
            this.dgBuscarEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuscarEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmpleado,
            this.strNombre,
            this.strDocumento,
            this.strDireccion,
            this.StrTelefono,
            this.StrEmail,
            this.IdRolEmpleado,
            this.DtmIngreso,
            this.DtmRetiro,
            this.StrDatosAdicionales,
            this.btnEditar,
            this.btnBorrar});
            this.dgBuscarEmpleado.Location = new System.Drawing.Point(6, 58);
            this.dgBuscarEmpleado.Name = "dgBuscarEmpleado";
            this.dgBuscarEmpleado.Size = new System.Drawing.Size(1165, 267);
            this.dgBuscarEmpleado.TabIndex = 15;
            this.dgBuscarEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBuscarEmpleado_CellContentClick);
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Depth = 0;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(502, 19);
            this.btnBuscarEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Primary = true;
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(78, 23);
            this.btnBuscarEmpleado.TabIndex = 14;
            this.btnBuscarEmpleado.Text = "BUSCAR";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.Depth = 0;
            this.txtBuscarEmpleado.Hint = "Buscar empleado";
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(17, 19);
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
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(642, 19);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(78, 23);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.HeaderText = "ID";
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.Width = 35;
            // 
            // strNombre
            // 
            this.strNombre.HeaderText = "EMPLEADO";
            this.strNombre.Name = "strNombre";
            this.strNombre.Width = 120;
            // 
            // strDocumento
            // 
            this.strDocumento.HeaderText = "DOCUMENTO";
            this.strDocumento.Name = "strDocumento";
            // 
            // strDireccion
            // 
            this.strDireccion.HeaderText = "DIRECCION";
            this.strDireccion.Name = "strDireccion";
            this.strDireccion.Width = 120;
            // 
            // StrTelefono
            // 
            this.StrTelefono.HeaderText = "TELEFONO";
            this.StrTelefono.Name = "StrTelefono";
            this.StrTelefono.ReadOnly = true;
            this.StrTelefono.Width = 75;
            // 
            // StrEmail
            // 
            this.StrEmail.HeaderText = "E-MAIL";
            this.StrEmail.Name = "StrEmail";
            // 
            // IdRolEmpleado
            // 
            this.IdRolEmpleado.HeaderText = "ROL";
            this.IdRolEmpleado.Name = "IdRolEmpleado";
            this.IdRolEmpleado.Width = 35;
            // 
            // DtmIngreso
            // 
            this.DtmIngreso.HeaderText = "F. INGRESO";
            this.DtmIngreso.Name = "DtmIngreso";
            // 
            // DtmRetiro
            // 
            this.DtmRetiro.HeaderText = "F. RETIRO";
            this.DtmRetiro.Name = "DtmRetiro";
            // 
            // StrDatosAdicionales
            // 
            this.StrDatosAdicionales.HeaderText = "DATOS ADICIONALES";
            this.StrDatosAdicionales.Name = "StrDatosAdicionales";
            this.StrDatosAdicionales.Width = 150;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseColumnTextForButtonValue = true;
            this.btnEditar.Width = 80;
            // 
            // btnBorrar
            // 
            this.btnBorrar.HeaderText = "BORRAR";
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseColumnTextForButtonValue = true;
            this.btnBorrar.Width = 80;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1200, 625);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbpBuscarEmpleado);
            this.Controls.Add(this.lblTituloEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmpleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
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
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn strNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRolEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtmIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtmRetiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrDatosAdicionales;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}