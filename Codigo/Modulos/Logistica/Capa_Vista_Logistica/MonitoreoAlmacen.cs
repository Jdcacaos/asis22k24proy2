using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Capa_Controlador_Logistica; // Para Controlador

namespace Capa_Vista_Logistica
{
    public partial class MonitoreoAlmacen : Form
    {
        private string idBodega; // Campo para almacenar el ID de la bodega
        Controlador controlador = new Controlador(); // Instancia del controlador

        // Constructor que recibe el ID de la bodega
        public MonitoreoAlmacen()
        {
            InitializeComponent();

            // Cargar información de la bodega
            CargarInformacionBodega(idBodega);

            // Cargar bodegas y productos
            cargarBodegas(); // Cargar primero las bodegas
            cargarProductos(); // Luego cargar los productos

            // Cargar bodegas y productos en auditoría
            cargarBodegasAuditoria();
            cargarProductosAuditoria();
        }






        private void CargarInformacionBodega(string idBodega)
        {
            MessageBox.Show("ID de Bodega seleccionado: " + idBodega);

            OdbcDataReader dr = controlador.ObtenerExistenciasBodega(idBodega);

            // Verificar si dr es null
            if (dr == null)
            {
                MessageBox.Show("No se pudieron obtener existencias para la bodega seleccionada.");
                return; // Salir del método si no hay datos
            }

            try
            {
                DataTable dtExistencias = new DataTable();
                dtExistencias.Load(dr);
                dgvExistencias.DataSource = dtExistencias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las existencias: " + ex.Message);
            }
            finally
            {
                // Asegurarse de cerrar el DataReader
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCargarExistencias_Click(object sender, EventArgs e)
        {
            if (cmbBodega.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una bodega antes de cargar las existencias.");
                return; // Salir del método si no hay selección
            }

            var selectedBodega = (KeyValuePair<int, string>)cmbBodega.SelectedItem; // Obtener el KeyValuePair
            int idBodega = selectedBodega.Key; // Usar la clave como ID de bodega

            DataTable dtExistencias = new DataTable(); // Crear un DataTable para recibir los datos
            try
            {
                controlador.CargarExistencias(idBodega.ToString(), dtExistencias); // Cargar las existencias en el DataTable
                dgvExistencias.DataSource = dtExistencias; // Asignar el DataTable al DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Mostrar cualquier error que ocurra
            }
        }

        private void btnRealizarAuditoria_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar que los ComboBoxes tengan un valor seleccionado
                if (cmbBodegaAuditoria.SelectedItem == null || cmbProductoAuditoria.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una bodega y un producto.");
                    return;
                }

                // Obtener valores de los controles con validaciones adecuadas
                int idBodega = Convert.ToInt32(cmbBodegaAuditoria.SelectedValue);
                int idProducto = Convert.ToInt32(cmbProductoAuditoria.SelectedValue);
                DateTime fechaAuditoria = dtpFechaAuditoria.Value;
                string observaciones = txtObservaciones.Text;

                // Validación y conversión de la cantidad registrada
                if (!int.TryParse(txtCantidadRegistrada.Text, out int cantidadRegistrada))
                {
                    MessageBox.Show("La cantidad registrada debe ser un número entero.");
                    return;
                }

                // Validación y conversión de la cantidad física
                if (!int.TryParse(txtCantidadFisica.Text, out int cantidadFisica))
                {
                    MessageBox.Show("La cantidad física debe ser un número entero.");
                    return;
                }

                // Obtener valor del CheckBox como booleano
                bool discrepancia = chkDiscrepanciaDetectada.Checked;

                // Realizar la auditoría a través del controlador
                controlador.RealizarAuditoria(idBodega, idProducto, fechaAuditoria, observaciones, cantidadRegistrada, cantidadFisica, discrepancia, dgvAuditorias);

                // Mostrar mensaje de éxito
                MessageBox.Show("Auditoría realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cargar auditorías en el DataGridView
                controlador.CargarAuditorias(dgvAuditorias);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el formato de entrada: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar auditoría: " + ex.Message);
            }
        }

        // Método para cargar las bodegas en el ComboBox
        private void cargarBodegas()
        {
            List<KeyValuePair<int, string>> bodegas = controlador.listadoBodegas();
            cmbBodega.DataSource = bodegas;
            cmbBodega.DisplayMember = "Value"; // Mostrar el nombre de la bodega
            cmbBodega.ValueMember = "Key"; // Usar el ID de la bodega como valor
        }

        private void cargarBodegasAuditoria()
        {
            List<KeyValuePair<int, string>> bodegas = controlador.listadoBodegas();

            // Depuración
            Console.WriteLine($"Bodegas encontradas: {bodegas.Count}");

            if (bodegas.Count > 0)
            {
                cmbBodegaAuditoria.DataSource = bodegas; // Asigna la lista al ComboBox
                cmbBodegaAuditoria.DisplayMember = "Key"; // Mostrar ID de la bodega
                cmbBodegaAuditoria.ValueMember = "Key"; // Usar el ID de la bodega como valor
            }
            else
            {
                MessageBox.Show("No se encontraron bodegas.");
            }
        }



        private void cargarProductosAuditoria()
        {
            List<KeyValuePair<int, string>> productos = controlador.listadoProductos(); // Cambia aquí

            // Depuración
            Console.WriteLine($"Productos encontrados: {productos.Count}");

            if (productos.Count > 0)
            {
                cmbProductoAuditoria.DataSource = productos; // Asigna la lista al ComboBox
                cmbProductoAuditoria.DisplayMember = "Key"; // Mostrar ID del producto
                cmbProductoAuditoria.ValueMember = "Key"; // Usar el ID del producto como valor
            }
            else
            {
                MessageBox.Show("No se encontraron productos.");
            }
        }


        private void cargarProductos()
        {
            List<string> productos = controlador.listadoProductos().Select(p => p.Value).ToList(); // Solo nombres de productos

            // Depuración
            Console.WriteLine($"Productos encontrados: {productos.Count}"); // Imprime la cantidad de productos

            if (productos.Count > 0)
            {
                cmbProducto.DataSource = productos; // Asigna la lista al ComboBox
            }
            else
            {
                MessageBox.Show("No se encontraron productos."); // Mensaje si no hay productos
            }
        }






        private void cmbBodega_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBodegaAuditoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProductoAuditoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
