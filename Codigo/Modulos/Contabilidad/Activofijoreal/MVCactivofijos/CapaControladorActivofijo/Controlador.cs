using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CapaModeloActivofijo;
using System.Data.Odbc;

namespace CapaControladorActivofijo
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();
        public DataTable llenarTablaActivoFijo(string tabla)
        {
            // Llama al método llenarTablaActivoFijo y obtiene el OdbcDataAdapter
            OdbcDataAdapter dt = sn.llenarTablaActivoFijo(tabla);

            // Crea un nuevo DataTable
            DataTable table = new DataTable();

            // Llena el DataTable con los datos obtenidos
            dt.Fill(table);

            // Retorna el DataTable con los datos de activos fijos
            return table;
        }

        public DataTable Buscar(string tabla, string columna, string dato)
        {
            return sn.Buscar(tabla, columna, dato);

        }

        public List<string> llenarCombo(string columna1, string tabla)
        {
            return sn.llenarCombo(columna1, tabla);
        }
        public void InsertarDepreciacionActivo(DateTime fechaDepreciacion, int idActivoFijo, string nombreActivo, string tipoActivo,
                                        string encargado, string departamento, double depreciacion,
                                        double depreciacionFiscal, string descripcion, int estado, int idCuenta)
        {
            // Crear una instancia del controlador


            // Llamar al método del controlador para guardar los datos
            sn.InsertarDepreciacionActivo(fechaDepreciacion, idActivoFijo, nombreActivo, tipoActivo, encargado, departamento,
                                           depreciacion, depreciacionFiscal, descripcion, estado, idCuenta);
        }
        public DataTable BuscarConEstado(string tabla, string columna, string dato, string estado)
        {
            // Llama al método de la clase Sentencias que realiza la búsqueda
            return sn.BuscarConEstado(tabla, columna, dato, estado);
        }

        public DataTable ObtenerRegistrosConEstado(string tabla, string columna, string estado)
        {
            // Llama al método de la clase Sentencias que realiza la búsqueda
            return sn.ObtenerRegistrosConEstado(tabla, columna, estado);
        }
        public void ActualizarEstadoActivoFijo(int idActivoFijo, int estado)
        {
            // Llama al método de la clase Controlador que realiza la actualización
            sn.ActualizarEstadoActivoFijo(idActivoFijo, estado);
        }

        public DataTable ObtenerRegistrosDepreciacion(int idActivoFijo)
        {

            return sn.ObtenerRegistrosDepreciacion(idActivoFijo);
        }

        public DataTable CargarReporte(int idActivoFijo)
        {
            // Obtener los registros de depreciación para el activo fijo especificado

            return sn.CargarReporte(idActivoFijo);

        }
        public void InsertarMantenimiento(int idActivoFijo2, string companiaAsegurada, string agenteSeguro, string telSiniestro, string tipoCobertura, double montoAsegurado, double primaTotal, double deducible, DateTime vigencia, DateTime fechaUtil, double costoServicio, int periodoServicio, DateTime proxServicio, int estado)
        {
            sn.InsertarMantenimiento(idActivoFijo2, companiaAsegurada, agenteSeguro, telSiniestro, tipoCobertura, montoAsegurado, primaTotal, deducible, vigencia, fechaUtil, costoServicio, periodoServicio, proxServicio, estado);
        }

        public DataTable ObtenerRegistrosHistorialServicio(int idActivoFijo) { 
              return sn.ObtenerRegistrosHistorialServicio(idActivoFijo);
    }

    }
}
