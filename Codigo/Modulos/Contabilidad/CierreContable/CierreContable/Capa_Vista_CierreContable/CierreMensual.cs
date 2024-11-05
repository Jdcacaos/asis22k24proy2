using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_CierreContable;
using System.IO;
using Capa_Controlador_Seguridad;

namespace Capa_Vista_CierreContable
{
    public partial class CierreMensual : Form
    {
        public string idUsuario { get; set; }
        logica LogicaSeg = new logica();
        public string sRutaProyectoAyuda { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));

        Controlador cn = new Controlador();
        public CierreMensual()
        {
            InitializeComponent();
        }

        private void ConsultasCierre_Load(object sender, EventArgs e)
        {
            LlenarCuentas();
            
            LlenarCboAnio();
            LlenarCboMes();
            // Configuración del ToolTip
            ToolTip toolTip = new ToolTip
            {
                IsBalloon = true // Hacer que el tooltip tenga forma de globo
            };
            toolTip.SetToolTip(btn_GuardarCierre, "Guarda el cierre contable, no se podrá modificar nada luego de esto.");
            toolTip.SetToolTip(btn_cancelar, "Cancela el guardado del cierre actual");
            toolTip.SetToolTip(btn_nuevocierre, "Genera el cierre del mes actual");
            toolTip.SetToolTip(btn_Actualizar, "Limpia los DataGridView y los Textbox de las sumas.");
            toolTip.SetToolTip(btn_Ayuda2, "Muestra la Ayuda del formulario actual.");
            toolTip.SetToolTip(btn_Reporte, "Muestra el Reporte del los datos del Mes Actual.");
        }

        public void LlenarCboAnio()
        {
            // Obtener el año actual
            int anioActual = DateTime.Now.Year;

            // Limpiar el ComboBox
            cbo_año.Items.Clear();

            // Agregar el año actual al ComboBox
            cbo_año.Items.Add(anioActual.ToString());

            // Seleccionar el año actual como predeterminado
            cbo_año.SelectedIndex = 0;
        }


        public void LlenarCuentas()
        {
            DataTable cuentas = cn.ObtenerCuentas();

            // Limpiar y agregar "Todas las cuentas" al ComboBox
            cbo_cuenta.Items.Clear();
            cbo_cuenta.Items.Add("Todas las cuentas");

            foreach (DataRow row in cuentas.Rows)
            {
                cbo_cuenta.Items.Add(row["nombre_cuenta"]); // Ajustar según el nombre de la columna en tu DataTable
            }

            cbo_cuenta.SelectedIndex = 0; // Seleccionar "Todas las cuentas" como predeterminada
        }




        public void LlenarCboMes()
        {
            // Verificar si hay un año seleccionado
            if (int.TryParse(cbo_año.Text, out int anio))
            {
                // Obtener todas las cuentas
                DataTable cuentas = cn.ObtenerCuentas();
                HashSet<int> idsCuentas = new HashSet<int>();

                // Agregar los IDs de las cuentas a un HashSet para fácil verificación
                foreach (DataRow row in cuentas.Rows)
                {
                    idsCuentas.Add(Convert.ToInt32(row["Pk_id_cuenta"])); // Asegúrate de que el nombre de la columna sea correcto
                }

                // Obtener el último mes con datos
                int ultimoMesConDatos = cn.ObtenerUltimoMesConDatos(anio);

                // Limpiar el ComboBox
                cbo_mes.Items.Clear();

                // Llamar al método del controlador para obtener los meses válidos
                DataTable mesesValidos = cn.ObtenerMesesSinDatos(ultimoMesConDatos, idsCuentas);

                // Llenar el ComboBox con los meses obtenidos
                foreach (DataRow row in mesesValidos.Rows)
                {
                    cbo_mes.Items.Add(row["Mes"]);
                }

                // Si no hay meses disponibles, puedes mostrar un mensaje
                if (cbo_mes.Items.Count == 0)
                {
                    MessageBox.Show("No hay meses disponibles para seleccionar.");
                }
            }
        }




        private void LlenarCierre(string cuentaSeleccionada)
        {
            DataTable datosCierre;

            // Verificar si se seleccionó "Todas las cuentas"
            if (cuentaSeleccionada == "Todas las cuentas")
            {
                datosCierre = cn.ObtenerDatosCierre(null); // Pasar null o un valor que indique que se deben obtener todas las cuentas
            }
            else
            {
                datosCierre = cn.ObtenerDatosCierre(cuentaSeleccionada);
            }

            // Verificar si se obtuvieron datos
            if (datosCierre != null && datosCierre.Rows.Count > 0)
            {
                dgv_cierre.DataSource = datosCierre; // Asignar el DataTable al DataGridView
            }
            else
            {
                MessageBox.Show("No se encontraron datos para la cuenta seleccionada.");
                dgv_cierre.DataSource = null; // Limpiar el DataGridView si no hay datos
            }
        }




        private void btn_nuevocierre_Click(object sender, EventArgs e)
        {
            string mes = cbo_mes.Text; // Obtener el mes desde el ComboBox
            string anio = cbo_año.Text; // Año de interés
            string cuentaSeleccionada = cbo_cuenta.Text;
            int periodo = 0;
            int aniov = 0;

            // Intenta convertir el texto a un entero
            if (!int.TryParse(anio, out aniov))
            {
                // La conversión falló, maneja el error aquí
                MessageBox.Show("Error: el año seleccionado no es válido.");
                return; // Salir del método si el año no es válido
            }

            // Verificar si se seleccionó un mes
            if (string.IsNullOrEmpty(mes))
            {
                string mensaje = "Error, debe seleccionar un mes para poder realizar la consulta. Intente de nuevo";
                MessageBox.Show(mensaje);
                return; // Salir del método si el mes no es válido
            }

            // Mapear el mes a su correspondiente periodo
            periodo = cn.ObtenerPeriodoPorMes(mes);

            LlenarCierre(cuentaSeleccionada);

            MessageBox.Show($"Mes: {mes}, Año: {aniov}.");

            // cn.ConsultarCierreG(cuentaSeleccionada, txt_cargomes, txt_abonomes, txt_saldoantmes, txt_saldoactmes);
            if (cuentaSeleccionada == "Todas las cuentas")
            {
                // Llama a la consulta sin aplicar filtro de cuenta
                cn.ConsultarCierreG(null, txt_cargomes, txt_abonomes, txt_saldoantmes, txt_saldoactmes);
            }
            else
            {
                // Llama a la consulta con el filtro de cuenta
                cn.ConsultarCierreG(cuentaSeleccionada, txt_cargomes, txt_abonomes, txt_saldoantmes, txt_saldoactmes);
            }

            // Aquí puedes continuar con cualquier lógica que necesites, 
            // como habilitar otros controles o realizar otras acciones.

            btn_nuevocierre.Enabled = false;
            btn_cancelar.Enabled = true;
            btn_GuardarCierre.Enabled = true;
            LogicaSeg.funinsertarabitacora(idUsuario, $"Se consultó las polizas del mes actual", "Cierre Mensual", "8000");

        }

        // Evento de clic para btn_cancelar
        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            // Limpiar el DataGridView
            dgv_cierre.DataSource = null; // O puedes usar dgv_cierre.Rows.Clear(); para eliminar filas
            dgv_cierre.Columns.Clear(); // Opcional: si deseas eliminar también las columnas

            // Activa el botón Nuevocierre y desactiva el botón Cancelar
            btn_nuevocierre.Enabled = true;
            btn_cancelar.Enabled = false;
            btn_GuardarCierre.Enabled = false;
            LogicaSeg.funinsertarabitacora(idUsuario, $"Se canceló la operación de cierre", "Cierre Mensual", "8000");

        }

        // Método para incrementar el año si el año actual tiene cierres completos
        private void IncrementarAnioSiEsNecesario(int anio)
        {
            // Verificar si el año tiene cierres completos
            if (cn.VerificarCierresCompletos(anio))
            {
                // Incrementar el año y  en el ComboBox
                int nuevoAnio = anio + 1;
                cbo_año.Items.Clear();
                cbo_año.Items.Add(nuevoAnio.ToString());
                cbo_año.SelectedIndex = 0;

                MessageBox.Show("Se ha completado el año. Ahora se procederá al año " + nuevoAnio);

                // Actualizar el año en tbl_historico_cuentas
                cn.ActualizarAnioHistorico(anio, nuevoAnio);
            }
        }


        private void btn_GuardarCierre_Click(object sender, EventArgs e)
        {
            // Obtener el año del ComboBox
            int anio = int.Parse(cbo_año.Text);

            // Verificar si hay un mes seleccionado
            if (cbo_mes.Items.Count > 0 && cbo_mes.SelectedIndex != -1)
            {
                // Obtener el mes como texto y convertir a mayúsculas para otros usos
                string mes = cbo_mes.Text.ToUpper();

                // Obtener el índice seleccionado y calcular el mes
                int mesi = cbo_mes.SelectedIndex + 1; // El índice se traduce correctamente al mes

                int periodo = cn.ObtenerPeriodoPorMes(mes); // Obtener periodo a partir del mes en mayúsculas

                // Confirmar la operación
                var confirmacion = MessageBox.Show("¿Estás seguro de realizar esta operación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    if (periodo == 0)
                    {
                        MessageBox.Show("Error: el mes seleccionado no es válido.");
                        return; // Salir si el mes no es válido
                    }

                    // Lógica para guardar los datos usando el periodo y año
                    cn.GenerarNuevoCierre(periodo, anio); // Usar el periodo obtenido

                    // Verifica y actualiza el año completo
                    cn.VerificarYActualizarAnoCompleto(anio);

                    // Llama a IncrementarAnioSiEsNecesario para incrementar el año si es necesario
                    IncrementarAnioSiEsNecesario(anio);

                    // Limpiar el DataGridView y restaurar botones a su estado inicial
                    dgv_cierre.DataSource = null;  // Desvincular el DataGridView de su fuente de datos
                    dgv_cierre.Rows.Clear();       // Limpiar las filas

                    btn_nuevocierre.Enabled = true;
                    btn_GuardarCierre.Enabled = false;
                    LlenarCboMes();

                    // Actualizar ComboBox de meses
                    cn.ActualizarComboBoxMeses();
                    txt_cargomes.Clear();
                    txt_abonomes.Clear();
                    txt_saldoactmes.Clear();
                    txt_saldoantmes.Clear();
                    btn_cancelar.Enabled = false;
                }
                else
                {
                    ReiniciarFormulario();
                }
            }
            else
            {
                MessageBox.Show("No se puede ingresar datos. No hay meses disponibles.");
            }
            LogicaSeg.funinsertarabitacora(idUsuario, $"Se guardó un nuevo Cierre Mensual", "Cierre Mensual", "8000");

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
            LogicaSeg.funinsertarabitacora(idUsuario, $"Se actualizó el Formulario", "Cierre Mensual", "8000");

        }

        private void ReiniciarFormulario()
        {
            // Limpiar los TextBoxes
            txt_abonomes.Text = string.Empty;
            txt_cargomes.Text = string.Empty;
            txt_saldoactmes.Text = string.Empty;
            txt_saldoantmes.Text = string.Empty;


            // Limpiar los DataGridViews
            dgv_cierre.DataSource = null; // Limpiar el DataSource

            // Volver a llenar el ComboBox de años
            LlenarCboAnio();

            // También puedes reiniciar otras variables o controles según lo necesites
            // Por ejemplo, restablecer estados de otros controles o variables
        }

        private void btn_Ayuda2_Click(object sender, EventArgs e)
        {
            try
            {
                //Ruta para que se ejecute desde la ejecucion de Interfac3
                string sAyudaPath = Path.Combine(sRutaProyectoAyuda, "Ayuda", "Modulos", "Contabilidad", "AyudaCierreContable", "AyudaCierreI.chm");
                //string sIndiceAyuda = Path.Combine(sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "Htmlayuda.hmtl");
                //MessageBox.Show("Ruta del reporte: " + sAyudaPath, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Help.ShowHelp(this, sAyudaPath, "AyudaCierre2.html");

                //Bitacora--------------!!!
                LogicaSeg.funinsertarabitacora(idUsuario, $"Se presiono Ayuda", "Cierre Mensual", "8000");
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reporte_Click_1(object sender, EventArgs e)
        {
            ReporteMes frm = new ReporteMes();
            frm.Show();
        }
    }
}
