using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Contabilidad
{
    public partial class Mantenimientoactivofijo : Form
    {
        public Mantenimientoactivofijo()
        {
            InitializeComponent();

            string idusuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            string[] alias = {"pkid", "CódigoActi", "Tipo Activo", "Descripción", "Marca", "Modelo", "FechaAdqui", "CostoAdqui", "Vida Útil", "ValorResidual", "Estado", "pkcuenta"};
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.LightBlue);
            navegador1.AsignarColorFuente(Color.BlueViolet);
            navegador1.ObtenerIdAplicacion("8000"); // Ajusta el ID de la aplicación
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario(idusuario);
            navegador1.AsignarTabla("tbl_activofijo");
            navegador1.AsignarNombreForm("Activos Fijos");


         



        }

    }
}
