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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
            string[] alias = { "codigo", "cliente", "monto", "fecha", "metodo_pago", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("pagos");
            navegador1.AsignarNombreForm("PAGOS");
            navegador1.AsignarOperacionIndividual("monto", "clientes", "saldo", "sumar", "Pk_cliente", "id_cliente");
            navegador1.AsignarComboConTabla("clientes", "Pk_cliente", "nombre_cliente", 1);
        }
    }
}
