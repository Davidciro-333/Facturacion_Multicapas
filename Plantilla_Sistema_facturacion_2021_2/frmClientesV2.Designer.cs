
namespace Plantilla_Sistema_facturacion_2021_2
{
    partial class frmClientesV2
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
            this.lblTituloClientes = new MaterialSkin.Controls.MaterialLabel();
            this.gbpClientes = new System.Windows.Forms.GroupBox();
            this.dgvClientesCRUD2 = new System.Windows.Forms.DataGridView();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscarCliente = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscarCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.gbpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesCRUD2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloClientes
            // 
            this.lblTituloClientes.AutoSize = true;
            this.lblTituloClientes.Depth = 0;
            this.lblTituloClientes.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloClientes.Location = new System.Drawing.Point(351, 10);
            this.lblTituloClientes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloClientes.Name = "lblTituloClientes";
            this.lblTituloClientes.Size = new System.Drawing.Size(229, 19);
            this.lblTituloClientes.TabIndex = 1;
            this.lblTituloClientes.Text = "ADMINISTRACIÓN DE CLIENTES";
            // 
            // gbpClientes
            // 
            this.gbpClientes.Controls.Add(this.dgvClientesCRUD2);
            this.gbpClientes.Controls.Add(this.btnNuevo);
            this.gbpClientes.Controls.Add(this.btnBuscarCliente);
            this.gbpClientes.Controls.Add(this.txtBuscarCliente);
            this.gbpClientes.Location = new System.Drawing.Point(12, 75);
            this.gbpClientes.Name = "gbpClientes";
            this.gbpClientes.Size = new System.Drawing.Size(906, 368);
            this.gbpClientes.TabIndex = 2;
            this.gbpClientes.TabStop = false;
            // 
            // dgvClientesCRUD2
            // 
            this.dgvClientesCRUD2.AllowUserToAddRows = false;
            this.dgvClientesCRUD2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientesCRUD2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cliente,
            this.strCliente,
            this.strDocumento,
            this.strDireccion,
            this.strTelefono,
            this.strEmail,
            this.btnEditar,
            this.btnBorrar});
            this.dgvClientesCRUD2.Location = new System.Drawing.Point(6, 58);
            this.dgvClientesCRUD2.Name = "dgvClientesCRUD2";
            this.dgvClientesCRUD2.Size = new System.Drawing.Size(894, 267);
            this.dgvClientesCRUD2.TabIndex = 14;
            this.dgvClientesCRUD2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientesCRUD2_CellContentClick);
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.HeaderText = "ID";
            this.Id_Cliente.Name = "Id_Cliente";
            this.Id_Cliente.ReadOnly = true;
            this.Id_Cliente.Width = 40;
            // 
            // strCliente
            // 
            this.strCliente.HeaderText = "CLIENTE";
            this.strCliente.Name = "strCliente";
            this.strCliente.ReadOnly = true;
            this.strCliente.Width = 250;
            // 
            // strDocumento
            // 
            this.strDocumento.HeaderText = "DOCUMENTO";
            this.strDocumento.Name = "strDocumento";
            this.strDocumento.ReadOnly = true;
            this.strDocumento.Width = 80;
            // 
            // strDireccion
            // 
            this.strDireccion.HeaderText = "DIRECCIÓN";
            this.strDireccion.Name = "strDireccion";
            this.strDireccion.ReadOnly = true;
            // 
            // strTelefono
            // 
            this.strTelefono.HeaderText = "TELÉFONO";
            this.strTelefono.Name = "strTelefono";
            this.strTelefono.ReadOnly = true;
            this.strTelefono.Width = 80;
            // 
            // strEmail
            // 
            this.strEmail.HeaderText = "E-MAIL";
            this.strEmail.Name = "strEmail";
            this.strEmail.ReadOnly = true;
            this.strEmail.Width = 140;
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "EDITAR";
            this.btnEditar.Name = "btnEditar";
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
            // btnNuevo
            // 
            this.btnNuevo.Depth = 0;
            this.btnNuevo.Location = new System.Drawing.Point(642, 19);
            this.btnNuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Primary = true;
            this.btnNuevo.Size = new System.Drawing.Size(78, 23);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Depth = 0;
            this.btnBuscarCliente.Location = new System.Drawing.Point(502, 19);
            this.btnBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Primary = true;
            this.btnBuscarCliente.Size = new System.Drawing.Size(78, 23);
            this.btnBuscarCliente.TabIndex = 12;
            this.btnBuscarCliente.Text = "BUSCAR";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Depth = 0;
            this.txtBuscarCliente.Hint = "Buscar cliente";
            this.txtBuscarCliente.Location = new System.Drawing.Point(17, 19);
            this.txtBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.PasswordChar = '\0';
            this.txtBuscarCliente.SelectedText = "";
            this.txtBuscarCliente.SelectionLength = 0;
            this.txtBuscarCliente.SelectionStart = 0;
            this.txtBuscarCliente.Size = new System.Drawing.Size(476, 23);
            this.txtBuscarCliente.TabIndex = 11;
            this.txtBuscarCliente.UseSystemPasswordChar = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(750, 449);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmClientesV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 625);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbpClientes);
            this.Controls.Add(this.lblTituloClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientesV2";
            this.Text = "frmClientesV2";
            this.Load += new System.EventHandler(this.frmClientesV2_Load);
            this.gbpClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesCRUD2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloClientes;
        private System.Windows.Forms.GroupBox gbpClientes;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscarCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarCliente;
        private System.Windows.Forms.DataGridView dgvClientesCRUD2;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevo;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn strCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn strDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn strTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn strEmail;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnBorrar;
    }
}