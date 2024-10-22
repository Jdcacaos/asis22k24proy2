
namespace Capa_Vista_CompraVenta
{
    partial class frm_ListadoEncabezado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_fecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbo_nombre = new System.Windows.Forms.ComboBox();
            this.Cbo_estado = new System.Windows.Forms.ComboBox();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Dgv_listado = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_listado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_fecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Cbo_nombre);
            this.groupBox1.Controls.Add(this.Cbo_estado);
            this.groupBox1.Controls.Add(this.Txt_codigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(54, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 101);
            this.groupBox1.TabIndex = 307;
            this.groupBox1.TabStop = false;
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.Location = new System.Drawing.Point(421, 58);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(200, 20);
            this.Txt_fecha.TabIndex = 11;
            this.Txt_fecha.TextChanged += new System.EventHandler(this.Txt_fecha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(352, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fecha:";
            // 
            // Cbo_nombre
            // 
            this.Cbo_nombre.FormattingEnabled = true;
            this.Cbo_nombre.Items.AddRange(new object[] {
            "Para Mayoristas",
            "Para Minoristas",
            "Especial"});
            this.Cbo_nombre.Location = new System.Drawing.Point(421, 19);
            this.Cbo_nombre.Name = "Cbo_nombre";
            this.Cbo_nombre.Size = new System.Drawing.Size(200, 21);
            this.Cbo_nombre.TabIndex = 10;
            // 
            // Cbo_estado
            // 
            this.Cbo_estado.FormattingEnabled = true;
            this.Cbo_estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.Cbo_estado.Location = new System.Drawing.Point(111, 58);
            this.Cbo_estado.Name = "Cbo_estado";
            this.Cbo_estado.Size = new System.Drawing.Size(178, 21);
            this.Cbo_estado.TabIndex = 10;
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.Location = new System.Drawing.Point(111, 16);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(178, 20);
            this.Txt_codigo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(48, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(352, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label10.Location = new System.Drawing.Point(48, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Código:";
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_titulo.Location = new System.Drawing.Point(60, 18);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(166, 21);
            this.Txt_titulo.TabIndex = 306;
            this.Txt_titulo.Text = "Listado de Precios";
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Location = new System.Drawing.Point(521, 74);
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(140, 20);
            this.Txt_buscar.TabIndex = 304;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Image = global::Capa_Vista_CompraVenta.Properties.Resources.buscar11;
            this.Btn_eliminar.Location = new System.Drawing.Point(664, 55);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(69, 57);
            this.Btn_eliminar.TabIndex = 303;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // Dgv_listado
            // 
            this.Dgv_listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Column1,
            this.Column2,
            this.Column3});
            this.Dgv_listado.Location = new System.Drawing.Point(54, 236);
            this.Dgv_listado.Name = "Dgv_listado";
            this.Dgv_listado.Size = new System.Drawing.Size(679, 236);
            this.Dgv_listado.TabIndex = 300;
            // 
            // Código
            // 
            this.Código.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.Width = 65;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Porcentaje %";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Estado";
            this.Column3.Name = "Column3";
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_editar.FlatAppearance.BorderSize = 0;
            this.Btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_editar.Image = global::Capa_Vista_CompraVenta.Properties.Resources.editar11;
            this.Btn_editar.Location = new System.Drawing.Point(192, 55);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(69, 57);
            this.Btn_editar.TabIndex = 305;
            this.Btn_editar.UseVisualStyleBackColor = false;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_agregar.FlatAppearance.BorderSize = 0;
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar.Image = global::Capa_Vista_CompraVenta.Properties.Resources.agregar11;
            this.Btn_agregar.Location = new System.Drawing.Point(54, 55);
            this.Btn_agregar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(69, 57);
            this.Btn_agregar.TabIndex = 301;
            this.Btn_agregar.UseVisualStyleBackColor = false;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Image = global::Capa_Vista_CompraVenta.Properties.Resources.borrar11;
            this.Btn_guardar.Location = new System.Drawing.Point(123, 55);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(69, 57);
            this.Btn_guardar.TabIndex = 302;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // frm_ListadoEncabezado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Txt_titulo);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Txt_buscar);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Dgv_listado);
            this.Name = "frm_ListadoEncabezado";
            this.Text = "frm_ListadoEncabezado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbo_nombre;
        private System.Windows.Forms.ComboBox Cbo_estado;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Txt_titulo;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.DataGridView Dgv_listado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}