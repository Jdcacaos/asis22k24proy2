using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Logistica;


namespace Capa_Vista_Logistica
{
    public partial class Almacenes : Form
    {
        public Almacenes()
        {
            InitializeComponent();
            string idUsuario = "9003";
            string[] alias = { "ID Bodega", "Nombre Bodega", "Ubicación", "Capacidad", "Fecha Registro", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.CadetBlue);
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.AsignarTabla("TBL_BODEGAS");
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarAyuda("1");
            navegador1.AsignarNombreForm("ALMACEN");
        }

        
        }
    }

