using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaVistaActivofijo;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using CapaControladorActivofijo;
namespace pruebasunitarias
{

    [TestClass]
    public class UnitTest1
    {
        private Frm_Activofijo form;
        private Frm_VistadeActivofijo formReporte;


        [TestInitialize]
        public void Setup()
        {
            // Inicializa el formulario para las pruebas
            form = new Frm_Activofijo();
            formReporte = new Frm_VistadeActivofijo();
        }

        [TestMethod]
        public void TestActualizarDataGridView_DataSource_NotNull()
        {
            // Llama al método que llena el DataGridView
            form.actualizarDataGridView();

            // Verifica que el DataGridView tenga una fuente de datos después de actualizar
            Assert.IsNotNull(form.dgv_activofijo.DataSource, "El DataGridView debe tener una fuente de datos después de actualizar.");
        }

        [TestMethod]
        public void TestDeshabilitarControles()
        {
            // Arrange
            Frm_VistadeActivofijo formActivoFijo = new Frm_VistadeActivofijo();

            // Act
            form.DeshabilitarControles(formActivoFijo);

            // Assert
            Assert.IsFalse(formActivoFijo.Txt_CodigoActivo.Enabled);
            Assert.IsFalse(formActivoFijo.Txt_Descripcion.Enabled);
            // Repite para los demás controles...
        }
        [TestMethod]
        public void CargarDatosDepreciacion_CuandoSeLlama_CargaCorrectamenteLosDatos()
        {
            // Arrange
            var form = new Frm_VistadeActivofijo();
            int idActivoFijo = 2; // ID de prueba

            // Crear una instancia real de Controlador
            var controlador = new Controlador();

            // Act
            form.CargarDatosDepreciacion(idActivoFijo);

            // Assert
            DataTable dtDepreciacionEsperada = controlador.ObtenerRegistrosDepreciacion(idActivoFijo);

            // Imprimir los nombres de las columnas para depuración
            Console.WriteLine("Columnas en el DataTable esperado:");
            foreach (DataColumn column in dtDepreciacionEsperada.Columns)
            {
                Console.WriteLine(column.ColumnName);
            }

            // Comprobar el número de filas incluyendo la fila en blanco
            int filasEsperadas = dtDepreciacionEsperada.Rows.Count + 1; // Añadir 1 para la fila en blanco
            Assert.AreEqual(filasEsperadas, form.Dgv_Depreciacion.Rows.Count);

            // Comprobar y mostrar los datos de la primera fila si existen
            if (dtDepreciacionEsperada.Rows.Count > 0)
            {
                var filaEsperada = dtDepreciacionEsperada.Rows[0]["Nombre_Activo"];
                var filaReal = form.Dgv_Depreciacion.Rows[0].Cells["Nombre_Activo"].Value;

                // Imprimir los datos para depuración
                Console.WriteLine($"Dato esperado: {filaEsperada}, Dato real: {filaReal}");

                // Comprobar que los datos son iguales
                Assert.AreEqual(filaEsperada, filaReal);
            }
           
            
        }

        


    }
}
    
    




