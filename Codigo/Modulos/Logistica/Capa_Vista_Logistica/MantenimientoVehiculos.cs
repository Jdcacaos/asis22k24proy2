using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Logistica
{
    public partial class MantenimientoVehiculos : Form
    {
        Capa_Controlador_Logistica.Controlador capa_Controlador_Logistica = new Capa_Controlador_Logistica.Controlador();
        private string Pk_id_Mantenimiento;

        public MantenimientoVehiculos()
        {
            InitializeComponent();
            CargarInformacionMantenimiento(Pk_id_Mantenimiento);
        }
        private void CargarInformacionMantenimiento(string Pk_id_Mantenimiento)
        {
            MessageBox.Show("ID de mantenimiento seleccionado: " + Pk_id_Mantenimiento);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                capa_Controlador_Logistica.RealizarSolicitudMantenimiento(Convert.ToInt32(txtID_mantenimiento.Text), txt_NombreSolicitante.Text, cmb_TipoMantenimiento.Text, cmb_ComponenteAfectado.Text, Fecha_mantenimiento.Text, txt_responsableAsignado.Text, txt_CodigoError.Text, cmb_ComponenteAfectado.Text, cmb_ComponenteAfectado.Text, Convert.ToInt32(txt_fk_id_movimiento.Text));
                MessageBox.Show("Se realizo el registro correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error"+ ex);
            }
        }
    }
}
