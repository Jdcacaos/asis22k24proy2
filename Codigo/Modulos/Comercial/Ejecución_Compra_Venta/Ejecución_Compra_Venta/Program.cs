using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejecución_Compra_Venta
{
    static class Program
    {
        

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Define un valor para idUsuario
            string idUsuario = "1"; // Reemplaza esto con el valor adecuado

            // Pasar el idUsuario al constructor
            Application.Run(new Capa_Vista_CompraVenta.Frm_MDI_general_CompraVenta(idUsuario));
        }
    }
}
