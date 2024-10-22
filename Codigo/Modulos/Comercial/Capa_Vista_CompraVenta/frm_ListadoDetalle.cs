using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_CompraVenta
{
    public partial class frm_ListadoDetalle : Form
    {
        // Variable de control para determinar el estado de los TextBox.
        private bool isTextBoxEnabled = false;

        public frm_ListadoDetalle()
        {
            InitializeComponent();

            // Deshabilitar los TextBox
            textBox1.Enabled = false;
            Txt_prod.Enabled = false;
            textBox3.Enabled = false;
            Txt_basadocosto.Enabled = false;
            Txt_productobuscado.Enabled = false;
            Txt_cod.Enabled = false;
            Txt_precio.Enabled = false;
            Txt_costo.Enabled = false;
            Txt_forzado.Enabled = false;
            Txt_porcentaje.Enabled = false;
            Btn_buscar.Enabled = false;

            // Deshabilitar checkBox
            Cbo_linea.Enabled = false;
            Cbo_marca.Enabled = false;

            // Asignar el evento CheckedChanged del RadioButton.
            Rdb_inventario.CheckedChanged += new EventHandler(Rdb_inventario_CheckedChanged);
            Rdb_marca.CheckedChanged += new EventHandler(Rdb_marca_CheckedChanged);
            Rdb_basadocosto.CheckedChanged += new EventHandler(Rdb_basadocosto_CheckedChanged);
            Rdb_forzar.CheckedChanged += new EventHandler(Rdb_forzar_CheckedChanged);
            Rdb_linea.CheckedChanged += new EventHandler(Rdb_linea_CheckedChanged);
        }

        private void frm_ListadoDetalle_Load(object sender, EventArgs e)
        {

        }

        private void Rdb_inventario_CheckedChanged(object sender, EventArgs e)
        {
            // Si el CheckBox está marcado, habilita los TextBox. Si no, lo deshabilita.
            if (Rdb_inventario.Checked)
            {
                // Habilita los TextBox 
                Txt_productobuscado.Enabled = true;
                Btn_buscar.Enabled = true;
            }
            else
            {
                // Deshabilita los TextBox y borra el contenido.
                textBox1.Enabled = false;
                Txt_prod.Enabled = false;
                textBox3.Enabled = false;
                Txt_productobuscado.Enabled = false;
                textBox3.Enabled = false;
                Txt_cod.Enabled = false;
                Txt_precio.Enabled = false;
                Txt_costo.Enabled = false;
                textBox1.Clear();
                Txt_prod.Clear();
                textBox3.Clear();
                Txt_cod.Clear();
                Txt_precio.Clear();
                Txt_costo.Clear();
                Btn_buscar.Enabled = false;
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            // Cambiar el estado de la variable de control
            isTextBoxEnabled = !isTextBoxEnabled;

            if (isTextBoxEnabled)
            {
                // Habilita los TextBox en solo lectura
                textBox1.Enabled = true;
                Txt_prod.Enabled = true;
                textBox3.Enabled = true;
                Txt_cod.Enabled = true;
                Txt_precio.Enabled = true;
                Txt_costo.Enabled = true;
                textBox1.ReadOnly = true;
                Txt_prod.ReadOnly = true;
                textBox3.ReadOnly = true;
                Txt_cod.ReadOnly = true;
                Txt_precio.ReadOnly = true;
                Txt_costo.ReadOnly = true;

                // Mostrar información en los TextBox
                textBox1.Text = "100";
                Txt_prod.Text = "1290F";
                textBox3.Text = "En existencia";
                Txt_cod.Text = "Colchón King";
                Txt_precio.Text = "Q. 4500.00";
                Txt_costo.Text = "Q. 3500.00";
            }
            else
            {

            }
        }

        private void Rdb_marca_CheckedChanged(object sender, EventArgs e)
        {
            // Si el radioButton2 está seleccionado, habilita el comboBox2
            if (Rdb_marca.Checked)
            {
                // Habilita el ComboBox
                Cbo_marca.Enabled = true;
            }
            else
            {
                // Deshabilita el ComboBox
                Cbo_marca.Enabled = false;
                //limpiar el comboBox
                Cbo_marca.Items.Clear();
            }
        }

        private void Rdb_linea_CheckedChanged(object sender, EventArgs e)
        {
            // Si el radioButton2 está seleccionado, habilita el comboBox2
            if (Rdb_linea.Checked)
            {
                // Habilita el ComboBox
                Cbo_linea.Enabled = true;
            }
            else
            {
                // Deshabilita el ComboBox
                Cbo_linea.Enabled = false;
                //limpiar el comboBox
                Cbo_linea.Items.Clear();
            }
        }

        private void Rdb_basadocosto_CheckedChanged(object sender, EventArgs e)
        {
            // Si el radioButton2 está seleccionado, habilita el textBox
            if (Rdb_basadocosto.Checked)
            {
                // Habilita el ComboBox
                Txt_basadocosto.Enabled = true;
            }
            else
            {
                // Deshabilita el textBox
                Txt_basadocosto.Enabled = false;
                // Limpiar textBox
                Txt_basadocosto.Clear();
            }
        }

        private void Rdb_forzar_CheckedChanged(object sender, EventArgs e)
        {
            // Si el radioButton2 está seleccionado, habilita el textBox
            if (Rdb_forzar.Checked)
            {
                // Habilita el ComboBox
                Txt_forzado.Enabled = true;
            }
            else
            {
                // Deshabilita el textBox
                Txt_forzado.Enabled = false;
                // Limpiar textBox
                Txt_forzado.Clear();
            }
        }

        private void Rdb_precioventa_CheckedChanged(object sender, EventArgs e)
        {
            // Si el radioButton2 está seleccionado, habilita el textBox
            if (Rdb_precioventa.Checked)
            {
                // Habilita el ComboBox
                Txt_porcentaje.Enabled = true;
            }
            else
            {
                // Deshabilita el textBox
                Txt_porcentaje.Enabled = false;
                // Limpiar textBox
                Txt_porcentaje.Clear();
            }
        }

        private void Rdb_costocompra_CheckedChanged(object sender, EventArgs e)
        {
            // Si el radioButton2 está seleccionado, habilita el textBox
            if (Rdb_costocompra.Checked)
            {
                // Habilita el ComboBox
                Txt_porcentaje.Enabled = true;
            }
            else
            {
                // Deshabilita el textBox
                Txt_porcentaje.Enabled = false;
                // Limpiar textBox
                Txt_porcentaje.Clear();
            }
        }
    }
}
