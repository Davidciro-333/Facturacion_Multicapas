
namespace Plantilla_Sistema_facturacion_2021_2
{
    partial class frmEditarRoles
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
            this.gbpRol = new System.Windows.Forms.GroupBox();
            this.txtDescripcionRol = new System.Windows.Forms.TextBox();
            this.lblDescripcionRol = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.gbpRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbpRol
            // 
            this.gbpRol.Controls.Add(this.txtDescripcionRol);
            this.gbpRol.Controls.Add(this.lblDescripcionRol);
            this.gbpRol.Controls.Add(this.txtNombreRol);
            this.gbpRol.Location = new System.Drawing.Point(69, 126);
            this.gbpRol.Name = "gbpRol";
            this.gbpRol.Size = new System.Drawing.Size(623, 268);
            this.gbpRol.TabIndex = 4;
            this.gbpRol.TabStop = false;
            // 
            // txtDescripcionRol
            // 
            this.txtDescripcionRol.Location = new System.Drawing.Point(19, 106);
            this.txtDescripcionRol.Multiline = true;
            this.txtDescripcionRol.Name = "txtDescripcionRol";
            this.txtDescripcionRol.Size = new System.Drawing.Size(350, 100);
            this.txtDescripcionRol.TabIndex = 3;
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
            // frmEditarRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbpRol);
            this.Name = "frmEditarRoles";
            this.Text = "frmEditarRoles";
            this.gbpRol.ResumeLayout(false);
            this.gbpRol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbpRol;
        private System.Windows.Forms.TextBox txtDescripcionRol;
        private MaterialSkin.Controls.MaterialLabel lblDescripcionRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreRol;
    }
}