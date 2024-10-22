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
    public partial class Mantenimientoactivofijo : Form
    {
        public Mantenimientoactivofijo()
        {
            InitializeComponent();
            string[] alias = { "pkid", "Codigo_Activo", "Tipo_Activo", "Descripcion", "Marca", "Modelo", "Fecha_Adqui", "Costo_Adqui", "Vida_Util", "Valor_Residual", "Estado", "pkCuenta" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("tbl_activofijo");
            navegador1.AsignarNombreForm("Activo Fijo");
        }
    }
}
