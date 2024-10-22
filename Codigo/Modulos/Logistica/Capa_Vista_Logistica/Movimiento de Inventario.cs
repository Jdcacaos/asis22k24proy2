using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Logistica
{
    public partial class Movimiento_de_Inventario : Form
    {
        private string Pk_id_movimiento;
        public Movimiento_de_Inventario()
        {
            InitializeComponent();
            CargarInformacionMovimiento(Pk_id_movimiento);
        }
        private void CargarInformacionMovimiento(string Pk_id_movimiento)
        {
            MessageBox.Show("ID de movimiento seleccionado: " + Pk_id_movimiento);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Movimiento_de_Inventario_Load(object sender, EventArgs e)
        {

        }
    }
}
