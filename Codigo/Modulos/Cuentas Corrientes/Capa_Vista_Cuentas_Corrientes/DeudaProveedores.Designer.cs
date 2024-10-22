
namespace Capa_Vista_Cuentas_Corrientes
{
    partial class DeudaProveedores
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
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Dgv_deudas = new System.Windows.Forms.DataGridView();
            this.Cbo_id_pago = new System.Windows.Forms.ComboBox();
            this.Cbo_id_proveedor = new System.Windows.Forms.ComboBox();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Txt_Descipcion = new System.Windows.Forms.TextBox();
            this.Dtp_FechaV = new System.Windows.Forms.DateTimePicker();
            this.Dtp_FechaI = new System.Windows.Forms.DateTimePicker();
            this.Lbl_descrip_deuda = new System.Windows.Forms.Label();
            this.Lbl_estado_deuda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_montoDeuda = new System.Windows.Forms.TextBox();
            this.Lbl_id_pago_deuda = new System.Windows.Forms.Label();
            this.Lbl_monto_dueda = new System.Windows.Forms.Label();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Txt_id_deuda = new System.Windows.Forms.TextBox();
            this.Lbl_id_deuda = new System.Windows.Forms.Label();
            this.Lbl_inicio_deuda = new System.Windows.Forms.Label();
            this.Lbl_vencimiento_deuda = new System.Windows.Forms.Label();
            this.Lbl_id_DeudaP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_deudas)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(825, 83);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(151, 43);
            this.Btn_Buscar.TabIndex = 105;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Dgv_deudas
            // 
            this.Dgv_deudas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_deudas.Location = new System.Drawing.Point(30, 400);
            this.Dgv_deudas.Name = "Dgv_deudas";
            this.Dgv_deudas.RowHeadersWidth = 51;
            this.Dgv_deudas.RowTemplate.Height = 24;
            this.Dgv_deudas.Size = new System.Drawing.Size(1120, 254);
            this.Dgv_deudas.TabIndex = 104;
            // 
            // Cbo_id_pago
            // 
            this.Cbo_id_pago.FormattingEnabled = true;
            this.Cbo_id_pago.Location = new System.Drawing.Point(278, 259);
            this.Cbo_id_pago.Name = "Cbo_id_pago";
            this.Cbo_id_pago.Size = new System.Drawing.Size(121, 24);
            this.Cbo_id_pago.TabIndex = 103;
            // 
            // Cbo_id_proveedor
            // 
            this.Cbo_id_proveedor.FormattingEnabled = true;
            this.Cbo_id_proveedor.Location = new System.Drawing.Point(279, 216);
            this.Cbo_id_proveedor.Name = "Cbo_id_proveedor";
            this.Cbo_id_proveedor.Size = new System.Drawing.Size(121, 24);
            this.Cbo_id_proveedor.TabIndex = 101;
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Location = new System.Drawing.Point(477, 83);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(151, 43);
            this.Btn_Actualizar.TabIndex = 100;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(136, 83);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(151, 43);
            this.Btn_guardar.TabIndex = 99;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Location = new System.Drawing.Point(653, 83);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(151, 43);
            this.Btn_eliminar.TabIndex = 98;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(307, 83);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(151, 43);
            this.Btn_editar.TabIndex = 97;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            // 
            // Txt_Descipcion
            // 
            this.Txt_Descipcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Descipcion.Location = new System.Drawing.Point(825, 257);
            this.Txt_Descipcion.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Descipcion.Name = "Txt_Descipcion";
            this.Txt_Descipcion.Size = new System.Drawing.Size(325, 30);
            this.Txt_Descipcion.TabIndex = 96;
            // 
            // Dtp_FechaV
            // 
            this.Dtp_FechaV.Location = new System.Drawing.Point(824, 223);
            this.Dtp_FechaV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dtp_FechaV.Name = "Dtp_FechaV";
            this.Dtp_FechaV.Size = new System.Drawing.Size(269, 22);
            this.Dtp_FechaV.TabIndex = 95;
            // 
            // Dtp_FechaI
            // 
            this.Dtp_FechaI.Location = new System.Drawing.Point(824, 181);
            this.Dtp_FechaI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dtp_FechaI.Name = "Dtp_FechaI";
            this.Dtp_FechaI.Size = new System.Drawing.Size(269, 22);
            this.Dtp_FechaI.TabIndex = 94;
            // 
            // Lbl_descrip_deuda
            // 
            this.Lbl_descrip_deuda.AutoSize = true;
            this.Lbl_descrip_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descrip_deuda.Location = new System.Drawing.Point(571, 262);
            this.Lbl_descrip_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_descrip_deuda.Name = "Lbl_descrip_deuda";
            this.Lbl_descrip_deuda.Size = new System.Drawing.Size(199, 23);
            this.Lbl_descrip_deuda.TabIndex = 93;
            this.Lbl_descrip_deuda.Text = "Descripcion de la Deuda:";
            // 
            // Lbl_estado_deuda
            // 
            this.Lbl_estado_deuda.AutoSize = true;
            this.Lbl_estado_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estado_deuda.Location = new System.Drawing.Point(571, 300);
            this.Lbl_estado_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_estado_deuda.Name = "Lbl_estado_deuda";
            this.Lbl_estado_deuda.Size = new System.Drawing.Size(160, 23);
            this.Lbl_estado_deuda.TabIndex = 92;
            this.Lbl_estado_deuda.Text = "Estado de la Deuda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(619, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 21);
            this.label3.TabIndex = 91;
            this.label3.Text = " ";
            // 
            // Txt_montoDeuda
            // 
            this.Txt_montoDeuda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_montoDeuda.Location = new System.Drawing.Point(279, 300);
            this.Txt_montoDeuda.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_montoDeuda.Name = "Txt_montoDeuda";
            this.Txt_montoDeuda.Size = new System.Drawing.Size(268, 30);
            this.Txt_montoDeuda.TabIndex = 90;
            // 
            // Lbl_id_pago_deuda
            // 
            this.Lbl_id_pago_deuda.AutoSize = true;
            this.Lbl_id_pago_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_pago_deuda.Location = new System.Drawing.Point(25, 258);
            this.Lbl_id_pago_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_pago_deuda.Name = "Lbl_id_pago_deuda";
            this.Lbl_id_pago_deuda.Size = new System.Drawing.Size(69, 23);
            this.Lbl_id_pago_deuda.TabIndex = 89;
            this.Lbl_id_pago_deuda.Text = "Id Pago:";
            // 
            // Lbl_monto_dueda
            // 
            this.Lbl_monto_dueda.AutoSize = true;
            this.Lbl_monto_dueda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_monto_dueda.Location = new System.Drawing.Point(25, 302);
            this.Lbl_monto_dueda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_monto_dueda.Name = "Lbl_monto_dueda";
            this.Lbl_monto_dueda.Size = new System.Drawing.Size(139, 23);
            this.Lbl_monto_dueda.TabIndex = 88;
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
            this.Cbo_estado.Location = new System.Drawing.Point(825, 296);
            this.Cbo_estado.Margin = new System.Windows.Forms.Padding(4);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(268, 24);
            this.Cbo_estado.TabIndex = 87;
            // 
            // Txt_id_deuda
            // 
            this.Txt_id_deuda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_id_deuda.Location = new System.Drawing.Point(280, 174);
            this.Txt_id_deuda.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_id_deuda.Name = "Txt_id_deuda";
            this.Txt_id_deuda.Size = new System.Drawing.Size(268, 30);
            this.Txt_id_deuda.TabIndex = 86;
            // 
            // Lbl_id_deuda
            // 
            this.Lbl_id_deuda.AutoSize = true;
            this.Lbl_id_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_deuda.Location = new System.Drawing.Point(26, 179);
            this.Lbl_id_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_deuda.Name = "Lbl_id_deuda";
            this.Lbl_id_deuda.Size = new System.Drawing.Size(83, 23);
            this.Lbl_id_deuda.TabIndex = 85;
            this.Lbl_id_deuda.Text = "Id Deuda:";
            // 
            // Lbl_inicio_deuda
            // 
            this.Lbl_inicio_deuda.AutoSize = true;
            this.Lbl_inicio_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_inicio_deuda.Location = new System.Drawing.Point(571, 184);
            this.Lbl_inicio_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_inicio_deuda.Name = "Lbl_inicio_deuda";
            this.Lbl_inicio_deuda.Size = new System.Drawing.Size(158, 23);
            this.Lbl_inicio_deuda.TabIndex = 84;
            this.Lbl_inicio_deuda.Text = "Fecha Inicio Deuda:";
            // 
            // Lbl_vencimiento_deuda
            // 
            this.Lbl_vencimiento_deuda.AutoSize = true;
            this.Lbl_vencimiento_deuda.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_vencimiento_deuda.Location = new System.Drawing.Point(571, 223);
            this.Lbl_vencimiento_deuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_vencimiento_deuda.Name = "Lbl_vencimiento_deuda";
            this.Lbl_vencimiento_deuda.Size = new System.Drawing.Size(212, 23);
            this.Lbl_vencimiento_deuda.TabIndex = 83;
            this.Lbl_vencimiento_deuda.Text = "Fecha Vencimiento Deuda:";
            // 
            // Lbl_id_DeudaP
            // 
            this.Lbl_id_DeudaP.AutoSize = true;
            this.Lbl_id_DeudaP.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_DeudaP.Location = new System.Drawing.Point(26, 219);
            this.Lbl_id_DeudaP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_id_DeudaP.Name = "Lbl_id_DeudaP";
            this.Lbl_id_DeudaP.Size = new System.Drawing.Size(126, 23);
            this.Lbl_id_DeudaP.TabIndex = 81;
            this.Lbl_id_DeudaP.Text = "No. Proveedor: ";
            // 
            // DeudaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1168, 675);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Dgv_deudas);
            this.Controls.Add(this.Cbo_id_pago);
            this.Controls.Add(this.Cbo_id_proveedor);
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
            this.Controls.Add(this.Lbl_id_DeudaP);
            this.Name = "DeudaProveedores";
            this.Text = "DeudaProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_deudas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.DataGridView Dgv_deudas;
        private System.Windows.Forms.ComboBox Cbo_id_pago;
        private System.Windows.Forms.ComboBox Cbo_id_proveedor;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.TextBox Txt_Descipcion;
        private System.Windows.Forms.DateTimePicker Dtp_FechaV;
        private System.Windows.Forms.DateTimePicker Dtp_FechaI;
        private System.Windows.Forms.Label Lbl_descrip_deuda;
        private System.Windows.Forms.Label Lbl_estado_deuda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_montoDeuda;
        private System.Windows.Forms.Label Lbl_id_pago_deuda;
        private System.Windows.Forms.Label Lbl_monto_dueda;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.TextBox Txt_id_deuda;
        private System.Windows.Forms.Label Lbl_id_deuda;
        private System.Windows.Forms.Label Lbl_inicio_deuda;
        private System.Windows.Forms.Label Lbl_vencimiento_deuda;
        private System.Windows.Forms.Label Lbl_id_DeudaP;
    }
}