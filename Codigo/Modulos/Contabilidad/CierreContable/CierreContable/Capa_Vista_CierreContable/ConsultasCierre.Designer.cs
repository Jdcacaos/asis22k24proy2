
namespace Capa_Vista_CierreContable
{
    partial class ConsultasCierre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasCierre));
            this.Lbl_totabonos = new System.Windows.Forms.Label();
            this.Lbl_totalhaber = new System.Windows.Forms.Label();
            this.Lbl_totcargos = new System.Windows.Forms.Label();
            this.Lbl_Totaldebe = new System.Windows.Forms.Label();
            this.Lbl_mes = new System.Windows.Forms.Label();
            this.Cbo_mes = new System.Windows.Forms.ComboBox();
            this.Lbl_Tituloconsulta = new System.Windows.Forms.Label();
            this.Lbl_saldoact = new System.Windows.Forms.Label();
            this.txt_saldoH = new System.Windows.Forms.TextBox();
            this.txt_saldoD = new System.Windows.Forms.TextBox();
            this.dgv_cargos = new System.Windows.Forms.DataGridView();
            this.dgv_abonos = new System.Windows.Forms.DataGridView();
            this.Lbl_haber = new System.Windows.Forms.Label();
            this.Lbl_Debe = new System.Windows.Forms.Label();
            this.Txt_saldofinal = new System.Windows.Forms.TextBox();
            this.cbo_cuenta = new System.Windows.Forms.ComboBox();
            this.Lbl_cuenta = new System.Windows.Forms.Label();
            this.Txt_saldoant = new System.Windows.Forms.TextBox();
            this.Lbl_saldoant = new System.Windows.Forms.Label();
            this.cbo_consultaAño = new System.Windows.Forms.ComboBox();
            this.Lbl_año = new System.Windows.Forms.Label();
            this.btn_Ayuda1 = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_Reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_abonos)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_totabonos
            // 
            this.Lbl_totabonos.AutoSize = true;
            this.Lbl_totabonos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_totabonos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_totabonos.Location = new System.Drawing.Point(833, 398);
            this.Lbl_totabonos.Name = "Lbl_totabonos";
            this.Lbl_totabonos.Size = new System.Drawing.Size(30, 23);
            this.Lbl_totabonos.TabIndex = 62;
            this.Lbl_totabonos.Text = "Q.";
            // 
            // Lbl_totalhaber
            // 
            this.Lbl_totalhaber.AutoSize = true;
            this.Lbl_totalhaber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_totalhaber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_totalhaber.Location = new System.Drawing.Point(766, 399);
            this.Lbl_totalhaber.Name = "Lbl_totalhaber";
            this.Lbl_totalhaber.Size = new System.Drawing.Size(62, 24);
            this.Lbl_totalhaber.TabIndex = 61;
            this.Lbl_totalhaber.Text = "Total:";
            // 
            // Lbl_totcargos
            // 
            this.Lbl_totcargos.AutoSize = true;
            this.Lbl_totcargos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_totcargos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_totcargos.Location = new System.Drawing.Point(322, 400);
            this.Lbl_totcargos.Name = "Lbl_totcargos";
            this.Lbl_totcargos.Size = new System.Drawing.Size(30, 23);
            this.Lbl_totcargos.TabIndex = 60;
            this.Lbl_totcargos.Text = "Q.";
            // 
            // Lbl_Totaldebe
            // 
            this.Lbl_Totaldebe.AutoSize = true;
            this.Lbl_Totaldebe.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Totaldebe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Totaldebe.Location = new System.Drawing.Point(265, 400);
            this.Lbl_Totaldebe.Name = "Lbl_Totaldebe";
            this.Lbl_Totaldebe.Size = new System.Drawing.Size(62, 24);
            this.Lbl_Totaldebe.TabIndex = 59;
            this.Lbl_Totaldebe.Text = "Total:";
            // 
            // Lbl_mes
            // 
            this.Lbl_mes.AutoSize = true;
            this.Lbl_mes.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_mes.Location = new System.Drawing.Point(395, 78);
            this.Lbl_mes.Name = "Lbl_mes";
            this.Lbl_mes.Size = new System.Drawing.Size(47, 24);
            this.Lbl_mes.TabIndex = 52;
            this.Lbl_mes.Text = "Mes";
            // 
            // Cbo_mes
            // 
            this.Cbo_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_mes.FormattingEnabled = true;
            this.Cbo_mes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.Cbo_mes.Location = new System.Drawing.Point(453, 78);
            this.Cbo_mes.Name = "Cbo_mes";
            this.Cbo_mes.Size = new System.Drawing.Size(163, 21);
            this.Cbo_mes.TabIndex = 51;
            // 
            // Lbl_Tituloconsulta
            // 
            this.Lbl_Tituloconsulta.AutoSize = true;
            this.Lbl_Tituloconsulta.Font = new System.Drawing.Font("Haettenschweiler", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tituloconsulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Tituloconsulta.Location = new System.Drawing.Point(427, 8);
            this.Lbl_Tituloconsulta.Name = "Lbl_Tituloconsulta";
            this.Lbl_Tituloconsulta.Size = new System.Drawing.Size(195, 37);
            this.Lbl_Tituloconsulta.TabIndex = 50;
            this.Lbl_Tituloconsulta.Text = "Consultar Cierre";
            // 
            // Lbl_saldoact
            // 
            this.Lbl_saldoact.AutoSize = true;
            this.Lbl_saldoact.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_saldoact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_saldoact.Location = new System.Drawing.Point(536, 458);
            this.Lbl_saldoact.Name = "Lbl_saldoact";
            this.Lbl_saldoact.Size = new System.Drawing.Size(123, 24);
            this.Lbl_saldoact.TabIndex = 73;
            this.Lbl_saldoact.Text = "Saldo Actual";
            // 
            // txt_saldoH
            // 
            this.txt_saldoH.Location = new System.Drawing.Point(877, 401);
            this.txt_saldoH.Name = "txt_saldoH";
            this.txt_saldoH.Size = new System.Drawing.Size(163, 20);
            this.txt_saldoH.TabIndex = 72;
            // 
            // txt_saldoD
            // 
            this.txt_saldoD.Location = new System.Drawing.Point(358, 402);
            this.txt_saldoD.Name = "txt_saldoD";
            this.txt_saldoD.Size = new System.Drawing.Size(163, 20);
            this.txt_saldoD.TabIndex = 71;
            // 
            // dgv_cargos
            // 
            this.dgv_cargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cargos.Location = new System.Drawing.Point(22, 163);
            this.dgv_cargos.Name = "dgv_cargos";
            this.dgv_cargos.Size = new System.Drawing.Size(499, 225);
            this.dgv_cargos.TabIndex = 78;
            // 
            // dgv_abonos
            // 
            this.dgv_abonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_abonos.Location = new System.Drawing.Point(541, 163);
            this.dgv_abonos.Name = "dgv_abonos";
            this.dgv_abonos.Size = new System.Drawing.Size(499, 225);
            this.dgv_abonos.TabIndex = 77;
            // 
            // Lbl_haber
            // 
            this.Lbl_haber.AutoSize = true;
            this.Lbl_haber.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_haber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_haber.Location = new System.Drawing.Point(751, 136);
            this.Lbl_haber.Name = "Lbl_haber";
            this.Lbl_haber.Size = new System.Drawing.Size(85, 24);
            this.Lbl_haber.TabIndex = 76;
            this.Lbl_haber.Text = "HABER";
            // 
            // Lbl_Debe
            // 
            this.Lbl_Debe.AutoSize = true;
            this.Lbl_Debe.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Debe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Debe.Location = new System.Drawing.Point(231, 136);
            this.Lbl_Debe.Name = "Lbl_Debe";
            this.Lbl_Debe.Size = new System.Drawing.Size(68, 24);
            this.Lbl_Debe.TabIndex = 75;
            this.Lbl_Debe.Text = "DEBE";
            // 
            // Txt_saldofinal
            // 
            this.Txt_saldofinal.Location = new System.Drawing.Point(665, 462);
            this.Txt_saldofinal.Name = "Txt_saldofinal";
            this.Txt_saldofinal.Size = new System.Drawing.Size(163, 20);
            this.Txt_saldofinal.TabIndex = 79;
            // 
            // cbo_cuenta
            // 
            this.cbo_cuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cuenta.FormattingEnabled = true;
            this.cbo_cuenta.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbo_cuenta.Location = new System.Drawing.Point(453, 105);
            this.cbo_cuenta.Name = "cbo_cuenta";
            this.cbo_cuenta.Size = new System.Drawing.Size(163, 21);
            this.cbo_cuenta.TabIndex = 80;
            // 
            // Lbl_cuenta
            // 
            this.Lbl_cuenta.AutoSize = true;
            this.Lbl_cuenta.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_cuenta.Location = new System.Drawing.Point(367, 102);
            this.Lbl_cuenta.Name = "Lbl_cuenta";
            this.Lbl_cuenta.Size = new System.Drawing.Size(75, 24);
            this.Lbl_cuenta.TabIndex = 81;
            this.Lbl_cuenta.Text = "Cuenta";
            // 
            // Txt_saldoant
            // 
            this.Txt_saldoant.Location = new System.Drawing.Point(308, 462);
            this.Txt_saldoant.Name = "Txt_saldoant";
            this.Txt_saldoant.Size = new System.Drawing.Size(181, 20);
            this.Txt_saldoant.TabIndex = 82;
            // 
            // Lbl_saldoant
            // 
            this.Lbl_saldoant.AutoSize = true;
            this.Lbl_saldoant.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_saldoant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_saldoant.Location = new System.Drawing.Point(172, 458);
            this.Lbl_saldoant.Name = "Lbl_saldoant";
            this.Lbl_saldoant.Size = new System.Drawing.Size(139, 24);
            this.Lbl_saldoant.TabIndex = 83;
            this.Lbl_saldoant.Text = "Saldo Anterior";
            // 
            // cbo_consultaAño
            // 
            this.cbo_consultaAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_consultaAño.FormattingEnabled = true;
            this.cbo_consultaAño.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbo_consultaAño.Location = new System.Drawing.Point(453, 51);
            this.cbo_consultaAño.Name = "cbo_consultaAño";
            this.cbo_consultaAño.Size = new System.Drawing.Size(163, 21);
            this.cbo_consultaAño.TabIndex = 84;
            // 
            // Lbl_año
            // 
            this.Lbl_año.AutoSize = true;
            this.Lbl_año.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_año.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_año.Location = new System.Drawing.Point(395, 51);
            this.Lbl_año.Name = "Lbl_año";
            this.Lbl_año.Size = new System.Drawing.Size(47, 24);
            this.Lbl_año.TabIndex = 85;
            this.Lbl_año.Text = "Año";
            // 
            // btn_Ayuda1
            // 
            this.btn_Ayuda1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.btn_Ayuda1.BackgroundImage = global::Capa_Vista_CierreContable.Properties.Resources.AYUDA_V4;
            this.btn_Ayuda1.Location = new System.Drawing.Point(191, 27);
            this.btn_Ayuda1.Name = "btn_Ayuda1";
            this.btn_Ayuda1.Size = new System.Drawing.Size(72, 66);
            this.btn_Ayuda1.TabIndex = 87;
            this.btn_Ayuda1.UseVisualStyleBackColor = false;
            this.btn_Ayuda1.Click += new System.EventHandler(this.btn_Ayuda1_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.btn_Actualizar.BackgroundImage = global::Capa_Vista_CierreContable.Properties.Resources.ACTUALIZAR_V4;
            this.btn_Actualizar.Location = new System.Drawing.Point(269, 27);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(72, 66);
            this.btn_Actualizar.TabIndex = 86;
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_consultar.Image = global::Capa_Vista_CierreContable.Properties.Resources.BUCAR_V4;
            this.btn_consultar.Location = new System.Drawing.Point(665, 27);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(72, 66);
            this.btn_consultar.TabIndex = 53;
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_mensual_Click_1);
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.btn_Reporte.BackgroundImage = global::Capa_Vista_CierreContable.Properties.Resources.impresora;
            this.btn_Reporte.Location = new System.Drawing.Point(113, 29);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(72, 63);
            this.btn_Reporte.TabIndex = 103;
            this.btn_Reporte.UseVisualStyleBackColor = false;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // ConsultasCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(152)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(913, 512);
            this.Controls.Add(this.btn_Reporte);
            this.Controls.Add(this.btn_Ayuda1);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.Lbl_año);
            this.Controls.Add(this.cbo_consultaAño);
            this.Controls.Add(this.Lbl_saldoant);
            this.Controls.Add(this.Txt_saldoant);
            this.Controls.Add(this.Lbl_cuenta);
            this.Controls.Add(this.cbo_cuenta);
            this.Controls.Add(this.Txt_saldofinal);
            this.Controls.Add(this.dgv_cargos);
            this.Controls.Add(this.dgv_abonos);
            this.Controls.Add(this.Lbl_haber);
            this.Controls.Add(this.Lbl_Debe);
            this.Controls.Add(this.Lbl_saldoact);
            this.Controls.Add(this.txt_saldoH);
            this.Controls.Add(this.txt_saldoD);
            this.Controls.Add(this.Lbl_totabonos);
            this.Controls.Add(this.Lbl_totalhaber);
            this.Controls.Add(this.Lbl_totcargos);
            this.Controls.Add(this.Lbl_Totaldebe);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.Lbl_mes);
            this.Controls.Add(this.Cbo_mes);
            this.Controls.Add(this.Lbl_Tituloconsulta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultasCierre";
            this.Load += new System.EventHandler(this.PartidaCierre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_abonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_totabonos;
        private System.Windows.Forms.Label Lbl_totalhaber;
        private System.Windows.Forms.Label Lbl_totcargos;
        private System.Windows.Forms.Label Lbl_Totaldebe;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label Lbl_mes;
        private System.Windows.Forms.ComboBox Cbo_mes;
        private System.Windows.Forms.Label Lbl_Tituloconsulta;
        private System.Windows.Forms.Label Lbl_saldoact;
        private System.Windows.Forms.TextBox txt_saldoH;
        private System.Windows.Forms.TextBox txt_saldoD;
        public System.Windows.Forms.DataGridView dgv_cargos;
        public System.Windows.Forms.DataGridView dgv_abonos;
        private System.Windows.Forms.Label Lbl_haber;
        private System.Windows.Forms.Label Lbl_Debe;
        private System.Windows.Forms.TextBox Txt_saldofinal;
        public System.Windows.Forms.ComboBox cbo_cuenta;
        private System.Windows.Forms.Label Lbl_cuenta;
        private System.Windows.Forms.TextBox Txt_saldoant;
        private System.Windows.Forms.Label Lbl_saldoant;
        public System.Windows.Forms.ComboBox cbo_consultaAño;
        private System.Windows.Forms.Label Lbl_año;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Ayuda1;
        private System.Windows.Forms.Button btn_Reporte;
    }
}