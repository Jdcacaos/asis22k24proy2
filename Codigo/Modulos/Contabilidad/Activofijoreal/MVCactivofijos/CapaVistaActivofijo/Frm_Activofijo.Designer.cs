
namespace CapaVistaActivofijo
{
    partial class Frm_Activofijo
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
            this.dgv_activofijo = new System.Windows.Forms.DataGridView();
            this.Pnl_Menu = new System.Windows.Forms.Panel();
            this.Btn_depreci = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_activofijo)).BeginInit();
            this.Pnl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_activofijo
            // 
            this.dgv_activofijo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_activofijo.Location = new System.Drawing.Point(12, 214);
            this.dgv_activofijo.Name = "dgv_activofijo";
            this.dgv_activofijo.RowHeadersWidth = 51;
            this.dgv_activofijo.RowTemplate.Height = 24;
            this.dgv_activofijo.Size = new System.Drawing.Size(1011, 482);
            this.dgv_activofijo.TabIndex = 5;
            this.dgv_activofijo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_activofijo_CellContentClick);
            // 
            // Pnl_Menu
            // 
            this.Pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Pnl_Menu.Controls.Add(this.Btn_depreci);
            this.Pnl_Menu.Controls.Add(this.Btn_Nuevo);
            this.Pnl_Menu.Controls.Add(this.Btn_Editar);
            this.Pnl_Menu.Controls.Add(this.Btn_imprimir);
            this.Pnl_Menu.Location = new System.Drawing.Point(246, 86);
            this.Pnl_Menu.Name = "Pnl_Menu";
            this.Pnl_Menu.Size = new System.Drawing.Size(497, 103);
            this.Pnl_Menu.TabIndex = 10;
            this.Pnl_Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Btn_depreci
            // 
            this.Btn_depreci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_depreci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_depreci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_depreci.Image = global::CapaVistaActivofijo.Properties.Resources.Reportes_V3;
            this.Btn_depreci.Location = new System.Drawing.Point(386, 0);
            this.Btn_depreci.Name = "Btn_depreci";
            this.Btn_depreci.Size = new System.Drawing.Size(109, 103);
            this.Btn_depreci.TabIndex = 9;
            this.Btn_depreci.Text = "Depreciacion";
            this.Btn_depreci.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_depreci.UseVisualStyleBackColor = true;
            this.Btn_depreci.Click += new System.EventHandler(this.Btn_depreci_Click_1);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackgroundImage = global::CapaVistaActivofijo.Properties.Resources.INGRESAR_V4;
            this.Btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Nuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Nuevo.Location = new System.Drawing.Point(0, 0);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(105, 102);
            this.Btn_Nuevo.TabIndex = 6;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackgroundImage = global::CapaVistaActivofijo.Properties.Resources.EDITAR_V4;
            this.Btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Editar.Location = new System.Drawing.Point(131, 0);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(105, 102);
            this.Btn_Editar.TabIndex = 7;
            this.Btn_Editar.Text = "Actualizar";
            this.Btn_Editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_imprimir
            // 
            this.Btn_imprimir.BackgroundImage = global::CapaVistaActivofijo.Properties.Resources.impresora;
            this.Btn_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_imprimir.Location = new System.Drawing.Point(257, 0);
            this.Btn_imprimir.Name = "Btn_imprimir";
            this.Btn_imprimir.Size = new System.Drawing.Size(105, 102);
            this.Btn_imprimir.TabIndex = 8;
            this.Btn_imprimir.Text = "Imprimir";
            this.Btn_imprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_imprimir.UseVisualStyleBackColor = true;
            this.Btn_imprimir.Click += new System.EventHandler(this.Btn_imprimir_Click);
            // 
            // Frm_Activofijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1052, 708);
            this.Controls.Add(this.Pnl_Menu);
            this.Controls.Add(this.dgv_activofijo);
            this.Name = "Frm_Activofijo";
            this.Text = "Frm_Activofijo";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_activofijo)).EndInit();
            this.Pnl_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_depreci;
        public System.Windows.Forms.DataGridView dgv_activofijo;
        private System.Windows.Forms.Button Btn_imprimir;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Panel Pnl_Menu;
    }
}