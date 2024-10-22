
namespace Capa_Vista_CompraVenta
{
    partial class Frm_comisiones
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
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_reporte = new System.Windows.Forms.Button();
            this.Lbl_total = new System.Windows.Forms.Label();
            this.Txt_comision = new System.Windows.Forms.TextBox();
            this.Txt_venta = new System.Windows.Forms.TextBox();
            this.Lbl_venta = new System.Windows.Forms.Label();
            this.Txt_porcentaje = new System.Windows.Forms.TextBox();
            this.Lbl_comision = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Dgv_ventas = new System.Windows.Forms.DataGridView();
            this.ID_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_vendedor = new System.Windows.Forms.TextBox();
            this.Lbl_vendedor = new System.Windows.Forms.Label();
            this.Gpb_ventas = new System.Windows.Forms.GroupBox();
            this.Rdb_costo = new System.Windows.Forms.RadioButton();
            this.Rdb_lineas = new System.Windows.Forms.RadioButton();
            this.Rdb_inventario = new System.Windows.Forms.RadioButton();
            this.Rdb_marcas = new System.Windows.Forms.RadioButton();
            this.Dtp_fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.Lbl_al = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dtp_fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.Lbl_del = new System.Windows.Forms.Label();
            this.Gpb_calculo = new System.Windows.Forms.GroupBox();
            this.Btn_calcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ventas)).BeginInit();
            this.Gpb_ventas.SuspendLayout();
            this.Gpb_calculo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Location = new System.Drawing.Point(991, 36);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(146, 35);
            this.Btn_limpiar.TabIndex = 38;
            this.Btn_limpiar.Text = "Limpiar Selección";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // Btn_reporte
            // 
            this.Btn_reporte.Location = new System.Drawing.Point(31, 720);
            this.Btn_reporte.Name = "Btn_reporte";
            this.Btn_reporte.Size = new System.Drawing.Size(178, 35);
            this.Btn_reporte.TabIndex = 37;
            this.Btn_reporte.Text = "Generar Reporte";
            this.Btn_reporte.UseVisualStyleBackColor = true;
            // 
            // Lbl_total
            // 
            this.Lbl_total.AutoSize = true;
            this.Lbl_total.Location = new System.Drawing.Point(855, 689);
            this.Lbl_total.Name = "Lbl_total";
            this.Lbl_total.Size = new System.Drawing.Size(97, 17);
            this.Lbl_total.TabIndex = 35;
            this.Lbl_total.Text = "Comsion total:";
            // 
            // Txt_comision
            // 
            this.Txt_comision.Enabled = false;
            this.Txt_comision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_comision.Location = new System.Drawing.Point(983, 683);
            this.Txt_comision.Name = "Txt_comision";
            this.Txt_comision.Size = new System.Drawing.Size(154, 27);
            this.Txt_comision.TabIndex = 34;
            this.Txt_comision.Text = "Q####";
            // 
            // Txt_venta
            // 
            this.Txt_venta.Enabled = false;
            this.Txt_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_venta.Location = new System.Drawing.Point(983, 637);
            this.Txt_venta.Name = "Txt_venta";
            this.Txt_venta.Size = new System.Drawing.Size(154, 27);
            this.Txt_venta.TabIndex = 33;
            this.Txt_venta.Text = "Q####";
            // 
            // Lbl_venta
            // 
            this.Lbl_venta.AutoSize = true;
            this.Lbl_venta.Location = new System.Drawing.Point(855, 643);
            this.Lbl_venta.Name = "Lbl_venta";
            this.Lbl_venta.Size = new System.Drawing.Size(122, 17);
            this.Lbl_venta.TabIndex = 32;
            this.Lbl_venta.Text = "Total de la venta: ";
            // 
            // Txt_porcentaje
            // 
            this.Txt_porcentaje.Enabled = false;
            this.Txt_porcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_porcentaje.Location = new System.Drawing.Point(588, 261);
            this.Txt_porcentaje.Name = "Txt_porcentaje";
            this.Txt_porcentaje.Size = new System.Drawing.Size(62, 27);
            this.Txt_porcentaje.TabIndex = 31;
            // 
            // Lbl_comision
            // 
            this.Lbl_comision.AutoSize = true;
            this.Lbl_comision.Location = new System.Drawing.Point(441, 267);
            this.Lbl_comision.Name = "Lbl_comision";
            this.Lbl_comision.Size = new System.Drawing.Size(141, 17);
            this.Lbl_comision.TabIndex = 30;
            this.Lbl_comision.Text = "Porcentaje Comision:";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Enabled = false;
            this.Txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombre.Location = new System.Drawing.Point(32, 261);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(367, 27);
            this.Txt_nombre.TabIndex = 28;
            this.Txt_nombre.Text = "Nombre Vendedor";
            // 
            // Dgv_ventas
            // 
            this.Dgv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Venta,
            this.Fecha_venta,
            this.Producto,
            this.Marca,
            this.Linea,
            this.Cantidad,
            this.Total});
            this.Dgv_ventas.Location = new System.Drawing.Point(31, 305);
            this.Dgv_ventas.Name = "Dgv_ventas";
            this.Dgv_ventas.RowHeadersWidth = 51;
            this.Dgv_ventas.RowTemplate.Height = 24;
            this.Dgv_ventas.Size = new System.Drawing.Size(1133, 292);
            this.Dgv_ventas.TabIndex = 27;
            // 
            // ID_Venta
            // 
            this.ID_Venta.HeaderText = "Id Venta";
            this.ID_Venta.MinimumWidth = 6;
            this.ID_Venta.Name = "ID_Venta";
            this.ID_Venta.Width = 125;
            // 
            // Fecha_venta
            // 
            this.Fecha_venta.HeaderText = "Fecha Venta";
            this.Fecha_venta.MinimumWidth = 6;
            this.Fecha_venta.Name = "Fecha_venta";
            this.Fecha_venta.Width = 125;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 125;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 125;
            // 
            // Linea
            // 
            this.Linea.HeaderText = "Linea";
            this.Linea.MinimumWidth = 6;
            this.Linea.Name = "Linea";
            this.Linea.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad Vendida";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.Location = new System.Drawing.Point(416, 35);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(107, 35);
            this.Btn_buscar.TabIndex = 26;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            // 
            // Txt_vendedor
            // 
            this.Txt_vendedor.Location = new System.Drawing.Point(115, 42);
            this.Txt_vendedor.Name = "Txt_vendedor";
            this.Txt_vendedor.Size = new System.Drawing.Size(284, 22);
            this.Txt_vendedor.TabIndex = 25;
            // 
            // Lbl_vendedor
            // 
            this.Lbl_vendedor.AutoSize = true;
            this.Lbl_vendedor.Location = new System.Drawing.Point(29, 44);
            this.Lbl_vendedor.Name = "Lbl_vendedor";
            this.Lbl_vendedor.Size = new System.Drawing.Size(74, 17);
            this.Lbl_vendedor.TabIndex = 24;
            this.Lbl_vendedor.Text = "Vendedor:";
            // 
            // Gpb_ventas
            // 
            this.Gpb_ventas.Controls.Add(this.Rdb_costo);
            this.Gpb_ventas.Controls.Add(this.Rdb_lineas);
            this.Gpb_ventas.Controls.Add(this.Rdb_inventario);
            this.Gpb_ventas.Controls.Add(this.Rdb_marcas);
            this.Gpb_ventas.Controls.Add(this.Dtp_fecha_fin);
            this.Gpb_ventas.Controls.Add(this.Lbl_al);
            this.Gpb_ventas.Controls.Add(this.label2);
            this.Gpb_ventas.Controls.Add(this.Dtp_fecha_inicio);
            this.Gpb_ventas.Controls.Add(this.Lbl_del);
            this.Gpb_ventas.Location = new System.Drawing.Point(181, 104);
            this.Gpb_ventas.Name = "Gpb_ventas";
            this.Gpb_ventas.Size = new System.Drawing.Size(796, 142);
            this.Gpb_ventas.TabIndex = 29;
            this.Gpb_ventas.TabStop = false;
            this.Gpb_ventas.Text = "Listar ventas:";
            // 
            // Rdb_costo
            // 
            this.Rdb_costo.AutoSize = true;
            this.Rdb_costo.Location = new System.Drawing.Point(523, 37);
            this.Rdb_costo.Name = "Rdb_costo";
            this.Rdb_costo.Size = new System.Drawing.Size(137, 21);
            this.Rdb_costo.TabIndex = 16;
            this.Rdb_costo.TabStop = true;
            this.Rdb_costo.Text = "Basada en Costo";
            this.Rdb_costo.UseVisualStyleBackColor = true;
            // 
            // Rdb_lineas
            // 
            this.Rdb_lineas.AutoSize = true;
            this.Rdb_lineas.Location = new System.Drawing.Point(446, 37);
            this.Rdb_lineas.Name = "Rdb_lineas";
            this.Rdb_lineas.Size = new System.Drawing.Size(71, 21);
            this.Rdb_lineas.TabIndex = 15;
            this.Rdb_lineas.TabStop = true;
            this.Rdb_lineas.Text = "Lineas";
            this.Rdb_lineas.UseVisualStyleBackColor = true;
            // 
            // Rdb_inventario
            // 
            this.Rdb_inventario.AutoSize = true;
            this.Rdb_inventario.Location = new System.Drawing.Point(268, 37);
            this.Rdb_inventario.Name = "Rdb_inventario";
            this.Rdb_inventario.Size = new System.Drawing.Size(91, 21);
            this.Rdb_inventario.TabIndex = 14;
            this.Rdb_inventario.TabStop = true;
            this.Rdb_inventario.Text = "Inventario";
            this.Rdb_inventario.UseVisualStyleBackColor = true;
            // 
            // Rdb_marcas
            // 
            this.Rdb_marcas.AutoSize = true;
            this.Rdb_marcas.Location = new System.Drawing.Point(365, 37);
            this.Rdb_marcas.Name = "Rdb_marcas";
            this.Rdb_marcas.Size = new System.Drawing.Size(75, 21);
            this.Rdb_marcas.TabIndex = 13;
            this.Rdb_marcas.TabStop = true;
            this.Rdb_marcas.Text = "Marcas";
            this.Rdb_marcas.UseVisualStyleBackColor = true;
            // 
            // Dtp_fecha_fin
            // 
            this.Dtp_fecha_fin.Location = new System.Drawing.Point(469, 90);
            this.Dtp_fecha_fin.Name = "Dtp_fecha_fin";
            this.Dtp_fecha_fin.Size = new System.Drawing.Size(272, 22);
            this.Dtp_fecha_fin.TabIndex = 11;
            // 
            // Lbl_al
            // 
            this.Lbl_al.AutoSize = true;
            this.Lbl_al.Location = new System.Drawing.Point(434, 90);
            this.Lbl_al.Name = "Lbl_al";
            this.Lbl_al.Size = new System.Drawing.Size(19, 17);
            this.Lbl_al.TabIndex = 10;
            this.Lbl_al.Text = "al";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Comision por:";
            // 
            // Dtp_fecha_inicio
            // 
            this.Dtp_fecha_inicio.Location = new System.Drawing.Point(142, 90);
            this.Dtp_fecha_inicio.Name = "Dtp_fecha_inicio";
            this.Dtp_fecha_inicio.Size = new System.Drawing.Size(272, 22);
            this.Dtp_fecha_inicio.TabIndex = 9;
            // 
            // Lbl_del
            // 
            this.Lbl_del.AutoSize = true;
            this.Lbl_del.Location = new System.Drawing.Point(52, 90);
            this.Lbl_del.Name = "Lbl_del";
            this.Lbl_del.Size = new System.Drawing.Size(84, 17);
            this.Lbl_del.TabIndex = 7;
            this.Lbl_del.Text = "Periodo del:";
            // 
            // Gpb_calculo
            // 
            this.Gpb_calculo.Controls.Add(this.Btn_calcular);
            this.Gpb_calculo.Location = new System.Drawing.Point(696, 616);
            this.Gpb_calculo.Name = "Gpb_calculo";
            this.Gpb_calculo.Size = new System.Drawing.Size(468, 118);
            this.Gpb_calculo.TabIndex = 36;
            this.Gpb_calculo.TabStop = false;
            this.Gpb_calculo.Text = "Calculo de Comision:";
            // 
            // Btn_calcular
            // 
            this.Btn_calcular.Location = new System.Drawing.Point(24, 37);
            this.Btn_calcular.Name = "Btn_calcular";
            this.Btn_calcular.Size = new System.Drawing.Size(91, 35);
            this.Btn_calcular.TabIndex = 19;
            this.Btn_calcular.Text = "Calcular";
            this.Btn_calcular.UseVisualStyleBackColor = true;
            // 
            // Frm_comisiones1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 786);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_reporte);
            this.Controls.Add(this.Lbl_total);
            this.Controls.Add(this.Txt_comision);
            this.Controls.Add(this.Txt_venta);
            this.Controls.Add(this.Lbl_venta);
            this.Controls.Add(this.Txt_porcentaje);
            this.Controls.Add(this.Lbl_comision);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.Dgv_ventas);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_vendedor);
            this.Controls.Add(this.Lbl_vendedor);
            this.Controls.Add(this.Gpb_ventas);
            this.Controls.Add(this.Gpb_calculo);
            this.Name = "Frm_comisiones1";
            this.Text = "Frm_comisiones1";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ventas)).EndInit();
            this.Gpb_ventas.ResumeLayout(false);
            this.Gpb_ventas.PerformLayout();
            this.Gpb_calculo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_reporte;
        private System.Windows.Forms.Label Lbl_total;
        private System.Windows.Forms.TextBox Txt_comision;
        private System.Windows.Forms.TextBox Txt_venta;
        private System.Windows.Forms.Label Lbl_venta;
        private System.Windows.Forms.TextBox Txt_porcentaje;
        private System.Windows.Forms.Label Lbl_comision;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.DataGridView Dgv_ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_vendedor;
        private System.Windows.Forms.Label Lbl_vendedor;
        private System.Windows.Forms.GroupBox Gpb_ventas;
        private System.Windows.Forms.RadioButton Rdb_costo;
        private System.Windows.Forms.RadioButton Rdb_lineas;
        private System.Windows.Forms.RadioButton Rdb_inventario;
        private System.Windows.Forms.RadioButton Rdb_marcas;
        private System.Windows.Forms.DateTimePicker Dtp_fecha_fin;
        private System.Windows.Forms.Label Lbl_al;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Dtp_fecha_inicio;
        private System.Windows.Forms.Label Lbl_del;
        private System.Windows.Forms.GroupBox Gpb_calculo;
        private System.Windows.Forms.Button Btn_calcular;
    }
}