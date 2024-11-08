
namespace Capa_Vista_CierreContable
{
    partial class CierreMensual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CierreMensual));
            this.Lbl_cierremens = new System.Windows.Forms.Label();
            this.Lbl_titulocierre = new System.Windows.Forms.Label();
            this.Lbl_mes = new System.Windows.Forms.Label();
            this.Cbo_mes = new System.Windows.Forms.ComboBox();
            this.Lbl_año = new System.Windows.Forms.Label();
            this.cbo_año = new System.Windows.Forms.ComboBox();
            this.dgv_cierre = new System.Windows.Forms.DataGridView();
            this.Lbl_cuenta = new System.Windows.Forms.Label();
            this.cbo_cuenta = new System.Windows.Forms.ComboBox();
            this.gpb_datosmes = new System.Windows.Forms.GroupBox();
            this.Lbl_saldoact = new System.Windows.Forms.Label();
            this.Lbl_saldoant = new System.Windows.Forms.Label();
            this.Lbl_abonomes = new System.Windows.Forms.Label();
            this.Lbl_cargomes = new System.Windows.Forms.Label();
            this.txt_saldoactmes = new System.Windows.Forms.TextBox();
            this.txt_saldoantmes = new System.Windows.Forms.TextBox();
            this.txt_abonomes = new System.Windows.Forms.TextBox();
            this.txt_cargomes = new System.Windows.Forms.TextBox();
            this.btn_Ayuda2 = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_nuevocierre = new System.Windows.Forms.Button();
            this.btn_GuardarCierre = new System.Windows.Forms.Button();
            this.btn_Reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cierre)).BeginInit();
            this.gpb_datosmes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_cierremens
            // 
            this.Lbl_cierremens.AutoSize = true;
            this.Lbl_cierremens.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cierremens.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_cierremens.Location = new System.Drawing.Point(357, 144);
            this.Lbl_cierremens.Name = "Lbl_cierremens";
            this.Lbl_cierremens.Size = new System.Drawing.Size(199, 24);
            this.Lbl_cierremens.TabIndex = 41;
            this.Lbl_cierremens.Text = "CIERRE MENSUAL";
            // 
            // Lbl_titulocierre
            // 
            this.Lbl_titulocierre.AutoSize = true;
            this.Lbl_titulocierre.Font = new System.Drawing.Font("Haettenschweiler", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulocierre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_titulocierre.Location = new System.Drawing.Point(365, 9);
            this.Lbl_titulocierre.Name = "Lbl_titulocierre";
            this.Lbl_titulocierre.Size = new System.Drawing.Size(180, 37);
            this.Lbl_titulocierre.TabIndex = 36;
            this.Lbl_titulocierre.Text = "Generar Cierre";
            // 
            // Lbl_mes
            // 
            this.Lbl_mes.AutoSize = true;
            this.Lbl_mes.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_mes.Location = new System.Drawing.Point(301, 73);
            this.Lbl_mes.Name = "Lbl_mes";
            this.Lbl_mes.Size = new System.Drawing.Size(47, 24);
            this.Lbl_mes.TabIndex = 54;
            this.Lbl_mes.Text = "Mes";
            // 
            // Cbo_mes
            // 
            this.Cbo_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_mes.FormattingEnabled = true;
            this.Cbo_mes.Location = new System.Drawing.Point(372, 76);
            this.Cbo_mes.Name = "Cbo_mes";
            this.Cbo_mes.Size = new System.Drawing.Size(163, 21);
            this.Cbo_mes.TabIndex = 53;
            // 
            // Lbl_año
            // 
            this.Lbl_año.AutoSize = true;
            this.Lbl_año.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_año.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_año.Location = new System.Drawing.Point(300, 49);
            this.Lbl_año.Name = "Lbl_año";
            this.Lbl_año.Size = new System.Drawing.Size(47, 24);
            this.Lbl_año.TabIndex = 56;
            this.Lbl_año.Text = "Año";
            // 
            // cbo_año
            // 
            this.cbo_año.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_año.Enabled = false;
            this.cbo_año.FormattingEnabled = true;
            this.cbo_año.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034"});
            this.cbo_año.Location = new System.Drawing.Point(372, 49);
            this.cbo_año.Name = "cbo_año";
            this.cbo_año.Size = new System.Drawing.Size(163, 21);
            this.cbo_año.TabIndex = 55;
            // 
            // dgv_cierre
            // 
            this.dgv_cierre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cierre.Location = new System.Drawing.Point(23, 171);
            this.dgv_cierre.Name = "dgv_cierre";
            this.dgv_cierre.Size = new System.Drawing.Size(814, 225);
            this.dgv_cierre.TabIndex = 58;
            // 
            // Lbl_cuenta
            // 
            this.Lbl_cuenta.AutoSize = true;
            this.Lbl_cuenta.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_cuenta.Location = new System.Drawing.Point(272, 103);
            this.Lbl_cuenta.Name = "Lbl_cuenta";
            this.Lbl_cuenta.Size = new System.Drawing.Size(75, 24);
            this.Lbl_cuenta.TabIndex = 71;
            this.Lbl_cuenta.Text = "Cuenta";
            // 
            // cbo_cuenta
            // 
            this.cbo_cuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_cuenta.FormattingEnabled = true;
            this.cbo_cuenta.Location = new System.Drawing.Point(372, 106);
            this.cbo_cuenta.Name = "cbo_cuenta";
            this.cbo_cuenta.Size = new System.Drawing.Size(163, 21);
            this.cbo_cuenta.TabIndex = 72;
            // 
            // gpb_datosmes
            // 
            this.gpb_datosmes.Controls.Add(this.Lbl_saldoact);
            this.gpb_datosmes.Controls.Add(this.Lbl_saldoant);
            this.gpb_datosmes.Controls.Add(this.Lbl_abonomes);
            this.gpb_datosmes.Controls.Add(this.Lbl_cargomes);
            this.gpb_datosmes.Controls.Add(this.txt_saldoactmes);
            this.gpb_datosmes.Controls.Add(this.txt_saldoantmes);
            this.gpb_datosmes.Controls.Add(this.txt_abonomes);
            this.gpb_datosmes.Controls.Add(this.txt_cargomes);
            this.gpb_datosmes.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datosmes.Location = new System.Drawing.Point(23, 402);
            this.gpb_datosmes.Name = "gpb_datosmes";
            this.gpb_datosmes.Size = new System.Drawing.Size(814, 118);
            this.gpb_datosmes.TabIndex = 99;
            this.gpb_datosmes.TabStop = false;
            this.gpb_datosmes.Text = "Datos del mes";
            // 
            // Lbl_saldoact
            // 
            this.Lbl_saldoact.AutoSize = true;
            this.Lbl_saldoact.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_saldoact.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_saldoact.Location = new System.Drawing.Point(471, 74);
            this.Lbl_saldoact.Name = "Lbl_saldoact";
            this.Lbl_saldoact.Size = new System.Drawing.Size(123, 24);
            this.Lbl_saldoact.TabIndex = 106;
            this.Lbl_saldoact.Text = "Saldo Actual";
            // 
            // Lbl_saldoant
            // 
            this.Lbl_saldoant.AutoSize = true;
            this.Lbl_saldoant.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_saldoant.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_saldoant.Location = new System.Drawing.Point(471, 47);
            this.Lbl_saldoant.Name = "Lbl_saldoant";
            this.Lbl_saldoant.Size = new System.Drawing.Size(139, 24);
            this.Lbl_saldoant.TabIndex = 105;
            this.Lbl_saldoant.Text = "Saldo Anterior";
            // 
            // Lbl_abonomes
            // 
            this.Lbl_abonomes.AutoSize = true;
            this.Lbl_abonomes.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_abonomes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_abonomes.Location = new System.Drawing.Point(27, 74);
            this.Lbl_abonomes.Name = "Lbl_abonomes";
            this.Lbl_abonomes.Size = new System.Drawing.Size(150, 24);
            this.Lbl_abonomes.TabIndex = 104;
            this.Lbl_abonomes.Text = "Abonos del Mes";
            // 
            // Lbl_cargomes
            // 
            this.Lbl_cargomes.AutoSize = true;
            this.Lbl_cargomes.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cargomes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_cargomes.Location = new System.Drawing.Point(32, 48);
            this.Lbl_cargomes.Name = "Lbl_cargomes";
            this.Lbl_cargomes.Size = new System.Drawing.Size(145, 24);
            this.Lbl_cargomes.TabIndex = 103;
            this.Lbl_cargomes.Text = "Cargos del mes";
            // 
            // txt_saldoactmes
            // 
            this.txt_saldoactmes.Enabled = false;
            this.txt_saldoactmes.Location = new System.Drawing.Point(616, 78);
            this.txt_saldoactmes.Name = "txt_saldoactmes";
            this.txt_saldoactmes.Size = new System.Drawing.Size(174, 20);
            this.txt_saldoactmes.TabIndex = 102;
            // 
            // txt_saldoantmes
            // 
            this.txt_saldoantmes.Enabled = false;
            this.txt_saldoantmes.Location = new System.Drawing.Point(616, 48);
            this.txt_saldoantmes.Name = "txt_saldoantmes";
            this.txt_saldoantmes.Size = new System.Drawing.Size(174, 20);
            this.txt_saldoantmes.TabIndex = 101;
            // 
            // txt_abonomes
            // 
            this.txt_abonomes.Enabled = false;
            this.txt_abonomes.Location = new System.Drawing.Point(193, 79);
            this.txt_abonomes.Name = "txt_abonomes";
            this.txt_abonomes.Size = new System.Drawing.Size(174, 20);
            this.txt_abonomes.TabIndex = 100;
            // 
            // txt_cargomes
            // 
            this.txt_cargomes.Enabled = false;
            this.txt_cargomes.Location = new System.Drawing.Point(193, 48);
            this.txt_cargomes.Name = "txt_cargomes";
            this.txt_cargomes.Size = new System.Drawing.Size(174, 20);
            this.txt_cargomes.TabIndex = 99;
            // 
            // btn_Ayuda2
            // 
            this.btn_Ayuda2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.btn_Ayuda2.BackgroundImage = global::Capa_Vista_CierreContable.Properties.Resources.AYUDA_V4;
            this.btn_Ayuda2.Location = new System.Drawing.Point(122, 34);
            this.btn_Ayuda2.Name = "btn_Ayuda2";
            this.btn_Ayuda2.Size = new System.Drawing.Size(72, 66);
            this.btn_Ayuda2.TabIndex = 101;
            this.btn_Ayuda2.UseVisualStyleBackColor = false;
            this.btn_Ayuda2.Click += new System.EventHandler(this.btn_Ayuda2_Click);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.btn_Actualizar.BackgroundImage = global::Capa_Vista_CierreContable.Properties.Resources.ACTUALIZAR_V4;
            this.btn_Actualizar.Location = new System.Drawing.Point(200, 34);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(72, 66);
            this.btn_Actualizar.TabIndex = 100;
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancelar.Image = global::Capa_Vista_CierreContable.Properties.Resources.CANCELAR_V4;
            this.btn_cancelar.Location = new System.Drawing.Point(654, 41);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(76, 66);
            this.btn_cancelar.TabIndex = 90;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_nuevocierre
            // 
            this.btn_nuevocierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.btn_nuevocierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevocierre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_nuevocierre.Image = global::Capa_Vista_CierreContable.Properties.Resources.INGRESAR_V4;
            this.btn_nuevocierre.Location = new System.Drawing.Point(576, 41);
            this.btn_nuevocierre.Name = "btn_nuevocierre";
            this.btn_nuevocierre.Size = new System.Drawing.Size(72, 66);
            this.btn_nuevocierre.TabIndex = 89;
            this.btn_nuevocierre.UseVisualStyleBackColor = false;
            this.btn_nuevocierre.Click += new System.EventHandler(this.btn_nuevocierre_Click);
            // 
            // btn_GuardarCierre
            // 
            this.btn_GuardarCierre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.btn_GuardarCierre.Enabled = false;
            this.btn_GuardarCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarCierre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_GuardarCierre.Image = global::Capa_Vista_CierreContable.Properties.Resources.guardar;
            this.btn_GuardarCierre.Location = new System.Drawing.Point(736, 41);
            this.btn_GuardarCierre.Name = "btn_GuardarCierre";
            this.btn_GuardarCierre.Size = new System.Drawing.Size(76, 66);
            this.btn_GuardarCierre.TabIndex = 88;
            this.btn_GuardarCierre.UseVisualStyleBackColor = false;
            this.btn_GuardarCierre.Click += new System.EventHandler(this.btn_GuardarCierre_Click);
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(55)))), ((int)(((byte)(62)))));
            this.btn_Reporte.BackgroundImage = global::Capa_Vista_CierreContable.Properties.Resources.impresora;
            this.btn_Reporte.Location = new System.Drawing.Point(44, 37);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(72, 63);
            this.btn_Reporte.TabIndex = 104;
            this.btn_Reporte.UseVisualStyleBackColor = false;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click_1);
            // 
            // CierreMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(901, 532);
            this.Controls.Add(this.btn_Reporte);
            this.Controls.Add(this.btn_Ayuda2);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.gpb_datosmes);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_nuevocierre);
            this.Controls.Add(this.btn_GuardarCierre);
            this.Controls.Add(this.cbo_cuenta);
            this.Controls.Add(this.Lbl_cuenta);
            this.Controls.Add(this.dgv_cierre);
            this.Controls.Add(this.Lbl_año);
            this.Controls.Add(this.cbo_año);
            this.Controls.Add(this.Lbl_mes);
            this.Controls.Add(this.Cbo_mes);
            this.Controls.Add(this.Lbl_cierremens);
            this.Controls.Add(this.Lbl_titulocierre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CierreMensual";
            this.Load += new System.EventHandler(this.ConsultasCierre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cierre)).EndInit();
            this.gpb_datosmes.ResumeLayout(false);
            this.gpb_datosmes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_cierremens;
        private System.Windows.Forms.Label Lbl_titulocierre;
        private System.Windows.Forms.Label Lbl_mes;
        public System.Windows.Forms.ComboBox Cbo_mes;
        private System.Windows.Forms.Label Lbl_año;
        public System.Windows.Forms.ComboBox cbo_año;
        private System.Windows.Forms.DataGridView dgv_cierre;
        private System.Windows.Forms.Label Lbl_cuenta;
        public System.Windows.Forms.ComboBox cbo_cuenta;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_nuevocierre;
        private System.Windows.Forms.Button btn_GuardarCierre;
        private System.Windows.Forms.GroupBox gpb_datosmes;
        private System.Windows.Forms.Label Lbl_saldoact;
        private System.Windows.Forms.Label Lbl_saldoant;
        private System.Windows.Forms.Label Lbl_abonomes;
        private System.Windows.Forms.Label Lbl_cargomes;
        private System.Windows.Forms.TextBox txt_saldoactmes;
        private System.Windows.Forms.TextBox txt_saldoantmes;
        private System.Windows.Forms.TextBox txt_abonomes;
        private System.Windows.Forms.TextBox txt_cargomes;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Ayuda2;
        private System.Windows.Forms.Button btn_Reporte;
    }
}