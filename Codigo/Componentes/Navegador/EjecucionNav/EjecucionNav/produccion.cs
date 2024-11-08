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
    public partial class produccion : Form
    {
        public produccion()
        {
            InitializeComponent();
            string[] alias = { "codigo", "fecha inicio", "fecha fin", "cantidad", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("tbl_ordenes_produccion");
            navegador1.AsignarNombreForm("FACTURAS");

            //PARAMETRO PARA INGRESAR VARIOS REGISTROS
            navegador1.AsignarVarios(true);
            navegador1.AsignarTablaVarios("tbl_ordenes_produccion_detalle");

            List<string> tablas = new List<string> { "tbl_ordenes_produccion_detalle" };
            navegador1.AsignarTablas(tablas);

            List<string> tablascomponentes = new List<string> { "tbl_ordenes_produccion_detalle" };
            navegador1.AsignarTablaComponentes(tablascomponentes);


            string[] aliaspolizadetalle = { "Fk_id_producto", "cantidad" };
            navegador1.AsignarAliasExtras("tbl_ordenes_produccion_detalle", aliaspolizadetalle);

            navegador1.AsignarComboConTabla("tbl_productos", "Pk_id_Producto", "nombreProducto", 1);
        }
    }
}
