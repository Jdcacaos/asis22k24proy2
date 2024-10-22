using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Nominas
{
    public partial class frm_procesos_percepciones : Form
    {
        //Metodos para que se abra solamente una ventana y no multiples
        private static frm_procesos_percepciones instancia = null;
        public static frm_procesos_percepciones ventana_unica()
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new frm_procesos_percepciones();
            }
            return instancia;
        }
        public frm_procesos_percepciones()
        {
            InitializeComponent();
            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();
            /*********Prueba con la tabla inicial*********/
            string[] alias = { "pk_dedu_perp", "concepto", " porcentaje", "monto", "cantidad", "estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("tbl_dedu_perp");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("Deducciones/Percepciones");
            /**********************************************/
        }
    }
}
