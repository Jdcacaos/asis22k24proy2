using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CapaControladorActivofijo;
using CrystalDecisions.Windows.Forms;
using System.IO;

namespace CapaVistaActivofijo
{
    public partial class Frm_VistadeActivofijo : Form
    {
        private ReportDocument reporte;
        public Frm_VistadeActivofijo()
        {
            InitializeComponent();

            reporte = new ReportDocument();
            
        }

        public void CargarDatosDepreciacion(int idActivoFijo)
        {
            // Crear una instancia del controlador
            Controlador cn = new Controlador();

            // Obtener los registros de depreciación para el ID del activo fijo
            DataTable dtDepreciacion = cn.ObtenerRegistrosDepreciacion(idActivoFijo);

            // Asignar el DataTable al DataGridView que usas para mostrar los datos de depreciación
            Dgv_Depreciacion.DataSource = dtDepreciacion; // Cambiar a dataGridViewDepreciacion

            // Si deseas realizar alguna configuración adicional del DataGridView
            Dgv_Depreciacion.AutoResizeColumns();
        }

        public void CargarDatosMantenimiento(int idActivoFijo)
        {
            // Crear una instancia del controlador
            Controlador cn = new Controlador();

            // Obtener los registros de mantenimiento para el ID del activo fijo
            DataTable dtMantenimiento = cn.ObtenerRegistrosHistorialServicio(idActivoFijo);

            // Asignar el DataTable al DataGridView que usas para mostrar los datos de mantenimiento
            Dgv_Mantenimiento.DataSource = dtMantenimiento;

            // Configuración adicional del DataGridView si es necesario
            Dgv_Mantenimiento.AutoResizeColumns();
        }



        public void Btn_reporte_Click(object sender, EventArgs e)
        {
           

        }

        private void ShowMessage(string v)
        {
            throw new NotImplementedException();
        }
       

        private void Dgv_Depreciacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string FindFileInDirectoryReporte(string directory, string fileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(directory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] files = Directory.GetFiles(directory, "*.rpt", SearchOption.TopDirectoryOnly);
                    // Si encontramos el archivo, verificamos si coincide con el archivo que se busca y retornamos su ruta
                    foreach (var file in files)
                    {
                        if (Path.GetFileName(file).Equals(fileName, StringComparison.OrdinalIgnoreCase))
                        {
                            //MessageBox.Show("Archivo encontrado: " + file);
                            return file;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró la carpeta: " + directory);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el archivo: " + ex.Message);
            }
            // Retorna null si no se encontró el archivo
            return null;
        }
        private void Btn_depreci_Click(object sender, EventArgs e)
        {
            FormReporteunitario reporteForm = new FormReporteunitario();
            ReportDocument reportDocument = new ReportDocument();

            try
            {
                string executablePath = AppDomain.CurrentDomain.BaseDirectory;
                string projectRoot = executablePath;

                // Buscar hacia arriba hasta encontrar la carpeta "Codigo"
                while (!Directory.Exists(Path.Combine(projectRoot, "Codigo")) &&
                       Directory.GetParent(projectRoot) != null)
                {
                    projectRoot = Directory.GetParent(projectRoot).FullName;
                }

                // Nombre del archivo del reporte 
                string sReporteFolderPath = Path.Combine(projectRoot, "Reportes", "Modulos", "Contabilidad", "Activifijo");

                // Buscar el archivo del reporte
                string pathReporte = FindFileInDirectoryReporte(sReporteFolderPath, "CrystalReport3.rpt");

                // Verificar si el archivo existe en la ruta especificada
                if (string.IsNullOrEmpty(pathReporte))
                {
                    MessageBox.Show("El archivo de reporte no se encontró en la ruta esperada.");
                    return;
                }

                // Cargar el reporte desde la ruta especificada
                reportDocument.Load(pathReporte);
                reportDocument.Refresh();

                // Crear un DataTable con los datos que se mostrarán en el reporte
                DataTable dtReportData = (DataTable)Dgv_Depreciacion.DataSource;

                // Verificar que el DataTable no esté vacío
                if (dtReportData == null || dtReportData.Rows.Count == 0)
                {
                    MessageBox.Show("No hay datos disponibles para mostrar en el reporte.");
                    return;
                }

                // Asignar el DataTable al reporte
                reportDocument.SetDataSource(dtReportData);

                // Asignar el reporte al visor de Crystal Reports en el formulario
                reporteForm.crystalReportViewer1.ReportSource = reportDocument;

                // Mostrar el formulario de reporte
                reporteForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el reporte: " + ex.Message);
            }
            finally
            {
                // Liberar recursos del reporte
                reportDocument.Close();
                reportDocument.Dispose();
            }

        }
        private string GetProjectRoot()
        {
            // Buscar la carpeta raíz del proyecto (donde está la carpeta "Codigo")
            string executablePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectRoot = executablePath;

            // Buscar hacia arriba hasta encontrar la carpeta "Codigo"
            while (!Directory.Exists(Path.Combine(projectRoot, "Codigo")) &&
                   Directory.GetParent(projectRoot) != null)
            {
                projectRoot = Directory.GetParent(projectRoot).FullName;
            }

            return projectRoot;
        }

        private void Dgv_Mantenimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
      
}
    


