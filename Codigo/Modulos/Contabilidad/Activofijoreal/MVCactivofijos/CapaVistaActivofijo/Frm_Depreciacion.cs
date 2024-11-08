using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorActivofijo;

namespace CapaVistaActivofijo
{
    public partial class Frm_Depreciacion : Form
    {
        private bool isUpdatingFields = false;
        Controlador cn = new Controlador();
        public Frm_Depreciacion()
        {
            InitializeComponent();
            LlenarComboActivoFijo();
            CargarDescripcionActivos();
            // Asignar eventos a los TextBox
            Txt_CostoAdqui.TextChanged += new EventHandler(TextBox_TextChanged);
            Txt_VidaUtil.TextChanged += new EventHandler(TextBox_TextChanged);
            Txt_ValorResidual.TextChanged += new EventHandler(TextBox_TextChanged);

            // Asignar eventos a los CheckBox
            Chk_LineaRecta.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            Chk_DobleSaldoDeclinable.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            Chk_SumaAnosDigitos.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (isUpdatingFields) return;

            // Validación de campos
            if (!decimal.TryParse(Txt_CostoAdqui.Text, out _))
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en el costo de adquisición.");
            }
            if (!decimal.TryParse(Txt_VidaUtil.Text, out _))
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en la vida útil.");
            }
            if (!decimal.TryParse(Txt_ValorResidual.Text, out _))
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en el valor residual.");
            }
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalcularDepreciacion(); // Llama a tu método de cálculo
        }
        public void LlenarComboActivoFijo()
        {
            List<string> descripciones = cn.llenarCombo("Descripcion", "tbl_activofijo");
            Cbo_descripcion.Items.Clear();
            Cbo_descripcion.Items.AddRange(descripciones.ToArray());
        }

        public void BuscarDetalleActivoFijo()
        {
            string tabla = "tbl_ActivoFijo";
            string columna = "Descripcion"; // Usar Descripcion para búsqueda
            string dato = (Cbo_descripcion.SelectedItem != null) ? Cbo_descripcion.SelectedItem.ToString() : string.Empty;

            // Modificar la búsqueda para incluir solo registros con Estado = '1'
            DataTable dt = cn.BuscarConEstado(tabla, columna, dato, "1");

            if (dt.Rows.Count > 0)
            {
                // Deshabilitar eventos de TextChanged
                isUpdatingFields = true;

                // Mostrar detalles en TextBox
                Txt_IDActivoFijo.Text = dt.Rows[0]["Pk_Id_ActivoFijo"].ToString();
                Txt_CodigoActivo.Text = dt.Rows[0]["Codigo_Activo"].ToString();
                Txt_IDTipoActivo.Text = dt.Rows[0]["Pk_Id_TipoActivoFijo"].ToString();
                Txt_Marca.Text = dt.Rows[0]["Pk_Id_Identidad"].ToString(); // Asumiendo que se desea mostrar el ID de identidad aquí
                Txt_Modelo.Text = dt.Rows[0]["Modelo"].ToString();

                dtp_FechaAdquisicion.Value = Convert.ToDateTime(dt.Rows[0]["Fecha_Adquisicion"]);
                dtp_FechaAdquisicion.Enabled = false;

                Txt_CostoAdqui.Text = dt.Rows[0]["Costo_Adquisicion"].ToString();
                Txt_VidaUtil.Text = dt.Rows[0]["Vida_Util"].ToString();
                Txt_ValorResidual.Text = dt.Rows[0]["Valor_Residual"].ToString();
                Txt_Estado.Text = dt.Rows[0]["Estado"].ToString();
                Txt_Cuenta.Text = dt.Rows[0]["Pk_Id_Cuenta"].ToString();

                // Validar y calcular depreciación si es posible
                if (decimal.TryParse(Txt_CostoAdqui.Text, out _) &&
                    decimal.TryParse(Txt_VidaUtil.Text, out _) &&
                    decimal.TryParse(Txt_ValorResidual.Text, out _))
                {
                    CalcularDepreciacion();
                }

                // Configurar los campos de solo lectura, excepto para txtEstado
                Txt_IDActivoFijo.ReadOnly = true;
                Txt_CodigoActivo.ReadOnly = true;
                Txt_IDTipoActivo.ReadOnly = true;
                Txt_Marca.ReadOnly = true; // Si Marca no es parte de la nueva tabla, debes cambiarlo
                Txt_Modelo.ReadOnly = true;
                Txt_CostoAdqui.ReadOnly = true;
                Txt_VidaUtil.ReadOnly = true;
                Txt_ValorResidual.ReadOnly = true;
                Txt_Cuenta.ReadOnly = true;
                Txt_Estado.ReadOnly = false; // Si deseas permitir modificaciones en el estado
            

        // Rehabilitar el procesamiento de eventos
        isUpdatingFields = false;
            }
            else
            {
                MessageBox.Show("No se encontraron resultados.");
            }
        }
        private void CargarDescripcionActivos()
        {
            string tabla = "tbl_activofijo";
            string columna = "Descripcion";

            try
            {
                // Obtener solo registros con Estado = '1'
                DataTable dt = cn.ObtenerRegistrosConEstado(tabla, columna, "1");

                Cbo_descripcion.Items.Clear(); // Limpiar elementos anteriores

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Cbo_descripcion.Items.Add(row[columna].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron activos disponibles.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar descripciones: {ex.Message}");
            }
        }


        private void CalcularDepreciacion()
        {
            // Verificar que todos los campos estén llenos y convertir los valores
            if (decimal.TryParse(Txt_CostoAdqui.Text, out decimal costoAdquisicion) &&
                decimal.TryParse(Txt_VidaUtil.Text, out decimal vidaUtil) &&
                decimal.TryParse(Txt_ValorResidual.Text, out decimal valorResidual))
            {
                decimal depreciacionAnual = 0;

                // Verificar qué método de depreciación se ha seleccionado
                if (Chk_LineaRecta.Checked)
                {
                    // Calcular depreciación en línea recta
                    depreciacionAnual = (costoAdquisicion - valorResidual) / vidaUtil;
                }
                else if (Chk_DobleSaldoDeclinable.Checked)
                {
                    // Calcular depreciación usando el método de doble saldo declinable
                    decimal tasaDepreciacion = 2 / vidaUtil; // Tasa del 200%
                    depreciacionAnual = (costoAdquisicion - valorResidual) * tasaDepreciacion;
                    // Asegúrate de que la depreciación no exceda el valor residual
                    if (depreciacionAnual + valorResidual > costoAdquisicion)
                    {
                        depreciacionAnual = costoAdquisicion - valorResidual; // Limitación al valor residual
                    }
                }
                else if (Chk_SumaAnosDigitos.Checked)
                {
                    // Calcular depreciación usando el método de suma de años dígitos
                    int vidaUtilInt = (int)vidaUtil;
                    int sumaAnos = (vidaUtilInt * (vidaUtilInt + 1)) / 2; // Suma de años dígitos
                    int añoActual = 1; // Por ejemplo, para el primer año

                    // Depreciación del primer año
                    depreciacionAnual = (costoAdquisicion - valorResidual) * (vidaUtilInt - añoActual + 1) / sumaAnos;
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un método de depreciación.");
                    return; // Salir si no se seleccionó ningún método
                }

                // Mostrar el resultado en el TextBox de depreciación anual
                Txt_DepreAnual.Text = depreciacionAnual.ToString("F2");

                // Calcular y mostrar la depreciación fiscal
                CalcularDepreciacionFiscal(costoAdquisicion);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en todos los campos.");
            }
        }
        private void CalcularDepreciacionFiscal(decimal costoAdquisicion)
        {
            // Define la tasa de depreciación fiscal
            decimal tasaDepreciacionFiscal = 0.20m; // Por ejemplo, el 20%

            // Calcular la depreciación fiscal
            decimal depreciacionFiscal = costoAdquisicion * tasaDepreciacionFiscal;

            // Mostrar el resultado en el TextBox de depreciación fiscal
            Txt_DepreFiscal.Text = depreciacionFiscal.ToString("F2");
        }


        private void cb_descripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarDetalleActivoFijo();
        }

        private void chkLineaRecta_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_LineaRecta.Checked)
            {
                Chk_DobleSaldoDeclinable.Checked = false;
                Chk_SumaAnosDigitos.Checked = false;
            }
        }

        private void chkDobleSaldoDeclinable_CheckedChanged(object sender, EventArgs e)
        {

            if (Chk_DobleSaldoDeclinable.Checked)
            {
                Chk_LineaRecta.Checked = false;
                Chk_SumaAnosDigitos.Checked = false;
            }
        }

        private void chkSumaAnosDigitos_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_SumaAnosDigitos.Checked)
            {
                Chk_LineaRecta.Checked = false;
                Chk_DobleSaldoDeclinable.Checked = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            LimpiarControles(this);
        }
        private void LimpiarControles(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear(); // Limpia el texto del TextBox
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1; // Restablece la selección del ComboBox
                }
                // Si hay otros tipos de controles, puedes agregar más condiciones aquí

                // Si el control tiene hijos, llama recursivamente a LimpiarControles
                if (control.HasChildren)
                {
                    LimpiarControles(control);
                }
            }
        }

        public void GuardarDatos()
        {
            // Crear una instancia del controlador
            Controlador cn = new Controlador();

            // Capturar los valores de los controles de la interfaz de usuario
            int idActivoFijo = Convert.ToInt32(Txt_IDActivoFijo.Text);
            string nombreActivo = Txt_NombreTIPOActivo.Text;
            string tipoActivo = Txt_IDTipoActivo.Text;
            string encargado = Txt_Encargado.Text;
            string departamento = Txt_Departamento.Text;
            DateTime fechaDepreciacion = dtp_FechaDepreciacion.Value;
            double depreciacion = double.Parse(Txt_DepreAnual.Text);
            double depreciacionFiscal = double.Parse(Txt_DepreFiscal.Text);
            string descripcion = Txt_Descripcion.Text;
            int estado = int.Parse(Txt_Estado1.Text);
            int idCuenta = Convert.ToInt32(Txt_Cuenta.Text);
            int estado1 = int.Parse(Txt_Estado.Text);
            // Llamar al método del controlador para guardar los datos
            cn.InsertarDepreciacionActivo(fechaDepreciacion, idActivoFijo, nombreActivo, tipoActivo, encargado, departamento,
                                           depreciacion, depreciacionFiscal, descripcion, estado, idCuenta);
            cn.ActualizarEstadoActivoFijo(idActivoFijo, estado1);
            // Mostrar mensaje de éxito
            MessageBox.Show("Datos guardados exitosamente en la tabla de depreciación de activo fijo.");
        }
        private bool requiereMantenimiento = false;
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (requiereMantenimiento)
            {
                // Si el usuario ya indicó que el activo requiere mantenimiento, guardar ambos
                GuardarDatosMantenimiento();
                GuardarDatos();

                // Restablecer el estado después de guardar
                requiereMantenimiento = false;
            }
            else
            {
                // Mostrar mensaje de confirmación para preguntar si el activo requiere mantenimiento
                DialogResult resultado = MessageBox.Show("¿Este activo requiere mantenimiento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    // Si el usuario selecciona "No", solo guardar los datos del activo sin mantenimiento
                    GuardarDatos();
                }
                else if (resultado == DialogResult.Yes)
                {
                    // Si el usuario selecciona "Sí", establecer el estado para requerir mantenimiento
                    requiereMantenimiento = true;

                    // Aquí puedes mostrar un mensaje indicando que debe ingresar los datos de mantenimiento
                    MessageBox.Show("Por favor, ingrese los datos de mantenimiento y luego presione Guardar.");
                }
            }

        }

        private void Gpb_Activo_Enter(object sender, EventArgs e)
        {

        }
        public string FindFileInDirectory(string directory, string fileName)
        {
            try
            {
                // Verificamos si la carpeta existe
                if (Directory.Exists(directory))
                {
                    // Buscamos el archivo .chm en la carpeta
                    string[] files = Directory.GetFiles(directory, "*.chm", SearchOption.TopDirectoryOnly);

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
                MessageBox.Show("Error al buscar ayuda: " + ex.Message);
            }

            // Retorna null si no se encontró el archivo
            return null;
        }

        private void btn_Ayudas_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la ruta del directorio del ejecutable
                string executablePath = AppDomain.CurrentDomain.BaseDirectory;

                // Retroceder a la carpeta del proyecto
                string projectPath = Path.GetFullPath(Path.Combine(executablePath, @"..\..\"));
                //MessageBox.Show("1" + projectPath);

                // Combinar con la ruta fija de "asis22k24proy2\Codigo\Componentes\Seguridad"
                //string basePath = Path.Combine(projectPath, @"asis22k24proy2\Codigo\Componentes\Seguridad");
                //MessageBox.Show("2" + basePath);


                string ayudaFolderPath = Path.Combine(projectPath, "AyudaConta");

                // Imprimir la ruta de ayuda para verificar
                //MessageBox.Show("3: " + ayudaFolderPath);

                // Busca el archivo .chm en la carpeta "Ayuda_Seguridad"
                string pathAyuda = FindFileInDirectory(ayudaFolderPath, "AyudaConta.chm");

                // Verifica si el archivo existe antes de intentar abrirlo
                if (!string.IsNullOrEmpty(pathAyuda))
                {
                    //MessageBox.Show("El archivo sí está.");
                    // Abre el archivo de ayuda .chm en la sección especificada
                    Help.ShowHelp(null, pathAyuda, "AyudaConta.html");
                }
                else
                {
                    // Si el archivo no existe, muestra un mensaje de error
                    MessageBox.Show("El archivo de ayuda no se encontró.");
                }
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }
        }

        public void GuardarDatosMantenimiento()
        {
            // Crear una instancia del controlador
            Controlador cn = new Controlador();

            // Capturar los valores de los controles de la interfaz de usuario
            int idActivoFijo2 = Convert.ToInt32(Txt_IDActivoFijo.Text);
            string companiaAsegurada = Txt_CompaniaAsegurada.Text;
            string agenteSeguro = Txt_AgenteSeguro.Text;
            string telSiniestro = Txt_TelSiniestro.Text;
            string tipoCobertura = Txt_TipoCobertura.Text;
            double montoAsegurado = double.Parse(Txt_MontoAsegurado.Text);
            double primaTotal = double.Parse(Txt_PrimaTotal.Text);
            double deducible = double.Parse(Txt_Deducible.Text);
            DateTime vigencia = dtp_Vigencia.Value;
            DateTime fechaUtil = dtp_FechaUtil.Value;
            double costoServicio = double.Parse(Txt_CostoMantenimiento.Text); // Cambiado a costoServicio
            int periodoServicio = int.Parse(Txt_PeriodoMantenimiento.Text); // Cambiado a periodoServicio
            DateTime proxServicio = dtp_ProxMantenimiento.Value; // Cambiado a proxServicio
            int estado = int.Parse(Txt_estado3.Text);

            // Llamar al método del controlador para guardar los datos
            cn.InsertarMantenimiento(idActivoFijo2, companiaAsegurada, agenteSeguro, telSiniestro, tipoCobertura, montoAsegurado, primaTotal, deducible, vigencia, fechaUtil, costoServicio, periodoServicio, proxServicio, estado);
            MessageBox.Show("Datos guardados exitosamente en la tabla de depreciación de activo fijo.");
            // Mostrar mensaje de éxito

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Txt_TelSiniestro_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_DepreFiscal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

