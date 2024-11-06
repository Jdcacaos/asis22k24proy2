using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorActivofijo;
namespace CapaVistaActivofijo
{
    public partial class Frm_Activofijo : Form
    {
        Controlador cn = new Controlador();
        public Frm_Activofijo()
        {
            InitializeComponent();
            actualizarDataGridView();
            dgv_activofijo.CellDoubleClick += dataGridView1_CellDoubleClick;
            dgv_activofijo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        string emp = "tbl_activofijo";

        public void actualizarDataGridView()
        {
            // Llama al método llenarTablaActivoFijo y obtiene el DataTable
            DataTable dt = cn.llenarTablaActivoFijo(emp);

            // Asigna el DataTable como DataSource del DataGridView
            dgv_activofijo.DataSource = dt;
        }

        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Asegurarse de que se ha seleccionado una fila válida
            if (e.RowIndex < 0) return;

            // Obtener los datos de la fila seleccionada
            DataGridViewRow filaSeleccionada = dgv_activofijo.Rows[e.RowIndex];

            // Obtener el ID del activo fijo
            int idActivoFijo = Convert.ToInt32(filaSeleccionada.Cells["ID_Activo"].Value);

            // Crear una instancia de frmActivoFijo (o la forma que uses para los activos fijos)
            Frm_VistadeActivofijo formActivoFijo = new Frm_VistadeActivofijo();

            // Establecer la pestaña activa en el TabControl
            formActivoFijo.a.SelectedTab = formActivoFijo.tabPage1; // Cambia a tabPage1

            // Pasar los datos a los controles en frmActivoFijo
            formActivoFijo.Txt_CodigoActivo.Text = filaSeleccionada.Cells["Codigo_Activo"].Value.ToString();
            formActivoFijo.Txt_Descripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();
            formActivoFijo.Txt_Modelo.Text = filaSeleccionada.Cells["Modelo"].Value.ToString();
            formActivoFijo.dtp_FechaAdquisicion.Value = Convert.ToDateTime(filaSeleccionada.Cells["Fecha_de_Aquisicion"].Value);
            formActivoFijo.Txt_CostoAdquisicion.Text = filaSeleccionada.Cells["Costo_de_Aquisicion"].Value.ToString();
            formActivoFijo.Txt_VidaUtil.Text = filaSeleccionada.Cells["Vida_Util"].Value.ToString();
            formActivoFijo.Txt_ValorResidual.Text = filaSeleccionada.Cells["Valor_Residual"].Value.ToString();
            formActivoFijo.Txt_Estado.Text = filaSeleccionada.Cells["Estado"].Value.ToString();
            formActivoFijo.txtIDActivoFijo.Text = filaSeleccionada.Cells["ID_Activo"].Value.ToString();

            // Nuevos campos a manejar                              
            formActivoFijo.Txt_TipoActivo.Text = filaSeleccionada.Cells["ID_Tipo_Activo"].Value.ToString(); // Tipo de Activo
            formActivoFijo.Txt_Marca.Text = filaSeleccionada.Cells["ID_Marca"].Value.ToString(); // Marca
            formActivoFijo.Txt_Cuenta.Text = filaSeleccionada.Cells["ID_Cuenta"].Value.ToString(); // Cuenta

            // Inhabilitar los controles de frmActivoFijo
            DeshabilitarControles(formActivoFijo);

            // Cargar los datos de depreciación en un DataGridView en formActivoFijo
            formActivoFijo.CargarDatosDepreciacion(idActivoFijo);
            formActivoFijo.CargarDatosMantenimiento(idActivoFijo);
            formActivoFijo.StartPosition = FormStartPosition.CenterScreen;
           
            // Mostrar frmActivoFijo
            formActivoFijo.ShowDialog();
        }

        public void DeshabilitarControles(Frm_VistadeActivofijo formActivoFijo)
        {
            formActivoFijo.Txt_CodigoActivo.Enabled = false;
            formActivoFijo.Txt_Descripcion.Enabled = false;
            formActivoFijo.Txt_Modelo.Enabled = false;
            formActivoFijo.dtp_FechaAdquisicion.Enabled = false;
            formActivoFijo.Txt_CostoAdquisicion.Enabled = false;
            formActivoFijo.Txt_VidaUtil.Enabled = false;
            formActivoFijo.Txt_ValorResidual.Enabled = false;
            formActivoFijo.Txt_Estado.Enabled = false;
            formActivoFijo.txtIDActivoFijo.Enabled = false;
            formActivoFijo.Txt_TipoActivo.Enabled = false; // Deshabilitar Tipo de Activo
            formActivoFijo.Txt_Marca.Enabled = false; // Deshabilitar Marca
            formActivoFijo.Txt_Cuenta.Enabled = false; // Deshabilitar Cuenta
        }
        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            await Task.Delay(500); // Espera de 500 ms
            Frm_Depreciacion form2 = new Frm_Depreciacion(); // Cambiar a PRUEBA3
            form2.StartPosition = FormStartPosition.CenterScreen; // Centrar el formulario en la pantalla
            form2.Show(); // Mostrar el formulario
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
      

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            actualizarDataGridView();
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {

        }
        public FormReportes formReportes;
       
        public async void Btn_depreci_Click_1(object sender, EventArgs e)
        {

            await Task.Delay(500); // Espera de 500 ms
            formReportes = new FormReportes(); // Crear una instancia de FormReportes
            formReportes.StartPosition = FormStartPosition.CenterScreen; // Centrar el formulario en la pantalla
            formReportes.Show(); // Mostrar el formulario
            MessageBox.Show("Formulario abierto"); // Confirmar que se llegó a este punto
        }

        private void dgv_activofijo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
