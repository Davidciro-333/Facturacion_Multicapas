
namespace Plantilla_Sistema_facturacion_2021_2
{
    partial class frmEditarCliente
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
            this.gbpEditarCliente = new System.Windows.Forms.GroupBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblEditarCliente = new System.Windows.Forms.Label();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbpEditarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // gbpEditarCliente
            // 
            this.gbpEditarCliente.Controls.Add(this.txtEmail);
            this.gbpEditarCliente.Controls.Add(this.txtTelefono);
            this.gbpEditarCliente.Controls.Add(this.txtDireccion);
            this.gbpEditarCliente.Controls.Add(this.txtDocumento);
            this.gbpEditarCliente.Controls.Add(this.txtNombreCliente);
            this.gbpEditarCliente.Controls.Add(this.txtIdCliente);
            this.gbpEditarCliente.Location = new System.Drawing.Point(43, 105);
            this.gbpEditarCliente.Name = "gbpEditarCliente";
            this.gbpEditarCliente.Size = new System.Drawing.Size(320, 282);
            this.gbpEditarCliente.TabIndex = 1;
            this.gbpEditarCliente.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "E-mail";
            this.txtEmail.Location = new System.Drawing.Point(59, 210);
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(232, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Hint = "Teléfono";
            this.txtTelefono.Location = new System.Drawing.Point(59, 170);
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(106, 23);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Hint = "Dirección";
            this.txtDireccion.Location = new System.Drawing.Point(59, 130);
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(232, 23);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Depth = 0;
            this.txtDocumento.Hint = "Documento";
            this.txtDocumento.Location = new System.Drawing.Point(59, 90);
            this.txtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.SelectionLength = 0;
            this.txtDocumento.SelectionStart = 0;
            this.txtDocumento.Size = new System.Drawing.Size(106, 23);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.UseSystemPasswordChar = false;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Depth = 0;
            this.txtNombreCliente.Hint = "Nombre Cliente";
            this.txtNombreCliente.Location = new System.Drawing.Point(59, 50);
            this.txtNombreCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.PasswordChar = '\0';
            this.txtNombreCliente.SelectedText = "";
            this.txtNombreCliente.SelectionLength = 0;
            this.txtNombreCliente.SelectionStart = 0;
            this.txtNombreCliente.Size = new System.Drawing.Size(232, 23);
            this.txtNombreCliente.TabIndex = 0;
            this.txtNombreCliente.UseSystemPasswordChar = false;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(20, 19);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(30, 20);
            this.txtIdCliente.TabIndex = 7;
            this.txtIdCliente.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(63, 395);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(111, 32);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(228, 395);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblEditarCliente
            // 
            this.lblEditarCliente.AutoSize = true;
            this.lblEditarCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarCliente.ForeColor = System.Drawing.Color.Red;
            this.lblEditarCliente.Location = new System.Drawing.Point(93, 70);
            this.lblEditarCliente.Name = "lblEditarCliente";
            this.lblEditarCliente.Size = new System.Drawing.Size(185, 28);
            this.lblEditarCliente.TabIndex = 13;
            this.lblEditarCliente.Text = "EDITAR CLIENTE";
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.lblEditarCliente);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.gbpEditarCliente);
            this.Name = "frmEditarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEditarCliente_Load);
            this.gbpEditarCliente.ResumeLayout(false);
            this.gbpEditarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbpEditarCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.Label lblEditarCliente;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}