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
    public partial class Facturas : Form
    {
        public Facturas()
        {
            InitializeComponent();
            string[] alias = { "codigo", "Cliente", "fecha", "Monto", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("facturas");
            navegador1.AsignarNombreForm("FACTURAS");

            //PARAMETRO PARA INGRESAR VARIOS REGISTROS
            navegador1.AsignarVarios(true);
            navegador1.AsignarTablaVarios("detalle_factura");

            //PARAMETROS PARA LLAMAR DATOS DE FORANEAS Y MOSTRARLOS
            navegador1.AsignarComboConTabla("clientes", "Pk_cliente", "nombre_cliente", 1);
            navegador1.AsignarForaneas("clientes", "nombre_cliente", "id_cliente", "Pk_cliente");

            //PARAMETRO PARA QUE ESTA TABLA TOME EL ID DE LA PRINCIPAL
            List<string> tablas = new List<string> { "detalle_factura" };
            navegador1.AsignarTablas(tablas);

            //PARAMETRO PARA DECIR QUE TABLAS CREARAN COMPONENTES
            List<string> tablascomponentes = new List<string> { "detalle_factura" };
            navegador1.AsignarTablaComponentes(tablascomponentes);

            //PARAMETROS PARA CREAR NUEVOS COMPONENTES DE OTRA TABLA
            string[] aliasfacturadetalle = { "id_producto", "cantidad", "precio_unitario", "subtotal", "estado" };
            navegador1.AsignarAliasExtras("detalle_factura", aliasfacturadetalle);
            navegador1.AsignarComboConTabla("productos", "Pk_producto", "nombre_producto", 1);

            var mapeoComponentesCampos = new Dictionary<string, string>
                {
                    { "id_cliente", "id_cliente" },          // Componente en vista -> Campo en tabla
                    { "monto_total", "monto" },              // Componente "monto_total" -> Campo "monto"
                    { "fecha", "fecha" },           // Componente "fecha" -> Campo "fecha_registro"
                    { "estado", "estado" }          // Componente "estado" -> Campo "estado_registro"
                };
            navegador1.AsignarReglaOperacion(
                    "monto_total",                    // Componente origen
                    "clientes",                 // Tabla donde se encuentra el saldo actual
                    "saldo",                    // Campo de saldo a comparar
                    "mayor",                    // Condición de comparación
                    "insertar",                 // Acción a ejecutar si la condición se cumple
                    "deudas",                   // Tabla para insertar el registro si la condición es verdadera
                    "id_cliente",
                    mapeoComponentesCampos // Componentes cuyos valores se insertarán en la tabla "Deudas"
                );

            // Ejecutar todas las reglas configuradas
            navegador1.AsignarOperacionIndividual("monto_total", "clientes", "saldo", "restar", "Pk_cliente", "id_cliente");
            navegador1.AsignarOperacionVarios("cantidad", "productos", "cantidad", "restar", "Pk_producto", "id_producto");
        }
    }
}
