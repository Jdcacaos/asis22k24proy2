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
    public partial class Polizas : Form
    {
        public Polizas()
        {
            InitializeComponent();
            string[] alias = { "codigo", "fecha", "concepto", "Tipo Poliza", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("tbl_polizaencabezado");
            navegador1.AsignarNombreForm("RECETAS");

            navegador1.AsignarVarios(true);
            navegador1.AsignarTablaVarios("tbl_polizadetalle");

            navegador1.AsignarComboConTabla("tbl_tipopoliza", "Pk_id_tipopoliza", "tipo", 1);

            List<string> tablas = new List<string> { "tbl_polizadetalle" };
            navegador1.AsignarTablas(tablas);

            List<string> tablascomponentes = new List<string> { "tbl_polizadetalle" };
            navegador1.AsignarTablaComponentes(tablascomponentes);

            string[] aliaspolizadetalle = { "Pk_id_cuenta", "Pk_id_tipooperacion", "valor" };
            navegador1.AsignarAliasExtras("tbl_polizadetalle", aliaspolizadetalle);

            navegador1.AsignarComboConTabla("tbl_cuentas", "Pk_id_cuenta", "nombre_cuenta", 1);
            navegador1.AsignarComboConTabla("tbl_tipooperacion", "Pk_id_tipooperacion", "nombre", 1);

            navegador1.AsignarOperacionVarios("valor", "tbl_cuentas", "cargo_acumulado", "sumar", "Pk_id_cuenta", "Pk_id_cuenta");

        }

    }
}
