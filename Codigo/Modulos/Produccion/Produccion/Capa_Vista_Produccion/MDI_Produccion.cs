using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Produccion
{
    public partial class MDI_Produccion : Form
    {
        // Variables para capturar la posición y el tamaño del formulario antes de maximizar
        int lx, ly;
        int sw, sh;

        public MDI_Produccion(string idUsuario)
        {
            InitializeComponent();
            ocultaSubMenu(); // Solo oculta los menús al inicio
        }

        // Ocultar submenús al iniciar (sin cerrar al abrir otro)
        private void ocultaSubMenu()
        {
            panelMenuProcesos.Visible = false;
            panelMenuMantenimiento.Visible = false;
        }

        // Mostrar u ocultar submenús (ahora se permite que los dos estén abiertos al mismo tiempo)
        private void muestraSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true; // Solo muestra el panel si está oculto
            }
            else
            {
                subMenu.Visible = false; // Oculta el panel si ya está visible
            }
        }

        // Función para cerrar el formulario
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Funcionalidades de botones de procesos
        // Botón de mantenimiento
        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            Frm_Mantenimiento_Produccion produccion = new Frm_Mantenimiento_Produccion();
            produccion.Show();
        }

        // Botón de órdenes de producción
        private void btnOrdenesProduccion_Click(object sender, EventArgs e)
        {
            Frm_Ordenes_De_Produccion OP = new Frm_Ordenes_De_Produccion();
            OP.Show();
        }

        // Botón de maquinaria
        private void btnMaquinaria_Click_1(object sender, EventArgs e)
        {
            Frm_Maquinaria maquinaria = new Frm_Maquinaria();
            maquinaria.Show();
        }

        // Botón de empleados (enlace a RRHH)
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Frm_Enlace_RRHH RRHH = new Frm_Enlace_RRHH();
            RRHH.Show();
        }

        // Botón de cierre
        private void btnCierre_Click(object sender, EventArgs e)
        {
            Frm_Cierre Cierre = new Frm_Cierre();
            Cierre.Show();
        }

        // Botón de implosión/explosión de materiales
        private void btnImplosionExplosion_Click(object sender, EventArgs e)
        {
            Frm_Implosion_Explosion_Materiales IEM = new Frm_Implosion_Explosion_Materiales();
            IEM.Show();
        }

        // Botón de sistema de producción
        private void btnProduccion_Click(object sender, EventArgs e)
        {
            Frm_Sistema_Produccion SP = new Frm_Sistema_Produccion();
            SP.Show();
        }

        // Botón de enlace a contabilidad y cierre (Pólizas)
        private void btnPolizas_Click(object sender, EventArgs e)
        {
            Frm_Enlace_Contabilidad_Cierre Polizas = new Frm_Enlace_Contabilidad_Cierre();
            Polizas.Show();
        }

        // Botón de conversiones
        private void btnConversiones_Click_1(object sender, EventArgs e)
        {
            Frm_Conversiones Conv = new Frm_Conversiones();
            Conv.Show();
        }

        // Botón de series
        private void btnSeries_Click_1(object sender, EventArgs e)
        {
            Frm_Series Series = new Frm_Series();
            Series.Show();
        }

        // Botón de lotes
        private void btnLotes_Click_1(object sender, EventArgs e)
        {
            Frm_Lotes Lotes = new Frm_Lotes();
            Lotes.Show();
        }
        #endregion

        // Mostrar el submenú de procesos
        private void btnMenuProcesos_Click(object sender, EventArgs e)
        {
            muestraSubMenu(panelMenuProcesos);
        }

        // Mostrar el submenú de mantenimiento
        private void btnMenuMantenimiento_Click_1(object sender, EventArgs e)
        {
            muestraSubMenu(panelMenuMantenimiento);
        }

        // Minimizar el formulario
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Maximizar el formulario
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            // Capturar la posición y el tamaño antes de maximizar
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;

            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void Btn_Recetas_Click_1(object sender, EventArgs e)
        {
            Frm_Receta receta = new Frm_Receta();
            receta.Show();
        }


        // Restaurar el tamaño original de la ventana
        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        // Función para salir del formulario
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
