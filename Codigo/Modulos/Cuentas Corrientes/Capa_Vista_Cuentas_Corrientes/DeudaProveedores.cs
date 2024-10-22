using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Cuentas_Corrientes
{
    public partial class DeudaProveedores : Form
    {
        public DeudaProveedores()
        {
            //InitializeComponent();
            //actualizarVistaDeudas();
            //cargarClientes();
            //cargarPagos();
            //getIdD();
        }
        /*void getIdD()
        {
            Txt_id_deuda.Text = controlador.getNextIdD();
        }
        private void actualizarVistaDeudas()
        {
            DataTable data = controlador.MostrarDeudas();
            Dgv_deudas.DataSource = data;
            Dgv_deudas.Columns[0].HeaderText = "Pk_id_deuda";
            Dgv_deudas.Columns[1].HeaderText = "Pk_id_clientes";
            Dgv_deudas.Columns[2].HeaderText = "Fk_id_cobrador";
            Dgv_deudas.Columns[3].HeaderText = "Fk_id_pago";
            Dgv_deudas.Columns[4].HeaderText = "monto_deuda";
            Dgv_deudas.Columns[5].HeaderText = "fecha_inicio_deuda";
            Dgv_deudas.Columns[6].HeaderText = "fecha_vencimiento_deuda";
            Dgv_deudas.Columns[7].HeaderText = "descriptcion_deuda";
            Dgv_deudas.Columns[8].HeaderText = "estado_deuda";
        }
        private void cargarPagos()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_id_pago.DataSource = limpiarTexbox;
            List<string> pagosCodes = controlador.listadoPagosd();
            Cbo_id_pago.DataSource = pagosCodes;
        }

        private void cargarClientes()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_id_proveedor.DataSource = limpiarTexbox;
            List<string> clientesCodes = controlador.listadoClientesd();
            Cbo_id_proveedor.DataSource = clientesCodes;
        }*/

        private void Btn_guardar_Click(object sender, EventArgs e)
        {

        }
    }
}
