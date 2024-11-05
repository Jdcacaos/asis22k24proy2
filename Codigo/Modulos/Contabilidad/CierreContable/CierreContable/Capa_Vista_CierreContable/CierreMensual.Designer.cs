
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
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_mes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_año = new System.Windows.Forms.ComboBox();
            this.dgv_cierre = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.cbo_cuenta = new System.Windows.Forms.ComboBox();
            this.gpb_datosmes = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(357, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 24);
            this.label8.TabIndex = 41;
            this.label8.Text = "CIERRE MENSUAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Haettenschweiler", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(365, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 37);
            this.label3.TabIndex = 36;
            this.label3.Text = "Generar Cierre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(301, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mes";
            // 
            // cbo_mes
            // 
            this.cbo_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_mes.FormattingEnabled = true;
            this.cbo_mes.Location = new System.Drawing.Point(372, 76);
            this.cbo_mes.Name = "cbo_mes";
            this.cbo_mes.Size = new System.Drawing.Size(163, 21);
            this.cbo_mes.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(300, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "Año";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(272, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 24);
            this.label12.TabIndex = 71;
            this.label12.Text = "Cuenta";
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
            this.gpb_datosmes.Controls.Add(this.label7);
            this.gpb_datosmes.Controls.Add(this.label6);
            this.gpb_datosmes.Controls.Add(this.label5);
            this.gpb_datosmes.Controls.Add(this.label4);
            this.gpb_datosmes.Controls.Add(this.txt_saldoactmes);
            this.gpb_datosmes.Controls.Add(this.txt_saldoantmes);
            this.gpb_datosmes.Controls.Add(this.txt_abonomes);
            this.gpb_datosmes.Controls.Add(this.txt_cargomes);
            this.gpb_datosmes.Location = new System.Drawing.Point(23, 402);
            this.gpb_datosmes.Name = "gpb_datosmes";
            this.gpb_datosmes.Size = new System.Drawing.Size(814, 118);
            this.gpb_datosmes.TabIndex = 99;
            this.gpb_datosmes.TabStop = false;
            this.gpb_datosmes.Text = "Datos del mes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(471, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 24);
            this.label7.TabIndex = 106;
            this.label7.Text = "Saldo Actual";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(471, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 24);
            this.label6.TabIndex = 105;
            this.label6.Text = "Saldo Anterior";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(27, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 24);
            this.label5.TabIndex = 104;
            this.label5.Text = "Abonos del Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(32, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 103;
            this.label4.Text = "Cargos del mes";
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
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgv_cierre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_año);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_mes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Name = "CierreMensual";
            this.Text = "Cierre Mensual";
            this.Load += new System.EventHandler(this.ConsultasCierre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cierre)).EndInit();
            this.gpb_datosmes.ResumeLayout(false);
            this.gpb_datosmes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbo_mes;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbo_año;
        private System.Windows.Forms.DataGridView dgv_cierre;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox cbo_cuenta;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_nuevocierre;
        private System.Windows.Forms.Button btn_GuardarCierre;
        private System.Windows.Forms.GroupBox gpb_datosmes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_saldoactmes;
        private System.Windows.Forms.TextBox txt_saldoantmes;
        private System.Windows.Forms.TextBox txt_abonomes;
        private System.Windows.Forms.TextBox txt_cargomes;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Ayuda2;
        private System.Windows.Forms.Button btn_Reporte;
    }
}