
namespace Plantilla_Sistema_facturacion_2021_2
{
    partial class frmEditarEmpleado
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
            this.components = new System.ComponentModel.Container();
            this.lblEditarEmpleado = new System.Windows.Forms.Label();
            this.gbpEmpleadosDetalles = new System.Windows.Forms.GroupBox();
            this.txtDatosAdicionales = new System.Windows.Forms.TextBox();
            this.lblDatosAdicionales = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRetiro = new MaterialSkin.Controls.MaterialLabel();
            this.lblFechaIngreso = new MaterialSkin.Controls.MaterialLabel();
            this.cmbRolEmpleado = new System.Windows.Forms.ComboBox();
            this.lblRolEmpleado = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmailEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefonoEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccionEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDocumentoEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbpEmpleadosDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditarEmpleado
            // 
            this.lblEditarEmpleado.AutoSize = true;
            this.lblEditarEmpleado.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarEmpleado.ForeColor = System.Drawing.Color.Red;
            this.lblEditarEmpleado.Location = new System.Drawing.Point(290, 80);
            this.lblEditarEmpleado.Name = "lblEditarEmpleado";
            this.lblEditarEmpleado.Size = new System.Drawing.Size(219, 28);
            this.lblEditarEmpleado.TabIndex = 14;
            this.lblEditarEmpleado.Text = "EDITAR EMPLEADO";
            // 
            // gbpEmpleadosDetalles
            // 
            this.gbpEmpleadosDetalles.Controls.Add(this.txtIdEmpleado);
            this.gbpEmpleadosDetalles.Controls.Add(this.txtDatosAdicionales);
            this.gbpEmpleadosDetalles.Controls.Add(this.lblDatosAdicionales);
            this.gbpEmpleadosDetalles.Controls.Add(this.dtpFechaRetiro);
            this.gbpEmpleadosDetalles.Controls.Add(this.dtpFechaIngreso);
            this.gbpEmpleadosDetalles.Controls.Add(this.lblFechaRetiro);
            this.gbpEmpleadosDetalles.Controls.Add(this.lblFechaIngreso);
            this.gbpEmpleadosDetalles.Controls.Add(this.cmbRolEmpleado);
            this.gbpEmpleadosDetalles.Controls.Add(this.lblRolEmpleado);
            this.gbpEmpleadosDetalles.Controls.Add(this.txtEmailEmpleado);
            this.gbpEmpleadosDetalles.Controls.Add(this.txtTelefonoEmpleado);
            this.gbpEmpleadosDetalles.Controls.Add(this.txtDireccionEmpleado);
            this.gbpEmpleadosDetalles.Controls.Add(this.txtDocumentoEmpleado);
            this.gbpEmpleadosDetalles.Controls.Add(this.txtNombreEmpleado);
            this.gbpEmpleadosDetalles.Location = new System.Drawing.Point(88, 120);
            this.gbpEmpleadosDetalles.Name = "gbpEmpleadosDetalles";
            this.gbpEmpleadosDetalles.Size = new System.Drawing.Size(623, 268);
            this.gbpEmpleadosDetalles.TabIndex = 15;
            this.gbpEmpleadosDetalles.TabStop = false;
            // 
            // txtDatosAdicionales
            // 
            this.txtDatosAdicionales.Location = new System.Drawing.Point(320, 163);
            this.txtDatosAdicionales.Multiline = true;
            this.txtDatosAdicionales.Name = "txtDatosAdicionales";
            this.txtDatosAdicionales.Size = new System.Drawing.Size(231, 82);
            this.txtDatosAdicionales.TabIndex = 12;
            // 
            // lblDatosAdicionales
            // 
            this.lblDatosAdicionales.AutoSize = true;
            this.lblDatosAdicionales.Depth = 0;
            this.lblDatosAdicionales.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDatosAdicionales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDatosAdicionales.Location = new System.Drawing.Point(320, 141);
            this.lblDatosAdicionales.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDatosAdicionales.Name = "lblDatosAdicionales";
            this.lblDatosAdicionales.Size = new System.Drawing.Size(156, 19);
            this.lblDatosAdicionales.TabIndex = 11;
            this.lblDatosAdicionales.Text = "DATOS ADICIONALES";
            // 
            // dtpFechaRetiro
            // 
            this.dtpFechaRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRetiro.Location = new System.Drawing.Point(433, 78);
            this.dtpFechaRetiro.Name = "dtpFechaRetiro";
            this.dtpFechaRetiro.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaRetiro.TabIndex = 10;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(433, 52);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaIngreso.TabIndex = 9;
            // 
            // lblFechaRetiro
            // 
            this.lblFechaRetiro.AutoSize = true;
            this.lblFechaRetiro.Depth = 0;
            this.lblFechaRetiro.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaRetiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaRetiro.Location = new System.Drawing.Point(337, 79);
            this.lblFechaRetiro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaRetiro.Name = "lblFechaRetiro";
            this.lblFechaRetiro.Size = new System.Drawing.Size(89, 19);
            this.lblFechaRetiro.TabIndex = 8;
            this.lblFechaRetiro.Text = "Fecha retiro";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Depth = 0;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaIngreso.Location = new System.Drawing.Point(319, 54);
            this.lblFechaIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(107, 19);
            this.lblFechaIngreso.TabIndex = 7;
            this.lblFechaIngreso.Text = "Fecha ingreso:";
            // 
            // cmbRolEmpleado
            // 
            this.cmbRolEmpleado.FormattingEnabled = true;
            this.cmbRolEmpleado.Location = new System.Drawing.Point(433, 25);
            this.cmbRolEmpleado.Name = "cmbRolEmpleado";
            this.cmbRolEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbRolEmpleado.TabIndex = 6;
            // 
            // lblRolEmpleado
            // 
            this.lblRolEmpleado.AutoSize = true;
            this.lblRolEmpleado.Depth = 0;
            this.lblRolEmpleado.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblRolEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRolEmpleado.Location = new System.Drawing.Point(325, 25);
            this.lblRolEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRolEmpleado.Name = "lblRolEmpleado";
            this.lblRolEmpleado.Size = new System.Drawing.Size(101, 19);
            this.lblRolEmpleado.TabIndex = 5;
            this.lblRolEmpleado.Text = "Rol empleado";
            // 
            // txtEmailEmpleado
            // 
            this.txtEmailEmpleado.Depth = 0;
            this.txtEmailEmpleado.Hint = "E-mail";
            this.txtEmailEmpleado.Location = new System.Drawing.Point(15, 165);
            this.txtEmailEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmailEmpleado.Name = "txtEmailEmpleado";
            this.txtEmailEmpleado.PasswordChar = '\0';
            this.txtEmailEmpleado.SelectedText = "";
            this.txtEmailEmpleado.SelectionLength = 0;
            this.txtEmailEmpleado.SelectionStart = 0;
            this.txtEmailEmpleado.Size = new System.Drawing.Size(217, 23);
            this.txtEmailEmpleado.TabIndex = 4;
            this.txtEmailEmpleado.UseSystemPasswordChar = false;
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.Depth = 0;
            this.txtTelefonoEmpleado.Hint = "Teléfono";
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(15, 136);
            this.txtTelefonoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.PasswordChar = '\0';
            this.txtTelefonoEmpleado.SelectedText = "";
            this.txtTelefonoEmpleado.SelectionLength = 0;
            this.txtTelefonoEmpleado.SelectionStart = 0;
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(128, 23);
            this.txtTelefonoEmpleado.TabIndex = 3;
            this.txtTelefonoEmpleado.UseSystemPasswordChar = false;
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.Depth = 0;
            this.txtDireccionEmpleado.Hint = "Direccion";
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(15, 107);
            this.txtDireccionEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.PasswordChar = '\0';
            this.txtDireccionEmpleado.SelectedText = "";
            this.txtDireccionEmpleado.SelectionLength = 0;
            this.txtDireccionEmpleado.SelectionStart = 0;
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(217, 23);
            this.txtDireccionEmpleado.TabIndex = 2;
            this.txtDireccionEmpleado.UseSystemPasswordChar = false;
            // 
            // txtDocumentoEmpleado
            // 
            this.txtDocumentoEmpleado.Depth = 0;
            this.txtDocumentoEmpleado.Hint = "Documento";
            this.txtDocumentoEmpleado.Location = new System.Drawing.Point(15, 78);
            this.txtDocumentoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocumentoEmpleado.Name = "txtDocumentoEmpleado";
            this.txtDocumentoEmpleado.PasswordChar = '\0';
            this.txtDocumentoEmpleado.SelectedText = "";
            this.txtDocumentoEmpleado.SelectionLength = 0;
            this.txtDocumentoEmpleado.SelectionStart = 0;
            this.txtDocumentoEmpleado.Size = new System.Drawing.Size(128, 23);
            this.txtDocumentoEmpleado.TabIndex = 1;
            this.txtDocumentoEmpleado.UseSystemPasswordChar = false;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Depth = 0;
            this.txtNombreEmpleado.Hint = "Nombre empleado";
            this.txtNombreEmpleado.Location = new System.Drawing.Point(15, 49);
            this.txtNombreEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.PasswordChar = '\0';
            this.txtNombreEmpleado.SelectedText = "";
            this.txtNombreEmpleado.SelectionLength = 0;
            this.txtNombreEmpleado.SelectionStart = 0;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(217, 23);
            this.txtNombreEmpleado.TabIndex = 0;
            this.txtNombreEmpleado.UseSystemPasswordChar = false;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(15, 19);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(32, 20);
            this.txtIdEmpleado.TabIndex = 13;
            this.txtIdEmpleado.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(264, 394);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(111, 32);
            this.btnActualizar.TabIndex = 16;
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
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmEditarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.gbpEmpleadosDetalles);
            this.Controls.Add(this.lblEditarEmpleado);
            this.Name = "frmEditarEmpleado";
            this.Text = "frmEditarEmpleado";
            this.Load += new System.EventHandler(this.frmEditarEmpleado_Load);
            this.gbpEmpleadosDetalles.ResumeLayout(false);
            this.gbpEmpleadosDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditarEmpleado;
        private System.Windows.Forms.GroupBox gbpEmpleadosDetalles;
        private System.Windows.Forms.TextBox txtDatosAdicionales;
        private MaterialSkin.Controls.MaterialLabel lblDatosAdicionales;
        private System.Windows.Forms.DateTimePicker dtpFechaRetiro;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private MaterialSkin.Controls.MaterialLabel lblFechaRetiro;
        private MaterialSkin.Controls.MaterialLabel lblFechaIngreso;
        private System.Windows.Forms.ComboBox cmbRolEmpleado;
        private MaterialSkin.Controls.MaterialLabel lblRolEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmailEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefonoEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccionEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocumentoEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}