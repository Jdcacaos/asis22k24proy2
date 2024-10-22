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
    public partial class Deuda_Clts : Form
    {
        Capa_Controlador_Cuentas_Corrientes.Controlador controlador = new Capa_Controlador_Cuentas_Corrientes.Controlador();
        public Deuda_Clts()
        {
            InitializeComponent();
            actualizarVistaDeudas();
            cargarClientes();
            cargarCobrador();
            cargarPagos();
            getIdD();
        }
        void getIdD()
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
            Cbo_id_clientes.DataSource = limpiarTexbox;
            List<string> clientesCodes = controlador.listadoClientesd();
            Cbo_id_clientes.DataSource = clientesCodes;
        }
        private void cargarCobrador()
        {
            List<string> limpiarTexbox = new List<string>();
            Cbo_id_cobrador.DataSource = limpiarTexbox;
            List<string> cobradorCodes = controlador.listadoCobradord();
            Cbo_id_cobrador.DataSource = cobradorCodes;
        }
        

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            controlador.guardarDeudas(Txt_id_deuda, Cbo_id_clientes.Text, Cbo_id_pago.Text, Cbo_id_cobrador.Text, 
                Txt_montoDeuda.Text, Dtp_FechaI.Text, Dtp_FechaV.Text, Txt_Descipcion.Text, Cbo_estado.Text);
            actualizarVistaDeudas();
            getIdD();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            DataTable data = controlador.queryDeuda(Txt_id_deuda);
            Dgv_deudas.DataSource = data;
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            actualizarVistaDeudas();
            getIdD();

            Btn_guardar.Enabled = true;
            Btn_editar.Enabled = false;
            Btn_eliminar.Enabled = false;
            Btn_Buscar.Enabled = true;
            Btn_Actualizar.Enabled = false;

            Txt_id_deuda.Text = "";
            Cbo_id_clientes.SelectedIndex = 0;
            Cbo_id_pago.SelectedIndex = 0;
            Cbo_id_cobrador.SelectedIndex = 0;
            Txt_montoDeuda.Text= "";
            Dtp_FechaI.Text = "";
            Dtp_FechaV.Text = "";
            Txt_Descipcion.Text = "";
            Cbo_estado.SelectedIndex = 0;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            controlador.borrarDeuda(Txt_id_deuda);
            actualizarVistaDeudas();
            getIdD();
        }

        private void Dgv_deudas_DoubleClick(object sender, EventArgs e)
        {
            if (Dgv_deudas.CurrentRow.Index != -1)
            {
                Btn_guardar.Enabled = false;
                Btn_editar.Enabled = true;
                Btn_eliminar.Enabled = true;
                Btn_Buscar.Enabled = true;
                Btn_Actualizar.Enabled = true;

                Txt_id_deuda.Text = Dgv_deudas.CurrentRow.Cells[0].Value.ToString();
                Cbo_id_clientes.Text = Dgv_deudas.CurrentRow.Cells[1].Value.ToString();
                Cbo_id_pago.Text = Dgv_deudas.CurrentRow.Cells[2].Value.ToString();
                Cbo_id_cobrador.Text = Dgv_deudas.CurrentRow.Cells[3].Value.ToString();
                Txt_montoDeuda.Text = Dgv_deudas.CurrentRow.Cells[4].Value.ToString();
                Dtp_FechaI.Text = Dgv_deudas.CurrentRow.Cells[5].Value.ToString();
                Dtp_FechaV.Text = Dgv_deudas.CurrentRow.Cells[6].Value.ToString();
                Txt_Descipcion.Text = Dgv_deudas.CurrentRow.Cells[7].Value.ToString();
                Cbo_estado.Text = Dgv_deudas.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {

        }
    }
}
