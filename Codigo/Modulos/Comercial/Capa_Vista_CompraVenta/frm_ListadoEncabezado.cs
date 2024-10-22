using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_CompraVenta
{
    public partial class frm_ListadoEncabezado : Form
    {
        public frm_ListadoEncabezado()
        {
            InitializeComponent();

            // Deshabilitar los TextBox
            Txt_codigo.Enabled = false;
            Txt_fecha.Enabled = false;

            // Establecer la fecha en el TextBox al mostrar el formulario
            this.Shown += new EventHandler(Txt_fecha_TextChanged);

            Dgv_listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ToolTip tnuevo = new ToolTip();
            tnuevo.SetToolTip(Btn_agregar, "Nueva Lista de Precios");
            ToolTip teliminar = new ToolTip();
            teliminar.SetToolTip(Btn_guardar, "Eliminar Lista");
            ToolTip tbuscar = new ToolTip();
            tbuscar.SetToolTip(Btn_eliminar, "Buscar Lista");
            ToolTip teditar = new ToolTip();
            teditar.SetToolTip(Btn_editar, "Agregar Productos a la lista");
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            frm_ListadoDetalle nuevoForm = new frm_ListadoDetalle(); // Instancia del nuevo formulario
            nuevoForm.Show(); // Muestra el formulario
        }

        private void Txt_fecha_TextChanged(object sender, EventArgs e)
        {
            Txt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
