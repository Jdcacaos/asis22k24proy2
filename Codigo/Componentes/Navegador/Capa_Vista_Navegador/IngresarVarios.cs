using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Navegador
{
    public partial class IngresarVarios : UserControl
    {
        public Navegador ComponentePrincipal { get; set; }
        public IngresarVarios()
        {
            InitializeComponent();
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> valoresComponentesExtras = new Dictionary<string, object>();

            if (ComponentePrincipal != null)
            {
                // Recorre los controles del UserControl principal
                foreach (Control control in ComponentePrincipal.Controls)
                {
                    if (control.Name.StartsWith("extra_"))
                    {
                        string nombreCampo = control.Name.Substring(6);

                        if (control is TextBox textBox)
                        {
                            valoresComponentesExtras[nombreCampo] = textBox.Text;
                        }
                        else if (control is ComboBox comboBox)
                        {
                            valoresComponentesExtras[nombreCampo] = comboBox.SelectedValue ?? comboBox.Text;
                        }
                        else if (control is DateTimePicker dateTimePicker)
                        {
                            valoresComponentesExtras[nombreCampo] = dateTimePicker.Value;
                        }
                        else if (control is Button btn)
                        {
                            valoresComponentesExtras[nombreCampo] = (btn.Text == "Activado") ? "1" : "0"; // Retorna "1" si el botón está activado, "0" si está desactivado
                        }
                    }
                }

                // Agrega la nueva fila a la DataGridView
                if (DataGridViewInformacionExtra != null)
                {
                    DataGridViewInformacionExtra.Rows.Add(valoresComponentesExtras.Values.ToArray());
                }

                // Pregunta al usuario si desea agregar otro producto
                DialogResult resultado = MessageBox.Show(
                    "¿Desea agregar otro producto?",
                    "Agregar Producto",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    // Limpia los componentes para permitir el ingreso de un nuevo producto
                    LimpiarComponentesExtras();
                    ActivarComponentesExtras(true); // Asegura que los componentes están activos
                }
                else
                {
                    // Desactiva los botones de agregar y los componentes de entrada
                    ActivarComponentesExtras(false);
                    Btn_agregar.Enabled = false;
                    Btn_quitar.Enabled = false; // Si tienes un botón de quitar, también se desactiva
                }
            }
            else
            {
                MessageBox.Show("No se ha asignado el componente principal.");
            }
        }
        public string TablaVarios { get; private set; }
        public void ConfigurarDataGridViewParaTablaVarios(string nombreTabla)
        {
            // Asigna el nombre de la tabla específica a la variable TablaVarios
            TablaVarios = nombreTabla;

            if (DataGridViewInformacionExtra == null)
            {
                Console.WriteLine("Error: DataGridViewInformacionExtra no está inicializado.");
                return;
            }

            Console.WriteLine("Configurando DataGridView para la tabla: " + nombreTabla);

            // Opcional: Inicializa DataGridView si es necesario para esta tabla
            DataGridViewInformacionExtra.DataSource = null; // Limpiar si ya tenía datos
        }

        public DataGridView DataGridViewInformacionExtra
        {
            get { return Dgv_InfoExtra; }
        }
        public void ObtenerValoresDeComponentesExtras()
        {
            // Asegurarse de que ComponentePrincipal no sea null
            if (ComponentePrincipal != null)
            {
                // Diccionario para almacenar los valores de los componentes extra
                Dictionary<string, object> valoresComponentesExtras = new Dictionary<string, object>();

                // Recorremos los controles en el UserControl principal
                foreach (Control control in ComponentePrincipal.Controls)
                {
                    if (control.Name.StartsWith("extra_"))
                    {
                        string nombreCampo = control.Name.Substring(6); // Quitar el prefijo "extra_"

                        // Obtener el valor dependiendo del tipo de control
                        if (control is TextBox textBox)
                        {
                            valoresComponentesExtras[nombreCampo] = textBox.Text;
                        }
                        else if (control is ComboBox comboBox)
                        {
                            valoresComponentesExtras[nombreCampo] = comboBox.SelectedItem;
                        }
                        else if (control is DateTimePicker dateTimePicker)
                        {
                            valoresComponentesExtras[nombreCampo] = dateTimePicker.Value;
                        }
                        else if (control is Button btn)
                        {
                            valoresComponentesExtras[nombreCampo] = (btn.Text == "Activado") ? "1" : "0"; // Retorna "1" si el botón está activado, "0" si está desactivado
                        }
                    }
                }

                // Aquí puedes usar 'valoresComponentesExtras' como necesites (por ejemplo, mostrar en una DataGridView)
            }
            else
            {
                MessageBox.Show("No se ha asignado el componente principal.");
            }
        }
        private void ActivarComponentesExtras(bool activar)
        {
            if (ComponentePrincipal != null)
            {
                foreach (Control control in ComponentePrincipal.Controls)
                {
                    if (control.Name.StartsWith("extra_"))
                    {
                        control.Enabled = activar;
                    }
                }
            }

            // Activa o desactiva los botones de "Agregar" y "Quitar"
            Btn_agregar.Enabled = activar;
            Btn_quitar.Enabled = activar; // Asegúrate de tener este botón definido si es necesario
            Dgv_InfoExtra.Enabled = activar;
        }

        private void LimpiarComponentesExtras()
        {
            foreach (Control control in ComponentePrincipal.Controls)
            {
                if (control.Name.StartsWith("extra_"))
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Clear();
                    }
                    else if (control is ComboBox comboBox)
                    {
                        comboBox.SelectedIndex = -1;
                    }
                    else if (control is DateTimePicker dateTimePicker)
                    {
                        dateTimePicker.Value = DateTime.Now;
                    }
                }
            }
        }

        private void Btn_quitar_Click(object sender, EventArgs e)
        {
            if (Dgv_InfoExtra.SelectedRows.Count > 0)
            {
                // Eliminar la fila seleccionada
                Dgv_InfoExtra.Rows.RemoveAt(Dgv_InfoExtra.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }
    }
}
