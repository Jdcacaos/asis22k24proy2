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
    public partial class mantenimiento : Form
    {
        public mantenimiento()
        {
            InitializeComponent();
            string[] alias = { "codigo", "nombre", "costo", "cantidad", "linea", "marca", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("productos");
            navegador1.AsignarNombreForm("PRODUCTOS");

            navegador1.AsignarComboConTabla("lineas", "codigo_linea", "nombre_linea", 1);
            navegador1.AsignarComboConTabla("marcas", "codigo_marca", "nombre_marca", 1);

            navegador1.AsignarForaneas("lineas", "nombre_linea", "codigo_linea", "codigo_linea");
            navegador1.AsignarForaneas("marcas", "nombre_marca", "codigo_marca", "codigo_marca");

            List<string> tablascomponentes = new List<string> {"existencias" };
            navegador1.AsignarTablaComponentes(tablascomponentes);
            string[] aliasbodega = { "id_bodega" };
            navegador1.AsignarAliasExtras("existencias", aliasbodega);
            navegador1.AsignarComboConTabla("bodegas", "id_bodega", "nombre_bodega", 1);
            List<Tuple<string, List<string>>> tablasAsociativas = new List<Tuple<string, List<string>>>()
            {
                // Ejemplo para la tabla asociativa 'existencias'
                Tuple.Create("existencias", new List<string>
                {
                    "id_bodega","id_bodega",    // Primera clave foránea
                    
                    "id_producto","Pk_producto",

                    "cantidad", "cantidad",      // Segunda clave foránea
                    
                    "estado","estado"

                })
            };

            // Llamada al método
            navegador1.AsignarAsociativas(tablasAsociativas);
        }
    }
}
