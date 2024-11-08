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
            Btn_agregar.Enabled = false;
            Btn_quitar.Enabled = false;
            Dgv_InfoExtra.Enabled = true;

        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            if (ComponentePrincipal == null)
            {
                MessageBox.Show("No se ha asignado el componente principal.");
                return;
            }

            // Pregunta inicial: si el usuario desea comenzar a agregar productos
            DialogResult inicio = MessageBox.Show(
                "¿Desea empezar a agregar productos?",
                "Agregar Producto",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (inicio == DialogResult.No)
            {
                // Si el usuario elige "No", no hace nada y termina el método.
                return;
            }

            // Si elige "Sí", activa los componentes para comenzar a agregar productos.
            ActivarComponentesExtras(true);

            // Validar que todos los campos están llenos
            if (!ValidarCamposLlenos())
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar el producto.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Recolecta y agrega los valores de los componentes extra a la DataGridView
            AgregarProducto();
        }
        private bool ValidarCamposLlenos()
        {
            foreach (Control control in ComponentePrincipal.Controls)
            {
                if (control.Name.StartsWith("extra_"))
                {
                    string nombreCampo = control.Name.Substring(6);

                    // Verifica si el campo existe en la grid actual y si corresponde a la tabla
                    if (DataGridViewInformacionExtra.Columns.Contains(nombreCampo))
                    {
                        // Verifica si el control está vacío según su tipo
                        if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            return false;
                        }
                        else if (control is ComboBox comboBox && comboBox.SelectedIndex == -1)
                        {
                            return false;
                        }
                        else if (control is DateTimePicker dateTimePicker && dateTimePicker.Value == DateTime.MinValue)
                        {
                            return false;
                        }
                        // Agrega aquí validaciones para otros tipos de control si es necesario
                    }
                }
            }
            return true;
        }

        private void AgregarProducto()
        {
            Dictionary<string, object> valoresComponentesExtras = new Dictionary<string, object>();

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
                        valoresComponentesExtras[nombreCampo] = (btn.Text == "Activado") ? "1" : "0";
                    }
                }
            }

            // Agrega la nueva fila a la DataGridView
            if (DataGridViewInformacionExtra != null)
            {
                DataGridViewInformacionExtra.Rows.Add(valoresComponentesExtras.Values.ToArray());
            }

            // Pregunta si desea agregar otro producto
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
            }
            else
            {
                // Desactiva los componentes de entrada
                ActivarComponentesExtras(false);

                // Rehabilita el botón de agregar y quitar
                Btn_agregar.Enabled = true;
                Btn_quitar.Enabled = true;
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
            if (ComponentePrincipal != null && DataGridViewInformacionExtra != null)
            {
                // Solo afecta los controles que coincidan con las columnas de la tabla actual en el DataGridView
                foreach (Control control in ComponentePrincipal.Controls)
                {
                    if (control.Name.StartsWith("extra_"))
                    {
                        string nombreCampo = control.Name.Substring(6); // Remover el prefijo "extra_"

                        // Verificar si el nombre del control coincide con una columna en el DataGridView
                        if (DataGridViewInformacionExtra.Columns.Contains(nombreCampo))
                        {
                            control.Enabled = activar;
                        }
                    }
                }
            }

            // Activa o desactiva los botones de "Agregar" y "Quitar"
            Btn_agregar.Enabled = activar;
            Btn_quitar.Enabled = activar;

            // Asegurarse de que el DataGridView esté siempre activo
            Dgv_InfoExtra.Enabled = true;
        }
        private void LimpiarComponentesExtras()
        {
            // Verifica que la grid tenga columnas y que la tabla esté configurada
            if (DataGridViewInformacionExtra.Columns.Count > 0 && !string.IsNullOrEmpty(TablaVarios))
            {
                // Recorre los controles en el UserControl principal
                foreach (Control control in ComponentePrincipal.Controls)
                {
                    if (control.Name.StartsWith("extra_"))
                    {
                        string nombreCampo = control.Name.Substring(6); // Eliminar el prefijo "extra_"

                        // Verifica si el campo existe en la grid actual y si corresponde a la tabla
                        if (DataGridViewInformacionExtra.Columns.Contains(nombreCampo))
                        {
                            // Limpia el control de acuerdo a su tipo
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
                            // Aquí puedes agregar otros tipos de control si los necesitas
                        }
                    }
                }
            }
        }
        private void Btn_quitar_Click(object sender, EventArgs e)
        {
            if (Dgv_InfoExtra.SelectedRows.Count > 0)
            {
                // Confirmación antes de eliminar
                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea eliminar el producto seleccionado?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    // Eliminar la fila seleccionada
                    Dgv_InfoExtra.Rows.RemoveAt(Dgv_InfoExtra.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }
  
        private void Btn_editar_Click(object sender, EventArgs e)
        {
                // Guardar los cambios en la fila seleccionada
                GuardarCambiosEnFilaSeleccionada();

        }
        private void GuardarCambiosEnFilaSeleccionada()
        {
            if (Dgv_InfoExtra.CurrentRow != null)
            {
                foreach (Control control in ComponentePrincipal.Controls)
                {
                    if (control.Name.StartsWith("extra_"))
                    {
                        string nombreCampo = control.Name.Substring(6);

                        if (DataGridViewInformacionExtra.Columns.Contains(nombreCampo))
                        {
                            if (control is TextBox textBox)
                            {
                                Dgv_InfoExtra.CurrentRow.Cells[nombreCampo].Value = textBox.Text;
                            }
                            else if (control is ComboBox comboBox)
                            {
                                Dgv_InfoExtra.CurrentRow.Cells[nombreCampo].Value = comboBox.SelectedItem;
                            }
                            else if (control is DateTimePicker dateTimePicker)
                            {
                                Dgv_InfoExtra.CurrentRow.Cells[nombreCampo].Value = dateTimePicker.Value;
                            }
                            else if (control is Button button)
                            {
                                Dgv_InfoExtra.CurrentRow.Cells[nombreCampo].Value = (button.Text == "Activado") ? "1" : "0";
                            }
                        }
                    }
                }

                MessageBox.Show("Los cambios han sido guardados en la fila seleccionada.");
            }
        }

        private void Dgv_InfoExtra_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Asegura que no sea un encabezado o una fila sin datos
            {
                // Recorre cada control en el formulario que coincide con las columnas del DataGridView
                foreach (Control control in ComponentePrincipal.Controls)
                {
                    if (control.Name.StartsWith("extra_"))
                    {
                        string nombreCampo = control.Name.Substring(6); // Elimina el prefijo "extra_"

                        if (DataGridViewInformacionExtra.Columns.Contains(nombreCampo))
                        {
                            object valorCelda = DataGridViewInformacionExtra.Rows[e.RowIndex].Cells[nombreCampo].Value;

                            if (control is TextBox textBox)
                            {
                                textBox.Text = valorCelda?.ToString();
                            }
                            else if (control is ComboBox comboBox)
                            {
                                comboBox.Text = valorCelda?.ToString();
                            }
                            else if (control is DateTimePicker dateTimePicker && valorCelda is DateTime)
                            {
                                dateTimePicker.Value = (DateTime)valorCelda;
                            }
                            else if (control is Button button)
                            {
                                button.Text = (valorCelda?.ToString() == "1") ? "Activado" : "Desactivado";
                                button.BackColor = (valorCelda?.ToString() == "1") ? Color.Green : Color.Red;
                            }
                        }
                    }
                }
            }
        }

        private void Dgv_InfoExtra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IngresarVarios_Load(object sender, EventArgs e)
        {
            Dgv_InfoExtra.CellClick += Dgv_InfoExtra_CellClick;
            Dgv_InfoExtra.Enabled = true;
        }
    }
}
