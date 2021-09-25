
namespace Plantilla_Sistema_facturacion_2021_2
{
    partial class frmAyuda
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
            this.webAyuda = new System.Windows.Forms.WebBrowser();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // webAyuda
            // 
            this.webAyuda.Location = new System.Drawing.Point(0, 0);
            this.webAyuda.MinimumSize = new System.Drawing.Size(20, 20);
            this.webAyuda.Name = "webAyuda";
            this.webAyuda.Size = new System.Drawing.Size(891, 625);
            this.webAyuda.TabIndex = 0;
            this.webAyuda.Url = new System.Uri("https://docs.microsoft.com/es-es/visualstudio/windows/?f1url=%3FappId%3DDev16IDEF" +
        "1%26l%3Des-ES%26k%3Dk(MSDNSTART)%26rd%3Dtrue&view=vs-2019", System.UriKind.Absolute);
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(897, 0);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(48, 26);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 625);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.webAyuda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAyuda";
            this.Text = "frmAyuda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webAyuda;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
    }
}