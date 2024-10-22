
namespace Capa_Vista_CompraVenta
{
    partial class frm_ListadoDetalle
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
            this.Gpb_modo = new System.Windows.Forms.GroupBox();
            this.Txt_aplicar = new System.Windows.Forms.Label();
            this.Txt_porcentaje = new System.Windows.Forms.TextBox();
            this.Txt_descuento = new System.Windows.Forms.Label();
            this.Txt_forzado = new System.Windows.Forms.TextBox();
            this.Rdb_forzar = new System.Windows.Forms.RadioButton();
            this.Rdb_precioventa = new System.Windows.Forms.RadioButton();
            this.Rdb_costocompra = new System.Windows.Forms.RadioButton();
            this.Txt_precioforzado = new System.Windows.Forms.Label();
            this.Gpb_productos = new System.Windows.Forms.GroupBox();
            this.Txt_basadocosto = new System.Windows.Forms.TextBox();
            this.Rdb_basadocosto = new System.Windows.Forms.RadioButton();
            this.Cbo_linea = new System.Windows.Forms.ComboBox();
            this.Rdb_linea = new System.Windows.Forms.RadioButton();
            this.Cbo_marca = new System.Windows.Forms.ComboBox();
            this.Rdb_marca = new System.Windows.Forms.RadioButton();
            this.Txt_costo = new System.Windows.Forms.TextBox();
            this.Txt_costocompra = new System.Windows.Forms.Label();
            this.Txt_precio = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Txt_prod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_precioventa = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_producto = new System.Windows.Forms.Label();
            this.Txt_cod = new System.Windows.Forms.TextBox();
            this.Txt_codigo = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Txt_productobuscado = new System.Windows.Forms.TextBox();
            this.Rdb_inventario = new System.Windows.Forms.RadioButton();
            this.Txt_busqueda = new System.Windows.Forms.Label();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Txt_titulo = new System.Windows.Forms.Label();
            this.Gpb_modo.SuspendLayout();
            this.Gpb_productos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_modo
            // 
            this.Gpb_modo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gpb_modo.Controls.Add(this.Txt_aplicar);
            this.Gpb_modo.Controls.Add(this.Txt_porcentaje);
            this.Gpb_modo.Controls.Add(this.Txt_descuento);
            this.Gpb_modo.Controls.Add(this.Txt_forzado);
            this.Gpb_modo.Controls.Add(this.Rdb_forzar);
            this.Gpb_modo.Controls.Add(this.Rdb_precioventa);
            this.Gpb_modo.Controls.Add(this.Rdb_costocompra);
            this.Gpb_modo.Controls.Add(this.Txt_precioforzado);
            this.Gpb_modo.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Gpb_modo.ForeColor = System.Drawing.Color.Blue;
            this.Gpb_modo.Location = new System.Drawing.Point(41, 348);
            this.Gpb_modo.Name = "Gpb_modo";
            this.Gpb_modo.Size = new System.Drawing.Size(747, 163);
            this.Gpb_modo.TabIndex = 29;
            this.Gpb_modo.TabStop = false;
            this.Gpb_modo.Text = "Seleccionar Modo";
            // 
            // Txt_aplicar
            // 
            this.Txt_aplicar.AutoSize = true;
            this.Txt_aplicar.ForeColor = System.Drawing.Color.Black;
            this.Txt_aplicar.Location = new System.Drawing.Point(566, 66);
            this.Txt_aplicar.Name = "Txt_aplicar";
            this.Txt_aplicar.Size = new System.Drawing.Size(22, 19);
            this.Txt_aplicar.TabIndex = 317;
            this.Txt_aplicar.Text = "%";
            // 
            // Txt_porcentaje
            // 
            this.Txt_porcentaje.Location = new System.Drawing.Point(444, 61);
            this.Txt_porcentaje.Name = "Txt_porcentaje";
            this.Txt_porcentaje.Size = new System.Drawing.Size(121, 26);
            this.Txt_porcentaje.TabIndex = 315;
            // 
            // Txt_descuento
            // 
            this.Txt_descuento.AutoSize = true;
            this.Txt_descuento.ForeColor = System.Drawing.Color.Black;
            this.Txt_descuento.Location = new System.Drawing.Point(440, 33);
            this.Txt_descuento.Name = "Txt_descuento";
            this.Txt_descuento.Size = new System.Drawing.Size(301, 19);
            this.Txt_descuento.TabIndex = 316;
            this.Txt_descuento.Text = "Porcentaje de descuento por defecto (Opcional)";
            // 
            // Txt_forzado
            // 
            this.Txt_forzado.Location = new System.Drawing.Point(255, 128);
            this.Txt_forzado.Name = "Txt_forzado";
            this.Txt_forzado.Size = new System.Drawing.Size(93, 26);
            this.Txt_forzado.TabIndex = 314;
            // 
            // Rdb_forzar
            // 
            this.Rdb_forzar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdb_forzar.AutoSize = true;
            this.Rdb_forzar.ForeColor = System.Drawing.Color.Black;
            this.Rdb_forzar.Location = new System.Drawing.Point(45, 102);
            this.Rdb_forzar.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_forzar.Name = "Rdb_forzar";
            this.Rdb_forzar.Size = new System.Drawing.Size(109, 23);
            this.Rdb_forzar.TabIndex = 4;
            this.Rdb_forzar.TabStop = true;
            this.Rdb_forzar.Text = "Forzar precio";
            this.Rdb_forzar.UseVisualStyleBackColor = true;
            this.Rdb_forzar.CheckedChanged += new System.EventHandler(this.Rdb_forzar_CheckedChanged);
            // 
            // Rdb_precioventa
            // 
            this.Rdb_precioventa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdb_precioventa.AutoSize = true;
            this.Rdb_precioventa.ForeColor = System.Drawing.Color.Black;
            this.Rdb_precioventa.Location = new System.Drawing.Point(45, 31);
            this.Rdb_precioventa.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_precioventa.Name = "Rdb_precioventa";
            this.Rdb_precioventa.Size = new System.Drawing.Size(274, 23);
            this.Rdb_precioventa.TabIndex = 2;
            this.Rdb_precioventa.TabStop = true;
            this.Rdb_precioventa.Text = "Usar descuento contra el precio de venta";
            this.Rdb_precioventa.UseVisualStyleBackColor = true;
            this.Rdb_precioventa.CheckedChanged += new System.EventHandler(this.Rdb_precioventa_CheckedChanged);
            // 
            // Rdb_costocompra
            // 
            this.Rdb_costocompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdb_costocompra.AutoSize = true;
            this.Rdb_costocompra.ForeColor = System.Drawing.Color.Black;
            this.Rdb_costocompra.Location = new System.Drawing.Point(45, 66);
            this.Rdb_costocompra.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_costocompra.Name = "Rdb_costocompra";
            this.Rdb_costocompra.Size = new System.Drawing.Size(349, 23);
            this.Rdb_costocompra.TabIndex = 3;
            this.Rdb_costocompra.TabStop = true;
            this.Rdb_costocompra.Text = "Usar ganancia a partir del costo promedio de compra";
            this.Rdb_costocompra.UseVisualStyleBackColor = true;
            this.Rdb_costocompra.CheckedChanged += new System.EventHandler(this.Rdb_costocompra_CheckedChanged);
            // 
            // Txt_precioforzado
            // 
            this.Txt_precioforzado.AutoSize = true;
            this.Txt_precioforzado.ForeColor = System.Drawing.Color.Black;
            this.Txt_precioforzado.Location = new System.Drawing.Point(251, 106);
            this.Txt_precioforzado.Name = "Txt_precioforzado";
            this.Txt_precioforzado.Size = new System.Drawing.Size(98, 19);
            this.Txt_precioforzado.TabIndex = 0;
            this.Txt_precioforzado.Text = "Precio forzado";
            // 
            // Gpb_productos
            // 
            this.Gpb_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Gpb_productos.Controls.Add(this.Txt_basadocosto);
            this.Gpb_productos.Controls.Add(this.Rdb_basadocosto);
            this.Gpb_productos.Controls.Add(this.Cbo_linea);
            this.Gpb_productos.Controls.Add(this.Rdb_linea);
            this.Gpb_productos.Controls.Add(this.Cbo_marca);
            this.Gpb_productos.Controls.Add(this.Rdb_marca);
            this.Gpb_productos.Controls.Add(this.Txt_costo);
            this.Gpb_productos.Controls.Add(this.Txt_costocompra);
            this.Gpb_productos.Controls.Add(this.Txt_precio);
            this.Gpb_productos.Controls.Add(this.textBox3);
            this.Gpb_productos.Controls.Add(this.Txt_prod);
            this.Gpb_productos.Controls.Add(this.label3);
            this.Gpb_productos.Controls.Add(this.Txt_precioventa);
            this.Gpb_productos.Controls.Add(this.textBox1);
            this.Gpb_productos.Controls.Add(this.label2);
            this.Gpb_productos.Controls.Add(this.Txt_producto);
            this.Gpb_productos.Controls.Add(this.Txt_cod);
            this.Gpb_productos.Controls.Add(this.Txt_codigo);
            this.Gpb_productos.Controls.Add(this.Btn_buscar);
            this.Gpb_productos.Controls.Add(this.Txt_productobuscado);
            this.Gpb_productos.Controls.Add(this.Rdb_inventario);
            this.Gpb_productos.Controls.Add(this.Txt_busqueda);
            this.Gpb_productos.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Gpb_productos.ForeColor = System.Drawing.Color.Blue;
            this.Gpb_productos.Location = new System.Drawing.Point(41, 62);
            this.Gpb_productos.Name = "Gpb_productos";
            this.Gpb_productos.Size = new System.Drawing.Size(747, 280);
            this.Gpb_productos.TabIndex = 28;
            this.Gpb_productos.TabStop = false;
            this.Gpb_productos.Text = "Selección de Productos";
            // 
            // Txt_basadocosto
            // 
            this.Txt_basadocosto.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Txt_basadocosto.Location = new System.Drawing.Point(490, 233);
            this.Txt_basadocosto.Name = "Txt_basadocosto";
            this.Txt_basadocosto.Size = new System.Drawing.Size(93, 22);
            this.Txt_basadocosto.TabIndex = 313;
            // 
            // Rdb_basadocosto
            // 
            this.Rdb_basadocosto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdb_basadocosto.AutoSize = true;
            this.Rdb_basadocosto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_basadocosto.ForeColor = System.Drawing.Color.Black;
            this.Rdb_basadocosto.Location = new System.Drawing.Point(476, 205);
            this.Rdb_basadocosto.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_basadocosto.Name = "Rdb_basadocosto";
            this.Rdb_basadocosto.Size = new System.Drawing.Size(145, 23);
            this.Rdb_basadocosto.TabIndex = 312;
            this.Rdb_basadocosto.TabStop = true;
            this.Rdb_basadocosto.Text = "Basado en Costo:";
            this.Rdb_basadocosto.UseVisualStyleBackColor = true;
            this.Rdb_basadocosto.CheckedChanged += new System.EventHandler(this.Rdb_basadocosto_CheckedChanged);
            // 
            // Cbo_linea
            // 
            this.Cbo_linea.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Cbo_linea.FormattingEnabled = true;
            this.Cbo_linea.Items.AddRange(new object[] {
            "Posturepedic",
            "Hybrid",
            "Conform",
            "World Luxury",
            "Mattress",
            "Extended ",
            "Life"});
            this.Cbo_linea.Location = new System.Drawing.Point(263, 232);
            this.Cbo_linea.Name = "Cbo_linea";
            this.Cbo_linea.Size = new System.Drawing.Size(178, 23);
            this.Cbo_linea.TabIndex = 311;
            // 
            // Rdb_linea
            // 
            this.Rdb_linea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdb_linea.AutoSize = true;
            this.Rdb_linea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_linea.ForeColor = System.Drawing.Color.Black;
            this.Rdb_linea.Location = new System.Drawing.Point(257, 205);
            this.Rdb_linea.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_linea.Name = "Rdb_linea";
            this.Rdb_linea.Size = new System.Drawing.Size(70, 23);
            this.Rdb_linea.TabIndex = 310;
            this.Rdb_linea.TabStop = true;
            this.Rdb_linea.Text = "Línea:";
            this.Rdb_linea.UseVisualStyleBackColor = true;
            this.Rdb_linea.CheckedChanged += new System.EventHandler(this.Rdb_linea_CheckedChanged);
            // 
            // Cbo_marca
            // 
            this.Cbo_marca.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Cbo_marca.FormattingEnabled = true;
            this.Cbo_marca.Items.AddRange(new object[] {
            "Sealy",
            "Serta",
            "Tempur-Pedic",
            "Simmons",
            "King Koil",
            "Spring Air",
            "Casper",
            "Purple",
            "Tuft & Needle",
            "Emma"});
            this.Cbo_marca.Location = new System.Drawing.Point(30, 232);
            this.Cbo_marca.Name = "Cbo_marca";
            this.Cbo_marca.Size = new System.Drawing.Size(178, 23);
            this.Cbo_marca.TabIndex = 309;
            // 
            // Rdb_marca
            // 
            this.Rdb_marca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdb_marca.AutoSize = true;
            this.Rdb_marca.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_marca.ForeColor = System.Drawing.Color.Black;
            this.Rdb_marca.Location = new System.Drawing.Point(24, 205);
            this.Rdb_marca.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_marca.Name = "Rdb_marca";
            this.Rdb_marca.Size = new System.Drawing.Size(77, 23);
            this.Rdb_marca.TabIndex = 308;
            this.Rdb_marca.TabStop = true;
            this.Rdb_marca.Text = "Marca:";
            this.Rdb_marca.UseVisualStyleBackColor = true;
            this.Rdb_marca.CheckedChanged += new System.EventHandler(this.Rdb_marca_CheckedChanged);
            // 
            // Txt_costo
            // 
            this.Txt_costo.Font = new System.Drawing.Font("Arial Narrow", 7.5F, System.Drawing.FontStyle.Bold);
            this.Txt_costo.ForeColor = System.Drawing.Color.Red;
            this.Txt_costo.Location = new System.Drawing.Point(362, 136);
            this.Txt_costo.Name = "Txt_costo";
            this.Txt_costo.Size = new System.Drawing.Size(74, 19);
            this.Txt_costo.TabIndex = 307;
            // 
            // Txt_costocompra
            // 
            this.Txt_costocompra.AutoSize = true;
            this.Txt_costocompra.Font = new System.Drawing.Font("Arial Narrow", 6.5F, System.Drawing.FontStyle.Bold);
            this.Txt_costocompra.ForeColor = System.Drawing.Color.Red;
            this.Txt_costocompra.Location = new System.Drawing.Point(244, 140);
            this.Txt_costocompra.Name = "Txt_costocompra";
            this.Txt_costocompra.Size = new System.Drawing.Size(112, 13);
            this.Txt_costocompra.TabIndex = 306;
            this.Txt_costocompra.Text = "Costo promedio de compra:";
            // 
            // Txt_precio
            // 
            this.Txt_precio.Font = new System.Drawing.Font("Arial Narrow", 7.5F, System.Drawing.FontStyle.Bold);
            this.Txt_precio.ForeColor = System.Drawing.Color.Red;
            this.Txt_precio.Location = new System.Drawing.Point(134, 139);
            this.Txt_precio.Name = "Txt_precio";
            this.Txt_precio.Size = new System.Drawing.Size(74, 19);
            this.Txt_precio.TabIndex = 305;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.textBox3.Location = new System.Drawing.Point(634, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 22);
            this.textBox3.TabIndex = 19;
            // 
            // Txt_prod
            // 
            this.Txt_prod.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Txt_prod.Location = new System.Drawing.Point(317, 106);
            this.Txt_prod.Name = "Txt_prod";
            this.Txt_prod.Size = new System.Drawing.Size(190, 22);
            this.Txt_prod.TabIndex = 304;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(630, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Estado:";
            // 
            // Txt_precioventa
            // 
            this.Txt_precioventa.AutoSize = true;
            this.Txt_precioventa.Font = new System.Drawing.Font("Arial Narrow", 6.5F, System.Drawing.FontStyle.Bold);
            this.Txt_precioventa.ForeColor = System.Drawing.Color.Red;
            this.Txt_precioventa.Location = new System.Drawing.Point(23, 143);
            this.Txt_precioventa.Name = "Txt_precioventa";
            this.Txt_precioventa.Size = new System.Drawing.Size(105, 13);
            this.Txt_precioventa.TabIndex = 303;
            this.Txt_precioventa.Text = "Precio de venta al público:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(535, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 22);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(531, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cantidad:";
            // 
            // Txt_producto
            // 
            this.Txt_producto.AutoSize = true;
            this.Txt_producto.ForeColor = System.Drawing.Color.Black;
            this.Txt_producto.Location = new System.Drawing.Point(243, 109);
            this.Txt_producto.Name = "Txt_producto";
            this.Txt_producto.Size = new System.Drawing.Size(68, 19);
            this.Txt_producto.TabIndex = 301;
            this.Txt_producto.Text = "Producto:";
            // 
            // Txt_cod
            // 
            this.Txt_cod.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Txt_cod.Location = new System.Drawing.Point(84, 109);
            this.Txt_cod.Name = "Txt_cod";
            this.Txt_cod.Size = new System.Drawing.Size(124, 22);
            this.Txt_cod.TabIndex = 300;
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.AutoSize = true;
            this.Txt_codigo.ForeColor = System.Drawing.Color.Black;
            this.Txt_codigo.Location = new System.Drawing.Point(21, 109);
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(57, 19);
            this.Txt_codigo.TabIndex = 299;
            this.Txt_codigo.Text = "Código:";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.White;
            this.Btn_buscar.ForeColor = System.Drawing.Color.Black;
            this.Btn_buscar.Location = new System.Drawing.Point(425, 67);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(75, 26);
            this.Btn_buscar.TabIndex = 24;
            this.Btn_buscar.Text = "Buscar";
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Txt_productobuscado
            // 
            this.Txt_productobuscado.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Txt_productobuscado.Location = new System.Drawing.Point(231, 68);
            this.Txt_productobuscado.Name = "Txt_productobuscado";
            this.Txt_productobuscado.Size = new System.Drawing.Size(178, 22);
            this.Txt_productobuscado.TabIndex = 298;
            // 
            // Rdb_inventario
            // 
            this.Rdb_inventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdb_inventario.AutoSize = true;
            this.Rdb_inventario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_inventario.ForeColor = System.Drawing.Color.Black;
            this.Rdb_inventario.Location = new System.Drawing.Point(20, 31);
            this.Rdb_inventario.Margin = new System.Windows.Forms.Padding(4);
            this.Rdb_inventario.Name = "Rdb_inventario";
            this.Rdb_inventario.Size = new System.Drawing.Size(101, 23);
            this.Rdb_inventario.TabIndex = 14;
            this.Rdb_inventario.TabStop = true;
            this.Rdb_inventario.Text = "Inventario:";
            this.Rdb_inventario.UseVisualStyleBackColor = true;
            this.Rdb_inventario.CheckedChanged += new System.EventHandler(this.Rdb_inventario_CheckedChanged);
            // 
            // Txt_busqueda
            // 
            this.Txt_busqueda.AutoSize = true;
            this.Txt_busqueda.ForeColor = System.Drawing.Color.Black;
            this.Txt_busqueda.Location = new System.Drawing.Point(21, 67);
            this.Txt_busqueda.Name = "Txt_busqueda";
            this.Txt_busqueda.Size = new System.Drawing.Size(204, 19);
            this.Txt_busqueda.TabIndex = 0;
            this.Txt_busqueda.Text = "Busque productos a seleccionar:";
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btn_guardar.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Btn_guardar.Location = new System.Drawing.Point(699, 517);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(89, 37);
            this.Btn_guardar.TabIndex = 27;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_cancelar.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Btn_cancelar.Location = new System.Drawing.Point(576, 517);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(98, 37);
            this.Btn_cancelar.TabIndex = 26;
            this.Btn_cancelar.Text = "Cancelar";
            this.Btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // Txt_titulo
            // 
            this.Txt_titulo.AutoSize = true;
            this.Txt_titulo.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.Txt_titulo.Location = new System.Drawing.Point(48, 20);
            this.Txt_titulo.Name = "Txt_titulo";
            this.Txt_titulo.Size = new System.Drawing.Size(165, 21);
            this.Txt_titulo.TabIndex = 25;
            this.Txt_titulo.Text = "Agregar Productos";
            // 
            // frm_ListadoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(820, 562);
            this.Controls.Add(this.Gpb_modo);
            this.Controls.Add(this.Gpb_productos);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_cancelar);
            this.Controls.Add(this.Txt_titulo);
            this.Name = "frm_ListadoDetalle";
            this.Text = "frm_ListadoDetalle";
            this.Load += new System.EventHandler(this.frm_ListadoDetalle_Load);
            this.Gpb_modo.ResumeLayout(false);
            this.Gpb_modo.PerformLayout();
            this.Gpb_productos.ResumeLayout(false);
            this.Gpb_productos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_modo;
        private System.Windows.Forms.Label Txt_aplicar;
        private System.Windows.Forms.TextBox Txt_porcentaje;
        private System.Windows.Forms.Label Txt_descuento;
        private System.Windows.Forms.TextBox Txt_forzado;
        private System.Windows.Forms.RadioButton Rdb_forzar;
        private System.Windows.Forms.RadioButton Rdb_precioventa;
        private System.Windows.Forms.RadioButton Rdb_costocompra;
        private System.Windows.Forms.Label Txt_precioforzado;
        private System.Windows.Forms.GroupBox Gpb_productos;
        private System.Windows.Forms.TextBox Txt_basadocosto;
        private System.Windows.Forms.RadioButton Rdb_basadocosto;
        private System.Windows.Forms.ComboBox Cbo_linea;
        private System.Windows.Forms.RadioButton Rdb_linea;
        private System.Windows.Forms.ComboBox Cbo_marca;
        private System.Windows.Forms.RadioButton Rdb_marca;
        private System.Windows.Forms.TextBox Txt_costo;
        private System.Windows.Forms.Label Txt_costocompra;
        private System.Windows.Forms.TextBox Txt_precio;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox Txt_prod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Txt_precioventa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Txt_producto;
        private System.Windows.Forms.TextBox Txt_cod;
        private System.Windows.Forms.Label Txt_codigo;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.TextBox Txt_productobuscado;
        private System.Windows.Forms.RadioButton Rdb_inventario;
        private System.Windows.Forms.Label Txt_busqueda;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Label Txt_titulo;
    }
}