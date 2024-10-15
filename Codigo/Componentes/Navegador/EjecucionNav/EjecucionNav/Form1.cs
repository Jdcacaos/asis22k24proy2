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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           


            /* string[] alias = { "codigo", "nombre", "linea", "marca", "existencia", "estado" };
             navegador1.AsignarAlias(alias);
             navegador1.AsignarSalida(this);
             navegador1.AsignarColorFondo(Color.LightBlue);
             navegador1.AsignarColorFuente(Color.BlueViolet);
             navegador1.ObtenerIdAplicacion("1000");
             navegador1.AsignarAyuda("1");
             navegador1.ObtenerIdUsuario("admin");
             navegador1.AsignarTabla("productos");
             navegador1.AsignarComboConTabla("lineas", "codigo_linea", "nombre_linea", 1);
             navegador1.AsignarComboConTabla("marcas", "codigo_marca", "nombre_marca", 1);
             navegador1.AsignarForaneas("lineas", "nombre_linea", "codigo_linea", "codigo_linea");
             navegador1.AsignarForaneas("marcas", "nombre_marca", "codigo_marca", "codigo_marca");
             navegador1.AsignarNombreForm("PERROS");
             /* string[] alias = { "ID", "nombre", "raza", "Estado"};
             navegador1.AsignarAlias(alias);
             navegador1.AsignarSalida(this);
             navegador1.AsignarColorFondo(Color.LightBlue);
             navegador1.AsignarColorFuente(Color.BlueViolet);
             navegador1.AsignarTabla("perro");

            navegador1.AsignarComboConTabla("razas", "id_raza", "nombre_raza", 1);
             navegador1.AsignarForaneas("razas", "nombre_raza", "id_raza", "id_raza");

             navegador1.ObtenerIdAplicacion("1000");
             navegador1.ObtenerIdUsuario("admin");
             navegador1.AsignarAyuda("1");
             navegador1.AsignarNombreForm("VENTAS");
             string[] alias = { "ID", "Fecha", "Monto", "Estado" };
              navegador1.AsignarAlias(alias);
              navegador1.AsignarSalida(this);
              navegador1.AsignarColorFondo(Color.LightBlue);
              navegador1.AsignarColorFuente(Color.BlueViolet);
              navegador1.AsignarTabla("factura");
              navegador1.ObtenerIdAplicacion("1000");
              navegador1.ObtenerIdUsuario("admin");
              navegador1.AsignarAyuda("1");
              navegador1.AsignarNombreForm("VENTAS");*/
            /*  string[] alias = { "ID", "Fecha", "Monto", "Estado" };
                  navegador1.AsignarAlias(alias);
                  navegador1.AsignarSalida(this);
                  navegador1.AsignarColorFondo(Color.LightBlue);
                  navegador1.AsignarColorFuente(Color.BlueViolet);
                  navegador1.AsignarTabla("factura");

                  // Configuración de las tablas adicionales
                  List<string> tablas = new List<string> { "detalle_factura","pago","envio"};
                  navegador1.AsignarTablas(tablas);

                  // Configuración de los alias para las tablas adicionales
                  string[] aliasDetalleFactura = { "cantidad", "precio_unitario","estado"};
                  navegador1.AsignarAliasExtras("detalle_factura", aliasDetalleFactura);

                  string[] aliasdetallespago = { "metodo_pago", "fecha_pago","estado" };
                  navegador1.AsignarAliasExtras("pago", aliasdetallespago);

                  string[] aliasdetallesenvio = { "direccion_envio", "fecha_envio","estado" };
                  navegador1.AsignarAliasExtras("envio", aliasdetallesenvio);



                  // Asignación de otros parámetros necesarios
                  navegador1.ObtenerIdAplicacion("1000");
                  navegador1.ObtenerIdUsuario("admin");
                  navegador1.AsignarAyuda("1");
                  navegador1.AsignarNombreForm("VENTAS");*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimiento mantenimiento = new mantenimiento();
            
            mantenimiento.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compras compras = new compras();
            
            compras.Show();
        }
    }
}
