
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class Deuda_Clts
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
            this.Txt_montoDeuda = new System.Windows.Forms.TextBox();
            this.Lbl_id_pago_deuda = new System.Windows.Forms.Label();
            this.Lbl_monto_dueda = new System.Windows.Forms.Label();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Txt_id_deuda = new System.Windows.Forms.TextBox();
            this.Lbl_id_deuda = new System.Windows.Forms.Label();
            this.Lbl_inicio_deuda = new System.Windows.Forms.Label();
            this.Lbl_vencimiento_deuda = new System.Windows.Forms.Label();
            this.Lbl_id_cobra_deuda = new System.Windows.Forms.Label();
            this.Lbl_id_clt_deuda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_estado_deuda = new System.Windows.Forms.Label();
            this.Lbl_descrip_deuda = new System.Windows.Forms.Label();
            this.Dtp_FechaI = new System.Windows.Forms.DateTimePicker();
            this.Dtp_FechaV = new System.Windows.Forms.DateTimePicker();
            this.Txt_Descipcion = new System.Windows.Forms.TextBox();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Cbo_id_clientes = new System.Windows.Forms.ComboBox();
            this.Cbo_id_cobrador = new System.Windows.Forms.ComboBox();
            this.Cbo_id_pago = new System.Windows.Forms.ComboBox();
            this.Dgv_deudas = new System.Windows.Forms.DataGridView();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_deudas)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_montoDeuda
            // 
            this.Txt_montoDeuda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_montoDeuda.Location = new System.Drawing.Point(272, 354);
            this.Txt_montoDeuda.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_montoDeuda.Name = "Txt_montoDeuda";
            this.Txt_montoDeuda.Size = new System.Drawing.Size(268, 30);
            this.Txt_montoDeuda.TabIndex = 56;
            // 
            // Lbl_id_pago_deuda
            // 
            this.Lbl_id_pago_deuda.AutoSize = true;
            this.Lbl_id_pago_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_pago_deuda.Location = new System.Drawing.Point(18, 312);
            this.Lbl_id_pago_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_pago_deuda.Name = "Lbl_id_pago_deuda";
            this.Lbl_id_pago_deuda.Size = new System.Drawing.Size(69, 23);
            this.Lbl_id_pago_deuda.TabIndex = 55;
            this.Lbl_id_pago_deuda.Text = "Id Pago:";
            // 
            // Lbl_monto_dueda
            // 
            this.Lbl_monto_dueda.AutoSize = true;
            this.Lbl_monto_dueda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_monto_dueda.Location = new System.Drawing.Point(18, 356);
            this.Lbl_monto_dueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_monto_dueda.Name = "Lbl_monto_dueda";
            this.Lbl_monto_dueda.Size = new System.Drawing.Size(139, 23);
            this.Lbl_monto_dueda.TabIndex = 54;
            this.Lbl_monto_dueda.Text = "Monto de Deuda:";
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.AutoCompleteCustomSource.AddRange(new string[] {
            "1. Habilitado",
            "2. Inhabilitado"});
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "1",
            "0"});
            this.Cbo_estado.Location = new System.Drawing.Point(817, 307);
            this.Cbo_estado.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(268, 24);
            this.Cbo_estado.TabIndex = 53;
            // 
            // Txt_id_deuda
            // 
            this.Txt_id_deuda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id_deuda.Location = new System.Drawing.Point(272, 185);
            this.Txt_id_deuda.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_id_deuda.Name = "Txt_id_deuda";
            this.Txt_id_deuda.Size = new System.Drawing.Size(268, 30);
            this.Txt_id_deuda.TabIndex = 52;
            // 
            // Lbl_id_deuda
            // 
            this.Lbl_id_deuda.AutoSize = true;
            this.Lbl_id_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_deuda.Location = new System.Drawing.Point(18, 190);
            this.Lbl_id_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_deuda.Name = "Lbl_id_deuda";
            this.Lbl_id_deuda.Size = new System.Drawing.Size(83, 23);
            this.Lbl_id_deuda.TabIndex = 51;
            this.Lbl_id_deuda.Text = "Id Deuda:";
            // 
            // Lbl_inicio_deuda
            // 
            this.Lbl_inicio_deuda.AutoSize = true;
            this.Lbl_inicio_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_inicio_deuda.Location = new System.Drawing.Point(563, 195);
            this.Lbl_inicio_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_inicio_deuda.Name = "Lbl_inicio_deuda";
            this.Lbl_inicio_deuda.Size = new System.Drawing.Size(158, 23);
            this.Lbl_inicio_deuda.TabIndex = 49;
            this.Lbl_inicio_deuda.Text = "Fecha Inicio Deuda:";
            // 
            // Lbl_vencimiento_deuda
            // 
            this.Lbl_vencimiento_deuda.AutoSize = true;
            this.Lbl_vencimiento_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_vencimiento_deuda.Location = new System.Drawing.Point(563, 234);
            this.Lbl_vencimiento_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_vencimiento_deuda.Name = "Lbl_vencimiento_deuda";
            this.Lbl_vencimiento_deuda.Size = new System.Drawing.Size(212, 23);
            this.Lbl_vencimiento_deuda.TabIndex = 46;
            this.Lbl_vencimiento_deuda.Text = "Fecha Vencimiento Deuda:";
            // 
            // Lbl_id_cobra_deuda
            // 
            this.Lbl_id_cobra_deuda.AutoSize = true;
            this.Lbl_id_cobra_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_cobra_deuda.Location = new System.Drawing.Point(18, 275);
            this.Lbl_id_cobra_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_cobra_deuda.Name = "Lbl_id_cobra_deuda";
            this.Lbl_id_cobra_deuda.Size = new System.Drawing.Size(106, 23);
            this.Lbl_id_cobra_deuda.TabIndex = 45;
            this.Lbl_id_cobra_deuda.Text = "Id Cobrador:";
            // 
            // Lbl_id_clt_deuda
            // 
            this.Lbl_id_clt_deuda.AutoSize = true;
            this.Lbl_id_clt_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_clt_deuda.Location = new System.Drawing.Point(18, 230);
            this.Lbl_id_clt_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_clt_deuda.Name = "Lbl_id_clt_deuda";
            this.Lbl_id_clt_deuda.Size = new System.Drawing.Size(91, 23);
            this.Lbl_id_clt_deuda.TabIndex = 44;
            this.Lbl_id_clt_deuda.Text = "Id Cliente: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "DEUDAS - CLIENTES -\r\n";
            // 
            // Lbl_estado_deuda
            // 
            this.Lbl_estado_deuda.AutoSize = true;
            this.Lbl_estado_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado_deuda.Location = new System.Drawing.Point(563, 311);
            this.Lbl_estado_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_estado_deuda.Name = "Lbl_estado_deuda";
            this.Lbl_estado_deuda.Size = new System.Drawing.Size(160, 23);
            this.Lbl_estado_deuda.TabIndex = 61;
            this.Lbl_estado_deuda.Text = "Estado de la Deuda:";
            // 
            // Lbl_descrip_deuda
            // 
            this.Lbl_descrip_deuda.AutoSize = true;
            this.Lbl_descrip_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descrip_deuda.Location = new System.Drawing.Point(563, 273);
            this.Lbl_descrip_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_descrip_deuda.Name = "Lbl_descrip_deuda";
            this.Lbl_descrip_deuda.Size = new System.Drawing.Size(199, 23);
            this.Lbl_descrip_deuda.TabIndex = 62;
            this.Lbl_descrip_deuda.Text = "Descripcion de la Deuda:";
            // 
            // Dtp_FechaI
            // 
            this.Dtp_FechaI.Location = new System.Drawing.Point(816, 192);
            this.Dtp_FechaI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dtp_FechaI.Name = "Dtp_FechaI";
            this.Dtp_FechaI.Size = new System.Drawing.Size(269, 22);
            this.Dtp_FechaI.TabIndex = 63;
            // 
            // Dtp_FechaV
            // 
            this.Dtp_FechaV.Location = new System.Drawing.Point(816, 234);
            this.Dtp_FechaV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dtp_FechaV.Name = "Dtp_FechaV";
            this.Dtp_FechaV.Size = new System.Drawing.Size(269, 22);
            this.Dtp_FechaV.TabIndex = 64;
            // 
            // Txt_Descipcion
            // 
            this.Txt_Descipcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descipcion.Location = new System.Drawing.Point(817, 268);
            this.Txt_Descipcion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Descipcion.Name = "Txt_Descipcion";
            this.Txt_Descipcion.Size = new System.Drawing.Size(325, 30);
            this.Txt_Descipcion.TabIndex = 65;
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Location = new System.Drawing.Point(353, 86);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(151, 43);
            this.Btn_Actualizar.TabIndex = 75;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(12, 86);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(151, 43);
            this.Btn_guardar.TabIndex = 74;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Location = new System.Drawing.Point(529, 86);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(151, 43);
            this.Btn_eliminar.TabIndex = 73;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(183, 86);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(151, 43);
            this.Btn_editar.TabIndex = 71;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Cbo_id_clientes
            // 
            this.Cbo_id_clientes.FormattingEnabled = true;
            this.Cbo_id_clientes.Location = new System.Drawing.Point(271, 227);
            this.Cbo_id_clientes.Name = "Cbo_id_clientes";
            this.Cbo_id_clientes.Size = new System.Drawing.Size(121, 24);
            this.Cbo_id_clientes.TabIndex = 76;
            // 
            // Cbo_id_cobrador
            // 
            this.Cbo_id_cobrador.FormattingEnabled = true;
            this.Cbo_id_cobrador.Location = new System.Drawing.Point(271, 274);
            this.Cbo_id_cobrador.Name = "Cbo_id_cobrador";
            this.Cbo_id_cobrador.Size = new System.Drawing.Size(121, 24);
            this.Cbo_id_cobrador.TabIndex = 77;
            // 
            // Cbo_id_pago
            // 
            this.Cbo_id_pago.FormattingEnabled = true;
            this.Cbo_id_pago.Location = new System.Drawing.Point(271, 313);
            this.Cbo_id_pago.Name = "Cbo_id_pago";
            this.Cbo_id_pago.Size = new System.Drawing.Size(121, 24);
            this.Cbo_id_pago.TabIndex = 78;
            // 
            // Dgv_deudas
            // 
            this.Dgv_deudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_deudas.Location = new System.Drawing.Point(22, 411);
            this.Dgv_deudas.Name = "Dgv_deudas";
            this.Dgv_deudas.RowHeadersWidth = 51;
            this.Dgv_deudas.RowTemplate.Height = 24;
            this.Dgv_deudas.Size = new System.Drawing.Size(1120, 254);
            this.Dgv_deudas.TabIndex = 79;
            this.Dgv_deudas.DoubleClick += new System.EventHandler(this.Dgv_deudas_DoubleClick);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(701, 86);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(151, 43);
            this.Btn_Buscar.TabIndex = 80;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Deuda_Clts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1210, 760);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Dgv_deudas);
            this.Controls.Add(this.Cbo_id_pago);
            this.Controls.Add(this.Cbo_id_cobrador);
            this.Controls.Add(this.Cbo_id_clientes);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Txt_Descipcion);
            this.Controls.Add(this.Dtp_FechaV);
            this.Controls.Add(this.Dtp_FechaI);
            this.Controls.Add(this.Lbl_descrip_deuda);
            this.Controls.Add(this.Lbl_estado_deuda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_montoDeuda);
            this.Controls.Add(this.Lbl_id_pago_deuda);
            this.Controls.Add(this.Lbl_monto_dueda);
            this.Controls.Add(this.Cbo_estado);
            this.Controls.Add(this.Txt_id_deuda);
            this.Controls.Add(this.Lbl_id_deuda);
            this.Controls.Add(this.Lbl_inicio_deuda);
            this.Controls.Add(this.Lbl_vencimiento_deuda);
            this.Controls.Add(this.Lbl_id_cobra_deuda);
            this.Controls.Add(this.Lbl_id_clt_deuda);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Deuda_Clts";
            this.Text = "Deuda_Clts";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_deudas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_montoDeuda;
        private System.Windows.Forms.Label Lbl_id_pago_deuda;
        private System.Windows.Forms.Label Lbl_monto_dueda;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.TextBox Txt_id_deuda;
        private System.Windows.Forms.Label Lbl_id_deuda;
        private System.Windows.Forms.Label Lbl_inicio_deuda;
        private System.Windows.Forms.Label Lbl_vencimiento_deuda;
        private System.Windows.Forms.Label Lbl_id_cobra_deuda;
        private System.Windows.Forms.Label Lbl_id_clt_deuda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_estado_deuda;
        private System.Windows.Forms.Label Lbl_descrip_deuda;
        private System.Windows.Forms.DateTimePicker Dtp_FechaI;
        private System.Windows.Forms.DateTimePicker Dtp_FechaV;
        private System.Windows.Forms.TextBox Txt_Descipcion;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.ComboBox Cbo_id_clientes;
        private System.Windows.Forms.ComboBox Cbo_id_cobrador;
        private System.Windows.Forms.ComboBox Cbo_id_pago;
        private System.Windows.Forms.DataGridView Dgv_deudas;
        private System.Windows.Forms.Button Btn_Buscar;
    }
}