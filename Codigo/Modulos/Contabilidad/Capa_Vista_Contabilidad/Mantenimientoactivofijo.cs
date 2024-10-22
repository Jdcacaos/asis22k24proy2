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
            navegador1.ObtenerIdAplicacion("1000"); // Ajusta el ID de la aplicación
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario(idusuario);
            navegador1.AsignarTabla("tbl_activofijo");
            navegador1.AsignarNombreForm("Activos Fijos");

            // Asignar combos para las relaciones foráneas (tipo activo, marca y cuenta contable)
            navegador1.AsignarComboConTabla("tbl_tipoactivo", "Pk_id_tipoactivo", "nombre_tipoactivo", 1);
            navegador1.AsignarComboConTabla("tbl_marca", "Pk_id_marca", "nombre_marca", 1);
            navegador1.AsignarComboConTabla("tbl_cuentas", "Pk_id_cuenta", "nombre_cuenta", 1); // Agregamos el combo de cuentas contables

            // Asignar las relaciones foráneas para tipo de activo, marca y cuenta contable
            navegador1.AsignarForaneas("tbl_tipoactivo", "nombre_tipoactivo", "Pk_id_tipoactivo", "Pk_id_tipoactivo");
            navegador1.AsignarForaneas("tbl_marca", "nombre_marca", "Pk_id_marca", "Pk_id_marca");
            navegador1.AsignarForaneas("tbl_cuentas", "nombre_cuenta", "Pk_id_cuenta", "Pk_id_cuenta"); // Relación foránea con cuentas contables



        }

    }
}
