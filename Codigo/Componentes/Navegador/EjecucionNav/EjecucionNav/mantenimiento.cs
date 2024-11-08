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

            List<string> tablascomponentes = new List<string> { "existencias" };
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
            string fechaActual = DateTime.Now.ToString("yyyy-MM-dd");
            // Llamada al método
            navegador1.AsignarAsociativas(tablasAsociativas);
            var valoresIniciales = new Dictionary<string, (string valorClave, string valorDisplay)>
                {
                    { "tipoOperacion", ("1", "1") },
                    { "fecha", (fechaActual, fechaActual) }

                };

            // Agregar componentes invisibles según los valores iniciales
            foreach (var item in valoresIniciales)
            {
                navegador1.AñadirComponenteInvisible(item.Key, item.Value.valorClave, item.Value.valorDisplay);
            }

            var valoresparamovimiento = new Dictionary<string, string>
                {
                    { "Pk_producto", "id_producto" },          // Componente en vista -> Campo en tabla
                    { "id_bodega", "id_bodega" },              // Componente "monto_total" -> Campo "monto"
                    { "tipoOperacion","id_tipo_movimiento" },
                    { "cantidad", "cantidad" },
                    { "fecha", "fecha" },  // Componente "fecha" -> Campo "fecha_registro"
                    { "costo", "valor_producto" },
                    { "estado", "estado" }          // Componente "estado" -> Campo "estado_registro"
                };
            navegador1.AsignarReglaOperacion(
                    "tipoOperacion",                    // Componente origen
                    "tipos_movimiento",                 // Tabla donde se encuentra el saldo actual
                    "id_tipo_movimiento",                    // Campo de saldo a comparar
                    "igual",                    // Condición de comparación
                    "insertar",                 // Acción a ejecutar si la condición se cumple
                    "movimientos_inventario",                   // Tabla para insertar el registro si la condición es verdadera
                    "tipoOperacion",
                    valoresparamovimiento // Componentes cuyos valores se insertarán en la tabla "Deudas"
                );
        }
    }
}
