using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Navegador;
using Capa_Controlador_Reporteria;
using Capa_Vista_Reporteria;
using Capa_Vista_Consulta;
using Capa_Controlador_Seguridad;
using System.IO;

namespace Capa_Vista_Navegador
{
    public partial class Navegador : UserControl
    {
        Validaciones v = new Validaciones(); // Instancia para validaciones
        logicaNav logic = new logicaNav(); // Lógica del navegador
        Form frmCerrar; // Formulario de cierre
        int iCorrecto = 0; // Variable de control para verificar si todo está correcto
        string sTablaPrincipal = "def"; // Nombre de la sTablaPrincipal principal
                                        // Nombre de una sTablaPrincipal secundaria
        List<string> lstTablasAdicionales = new List<string>(); // Lista de tablas adicionales
        Dictionary<string, string> dicItems;
        string sNombreFormulario; // Nombre del formulario
        int iPosicionInicial = 8; // Posición inicial de componentes
        string sIdReporte = ""; // ID del reporte

        int[] arrModoCampoCombo = new int[40]; // Modo de los campos de combo
        int iNumeroCampos = 1; // Contador de campos
        int iPosicionX = 30; // Posición X inicial para componentes
        int iPosicionY = 30; // Posición Y inicial para componentes
        int iActivar = 0; // Variable para reconocer la función del botón de guardar (1. Ingresar, 2. Modificar, 3. Eliminar)
        int globalPosX = 600; // Posición inicial en X para la segunda columna
        int globalPosY = 100; // Posición inicial en Y
        int globalColumna = 0; // Contador de columnas global
        int globalFila = 0; // Contador de filas global
        string[] arrAliasCampos = new string[40]; // Alias para los campos
        string[] arrTipoCampos = new string[30]; // Tipo de los campos
        string[] arrTablaCombo = new string[30]; // Nombre de las tablas de combo
        string[] arrCampoCombo = new string[30]; // Campos de combo
        string[] arrListaItems = new string[30]; // Lista de items
        string[] arrCampoDisplayCombo = new string[30];
        string[] arrAliasExtra = new string[100];// Campos display del combo

        //string sTablaRelacionada = ""; // Tabla relacionada
        //string sCampoDescriptivo = ""; // Campo descriptivo
        //string sColumnaPrimariaRelacionada = ""; // Columna primaria relacionada
        //string sColumnaForanea = ""; // Columna foránea

        int iPosicionCombo = 10; // Posición del combo
        int iNumeroCombos = 0; // Número de combos
        int iNumeroCombosAux = 0; // Número auxiliar de combos
        int iEstadoFormulario = 1; // Estado del formulario (1. Activado, 0. Desactivado)
        Color cColorFuente = Color.White; // Color de la fuente
        Color cNuevoColorFondo = Color.White; // Nuevo color de fondo
        //bool bPresionado = false; // Verifica si se ha presionado un botón
        logica lg = new logica(); // Objeto para obtener métodos de bitácora
        string sIdUsuario = ""; // ID del usuario
        string sIdAplicacion = ""; // ID de la aplicación
        string sUsuarioActivo = ""; // Usuario activo
        string sAplicacionActiva = ""; // Aplicación activa
        string sIdAyuda; // ID de la ayuda
        string sRutaAyuda; // Ruta de la ayuda
        string sIndiceAyuda; // Índice de la ayuda
        string sEstadoAyuda = ""; // Estado de la ayuda
        string sTablaAdicional = "";
        // Variables globales
        string tablaOrigenGlobal = "";
        string campoOrigenGlobal = "";
        string tablaDestinoGlobal = "";
        string campoDestinoGlobal = "";
        string operacionGlobal = "";
        string CampoDescriptivoGlobal = "";
        string valorDescriptivoGlobal = "";


        Font fFuenteLabels = new Font("Century Gothic", 13.0f, FontStyle.Regular, GraphicsUnit.Pixel); // Fuente para labels
        ToolTip tpAyuda = new ToolTip(); // ToolTip para mostrar ayudas en la interfaz
        private List<Tuple<string, string, string, string>> relacionesForaneas = new List<Tuple<string, string, string, string>>();
        List<Tuple<string, string, string>> comboData = new List<Tuple<string, string, string>>();
        Dictionary<string, string[]> aliasPorTabla = new Dictionary<string, string[]>();
        List<OperacionCampo> listaOperaciones = new List<OperacionCampo>();
        // Declaración del diccionario a nivel de clase
        Dictionary<string, List<string>> diccionarioTablasAsociativas = new Dictionary<string, List<string>>();
        // Declaración del diccionario para almacenar las tablas asociativas
        List<string> lstTablasParaComponentes = new List<string>();
        List<string> listaOperacionesCondicionales = new List<string>();

        private IngresarVarios IngresarVariosControl;
        private bool activarIngresarVarios;
        private string nombreTablaVarios;
        private List<ReglaOperacion> listaReglas = new List<ReglaOperacion>();



        public Navegador()
        {
            InitializeComponent();
            LimpiarListaItems(); // Limpia la lista de items
                                 // this.AutoScaleMode = AutoScaleMode.Dpi; // Escala automática
            this.Dock = DockStyle.Fill;
            sUsuarioActivo = sIdUsuario; // Actualizado: nombre de la variable para el usuario activo
            sAplicacionActiva = sIdAplicacion; // Actualizado: nombre de la variable para la aplicación activa
                                               // Configuración del ToolTip
            tpAyuda.IsBalloon = true; // Actualizado: nombre de la variable para el ToolTip
            tpAyuda.AutoPopDelay = 5000; // Mantener el ToolTip visible por 5 segundos
            tpAyuda.InitialDelay = 1000; // Retraso de 1 segundo antes de que aparezca el ToolTip
            tpAyuda.ReshowDelay = 500;   // Retraso de medio segundo antes de reaparecer
            tpAyuda.ShowAlways = true;   // Mostrar el ToolTip siempre, incluso cuando el control no tiene el foco
                                         // Asignación de ToolTips a botones
            tpAyuda.SetToolTip(Btn_Ingresar, "Agregar un nuevo registro al sistema.");
            tpAyuda.SetToolTip(Btn_Modificar, "Modificar el registro seleccionado.");
            tpAyuda.SetToolTip(Btn_Guardar, "Guardar los cambios realizados.");
            tpAyuda.SetToolTip(Btn_Cancelar, "Cancelar la operación actual.");
            tpAyuda.SetToolTip(Btn_Eliminar, "Eliminar el registro seleccionado.");
            tpAyuda.SetToolTip(Btn_Consultar, "Acceder a las consultas avanzadas.");
            tpAyuda.SetToolTip(Btn_Refrescar, "Actualizar los datos de la sTablaPrincipal.");
            tpAyuda.SetToolTip(Btn_FlechaInicio, "Ir al primer registro.");
            tpAyuda.SetToolTip(Btn_Anterior, "Mover al registro anterior.");
            tpAyuda.SetToolTip(Btn_Siguiente, "Mover al siguiente registro.");
            tpAyuda.SetToolTip(Btn_FlechaFin, "Ir al último registro.");
            tpAyuda.SetToolTip(Btn_Ayuda, "Ver la ayuda del formulario.");
            tpAyuda.SetToolTip(Btn_Salir, "Cerrar el formulario actual.");
            tpAyuda.SetToolTip(Btn_Imprimir, "Mostrar un Reporte");

        }


        // Método para manejar la carga del navegador
        private void Navegador_Load(object sender, EventArgs e)
        {
            colorDialog1.Color = cNuevoColorFondo; // Asigna el color de fondo seleccionado
            this.BackColor = colorDialog1.Color; // Aplica el color de fondo al formulario
            BotonesYPermisosSinMensaje(); // Asigna los permisos a los botones según el usuario
            foreach (Control ctrl in Tlp_Panel2.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Paint += button_Paint;
                }
            }
            if (activarIngresarVarios)
            {
                IngresarVariosControl = new IngresarVarios();
                IngresarVariosControl.ComponentePrincipal = this; // Referencia al componente principal
                IngresarVariosControl.Location = new System.Drawing.Point(850, 515); // Ubicación personalizada
                this.Controls.Add(IngresarVariosControl);
                IngresarVariosControl.Visible = true;
                if (!string.IsNullOrEmpty(nombreTablaVarios))
                {
                    IngresarVariosControl.ConfigurarDataGridViewParaTablaVarios(nombreTablaVarios);
                }
                Console.WriteLine("IngresarVariosControl fue inicializado con la tabla: " + nombreTablaVarios);
            }

            if (sTablaPrincipal != "def")
            {
                string sTablaOK = logic.TestTabla(sTablaPrincipal);
                if (sTablaOK == "" && iCorrecto == 0)
                {
                    string sEstadoOK = logic.TestEstado(sTablaPrincipal);
                    if (sEstadoOK == "" && iCorrecto == 0)
                    {
                        if (sEstadoAyuda == "0")
                        {
                            MessageBox.Show("No se encontró ningún registro en la sTablaPrincipal Ayuda");
                            Application.Exit();
                        }
                        else
                        {
                            if (NumeroAlias() == logic.ContarCampos(sTablaPrincipal))
                            {
                                DataTable dt = logic.ConsultaLogica(sTablaPrincipal, relacionesForaneas);
                                Dgv_Informacion.DataSource = dt;

                                int iHead = 0;
                                while (iHead < logic.ContarCampos(sTablaPrincipal))
                                {
                                    Dgv_Informacion.Columns[iHead].HeaderText = arrAliasCampos[iHead];
                                    iHead++;
                                }

                                CreaComponentes();
                                MessageBox.Show("hola");

                                // Crear componentes de las tablas adicionales
                                if (lstTablasParaComponentes != null)
                                {
                                    foreach (string tabla in lstTablasParaComponentes)
                                    {
                                        if (aliasPorTabla.ContainsKey(tabla))
                                        {
                                            string[] aliasTabla = aliasPorTabla[tabla];
                                            string aliasString = string.Join(", ", aliasTabla);
                                            MessageBox.Show("Se generó para la tabla: " + tabla + " con alias: " + aliasString);

                                            CrearComponentesExtra(tabla);
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se encontraron alias para la tabla: " + tabla);
                                        }
                                    }
                                }



                                ColorTitulo();
                                Txt_Tabla.ForeColor = cColorFuente;
                                Deshabilitarcampos_y_botones();

                                if (logic.TestRegistros(sTablaPrincipal) > 0)
                                {
                                    int iNumCombo = 0;
                                    int iIndex = 0;

                                    foreach (Control componente in Controls)
                                    {
                                        if (iIndex < Dgv_Informacion.CurrentRow.Cells.Count) // Asegura que iIndex no exceda las celdas disponibles
                                        {
                                            if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                                            {
                                                if (componente is ComboBox)
                                                {
                                                    if (arrModoCampoCombo[iNumCombo] == 1)
                                                    {
                                                        componente.Text = logic.LlaveCampoRev(arrTablaCombo[iNumCombo], arrCampoCombo[iNumCombo], Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString());
                                                    }
                                                    else
                                                    {
                                                        componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                                                    }
                                                    iNumCombo++;
                                                }
                                                else
                                                {
                                                    componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                                                }

                                                iIndex++;
                                            }
                                            else if (componente is Button)
                                            {
                                                if (iIndex < Dgv_Informacion.CurrentRow.Cells.Count)
                                                {
                                                    string sVar1 = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                                                    if (sVar1 == "0")
                                                    {
                                                        componente.Text = "Desactivado";
                                                        componente.BackColor = Color.Red;
                                                    }
                                                    else if (sVar1 == "1")
                                                    {
                                                        componente.Text = "Activado";
                                                        componente.BackColor = Color.Green;
                                                    }
                                                    componente.Enabled = false;
                                                    iIndex++;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            // Si iIndex está fuera del rango de las celdas, se sale del bucle
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    Btn_Anterior.Enabled = false;
                                    Btn_Siguiente.Enabled = false;
                                    Btn_FlechaInicio.Enabled = false;
                                    Btn_FlechaFin.Enabled = false;
                                    Btn_Modificar.Enabled = false;
                                    Btn_Eliminar.Enabled = false;
                                }
                            }
                            else
                            {
                                if (NumeroAlias() < logic.ContarCampos(sTablaPrincipal))
                                {
                                    DialogResult drValidacion = MessageBox.Show(sEstadoOK + "El número de Alias asignados es menor que el requerido \n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                                    if (drValidacion == DialogResult.OK)
                                    {
                                        Application.Exit();
                                    }
                                }
                                else
                                {
                                    if (NumeroAlias() > logic.ContarCampos(sTablaPrincipal))
                                    {
                                        DialogResult drValidacion = MessageBox.Show(sEstadoOK + "El número de Alias asignados es mayor que el requerido \n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                                        if (drValidacion == DialogResult.OK)
                                        {
                                            Application.Exit();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        DialogResult drValidacion = MessageBox.Show(sEstadoOK + "\n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                        if (drValidacion == DialogResult.OK)
                        {
                            Application.Exit();
                        }
                    }
                }
                else
                {
                    DialogResult drValidacion = MessageBox.Show(sTablaOK + "\n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                    if (drValidacion == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
        }
        //-----------------------------------------------Funciones-----------------------------------------------//

        //******************************************** CODIGO HECHO POR DIEGO MARROQUIN ***************************** 

        void ColorTitulo()
        {
            foreach (Control componente in Controls)
            {
                if (componente is Label)
                {
                    componente.ForeColor = cColorFuente; // Cambia el color de la fuente de los labels
                }
            }
        }

        public void ObtenerIdUsuario(string sIdUsuario)
        {
            this.sIdUsuario = sIdUsuario; // Asigna el ID del usuario
        }

        // Lista para almacenar múltiples relaciones foráneas como tuplas

        // Lista para almacenar múltiples relaciones foráneas
        
        public void AsignarForaneas(string sTablaRela, string sCampoDescri, string sColumnaFora, string sColumnaPrimariaRelaciona)
        {
            // Añadir la relación foránea a la lista
            relacionesForaneas.Add(new Tuple<string, string, string, string>(sTablaRela, sCampoDescri, sColumnaFora, sColumnaPrimariaRelaciona));
        }
        public void AsignarVarios(bool activar)
        {
            activarIngresarVarios = activar; // Solo cambia el estado de la variable
        }

        public void AsignarTablaVarios(string nombreTabla)
        {
            nombreTablaVarios = nombreTabla;
            Console.WriteLine("Nombre de la tabla almacenado: " + nombreTabla);
        }

        public void AsignarReglaOperacion(
           string componenteOrigen,
           string tablaComparacion,
           string campoComparacion,
           string condicion,
           string accion,
           string tablaInsercion,
           string valorClavePrimaria,
           Dictionary<string, string> mapeoComponentesCampos // Diccionario de mapeo
       )
        {
            // Crear la nueva regla y asignar sus propiedades
            ReglaOperacion nuevaRegla = new ReglaOperacion
            {
                ComponenteOrigen = componenteOrigen,
                TablaComparacion = tablaComparacion,
                CampoComparacion = campoComparacion,
                Condicion = condicion,
                Accion = accion,
                TablaInsercion = tablaInsercion,
                ClavePrimaria = valorClavePrimaria,
                MapeoComponentesCampos = mapeoComponentesCampos // Asignar el diccionario de mapeo
            };

            // Agregar la regla a la lista de reglas
            listaReglas.Add(nuevaRegla);

            Console.WriteLine($"Regla condicional agregada: si '{componenteOrigen}' es '{condicion}' que '{campoComparacion}' en '{tablaComparacion}', hacer '{accion}' en '{tablaInsercion}' con los mapeos {string.Join(", ", mapeoComponentesCampos)}.");
        }
       


        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 
        public void ObtenerIdAplicacion(string sIdAplicacion)
        {
            this.sIdAplicacion = sIdAplicacion; // Asigna el ID de la aplicación
        }


        private int NumeroAlias()
        {
            int iIndex = 0;
            foreach (string sCad in arrAliasCampos)
            {
                if (sCad != null && sCad != "")
                {
                    iIndex++;
                }
            }
            return iIndex; // Devuelve el número de alias asignados
        }

        public string ObtenerDatoTabla(int iPos)
        {
            iPos = iPos - 1;
            return Dgv_Informacion.CurrentRow.Cells[iPos].Value.ToString(); // Devuelve un dato específico de la sTablaPrincipal según la posición
        }

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 

        public string ObtenerDatoCampos(int iPos)
        {
            int iIndex = 0;
            iPos = iPos - 1;  // Ajuste del índice, ya que 'pos' es 1-based, pero los arrays son 0-based
            string sDato = "";

            // Recorre los controles relevantes: TextBox, DateTimePicker, ComboBox
            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    if (iIndex == iPos)  // Verifica si el índice coincide con el solicitado
                    {
                        // Obtiene el valor del control según su tipo
                        if (componente is TextBox || componente is ComboBox)
                        {
                            sDato = componente.Text;  // Para TextBox y ComboBox, toma el texto
                        }
                        else if (componente is DateTimePicker dateTimePicker)
                        {
                            sDato = dateTimePicker.Value.ToString("yyyy-MM-dd");  // Formato de fecha
                        }
                        break;  // Una vez encontrado el campo, termina el ciclo
                    }
                    iIndex++;  // Incrementa el índice solo si es un control relevante
                }
            }

            return sDato; // Devuelve el valor del campo encontrado
        }

        public void AsignarAlias(string[] arrAlias)
        {
            arrAlias.CopyTo(arrAliasCampos, 0); // Cambiado aliasC a arrAliasCampos
        }

        public void AsignarAliasExtras(string tabla, string[] listadecampos)
        {
            // Guarda la lista de campos (alias) en el diccionario, asociándola con la tabla correspondiente
            if (!aliasPorTabla.ContainsKey(tabla))
            {
                aliasPorTabla.Add(tabla, listadecampos);
            }
            else
            {
                aliasPorTabla[tabla] = listadecampos; // Actualiza si ya existe
            }
        }

        public void AsignarAyuda(string sAyudar)
        {
            string sAyudaOK = logic.TestTabla("ayuda");
            if (sAyudaOK == "")
            {
                if (logic.ContarRegAyuda(sAyudar) > 0)
                {
                    sIdAyuda = sAyudar; 
                    sRutaAyuda = logic.ModRuta(sIdAyuda);
                    sIndiceAyuda = logic.ModIndice(sIdAyuda); 
                    if (sRutaAyuda == "" || sIndiceAyuda == "" || sRutaAyuda == null || sIndiceAyuda == null)
                    {
                        DialogResult drValidacion = MessageBox.Show("La Ruta o índice de la ayuda está vacía", "Verificación de requisitos", MessageBoxButtons.OK);
                        if (drValidacion == DialogResult.OK)
                        {
                            iCorrecto = 1; 
                        }
                    }
                }
                else
                {
                    DialogResult drValidacion = MessageBox.Show("Por favor verifique el id de Ayuda asignado al form", "Verificación de requisitos", MessageBoxButtons.OK);
                    if (drValidacion == DialogResult.OK)
                    {
                        iCorrecto = 1;
                    }
                }

            }
            else
            {
                DialogResult drValidacion = MessageBox.Show(sAyudaOK + ", Por favor incluirla", "Verificación de requisitos", MessageBoxButtons.OK);
                if (drValidacion == DialogResult.OK)
                {
                    iCorrecto = 1; 
                }
            }
        }

        public void AsignarReporte(string sRepo)
        {
            sIdReporte = sRepo; 
        }

        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS ***************************** 

        public void AsignarSalida(Form frmSalida)
        {
            frmCerrar = frmSalida; 
        }

        public void AsignarColorFuente(Color colFuenteC)
        {
            cColorFuente = colFuenteC; 
        }

        public void AsignarTabla(string sTabla)
        {
            sTablaPrincipal = sTabla; 
        }

        public void AsignarTablas(List<string> lstTablas)
        {
            lstTablasAdicionales = lstTablas; 
        }

        public void AsignarNombreForm(string sNom)
        {
            sNombreFormulario = sNom; 
            Txt_Tabla.Text = sNombreFormulario; 
        }
        public void AsignarTablaComponentes(List<string> lstTablas)
        {
            lstTablasParaComponentes = lstTablas;
        }

        public void AsignarAsociativas(List<Tuple<string, List<string>>> lstTablasAsociativas)
        {
            foreach (var tupla in lstTablasAsociativas)
            {
                string nombreTabla = tupla.Item1;  // Nombre de la tabla asociativa
                List<string> columnasAsociadas = tupla.Item2;  // Lista de nombres de columnas y componentes

                // Guardar directamente las columnas asociadas sin procesar componentes
                diccionarioTablasAsociativas[nombreTabla] = columnasAsociadas; // Guarda ambas, campo y componente
            }
        }

        public void AsignarComboConTabla(string sTablaPrincipal, string sCampoClave, string sCampoDisplay, int iModo)
        {
            // Verifica si la sTablaPrincipal existe
            string sTablaOK = logic.TestTabla(sTablaPrincipal);
            if (sTablaOK == "")
            {
                // Asigna los valores para el combo
                arrModoCampoCombo[iNumeroCombos] = iModo; 
                arrTablaCombo[iNumeroCombos] = sTablaPrincipal;
                arrCampoCombo[iNumeroCombos] = sCampoClave;
                arrCampoDisplayCombo[iNumeroCombos] = sCampoDisplay;
                comboData.Add(new Tuple<string, string, string>(sTablaPrincipal, sCampoClave, sCampoDisplay));
                iNumeroCombos++;
               
            }
            else
            {
                // Muestra error si la sTablaPrincipal o campo son incorrectos
                DialogResult drValidacion = MessageBox.Show(sTablaOK + ", o el campo seleccionado\n para el ComboBox es incorrecto", "Verificación de requisitos", MessageBoxButtons.OK);
                if (drValidacion == DialogResult.OK)
                {
                    iCorrecto = 1; // Cambiado correcto a iCorrecto
                }
            }
        }


        //******************************************** CODIGO HECHO POR ANIKA ESCOTO ***************************** 

        public void AsignarColorFondo(Color colNuevo)
        {
            cNuevoColorFondo = colNuevo; 
        }

        public void AsignarComboConLista(int iPos, string sLista)
        {
            iPosicionCombo = iPos - 1; 
            LimpiarLista(sLista);
            arrModoCampoCombo[iNumeroCombos] = 0; 
            iNumeroCombos++;
        }

        void LimpiarLista(string sCadena)
        {
            LimpiarListaItems();
            int iContadorCadena = 0;
            int iContadorArray = 0;
            string sPalabra = "";
            while (iContadorCadena < sCadena.Length)
            {
                if (sCadena[iContadorCadena] != '|')
                {
                    sPalabra += sCadena[iContadorCadena];
                    iContadorCadena++;
                }
                else
                {
                    arrListaItems[iContadorArray] = sPalabra; 
                    sPalabra = "";
                    iContadorArray++;
                    iContadorCadena++;
                }
            }
        }

        public void AsignarOperacionEnTiempoReal(string componenteOrigen1, string componenteOrigen2, string operacion, string componenteDestino)
        {
            string valorOrigen1 = ObtenerValorActualizar(componenteOrigen1); // Validar si contiene el nombre del campo
            string valorOrigen2 = ObtenerValorActualizar(componenteOrigen2);
            Control compDest = this.Controls.Find(componenteDestino, true).FirstOrDefault();

            /*  if (string.IsNullOrEmpty(valorOrigen1) || string.IsNullOrEmpty(valorOrigen2) || compDest == null)
              {
                  Console.WriteLine($"Error: Uno o más componentes no fueron encontrados o están vacíos. Verifique los nombres de los componentes.");
                  return;
              }*/

            // Suscribirse a los eventos de cambio de ambos componentes origen
            Control comp1 = this.Controls.Find(componenteOrigen1, true).FirstOrDefault();
            Control comp2 = this.Controls.Find(componenteOrigen2, true).FirstOrDefault();

            if (comp1 != null)
            {
                if (comp1 is TextBox tb1)
                {
                    tb1.TextChanged += (sender, e) => EjecutarOperacionTiempoReal(ObtenerValorActualizar(componenteOrigen1), ObtenerValorActualizar(componenteOrigen2), operacion, compDest);
                }
                else if (comp1 is ComboBox cb1)
                {
                    cb1.SelectedIndexChanged += (sender, e) => EjecutarOperacionTiempoReal(ObtenerValorActualizar(componenteOrigen1), ObtenerValorActualizar(componenteOrigen2), operacion, compDest);
                }
            }

            if (comp2 != null)
            {
                if (comp2 is TextBox tb2)
                {
                    tb2.TextChanged += (sender, e) => EjecutarOperacionTiempoReal(ObtenerValorActualizar(componenteOrigen1), ObtenerValorActualizar(componenteOrigen2), operacion, compDest);
                }
                else if (comp2 is ComboBox cb2)
                {
                    cb2.SelectedIndexChanged += (sender, e) => EjecutarOperacionTiempoReal(ObtenerValorActualizar(componenteOrigen1), ObtenerValorActualizar(componenteOrigen2), operacion, compDest);
                }
            }
        }
        void LimpiarListaItems()
        {
            for (int iIndex = 0; iIndex < arrListaItems.Length; iIndex++) 
            {
                arrListaItems[iIndex] = ""; 
            }
        }
        private void EjecutarOperacionTiempoReal(string valor1, string valor2, string operacion, Control componenteDestino)
        {
            if (string.IsNullOrEmpty(valor1) || string.IsNullOrEmpty(valor2))
            {
                Console.WriteLine("Error: Ambos valores deben estar presentes antes de realizar la operación.");
                return;
            }

            try
            {
                decimal resultado = 0;
                decimal num1 = decimal.Parse(valor1);
                decimal num2 = decimal.Parse(valor2);

                switch (operacion.ToLower())
                {
                    case "sumar":
                        resultado = num1 + num2;
                        break;
                    case "restar":
                        resultado = num1 - num2;
                        break;
                    case "multiplicar":
                        resultado = num1 * num2;
                        break;
                    case "dividir":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                            return;
                        }
                        resultado = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Operación no reconocida.");
                        return;
                }

                // Actualizar el valor del componente destino
                if (componenteDestino is TextBox tb)
                {
                    tb.Text = resultado.ToString();
                }
                else if (componenteDestino is Label lbl)
                {
                    lbl.Text = resultado.ToString();
                }
                else
                {
                    Console.WriteLine("Error: El componente destino no es compatible.");
                }

                Console.WriteLine($"Operación {operacion} realizada. Resultado: {resultado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al realizar la operación: {ex.Message}");
            }
        }

        public bool EjecutarReglasCondicionales()
        {
            try
            {
                foreach (var regla in listaReglas)
                {
                    // Obtener el valor del componente origen para la condición
                    string valorComponenteOrigen = ObtenerValorActualizar(regla.ComponenteOrigen);
                    Console.WriteLine("VALOR PARA CONDICION COMPONENTE ORIGEN: " + valorComponenteOrigen);

                    if (string.IsNullOrEmpty(valorComponenteOrigen))
                    {
                        Console.WriteLine($"Error: El valor en '{regla.ComponenteOrigen}' no ha sido proporcionado.");
                        continue;
                    }
                    decimal valorComponente = decimal.Parse(valorComponenteOrigen);

                    // Obtener el valor de la clave primaria
                    string valorClavePrimaria = ObtenerValorActualizar(regla.ClavePrimaria);
                    Console.WriteLine("VALOR CLAVE PRIMARIA: " + valorClavePrimaria);

                    if (string.IsNullOrEmpty(valorClavePrimaria))
                    {
                        Console.WriteLine($"Error: No se encontró un valor para la clave primaria '{regla.ClavePrimaria}'.");
                        continue;
                    }

                    // Obtener el valor del campo de comparación desde la tabla según la clave primaria
                    string valorCampoComparacion = logic.ObtenerValorCampo(
                        regla.TablaComparacion,
                        regla.CampoComparacion,
                        logic.ObtenerClavePrimaria(regla.TablaComparacion),
                        valorClavePrimaria);

                    Console.WriteLine("VALOR COMPARACION: " + valorCampoComparacion);
                    if (string.IsNullOrEmpty(valorCampoComparacion))
                    {
                        Console.WriteLine($"Error: No se encontró el valor en '{regla.CampoComparacion}' de la tabla '{regla.TablaComparacion}'.");
                        continue;
                    }
                    decimal valorComparacion = decimal.Parse(valorCampoComparacion);

                    // Evaluar la condición
                    bool condicionCumplida = EvaluarCondicion(valorComponente, regla.Condicion, valorComparacion);
                    if (!condicionCumplida)
                    {
                        Console.WriteLine("La condición no se cumple. Operación omitida.");
                        continue;
                    }

                    // Ejecutar el INSERT si se cumple la condición
                    if (regla.Accion == "insertar")
                    {
                        var valoresComponentes = new Dictionary<string, string>();

                        foreach (var map in regla.MapeoComponentesCampos)
                        {
                            string valorComponenteInsertar = ObtenerValorActualizar(map.Key);
                            if (!string.IsNullOrEmpty(valorComponenteInsertar))
                            {
                                valoresComponentes[map.Key] = valorComponenteInsertar;
                            }
                        }

                        if (valoresComponentes.Count > 0)
                        {
                            string insertQuery = logic.RealizarInsercionCondicional(regla.TablaInsercion, valoresComponentes, regla.MapeoComponentesCampos);
                            MessageBox.Show("Se asignó un registro en " + regla.TablaInsercion);
                            if (insertQuery != null)
                            {
                                lstQueries2.Add(insertQuery); // Añade la consulta a la lista si es válida
                            }
                            else
                            {
                                MessageBox.Show("Error al generar la consulta de inserción. No se completará la operación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ejecutar las reglas condicionales: {ex.Message}");
                return false;
            }
        }
        private bool EvaluarCondicion(decimal valorComponente, string condicion, decimal valorComparacion)
        {
            switch (condicion)
            {
                case "menor":
                    return valorComponente < valorComparacion;
                case "mayor":
                    return valorComponente > valorComparacion;
                case "igual":
                    return valorComponente == valorComparacion;
                default:
                    Console.WriteLine("Condición no reconocida.");
                    return false;
            }
        }

        List<OperacionCampo> listaOperacionesIndividuales = new List<OperacionCampo>();
        public void AsignarOperacionVarios(string campoOrigen, string tablaDestino, string campoDestino, string operacion, string campoCondicional, string valorCondicional)
        {
            var nuevaOperacion = new OperacionCampo(campoOrigen, tablaDestino, campoDestino, operacion, campoCondicional, valorCondicional);
            listaOperaciones.Add(nuevaOperacion);

            Console.WriteLine($"Operación '{operacion}' asignada entre componente {campoOrigen} y campo {campoDestino} de {tablaDestino} con condición en '{campoCondicional}' = '{valorCondicional}'.");
        }

        public void AsignarOperacionIndividual(string campoOrigen, string tablaDestino, string campoDestino, string operacion, string campoCondicional, string valorCondicional)
        {
            var nuevaOperacion = new OperacionCampo(campoOrigen, tablaDestino, campoDestino, operacion, campoCondicional, valorCondicional);
            listaOperacionesIndividuales.Add(nuevaOperacion);
            Console.WriteLine($"Operación (Individual) '{operacion}' asignada entre componente {campoOrigen} y campo {campoDestino} de {tablaDestino} con condición en '{campoCondicional}' = '{valorCondicional}'.");
        }
        private string GenerarConsultaOperacion(string valorOrigen, string valorDestino, OperacionCampo operacion, string valorCondicional)
        {
            string tipoCampoDestino = logic.ObtenerTipoCampo(operacion.TablaDestino, operacion.CampoDestino);
            return tipoCampoDestino.Contains("int")
                ? GenerarQueryOperacionEnteros(valorOrigen, valorDestino, operacion, valorCondicional)
                : GenerarQueryOperacionDecimales(valorOrigen, valorDestino, operacion, valorCondicional);
        }
        public bool GenerarConsultasOperacionesIndividuales()
        {
            try
            {
                foreach (var operacion in listaOperacionesIndividuales)
                {
                    string valorOrigen = ObtenerValorActualizar(operacion.CampoOrigen);
                    string valorCondicional = ObtenerValorActualizar(operacion.ValorCondicional);
                    string valorDestino = logic.ObtenerValorCampo(operacion.TablaDestino, operacion.CampoDestino, operacion.CampoCondicional, valorCondicional);
                    string query = GenerarConsultaOperacion(valorOrigen, valorDestino, operacion, valorCondicional);

                    if (string.IsNullOrEmpty(query))
                    {
                        Console.WriteLine("Error en operación: El resultado no puede ser negativo o es nulo.");
                        return false;
                    }

                    lstQueries2.Add(query);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al generar consultas de operación individual: {ex.Message}");
                return false;
            }
            return true;
        }


        private string GenerarQueryOperacionEnteros(string valorOrigen, string valorDestino, OperacionCampo operacion, string valorCondicional)
        {
            int valorNumOrigen = int.Parse(valorOrigen);
            int valorNumDestino = string.IsNullOrEmpty(valorDestino) ? 0 : int.Parse(valorDestino);
            int resultadoOperacion = 0;

            switch (operacion.Operacion)
            {
                case "copiar":
                    resultadoOperacion = valorNumOrigen;
                    break;
                case "sumar":
                    resultadoOperacion = valorNumDestino + valorNumOrigen;
                    break;
                case "restar":
                    resultadoOperacion = valorNumDestino - valorNumOrigen;
                    if (resultadoOperacion < 0)
                    {
                        Console.WriteLine("Error: El resultado de la resta no puede ser negativo.");
                        return null;
                    }
                    break;
                default:
                    Console.WriteLine("Operación no reconocida.");
                    return null;
            }

            return $"UPDATE {operacion.TablaDestino} SET {operacion.CampoDestino} = {resultadoOperacion} WHERE {operacion.CampoCondicional} = '{valorCondicional}' AND estado = 1;";
        }

        private string GenerarQueryOperacionDecimales(string valorOrigen, string valorDestino, OperacionCampo operacion, string valorCondicional)
        {
            decimal valorDecOrigen = decimal.Parse(valorOrigen);
            decimal valorDecDestino = string.IsNullOrEmpty(valorDestino) ? 0 : decimal.Parse(valorDestino);
            decimal resultadoOperacionDecimal = 0;

            switch (operacion.Operacion)
            {
                case "copiar":
                    resultadoOperacionDecimal = valorDecOrigen;
                    break;
                case "sumar":
                    resultadoOperacionDecimal = valorDecDestino + valorDecOrigen;
                    break;
                case "restar":
                    resultadoOperacionDecimal = valorDecDestino - valorDecOrigen;
                    break;
                default:
                    Console.WriteLine("Operación no reconocida.");
                    return null;
            }

            return $"UPDATE {operacion.TablaDestino} SET {operacion.CampoDestino} = {resultadoOperacionDecimal} WHERE {operacion.CampoCondicional} = '{valorCondicional}' AND estado = 1;";
        }


        private string ObtenerValorActualizar(string campoNombre)
        {
            // Buscar el componente correspondiente por su nombre (primero intenta con 'extra_')
            Control componente = this.Controls.Find("extra_" + campoNombre, true).FirstOrDefault();

            // Si no se encuentra con 'extra_', intenta con el nombre original
            if (componente == null)
            {
                componente = this.Controls.Find(campoNombre, true).FirstOrDefault();
            }

            if (componente == null)
            {
                Console.WriteLine($"Error: No se encontró un componente con el nombre '{campoNombre}' o 'extra_{campoNombre}'.");
                return null;
            }

            // Dependiendo del tipo de componente, obtener su valor
            if (componente is ComboBox cb)
            {
                return cb.SelectedValue.ToString();  // Retorna el texto mostrado en el ComboBox
            }
            else if (componente is DateTimePicker dtp)
            {
                return dtp.Value.ToString("yyyy-MM-dd"); // Formato de fecha
            }
            else if (componente is TextBox tb)
            {
                return tb.Text; // Retorna el valor de un TextBox
            }
            else if (componente is Button btn)
            {
                return (btn.Text == "Activado") ? "1" : "0"; // Retorna "1" si el botón está activado, "0" si está desactivado
            }

            return "";
        }



        // Función para verificar si un valor es numérico
        private bool EsNumero(string valor)
        {
            return int.TryParse(valor, out _);
        }

        void CreaComponentes()
        {
            // Obtiene los campos, tipos de datos y llaves de la sTablaPrincipal
            string[] sCampos = logic.Campos(sTablaPrincipal);
            string[] sTipos = logic.Tipos(sTablaPrincipal);
            string[] sLlaves = logic.Llaves(sTablaPrincipal);
            int iIndex = 0;
            int iFin = sCampos.Length;
            int iNumeroCampos = 1; // Contador de campos

            // Variables para gestionar la posición
            int columnaActual = 0; // Contador de columna
            int maxFilasPorColumna = 5; // Número máximo de filas antes de cambiar de columna
            int posX = 50; // Posición inicial en X
            int posY = 100; // Posición inicial en Y
            int desplazamientoY = 60; // Espacio vertical entre controles

            while (iIndex < iFin)
            {
                // Calcular la posición en la que se colocará el Label y el control asociado
                int currentPosY = posY + ((iNumeroCampos - 1) % maxFilasPorColumna) * desplazamientoY;

                // Si alcanzamos el máximo de filas por columna, movemos a la siguiente columna
                if (iNumeroCampos > 1 && (iNumeroCampos - 1) % maxFilasPorColumna == 0)
                {
                    columnaActual++;
                    posX += 200; // Desplazamiento horizontal para la siguiente columna
                }

                // Crea un Label para cada campo
                Label lb = new Label();
                lb.Text = arrAliasCampos[iIndex];
                lb.Location = new Point(posX, currentPosY);
                lb.Name = "lb_" + sCampos[iIndex];
                lb.Font = new Font(fFuenteLabels.FontFamily, fFuenteLabels.Size * 1.3f, FontStyle.Bold | fFuenteLabels.Style);
                lb.ForeColor = cColorFuente;
                lb.AutoSize = true;
                this.Controls.Add(lb);

                // Dependiendo del tipo de campo, crea el componente adecuado
                string nombreComponente = sCampos[iIndex];
                Point controlPosition = new Point(posX, currentPosY + lb.Height + 5); // Posición del control debajo del Label

                switch (sTipos[iIndex])
                {
                    case "int":
                        arrTipoCampos[iIndex] = "Num";
                        if (sLlaves[iIndex] != "MUL")
                        {
                            CrearTextBoxNumerico(nombreComponente, controlPosition);
                            Console.WriteLine("COMPONENTE NOMBRE: " + nombreComponente);
                        }
                        else
                        {
                            string tablaRelacionada = logic.DetectarTablaRelacionada(sTablaPrincipal, sCampos[iIndex]);
                            string campoClave = logic.DetectarClaveRelacionada(sTablaPrincipal, sCampos[iIndex]);
                            string campoDisplay = logic.DetectarCampoDisplayRelacionada(sTablaPrincipal, sCampos[iIndex]);

                            // Cambiar DataTable por Dictionary
                            Dictionary<string, string> dicItems = logic.Items(tablaRelacionada, campoClave, campoDisplay);

                            CrearComboBox(nombreComponente, controlPosition);

                        }
                        break;

                    case "varchar":
                    case "text":
                        arrTipoCampos[iIndex] = "Text";
                        if (sLlaves[iIndex] != "MUL")
                        {
                            CrearTextBoxVarchar(nombreComponente, controlPosition);
                            Console.WriteLine("COMPONENTE NOMBRE: " + nombreComponente);
                        }
                        else
                        {
                            string tablaRelacionada = logic.DetectarTablaRelacionada(sTablaPrincipal, sCampos[iIndex]);
                            string campoClave = logic.DetectarClaveRelacionada(sTablaPrincipal, sCampos[iIndex]);
                            string campoDisplay = logic.DetectarCampoDisplayRelacionada(sTablaPrincipal, sCampos[iIndex]);

                            // Cambiar DataTable por Dictionary
                            Dictionary<string, string> dicItems = logic.Items(tablaRelacionada, campoClave, campoDisplay);

                            CrearComboBox(nombreComponente, controlPosition);

                        }
                        break;

                    case "date":
                    case "datetime":
                        arrTipoCampos[iIndex] = "Date";
                        if (sLlaves[iIndex] != "MUL" && sLlaves[iIndex] != "PRI")
                        {
                            CrearDateTimePicker(nombreComponente, controlPosition);
                            Console.WriteLine("COMPONENTE NOMBRE: " + nombreComponente);
                        }
                        else
                        {


                            CrearComboBox(nombreComponente, controlPosition);
                            Console.WriteLine("COMPONENTE NOMBRE: " + nombreComponente);

                        }
                        break;

                    case "time":
                        arrTipoCampos[iIndex] = "Time";
                        CrearCampoHora(nombreComponente, controlPosition);
                        Console.WriteLine("COMPONENTE NOMBRE: " + nombreComponente);
                        break;

                    case "float":
                    case "decimal":
                    case "double":
                        arrTipoCampos[iIndex] = "Decimal";
                        CrearCampoDecimales(nombreComponente, controlPosition);
                        Console.WriteLine("COMPONENTE NOMBRE: " + nombreComponente);
                        break;

                    case "tinyint":
                        arrTipoCampos[iIndex] = "Bool";
                        if (sLlaves[iIndex] != "MUL")
                        {
                            CrearBotonEstado(nombreComponente, controlPosition);
                            Console.WriteLine("COMPONENTE NOMBRE: " + nombreComponente);
                        }
                        else
                        {
                            // Si es clave foránea, podrías manejarlo aquí si es necesario
                        }
                        break;

                    default:
                        if (!string.IsNullOrEmpty(sTipos[iIndex]))
                        {
                            MessageBox.Show($"La tabla {sTablaPrincipal} posee un campo {sTipos[iIndex]}, este tipo de dato no es reconocido por el navegador.", "Verificación de requisitos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                }

                iNumeroCampos++;
                iIndex++;
            }
        }
        //******************************************** CODIGO HECHO POR JORGE AVILA***************************** 

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ***************************** 
        void CrearComponentesExtra(string tabla)
        {
            string[] sCampos = logic.Campos(tabla);
            string[] sTipos = logic.Tipos(tabla);
            string[] sLlaves = logic.Llaves(tabla);

            // Verificar si la tabla tiene alias definidos en el diccionario
            if (!aliasPorTabla.ContainsKey(tabla))
            {
                MessageBox.Show($"No hay alias definidos para la tabla: {tabla}");
                return;
            }

            // Obtener los alias de los campos para esta tabla
            string[] alias = aliasPorTabla[tabla];

            // Solo accede y configura la DataGridView de IngresarVarios si activarIngresarVarios es true
            if (activarIngresarVarios)
            {
                // Accede a la DataGridView del UserControl IngresarVarios
                DataGridView dgvExtras = IngresarVariosControl.DataGridViewInformacionExtra;

                // Agregar columnas a la DataGridView si no existen ya
                if (dgvExtras.Columns.Count == 0)
                {
                    foreach (string aliasCampo in alias)
                    {
                        // Añadir columnas con los nombres de los alias
                        dgvExtras.Columns.Add(aliasCampo, aliasCampo);
                    }
                }
            }
            // El resto del código para crear los componentes y etiquetas
            int iIndex = 0;
            int desplazamientoY = 60;  // Espacio vertical entre controles
            int desplazamientoX = 200; // Espacio horizontal entre columnas

            // Posiciones iniciales basadas en las variables globales
            int posX = globalPosX + (globalColumna * desplazamientoX);
            int posY = globalPosY;

            // Crear un Label para indicar los campos adicionales
            Label lbl = new Label();
            lbl.Text = "Campos Adicionales para: " + tabla;
            lbl.Location = new Point(globalPosX + 50, posY);
            lbl.Font = new Font(fFuenteLabels.FontFamily, fFuenteLabels.Size * 1.2f, FontStyle.Bold | fFuenteLabels.Style);
            lbl.ForeColor = cColorFuente;
            lbl.AutoSize = true;
            this.Controls.Add(lbl);

            posY += lbl.Height + 10; // Actualizar posY para colocar controles debajo del Label

            int itemsEnColumna = 0; // Contador de ítems en la columna actual

            // Iterar sobre todos los campos de la tabla
            for (int i = 0; i < sCampos.Length; i++)
            {
                // Verificar si el campo es autoincremental o clave primaria

                // Buscar si el campo actual tiene un alias asignado en la lista de alias
                string aliasActual = alias.FirstOrDefault(a => a == sCampos[i]);
                if (aliasActual == null)
                {
                    continue; // Si el campo no está en los alias, no se crea el componente
                }

                // Calcular la posición Y actual
                int currentPosY = posY + (itemsEnColumna * desplazamientoY);

                // Si la posición Y excede la altura del formulario, pasar a la siguiente columna
                if (currentPosY + desplazamientoY > this.Height - 100) // Ajuste para margen inferior
                {
                    globalColumna++;
                    posX = globalPosX + (globalColumna * desplazamientoX);
                    posY = globalPosY + lbl.Height + 10;
                    currentPosY = posY;
                    itemsEnColumna = 0;
                }

                // Crear el Label para el campo actual
                Label lb = new Label();
                lb.Text = aliasActual;
                lb.Location = new Point(posX, currentPosY);
                lb.Name = "lb_extra_" + sCampos[i];
                lb.Font = new Font(fFuenteLabels.FontFamily, fFuenteLabels.Size * 1.1f, FontStyle.Bold | fFuenteLabels.Style);
                lb.ForeColor = cColorFuente;
                lb.AutoSize = true;
                this.Controls.Add(lb);

                // Crear el control asociado debajo del Label
                Point controlPosition = new Point(posX, currentPosY + lb.Height + 5); // Ajuste para que se coloque justo debajo del Label

                string nombreComponente = "extra_" + sCampos[i];

                switch (sTipos[i])
                {
                    case "int":
                        arrTipoCampos[iIndex] = "Num";
                        if (sLlaves[i] != "MUL")
                        {
                            CrearTextBoxNumerico(nombreComponente, controlPosition);
                        }
                        else
                        {
                            // Es una clave foránea, crear ComboBox
                            string tablaRelacionada = logic.DetectarTablaRelacionada(tabla, sCampos[iIndex]);
                            string campoClave = logic.DetectarClaveRelacionada(tabla, sCampos[iIndex]);
                            string campoDisplay = logic.DetectarCampoDisplayRelacionada(tabla, sCampos[iIndex]);
                            Console.WriteLine($"Tabla relacionada: {tablaRelacionada}, Campo Clave: {campoClave}, Campo Display: {campoDisplay}");
                            Console.WriteLine($"Tabla relacionada: {tabla}");
                            // Cambiar DataTable por Dictionary
                            Dictionary<string, string> dicItems = logic.Items(tablaRelacionada, campoClave, campoDisplay);

                            CrearComboBox(nombreComponente, controlPosition);
                        }
                        break;

                    case "varchar":
                    case "text":
                        arrTipoCampos[iIndex] = "Text";
                        if (sLlaves[i] != "MUL")
                        {
                            CrearTextBoxVarchar(nombreComponente, controlPosition);
                        }
                        else
                        {
                            CrearComboBox(nombreComponente, controlPosition);
                        }
                        break;

                    case "date":
                    case "datetime":
                        arrTipoCampos[iIndex] = "Date";
                        CrearDateTimePicker(nombreComponente, controlPosition);
                        break;

                    case "time":
                        arrTipoCampos[iIndex] = "Time";
                        CrearCampoHora(nombreComponente, controlPosition);
                        break;

                    case "float":
                    case "decimal":
                    case "double":
                        arrTipoCampos[iIndex] = "Decimal";
                        CrearCampoDecimales(nombreComponente, controlPosition);
                        break;

                    case "tinyint":
                        arrTipoCampos[iIndex] = "Bool";
                        CrearBotonEstado(nombreComponente, controlPosition);
                        break;

                    default:
                        if (!string.IsNullOrEmpty(sTipos[i]))
                        {
                            MessageBox.Show($"El tipo de dato '{sTipos[i]}' no es soportado para el campo '{sCampos[i]}'.", "Tipo de dato no soportado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                }

                itemsEnColumna++;
            }

            // Resetear la posición de columna y fila para la próxima tabla si es necesario
            globalColumna++;
            globalFila = 0;
        }

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ***************************** 

        //******************************************** CODIGO HECHO POR DIEGO MARROQUIN*****************************

        // Función que maneja el evento click de los botones, cambiando su estado entre "Activado" y "Desactivado"
        void Func_click(object sender, EventArgs e)
        {
            // Convertir el sender a un Button
            Button btn = sender as Button;

            // Verifica si la conversión fue exitosa
            if (btn != null)
            {
                // Cambia el estado del botón en función de su estado actual
                if (btn.Text == "Activado")
                {
                    btn.Text = "Desactivado";
                    btn.BackColor = Color.Red;
                    iEstadoFormulario = 0;
                }
                else
                {
                    btn.Text = "Activado";
                    btn.BackColor = Color.Green;
                    iEstadoFormulario = 1;
                }
            }
        }
        //******************************************** CODIGO HECHO POR DIEGO MARROQUIN*****************************

        //******************************************** CODIGO HECHO POR PABLO FLORES*****************************

        // Función que crea un botón con un estado inicial de "Activado" y lo añade al formulario
        void CrearBotonEstado(String sNom, Point location)
        {
            Button btn = new Button(); // Crea un nuevo botón
            btn.Width = (int)(btn.Width * 1.2);
            btn.Height = (int)(btn.Height * 1.2);
            btn.Location = location; // Establece la ubicación del botón
            btn.Text = "Activado"; // Establece el texto inicial del botón
            btn.BackColor = Color.Green; // Establece el color de fondo inicial
            btn.Click += new EventHandler(Func_click); // Asigna la función de clic al botón
            btn.Name = sNom; // Establece el nombre del botón
            btn.Enabled = false; // Deshabilita el botón inicialmente
            btn.AutoSize = true;
            this.Controls.Add(btn); // Añade el botón al formulario
                                    // iPosicionInicial++; // Ya no es necesario incrementar iPosicionInicial aquí
        }

        // Función que crea un TextBox para números y lo añade al formulario
        void CrearTextBoxNumerico(String sNom, Point location)
        {
            TextBox tb = new TextBox(); // Crea un nuevo TextBox
            tb.Width = (int)(tb.Width * 1.2);
            tb.Height = (int)(tb.Height * 1.2);
            tb.Location = location; // Establece la ubicación del TextBox
            tb.Name = sNom; // Establece el nombre del TextBox
            this.Controls.Add(tb); // Añade el TextBox al formulario
            tb.KeyPress += ParaValidarNumeros_KeyPress; // Asigna la función de validación de números al evento KeyPress
                                                        // iPosicionInicial++; // Ya no es necesario incrementar iPosicionInicial aquí
        }

        //******************************************** CODIGO HECHO POR PABLO FLORES*****************************

        //******************************************** CODIGO HECHO POR EMANUEL BARAHONA*****************************

        // Función que crea un TextBox para texto de tipo varchar y lo añade al formulario
        void CrearTextBoxVarchar(String sNom, Point location)
        {
            TextBox tb = new TextBox();
            tb.Width = (int)(tb.Width * 1.2);
            tb.Height = (int)(tb.Height * 1.2);
            tb.Location = location;
            tb.Name = sNom;
            this.Controls.Add(tb);
            tb.KeyPress += ParaValidarVarchar_KeyPress; // Función para validar entrada de texto
        }


        // Función que crea un TextBox para la hora y lo añade al formulario
        void CrearCampoHora(String sNom, Point location)
        {
            TextBox tb = new TextBox(); // Crea un nuevo TextBox
            tb.Width = (int)(tb.Width * 1.2);
            tb.Height = (int)(tb.Height * 1.2);
            tb.Location = location; // Establece la ubicación del TextBox
            tb.Name = sNom; // Establece el nombre del TextBox
            this.Controls.Add(tb); // Añade el TextBox al formulario
            tb.KeyPress += ParaValidarHora_KeyPress; // Asigna la función de validación de hora al evento KeyPress
                                                     // iPosicionInicial++; // Ya no es necesario incrementar iPosicionInicial aquí
        }

        // Función que crea un TextBox para decimales y lo añade al formulario
        void CrearCampoDecimales(String sNom, Point location)
        {
            TextBox tb = new TextBox(); // Crea un nuevo TextBox
            tb.Width = (int)(tb.Width * 1.2);
            tb.Height = (int)(tb.Height * 1.2);
            tb.Location = location; // Establece la ubicación del TextBox
            tb.Name = sNom; // Establece el nombre del TextBox
            this.Controls.Add(tb); // Añade el TextBox al formulario
            tb.KeyPress += ParaValidarDecimales_KeyPress; // Asigna la función de validación de decimales al evento KeyPress
                                                          // iPosicionInicial++; // Ya no es necesario incrementar iPosicionInicial aquí
        }

        //******************************************** CODIGO HECHO POR EMANUEL BARAHONA*****************************

        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS*****************************

        // Estos métodos manejan eventos KeyPress para validar diferentes tipos de entradas en los controles.

        private void ParaValidarDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida que el input sea un número decimal.
            v.Camposdecimales(e);
        }

        private void ParaValidarNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida que el input sea un número entero.
            v.CamposNumericos(e);
        }

        private void ParaValidarHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida que el input siga el formato de hora.
            v.CamposHora(e);
        }

        private void ParaValidarVarchar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida que el input sea un texto tipo varchar.
            v.CamposVchar(e);
        }

        private void ParaValidarTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida que el input contenga solo letras.
            v.CamposLetras(e);
        }

        private void ParaValidarCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Maneja la validación del input en un ComboBox.
            v.Combobox(e);
        }


        // Este método crea y configura un ComboBox dinámicamente basado en los parámetros y la lógica del sistema.
        void CrearComboBox(string sNom, Point location)
        {
            ComboBox cb = new ComboBox();
            cb.Width = (int)(cb.Width * 1.2);
            cb.Height = (int)(cb.Height * 1.2);
            cb.Location = location;
            cb.Name = sNom;

            // Obtener la tabla, campo clave y campo display usando los arreglos de combo
            if (arrTablaCombo[iNumeroCombosAux] != null)
            {
                string tabla = arrTablaCombo[iNumeroCombosAux];
                string campoClave = arrCampoCombo[iNumeroCombosAux];
                string campoDisplay = arrCampoDisplayCombo[iNumeroCombosAux];
                Console.WriteLine($"Tabla relacionada: {tabla}, Campo Clave: {campoClave}, Campo Display: {campoDisplay}");
                Console.WriteLine($"Tabla relacionada: {tabla}");
                // Obtener los datos de la lógica del sistema para la tabla y los campos
                Dictionary<string, string> dicItems = logic.Items(tabla, campoClave, campoDisplay);

                // Si se encuentran datos, asignarlos al ComboBox
                if (dicItems != null && dicItems.Count > 0)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dicItems;

                    cb.DataSource = bs;
                    cb.DisplayMember = "Value";  // Mostrar el campo descriptivo
                    cb.ValueMember = "Key";      // Usar el campo clave como valor
                }
                else
                {
                    // Manejar el caso en que no se encuentran datos
                    Console.WriteLine($"No se encontraron datos para la tabla: {tabla}, clave: {campoClave}, display: {campoDisplay}");
                }

                // Incrementar el índice de combos
                if (iNumeroCombos > iNumeroCombosAux) { iNumeroCombosAux++; }
            }
            else
            {
                // Manejar el caso en que no se encontró la tabla en arrTablaCombo
                Console.WriteLine($"Error: no se encontró tabla para el combo con nombre: {sNom}");
            }

            // Añadir el ComboBox al formulario
            this.Controls.Add(cb);
        }
        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS*****************************

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ***************************** 
        void CrearDateTimePicker(String sNom, Point location)
        {
            DateTimePicker dtp = new DateTimePicker(); // Crea un nuevo DateTimePicker
            dtp.Width = (int)(dtp.Width * 1.2);
            dtp.Height = (int)(dtp.Height * 1.2);
            dtp.Location = location; // Establece la ubicación del DateTimePicker
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "yyyy-MM-dd";
            dtp.Width = 100;
            dtp.Name = sNom; // Establece el nombre del DateTimePicker
            this.Controls.Add(dtp); // Añade el DateTimePicker al formulario
                                    // iPosicionInicial++; // Ya no es necesario incrementar iPosicionInicial aquí
        }
        public void Deshabilitarcampos_y_botones()
        {
            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox || componente is Button)
                {
                    componente.Enabled = false; // De esta manera bloqueamos todos los TextBox, DateTimePicker y ComboBox
                }
            }
            if (IngresarVariosControl != null && IngresarVariosControl.DataGridViewInformacionExtra != null)
            {
                IngresarVariosControl.DataGridViewInformacionExtra.Enabled = false;
                IngresarVariosControl.DataGridViewInformacionExtra.Rows.Clear(); // Limpiar filas solo de la DataGridView extra
            }
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Guardar.Enabled = false;
            Btn_Cancelar.Enabled = false;
        }

        public void HabilitarCampos_y_Botones()
        {
            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox || componente is Button)
                {
                    componente.Enabled = true; // Habilita todos los TextBox, DateTimePicker y ComboBox para edición
                }
            }
            // Btn_Modificar.Enabled = true;
           Btn_Eliminar.Enabled = true;
           Btn_Guardar.Enabled = true;
           Btn_Cancelar.Enabled = true;
        }

        public void ActualizarDataGridView()
        {
            // Pasar todas las relaciones foráneas a la capa lógica
            DataTable dt = logic.ConsultaLogica(sTablaPrincipal, relacionesForaneas);
            Dgv_Informacion.DataSource = dt;

            // Asignar los alias como encabezados de las columnas
            int iHead = 0;
            while (iHead < logic.ContarCampos(sTablaPrincipal))
            {
                Dgv_Informacion.Columns[iHead].HeaderText = arrAliasCampos[iHead];
                iHead++;
            }
        }

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ***************************** 


        //******************************************** CODIGO HECHO POR MATY MANCILLA*****************************

        // Este método genera una consulta SQL para "eliminar" un registro de la base de datos.
        // En lugar de eliminar físicamente el registro, se actualiza el campo 'estado' a 0, lo que indica que está inactivo.
        string CrearDelete(string sNombreTabla, bool esTablaAdicional)
        {
            // Inicia la construcción de la consulta SQL con la instrucción UPDATE para la tabla especificada.
            string sQuery = "UPDATE " + sNombreTabla + " SET estado=0";

            // Esta variable construye la cláusula WHERE de la consulta SQL.
            string sWhereQuery = " WHERE ";
            bool claveAsignada = false;

            // Verifica si es la tabla principal (no es una tabla adicional)
            if (!esTablaAdicional)
            {
                foreach (Control componente in Controls)
                {
                    // Considera TextBox, DateTimePicker y ComboBox
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        // Si el componente tiene un nombre que sugiere que es la clave primaria
                        if (componente.Name.Contains("Pk") && !string.IsNullOrEmpty(componente.Text))
                        {
                            // Construye la cláusula WHERE usando el nombre del componente como campo y su valor como condición
                            sWhereQuery += componente.Name + " = '" + componente.Text + "' ";
                            claveAsignada = true;
                            Console.WriteLine($"Clave primaria detectada: {componente.Name} = {componente.Text}");
                            break; // Ya que solo necesitamos una clave primaria, salimos del bucle
                        }
                    }
                }
            }

            // Si no se asignó ninguna clave, evita crear la consulta
            if (!claveAsignada)
            {
                Console.WriteLine($"Advertencia: No se pudo asignar una clave principal para la tabla {sNombreTabla}.");
                return null;
            }

            // Elimina posibles espacios y comas al final de las cadenas.
            sWhereQuery = sWhereQuery.TrimEnd(' ');

            // Completar la construcción de la consulta SQL uniendo la cláusula WHERE.
            sQuery += sWhereQuery + ";";

            // Imprimir la consulta en la consola para depuración.
            Console.WriteLine($"Consulta generada para la tabla principal {sNombreTabla}: {sQuery}");

            // Retornar la consulta construida.
            return sQuery;
        }

        string CrearDeleteExtras(string sNombreTabla)
        {
            // Inicia la construcción de la consulta SQL con la instrucción UPDATE para la tabla especificada.
            string sQuery = "UPDATE " + sNombreTabla + " SET estado=0";

            // Esta variable construye la cláusula WHERE de la consulta SQL.
            string sWhereQuery = " WHERE ";
            bool claveAsignada = false;

            // Verificar si hay alias definidos para esta tabla
            if (aliasPorTabla.ContainsKey(sNombreTabla))
            {
                string[] alias = aliasPorTabla[sNombreTabla];

                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        string nombreCampo = componente.Name.Replace("extra_", "");

                        // Depuración para ver si estamos encontrando el campo
                        Console.WriteLine($"Buscando campo: {nombreCampo}");

                        if (alias.Contains(nombreCampo))
                        {
                            Console.WriteLine($"Campo encontrado: {nombreCampo}, valor: {componente.Text}");

                            // Añadir la condición al WHERE con un AND si ya hay otras condiciones
                            if (claveAsignada)
                            {
                                sWhereQuery += " AND ";
                            }
                            sWhereQuery += nombreCampo + " = '" + componente.Text + "' ";
                            claveAsignada = true;
                        }
                    }
                }
            }

            // Si no se asignó ninguna clave, evitar crear la consulta
            if (!claveAsignada)
            {
                Console.WriteLine($"Advertencia: No se pudo asignar una clave principal o clave foránea para la tabla {sNombreTabla}.");
                return null;
            }

            // Completar la construcción de la consulta SQL uniendo la cláusula WHERE.
            sQuery += sWhereQuery + ";";

            // Imprimir la consulta en la consola para depuración.
            Console.WriteLine($"Consulta generada para tabla adicional {sNombreTabla}: {sQuery}");

            // Retornar la consulta construida.
            return sQuery;
        }

        //******************************************** CODIGO HECHO POR MATY MANCILLA*****************************

        //******************************************** CODIGO HECHO POR JOEL LOPEZ***************************** 
        string CrearInsert(string sNombreTabla)
        {

            // Inicializa las cadenas para la consulta INSERT y los valores a insertar
            string sQuery = "INSERT INTO " + sNombreTabla + " (";
            string sValores = "VALUES (";

            string sCampos = "";
            string sValoresCampos = "";

            // Obtén la lista de campos de la tabla desde la lógica
            string[] arrCamposTabla = logic.Campos(sNombreTabla);
            int iPosicionCampo = 0;

            // Recorre todos los controles del formulario
            foreach (Control componente in Controls)
            {
                // Ignora los componentes que tienen el prefijo "extra_"
                if (componente.Name.StartsWith("extra_"))
                {
                    continue; // Saltar al siguiente control
                }

                // Solo procesar si es un componente relevante: TextBox, DateTimePicker, ComboBox o Button
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox || componente is Button)
                {
                    // Obtén el nombre del campo que se supone que coincide con la tabla
                    if (iPosicionCampo < arrCamposTabla.Length)
                    {
                        string sNombreCampo = arrCamposTabla[iPosicionCampo];
                        string sValorCampo = string.Empty;

                        // Si el control es un ComboBox, obtiene el valor seleccionado (ID)
                        if (componente is ComboBox cb)
                        {
                            sValorCampo = cb.SelectedValue?.ToString() ?? ""; // Asegúrate de que no sea nulo
                        }
                        else if (componente is Button btn)
                        {
                            // Si el botón define el estado, asigna '0' o '1' según el texto del botón
                            sValorCampo = (btn.Text == "Activado") ? "1" : "0";
                        }
                        else if (componente is DateTimePicker dtp)
                        {
                            sValorCampo = dtp.Value.ToString("yyyy-MM-dd");
                        }
                        else if (componente is TextBox)
                        {
                            sValorCampo = componente.Text;
                        }

                        // Solo agrega el campo y el valor si no está vacío
                        if (!string.IsNullOrEmpty(sValorCampo))
                        {
                            sCampos += sNombreCampo + ", ";
                            sValoresCampos += "'" + sValorCampo + "', ";
                        }

                        iPosicionCampo++;
                    }
                }
            }

            // Elimina las últimas comas y cierra las instrucciones
            sCampos = sCampos.TrimEnd(' ', ',');
            sValoresCampos = sValoresCampos.TrimEnd(' ', ',');

            // Verifica si el número de columnas y valores coinciden antes de construir la consulta
            if (sCampos.Split(',').Length != sValoresCampos.Split(',').Length)
            {
                Console.WriteLine("Error: El número de columnas no coincide con el número de valores.");
                return null; // Retorna nulo para indicar que hay un error en la construcción
            }

            sQuery += sCampos + ") " + sValores + sValoresCampos + ");";

            return sQuery;
        }
        string CrearInsertParaAsociativas(string nombreTabla, Dictionary<string, string> valoresCampos)
        {

            if (string.IsNullOrEmpty(nombreTabla))
            {
                throw new ArgumentException("El nombre de la tabla no puede estar vacío.");
            }

            string sQuery = $"INSERT INTO {nombreTabla} (";
            string sValores = "VALUES (";

            string sCampos = "";
            string sValoresCampos = "";

            foreach (var campo in valoresCampos)
            {
                string tipoCampo = logic.ObtenerTipoCampo(nombreTabla, campo.Key);

                // Agregar el campo al string de campos
                sCampos += campo.Key + ", ";

                // Verificar si el campo es numérico o no
                if (tipoCampo.Contains("int") || tipoCampo.Contains("decimal"))
                {
                    // Validar que el valor sea numérico
                    if (!int.TryParse(campo.Value, out _) && !decimal.TryParse(campo.Value, out _))
                    {
                        Console.WriteLine($"Error: El campo {campo.Key} debe contener un valor numérico.");
                        return null;
                    }
                    // No agregar comillas para campos numéricos
                    sValoresCampos += $"{campo.Value}, ";
                }
                else
                {
                    // Agregar comillas para campos no numéricos (strings, fechas, etc.)
                    sValoresCampos += $"'{campo.Value}', ";
                }
            }

            // Eliminar la última coma
            sCampos = sCampos.TrimEnd(' ', ',');
            sValoresCampos = sValoresCampos.TrimEnd(' ', ',');

            sQuery += sCampos + ") " + sValores + sValoresCampos + ");";

            return sQuery;
        }

        private string RealizarOperacionPorFila(string valorOrigen, string valorCondicional, OperacionCampo operacion)
        {
            try
            {
                // Obtener el valor actual del campo destino en la base de datos
                string valorDestino = logic.ObtenerValorCampo(
                    operacion.TablaDestino,
                    operacion.CampoDestino,
                    operacion.CampoCondicional,
                    valorCondicional
                );

                // Convertir los valores de origen y destino al tipo numérico adecuado
                int valorNumOrigen = int.Parse(valorOrigen);
                int valorNumDestino = string.IsNullOrEmpty(valorDestino) ? 0 : int.Parse(valorDestino); // Usar 0 si está vacío

                // Realizar la operación especificada
                int resultadoOperacion = 0;
                switch (operacion.Operacion.ToLower())
                {
                    case "copiar":
                        resultadoOperacion = valorNumOrigen;
                        break;
                    case "sumar":
                        resultadoOperacion = valorNumDestino + valorNumOrigen;
                        break;
                    case "restar":
                        resultadoOperacion = valorNumDestino - valorNumOrigen;
                        if (resultadoOperacion < 0)
                        {
                            Console.WriteLine("Error: El resultado de la resta no puede ser negativo.");
                            return null; // Devuelve null si la operación no es válida
                        }
                        break;
                    default:
                        Console.WriteLine("Operación no reconocida.");
                        return null; // Devuelve null si la operación no es válida
                }

                // Generar la consulta de actualización
                string updateQuery = $"UPDATE {operacion.TablaDestino} SET {operacion.CampoDestino} = {resultadoOperacion} WHERE {operacion.CampoCondicional} = '{valorCondicional}'";
                Console.WriteLine("OPERACION FILA: " + updateQuery);
                return updateQuery; // Devuelve la consulta generada
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al realizar la operación en la fila: {ex.Message}");
                return null; // Devuelve null si hay un error
            }
        }
        List<string> lstQueries2 = new List<string>();
        List<string> CrearInsertDesdeDataGridView(string sNombreTabla, string idForaneo, DataGridView dgvProductos)
        {
            List<string> lstQueries = new List<string>();
            var columnasPropiedades = logic.ObtenerColumnasYPropiedadesLogica(sNombreTabla);
            string sClaveForanea = logic.ObtenerClaveForanea(sNombreTabla, sTablaPrincipal);

            if (!columnasPropiedades.Any(c => c.nombreColumna == sClaveForanea))
            {
                Console.WriteLine($"Error: La clave foránea {sClaveForanea} no existe en los campos de {sNombreTabla}.");
                return null;
            }

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.IsNewRow) continue;

                // Procesa las operaciones para la fila actual sin duplicarlas
                foreach (var operacion in listaOperaciones)
                {
                    string valorOrigen = fila.Cells[operacion.CampoOrigen]?.Value?.ToString() ?? "0";
                    string valorCondicional = fila.Cells[operacion.ValorCondicional]?.Value?.ToString();

                    if (!string.IsNullOrEmpty(valorOrigen) && !string.IsNullOrEmpty(valorCondicional))
                    {
                        // Ejecutar la operación y obtener la consulta
                        string updateQuery = RealizarOperacionPorFila(valorOrigen, valorCondicional, operacion);

                        if (updateQuery == null)
                        {
                            MessageBox.Show("Error en las operaciones de campos para esta fila. No se completará la inserción.", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null; // Cancelar si hay un error en la operación
                        }

                        // Agregar la consulta de actualización a la lista sin duplicar
                        if (!lstQueries.Contains(updateQuery))
                        {
                            lstQueries.Add(updateQuery);
                        }
                    }
                }

                // Construir la consulta de inserción para la fila en la tabla `sNombreTabla`
                string sQuery = $"INSERT INTO {sNombreTabla} ({sClaveForanea}, ";
                string sValores = $"VALUES ('{idForaneo}', ";
                bool hasValues = false;

                foreach (var (nombreColumna, esAutoIncremental, esClaveForanea, esTinyInt) in columnasPropiedades)
                {
                    if (esAutoIncremental || nombreColumna == sClaveForanea) continue;

                    if (dgvProductos.Columns.Contains(nombreColumna))
                    {
                        DataGridViewCell celda = fila.Cells[nombreColumna];
                        string sValorCampo = "";

                        if (esTinyInt && celda is DataGridViewButtonCell)
                        {
                            sValorCampo = (celda.Style.BackColor == Color.Green) ? "1" : "0";
                        }
                        else
                        {
                            sValorCampo = celda?.Value?.ToString() ?? "";
                        }

                        if (!string.IsNullOrEmpty(sValorCampo))
                        {
                            sQuery += $"{nombreColumna}, ";
                            sValores += $"'{sValorCampo}', ";
                            hasValues = true;
                        }
                    }
                }

                if (hasValues)
                {
                    sQuery = sQuery.TrimEnd(' ', ',') + ") ";
                    sValores = sValores.TrimEnd(' ', ',') + ");";
                    string fullQuery = sQuery + sValores;
                    Console.WriteLine("CONSULTA GENERADA PARA GRID: " + fullQuery);
                    lstQueries.Add(fullQuery);
                }
            }

            return lstQueries;
        }

        string CrearInsertDesdeControles(string sNombreTabla, string idForaneo)
        {

            var columnasPropiedades = logic.ObtenerColumnasYPropiedadesLogica(sNombreTabla);
            string sClaveForanea = logic.ObtenerClaveForanea(sNombreTabla, sTablaPrincipal);

            if (!columnasPropiedades.Any(c => c.nombreColumna == sClaveForanea))
            {
                Console.WriteLine($"Error: La clave foránea {sClaveForanea} no existe en los campos de {sNombreTabla}.");
                return null;
            }

            string sQuery = $"INSERT INTO {sNombreTabla} ({sClaveForanea}, ";
            string sValores = $"VALUES ('{idForaneo}', ";
            bool hasValues = false;

            foreach (var (nombreColumna, esAutoIncremental, esClaveForanea, esTinyInt) in columnasPropiedades)
            {
                if (esAutoIncremental || nombreColumna == sClaveForanea) continue;

                Control control = Controls.Find("extra_" + nombreColumna, true).FirstOrDefault();

                if (control != null)
                {
                    string sValorCampo = "";

                    if (control is TextBox textBox)
                        sValorCampo = textBox.Text;
                    else if (control is ComboBox comboBox)
                        sValorCampo = comboBox.SelectedValue?.ToString() ?? "";
                    else if (control is DateTimePicker dateTimePicker)
                        sValorCampo = dateTimePicker.Value.ToString("yyyy-MM-dd");
                    else if (control is Button button && esTinyInt) // Detecta si el control es un botón y es tinyint
                    {
                        // Asigna "1" si el botón está verde (activado) y "0" si está rojo (desactivado)
                        sValorCampo = (button.BackColor == Color.Green) ? "1" : "0";
                    }

                    if (!string.IsNullOrEmpty(sValorCampo))
                    {
                        sQuery += $"{nombreColumna}, ";
                        sValores += $"'{sValorCampo}', ";
                        hasValues = true;
                    }
                }
            }

            if (hasValues)
            {
                sQuery = sQuery.TrimEnd(' ', ',') + ") ";
                sValores = sValores.TrimEnd(' ', ',') + ");";
                string fullQuery = sQuery + sValores;
                Console.WriteLine("CONSULTA GENERADA SIN GRID: " + fullQuery);
                return fullQuery;
            }

            return null;
        }
        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ***************************** 
        private IEnumerable<Control> GetAllControls(Control container)
        {
            // Función recursiva para obtener todos los controles, incluyendo los anidados
            foreach (Control control in container.Controls)
            {
                foreach (Control child in GetAllControls(control))
                {
                    yield return child;
                }
                yield return control;
            }
        }


        string CrearUpdate(string sTablaPrincipal, string sNombreClavePrimaria)
        {
            string[] arrColumnasTabla = logic.Campos(sTablaPrincipal);
            string sQuery = "UPDATE " + sTablaPrincipal + " SET ";
            string sWhereQuery = " WHERE ";
            string sCampos = "";
            int valor = 0;

            // Utiliza la nueva función para obtener solo los controles relevantes
            foreach (Control componente in GetRelevantControls(this))
            {
                if (componente.Name.StartsWith("extra_"))
                {
                    continue; // Ignora los componentes que tienen el prefijo "extra_"
                }

                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox || componente is Button)
                {
                    string sNombreCampo = componente.Name;
                    if (arrColumnasTabla.Contains(sNombreCampo) && sNombreCampo != sNombreClavePrimaria)
                    {
                        string sValorCampo = ObtenerValorDelComponente(componente, ref valor);
                        if (!string.IsNullOrEmpty(sValorCampo))
                        {
                            sCampos += $"{sNombreCampo} = '{sValorCampo}', ";
                        }
                    }
                }
            }

            if (string.IsNullOrEmpty(sCampos))
            {
                Console.WriteLine($"No hay campos para actualizar en la tabla {sTablaPrincipal}");
                return null;
            }

            sCampos = sCampos.TrimEnd(' ', ',');
            string sValorClave = Dgv_Informacion.CurrentRow.Cells[0].Value.ToString();
            sWhereQuery += $"{sNombreClavePrimaria} = '{sValorClave}'";
            sQuery += sCampos + sWhereQuery + ";";
            Console.WriteLine("Consulta generada para el UPDATE: " + sQuery);

            return sQuery;
        }

        string CrearUpdateParaTablasExtras(string sTablaAdicional, string sNombreClavePrimaria, string sNombreClaveForanea)
        {
            string[] arrColumnasTabla = logic.Campos(sTablaAdicional);
            string sQuery = "UPDATE " + sTablaAdicional + " SET ";
            string sWhereQuery = " WHERE ";
            string sCampos = "";
            int valor = 0;

            // Lista para mantener un registro de los campos que ya se han procesado
            HashSet<string> camposProcesados = new HashSet<string>();

            foreach (Control componente in GetRelevantControls(this))
            {
                if (componente.Name.StartsWith("extra_"))
                {
                    string sNombreCampo = componente.Name.Replace("extra_", "");
                    if (arrColumnasTabla.Contains(sNombreCampo) && sNombreCampo != sNombreClavePrimaria && sNombreCampo != sNombreClaveForanea)
                    {
                        // Verifica si el campo ya fue procesado
                        if (!camposProcesados.Contains(sNombreCampo))
                        {
                            string sValorCampo = ObtenerValorDelComponente(componente, ref valor);
                            if (!string.IsNullOrEmpty(sValorCampo))
                            {
                                sCampos += $"{sNombreCampo} = '{sValorCampo}', ";
                                camposProcesados.Add(sNombreCampo); // Marca el campo como procesado
                            }
                        }
                        else
                        {
                            Console.WriteLine($"El campo {sNombreCampo} ya ha sido procesado, se ignora para evitar duplicados.");
                        }
                    }
                }
            }

            if (string.IsNullOrEmpty(sCampos))
            {
                Console.WriteLine($"No hay campos para actualizar en la tabla {sTablaAdicional}");
                return null;
            }

            sCampos = sCampos.TrimEnd(' ', ',');
            string sValorClave = Dgv_Informacion.CurrentRow.Cells[0].Value.ToString();
            sWhereQuery += $"{sNombreClaveForanea} = '{sValorClave}'";
            sQuery += sCampos + sWhereQuery + ";";
            Console.WriteLine("Consulta generada para el UPDATE en tabla adicional: " + sQuery);

            return sQuery;
        }

        private string ObtenerValorDelComponente(Control componente, ref int valor)
        {
            string sValorCampo = "";
            if (componente is ComboBox cb)
            {
                Console.WriteLine($"Procesando ComboBox: {componente.Name}, Valor actual: {valor}, Tamaño de comboData: {comboData.Count}");
                if (valor < comboData.Count) // Verificar que el índice esté dentro del rango
                {
                    var comboInfo = comboData[valor];
                    string sTabla = comboInfo.Item1;
                    string sCampoClave = comboInfo.Item2;
                    string sCampoDisplay = comboInfo.Item3;
                    sValorCampo = logic.ObtenerValorClaveDesdeLogica(sTabla, sCampoClave, sCampoDisplay, cb.Text);
                    valor++;
                }
                else
                {
                    Console.WriteLine($"Índice fuera de rango: {valor} en comboData para la tabla relacionada.");
                }
            }
            else if (componente is DateTimePicker dtp)
            {
                sValorCampo = dtp.Value.ToString("yyyy-MM-dd");
            }
            else if (componente is TextBox)
            {
                sValorCampo = componente.Text;
            }
            else if (componente is Button btn)
            {
                sValorCampo = (btn.Text == "Activado") ? "1" : "0";
            }

            return sValorCampo;
        }


        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ***************************** 

        //******************************************** CODIGO HECHO POR PABLO FLORES***************************** 
        public void GuardadoForsozo()
        {
            // Ejecuta la consulta de inserción generada y limpia los campos del formulario
            logic.NuevoQuery(CrearInsert(sTablaPrincipal)); 
            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    componente.Enabled = true;
                    componente.Text = "";
                }
            }
            ActualizarDataGridView();
        }

        public void HabilitarTodosBotones() // Habilita todos los botones
        {
            Btn_Guardar.Enabled = true;
            Btn_Ingresar.Enabled = true;
            Btn_Modificar.Enabled = true;
            Btn_Cancelar.Enabled = false;
            Btn_Eliminar.Enabled = true;
        }

        private IEnumerable<Control> GetRelevantControls(Control container)
        {
            // Función recursiva para obtener solo los controles relevantes (TextBox, ComboBox, DateTimePicker, y Button) que estén relacionados con las tablas.
            foreach (Control control in container.Controls)
            {
                // Filtra solo los controles relevantes que utilizas en tus formularios
                if (control is TextBox || control is ComboBox || control is DateTimePicker || control is Button)
                {
                    // Verifica que el control tenga un prefijo relevante (por ejemplo, 'extra_' para tablas adicionales o sin prefijo para la tabla principal)
                    if (control.Name.StartsWith("extra_") || IsControlForPrincipalTable(control))
                    {
                        yield return control;
                    }
                }

                // Llamada recursiva para los controles hijos
                foreach (Control child in GetRelevantControls(control))
                {
                    yield return child;
                }
            }
        }

        private bool IsControlForPrincipalTable(Control control)
        {
            return !control.Name.StartsWith("extra_");
        }
        //******************************************** CODIGO HECHO POR PABLO FLORES***************************** 

        //-----------------------------------------------Funcionalidad de Botones-----------------------------------------------//

        //******************************************** CODIGO HECHO POR DIEGO MARROQUIN***************************** 
        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            string[] arrTipos = logic.Tipos(sTablaPrincipal);
            string[] arrLlaves = logic.Llaves(sTablaPrincipal);
            bool bTipoInt = false;
            string sAuxId = "";
            int iAuxLastId = 0;

            if (arrTipos[0].Contains("int") && arrLlaves[0] == "PRI")
            {
                bTipoInt = true;
                sAuxId = logic.UltimoID(sTablaPrincipal);
                iAuxLastId = !string.IsNullOrEmpty(sAuxId) ? Int32.Parse(sAuxId) : 0;
            }

            iActivar = 2;
            HabilitarCampos_y_Botones();

            foreach (Control componente in Controls)
            {
                string nombreComponente = componente.Name.Replace("extra_", "");

                if (componente is TextBox && bTipoInt && nombreComponente == arrLlaves[0])
                {
                    iAuxLastId += 1;
                    componente.Text = iAuxLastId.ToString();
                    componente.Enabled = false;
                }
                else if (componente.Name.StartsWith("extra_"))
                {
                    componente.Enabled = true;
                    if (componente is TextBox || componente is ComboBox || componente is DateTimePicker)
                    {
                        componente.Text = "";
                    }
                }
                else if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    componente.Enabled = true;
                    componente.Text = "";
                }
            }

            if (IngresarVariosControl != null)
            {
                IngresarVariosControl.Btn_agregar.Enabled = true;
                IngresarVariosControl.Btn_quitar.Enabled = true;

                IngresarVariosControl.DataGridViewInformacionExtra.Enabled = false;
                IngresarVariosControl.DataGridViewInformacionExtra.Rows.Clear();
            }

            Btn_Ingresar.Enabled = false;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Cancelar.Enabled = true;

           //BotonesYPermisosSinMensaje();
        }


        //******************************************** CODIGO HECHO POR DIEGO MARROQUIN***************************** 

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Muestra un mensaje de confirmación antes de proceder con la modificación
                DialogResult drResult = MessageBox.Show(
                    "Está a punto de modificar un registro existente.\n\n" +
                    "Asegúrese de que todos los datos sean correctos antes de continuar.\n\n" +
                    "¿Desea proceder con la modificación de este registro?",
                    "Confirmación de Modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                );

                // Si el usuario selecciona "No", se cancela la operación
                if (drResult == DialogResult.No)
                {
                    return;
                }

                // Habilita campos para edición
                HabilitarCampos_y_Botones();
                Btn_Modificar.Enabled = false;
                iActivar = 1; // Define que se realizará una modificación
                int iIndice = 0;

                string[] arrTipos = logic.Tipos(sTablaPrincipal);
                int iNumCombo = 0;

                // Verifica que la fila seleccionada en el DataGridView no sea null
                if (Dgv_Informacion.CurrentRow == null)
                {
                    MessageBox.Show("No hay ninguna fila seleccionada en el DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Recorre los controles para habilitar la edición
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        // Verifica que iIndice esté dentro del rango antes de acceder a la celda
                        if (iIndice < Dgv_Informacion.CurrentRow.Cells.Count)
                        {
                            // Deshabilita el campo del ID si es entero (autoincremental)
                            if (iIndice == 0 && arrTipos[0] == "int")
                            {
                                componente.Enabled = false;
                            }
                            else
                            {
                                if (componente is ComboBox comboBox)
                                {
                                    if (arrModoCampoCombo[iNumCombo] == 1)
                                    {
                                        string valorLlave = logic.LlaveCampoRev(arrTablaCombo[iNumCombo], arrCampoCombo[iNumCombo], Dgv_Informacion.CurrentRow.Cells[iIndice].Value.ToString());

                                        // Verifica que el valor asignado no sea vacío o nulo
                                        if (!string.IsNullOrEmpty(valorLlave))
                                        {
                                            comboBox.Text = valorLlave;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Valor vacío o nulo en la celda {iIndice} para el ComboBox.");
                                        }
                                    }
                                    else
                                    {
                                        // Asigna el valor directamente si no requiere revisión con `LlaveCampoRev`
                                        comboBox.Text = Dgv_Informacion.CurrentRow.Cells[iIndice].Value.ToString();
                                    }

                                    iNumCombo++; // Incrementa el contador de ComboBox
                                }
                                else
                                {
                                    // Asigna el texto para los demás controles (TextBox, DateTimePicker, etc.)
                                    componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndice].Value.ToString();
                                }
                            }

                            iIndice++; // Incrementa el índice solo si se ha accedido a una celda válida
                        }
                        else
                        {
                            Console.WriteLine($"El índice {iIndice} está fuera del rango de las celdas disponibles en el DataGridView.");
                            break; // Sale del bucle si el índice está fuera de rango
                        }
                    }

                    if (componente is Button)
                    {
                        // No incrementar iIndice para los botones, ya que no están vinculados a una celda
                        if (iIndice < Dgv_Informacion.CurrentRow.Cells.Count)
                        {
                            string sEstadoRegistro = Dgv_Informacion.CurrentRow.Cells[iIndice].Value.ToString();

                            if (sEstadoRegistro == "0")
                            {
                                componente.Text = "Desactivado";
                                componente.BackColor = Color.Red;
                                iEstadoFormulario = 0;
                            }
                            else if (sEstadoRegistro == "1")
                            {
                                componente.Text = "Activado";
                                componente.BackColor = Color.Green;
                                iEstadoFormulario = 1;
                            }

                            componente.Enabled = true;

                            // Solo incrementar el índice si el botón está vinculado a una celda (en caso de que esté)
                            iIndice++;
                        }
                        else
                        {
                            Console.WriteLine($"El índice {iIndice} está fuera del rango al configurar el botón.");
                            break; // Sale del bucle si el índice está fuera de rango
                        }
                    }
                }

                // Habilita y deshabilita botones según el usuario
               BotonesYPermisosSinMensaje();

                Btn_Ingresar.Enabled = false;
                Btn_Eliminar.Enabled = false;
                Btn_Cancelar.Enabled = true;
            }
            catch (Exception ex)
            {
                // Manejo de errores y muestra un mensaje más profesional
                MessageBox.Show(
                    "Ocurrió un error durante la modificación del registro.\n\n" +
                    "Detalles del error: " + ex.Message + "\n\n" +
                    "Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Error en la Modificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }


        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ*****************************


        //******************************************** CODIGO HECHO POR JORGE AVILA***************************** 
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                lg.funinsertarabitacora(sIdUsuario, "Se presionó el botón cancelar en " + sTablaPrincipal, sTablaPrincipal, sIdAplicacion);

                DialogResult drResult = MessageBox.Show(
                    "Está a punto de cancelar los cambios no guardados.\n\n" +
                    "Cualquier dato ingresado se perderá.\n\n" +
                    "¿Desea realmente cancelar la operación?",
                    "Confirmación de Cancelación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                );

                if (drResult == DialogResult.No)
                {
                    return;
                }

                //Btn_Modificar.Enabled = true;
                Btn_Guardar.Enabled = false;
                Btn_Cancelar.Enabled = false;
                Btn_Ingresar.Enabled = true;
                Btn_Eliminar.Enabled = true;
                Btn_Refrescar.Enabled = true;
                Deshabilitarcampos_y_botones();
                ActualizarDataGridView();
                if (logic.TestRegistros(sTablaPrincipal) > 0)
                {
                    int iIndice = 0;
                    int iNumCombo = 0;

                    foreach (Control componente in Controls)
                    {
                        if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                        {
                            // Verificación adicional para evitar que iIndice exceda el número de columnas en Dgv_Informacion
                            if (Dgv_Informacion.CurrentRow != null && iIndice < Dgv_Informacion.ColumnCount)
                            {
                                if (componente is ComboBox)
                                {
                                    if (arrModoCampoCombo[iNumCombo] == 1)
                                    {
                                        componente.Text = logic.LlaveCampoRev(arrTablaCombo[iNumCombo], arrCampoCombo[iNumCombo], Dgv_Informacion.CurrentRow.Cells[iIndice].Value.ToString());
                                    }
                                    else
                                    {
                                        componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndice].Value.ToString();
                                    }
                                    iNumCombo++;
                                }
                                else
                                {
                                    componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndice].Value.ToString();
                                }
                                componente.Enabled = false;
                                iIndice++;
                            }
                            else
                            {
                                Console.WriteLine($"El índice {iIndice} está fuera del rango al configurar el componente.");
                                break; // Termina el bucle si el índice excede el número de columnas
                            }
                        }
                        if (componente is Button)
                        {
                            // Verificación adicional para evitar que iIndice exceda el número de columnas en Dgv_Informacion
                            if (Dgv_Informacion.CurrentRow != null && iIndice < Dgv_Informacion.ColumnCount)
                            {
                                string sEstadoRegistro = Dgv_Informacion.CurrentRow.Cells[iIndice].Value.ToString();
                                if (sEstadoRegistro == "0")
                                {
                                    componente.Text = "Desactivado";
                                    componente.BackColor = Color.Red;
                                }
                                else if (sEstadoRegistro == "1")
                                {
                                    componente.Text = "Activado";
                                    componente.BackColor = Color.Green;
                                }
                                componente.Enabled = false;
                            }
                            else
                            {
                                Console.WriteLine($"El índice {iIndice} está fuera del rango al configurar el botón.");
                                break; // Termina el bucle si el índice excede el número de columnas
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error durante el proceso de cancelación.\n\n" +
                    "Detalles del error: " + ex.Message + "\n\n" +
                    "Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Error en Cancelación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //******************************************** CODIGO HECHO POR JORGE AVILA ***************************** 

        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS***************************** 
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar un mensaje de confirmación antes de proceder con la eliminación
                DialogResult drRespuestaEliminar = MessageBox.Show(
                    "Está a punto de eliminar (desactivar) este registro y sus datos relacionados en todas las tablas.\n\n" +
                    "¿Está seguro de que desea continuar?",
                    "Confirmación de Eliminación - " + sNombreFormulario,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2 // Opción "No" predeterminada
                );

                if (drRespuestaEliminar == DialogResult.Yes)
                {
                    // Eliminar el registro en la tabla principal
                    string sQueryPrincipal = CrearDelete(sTablaPrincipal, false);
                    logic.NuevoQuery(sQueryPrincipal);
                    string sLlavePrimaria = logic.ObtenerClavePrimaria(sTablaPrincipal);
                    // Iterar sobre las tablas adicionales y cambiar el estado en cada una
                  

                    // Actualizar el DataGridView y mostrar un mensaje de éxito
                    ActualizarDataGridView();
                    MessageBox.Show(
                        "El registro y sus datos relacionados han sido eliminados correctamente en todas las tablas.",
                        "Eliminación Exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Restablecer el estado de los botones
                    Deshabilitarcampos_y_botones();
                    lg.funinsertarabitacora(sIdUsuario, "Se actualizó el estado en " + sTablaPrincipal, sTablaPrincipal, sIdAplicacion);
                }
                else if (drRespuestaEliminar == DialogResult.No)
                {
                    // Si el usuario cancela la operación de eliminación
                    MessageBox.Show(
                        "La eliminación ha sido cancelada.",
                        "Operación Cancelada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Mantener el estado de los botones
                    Deshabilitarcampos_y_botones();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores con un mensaje más profesional
                MessageBox.Show(
                    "Ocurrió un error durante el proceso de eliminación del registro.\n\n" +
                    "Detalles del error: " + ex.Message + "\n\n" +
                    "Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Error en la Eliminación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS***************************** 


        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS***************************** 
        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {
            try
            {
                // Refrescar la DataGridView y actualizar los controles
                ActualizarDataGridView();

                // Iterar sobre los controles y actualizar sus valores con los datos del DataGridView
                int iIndex = 0;
                int iNumCombo = 0;
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (componente is ComboBox)
                        {
                            if (arrModoCampoCombo[iNumCombo] == 1) // Cambiado numCombo a iNumCombo
                            {
                                componente.Text = logic.LlaveCampoRev(arrTablaCombo[iNumCombo], arrCampoCombo[iNumCombo], Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString());
                            }
                            else
                            {
                                componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                            }
                            iNumCombo++; 
                        }
                        else
                        {
                            componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                        }

                        iIndex++;
                    }
                    if (componente is Button)
                    {
                        string sVarEstado = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString(); 
                        if (sVarEstado == "0")
                        {
                            componente.Text = "Desactivado";
                            componente.BackColor = Color.Red;
                        }
                        if (sVarEstado == "1")
                        {
                            componente.Text = "Activado";
                            componente.BackColor = Color.Green;
                        }
                        componente.Enabled = false;
                    }
                }

                // Habilitar y deshabilitar botones según permisos del usuario
                BotonesYPermisosSinMensaje();

                // Mostrar mensaje de éxito al refrescar los datos
                MessageBox.Show(
                    "Los datos han sido actualizados correctamente.",
                    "Refrescado Exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                // Manejo de errores y mostrar un mensaje más profesional
                MessageBox.Show(
                    "Ocurrió un error al refrescar los datos.\n\n" +
                    "Detalles del error: " + ex.Message + "\n\n" +
                    "Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Error al Refrescar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Este método maneja el evento de clic en el botón "Anterior".
        private void Btn_Anterior_Click(object sender, EventArgs e)
        {
            int iIndex = 0;
            string[] arrCampos = logic.Campos(sTablaPrincipal); 

            int iFila = Dgv_Informacion.SelectedRows[0].Index; 

            if (iFila > 0)
            {
                Dgv_Informacion.Rows[iFila - 1].Selected = true; 
                Dgv_Informacion.CurrentCell = Dgv_Informacion.Rows[iFila - 1].Cells[0];

                int iNumCombo = 0;
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (componente is ComboBox)
                        {
                            if (arrModoCampoCombo[iNumCombo] == 1) 
                            {
                                componente.Text = logic.LlaveCampoRev(arrTablaCombo[iNumCombo], arrCampoCombo[iNumCombo], Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString());
                            }
                            else
                            {
                                componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                            }
                            iNumCombo++; 
                        }
                        else
                        {
                            componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                        }
                        iIndex++;
                    }
                    if (componente is Button)
                    {
                        string sVarEstado = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString(); 
                        if (sVarEstado == "0")
                        {
                            componente.Text = "Desactivado";
                            componente.BackColor = Color.Red;
                        }
                        if (sVarEstado == "1")
                        {
                            componente.Text = "Activado";
                            componente.BackColor = Color.Green;
                        }
                        componente.Enabled = false;
                    }
                }
            }
        }

        // Este método maneja el evento de clic en el botón "Siguiente".
        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            int iIndex = 0;
            string[] arrCampos = logic.Campos(sTablaPrincipal); 

            int iFila = Dgv_Informacion.SelectedRows[0].Index; 

            if (iFila < Dgv_Informacion.Rows.Count - 1)
            {
                Dgv_Informacion.Rows[iFila + 1].Selected = true; 
                Dgv_Informacion.CurrentCell = Dgv_Informacion.Rows[iFila + 1].Cells[0]; 

                int iNumCombo = 0; 
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (componente is ComboBox)
                        {
                            if (arrModoCampoCombo[iNumCombo] == 1) 
                            {
                                componente.Text = logic.LlaveCampoRev(arrTablaCombo[iNumCombo], arrCampoCombo[iNumCombo], Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString());
                            }
                            else
                            {
                                componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                            }
                            iNumCombo++;
                        }
                        else
                        {
                            componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                        }
                        iIndex++;
                    }
                    if (componente is Button)
                    {
                        string sVarEstado = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                        if (sVarEstado == "0")
                        {
                            componente.Text = "Desactivado";
                            componente.BackColor = Color.Red;
                        }
                        if (sVarEstado == "1")
                        {
                            componente.Text = "Activado";
                            componente.BackColor = Color.Green;
                        }
                        componente.Enabled = false;
                    }
                }
            }
        }


        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ*****************************




        //******************************************** CODIGO HECHO POR JOEL LOPEZ***************************** 

        // Este método maneja el evento de clic del botón "Flecha Fin" para moverse al último registro visible en el DataGridView.
        private void Btn_FlechaFin_Click(object sender, EventArgs e)
        {
            // Selecciona la penúltima fila (contando desde cero) en el DataGridView y la establece como la fila actual.
            Dgv_Informacion.Rows[Dgv_Informacion.Rows.Count - 2].Selected = true;
            Dgv_Informacion.CurrentCell = Dgv_Informacion.Rows[Dgv_Informacion.Rows.Count - 2].Cells[0];

            int iIndex = 0;
            // Obtiene los nombres de las columnas de la sTablaPrincipal en la base de datos.
            string[] arrCampos = logic.Campos(sTablaPrincipal); 

            // Obtiene el índice de la fila actualmente seleccionada en el DataGridView.
            int iFila = Dgv_Informacion.SelectedRows[0].Index; 
            if (iFila < Dgv_Informacion.Rows.Count - 1)
            {
                // Vuelve a seleccionar la penúltima fila para asegurarse de que es la fila correcta.
                Dgv_Informacion.Rows[Dgv_Informacion.Rows.Count - 2].Selected = true;
                Dgv_Informacion.CurrentCell = Dgv_Informacion.Rows[Dgv_Informacion.Rows.Count - 2].Cells[0];

                int iNumCombo = 0; 
                 // Itera sobre todos los controles en el formulario.
                foreach (Control componente in Controls)
                {
                    // Si el control es un TextBox, DateTimePicker o ComboBox, actualiza su valor con el valor correspondiente de la celda seleccionada en el DataGridView.
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (componente is ComboBox)
                        {
                            // Para los ComboBox, se verifica si el campo es clave externa (arrModoCampoCombo) y se obtiene el valor adecuado.
                            if (arrModoCampoCombo[iNumCombo] == 1) 
                            {
                                componente.Text = logic.LlaveCampoRev(arrTablaCombo[iNumCombo], arrCampoCombo[iNumCombo], Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString());
                            }
                            else
                            {
                                componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                            }
                            iNumCombo++; // Cambiado numCombo a iNumCombo
                        }
                        else
                        {
                            componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                        }
                        iIndex++;
                    }
                    // Si el control es un botón, se actualiza su estado dependiendo del valor de la celda en la fila seleccionada.
                    if (componente is Button)
                    {
                        string sVarEstado = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString(); // Cambiado var1 a sVarEstado
                        if (sVarEstado == "0")
                        {
                            componente.Text = "Desactivado";
                            componente.BackColor = Color.Red;
                        }
                        if (sVarEstado == "1")
                        {
                            componente.Text = "Activado";
                            componente.BackColor = Color.Green;
                        }
                        componente.Enabled = false;
                    }
                }
            }
        }


        
        // Este método maneja el evento de clic del botón "Flecha Inicio" para moverse al primer registro en el DataGridView.
        private void Btn_FlechaInicio_Click(object sender, EventArgs e)
        {
            // Selecciona la primera fila en el DataGridView y la establece como la fila actual.
            Dgv_Informacion.Rows[0].Selected = true;
            Dgv_Informacion.CurrentCell = Dgv_Informacion.Rows[0].Cells[0];

            int iIndex = 0;
            // Obtiene los nombres de las columnas de la sTablaPrincipal en la base de datos.
            string[] arrCampos = logic.Campos(sTablaPrincipal);

            int iFila = Dgv_Informacion.SelectedRows[0].Index;
            if (iFila < Dgv_Informacion.Rows.Count - 1)
            {
                // Vuelve a seleccionar la primera fila para asegurarse de que es la fila correcta.
                Dgv_Informacion.Rows[0].Selected = true;
                Dgv_Informacion.CurrentCell = Dgv_Informacion.Rows[0].Cells[0];

                int iNumCombo = 0;
                                   // Itera sobre todos los controles en el formulario.
                foreach (Control componente in Controls)
                {
                    // Si el control es un TextBox, DateTimePicker o ComboBox, actualiza su valor con el valor correspondiente de la celda seleccionada en el DataGridView.
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (componente is ComboBox)
                        {
                            // Para los ComboBox, se verifica si el campo es clave externa (arrModoCampoCombo) y se obtiene el valor adecuado.
                            if (arrModoCampoCombo[iNumCombo] == 1) 
                            {
                                componente.Text = logic.LlaveCampoRev(arrTablaCombo[iNumCombo], arrCampoCombo[iNumCombo], Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString());
                            }
                            else
                            {
                                componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                            }
                            iNumCombo++;
                        }
                        else
                        {
                            componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                        }
                        iIndex++;
                    }
                    // Si el control es un botón, se actualiza su estado dependiendo del valor de la celda en la fila seleccionada.
                    if (componente is Button)
                    {
                        string sVarEstado = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                        if (sVarEstado == "0")
                        {
                            componente.Text = "Desactivado";
                            componente.BackColor = Color.Red;
                        }
                        if (sVarEstado == "1")
                        {
                            componente.Text = "Activado";
                            componente.BackColor = Color.Green;
                        }
                        componente.Enabled = false;
                    }
                }
            }
        }

        //******************************************** CODIGO HECHO POR ANIKA ESCOTO *****************************

        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS *****************************

        // Este método configura los botones del formulario en función de los permisos del usuario, sin mostrar mensajes.
        public void BotonesYPermisosSinMensaje()
        {
            try
            {
                // Lista de nombres de permisos que corresponden a las acciones posibles.
                string[] arrPermisosText = { "INGRESAR", "BUSCAR", "MODIFICAR", "ELIMINAR", "IMPRIMIR" };
                // Lista de botones en el formulario que se habilitarán o deshabilitarán según los permisos del usuario.
                Button[] arrBotones = { Btn_Ingresar, Btn_Consultar, Btn_Modificar, Btn_Eliminar, Btn_Imprimir };

                for (int iIndex = 0; iIndex < arrPermisosText.Length; iIndex++)
                {
                    // Consulta el ID del usuario actual.
                    string sIdUsuario1 = logic.ObtenerIdUsuario(sIdUsuario);
                    
                    // Verifica si el usuario tiene permiso para la acción correspondiente.
                    bool bTienePermiso = lg.ConsultarPermisos(sIdUsuario1, sIdAplicacion, iIndex + 1);

                    // Si el botón existe (no es nulo), se habilita o deshabilita según los permisos del usuario.
                    if (arrBotones[iIndex] != null)
                    {
                        arrBotones[iIndex].Enabled = bTienePermiso;
                    }
                }
            }
            catch (Exception ex)
            {
                // En caso de error, se muestra un mensaje en la consola con los detalles del error.
                Console.WriteLine("Error al configurar los botones y permisos: " + ex.Message);
                // Opcionalmente, se podría registrar el error en un archivo de log.
            }
        }


        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS *****************************


        //******************************************** CODIGO HECHO POR JOSUE CACAO *****************************

        // Este método configura los botones del formulario basándose en los permisos del usuario y muestra un mensaje con los botones habilitados y deshabilitados.
        public void BotonesYPermisos()
        {
            try
            {
                // Definición de los nombres de los permisos y sus correspondientes botones en el formulario.
                string[] arrPermisosText = { "INGRESAR", "BUSCAR", "MODIFICAR", "ELIMINAR", "IMPRIMIR" };
                Button[] arrBotones = { Btn_Ingresar, Btn_Consultar, Btn_Modificar, Btn_Eliminar, Btn_Imprimir };

                string sBotonesPermitidos = "";   // Variable para almacenar los botones que el usuario tiene permiso de usar.
                string sBotonesNoPermitidos = ""; // Variable para almacenar los botones que el usuario no tiene permiso de usar.

                for (int iIndex = 0; iIndex < arrPermisosText.Length; iIndex++)
                {
                    // Obtiene el ID del usuario actual.
                    string sIdUsuario1 = logic.ObtenerIdUsuario(sIdUsuario);
                    
                    // Consulta si el usuario tiene el permiso correspondiente.
                    bool bTienePermiso = lg.ConsultarPermisos(sIdUsuario1, sIdAplicacion, iIndex + 1);

                    if (arrBotones[iIndex] != null)
                    {
                        arrBotones[iIndex].Enabled = bTienePermiso; // Habilita o deshabilita el botón según el permiso.

                        if (arrBotones[iIndex].Enabled)
                        {
                            // Si el botón está habilitado, se agrega a la lista de botones permitidos.
                            sBotonesPermitidos += arrPermisosText[iIndex] + ", ";
                        }
                        else
                        {
                            // Si el botón está deshabilitado, se agrega a la lista de botones no permitidos.
                            sBotonesNoPermitidos += arrPermisosText[iIndex] + ", ";
                        }
                    }
                    else
                    {
                        // Si el botón no se encuentra, se agrega a la lista de botones no permitidos.
                        sBotonesNoPermitidos += arrPermisosText[iIndex] + ", ";
                    }
                }

                // Formateo del mensaje final que se mostrará al usuario.
                string sMensaje = "";

                if (!string.IsNullOrEmpty(sBotonesPermitidos))
                {
                    sMensaje += "Botones permitidos: " + sBotonesPermitidos.TrimEnd(',', ' ') + ".\n";
                }

                if (!string.IsNullOrEmpty(sBotonesNoPermitidos))
                {
                    sMensaje += "Botones no permitidos: " + sBotonesNoPermitidos.TrimEnd(',', ' ') + ".";
                }

                if (!string.IsNullOrEmpty(sMensaje))
                {
                    // Muestra un único MessageBox con el resumen de los botones permitidos y no permitidos.
                    MessageBox.Show(sMensaje);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores, mostrando un mensaje en caso de que algo salga mal al configurar los botones.
                MessageBox.Show("Error al configurar los botones y permisos: " + ex.Message);
            }
        }


        //******************************************** CODIGO HECHO POR JOSUE CACAO *****************************

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ *****************************

        // Este método maneja el evento de clic del botón "Guardar", asegurando que los datos sean válidos y guardándolos en la base de datos.
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

            try
            {
                // Muestra un mensaje de confirmación antes de proceder con el guardado.
                DialogResult drResult = MessageBox.Show(
                    "Está a punto de guardar un nuevo registro en el sistema.\n\n" +
                    "Asegúrese de que toda la información ingresada sea correcta.\n\n" +
                    "¿Desea continuar con el guardado?",
                    "Confirmación de Guardado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (drResult == DialogResult.No)
                {
                    return;
                }

                // Verifica si todos los campos están llenos antes de proceder.
                bool bLleno = true;
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (string.IsNullOrEmpty(componente.Text))
                        {
                            bLleno = false;
                            break; // Si encuentra un campo vacío, sale del bucle.
                        }
                    }
                }

                if (!bLleno)
                {
                    MessageBox.Show(
                        "Por favor, complete todos los campos antes de guardar.\n\n" +
                        "El registro no se puede guardar mientras existan campos vacíos.",
                        "Campos Vacíos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                EjecutarReglasCondicionales();
                if (IngresarVariosControl != null && IngresarVariosControl.DataGridViewInformacionExtra != null)
                {
                    // Verifica si la grid extra está vacía
                    if (IngresarVariosControl.DataGridViewInformacionExtra.Rows.Count == 0 ||
     (IngresarVariosControl.DataGridViewInformacionExtra.Rows.Count == 1 && IngresarVariosControl.DataGridViewInformacionExtra.Rows[0].IsNewRow))
                    {
                        MessageBox.Show("Debe agregar al menos un registro en la tabla de detalles antes de guardar.",
                                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Salir del método y no continuar con el guardado
                    }
                    MessageBox.Show("esta llena");
                }

                // Verificar las operaciones de campo antes de cualquier inserción
                // Ejecutamos todas las operaciones de la lista de una sola vez




                // Lista para almacenar las consultas SQL que se ejecutarán.
                List<string> lstQueries = new List<string>();

                // Dependiendo del valor de "iActivar", se realiza una actualización o inserción.
                switch (iActivar)
                {
                    case 1: // Actualizar
                        try
                        {
                            // Obtener la clave primaria de la tabla principal
                            string sClavePrimariaPrincipal = logic.ObtenerClavePrimaria(sTablaPrincipal);
                            string sQueryPrincipal = CrearUpdate(sTablaPrincipal, sClavePrimariaPrincipal);

                            // Verificar que la consulta de la tabla principal no sea nula antes de agregarla
                            if (!string.IsNullOrEmpty(sQueryPrincipal))
                            {
                                lstQueries.Add(sQueryPrincipal); // Añade la consulta principal a la lista.
                            }

                            // Itera sobre las tablas adicionales para actualizar registros relacionados.
                            foreach (string sTablaAdicional in lstTablasAdicionales)
                            {
                                if (!string.IsNullOrEmpty(sTablaAdicional))
                                {
                                    string sClavePrimariaAdicional = logic.ObtenerClavePrimaria(sTablaAdicional);
                                    string sClaveForaneaAdicional = logic.ObtenerClaveForanea(sTablaAdicional, sTablaPrincipal);

                                    // Crear una consulta de actualización para la tabla adicional.
                                    // Nota: CrearUpdateParaTablasExtras se asegura de que solo se actualicen campos de la tabla adicional.
                                    string sQueryAdicional = CrearUpdateParaTablasExtras(sTablaAdicional, sClavePrimariaAdicional, sClaveForaneaAdicional);

                                    if (!string.IsNullOrEmpty(sQueryAdicional))
                                    {
                                        lstQueries.Add(sQueryAdicional); // Añade la consulta adicional a la lista.
                                    }
                                }
                            }

                            // Ejecuta las consultas para actualizar datos en múltiples tablas.
                            logic.InsertarDatosEnMultiplesTablas(lstQueries);
                            MessageBox.Show("El registro ha sido actualizado correctamente.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Inserta en la bitácora
                            lg.funinsertarabitacora(sIdUsuario, "Actualizó registro", sTablaPrincipal, sIdAplicacion);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ocurrió un error al actualizar los registros: {ex.Message}", "Error de Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case 2: // Insertar
                        try
                        {
                            if (!GenerarConsultasOperacionesIndividuales())
                            {
                                MessageBox.Show("Error en alguna de las operaciones de campos. No se completarán las inserciones.", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                lstQueries2.Clear();
                                Deshabilitarcampos_y_botones();
                                return;
                            }

                            // Generar la consulta de inserción para la tabla principal
                            string sQueryPrimeraTabla = CrearInsert(sTablaPrincipal);
                            if (string.IsNullOrEmpty(sQueryPrimeraTabla))
                            {
                                Console.WriteLine("Error: La consulta generada para la tabla principal es nula o vacía.");
                                MessageBox.Show("Error al generar la consulta principal. La inserción ha sido cancelada.", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            if (lstQueries2.Count > 0)
                            {
                                // Añadir consulta principal a la lista de queries
                                lstQueries2.Add(sQueryPrimeraTabla);
                                // Limpiar lstQueries2 después de la transacción
                                //MessageBox.Show("La transaccion se completo correctamente.", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                logic.InsertarDatosEnMultiplesTablas(lstQueries2);
                            }
                            else
                            {
                                logic.NuevoQuery(sQueryPrimeraTabla);
                                //MessageBox.Show("La transaccion  se completo correctamente.", "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            lstQueries2.Clear();
                            // Obtén el último ID insertado para utilizarlo en las tablas adicionales
                            string sUltimoIdPrimeraTabla = logic.UltimoID(sTablaPrincipal);
                            if (string.IsNullOrEmpty(sUltimoIdPrimeraTabla))
                            {
                                Console.WriteLine("Error: El último ID obtenido de la tabla principal es nulo o vacío.");
                                return;
                            }

                            // Registrar en la bitácora
                            lg.funinsertarabitacora(sIdUsuario, "Se insertó en " + sTablaPrincipal, sTablaPrincipal, sIdAplicacion);

                            // Lista para almacenar las consultas generadas


                            // Inserta en las tablas adicionales
                            foreach (string sTablaAdicional in lstTablasAdicionales)
                            {
                                DataGridView dgvProductos = (IngresarVariosControl != null && IngresarVariosControl.TablaVarios == sTablaAdicional)
                                                            ? IngresarVariosControl.DataGridViewInformacionExtra
                                                            : null;

                                if (dgvProductos != null)
                                {
                                    var queriesGrid = CrearInsertDesdeDataGridView(sTablaAdicional, sUltimoIdPrimeraTabla, dgvProductos);

                                    // Si alguna consulta falla, cancelar todo el proceso
                                    if (queriesGrid == null)
                                    {
                                        MessageBox.Show("Error en la generación de consultas para los datos adicionales. Transacción cancelada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        lstQueries.Clear(); // Limpiar todas las consultas para evitar inserciones parciales
                                        Deshabilitarcampos_y_botones(); // Restablecer el estado de los botones si es necesario
                                        return; // Cancelar la operación
                                    }

                                    // Agregar las consultas generadas a la lista principal de consultas
                                    lstQueries.AddRange(queriesGrid);
                                }
                                else
                                {
                                    string queryControles = CrearInsertDesdeControles(sTablaAdicional, sUltimoIdPrimeraTabla);
                                    if (!string.IsNullOrEmpty(queryControles)) lstQueries.Add(queryControles);
                                }
                            }

                            // Insertar en las tablas asociativas
                            foreach (var asociativa in diccionarioTablasAsociativas)
                            {
                                string nombreTablaAsociativa = asociativa.Key;
                                List<string> columnas = asociativa.Value;

                                Dictionary<string, string> valoresCampos = new Dictionary<string, string>();

                                for (int i = 0; i < columnas.Count; i += 2)
                                {
                                    string nombreCampo = columnas[i];
                                    string nombreComponente = columnas[i + 1];
                                    string valorCampo = ObtenerValorActualizar(nombreComponente);
                                    Console.WriteLine("VALOR COMPONENTE: " + nombreComponente + " VALOR: " + valorCampo);

                                    if (!string.IsNullOrEmpty(valorCampo))
                                    {
                                        valoresCampos[nombreCampo] = valorCampo;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Advertencia: No se pudo obtener un valor válido para el componente {nombreComponente}.");
                                    }
                                }

                                if (valoresCampos.Count == columnas.Count / 2)
                                {
                                    string sQueryAsociativa = CrearInsertParaAsociativas(nombreTablaAsociativa, valoresCampos);
                                    if (!string.IsNullOrEmpty(sQueryAsociativa))
                                    {
                                        lstQueries.Add(sQueryAsociativa);
                                        Console.WriteLine("QUERY GENERADO: " + sQueryAsociativa);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Error: No se pudieron obtener todos los valores para la tabla {nombreTablaAsociativa}.");
                                }
                            }

                            // Ejecutar todas las consultas en una sola transacción
                            logic.InsertarDatosEnMultiplesTablas(lstQueries);

                            MessageBox.Show("El registro ha sido guardado correctamente.", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error al guardar los registros: " + ex.Message);
                            MessageBox.Show($"Ocurrió un error al guardar los registros: {ex.Message}", "Error de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    default:
                        MessageBox.Show("Opción no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                // Actualiza la vista de datos y deshabilita los campos después de la operación.
                ActualizarDataGridView();
                Deshabilitarcampos_y_botones();
                BotonesYPermisosSinMensaje();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error durante el guardado del registro.\n\n" +
                    "Detalles del error: " + ex.Message + "\n\n" +
                    "Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Error en el Guardado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ *****************************




        //******************************************** CODIGO HECHO POR MATY MANCILLA *****************************

        // Este método maneja el evento de clic en una celda del DataGridView.
        // Cuando se hace clic en una celda, se actualizan los controles del formulario (TextBox, DateTimePicker, ComboBox, Button)
        // con los valores correspondientes de la fila seleccionada en el DataGridView.
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iIndex = 0;
            string primaryKeyValue = null;

            Console.WriteLine("Comenzando la asignación de componentes de la tabla principal...");

            // Asignar valores a los componentes de la tabla principal
            foreach (Control componente in Controls)
            {
                if (iIndex >= Dgv_Informacion.CurrentRow.Cells.Count)
                    break;

                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    Console.WriteLine($"Asignando valor al componente: {componente.Name}");
                    componente.Text = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                    Console.WriteLine($"Valor asignado: {Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString()}");

                    // Guardar la clave primaria si el nombre del componente la contiene
                    if (componente.Name.Contains("Pk"))
                    {
                        primaryKeyValue = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                        Console.WriteLine($"Clave primaria detectada: {primaryKeyValue}");
                    }

                    iIndex++;
                }
                else if (componente is Button) // Verificamos si el componente es un botón
                {
                    Console.WriteLine($"Asignando valor al botón: {componente.Name}");

                    string valorCelda = Dgv_Informacion.CurrentRow.Cells[iIndex].Value.ToString();
                    Console.WriteLine($"Valor asignado al botón: {valorCelda}");

                    // Verificar si el valor es 0 o 1 para cambiar el estado del botón
                    if (valorCelda == "1")
                    {
                        componente.Text = "Activado";
                        componente.BackColor = Color.Green;
                        Console.WriteLine($"Botón {componente.Name} activado (verde).");
                    }
                    else if (valorCelda == "0")
                    {
                        componente.Text = "Desactivado";
                        componente.BackColor = Color.Red;
                        Console.WriteLine($"Botón {componente.Name} desactivado (rojo).");
                    }

                    iIndex++;
                }

            }

            // Si se obtiene el valor de la clave primaria, consultar las tablas relacionadas
            if (!string.IsNullOrEmpty(primaryKeyValue))
            {
                Console.WriteLine("Llamando a LlenarComponentesExtraDinamico...");
                LlenarComponentesExtraDinamico(primaryKeyValue);
            }
            else
            {
                Console.WriteLine("No se detectó clave primaria.");
            }

            BotonesYPermisosSinMensaje();
        }

        private void LlenarComponentesExtraDinamico(string primaryKeyValue)
        {
            Console.WriteLine($"Procesando tablas adicionales para la clave primaria: {primaryKeyValue}");

            foreach (string tabla in lstTablasAdicionales)
            {
                Console.WriteLine($"Procesando tabla: {tabla}");

                if (!aliasPorTabla.ContainsKey(tabla))
                {
                    MessageBox.Show($"No hay alias definidos para la tabla: {tabla}");
                    continue;
                }

                string[] alias = aliasPorTabla[tabla];
                Console.WriteLine($"Alias encontrados para la tabla {tabla}: {string.Join(", ", alias)}");

                // Realizar la consulta a la tabla relacionada utilizando la clave primaria y obtener todos los registros
                List<Dictionary<string, string>> listaDatosExtra = logic.ObtenerDatosExtra(tabla, primaryKeyValue, sTablaPrincipal);
                Console.WriteLine($"Datos obtenidos de {tabla}: {listaDatosExtra?.Count} registros.");

                // Limpiar la DataGridView antes de asignar nuevos datos
                if (IngresarVariosControl != null && IngresarVariosControl.DataGridViewInformacionExtra != null)
                {
                    var dataGridView = IngresarVariosControl.DataGridViewInformacionExtra;
                    dataGridView.Rows.Clear(); // Limpia las filas existentes

                    // Si no se obtuvieron datos, asegurarse de que la DataGridView quede vacía y continuar con la siguiente tabla
                    if (listaDatosExtra == null || listaDatosExtra.Count == 0)
                    {
                        Console.WriteLine($"No se obtuvieron datos para la tabla {tabla}. La DataGridView quedará vacía.");
                        continue;
                    }

                    // Añadir filas solo si hay datos en listaDatosExtra
                    foreach (var datosExtra in listaDatosExtra)
                    {
                        int rowIndex = dataGridView.Rows.Add();
                        DataGridViewRow row = dataGridView.Rows[rowIndex];

                        foreach (string columna in alias)
                        {
                            if (datosExtra.ContainsKey(columna))
                            {
                                row.Cells[columna].Value = datosExtra[columna];
                            }
                        }
                    }
                }

                // Asignación a controles individuales (usando el primer registro solo como ejemplo)
                if (listaDatosExtra != null && listaDatosExtra.Count > 0)
                {
                    var datosPrimerRegistro = listaDatosExtra[0];
                    foreach (Control componente in Controls)
                    {
                        if (componente.Name.StartsWith("extra_"))
                        {
                            string nombreCampo = componente.Name.Replace("extra_", "");
                            Console.WriteLine($"Verificando componente {componente.Name} para el campo {nombreCampo}");

                            if (alias.Contains(nombreCampo) && datosPrimerRegistro.ContainsKey(nombreCampo))
                            {
                                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                                {
                                    componente.Text = datosPrimerRegistro[nombreCampo];
                                }
                                else if (componente is Button)
                                {
                                    string valor = datosPrimerRegistro[nombreCampo];
                                    if (valor == "1")
                                    {
                                        componente.Text = "Activado";
                                        componente.BackColor = Color.Green;
                                    }
                                    else if (valor == "0")
                                    {
                                        componente.Text = "Desactivado";
                                        componente.BackColor = Color.Red;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        // Método de placeholder, sin implementación.
        private void Contenido_Click(object sender, EventArgs e)
        {
            // Código a implementar
        }

        // Maneja el evento de clic en el botón de ayuda.
        private void Btn_Ayuda_Click_1(object sender, EventArgs e)
        {
            // Construye la ruta completa del archivo de ayuda
            string sRutaArchivoAyuda = AppDomain.CurrentDomain.BaseDirectory + @"..\..\AyudaHTML\AyudaNavegador.chm";

            // Normaliza la ruta para obtenerla de forma absoluta
            sRutaArchivoAyuda = System.IO.Path.GetFullPath(sRutaArchivoAyuda);

            // Verifica si el archivo de ayuda existe antes de intentar abrirlo
            if (System.IO.File.Exists(sRutaArchivoAyuda))
            {
                Help.ShowHelp(this, sRutaArchivoAyuda, "AyudaNav.html");
            }
            else
            {
                // Muestra un mensaje de error si el archivo de ayuda no se encuentra
                MessageBox.Show("No se encontró el archivo de ayuda: " + sRutaArchivoAyuda, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Maneja el evento de clic en un botón para obtener más ayuda.
        private void Btn_MasAyuda_Click(object sender, EventArgs e)
        {
            // Verifica la existencia de la tabla de ayuda
            string sAyudaOK = logic.TestTabla("ayuda");
            if (sAyudaOK == "")
            {
                // Si la tabla existe sin problemas, abre el formulario de ayuda
                Ayudas nuevo = new Ayudas();
                nuevo.Show();
            }
            else
            {
                // Si hay un problema con la tabla, muestra un mensaje de advertencia
                DialogResult drValidacion = MessageBox.Show(sAyudaOK + " \n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                if (drValidacion == DialogResult.OK)
                {
                    // Acción adicional si el usuario presiona OK (actualmente no implementada)
                }
            }
        }

        // Método de placeholder, sin implementación.
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Código a implementar
        }

        // Método de placeholder, sin implementación.
        private void LblTabla_Click(object sender, EventArgs e)
        {
            // Código a implementar
        }

        // Maneja el evento de clic en un botón (button7) y oculta el formulario actual.
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual.
        }

        // Maneja el evento de clic en el botón de imprimir.
        private void Btn_Imprimir_Click_1(object sender, EventArgs e)
        {
            // Se crea una instancia del controlador de reportería.
            Capa_Controlador_Reporteria.Controlador controlador = new Capa_Controlador_Reporteria.Controlador();

            // Se obtiene el ID de la aplicación.
            ObtenerIdAplicacion(sIdAplicacion);

            // Se consulta la ruta del reporte usando el ID de la aplicación.
            string sRuta = controlador.queryRuta(sIdAplicacion);

            // Si la ruta es válida, se abre el visor de reportes con la ruta obtenida.
            if (!string.IsNullOrEmpty(sIdAplicacion))
            {
                Capa_Vista_Reporteria.visualizar visualizar = new Capa_Vista_Reporteria.visualizar(sRuta);
                visualizar.ShowDialog(); // Muestra el reporte en un diálogo modal.
                lg.funinsertarabitacora(sIdUsuario, "Vio un reporte", sTablaPrincipal, sIdAplicacion);
            }
        }

        // Maneja el evento de clic en el botón principal de reportes.
        private void Btn_Reportes_Principal_Click(object sender, EventArgs e)
        {
            menu_reporteria reportes = new menu_reporteria();
            reportes.Show(); // Muestra el formulario del menú de reportes.
        }

        // Maneja el evento de clic en el botón de consulta.
        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            // Se obtiene el ID del usuario.
            string sIdUsuario1 = logic.ObtenerIdUsuario(sIdUsuario);

           
            ConsultaSimple nueva = new ConsultaSimple(sTablaPrincipal);
            nueva.Show();
            lg.funinsertarabitacora(sIdUsuario, "Entro a consultas", "consultas", sIdAplicacion);
            BotonesYPermisosSinMensaje();
        }


        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ *****************************


        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS *****************************

        // Este método maneja el evento de clic en el botón principal de reportes.
        // Abre el menú de reportería.
        private void Btn_Reportes_Principal_Click_1(object sender, EventArgs e)
        {
            // Se crea una instancia del formulario de menú de reportería.
            menu_reporteria reportes = new menu_reporteria();

            // Muestra el formulario del menú de reportería.
            reportes.Show();
            lg.funinsertarabitacora(sIdUsuario, "Abrio un reporte", sTablaPrincipal, sIdAplicacion);
        }

        // Este método maneja el evento de clic en el botón de ayuda (button1).
        // Abre el formulario de ayudas.
        private void Button1_Click(object sender, EventArgs e)
        {
            // Se crea una instancia del formulario de ayudas.
            Ayudas ayudas = new Ayudas();

            // Muestra el formulario de ayudas.
            ayudas.Show();
            lg.funinsertarabitacora(sIdUsuario, "Entro a los registros de ayuda", sTablaPrincipal, sIdAplicacion);
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // Verifica si se está en medio de una operación de guardado y se quiere salir sin finalizar.
                    if (Btn_Guardar.Enabled == true && Btn_Cancelar.Enabled == true && Btn_Eliminar.Enabled == false && Btn_Modificar.Enabled == false && Btn_Ingresar.Enabled == false)
                    {
                        foreach (Control componente in Controls)
                        {
                            // Si hay un TextBox con datos, pregunta al usuario si desea guardar antes de salir.
                            if (componente.Text != "" && componente is TextBox)
                            {
                                DialogResult drRespuestaGuardar = MessageBox.Show(
                                    "Se ha detectado una operación de guardado en curso.\n\n" +
                                    "¿Desea guardar los cambios antes de salir?",
                                    "Confirmación de Salida - " + sNombreFormulario,
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Warning
                                );

                                // Si el usuario elige "Yes", se guarda y luego se cierra el formulario.
                                if (drRespuestaGuardar == DialogResult.Yes)
                                {
                                    GuardadoForsozo();
                                    frmCerrar.Visible = false;
                                    lg.funinsertarabitacora(sIdUsuario, "Salio del Navegador", sTablaPrincipal, sIdAplicacion);
                                }
                                // Si el usuario elige "No", se cierra el formulario sin guardar.
                                else if (drRespuestaGuardar == DialogResult.No)
                                {
                                    frmCerrar.Visible = false;
                                }
                                // Si el usuario elige "Cancel", se cancela la salida y permanece en el formulario.
                                else if (drRespuestaGuardar == DialogResult.Cancel)
                                {
                                    return;
                                }
                            }
                        }
                    }

                    // Verifica si se está en medio de una operación de modificación y se quiere salir sin finalizar.
                    if (Btn_Modificar.Enabled == true && Btn_Guardar.Enabled == true && Btn_Cancelar.Enabled == true && Btn_Ingresar.Enabled == false)
                    {
                        foreach (Control componente in Controls)
                        {
                            // Si hay un TextBox con datos, pregunta al usuario si desea regresar y finalizar la operación antes de salir.
                            if (componente.Text != "" && componente is TextBox)
                            {
                                DialogResult drRespuestaModificar = MessageBox.Show(
                                    "Se ha detectado una operación de modificación en curso.\n\n" +
                                    "¿Desea regresar y finalizar la operación antes de salir?",
                                    "Confirmación de Salida - " + sNombreFormulario,
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Warning
                                );

                                // Si el usuario elige "Yes", se cancela la salida y permanece en el formulario.
                                if (drRespuestaModificar == DialogResult.Yes)
                                {
                                    return;
                                }
                                // Si el usuario elige "No", se cierra el formulario sin finalizar la modificación.
                                else if (drRespuestaModificar == DialogResult.No)
                                {
                                    frmCerrar.Visible = false;
                                }
                                // Si el usuario elige "Cancel", se cancela la salida y permanece en el formulario.
                                else if (drRespuestaModificar == DialogResult.Cancel)
                                {
                                    return;
                                }
                            }
                        }
                    }

                    // Verifica si se está en medio de una operación de eliminación y se quiere salir sin finalizar.
                    if (Btn_Eliminar.Enabled == true && Btn_Cancelar.Enabled == true && Btn_Modificar.Enabled == false && Btn_Guardar.Enabled == false && Btn_Ingresar.Enabled == false)
                    {
                        foreach (Control componente in Controls)
                        {
                            // Si hay un TextBox con datos, pregunta al usuario si desea regresar y finalizar la operación antes de salir.
                            if (componente.Text != "" && componente is TextBox)
                            {
                                DialogResult drRespuestaEliminar = MessageBox.Show(
                                    "Se ha detectado una operación de eliminación en curso.\n\n" +
                                    "¿Desea regresar y finalizar la operación antes de salir?",
                                    "Confirmación de Salida - " + sNombreFormulario,
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Warning
                                );

                                // Si el usuario elige "Yes", se cancela la salida y permanece en el formulario.
                                if (drRespuestaEliminar == DialogResult.Yes)
                                {
                                    return;
                                }
                                // Si el usuario elige "No", se cierra el formulario sin finalizar la eliminación.
                                else if (drRespuestaEliminar == DialogResult.No)
                                {
                                    frmCerrar.Visible = false;
                                }
                                // Si el usuario elige "Cancel", se cancela la salida y permanece en el formulario.
                                else if (drRespuestaEliminar == DialogResult.Cancel)
                                {
                                    return;
                                }
                            }
                        }
                    }

                    // Confirma finalmente si el usuario desea salir del formulario si no hay operaciones pendientes.
                    DialogResult drConfirmacionFinal = MessageBox.Show(
                        "¿Está seguro de que desea salir del formulario?",
                        "Confirmación de Salida",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    // Si el usuario confirma, cierra el formulario.
                    if (drConfirmacionFinal == DialogResult.Yes)
                    {
                        frmCerrar.Visible = false;
                    }
                    else
                    {
                        return; // Si el usuario decide quedarse, se cancela la salida.
                    }
                }
                catch (Exception ex)
                {
                    // En caso de error, muestra un mensaje al usuario con los detalles del error.
                    MessageBox.Show(
                        "Ocurrió un error al intentar salir del formulario.\n\n" +
                        "Detalles del error: " + ex.Message + "\n\n" +
                        "Por favor, intente nuevamente o contacte al administrador del sistema.",
                        "Error al Salir",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el directorio raíz del proyecto subiendo suficientes niveles
                string sProjectRootPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\.."));

                // Combinar la ruta base con la carpeta "Ayuda\AyudaHTML"
                string sAyudaPath = Path.Combine(sProjectRootPath, "Ayuda", "Ayuda_Navegador", sRutaAyuda);

                // Mostrar la ruta en un MessageBox antes de proceder
                //MessageBox.Show("Buscando archivo de ayuda en la ruta: " + ayudaPath, "Ruta de Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Verificar que el archivo de ayuda exista antes de intentar abrirlo
                if (File.Exists(sAyudaPath))
                {
                    // Mostrar la ayuda utilizando la ruta completa y el índice
                    Help.ShowHelp(this, sAyudaPath, sIndiceAyuda);
                    lg.funinsertarabitacora(sIdUsuario, "Vio un documento de ayuda", sTablaPrincipal, sIdAplicacion);
                }
                else
                {
                    // Mostrar un mensaje de error si el archivo de ayuda no se encuentra
                    MessageBox.Show("No se encontró el archivo de ayuda en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }

            BotonesYPermisosSinMensaje();
        }
        private void button_Paint(object sender, PaintEventArgs e)
        {
            BiselUtil.AplicarBisel(sender as Button, e);
        }

        private void Btn_Ingresar_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Tlp_Panel2_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = sender as Panel;

            // Color de la sombra (ajusta al color que prefieras)
            Color sombraColor = Color.Gray;

            // Dibujar sombra (parte inferior y derecha)
            int sombraTamaño = 5; // Tamaño de la sombra
            Rectangle shadowRect = new Rectangle(pnl.ClientRectangle.X + sombraTamaño,
                                                 pnl.ClientRectangle.Y + sombraTamaño,
                                                 pnl.ClientRectangle.Width,
                                                 pnl.ClientRectangle.Height);
            using (Brush shadowBrush = new SolidBrush(sombraColor))
            {
                e.Graphics.FillRectangle(shadowBrush, shadowRect);
            }

            // Dibujar bisel alrededor del panel
            ControlPaint.DrawBorder(e.Graphics, pnl.ClientRectangle,
                                    SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,  // Arriba
                                    SystemColors.ControlLightLight, 2, ButtonBorderStyle.Outset,  // Izquierda
                                    SystemColors.ControlDark, 3, ButtonBorderStyle.Inset,          // Derecha
                                    SystemColors.ControlDark, 3, ButtonBorderStyle.Inset);
        }

        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS *****************************
    }
}