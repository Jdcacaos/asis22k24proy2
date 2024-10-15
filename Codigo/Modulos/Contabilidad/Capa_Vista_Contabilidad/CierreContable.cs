using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Contabilidad
{
    public partial class CierreContable : Form
    {
        public CierreContable()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PartidaCierre partida = new PartidaCierre();
            partida.MdiParent = this.MdiParent;
            partida.StartPosition = FormStartPosition.CenterScreen;
            partida.Show();
        }
    }
}
