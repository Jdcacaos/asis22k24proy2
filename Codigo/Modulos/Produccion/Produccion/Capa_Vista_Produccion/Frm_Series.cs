using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Produccion
{
    public partial class Frm_Series : Form
    {
        public Frm_Series()
        {
            InitializeComponent();

            string[] alias = { "ID Serie", "Codigo ", "Producto", "Fecha Inicio", "Fecha Final", "Etapa", "Descripcion", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            // Instanciar colores personalizados
            Color colorFondo = ColorTranslator.FromHtml("#B1CFE6"); // Color de fondo
            Color colorFuente = ColorTranslator.FromHtml("#112B4D"); // Color de fuente
            navegador1.AsignarColorFondo(colorFondo);
            navegador1.AsignarColorFuente(colorFuente);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("tbl_series");
            navegador1.AsignarNombreForm("Series");
            // List<string> tablas = new List<string> { "otra_tabla_1", "otra_tabla_2" };
            // navegador1.AsignarTablas(tablas); 
        }
    }
}
