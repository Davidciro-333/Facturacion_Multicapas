
namespace Plantilla_Sistema_facturacion_2021_2
{
    partial class frmInformeFactura
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
            this.lblTituloInformes = new MaterialSkin.Controls.MaterialLabel();
            this.gbpInformes = new System.Windows.Forms.GroupBox();
            this.lblSeleccioneInforme = new MaterialSkin.Controls.MaterialLabel();
            this.cmbSeleccioneInforme = new System.Windows.Forms.ComboBox();
            this.lblOrdenar = new MaterialSkin.Controls.MaterialLabel();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.lblFechaInicio = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.rbEnPantalla = new System.Windows.Forms.RadioButton();
            this.rdbExcel = new System.Windows.Forms.RadioButton();
            this.rdbPdf = new System.Windows.Forms.RadioButton();
            this.btnGenerarInforme = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dtgInforme = new System.Windows.Forms.DataGridView();
            this.gbpInformes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInforme)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloInformes
            // 
            this.lblTituloInformes.AutoSize = true;
            this.lblTituloInformes.Depth = 0;
            this.lblTituloInformes.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloInformes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloInformes.Location = new System.Drawing.Point(303, 10);
            this.lblTituloInformes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloInformes.Name = "lblTituloInformes";
            this.lblTituloInformes.Size = new System.Drawing.Size(324, 19);
            this.lblTituloInformes.TabIndex = 1;
            this.lblTituloInformes.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";
            // 
            // gbpInformes
            // 
            this.gbpInformes.Controls.Add(this.btnSalir);
            this.gbpInformes.Controls.Add(this.btnGenerarInforme);
            this.gbpInformes.Controls.Add(this.rdbPdf);
            this.gbpInformes.Controls.Add(this.rdbExcel);
            this.gbpInformes.Controls.Add(this.rbEnPantalla);
            this.gbpInformes.Controls.Add(this.dtpFechaFinal);
            this.gbpInformes.Controls.Add(this.lblFechaFinal);
            this.gbpInformes.Controls.Add(this.dtpFechaInicio);
            this.gbpInformes.Controls.Add(this.lblFechaInicio);
            this.gbpInformes.Controls.Add(this.cmbOrdenar);
            this.gbpInformes.Controls.Add(this.lblOrdenar);
            this.gbpInformes.Controls.Add(this.cmbSeleccioneInforme);
            this.gbpInformes.Controls.Add(this.lblSeleccioneInforme);
            this.gbpInformes.Location = new System.Drawing.Point(70, 75);
            this.gbpInformes.Name = "gbpInformes";
            this.gbpInformes.Size = new System.Drawing.Size(800, 268);
            this.gbpInformes.TabIndex = 2;
            this.gbpInformes.TabStop = false;
            // 
            // lblSeleccioneInforme
            // 
            this.lblSeleccioneInforme.AutoSize = true;
            this.lblSeleccioneInforme.Depth = 0;
            this.lblSeleccioneInforme.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSeleccioneInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSeleccioneInforme.Location = new System.Drawing.Point(15, 25);
            this.lblSeleccioneInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSeleccioneInforme.Name = "lblSeleccioneInforme";
            this.lblSeleccioneInforme.Size = new System.Drawing.Size(166, 19);
            this.lblSeleccioneInforme.TabIndex = 0;
            this.lblSeleccioneInforme.Text = "SELECCIONE INFORME";
            // 
            // cmbSeleccioneInforme
            // 
            this.cmbSeleccioneInforme.FormattingEnabled = true;
            this.cmbSeleccioneInforme.Location = new System.Drawing.Point(200, 25);
            this.cmbSeleccioneInforme.Name = "cmbSeleccioneInforme";
            this.cmbSeleccioneInforme.Size = new System.Drawing.Size(233, 21);
            this.cmbSeleccioneInforme.TabIndex = 1;
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Depth = 0;
            this.lblOrdenar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOrdenar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOrdenar.Location = new System.Drawing.Point(500, 25);
            this.lblOrdenar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(91, 19);
            this.lblOrdenar.TabIndex = 2;
            this.lblOrdenar.Text = "Ordenar por:";
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Location = new System.Drawing.Point(600, 25);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdenar.TabIndex = 3;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Depth = 0;
            this.lblFechaInicio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaInicio.Location = new System.Drawing.Point(100, 100);
            this.lblFechaInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(94, 19);
            this.lblFechaInicio.TabIndex = 4;
            this.lblFechaInicio.Text = "Fecha inicio:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(200, 100);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaInicio.TabIndex = 5;
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Depth = 0;
            this.lblFechaFinal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFechaFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFechaFinal.Location = new System.Drawing.Point(450, 100);
            this.lblFechaFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(86, 19);
            this.lblFechaFinal.TabIndex = 6;
            this.lblFechaFinal.Text = "Fecha final:";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(535, 100);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaFinal.TabIndex = 7;
            // 
            // rbEnPantalla
            // 
            this.rbEnPantalla.AutoSize = true;
            this.rbEnPantalla.Location = new System.Drawing.Point(200, 160);
            this.rbEnPantalla.Name = "rbEnPantalla";
            this.rbEnPantalla.Size = new System.Drawing.Size(78, 17);
            this.rbEnPantalla.TabIndex = 8;
            this.rbEnPantalla.TabStop = true;
            this.rbEnPantalla.Text = "En pantalla";
            this.rbEnPantalla.UseVisualStyleBackColor = true;
            // 
            // rdbExcel
            // 
            this.rdbExcel.AutoSize = true;
            this.rdbExcel.Location = new System.Drawing.Point(350, 160);
            this.rdbExcel.Name = "rdbExcel";
            this.rdbExcel.Size = new System.Drawing.Size(51, 17);
            this.rdbExcel.TabIndex = 9;
            this.rdbExcel.TabStop = true;
            this.rdbExcel.Text = "Excel";
            this.rdbExcel.UseVisualStyleBackColor = true;
            // 
            // rdbPdf
            // 
            this.rdbPdf.AutoSize = true;
            this.rdbPdf.Location = new System.Drawing.Point(500, 160);
            this.rdbPdf.Name = "rdbPdf";
            this.rdbPdf.Size = new System.Drawing.Size(41, 17);
            this.rdbPdf.TabIndex = 10;
            this.rdbPdf.TabStop = true;
            this.rdbPdf.Text = "Pdf";
            this.rdbPdf.UseVisualStyleBackColor = true;
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.Depth = 0;
            this.btnGenerarInforme.Location = new System.Drawing.Point(250, 200);
            this.btnGenerarInforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Primary = true;
            this.btnGenerarInforme.Size = new System.Drawing.Size(150, 35);
            this.btnGenerarInforme.TabIndex = 14;
            this.btnGenerarInforme.Text = "GENERAR INFORME";
            this.btnGenerarInforme.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(415, 200);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(100, 35);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtgInforme
            // 
            this.dtgInforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInforme.Location = new System.Drawing.Point(70, 360);
            this.dtgInforme.Name = "dtgInforme";
            this.dtgInforme.Size = new System.Drawing.Size(800, 246);
            this.dtgInforme.TabIndex = 3;
            // 
            // frmInformeFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 625);
            this.Controls.Add(this.dtgInforme);
            this.Controls.Add(this.gbpInformes);
            this.Controls.Add(this.lblTituloInformes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformeFactura";
            this.Text = "frmInformeFactura";
            this.gbpInformes.ResumeLayout(false);
            this.gbpInformes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInforme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTituloInformes;
        private System.Windows.Forms.GroupBox gbpInformes;
        private System.Windows.Forms.ComboBox cmbOrdenar;
        private MaterialSkin.Controls.MaterialLabel lblOrdenar;
        private System.Windows.Forms.ComboBox cmbSeleccioneInforme;
        private MaterialSkin.Controls.MaterialLabel lblSeleccioneInforme;
        private System.Windows.Forms.RadioButton rdbPdf;
        private System.Windows.Forms.RadioButton rdbExcel;
        private System.Windows.Forms.RadioButton rbEnPantalla;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private MaterialSkin.Controls.MaterialLabel lblFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private MaterialSkin.Controls.MaterialLabel lblFechaInicio;
        private MaterialSkin.Controls.MaterialRaisedButton btnGenerarInforme;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.DataGridView dtgInforme;
    }
}