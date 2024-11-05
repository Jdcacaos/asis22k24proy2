
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
            this.txt_totabonos = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_totcargos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_mes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_saldoH = new System.Windows.Forms.TextBox();
            this.txt_saldoD = new System.Windows.Forms.TextBox();
            this.dgv_cargos = new System.Windows.Forms.DataGridView();
            this.dgv_abonos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_saldofinal = new System.Windows.Forms.TextBox();
            this.cbo_cuenta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_saldoant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_consultaAño = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Ayuda1 = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_Reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_abonos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_totabonos
            // 
            this.txt_totabonos.AutoSize = true;
            this.txt_totabonos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totabonos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_totabonos.Location = new System.Drawing.Point(833, 398);
            this.txt_totabonos.Name = "txt_totabonos";
            this.txt_totabonos.Size = new System.Drawing.Size(30, 23);
            this.txt_totabonos.TabIndex = 62;
            this.txt_totabonos.Text = "Q.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(766, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 24);
            this.label9.TabIndex = 61;
            this.label9.Text = "Total:";
            // 
            // txt_totcargos
            // 
            this.txt_totcargos.AutoSize = true;
            this.txt_totcargos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totcargos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_totcargos.Location = new System.Drawing.Point(322, 400);
            this.txt_totcargos.Name = "txt_totcargos";
            this.txt_totcargos.Size = new System.Drawing.Size(30, 23);
            this.txt_totcargos.TabIndex = 60;
            this.txt_totcargos.Text = "Q.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(265, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 59;
            this.label8.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(395, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Mes";
            // 
            // cbo_mes
            // 
            this.cbo_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_mes.FormattingEnabled = true;
            this.cbo_mes.Items.AddRange(new object[] {
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
            this.cbo_mes.Location = new System.Drawing.Point(453, 78);
            this.cbo_mes.Name = "cbo_mes";
            this.cbo_mes.Size = new System.Drawing.Size(163, 21);
            this.cbo_mes.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Haettenschweiler", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(427, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 37);
            this.label3.TabIndex = 50;
            this.label3.Text = "Partida de Cierre";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(536, 458);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 24);
            this.label15.TabIndex = 73;
            this.label15.Text = "Saldo Actual";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(751, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 76;
            this.label1.Text = "HABER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(231, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 75;
            this.label5.Text = "DEBE";
            // 
            // txt_saldofinal
            // 
            this.txt_saldofinal.Location = new System.Drawing.Point(665, 462);
            this.txt_saldofinal.Name = "txt_saldofinal";
            this.txt_saldofinal.Size = new System.Drawing.Size(163, 20);
            this.txt_saldofinal.TabIndex = 79;
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
            this.cbo_cuenta.SelectedIndexChanged += new System.EventHandler(this.cbo_cuenta_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(367, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 81;
            this.label4.Text = "Cuenta";
            // 
            // txt_saldoant
            // 
            this.txt_saldoant.Location = new System.Drawing.Point(308, 462);
            this.txt_saldoant.Name = "txt_saldoant";
            this.txt_saldoant.Size = new System.Drawing.Size(181, 20);
            this.txt_saldoant.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(172, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 24);
            this.label6.TabIndex = 83;
            this.label6.Text = "Saldo Anterior";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(395, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 24);
            this.label7.TabIndex = 85;
            this.label7.Text = "Año";
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
            this.ClientSize = new System.Drawing.Size(1052, 520);
            this.Controls.Add(this.btn_Reporte);
            this.Controls.Add(this.btn_Ayuda1);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbo_consultaAño);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_saldoant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_cuenta);
            this.Controls.Add(this.txt_saldofinal);
            this.Controls.Add(this.dgv_cargos);
            this.Controls.Add(this.dgv_abonos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_saldoH);
            this.Controls.Add(this.txt_saldoD);
            this.Controls.Add(this.txt_totabonos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_totcargos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_mes);
            this.Controls.Add(this.label3);
            this.Name = "ConsultasCierre";
            this.Text = "PartidaCierre";
            this.Load += new System.EventHandler(this.PartidaCierre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_abonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_totabonos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txt_totcargos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_mes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_saldoH;
        private System.Windows.Forms.TextBox txt_saldoD;
        public System.Windows.Forms.DataGridView dgv_cargos;
        public System.Windows.Forms.DataGridView dgv_abonos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_saldofinal;
        public System.Windows.Forms.ComboBox cbo_cuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_saldoant;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbo_consultaAño;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Ayuda1;
        private System.Windows.Forms.Button btn_Reporte;
    }
}