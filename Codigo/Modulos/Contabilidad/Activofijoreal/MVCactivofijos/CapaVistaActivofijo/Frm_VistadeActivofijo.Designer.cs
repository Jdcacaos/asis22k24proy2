
namespace CapaVistaActivofijo
{
    partial class Frm_VistadeActivofijo
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
            this.a = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Gpb_datosacti = new System.Windows.Forms.GroupBox();
            this.Lbl_cuenta = new System.Windows.Forms.Label();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Lbl_valorRecidual = new System.Windows.Forms.Label();
            this.Lbl_vidautil = new System.Windows.Forms.Label();
            this.Lbl_costoadqui = new System.Windows.Forms.Label();
            this.Lbl_fechaadqui = new System.Windows.Forms.Label();
            this.dtp_FechaAdquisicion = new System.Windows.Forms.DateTimePicker();
            this.Txt_CostoAdquisicion = new System.Windows.Forms.TextBox();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.Txt_Cuenta = new System.Windows.Forms.TextBox();
            this.Txt_VidaUtil = new System.Windows.Forms.TextBox();
            this.Txt_ValorResidual = new System.Windows.Forms.TextBox();
            this.Gpb_activofijo = new System.Windows.Forms.GroupBox();
            this.Lbl_Tipoactivo = new System.Windows.Forms.Label();
            this.Lbl_Marca = new System.Windows.Forms.Label();
            this.Lbl_Modelo = new System.Windows.Forms.Label();
            this.Lbl_idactivo = new System.Windows.Forms.Label();
            this.Lbl_codigo = new System.Windows.Forms.Label();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.Txt_CodigoActivo = new System.Windows.Forms.TextBox();
            this.Txt_Modelo = new System.Windows.Forms.TextBox();
            this.Txt_Marca = new System.Windows.Forms.TextBox();
            this.txtIDActivoFijo = new System.Windows.Forms.TextBox();
            this.Txt_TipoActivo = new System.Windows.Forms.TextBox();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Dgv_Depreciacion = new System.Windows.Forms.DataGridView();
            this.Btn_depreci = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Dgv_Mantenimiento = new System.Windows.Forms.DataGridView();
            this.a.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Gpb_datosacti.SuspendLayout();
            this.Gpb_activofijo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Depreciacion)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Mantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Controls.Add(this.tabPage1);
            this.a.Controls.Add(this.tabPage2);
            this.a.Controls.Add(this.tabPage3);
            this.a.Location = new System.Drawing.Point(12, 12);
            this.a.Name = "a";
            this.a.SelectedIndex = 0;
            this.a.Size = new System.Drawing.Size(1035, 555);
            this.a.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabPage1.Controls.Add(this.Gpb_datosacti);
            this.tabPage1.Controls.Add(this.Gpb_activofijo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1027, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General ";
            // 
            // Gpb_datosacti
            // 
            this.Gpb_datosacti.Controls.Add(this.Lbl_cuenta);
            this.Gpb_datosacti.Controls.Add(this.Lbl_estado);
            this.Gpb_datosacti.Controls.Add(this.Lbl_valorRecidual);
            this.Gpb_datosacti.Controls.Add(this.Lbl_vidautil);
            this.Gpb_datosacti.Controls.Add(this.Lbl_costoadqui);
            this.Gpb_datosacti.Controls.Add(this.Lbl_fechaadqui);
            this.Gpb_datosacti.Controls.Add(this.dtp_FechaAdquisicion);
            this.Gpb_datosacti.Controls.Add(this.Txt_CostoAdquisicion);
            this.Gpb_datosacti.Controls.Add(this.Txt_Estado);
            this.Gpb_datosacti.Controls.Add(this.Txt_Cuenta);
            this.Gpb_datosacti.Controls.Add(this.Txt_VidaUtil);
            this.Gpb_datosacti.Controls.Add(this.Txt_ValorResidual);
            this.Gpb_datosacti.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_datosacti.Location = new System.Drawing.Point(505, 77);
            this.Gpb_datosacti.Name = "Gpb_datosacti";
            this.Gpb_datosacti.Size = new System.Drawing.Size(414, 331);
            this.Gpb_datosacti.TabIndex = 16;
            this.Gpb_datosacti.TabStop = false;
            this.Gpb_datosacti.Text = "Dato";
            // 
            // Lbl_cuenta
            // 
            this.Lbl_cuenta.AutoSize = true;
            this.Lbl_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cuenta.Location = new System.Drawing.Point(278, 230);
            this.Lbl_cuenta.Name = "Lbl_cuenta";
            this.Lbl_cuenta.Size = new System.Drawing.Size(59, 17);
            this.Lbl_cuenta.TabIndex = 25;
            this.Lbl_cuenta.Text = "Cuenta";
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado.Location = new System.Drawing.Point(136, 230);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(58, 17);
            this.Lbl_estado.TabIndex = 24;
            this.Lbl_estado.Text = "Estado";
            // 
            // Lbl_valorRecidual
            // 
            this.Lbl_valorRecidual.AutoSize = true;
            this.Lbl_valorRecidual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_valorRecidual.Location = new System.Drawing.Point(6, 230);
            this.Lbl_valorRecidual.Name = "Lbl_valorRecidual";
            this.Lbl_valorRecidual.Size = new System.Drawing.Size(114, 17);
            this.Lbl_valorRecidual.TabIndex = 23;
            this.Lbl_valorRecidual.Text = "Valor Recidual";
            // 
            // Lbl_vidautil
            // 
            this.Lbl_vidautil.AutoSize = true;
            this.Lbl_vidautil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_vidautil.Location = new System.Drawing.Point(9, 166);
            this.Lbl_vidautil.Name = "Lbl_vidautil";
            this.Lbl_vidautil.Size = new System.Drawing.Size(69, 17);
            this.Lbl_vidautil.TabIndex = 22;
            this.Lbl_vidautil.Text = "Vida Util";
            // 
            // Lbl_costoadqui
            // 
            this.Lbl_costoadqui.AutoSize = true;
            this.Lbl_costoadqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_costoadqui.Location = new System.Drawing.Point(6, 105);
            this.Lbl_costoadqui.Name = "Lbl_costoadqui";
            this.Lbl_costoadqui.Size = new System.Drawing.Size(159, 17);
            this.Lbl_costoadqui.TabIndex = 21;
            this.Lbl_costoadqui.Text = "Costo de adquicision";
            // 
            // Lbl_fechaadqui
            // 
            this.Lbl_fechaadqui.AutoSize = true;
            this.Lbl_fechaadqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechaadqui.Location = new System.Drawing.Point(6, 44);
            this.Lbl_fechaadqui.Name = "Lbl_fechaadqui";
            this.Lbl_fechaadqui.Size = new System.Drawing.Size(162, 17);
            this.Lbl_fechaadqui.TabIndex = 20;
            this.Lbl_fechaadqui.Text = "Fecha de adquicision";
            // 
            // dtp_FechaAdquisicion
            // 
            this.dtp_FechaAdquisicion.Location = new System.Drawing.Point(6, 64);
            this.dtp_FechaAdquisicion.Name = "dtp_FechaAdquisicion";
            this.dtp_FechaAdquisicion.Size = new System.Drawing.Size(265, 22);
            this.dtp_FechaAdquisicion.TabIndex = 11;
            // 
            // Txt_CostoAdquisicion
            // 
            this.Txt_CostoAdquisicion.Location = new System.Drawing.Point(9, 125);
            this.Txt_CostoAdquisicion.Name = "Txt_CostoAdquisicion";
            this.Txt_CostoAdquisicion.Size = new System.Drawing.Size(100, 22);
            this.Txt_CostoAdquisicion.TabIndex = 6;
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Location = new System.Drawing.Point(139, 250);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(100, 22);
            this.Txt_Estado.TabIndex = 9;
            // 
            // Txt_Cuenta
            // 
            this.Txt_Cuenta.Location = new System.Drawing.Point(281, 250);
            this.Txt_Cuenta.Name = "Txt_Cuenta";
            this.Txt_Cuenta.Size = new System.Drawing.Size(100, 22);
            this.Txt_Cuenta.TabIndex = 14;
            // 
            // Txt_VidaUtil
            // 
            this.Txt_VidaUtil.Location = new System.Drawing.Point(9, 186);
            this.Txt_VidaUtil.Name = "Txt_VidaUtil";
            this.Txt_VidaUtil.Size = new System.Drawing.Size(100, 22);
            this.Txt_VidaUtil.TabIndex = 7;
            // 
            // Txt_ValorResidual
            // 
            this.Txt_ValorResidual.Location = new System.Drawing.Point(6, 250);
            this.Txt_ValorResidual.Name = "Txt_ValorResidual";
            this.Txt_ValorResidual.Size = new System.Drawing.Size(100, 22);
            this.Txt_ValorResidual.TabIndex = 8;
            // 
            // Gpb_activofijo
            // 
            this.Gpb_activofijo.Controls.Add(this.Lbl_Tipoactivo);
            this.Gpb_activofijo.Controls.Add(this.Lbl_Marca);
            this.Gpb_activofijo.Controls.Add(this.Lbl_Modelo);
            this.Gpb_activofijo.Controls.Add(this.Lbl_idactivo);
            this.Gpb_activofijo.Controls.Add(this.Lbl_codigo);
            this.Gpb_activofijo.Controls.Add(this.Lbl_descripcion);
            this.Gpb_activofijo.Controls.Add(this.Txt_CodigoActivo);
            this.Gpb_activofijo.Controls.Add(this.Txt_Modelo);
            this.Gpb_activofijo.Controls.Add(this.Txt_Marca);
            this.Gpb_activofijo.Controls.Add(this.txtIDActivoFijo);
            this.Gpb_activofijo.Controls.Add(this.Txt_TipoActivo);
            this.Gpb_activofijo.Controls.Add(this.Txt_Descripcion);
            this.Gpb_activofijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_activofijo.Location = new System.Drawing.Point(25, 77);
            this.Gpb_activofijo.Name = "Gpb_activofijo";
            this.Gpb_activofijo.Size = new System.Drawing.Size(449, 331);
            this.Gpb_activofijo.TabIndex = 15;
            this.Gpb_activofijo.TabStop = false;
            this.Gpb_activofijo.Text = "Activo";
            // 
            // Lbl_Tipoactivo
            // 
            this.Lbl_Tipoactivo.AutoSize = true;
            this.Lbl_Tipoactivo.Location = new System.Drawing.Point(230, 299);
            this.Lbl_Tipoactivo.Name = "Lbl_Tipoactivo";
            this.Lbl_Tipoactivo.Size = new System.Drawing.Size(83, 17);
            this.Lbl_Tipoactivo.TabIndex = 19;
            this.Lbl_Tipoactivo.Text = "Tipoactivo";
            // 
            // Lbl_Marca
            // 
            this.Lbl_Marca.AutoSize = true;
            this.Lbl_Marca.Location = new System.Drawing.Point(12, 188);
            this.Lbl_Marca.Name = "Lbl_Marca";
            this.Lbl_Marca.Size = new System.Drawing.Size(52, 17);
            this.Lbl_Marca.TabIndex = 18;
            this.Lbl_Marca.Text = "Marca";
            // 
            // Lbl_Modelo
            // 
            this.Lbl_Modelo.AutoSize = true;
            this.Lbl_Modelo.Location = new System.Drawing.Point(12, 251);
            this.Lbl_Modelo.Name = "Lbl_Modelo";
            this.Lbl_Modelo.Size = new System.Drawing.Size(60, 17);
            this.Lbl_Modelo.TabIndex = 17;
            this.Lbl_Modelo.Text = "Modelo";
            // 
            // Lbl_idactivo
            // 
            this.Lbl_idactivo.AutoSize = true;
            this.Lbl_idactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idactivo.Location = new System.Drawing.Point(265, 127);
            this.Lbl_idactivo.Name = "Lbl_idactivo";
            this.Lbl_idactivo.Size = new System.Drawing.Size(67, 17);
            this.Lbl_idactivo.TabIndex = 16;
            this.Lbl_idactivo.Text = "IDActivo";
            // 
            // Lbl_codigo
            // 
            this.Lbl_codigo.AutoSize = true;
            this.Lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigo.Location = new System.Drawing.Point(12, 37);
            this.Lbl_codigo.Name = "Lbl_codigo";
            this.Lbl_codigo.Size = new System.Drawing.Size(58, 17);
            this.Lbl_codigo.TabIndex = 15;
            this.Lbl_codigo.Text = "Codigo";
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Location = new System.Drawing.Point(12, 127);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(93, 17);
            this.Lbl_descripcion.TabIndex = 14;
            this.Lbl_descripcion.Text = "Descripcion";
            // 
            // Txt_CodigoActivo
            // 
            this.Txt_CodigoActivo.Location = new System.Drawing.Point(70, 37);
            this.Txt_CodigoActivo.Name = "Txt_CodigoActivo";
            this.Txt_CodigoActivo.Size = new System.Drawing.Size(100, 22);
            this.Txt_CodigoActivo.TabIndex = 2;
            // 
            // Txt_Modelo
            // 
            this.Txt_Modelo.Location = new System.Drawing.Point(15, 271);
            this.Txt_Modelo.Name = "Txt_Modelo";
            this.Txt_Modelo.Size = new System.Drawing.Size(100, 22);
            this.Txt_Modelo.TabIndex = 4;
            // 
            // Txt_Marca
            // 
            this.Txt_Marca.Location = new System.Drawing.Point(15, 212);
            this.Txt_Marca.Name = "Txt_Marca";
            this.Txt_Marca.Size = new System.Drawing.Size(100, 22);
            this.Txt_Marca.TabIndex = 13;
            // 
            // txtIDActivoFijo
            // 
            this.txtIDActivoFijo.Location = new System.Drawing.Point(268, 147);
            this.txtIDActivoFijo.Name = "txtIDActivoFijo";
            this.txtIDActivoFijo.Size = new System.Drawing.Size(100, 22);
            this.txtIDActivoFijo.TabIndex = 10;
            // 
            // Txt_TipoActivo
            // 
            this.Txt_TipoActivo.Location = new System.Drawing.Point(319, 296);
            this.Txt_TipoActivo.Name = "Txt_TipoActivo";
            this.Txt_TipoActivo.Size = new System.Drawing.Size(100, 22);
            this.Txt_TipoActivo.TabIndex = 12;
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(15, 147);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(226, 22);
            this.Txt_Descripcion.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabPage2.Controls.Add(this.Dgv_Depreciacion);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1027, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Depreciacion";
            // 
            // Dgv_Depreciacion
            // 
            this.Dgv_Depreciacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Depreciacion.Location = new System.Drawing.Point(7, 26);
            this.Dgv_Depreciacion.Name = "Dgv_Depreciacion";
            this.Dgv_Depreciacion.RowHeadersWidth = 51;
            this.Dgv_Depreciacion.RowTemplate.Height = 24;
            this.Dgv_Depreciacion.Size = new System.Drawing.Size(1017, 500);
            this.Dgv_Depreciacion.TabIndex = 0;
            this.Dgv_Depreciacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Depreciacion_CellContentClick);
            // 
            // Btn_depreci
            // 
            this.Btn_depreci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_depreci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_depreci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_depreci.Image = global::CapaVistaActivofijo.Properties.Resources.Reportes_V3;
            this.Btn_depreci.Location = new System.Drawing.Point(934, 573);
            this.Btn_depreci.Name = "Btn_depreci";
            this.Btn_depreci.Size = new System.Drawing.Size(109, 103);
            this.Btn_depreci.TabIndex = 10;
            this.Btn_depreci.Text = "Reprote";
            this.Btn_depreci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_depreci.UseVisualStyleBackColor = true;
            this.Btn_depreci.Click += new System.EventHandler(this.Btn_depreci_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabPage3.Controls.Add(this.Dgv_Mantenimiento);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1027, 526);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mantenimiento";
            // 
            // Dgv_Mantenimiento
            // 
            this.Dgv_Mantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Mantenimiento.Location = new System.Drawing.Point(5, 13);
            this.Dgv_Mantenimiento.Name = "Dgv_Mantenimiento";
            this.Dgv_Mantenimiento.RowHeadersWidth = 51;
            this.Dgv_Mantenimiento.RowTemplate.Height = 24;
            this.Dgv_Mantenimiento.Size = new System.Drawing.Size(1017, 500);
            this.Dgv_Mantenimiento.TabIndex = 1;
            this.Dgv_Mantenimiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Mantenimiento_CellContentClick);
            // 
            // Frm_VistadeActivofijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1055, 686);
            this.Controls.Add(this.Btn_depreci);
            this.Controls.Add(this.a);
            this.Name = "Frm_VistadeActivofijo";
            this.Text = "FrmVistadeActivofijo";
            this.a.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Gpb_datosacti.ResumeLayout(false);
            this.Gpb_datosacti.PerformLayout();
            this.Gpb_activofijo.ResumeLayout(false);
            this.Gpb_activofijo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Depreciacion)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Mantenimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl a;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox Gpb_datosacti;
        private System.Windows.Forms.Label Lbl_cuenta;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.Label Lbl_valorRecidual;
        private System.Windows.Forms.Label Lbl_vidautil;
        private System.Windows.Forms.Label Lbl_costoadqui;
        private System.Windows.Forms.Label Lbl_fechaadqui;
        public System.Windows.Forms.DateTimePicker dtp_FechaAdquisicion;
        public System.Windows.Forms.TextBox Txt_CostoAdquisicion;
        public System.Windows.Forms.TextBox Txt_Estado;
        public System.Windows.Forms.TextBox Txt_Cuenta;
        public System.Windows.Forms.TextBox Txt_VidaUtil;
        public System.Windows.Forms.TextBox Txt_ValorResidual;
        private System.Windows.Forms.GroupBox Gpb_activofijo;
        private System.Windows.Forms.Label Lbl_Tipoactivo;
        private System.Windows.Forms.Label Lbl_Marca;
        private System.Windows.Forms.Label Lbl_Modelo;
        private System.Windows.Forms.Label Lbl_idactivo;
        private System.Windows.Forms.Label Lbl_codigo;
        private System.Windows.Forms.Label Lbl_descripcion;
        public System.Windows.Forms.TextBox Txt_CodigoActivo;
        public System.Windows.Forms.TextBox Txt_Modelo;
        public System.Windows.Forms.TextBox Txt_Marca;
        public System.Windows.Forms.TextBox txtIDActivoFijo;
        public System.Windows.Forms.TextBox Txt_TipoActivo;
        public System.Windows.Forms.TextBox Txt_Descripcion;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.DataGridView Dgv_Depreciacion;
        private System.Windows.Forms.Button Btn_depreci;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.DataGridView Dgv_Mantenimiento;
    }
}