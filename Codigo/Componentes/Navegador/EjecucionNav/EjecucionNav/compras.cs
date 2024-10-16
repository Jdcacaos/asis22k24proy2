using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejecucionNav
{
    public partial class compras : Form
    {
        public compras()
        {
            InitializeComponent();
            string[] alias = { "codigo", "vehiculo", "cantidad", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("detalle_venta_vehiculos");
            navegador1.AsignarNombreForm("COMPRAS");
            navegador1.AsignarComboConTabla("vehiculos", "Pk_vehiculo", "nombre_vehiculo", 1);
            navegador1.AsignarForaneas("vehiculos", "nombre_vehiculo", "Fk_vehiculo", "Pk_vehiculo");

            navegador1.AsignarOperacion( "detalle_venta_vehiculos", "cantidad_vendida", "inventario_vehiculos", "cantidad_existencia", "restar");
            
            List<string> tablas = new List<string> { "venta" };
            navegador1.AsignarTablas(tablas);

            string[] aliasventa = { "nombre_cliente", "nombre_empleado","monto","estado" };
            navegador1.AsignarAliasExtras("venta", aliasventa);

        }
    }
}
