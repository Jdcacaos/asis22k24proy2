
namespace Capa_Vista_CompraVenta
{
    partial class frm_Factura
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
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.Cbo_nit = new System.Windows.Forms.ComboBox();
            this.Txt_nit = new System.Windows.Forms.Label();
            this.Dgv_factura = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cbo_metodoPago = new System.Windows.Forms.ComboBox();
            this.Txt_metodoPagon = new System.Windows.Forms.Label();
            this.Btn_insertarD = new System.Windows.Forms.Button();
            this.Btn_cancelarD = new System.Windows.Forms.Button();
            this.Cbo_encabezado = new System.Windows.Forms.ComboBox();
            this.Txt_idEfk = new System.Windows.Forms.Label();
            this.Txt_idDetalle = new System.Windows.Forms.TextBox();
            this.Txt_idD = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.Txt_idCotizacionfk = new System.Windows.Forms.Label();
            this.Txt_precioTn = new System.Windows.Forms.Label();
            this.Txt_precioTotal = new System.Windows.Forms.TextBox();
            this.Txt_subtotal = new System.Windows.Forms.TextBox();
            this.Txt_IVAn = new System.Windows.Forms.Label();
            this.Txt_IVA = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Txt_subtotaln = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_idEncezado = new System.Windows.Forms.TextBox();
            this.Btn_cancelarE = new System.Windows.Forms.Button();
            this.Btn_insertarE = new System.Windows.Forms.Button();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.Cbo_cliente = new System.Windows.Forms.ComboBox();
            this.Cbo_vendedor = new System.Windows.Forms.ComboBox();
            this.Txt_FechaVencimiento = new System.Windows.Forms.Label();
            this.Txt_Clienten = new System.Windows.Forms.Label();
            this.Txt_Vendedorn = new System.Windows.Forms.Label();
            this.Txt_idE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_factura)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_titulo.Location = new System.Drawing.Point(350, 9);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(71, 20);
            this.Txt_titulo.TabIndex = 9;
            this.Txt_titulo.Text = "Factura";
            // 
            // Cbo_nit
            // 
            this.Cbo_nit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_nit.FormattingEnabled = true;
            this.Cbo_nit.Location = new System.Drawing.Point(404, 74);
            this.Cbo_nit.Name = "Cbo_nit";
            this.Cbo_nit.Size = new System.Drawing.Size(121, 23);
            this.Cbo_nit.TabIndex = 31;
            this.Cbo_nit.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // Txt_nit
            // 
            this.Txt_nit.AutoSize = true;
            this.Txt_nit.Location = new System.Drawing.Point(330, 77);
            this.Txt_nit.Name = "Txt_nit";
            this.Txt_nit.Size = new System.Drawing.Size(28, 19);
            this.Txt_nit.TabIndex = 30;
            this.Txt_nit.Text = "Nit";
            this.Txt_nit.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dgv_factura
            // 
            this.Dgv_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_factura.Location = new System.Drawing.Point(19, 356);
            this.Dgv_factura.Name = "Dgv_factura";
            this.Dgv_factura.Size = new System.Drawing.Size(735, 141);
            this.Dgv_factura.TabIndex = 10;
            this.Dgv_factura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Cbo_metodoPago);
            this.groupBox3.Controls.Add(this.Txt_metodoPagon);
            this.groupBox3.Controls.Add(this.Btn_insertarD);
            this.groupBox3.Controls.Add(this.Btn_cancelarD);
            this.groupBox3.Controls.Add(this.Cbo_encabezado);
            this.groupBox3.Controls.Add(this.Txt_idEfk);
            this.groupBox3.Controls.Add(this.Txt_idDetalle);
            this.groupBox3.Controls.Add(this.Txt_idD);
            this.groupBox3.Controls.Add(this.comboBox6);
            this.groupBox3.Controls.Add(this.Txt_idCotizacionfk);
            this.groupBox3.Controls.Add(this.Txt_precioTn);
            this.groupBox3.Controls.Add(this.Txt_precioTotal);
            this.groupBox3.Controls.Add(this.Txt_subtotal);
            this.groupBox3.Controls.Add(this.Txt_IVAn);
            this.groupBox3.Controls.Add(this.Txt_IVA);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.Txt_subtotaln);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(19, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(735, 170);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle";
            // 
            // Cbo_metodoPago
            // 
            this.Cbo_metodoPago.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_metodoPago.FormattingEnabled = true;
            this.Cbo_metodoPago.Location = new System.Drawing.Point(163, 138);
            this.Cbo_metodoPago.Name = "Cbo_metodoPago";
            this.Cbo_metodoPago.Size = new System.Drawing.Size(121, 23);
            this.Cbo_metodoPago.TabIndex = 31;
            // 
            // Txt_metodoPagon
            // 
            this.Txt_metodoPagon.AutoSize = true;
            this.Txt_metodoPagon.Location = new System.Drawing.Point(45, 139);
            this.Txt_metodoPagon.Name = "Txt_metodoPagon";
            this.Txt_metodoPagon.Size = new System.Drawing.Size(111, 19);
            this.Txt_metodoPagon.TabIndex = 30;
            this.Txt_metodoPagon.Text = "Metodo de pago";
            // 
            // Btn_insertarD
            // 
            this.Btn_insertarD.Location = new System.Drawing.Point(613, 46);
            this.Btn_insertarD.Name = "Btn_insertarD";
            this.Btn_insertarD.Size = new System.Drawing.Size(75, 23);
            this.Btn_insertarD.TabIndex = 26;
            this.Btn_insertarD.Text = "Insertar";
            this.Btn_insertarD.UseVisualStyleBackColor = true;
            // 
            // Btn_cancelarD
            // 
            this.Btn_cancelarD.Location = new System.Drawing.Point(613, 105);
            this.Btn_cancelarD.Name = "Btn_cancelarD";
            this.Btn_cancelarD.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelarD.TabIndex = 27;
            this.Btn_cancelarD.Text = "Cancelar";
            this.Btn_cancelarD.UseVisualStyleBackColor = true;
            // 
            // Cbo_encabezado
            // 
            this.Cbo_encabezado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_encabezado.FormattingEnabled = true;
            this.Cbo_encabezado.Location = new System.Drawing.Point(165, 72);
            this.Cbo_encabezado.Name = "Cbo_encabezado";
            this.Cbo_encabezado.Size = new System.Drawing.Size(121, 23);
            this.Cbo_encabezado.TabIndex = 25;
            // 
            // Txt_idEfk
            // 
            this.Txt_idEfk.AutoSize = true;
            this.Txt_idEfk.Location = new System.Drawing.Point(45, 80);
            this.Txt_idEfk.Name = "Txt_idEfk";
            this.Txt_idEfk.Size = new System.Drawing.Size(103, 19);
            this.Txt_idEfk.TabIndex = 24;
            this.Txt_idEfk.Text = "ID Encabezado";
            // 
            // Txt_idDetalle
            // 
            this.Txt_idDetalle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idDetalle.Location = new System.Drawing.Point(165, 37);
            this.Txt_idDetalle.Name = "Txt_idDetalle";
            this.Txt_idDetalle.Size = new System.Drawing.Size(121, 22);
            this.Txt_idDetalle.TabIndex = 23;
            // 
            // Txt_idD
            // 
            this.Txt_idD.AutoSize = true;
            this.Txt_idD.Location = new System.Drawing.Point(45, 45);
            this.Txt_idD.Name = "Txt_idD";
            this.Txt_idD.Size = new System.Drawing.Size(25, 19);
            this.Txt_idD.TabIndex = 22;
            this.Txt_idD.Text = "ID";
            // 
            // comboBox6
            // 
            this.comboBox6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(163, 105);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 23);
            this.comboBox6.TabIndex = 20;
            // 
            // Txt_idCotizacionfk
            // 
            this.Txt_idCotizacionfk.AutoSize = true;
            this.Txt_idCotizacionfk.Location = new System.Drawing.Point(45, 109);
            this.Txt_idCotizacionfk.Name = "Txt_idCotizacionfk";
            this.Txt_idCotizacionfk.Size = new System.Drawing.Size(93, 19);
            this.Txt_idCotizacionfk.TabIndex = 19;
            this.Txt_idCotizacionfk.Text = "ID Cotización";
            // 
            // Txt_precioTn
            // 
            this.Txt_precioTn.AutoSize = true;
            this.Txt_precioTn.Location = new System.Drawing.Point(339, 107);
            this.Txt_precioTn.Name = "Txt_precioTn";
            this.Txt_precioTn.Size = new System.Drawing.Size(82, 19);
            this.Txt_precioTn.TabIndex = 21;
            this.Txt_precioTn.Text = "Precio Total";
            // 
            // Txt_precioTotal
            // 
            this.Txt_precioTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_precioTotal.Location = new System.Drawing.Point(433, 107);
            this.Txt_precioTotal.Name = "Txt_precioTotal";
            this.Txt_precioTotal.Size = new System.Drawing.Size(121, 22);
            this.Txt_precioTotal.TabIndex = 20;
            // 
            // Txt_subtotal
            // 
            this.Txt_subtotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_subtotal.Location = new System.Drawing.Point(433, 39);
            this.Txt_subtotal.Name = "Txt_subtotal";
            this.Txt_subtotal.Size = new System.Drawing.Size(121, 22);
            this.Txt_subtotal.TabIndex = 19;
            // 
            // Txt_IVAn
            // 
            this.Txt_IVAn.AutoSize = true;
            this.Txt_IVAn.Location = new System.Drawing.Point(338, 78);
            this.Txt_IVAn.Name = "Txt_IVAn";
            this.Txt_IVAn.Size = new System.Drawing.Size(34, 19);
            this.Txt_IVAn.TabIndex = 16;
            this.Txt_IVAn.Text = "IVA";
            // 
            // Txt_IVA
            // 
            this.Txt_IVA.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IVA.Location = new System.Drawing.Point(433, 71);
            this.Txt_IVA.Name = "Txt_IVA";
            this.Txt_IVA.Size = new System.Drawing.Size(121, 22);
            this.Txt_IVA.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 19);
            this.label14.TabIndex = 10;
            // 
            // Txt_subtotaln
            // 
            this.Txt_subtotaln.AutoSize = true;
            this.Txt_subtotaln.Location = new System.Drawing.Point(338, 46);
            this.Txt_subtotaln.Name = "Txt_subtotaln";
            this.Txt_subtotaln.Size = new System.Drawing.Size(59, 19);
            this.Txt_subtotaln.TabIndex = 9;
            this.Txt_subtotaln.Text = "Subtotal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cbo_nit);
            this.groupBox1.Controls.Add(this.Txt_nit);
            this.groupBox1.Controls.Add(this.Txt_idEncezado);
            this.groupBox1.Controls.Add(this.Btn_cancelarE);
            this.groupBox1.Controls.Add(this.Btn_insertarE);
            this.groupBox1.Controls.Add(this.Dtp_fecha);
            this.groupBox1.Controls.Add(this.Cbo_cliente);
            this.groupBox1.Controls.Add(this.Cbo_vendedor);
            this.groupBox1.Controls.Add(this.Txt_FechaVencimiento);
            this.groupBox1.Controls.Add(this.Txt_Clienten);
            this.groupBox1.Controls.Add(this.Txt_Vendedorn);
            this.groupBox1.Controls.Add(this.Txt_idE);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 119);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // Txt_idEncezado
            // 
            this.Txt_idEncezado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idEncezado.Location = new System.Drawing.Point(103, 31);
            this.Txt_idEncezado.Name = "Txt_idEncezado";
            this.Txt_idEncezado.Size = new System.Drawing.Size(121, 22);
            this.Txt_idEncezado.TabIndex = 9;
            // 
            // Btn_cancelarE
            // 
            this.Btn_cancelarE.Location = new System.Drawing.Point(613, 72);
            this.Btn_cancelarE.Name = "Btn_cancelarE";
            this.Btn_cancelarE.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancelarE.TabIndex = 8;
            this.Btn_cancelarE.Text = "Cancelar";
            this.Btn_cancelarE.UseVisualStyleBackColor = true;
            // 
            // Btn_insertarE
            // 
            this.Btn_insertarE.Location = new System.Drawing.Point(613, 31);
            this.Btn_insertarE.Name = "Btn_insertarE";
            this.Btn_insertarE.Size = new System.Drawing.Size(75, 23);
            this.Btn_insertarE.TabIndex = 7;
            this.Btn_insertarE.Text = "Insertar";
            this.Btn_insertarE.UseVisualStyleBackColor = true;
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_fecha.Location = new System.Drawing.Point(325, 34);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(200, 22);
            this.Dtp_fecha.TabIndex = 6;
            this.Dtp_fecha.ValueChanged += new System.EventHandler(this.Dtp_fecha_ValueChanged);
            // 
            // Cbo_cliente
            // 
            this.Cbo_cliente.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_cliente.FormattingEnabled = true;
            this.Cbo_cliente.Location = new System.Drawing.Point(103, 91);
            this.Cbo_cliente.Name = "Cbo_cliente";
            this.Cbo_cliente.Size = new System.Drawing.Size(121, 23);
            this.Cbo_cliente.TabIndex = 5;
            // 
            // Cbo_vendedor
            // 
            this.Cbo_vendedor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_vendedor.FormattingEnabled = true;
            this.Cbo_vendedor.Location = new System.Drawing.Point(103, 59);
            this.Cbo_vendedor.Name = "Cbo_vendedor";
            this.Cbo_vendedor.Size = new System.Drawing.Size(121, 23);
            this.Cbo_vendedor.TabIndex = 4;
            // 
            // Txt_FechaVencimiento
            // 
            this.Txt_FechaVencimiento.AutoSize = true;
            this.Txt_FechaVencimiento.Location = new System.Drawing.Point(367, 16);
            this.Txt_FechaVencimiento.Name = "Txt_FechaVencimiento";
            this.Txt_FechaVencimiento.Size = new System.Drawing.Size(123, 19);
            this.Txt_FechaVencimiento.TabIndex = 3;
            this.Txt_FechaVencimiento.Text = "Fecha Vencimiento";
            // 
            // Txt_Clienten
            // 
            this.Txt_Clienten.AutoSize = true;
            this.Txt_Clienten.Location = new System.Drawing.Point(29, 94);
            this.Txt_Clienten.Name = "Txt_Clienten";
            this.Txt_Clienten.Size = new System.Drawing.Size(51, 19);
            this.Txt_Clienten.TabIndex = 2;
            this.Txt_Clienten.Text = "Cliente";
            // 
            // Txt_Vendedorn
            // 
            this.Txt_Vendedorn.AutoSize = true;
            this.Txt_Vendedorn.Location = new System.Drawing.Point(29, 59);
            this.Txt_Vendedorn.Name = "Txt_Vendedorn";
            this.Txt_Vendedorn.Size = new System.Drawing.Size(68, 19);
            this.Txt_Vendedorn.TabIndex = 1;
            this.Txt_Vendedorn.Text = "Vendedor";
            // 
            // Txt_idE
            // 
            this.Txt_idE.AutoSize = true;
            this.Txt_idE.Location = new System.Drawing.Point(29, 31);
            this.Txt_idE.Name = "Txt_idE";
            this.Txt_idE.Size = new System.Drawing.Size(25, 19);
            this.Txt_idE.TabIndex = 0;
            this.Txt_idE.Text = "ID";
            // 
            // frm_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Dgv_factura);
            this.Controls.Add(this.Txt_titulo);
            this.Name = "frm_Factura";
            this.Text = "frm_Factura";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_factura)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt_titulo;
        private System.Windows.Forms.ComboBox Cbo_nit;
        private System.Windows.Forms.Label Txt_nit;
        private System.Windows.Forms.DataGridView Dgv_factura;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_insertarD;
        private System.Windows.Forms.Button Btn_cancelarD;
        private System.Windows.Forms.ComboBox Cbo_encabezado;
        private System.Windows.Forms.Label Txt_idEfk;
        private System.Windows.Forms.TextBox Txt_idDetalle;
        private System.Windows.Forms.Label Txt_idD;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label Txt_idCotizacionfk;
        private System.Windows.Forms.Label Txt_precioTn;
        private System.Windows.Forms.TextBox Txt_precioTotal;
        private System.Windows.Forms.TextBox Txt_subtotal;
        private System.Windows.Forms.Label Txt_IVAn;
        private System.Windows.Forms.TextBox Txt_IVA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label Txt_subtotaln;
        private System.Windows.Forms.ComboBox Cbo_metodoPago;
        private System.Windows.Forms.Label Txt_metodoPagon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_idEncezado;
        private System.Windows.Forms.Button Btn_cancelarE;
        private System.Windows.Forms.Button Btn_insertarE;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
        private System.Windows.Forms.ComboBox Cbo_cliente;
        private System.Windows.Forms.ComboBox Cbo_vendedor;
        private System.Windows.Forms.Label Txt_FechaVencimiento;
        private System.Windows.Forms.Label Txt_Clienten;
        private System.Windows.Forms.Label Txt_Vendedorn;
        private System.Windows.Forms.Label Txt_idE;
    }
}