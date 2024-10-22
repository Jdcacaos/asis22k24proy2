
namespace Capa_Vista_CompraVenta
{
    partial class frm_Mantenimientopoliza
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
            this.Btn_salir = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Txt_dif = new System.Windows.Forms.TextBox();
            this.Txt_diferencial = new System.Windows.Forms.Label();
            this.Txt_abono = new System.Windows.Forms.TextBox();
            this.Txt_totalabonos = new System.Windows.Forms.Label();
            this.Txt_cargo = new System.Windows.Forms.TextBox();
            this.Txt_totalcargos = new System.Windows.Forms.Label();
            this.Gpb_detalle = new System.Windows.Forms.GroupBox();
            this.Txt_valor = new System.Windows.Forms.TextBox();
            this.Cbo_carabono = new System.Windows.Forms.ComboBox();
            this.Cbo_codigo = new System.Windows.Forms.ComboBox();
            this.Txt_val = new System.Windows.Forms.Label();
            this.Txt_cargoabono = new System.Windows.Forms.Label();
            this.Txt_codigo = new System.Windows.Forms.Label();
            this.Dgv_Informacion = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Gpb_informacion = new System.Windows.Forms.GroupBox();
            this.Txt_emision = new System.Windows.Forms.Label();
            this.Txt_polizaID = new System.Windows.Forms.TextBox();
            this.Txt_poliza = new System.Windows.Forms.Label();
            this.Txt_concepto = new System.Windows.Forms.Label();
            this.Txt_ConceptoID = new System.Windows.Forms.TextBox();
            this.Dtp_emision = new System.Windows.Forms.DateTimePicker();
            this.Gpb_detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Informacion)).BeginInit();
            this.Gpb_informacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_salir
            // 
            this.Btn_salir.Location = new System.Drawing.Point(632, 10);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(112, 42);
            this.Btn_salir.TabIndex = 39;
            this.Btn_salir.Text = "Salir";
            this.Btn_salir.UseVisualStyleBackColor = true;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.Location = new System.Drawing.Point(483, 10);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(112, 42);
            this.Btn_cancelar.TabIndex = 38;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.Location = new System.Drawing.Point(330, 10);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(112, 42);
            this.Btn_modificar.TabIndex = 37;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.UseVisualStyleBackColor = true;
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.Location = new System.Drawing.Point(182, 10);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(112, 42);
            this.Btn_nuevo.TabIndex = 36;
            this.Btn_nuevo.Text = "Nuevo";
            this.Btn_nuevo.UseVisualStyleBackColor = true;
            // 
            // Txt_dif
            // 
            this.Txt_dif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_dif.Location = new System.Drawing.Point(884, 547);
            this.Txt_dif.Name = "Txt_dif";
            this.Txt_dif.Size = new System.Drawing.Size(112, 30);
            this.Txt_dif.TabIndex = 35;
            // 
            // Txt_diferencial
            // 
            this.Txt_diferencial.AutoSize = true;
            this.Txt_diferencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_diferencial.Location = new System.Drawing.Point(867, 519);
            this.Txt_diferencial.Name = "Txt_diferencial";
            this.Txt_diferencial.Size = new System.Drawing.Size(152, 25);
            this.Txt_diferencial.TabIndex = 34;
            this.Txt_diferencial.Text = "Total Diferencial";
            // 
            // Txt_abono
            // 
            this.Txt_abono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_abono.Location = new System.Drawing.Point(880, 473);
            this.Txt_abono.Name = "Txt_abono";
            this.Txt_abono.Size = new System.Drawing.Size(116, 30);
            this.Txt_abono.TabIndex = 33;
            // 
            // Txt_totalabonos
            // 
            this.Txt_totalabonos.AutoSize = true;
            this.Txt_totalabonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_totalabonos.Location = new System.Drawing.Point(871, 445);
            this.Txt_totalabonos.Name = "Txt_totalabonos";
            this.Txt_totalabonos.Size = new System.Drawing.Size(129, 25);
            this.Txt_totalabonos.TabIndex = 32;
            this.Txt_totalabonos.Text = "Total Abonos";
            // 
            // Txt_cargo
            // 
            this.Txt_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cargo.Location = new System.Drawing.Point(876, 390);
            this.Txt_cargo.Name = "Txt_cargo";
            this.Txt_cargo.Size = new System.Drawing.Size(120, 30);
            this.Txt_cargo.TabIndex = 31;
            // 
            // Txt_totalcargos
            // 
            this.Txt_totalcargos.AutoSize = true;
            this.Txt_totalcargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_totalcargos.Location = new System.Drawing.Point(871, 362);
            this.Txt_totalcargos.Name = "Txt_totalcargos";
            this.Txt_totalcargos.Size = new System.Drawing.Size(125, 25);
            this.Txt_totalcargos.TabIndex = 30;
            this.Txt_totalcargos.Text = "Total Cargos";
            // 
            // Gpb_detalle
            // 
            this.Gpb_detalle.Controls.Add(this.Txt_valor);
            this.Gpb_detalle.Controls.Add(this.Cbo_carabono);
            this.Gpb_detalle.Controls.Add(this.Cbo_codigo);
            this.Gpb_detalle.Controls.Add(this.Txt_val);
            this.Gpb_detalle.Controls.Add(this.Txt_cargoabono);
            this.Gpb_detalle.Controls.Add(this.Txt_codigo);
            this.Gpb_detalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gpb_detalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gpb_detalle.Location = new System.Drawing.Point(56, 186);
            this.Gpb_detalle.Name = "Gpb_detalle";
            this.Gpb_detalle.Size = new System.Drawing.Size(778, 94);
            this.Gpb_detalle.TabIndex = 29;
            this.Gpb_detalle.TabStop = false;
            this.Gpb_detalle.Text = "Detalle";
            // 
            // Txt_valor
            // 
            this.Txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_valor.Location = new System.Drawing.Point(530, 47);
            this.Txt_valor.Name = "Txt_valor";
            this.Txt_valor.Size = new System.Drawing.Size(133, 34);
            this.Txt_valor.TabIndex = 14;
            // 
            // Cbo_carabono
            // 
            this.Cbo_carabono.FormattingEnabled = true;
            this.Cbo_carabono.Location = new System.Drawing.Point(291, 48);
            this.Cbo_carabono.Name = "Cbo_carabono";
            this.Cbo_carabono.Size = new System.Drawing.Size(202, 33);
            this.Cbo_carabono.TabIndex = 14;
            // 
            // Cbo_codigo
            // 
            this.Cbo_codigo.FormattingEnabled = true;
            this.Cbo_codigo.Location = new System.Drawing.Point(45, 48);
            this.Cbo_codigo.Name = "Cbo_codigo";
            this.Cbo_codigo.Size = new System.Drawing.Size(202, 33);
            this.Cbo_codigo.TabIndex = 13;
            // 
            // Txt_val
            // 
            this.Txt_val.AutoSize = true;
            this.Txt_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_val.Location = new System.Drawing.Point(571, 20);
            this.Txt_val.Name = "Txt_val";
            this.Txt_val.Size = new System.Drawing.Size(58, 25);
            this.Txt_val.TabIndex = 11;
            this.Txt_val.Text = "Valor";
            // 
            // Txt_cargoabono
            // 
            this.Txt_cargoabono.AutoSize = true;
            this.Txt_cargoabono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_cargoabono.Location = new System.Drawing.Point(332, 20);
            this.Txt_cargoabono.Name = "Txt_cargoabono";
            this.Txt_cargoabono.Size = new System.Drawing.Size(130, 25);
            this.Txt_cargoabono.TabIndex = 8;
            this.Txt_cargoabono.Text = "Cargo/Abono";
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.AutoSize = true;
            this.Txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_codigo.Location = new System.Drawing.Point(105, 20);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(75, 25);
            this.Txt_codigo.TabIndex = 6;
            this.Txt_codigo.Text = "Codigo";
            // 
            // Dgv_Informacion
            // 
            this.Dgv_Informacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Informacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cuenta,
            this.Tipo,
            this.Cargo,
            this.Abonos});
            this.Dgv_Informacion.Location = new System.Drawing.Point(56, 294);
            this.Dgv_Informacion.Name = "Dgv_Informacion";
            this.Dgv_Informacion.RowHeadersWidth = 51;
            this.Dgv_Informacion.RowTemplate.Height = 24;
            this.Dgv_Informacion.Size = new System.Drawing.Size(778, 306);
            this.Dgv_Informacion.TabIndex = 28;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 150;
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.MinimumWidth = 6;
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Width = 300;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 125;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            this.Cargo.Width = 125;
            // 
            // Abonos
            // 
            this.Abonos.HeaderText = "Abonos";
            this.Abonos.MinimumWidth = 6;
            this.Abonos.Name = "Abonos";
            this.Abonos.Width = 125;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Location = new System.Drawing.Point(872, 294);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(120, 46);
            this.Btn_eliminar.TabIndex = 26;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(872, 223);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(112, 44);
            this.Btn_guardar.TabIndex = 25;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            // 
            // Gpb_informacion
            // 
            this.Gpb_informacion.Controls.Add(this.Txt_emision);
            this.Gpb_informacion.Controls.Add(this.Txt_polizaID);
            this.Gpb_informacion.Controls.Add(this.Txt_poliza);
            this.Gpb_informacion.Controls.Add(this.Txt_concepto);
            this.Gpb_informacion.Controls.Add(this.Txt_ConceptoID);
            this.Gpb_informacion.Controls.Add(this.Dtp_emision);
            this.Gpb_informacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gpb_informacion.Location = new System.Drawing.Point(56, 58);
            this.Gpb_informacion.Name = "Gpb_informacion";
            this.Gpb_informacion.Size = new System.Drawing.Size(778, 122);
            this.Gpb_informacion.TabIndex = 27;
            this.Gpb_informacion.TabStop = false;
            // 
            // Txt_emision
            // 
            this.Txt_emision.AutoSize = true;
            this.Txt_emision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_emision.Location = new System.Drawing.Point(6, 28);
            this.Txt_emision.Name = "Txt_emision";
            this.Txt_emision.Size = new System.Drawing.Size(81, 25);
            this.Txt_emision.TabIndex = 13;
            this.Txt_emision.Text = "Emisión";
            // 
            // Txt_polizaID
            // 
            this.Txt_polizaID.Location = new System.Drawing.Point(519, 34);
            this.Txt_polizaID.Name = "Txt_polizaID";
            this.Txt_polizaID.Size = new System.Drawing.Size(110, 22);
            this.Txt_polizaID.TabIndex = 9;
            // 
            // Txt_poliza
            // 
            this.Txt_poliza.AutoSize = true;
            this.Txt_poliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_poliza.Location = new System.Drawing.Point(413, 30);
            this.Txt_poliza.Name = "Txt_poliza";
            this.Txt_poliza.Size = new System.Drawing.Size(100, 25);
            this.Txt_poliza.TabIndex = 8;
            this.Txt_poliza.Text = "No. Poliza";
            // 
            // Txt_concepto
            // 
            this.Txt_concepto.AutoSize = true;
            this.Txt_concepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_concepto.Location = new System.Drawing.Point(6, 85);
            this.Txt_concepto.Name = "Txt_concepto";
            this.Txt_concepto.Size = new System.Drawing.Size(97, 25);
            this.Txt_concepto.TabIndex = 6;
            this.Txt_concepto.Text = "Concepto";
            // 
            // Txt_ConceptoID
            // 
            this.Txt_ConceptoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ConceptoID.Location = new System.Drawing.Point(125, 85);
            this.Txt_ConceptoID.Name = "Txt_ConceptoID";
            this.Txt_ConceptoID.Size = new System.Drawing.Size(647, 27);
            this.Txt_ConceptoID.TabIndex = 7;
            // 
            // Dtp_emision
            // 
            this.Dtp_emision.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_emision.Location = new System.Drawing.Point(125, 31);
            this.Dtp_emision.Name = "Dtp_emision";
            this.Dtp_emision.Size = new System.Drawing.Size(272, 22);
            this.Dtp_emision.TabIndex = 3;
            // 
            // frm_Mantenimientopoliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 602);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_nuevo);
            this.Controls.Add(this.Txt_dif);
            this.Controls.Add(this.Txt_diferencial);
            this.Controls.Add(this.Txt_abono);
            this.Controls.Add(this.Txt_totalabonos);
            this.Controls.Add(this.Txt_cargo);
            this.Controls.Add(this.Txt_totalcargos);
            this.Controls.Add(this.Gpb_detalle);
            this.Controls.Add(this.Dgv_Informacion);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Gpb_informacion);
            this.Name = "frm_Mantenimientopoliza";
            this.Text = "frm_Mantenimientopoliza";
            this.Gpb_detalle.ResumeLayout(false);
            this.Gpb_detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Informacion)).EndInit();
            this.Gpb_informacion.ResumeLayout(false);
            this.Gpb_informacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.TextBox Txt_dif;
        private System.Windows.Forms.Label Txt_diferencial;
        private System.Windows.Forms.TextBox Txt_abono;
        private System.Windows.Forms.Label Txt_totalabonos;
        private System.Windows.Forms.TextBox Txt_cargo;
        private System.Windows.Forms.Label Txt_totalcargos;
        private System.Windows.Forms.GroupBox Gpb_detalle;
        private System.Windows.Forms.TextBox Txt_valor;
        private System.Windows.Forms.ComboBox Cbo_carabono;
        private System.Windows.Forms.ComboBox Cbo_codigo;
        private System.Windows.Forms.Label Txt_val;
        private System.Windows.Forms.Label Txt_cargoabono;
        private System.Windows.Forms.Label Txt_codigo;
        private System.Windows.Forms.DataGridView Dgv_Informacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abonos;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.GroupBox Gpb_informacion;
        private System.Windows.Forms.Label Txt_emision;
        private System.Windows.Forms.TextBox Txt_polizaID;
        private System.Windows.Forms.Label Txt_poliza;
        private System.Windows.Forms.Label Txt_concepto;
        private System.Windows.Forms.TextBox Txt_ConceptoID;
        private System.Windows.Forms.DateTimePicker Dtp_emision;
    }
}