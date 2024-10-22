
namespace Capa_Vista_Logistica
{
    partial class MantenimientoVehiculos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID_mantenimiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_TipoMantenimiento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_ComponenteAfectado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Fecha_mantenimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_responsableAsignado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CodigoError = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.txt_TiempoEstimado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_generarPDF = new System.Windows.Forms.Button();
            this.txt_NombreSolicitante = new System.Windows.Forms.TextBox();
            this.txt_fk_id_movimiento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Solicitante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Formulario de solicitud de mantenimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID_mantenimiento";
            // 
            // txtID_mantenimiento
            // 
            this.txtID_mantenimiento.Location = new System.Drawing.Point(129, 44);
            this.txtID_mantenimiento.Name = "txtID_mantenimiento";
            this.txtID_mantenimiento.Size = new System.Drawing.Size(254, 20);
            this.txtID_mantenimiento.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo de mantenimiento";
            // 
            // cmb_TipoMantenimiento
            // 
            this.cmb_TipoMantenimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoMantenimiento.FormattingEnabled = true;
            this.cmb_TipoMantenimiento.Items.AddRange(new object[] {
            "Mantenimiento Preventivo",
            "Mantenimiento Correctivo"});
            this.cmb_TipoMantenimiento.Location = new System.Drawing.Point(129, 117);
            this.cmb_TipoMantenimiento.Name = "cmb_TipoMantenimiento";
            this.cmb_TipoMantenimiento.Size = new System.Drawing.Size(254, 21);
            this.cmb_TipoMantenimiento.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Componente Afectado";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmb_ComponenteAfectado
            // 
            this.cmb_ComponenteAfectado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ComponenteAfectado.FormattingEnabled = true;
            this.cmb_ComponenteAfectado.Items.AddRange(new object[] {
            "Motor",
            "Llantas",
            "Frenos",
            "Aceite/Agua"});
            this.cmb_ComponenteAfectado.Location = new System.Drawing.Point(129, 164);
            this.cmb_ComponenteAfectado.Name = "cmb_ComponenteAfectado";
            this.cmb_ComponenteAfectado.Size = new System.Drawing.Size(254, 21);
            this.cmb_ComponenteAfectado.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha";
            // 
            // Fecha_mantenimiento
            // 
            this.Fecha_mantenimiento.Location = new System.Drawing.Point(55, 206);
            this.Fecha_mantenimiento.Name = "Fecha_mantenimiento";
            this.Fecha_mantenimiento.Size = new System.Drawing.Size(328, 20);
            this.Fecha_mantenimiento.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Responsable asignado";
            // 
            // txt_responsableAsignado
            // 
            this.txt_responsableAsignado.Location = new System.Drawing.Point(133, 249);
            this.txt_responsableAsignado.Name = "txt_responsableAsignado";
            this.txt_responsableAsignado.Size = new System.Drawing.Size(250, 20);
            this.txt_responsableAsignado.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Problema";
            // 
            // txt_CodigoError
            // 
            this.txt_CodigoError.Location = new System.Drawing.Point(69, 290);
            this.txt_CodigoError.Name = "txt_CodigoError";
            this.txt_CodigoError.Size = new System.Drawing.Size(314, 20);
            this.txt_CodigoError.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Estado del mantenimiento";
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Items.AddRange(new object[] {
            "Activo",
            "No Activo"});
            this.cmb_Estado.Location = new System.Drawing.Point(153, 322);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(230, 21);
            this.cmb_Estado.TabIndex = 16;
            // 
            // txt_TiempoEstimado
            // 
            this.txt_TiempoEstimado.Location = new System.Drawing.Point(153, 364);
            this.txt_TiempoEstimado.Name = "txt_TiempoEstimado";
            this.txt_TiempoEstimado.Size = new System.Drawing.Size(250, 20);
            this.txt_TiempoEstimado.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Tiempo estimado";
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Location = new System.Drawing.Point(12, 472);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_Enviar.TabIndex = 19;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = true;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(129, 472);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 20;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(252, 472);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Actualizar.TabIndex = 21;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(377, 472);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 22;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 510);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 174);
            this.dataGridView1.TabIndex = 23;
            // 
            // btn_generarPDF
            // 
            this.btn_generarPDF.Location = new System.Drawing.Point(409, 364);
            this.btn_generarPDF.Name = "btn_generarPDF";
            this.btn_generarPDF.Size = new System.Drawing.Size(89, 23);
            this.btn_generarPDF.TabIndex = 24;
            this.btn_generarPDF.Text = "Generar PDF";
            this.btn_generarPDF.UseVisualStyleBackColor = true;
            // 
            // txt_NombreSolicitante
            // 
            this.txt_NombreSolicitante.Location = new System.Drawing.Point(129, 84);
            this.txt_NombreSolicitante.Name = "txt_NombreSolicitante";
            this.txt_NombreSolicitante.Size = new System.Drawing.Size(254, 20);
            this.txt_NombreSolicitante.TabIndex = 25;
            // 
            // txt_fk_id_movimiento
            // 
            this.txt_fk_id_movimiento.Location = new System.Drawing.Point(153, 415);
            this.txt_fk_id_movimiento.Name = "txt_fk_id_movimiento";
            this.txt_fk_id_movimiento.Size = new System.Drawing.Size(250, 20);
            this.txt_fk_id_movimiento.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 422);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Id de Movimiento";
            // 
            // MantenimientoVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 696);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_fk_id_movimiento);
            this.Controls.Add(this.txt_NombreSolicitante);
            this.Controls.Add(this.btn_generarPDF);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_TiempoEstimado);
            this.Controls.Add(this.cmb_Estado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_CodigoError);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_responsableAsignado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Fecha_mantenimiento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_ComponenteAfectado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_TipoMantenimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID_mantenimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoVehiculos";
            this.Text = "Mantenimiento de vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID_mantenimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_TipoMantenimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_ComponenteAfectado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Fecha_mantenimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_responsableAsignado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_CodigoError;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_Estado;
        private System.Windows.Forms.TextBox txt_TiempoEstimado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_generarPDF;
        private System.Windows.Forms.TextBox txt_NombreSolicitante;
        private System.Windows.Forms.TextBox txt_fk_id_movimiento;
        private System.Windows.Forms.Label label11;
    }
}