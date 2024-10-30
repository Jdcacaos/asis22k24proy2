
namespace Capa_Vista_Navegador
{
    partial class IngresarVarios
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dgv_InfoExtra = new System.Windows.Forms.DataGridView();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_quitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_InfoExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_InfoExtra
            // 
            this.Dgv_InfoExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_InfoExtra.Location = new System.Drawing.Point(0, 3);
            this.Dgv_InfoExtra.Name = "Dgv_InfoExtra";
            this.Dgv_InfoExtra.RowHeadersWidth = 51;
            this.Dgv_InfoExtra.RowTemplate.Height = 24;
            this.Dgv_InfoExtra.Size = new System.Drawing.Size(769, 253);
            this.Dgv_InfoExtra.TabIndex = 0;
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.Location = new System.Drawing.Point(835, 25);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(87, 80);
            this.Btn_agregar.TabIndex = 1;
            this.Btn_agregar.Text = "agregar";
            this.Btn_agregar.UseVisualStyleBackColor = true;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // Btn_quitar
            // 
            this.Btn_quitar.Location = new System.Drawing.Point(835, 156);
            this.Btn_quitar.Name = "Btn_quitar";
            this.Btn_quitar.Size = new System.Drawing.Size(87, 80);
            this.Btn_quitar.TabIndex = 2;
            this.Btn_quitar.Text = "quitar";
            this.Btn_quitar.UseVisualStyleBackColor = true;
            this.Btn_quitar.Click += new System.EventHandler(this.Btn_quitar_Click);
            // 
            // IngresarVarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Btn_quitar);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.Dgv_InfoExtra);
            this.Name = "IngresarVarios";
            this.Size = new System.Drawing.Size(994, 282);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_InfoExtra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_InfoExtra;
        public System.Windows.Forms.Button Btn_agregar;
        public System.Windows.Forms.Button Btn_quitar;
    }
}
