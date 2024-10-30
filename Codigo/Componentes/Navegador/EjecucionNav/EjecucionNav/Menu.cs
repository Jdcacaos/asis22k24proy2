using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjecucionNav
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void mANTENIMIENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimiento mantenimiento = new mantenimiento();

            mantenimiento.Show();
        }

        private void fACTURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturas facturas = new Facturas();
            facturas.Show();
        }
    }
}
