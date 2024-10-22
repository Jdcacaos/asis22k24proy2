using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc; // Para OdbcDataReader
using Capa_Modelo_Logistica; // Para Sentencias
using System.Windows.Forms;
using System.Data;

namespace Capa_Controlador_Logistica
{
    public class Controlador
    {
        //Metodo de ingreso de datos de chofer realizado por Ammy Catun 0901-21-4857
        private Capa_Modelo_Logistica.Sentencias sentencias = new Capa_Modelo_Logistica.Sentencias();
        public int guardarChofer(TextBox idChofer, string sNombreEmp, string sNumeroIdent, string sNombre, string sLicencia, string sTelefono, string sDireccion)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(idChofer.Text) || string.IsNullOrEmpty(sNombreEmp) || string.IsNullOrEmpty(sNumeroIdent) ||
                string.IsNullOrEmpty(sNombre) || string.IsNullOrEmpty(sLicencia) || string.IsNullOrEmpty(sTelefono) || string.IsNullOrEmpty(sDireccion))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                sentencias.registrarChofer(idChofer.Text, sNombreEmp, sNumeroIdent, sNombre, sLicencia, sTelefono, sDireccion);
                return 1;
            }
        }
        public DataTable cargarChoferes()
        {
            return sentencias.cargarChoferes();
        }

        public string getNextId()
        {
            int nextId = sentencias.getMaxIdChofer();
            nextId = nextId + 1;
            return nextId.ToString();
        }
        //metodo de eliminar chofer Ammy Patricia Catun Lopez 0901-21-4857
        public void eliminarChofer(string idChofer)
        {
            //se valida que el textbox no este vacío o con espacios en blanco
            if (string.IsNullOrEmpty(idChofer))
            {
                MessageBox.Show("Existen campos vacios, revise y vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                sentencias.eliminarChofer(idChofer);
            }
        }

        //metodo de modificar chofer Ammy Patricia Catun Lopez 0901-21-4857
        public void modificarChofer(string idChofer, string nombreEmp, string numeroIdent, string nombre, string licencia, string telefono, string direccion)
        {
            sentencias.modificarChofer(idChofer, nombreEmp, numeroIdent, nombre, licencia, telefono, direccion);
        }
        //metodo de buscar chofer Ammy Patricia Catun Lopez 0901-21-4857
        public DataTable buscarChofer(string idChofer)
        {
            return sentencias.buscarChofer(idChofer);
        }
        public void RealizarSolicitudMantenimiento(int idMantenimiento, string nombreSolicitante, string tipoMantenimiento, string componenteAfectado, string fecha, string responsableAsignado, string codigo_error_Problema, string estadoMantenimiento, string tiempoEstimado, int id_Movimiento)
        {
            sentencias.InsertarSolicitudMantenimiento(idMantenimiento, nombreSolicitante, tipoMantenimiento, componenteAfectado, fecha, responsableAsignado, codigo_error_Problema, estadoMantenimiento, tiempoEstimado, id_Movimiento);
        }

        // Método para obtener existencias de una bodega (Realizado por Daniel Sierra 0901-21-12740)
        public OdbcDataReader ObtenerExistenciasBodega(string idBodega)
        {
            return sentencias.ObtenerExistenciasBodega(idBodega);
        }

        // Método para cargar existencias (puede agregar más lógica si es necesario) (Realizado por Daniel Sierra 0901-21-12740)
        public void CargarExistencias(string idBodega)
        {
            OdbcDataReader dr = ObtenerExistenciasBodega(idBodega);
            // Aquí puedes agregar lógica para manejar los datos obtenidos, como llenarlos en un DataGridView
        }

        public void CargarExistencias(string idBodega, DataTable dtExistencias)
        {
            using (OdbcDataReader dr = ObtenerExistenciasBodega(idBodega))
            {
                if (dr != null)
                {
                    try
                    {
                        dtExistencias.Load(dr); // Carga los datos en el DataTable
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al cargar las existencias: " + ex.Message);
                    }
                    finally
                    {
                        dr.Close(); // Asegúrate de cerrar el DataReader
                    }
                }
                else
                {
                    throw new Exception("No se pudieron obtener existencias para la bodega seleccionada.");
                }
            }
        }

        // Método para realizar auditoría (Realizado por Daniel Sierra 0901-21-12740)
        public void RealizarAuditoria(string idBodega, string idProducto, int cantidadFisica, int cantidadRegistrada, bool discrepancia)
        {
            sentencias.InsertarAuditoria(idBodega, idProducto, cantidadFisica, cantidadRegistrada, discrepancia);
        }

        // Método para obtener las bodegas

        public List<KeyValuePair<int, string>> listadoBodegas()
        {
            return sentencias.GetBodegas(); // Llama al método actualizado
        }




        // Método para obtener productos
        public List<KeyValuePair<int, string>> listadoProductos()
        {
            return sentencias.GetProductos(); // Llama al método actualizado
        }

        // Método para registrar una auditoría
        public void RealizarAuditoria(int idBodega, int idProducto, DateTime fechaAuditoria, string observaciones, int cantidadRegistrada, int cantidadFisica, bool discrepancia)
        {
            sentencias.InsertarAuditoria(idBodega, idProducto, fechaAuditoria, observaciones, cantidadRegistrada, cantidadFisica, discrepancia);
        }

        // Método para cargar las auditorías en el DataGridView
        public DataTable CargarAuditorias()
        {
            return sentencias.ObtenerAuditorias();
        }

        public void RealizarAuditoria(
     int idBodega,
     int idProducto,
     DateTime fechaAuditoria,
     string observaciones,
     int cantidadRegistrada,
     int cantidadFisica,
     bool discrepancia,
     DataGridView dgvAuditorias)
        {
            try
            {
                // Llamar al método para insertar auditoría
                string resultado = sentencias.InsertarAuditoria(idBodega, idProducto, fechaAuditoria, observaciones, cantidadRegistrada, cantidadFisica, discrepancia);

                // Comprobar el resultado de la inserción
                if (resultado == "Auditoría realizada con éxito")
                {
                    MessageBox.Show(resultado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarAuditorias(dgvAuditorias); // Actualizar DataGridView
                }
                else
                {
                    MessageBox.Show("Error al realizar auditoría: " + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void CargarAuditorias(DataGridView dgvAuditorias)
        {
            try
            {
                DataTable dtAuditorias = sentencias.ObtenerAuditorias();
                dgvAuditorias.DataSource = dtAuditorias;

                // Configura las columnas según sea necesario
                if (dtAuditorias.Columns.Count > 0)
                {
                    dgvAuditorias.Columns[0].HeaderText = "ID Auditoría"; // Pk_ID_AUDITORIA
                    dgvAuditorias.Columns[1].HeaderText = "Bodega"; // Fk_ID_BODEGA
                    dgvAuditorias.Columns[2].HeaderText = "Producto"; // Fk_ID_PRODUCTO
                    dgvAuditorias.Columns[3].HeaderText = "Fecha Auditoría"; // FECHA_AUDITORIA
                    dgvAuditorias.Columns[4].HeaderText = "Observaciones"; // OBSERVACIONES
                    dgvAuditorias.Columns[5].HeaderText = "Cantidad Registrada"; // CANTIDAD_REGISTRADA
                    dgvAuditorias.Columns[6].HeaderText = "Cantidad Física"; // CANTIDAD_FISICA
                    dgvAuditorias.Columns[7].HeaderText = "Discrepancia"; // DISCREPANCIA_DETECTADA
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar auditorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

