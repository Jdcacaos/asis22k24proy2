﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Navegador;
using Capa_Datos_Navegador ;
using Capa_Controlador_Reporteria;
using Capa_Vista_Reporteria;
using Capa_Vista_Consulta;
using CapaDatos;


namespace Capa_Vista_Navegador
{
    public partial class Navegador : UserControl
    {
        Validaciones v = new Validaciones();
        logicaNav logic = new logicaNav();
        Form cerrar;
        int correcto = 0;
        string tabla = "def";
        string otratabla = "def";
        // Lista que contendrá los nombres de las tablas adicionales
        List<string> listaTablasAdicionales = new List<string>();

        string nomForm;
        int pos = 8;
        string idRepo = "";

        int[] modoCampoCombo = new int[40];
        int noCampos = 1;
        int x = 30;
        int y = 30;
        int activar = 0;    //Variable para reconocer que funcion realizara el boton de guardar (1. Ingresar, 2. Modificar, 3. Eliminar)
        string[] aliasC = new string[40];
        string[] tipoCampo = new string[30];//
        string[] tablaCombo = new string[30];
        string[] campoCombo = new string[30];
        string[] listaItems = new string[30];
        string[] campoDisplayCombo = new string[30];

        string tablarelacionada = "";
        string campodescriptivo = "";
        string columnaprimararelacionada = "";
        string columnaForanea = "";

        int posCombo = 10;
        int noCombo = 0;
        int noComboAux = 0;
        int estado = 1;
        Color Cfuente = Color.White;
        Color nuevoColor = Color.White;
        bool presionado = false;
        sentencia sn = new sentencia(); //objeto del componente de seguridad para obtener el método de la bitácora
        string idUsuario = "";
        string idAplicacion = "";
        //las siguientes dos variables son para el método botonesYPermisos();
        string userActivo = ""; //1
        string aplActivo = "";  //2
        string idyuda;
        string AsRuta;
        string AsIndice;
        string Asayuda = "";
        // string rutaa;
        Font fuente = new Font("Century Gothic", 13.0f, FontStyle.Regular, GraphicsUnit.Pixel); //objeto para definir el tipo y tamaño de fuente de los labels
        ToolTip ayuda_tp = new ToolTip();




        public Navegador()
        {
            InitializeComponent();
            limpiarListaItems();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            userActivo = idUsuario;
            aplActivo = idAplicacion;
            //Configuración del ToolTip
            ayuda_tp.IsBalloon = true;
            ayuda_tp.AutoPopDelay = 5000; // Mantener el ToolTip visible por 5 segundos
            ayuda_tp.InitialDelay = 1000; // Retraso de 1 segundo antes de que aparezca el ToolTip
            ayuda_tp.ReshowDelay = 500;   // Retraso de medio segundo antes de reaparecer
            ayuda_tp.ShowAlways = true;   // Mostrar el ToolTip siempre, incluso cuando el control no tiene el foco
            //ToolTips
            ayuda_tp.IsBalloon = true;
            ayuda_tp.SetToolTip(Btn_Ingresar, "Agregar un nuevo registro al sistema.");
            ayuda_tp.SetToolTip(Btn_Modificar, "Modificar el registro seleccionado.");
            ayuda_tp.SetToolTip(Btn_Guardar, "Guardar los cambios realizados.");
            ayuda_tp.SetToolTip(Btn_Cancelar, "Cancelar la operación actual.");
            ayuda_tp.SetToolTip(Btn_Eliminar, "Eliminar el registro seleccionado.");
            ayuda_tp.SetToolTip(Btn_Consultar, "Acceder a las consultas avanzadas.");
            ayuda_tp.SetToolTip(Btn_Refrescar, "Actualizar los datos de la tabla.");
            ayuda_tp.SetToolTip(Btn_FlechaInicio, "Ir al primer registro.");
            ayuda_tp.SetToolTip(Btn_Anterior, "Mover al registro anterior.");
            ayuda_tp.SetToolTip(Btn_Siguiente, "Mover al siguiente registro.");
            ayuda_tp.SetToolTip(Btn_FlechaFin, "Ir al último registro.");
            ayuda_tp.SetToolTip(Btn_Ayuda, "Ver la ayuda del formulario.");
            ayuda_tp.SetToolTip(Btn_Salir, "Cerrar el formulario actual.");
            ayuda_tp.SetToolTip(Btn_Imprimir, "Mostrar un Reporte");
            ayuda_tp.SetToolTip(button1, "Asignar Documento de Ayuda");
            ayuda_tp.SetToolTip(btn_Reportes_Principal, "Mostrar un Reporte");
        }
        private void Navegador_Load(object sender, EventArgs e)
        {
            colorDialog1.Color = nuevoColor;
            this.BackColor = colorDialog1.Color;
            botonesYPermisos();

            if (tabla != "def")
            {
                string TablaOK = logic.TestTabla(tabla);
                if (TablaOK == "" && correcto == 0)
                {
                    string EstadoOK = logic.TestEstado(tabla);
                    if (EstadoOK == "" && correcto == 0)
                    {
                        if (Asayuda == "0")
                        {
                            MessageBox.Show("No se encontró ningún registro en la tabla Ayuda");
                            Application.Exit();
                        }
                        else
                        {
                            if (numeroAlias() == logic.contarCampos(tabla))
                            {
                                int i = 0;
                                DataTable dt = logic.consultaLogica(tabla, tablarelacionada, campodescriptivo, columnaForanea, columnaprimararelacionada);
                                dataGridView1.DataSource = dt;
                                int head = 0;
                                while (head < logic.contarCampos(tabla))
                                {
                                    dataGridView1.Columns[head].HeaderText = aliasC[head];
                                    head++;
                                }
                                CreaComponentes();
                                colorTitulo();
                                lblTabla.ForeColor = Cfuente;
                                deshabilitarcampos_y_botones();

                                Btn_Modificar.Enabled = true;
                                Btn_Eliminar.Enabled = true;

                                //habilitar y deshabilitar según Usuario FUNCION SOLO PARA INICIO                                                                                               
                                if (logic.TestRegistros(tabla) > 0)
                                {
                                    int numCombo = 0;
                                    foreach (Control componente in Controls)
                                    {
                                        if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                                        {
                                            if (componente is ComboBox)
                                            {
                                                if (modoCampoCombo[numCombo] == 1)
                                                {
                                                    componente.Text = logic.llaveCampoRev(tablaCombo[numCombo], campoCombo[numCombo], dataGridView1.CurrentRow.Cells[i].Value.ToString());

                                                }
                                                else
                                                {
                                                    componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                                                }

                                                numCombo++;
                                            }
                                            else
                                            {
                                                componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                                            }

                                            i++;
                                        }
                                        if (componente is Button)
                                        {
                                            string var1 = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                                            if (var1 == "0")
                                            {
                                                componente.Text = "Desactivado";
                                                componente.BackColor = Color.Red;
                                            }
                                            if (var1 == "1")
                                            {
                                                componente.Text = "Activado";
                                                componente.BackColor = Color.Green;
                                            }
                                            componente.Enabled = false;

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
                                if (numeroAlias() < logic.contarCampos(tabla))
                                {
                                    DialogResult validacion = MessageBox.Show(EstadoOK + "El numero de Alias asignados es menor que el requerido \n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                                    if (validacion == DialogResult.OK)
                                    {
                                        Application.Exit();
                                    }
                                }
                                else
                                {
                                    if (numeroAlias() > logic.contarCampos(tabla))
                                    {
                                        DialogResult validacion = MessageBox.Show(EstadoOK + "El numero de Alias asignados es mayor que el requerido \n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                                        if (validacion == DialogResult.OK)
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
                        DialogResult validacion = MessageBox.Show(EstadoOK + "\n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                        if (validacion == DialogResult.OK)
                        {
                            Application.Exit();
                        }
                    }
                }
                else
                {
                    DialogResult validacion = MessageBox.Show(TablaOK + "\n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                    if (validacion == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
            }
        }

        //-----------------------------------------------Funciones-----------------------------------------------//

        void colorTitulo()
        {
            foreach (Control componente in Controls)
            {
                if (componente is Label)
                {

                    componente.ForeColor = Cfuente;
                }
            }
        }
        public void ObtenerIdUsuario(string idUsuario)
        {

            this.idUsuario = idUsuario;
        }
        public void asignarforaneas(string table, string tablarela, string campodescri, string columnafora, string columnaprimaria)
        {
            tabla = table;
            tablarelacionada = tablarela;
            campodescriptivo = campodescri;
            columnaForanea = columnafora;
            columnaprimararelacionada = columnaprimaria;




        }
        public void ObtenerIdAplicacion(string idAplicacion)
        {
            this.idAplicacion = idAplicacion;
        }
        private int numeroAlias()
        {
            int i = 0;
            foreach (string cad in aliasC)
            {
                if (cad != null && cad != "")
                {
                    i++;
                }
            }
            return i;
        }

        public string obtenerDatoTabla(int pos)
        {
            pos = pos - 1;
            return dataGridView1.CurrentRow.Cells[pos].Value.ToString();
        }

        public string obtenerDatoCampos(int pos)
        {
            int i = 0;
            pos = pos - 1;  // Ajuste del índice, ya que 'pos' es 1-based, pero los arrays son 0-based
            string dato = "";

            // Solo recorremos los controles relevantes: TextBox, DateTimePicker, ComboBox
            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    if (i == pos)  // Verificar si el índice coincide con el solicitado
                    {
                        // Obtener el valor del control según su tipo
                        if (componente is TextBox || componente is ComboBox)
                        {
                            dato = componente.Text;  // Para TextBox y ComboBox, tomamos el texto
                        }
                        else if (componente is DateTimePicker dateTimePicker)
                        {
                            dato = dateTimePicker.Value.ToString("yyyy-MM-dd");  // Formato de fecha
                        }
                        break;  // Una vez encontrado el campo, terminamos el ciclo
                    }
                    i++;  // Incrementar el índice solo si es un control relevante
                }
            }

            return dato;
        }

        public void asignarAlias(string[] alias)
        {
            alias.CopyTo(aliasC, 0);
        }

        public void asignarAyuda(string ayudar)
        {
            string AyudaOK = logic.TestTabla("ayuda");
            if (AyudaOK == "")
            {
                if (logic.contarRegAyuda(ayudar) > 0)
                {
                    idyuda = ayudar;
                    AsRuta = logic.MRuta(idyuda);
                    AsIndice = logic.MIndice(idyuda);
                    if (AsRuta == "" || AsIndice == "" || AsRuta == null || AsIndice == null)
                    {
                        DialogResult validacion = MessageBox.Show("La Ruta o índice de la ayuda está vacía", "Verificación de requisitos", MessageBoxButtons.OK);
                        if (validacion == DialogResult.OK)
                        {
                            correcto = 1;
                        }
                    }
                }
                else
                {
                    DialogResult validacion = MessageBox.Show("Por favor verifique el id de Ayuda asignado al form", "Verificación de requisitos", MessageBoxButtons.OK);
                    if (validacion == DialogResult.OK)
                    {
                        correcto = 1;
                    }
                }

            }
            else
            {
                DialogResult validacion = MessageBox.Show(AyudaOK + ", Por favor incluirla", "Verificación de requisitos", MessageBoxButtons.OK);
                if (validacion == DialogResult.OK)
                {
                    correcto = 1;
                }
            }
        }

        public void asignarReporte(string repo)
        {
            idRepo = repo;
        }
        public void asignarSalida(Form salida)
        {
            cerrar = salida;
        }
        public void asignarColorFuente(Color FuenteC)
        {

            Cfuente = FuenteC;
        }
        public void asignarTabla(string table)
        {
            tabla = table;
        }

        public void asignarTablas(List<string> tablas)
        {
            listaTablasAdicionales = tablas;
        }

        public void asignarNombreForm(string nom)
        {
            nomForm = nom;
            lblTabla.Text = nomForm;
        }

        public void asignarComboConTabla(string tabla, string campoClave, string campoDisplay, int modo)
        {
            // Verifica si la tabla existe
            string TablaOK = logic.TestTabla(tabla);
            if (TablaOK == "")
            {
                // Asigna los valores para el combo
                modoCampoCombo[noCombo] = modo;
                tablaCombo[noCombo] = tabla;
                campoCombo[noCombo] = campoClave; // Este será el valor subyacente (id_raza)
                campoDisplayCombo[noCombo] = campoDisplay; // Este será lo que se muestra (nombre_raza)
                noCombo++;
            }
            else
            {
                // Muestra error si la tabla o campo son incorrectos
                DialogResult validacion = MessageBox.Show(TablaOK + ", o el campo seleccionado\n para el ComboBox es incorrecto", "Verificación de requisitos", MessageBoxButtons.OK);
                if (validacion == DialogResult.OK)
                {
                    correcto = 1;
                }
            }
        }


        public void asignarColorFondo(Color nuevo)
        {
            nuevoColor = nuevo;
        }

        public void asignarComboConLista(int pos, string lista)
        {
            posCombo = pos - 1;
            limpiarLista(lista);
            modoCampoCombo[noCombo] = 0;
            noCombo++;
        }

        void limpiarLista(string cadena)
        {
            limpiarListaItems();
            int contadorCadena = 0;
            int contadorArray = 0;
            string palabra = "";
            while (contadorCadena < cadena.Length)
            {
                if (cadena[contadorCadena] != '|')
                {
                    palabra += cadena[contadorCadena];
                    contadorCadena++;
                }
                else
                {

                    listaItems[contadorArray] = palabra;
                    palabra = "";
                    contadorArray++;
                    contadorCadena++;
                }
            }
        }

        void limpiarListaItems()
        {
            for (int i = 0; i < listaItems.Length; i++)
            {
                listaItems[i] = "";
            }
        }


        void CreaComponentes()
        {
            string[] Campos = logic.campos(tabla);
            string[] Tipos = logic.tipos(tabla);
            string[] LLaves = logic.llaves(tabla);
            int i = 0;
            int fin = Campos.Length;
            while (i < fin)
            {
                if (noCampos == 6 || noCampos == 11 || noCampos == 16 || noCampos == 21) { pos = 8; }
                if (noCampos >= 6 && noCampos < 10) { x = 300; }
                if (noCampos >= 11 && noCampos < 15) { x = 600; }
                if (noCampos >= 16 && noCampos < 20) { x = 900; }
                if (noCampos >= 21 && noCampos < 25) { x = 900; }
                Label lb = new Label();

                lb.Text = aliasC[i];

                Point p = new Point(x + pos, y * pos);
                lb.Location = p;
                lb.Name = "lb_" + Campos[i];
                lb.Font = fuente;
                lb.ForeColor = Cfuente;
                this.Controls.Add(lb);

                if (LLaves[i] == "PRI" && i != 0)
                {
                    LLaves[i] = "MUL";
                }

                switch (Tipos[i])
                {
                    case "int":
                        tipoCampo[noCampos - 1] = "Num";
                        if (LLaves[i] != "MUL")
                        {
                            crearTextBoxnumerico(Campos[i]);
                        }
                        else
                        {
                            crearComboBox(Campos[i]);
                        }

                        break;
                    case "varchar":
                        tipoCampo[noCampos - 1] = "Text";

                        if (LLaves[i] != "MUL")
                        { crearTextBoxvarchar(Campos[i]); }
                        else { crearComboBox(Campos[i]); }
                        break;
                    case "date":
                        tipoCampo[noCampos - 1] = "Text";
                        if (LLaves[i] != "MUL")
                        { crearDateTimePicker(Campos[i]); }
                        else { crearComboBox(Campos[i]); }
                        break;

                    case "datetime":
                        tipoCampo[noCampos - 1] = "Text";
                        if (LLaves[i] != "MUL")
                        { crearDateTimePicker(Campos[i]); }
                        else { crearComboBox(Campos[i]); }
                        break;

                    case "text":
                        tipoCampo[noCampos - 1] = "Text";
                        if (LLaves[i] != "MUL")
                        { crearTextBoxvarchar(Campos[i]); }
                        else { crearComboBox(Campos[i]); }
                        break;
                    case "time":
                        tipoCampo[noCampos - 1] = "Text";
                        crearcampohora(Campos[i]);
                        break;

                    case "float":
                        tipoCampo[noCampos - 1] = "Text";
                        crearcampodecimales(Campos[i]);
                        break;

                    case "decimal":
                        tipoCampo[noCampos - 1] = "Text";
                        crearcampodecimales(Campos[i]);
                        break;

                    case "double":
                        tipoCampo[noCampos - 1] = "Text";
                        crearcampodecimales(Campos[i]);
                        break;



                    case "tinyint":
                        tipoCampo[noCampos - 1] = "Num";
                        if (LLaves[i] != "MUL")
                        {
                            crearBotonEstado(Campos[i]);
                        }
                        break;

                    default:

                        if (Tipos[i] != null && Tipos[i] != "")
                        {
                            DialogResult validacion = MessageBox.Show("La tabla " + tabla + " posee un campo " + Tipos[i] + ", este tipo de dato no es reconocido por el navegador\n Solucione este problema...", "Verificación de requisitos", MessageBoxButtons.OK);
                            if (validacion == DialogResult.OK)
                            {
                                Application.Exit();
                            }
                        }

                        break;
                }
                noCampos++;

                i++;
            }
        }
        void func_click(object sender, EventArgs e)
        {
            foreach (Control componente in Controls)
            {
                if (componente is Button)
                {
                    if (estado == 1)
                    {
                        componente.Text = "Desactivado";
                        componente.BackColor = Color.Red;
                        //estado++;
                        estado = 0;
                    }
                    else
                    {
                        componente.Text = "Activado";
                        componente.BackColor = Color.Green;
                        //estado++;
                        estado = 1;
                    }
                }
            }
        }
        void crearBotonEstado(String nom)
        {
            Button btn = new Button();
            Point p = new Point(x + 125 + pos, y * pos);
            btn.Location = p;
            btn.Text = "Activado";
            btn.BackColor = Color.Green;
            btn.Click += new EventHandler(func_click);
            btn.Name = nom;
            btn.Enabled = false;
            this.Controls.Add(btn);
            pos++;
        }
        void crearTextBoxnumerico(String nom)
        {


            TextBox tb = new TextBox();
            Point p = new Point(x + 125 + pos, y * pos);
            tb.Location = p;
            tb.Name = nom;
            this.Controls.Add(tb);
            tb.KeyPress += Paravalidarnumeros_KeyPress;
            this.KeyPress += Paravalidarnumeros_KeyPress;
            pos++;

        }

        void crearTextBoxvarchar(String nom)
        {
            TextBox tb = new TextBox();
            Point p = new Point(x + 125 + pos, y * pos);
            tb.Location = p;
            tb.Name = nom;
            this.Controls.Add(tb);
            tb.KeyPress += Paravalidarvarchar_KeyPress;
            this.KeyPress += Paravalidarvarchar_KeyPress;
            pos++;

        }


        void crearcampohora(String nom)
        {
            TextBox tb = new TextBox();
            Point p = new Point(x + 125 + pos, y * pos);
            tb.Location = p;
            tb.Name = nom;
            this.Controls.Add(tb);
            tb.KeyPress += Paravalidarhora_KeyPress;
            this.KeyPress += Paravalidarhora_KeyPress;
            //+= new System.Windows.Forms.KeyPressEventHandler(this.Txt_telefono_KeyPress);
            pos++;
        }


        void crearcampodecimales(String nom)
        {
            TextBox tb = new TextBox();
            Point p = new Point(x + 125 + pos, y * pos);
            tb.Location = p;
            tb.Name = nom;
            this.Controls.Add(tb);
            tb.KeyPress += Paravalidardecimales_KeyPress;
            this.KeyPress += Paravalidardecimales_KeyPress;
            //+= new System.Windows.Forms.KeyPressEventHandler(this.Txt_telefono_KeyPress);
            pos++;


        }

        private void Paravalidardecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Camposdecimales(e);
        }

        private void Paravalidarnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CamposNumericos(e);
        }

        private void Paravalidarhora_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CamposHora(e);
        }

        private void Paravalidarvarchar_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CamposVchar(e);
        }
        private void Paravalidartexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.CamposLetras(e);
        }
        private void Paravalidacombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.Combobox(e);
        }

        void crearComboBox(String nom)
        {
            // Obtener los items para el ComboBox (una lista de objetos clave-valor)
            Dictionary<string, string> items;
            if (tablaCombo[noComboAux] != null)
            {
                items = logic.items(tablaCombo[noComboAux], campoCombo[noComboAux], campoDisplayCombo[noComboAux]);
                if (noCombo > noComboAux) { noComboAux++; }
            }
            else
            {
                items = logic.items("Peliculas", "idPelicula", "nombrePelicula");
                if (noCombo > noComboAux) { noComboAux++; }
            }

            ComboBox cb = new ComboBox();
            Point p = new Point(x + 125 + pos, y * pos);
            cb.Location = p;
            cb.Name = nom;

            // Asignar el DataSource usando un BindingSource
            BindingSource bs = new BindingSource();
            bs.DataSource = items;

            cb.DataSource = bs;  // Asignar el DataSource al ComboBox
            cb.DisplayMember = "Value";  // Mostrar el nombre
            cb.ValueMember = "Key";      // Guardar el ID

            this.Controls.Add(cb);
            pos++;
        }




        void crearDateTimePicker(String nom)
        {
            DateTimePicker dtp = new DateTimePicker();
            Point p = new Point(x + 125 + pos, y * pos);
            dtp.Location = p;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.CustomFormat = "yyyy-MM-dd";
            dtp.Width = 100;
            dtp.Name = nom;
            this.Controls.Add(dtp);
            pos++;
        }

        public void deshabilitarcampos_y_botones()
        {
            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    componente.Enabled = false; //De esta menera bloqueamos todos los textbox por si solo quiere ver los registros

                }

            }
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;
            Btn_Guardar.Enabled = false;
            Btn_Cancelar.Enabled = false;

        }

        public void habilitarcampos_y_botones()
        {
            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    componente.Enabled = true; //De esta menera bloqueamos todos los textbox por si solo quiere ver los registros

                }

            }
            Btn_Modificar.Enabled = true;
            Btn_Eliminar.Enabled = true;
            Btn_Guardar.Enabled = true;
            Btn_Cancelar.Enabled = true;

        }

        public void actualizardatagriew()
        {

            DataTable dt = logic.consultaLogica(tabla, tablarelacionada, campodescriptivo, columnaForanea, columnaprimararelacionada);


            dataGridView1.DataSource = dt;
            int head = 0;
            while (head < logic.contarCampos(tabla))
            {
                dataGridView1.Columns[head].HeaderText = aliasC[head];
                head++;
            }
        }

        string crearDelete()// crea el query de delete
        {
            //Cambiar el estadoPelicula por estado
            string query = "UPDATE " + tabla + " SET estado=0";
            string whereQuery = " WHERE  ";
            int posCampo = 0;
            int i = 0;
            string campos = "";

            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    if (posCampo == 0)
                    {
                        switch (tipoCampo[posCampo])
                        {
                            case "Text":
                                if (componente is ComboBox)
                                {

                                    if (modoCampoCombo[i] == 1)
                                    {
                                        whereQuery += componente.Name + " = '" + logic.llaveCampolo(tablaCombo[i], campoCombo[i], componente.Text) + "' , ";
                                    }
                                    else
                                    {
                                        whereQuery += componente.Name + " = '" + componente.Text + "' , ";
                                    }

                                    i++;
                                }
                                else
                                {
                                    whereQuery += componente.Name + " = '" + componente.Text + "' , ";
                                }


                                break;
                            case "Num":
                                if (componente is ComboBox)
                                {

                                    if (modoCampoCombo[i] == 1)
                                    {
                                        whereQuery += componente.Name + " = " + logic.llaveCampolo(tablaCombo[i], campoCombo[i], componente.Text);

                                    }
                                    else
                                    {
                                        whereQuery += componente.Name + " = " + componente.Text;
                                    }

                                    i++;
                                }
                                else
                                {
                                    whereQuery += componente.Name + " = " + componente.Text;
                                }

                                break;
                        }

                    }
                    posCampo++;
                }

            }
            campos = campos.TrimEnd(' ');
            campos = campos.TrimEnd(',');
            whereQuery = whereQuery.TrimEnd(' ');
            whereQuery = whereQuery.TrimEnd(',');
            //query += campos + whereQuery + ";";
            query += whereQuery + ";";
            Console.Write(query);
            //sn.insertarBitacora(idUsuario, "Se eliminó un registro", tabla);
            return query;
        }

        string crearInsert(string nombretabla)
        {
            string query = "INSERT INTO " + nombretabla + " (";
            string valores = "VALUES (";

            int posCampo = 0;
            string campos = "";
            string valoresCampos = "";

            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    string nombreCampo = logic.campos(nombretabla)[posCampo];
                    string valorCampo = string.Empty;

                    // Si el control es un ComboBox
                    if (componente is ComboBox cb)
                    {
                        // Obtener el valor seleccionado (ID) del ComboBox
                        valorCampo = cb.SelectedValue.ToString();  // Aquí se obtiene el ID en lugar del nombre
                    }
                    else
                    {
                        valorCampo = componente.Text;  // Para otros controles (TextBox, DateTimePicker, etc.)
                    }

                    // Agregar campo y valor si no está vacío
                    if (!string.IsNullOrEmpty(valorCampo))
                    {
                        campos += nombreCampo + ", ";
                        valoresCampos += "'" + valorCampo + "', ";
                    }

                    posCampo++;
                }
            }

            // Eliminar las últimas comas y cerrar las instrucciones
            campos = campos.TrimEnd(' ', ',');
            valoresCampos = valoresCampos.TrimEnd(' ', ',');

            query += campos + ") " + valores + valoresCampos + ");";

            return query;
        }
        private IEnumerable<Control> GetAllControls(Control container)
        {
            foreach (Control control in container.Controls)
            {
                foreach (Control child in GetAllControls(control))
                {
                    yield return child;
                }
                yield return control;
            }
        }

        string crearUpdate(string tabla, string nombreClavePrimaria, string nombreClaveForanea)
        {
            // Obtener las columnas existentes en la tabla
            string[] columnasTabla = logic.campos(tabla);

            string query = "UPDATE " + tabla + " SET ";
            string whereQuery = " WHERE ";
            int i = 0;
            string campos = "";

            // Usar la función para obtener todos los controles, incluyendo los anidados
            foreach (Control componente in GetAllControls(this))
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    string nombreCampo = componente.Name;
                    Console.WriteLine($"Evaluando control: {nombreCampo} para la tabla: {tabla}");

                    if (columnasTabla.Contains(nombreCampo))
                    {
                        // Excluir claves primarias y foráneas
                        if (nombreCampo != nombreClavePrimaria && nombreCampo != nombreClaveForanea)
                        {
                            // Agregar al SET
                            string valorCampo = componente.Text;
                            campos += $"{nombreCampo} = '{valorCampo}', ";
                            i++;
                            Console.WriteLine($"Asignando valor '{valorCampo}' al campo '{nombreCampo}' en la tabla '{tabla}'");
                        }
                        else
                        {
                            Console.WriteLine($"El campo {nombreCampo} es clave primaria o foránea y no se actualizará.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"El control {nombreCampo} no corresponde a una columna en la tabla {tabla}");
                    }
                }
            }

            if (string.IsNullOrEmpty(campos))
            {
                Console.WriteLine($"No hay campos para actualizar en la tabla {tabla}");
                return null; // O manejar según corresponda
            }

            campos = campos.TrimEnd(' ', ',');

            // Usar la clave primaria o foránea en el WHERE
            string valorClave = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (!string.IsNullOrEmpty(nombreClaveForanea))
            {
                whereQuery += $"{nombreClaveForanea} = '{valorClave}'";
            }
            else
            {
                whereQuery += $"{nombreClavePrimaria} = '{valorClave}'";
            }

            query += campos + whereQuery + ";";

            Console.WriteLine("Consulta generada para el UPDATE: " + query);

            return query;
        }

        public void guardadoforsozo()
        {
            logic.nuevoQuery(crearInsert(tabla));
            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    componente.Enabled = true;
                    componente.Text = "";

                }

            }
            actualizardatagriew();
        }

        public void habilitarallbotones()//habilita todos los botnes
        {
            Btn_Guardar.Enabled = true;
            Btn_Ingresar.Enabled = true;
            Btn_Modificar.Enabled = true;
            Btn_Cancelar.Enabled = false;
            Btn_Eliminar.Enabled = true;

        }

        //-----------------------------------------------Funcionalidad de Botones-----------------------------------------------//

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {

            string[] Tipos = logic.tipos(tabla);

            bool tipoInt = false;
            bool ExtraAI = false;
            string auxId = "";
            int auxLastId = 0;

            // Verificar si el primer campo de la tabla es de tipo entero y autoincremental
            if (Tipos[0] == "int")
            {
                tipoInt = true;

                // Obtener el último ID insertado en la tabla si el campo es autoincrementable
                auxId = logic.lastID(tabla);

                // Verificar si el ID existe o la tabla está vacía
                if (!string.IsNullOrEmpty(auxId))
                {
                    auxLastId = Int32.Parse(auxId);
                }
                else
                {
                    auxLastId = 0; // Si no hay registros previos, inicializamos el ID en 0
                }

                ExtraAI = true; // Suponemos que el campo es autoincremental
            }

            activar = 2;
            habilitarcampos_y_botones();

            foreach (Control componente in Controls)
            {
                if (componente is TextBox && tipoInt && ExtraAI)
                {
                    // Incrementar el último ID para el nuevo registro
                    auxLastId += 1;
                    componente.Text = auxLastId.ToString();
                    componente.Enabled = false; // Deshabilitar el campo autoincremental para que no sea editable
                    tipoInt = false;
                    ExtraAI = false;
                }
                else if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    componente.Enabled = true;
                    componente.Text = "";
                }
                else if (componente is Button)
                {
                    componente.Enabled = true;
                }

                Btn_Ingresar.Enabled = false;
                Btn_Modificar.Enabled = false;
                Btn_Eliminar.Enabled = false;
                Btn_Cancelar.Enabled = true;
            }

            botonesYPermisosSinMensaje();
            // Habilitar y deshabilitar botones según usuario
            Btn_Ingresar.Enabled = false;
            //Btn_Guardar.Enabled = false;
            Btn_Modificar.Enabled = false;
            Btn_Eliminar.Enabled = false;

        }
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Mostrar un mensaje de confirmación antes de proceder con la operación de modificación
                DialogResult result = MessageBox.Show(
                    "Está a punto de modificar un registro existente.\n\n" +
                    "Asegúrese de que todos los datos sean correctos antes de continuar.\n\n" +
                    "¿Desea proceder con la modificación de este registro?",
                    "Confirmación de Modificación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, // Icono de advertencia para hacerlo más formal
                    MessageBoxDefaultButton.Button2 // Por defecto, la opción seleccionada será 'No'
                );

                // Si el usuario selecciona "No", se cancela la operación
                if (result == DialogResult.No)
                {
                    return;
                }

                // Habilitar campos para edición
                habilitarcampos_y_botones();
                activar = 1;
                int i = 0;

                string[] Tipos = logic.tipos(tabla);
                int numCombo = 0;

                // Recorrer los controles para habilitar la edición
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        // Deshabilitar el campo del ID si es entero (autoincremental)
                        if (i == 0 && Tipos[0] == "int")
                        {
                            componente.Enabled = false; // Deshabilitar el ID para que no sea modificable
                        }
                        else
                        {
                            // Si es un ComboBox, recuperar el valor adecuado
                            if (componente is ComboBox)
                            {
                                if (modoCampoCombo[numCombo] == 1)
                                {
                                    componente.Text = logic.llaveCampoRev(tablaCombo[numCombo], campoCombo[numCombo], dataGridView1.CurrentRow.Cells[i].Value.ToString());
                                }
                                else
                                {
                                    componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                                }
                                numCombo++;
                            }
                            else
                            {
                                // Asignar el valor del campo al componente
                                componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                            }
                        }

                        i++;
                    }

                    if (componente is Button)
                    {
                        componente.Enabled = true;
                        string var1 = dataGridView1.CurrentRow.Cells[i].Value.ToString();

                        if (var1 == "0")
                        {
                            componente.Text = "Desactivado";
                            componente.BackColor = Color.Red;
                            estado = 0;
                        }
                        else if (var1 == "1")
                        {
                            componente.Text = "Activado";
                            componente.BackColor = Color.Green;
                            estado = 1;
                        }
                        componente.Enabled = true;

                    }
                }

                // Habilitar y deshabilitar botones según el usuario
                botonesYPermisosSinMensaje();
                Btn_Ingresar.Enabled = false;
                Btn_Modificar.Enabled = false;
                Btn_Eliminar.Enabled = false;
                Btn_Cancelar.Enabled = true;
            }
            catch (Exception ex)
            {
                // Manejo de errores y mostrar un mensaje más profesional
                MessageBox.Show(
                    "Ocurrió un error durante la modificación del registro.\n\n" +
                    "Detalles del error: " + ex.Message + "\n\n" +
                    "Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Error en la Modificación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error // Icono de error para hacer el mensaje más claro
                );
            }
        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                sn.insertarBitacora(idUsuario, "Se presiono el boton cancelar en " + tabla, tabla);
                // Mostrar un mensaje de confirmación antes de cancelar la operación actual
                DialogResult result = MessageBox.Show(
                    "Está a punto de cancelar los cambios no guardados.\n\n" +
                    "Cualquier dato ingresado se perderá.\n\n" +
                    "¿Desea realmente cancelar la operación?",
                    "Confirmación de Cancelación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, // Icono de advertencia
                    MessageBoxDefaultButton.Button2 // Opción "No" predeterminada
                );

                // Si el usuario selecciona "No", se cancela la operación de cancelación
                if (result == DialogResult.No)
                {
                    return;
                }

                // Reestablecer botones y deshabilitar el que no se necesita
                Btn_Modificar.Enabled = true;
                Btn_Guardar.Enabled = false;
                Btn_Cancelar.Enabled = false;
                Btn_Ingresar.Enabled = true;
                Btn_Eliminar.Enabled = true;
                Btn_Refrescar.Enabled = true;

                // Actualizar el DataGridView y los controles a su estado original
                actualizardatagriew();
                if (logic.TestRegistros(tabla) > 0)
                {
                    int i = 0;
                    int numCombo = 0;
                    foreach (Control componente in Controls)
                    {
                        if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                        {
                            if (componente is ComboBox)
                            {
                                if (modoCampoCombo[numCombo] == 1)
                                {
                                    componente.Text = logic.llaveCampoRev(tablaCombo[numCombo], campoCombo[numCombo], dataGridView1.CurrentRow.Cells[i].Value.ToString());
                                }
                                else
                                {
                                    componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                                }
                                numCombo++;
                            }
                            else
                            {
                                componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                            }
                            componente.Enabled = false;
                            i++;
                        }
                        if (componente is Button)
                        {
                            string var1 = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                            if (var1 == "0")
                            {
                                componente.Text = "Desactivado";
                                componente.BackColor = Color.Red;
                            }
                            if (var1 == "1")
                            {
                                componente.Text = "Activado";
                                componente.BackColor = Color.Green;
                            }
                            componente.Enabled = false;
                        }
                    }
                }

                // Habilitar/deshabilitar según los permisos del usuario
                botonesYPermisosSinMensaje();
            }
            catch (Exception ex)
            {
                // Manejo de errores con un mensaje más profesional
                MessageBox.Show(
                    "Ocurrió un error durante el proceso de cancelación.\n\n" +
                    "Detalles del error: " + ex.Message + "\n\n" +
                    "Por favor, intente nuevamente o contacte al administrador del sistema.",
                    "Error en Cancelación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error // Icono de error
                );
            }
        }


        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!presionado)
                {
                    // Habilitar y deshabilitar botones según el estado de eliminación
                    Btn_Guardar.Enabled = false;
                    Btn_Modificar.Enabled = false;
                    Btn_Eliminar.Enabled = true;
                    Btn_Cancelar.Enabled = true;
                    Btn_Ingresar.Enabled = false;
                    presionado = true;
                }
                else
                {
                    // Mostrar un mensaje de confirmación antes de proceder con la eliminación
                    DialogResult respuestaEliminar = MessageBox.Show(
                        "Está a punto de eliminar permanentemente este registro del sistema.\n\n" +
                        "Esta operación no se puede deshacer. ¿Está seguro de que desea continuar?",
                        "Confirmación de Eliminación - " + nomForm,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button2 // Opción "No" predeterminada
                    );

                    if (respuestaEliminar == DialogResult.Yes)
                    {
                        // Proceder con la eliminación
                        logic.nuevoQuery(crearDelete());
                        actualizardatagriew();

                        // Mostrar un mensaje de éxito tras la eliminación
                        MessageBox.Show(
                            "El registro ha sido eliminado correctamente.",
                            "Eliminación Exitosa",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information

                        );

                        // Restablecer el estado de los botones
                        Btn_Modificar.Enabled = true;
                        Btn_Guardar.Enabled = false;
                        Btn_Cancelar.Enabled = false;
                        Btn_Eliminar.Enabled = true;
                        Btn_Ingresar.Enabled = true;
                        presionado = false;
                    }
                    else if (respuestaEliminar == DialogResult.No)
                    {
                        // Si el usuario cancela la operación de eliminación
                        MessageBox.Show(
                            "La eliminación ha sido cancelada.",
                            "Operación Cancelada",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        // Mantener el estado de los botones
                        Btn_Guardar.Enabled = false;
                        Btn_Modificar.Enabled = false;
                        Btn_Eliminar.Enabled = true;
                        Btn_Cancelar.Enabled = true;
                        Btn_Ingresar.Enabled = false;
                        presionado = true;
                    }
                }

                // Habilitar/deshabilitar botones según los permisos del usuario
                botonesYPermisosSinMensaje(); ;
                presionado = true;
                sn.insertarBitacora(idUsuario, "Se actualizo el estado en " + tabla, tabla);
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

        /*
                private void Btn_Consultar_Click(object sender, EventArgs e)
                {
                    //DLL DE CONSULTAS
                    sentencia con = new sentencia();
                    bool per1 = con.consultarPermisos(idUsuario, idAplicacion, 1);
                    bool per2 = con.consultarPermisos(idUsuario, idAplicacion, 2);
                    bool per3 = con.consultarPermisos(idUsuario, idAplicacion, 3);
                    bool per4 = con.consultarPermisos(idUsuario, idAplicacion, 4);
                    bool per5 = con.consultarPermisos(idUsuario, idAplicacion, 5);

                    if (per1==true && per2 == true && per3 == true && per4 == true && per5 == true)
                    {
                        Compleja nuevo = new Compleja(idUsuario);
                        nuevo.Show();
                    }
                    else
                    {
                         Simple nueva = new Simple(idUsuario);
                        nueva.Show();
                    }

                    //habilitar y deshabilitar según Usuario
                    botonesYPermisos();
                }
        */
        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            //DLL DE IMPRESION, FORATO DE REPORTES.
            string llave = "";
            if (idRepo != "")
            {
                llave = logic.ObtenerIdReporte(idRepo);

            }
            else
            {
                MessageBox.Show("No se asigno ningun reporte....");
            }

            if (llave != "")
            {
                Clientes cl = new Clientes(llave);
                cl.Show();
            }
            else
            {
                MessageBox.Show("El Id Asignado es incorrecto");
            }

            //habilitar y deshabilitar según Usuario
            botonesYPermisosSinMensaje();
        }

        private void Btn_Refrescar_Click(object sender, EventArgs e)
        {
            try
            {
                // Refrescar la DataGridView y actualizar los controles
                actualizardatagriew();

                // Iterar sobre los controles y actualizar sus valores con los datos del DataGridView
                int i = 0;
                int numCombo = 0;
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (componente is ComboBox)
                        {
                            if (modoCampoCombo[numCombo] == 1)
                            {
                                componente.Text = logic.llaveCampoRev(tablaCombo[numCombo], campoCombo[numCombo], dataGridView1.CurrentRow.Cells[i].Value.ToString());
                            }
                            else
                            {
                                componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                            }
                            numCombo++;
                        }
                        else
                        {
                            componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                        }

                        i++;
                    }
                    if (componente is Button)
                    {
                        string var1 = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                        if (var1 == "0")
                        {
                            componente.Text = "Desactivado";
                            componente.BackColor = Color.Red;
                        }
                        if (var1 == "1")
                        {
                            componente.Text = "Activado";
                            componente.BackColor = Color.Green;
                        }
                        componente.Enabled = false;
                    }
                }

                // Habilitar y deshabilitar botones según permisos del usuario
                botonesYPermisosSinMensaje();

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



        private void Btn_Anterior_Click(object sender, EventArgs e)
        {
            int i = 0;
            string[] Campos = logic.campos(tabla);

            int fila = dataGridView1.SelectedRows[0].Index;
            if (fila > 0)
            {
                dataGridView1.Rows[fila - 1].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[fila - 1].Cells[0];

                int numCombo = 0;
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (componente is ComboBox)
                        {
                            if (modoCampoCombo[numCombo] == 1)
                            {
                                componente.Text = logic.llaveCampoRev(tablaCombo[numCombo], campoCombo[numCombo], dataGridView1.CurrentRow.Cells[i].Value.ToString());

                            }
                            else
                            {
                                componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                            }

                            numCombo++;
                        }
                        else
                        {
                            componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                        }

                        i++;
                    }
                    if (componente is Button)
                    {
                        string var1 = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                        if (var1 == "0")
                        {
                            componente.Text = "Desactivado";
                            componente.BackColor = Color.Red;
                        }
                        if (var1 == "1")
                        {
                            componente.Text = "Activado";
                            componente.BackColor = Color.Green;
                        }
                        componente.Enabled = false;

                    }
                }
            }
        }

        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            int i = 0;
            string[] Campos = logic.campos(tabla);

            int fila = dataGridView1.SelectedRows[0].Index;
            if (fila < dataGridView1.Rows.Count - 1)
            {
                dataGridView1.Rows[fila + 1].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[fila + 1].Cells[0];

                int numCombo = 0;
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (componente is ComboBox)
                        {
                            if (modoCampoCombo[numCombo] == 1)
                            {
                                componente.Text = logic.llaveCampoRev(tablaCombo[numCombo], campoCombo[numCombo], dataGridView1.CurrentRow.Cells[i].Value.ToString());

                            }
                            else
                            {
                                componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                            }

                            numCombo++;
                        }
                        else
                        {
                            componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                        }

                        i++;
                    }
                    if (componente is Button)
                    {
                        string var1 = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                        if (var1 == "0")
                        {
                            componente.Text = "Desactivado";
                            componente.BackColor = Color.Red;
                        }
                        if (var1 == "1")
                        {
                            componente.Text = "Activado";
                            componente.BackColor = Color.Green;
                        }
                        componente.Enabled = false;

                    }
                }

            }
        }

        private void Btn_FlechaFin_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[dataGridView1.Rows.Count - 2].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0];

            int i = 0;
            string[] Campos = logic.campos(tabla);

            int fila = dataGridView1.SelectedRows[0].Index;
            if (fila < dataGridView1.Rows.Count - 1)
            {
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0];

                int numCombo = 0;
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (componente is ComboBox)
                        {
                            if (modoCampoCombo[numCombo] == 1)
                            {
                                componente.Text = logic.llaveCampoRev(tablaCombo[numCombo], campoCombo[numCombo], dataGridView1.CurrentRow.Cells[i].Value.ToString());

                            }
                            else
                            {
                                componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                            }

                            numCombo++;
                        }
                        else
                        {
                            componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                        }

                        i++;
                    }
                    if (componente is Button)
                    {
                        string var1 = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                        if (var1 == "0")
                        {
                            componente.Text = "Desactivado";
                            componente.BackColor = Color.Red;
                        }
                        if (var1 == "1")
                        {
                            componente.Text = "Activado";
                            componente.BackColor = Color.Green;
                        }
                        componente.Enabled = false;

                    }
                }

            }
        }

        private void Btn_FlechaInicio_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];

            int i = 0;
            string[] Campos = logic.campos(tabla);

            int fila = dataGridView1.SelectedRows[0].Index;
            if (fila < dataGridView1.Rows.Count - 1)
            {
                dataGridView1.Rows[0].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];


                int numCombo = 0;
                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (componente is ComboBox)
                        {
                            if (modoCampoCombo[numCombo] == 1)
                            {
                                componente.Text = logic.llaveCampoRev(tablaCombo[numCombo], campoCombo[numCombo], dataGridView1.CurrentRow.Cells[i].Value.ToString());

                            }
                            else
                            {
                                componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                            }

                            numCombo++;
                        }
                        else
                        {
                            componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                        }

                        i++;
                    }
                    if (componente is Button)
                    {
                        string var1 = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                        if (var1 == "0")
                        {
                            componente.Text = "Desactivado";
                            componente.BackColor = Color.Red;
                        }
                        if (var1 == "1")
                        {
                            componente.Text = "Activado";
                            componente.BackColor = Color.Green;
                        }
                        componente.Enabled = false;

                    }
                }
            }

        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                Help.ShowHelp(this, AsRuta, AsIndice); // Abre el menú de ayuda HTML
            }
            catch (Exception ex)
            {
                // Opción 1: Mostrar un mensaje de error al usuario
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Opción 2: Registrar el error en la consola para propósitos de depuración
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());

                // Opción 3: Podrías agregar un registro de error en un archivo de log si es necesario
                // LogError(ex); // Función que guarda el error en un archivo de texto o en otro lugar
            }

            botonesYPermisosSinMensaje();
        }


        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            try
            {
                // Opción cuando se está guardando y se quiere salir sin finalizar
                if (Btn_Guardar.Enabled == true && Btn_Cancelar.Enabled == true && Btn_Eliminar.Enabled == false && Btn_Modificar.Enabled == false && Btn_Ingresar.Enabled == false)
                {
                    foreach (Control componente in Controls)
                    {
                        if (componente.Text != "" && componente is TextBox)
                        {
                            // Mostrar un mensaje si el usuario intenta salir sin guardar
                            DialogResult respuestaGuardar = MessageBox.Show(
                                "Se ha detectado una operación de guardado en curso.\n\n" +
                                "¿Desea guardar los cambios antes de salir?",
                                "Confirmación de Salida - " + nomForm,
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Warning
                            );

                            if (respuestaGuardar == DialogResult.Yes)
                            {
                                guardadoforsozo();
                                cerrar.Visible = false; // Cierra el formulario después de guardar
                            }
                            else if (respuestaGuardar == DialogResult.No)
                            {
                                cerrar.Visible = false; // Cierra el formulario sin guardar
                            }
                            else if (respuestaGuardar == DialogResult.Cancel)
                            {
                                return; // Cancela la salida y permanece en el formulario
                            }
                        }
                    }
                }

                // Opción cuando se está modificando y se quiere salir sin finalizar
                if (Btn_Modificar.Enabled == true && Btn_Guardar.Enabled == true && Btn_Cancelar.Enabled == true && Btn_Ingresar.Enabled == false)
                {
                    foreach (Control componente in Controls)
                    {
                        if (componente.Text != "" && componente is TextBox)
                        {
                            DialogResult respuestaModificar = MessageBox.Show(
                                "Se ha detectado una operación de modificación en curso.\n\n" +
                                "¿Desea regresar y finalizar la operación antes de salir?",
                                "Confirmación de Salida - " + nomForm,
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Warning
                            );

                            if (respuestaModificar == DialogResult.Yes)
                            {
                                return; // El usuario decide regresar al formulario
                            }
                            else if (respuestaModificar == DialogResult.No)
                            {
                                cerrar.Visible = false; // Cierra el formulario sin finalizar la modificación
                            }
                            else if (respuestaModificar == DialogResult.Cancel)
                            {
                                return; // Cancela la salida y permanece en el formulario
                            }
                        }
                    }
                }

                // Opción cuando se está eliminando y se quiere salir sin finalizar
                if (Btn_Eliminar.Enabled == true && Btn_Cancelar.Enabled == true && Btn_Modificar.Enabled == false && Btn_Guardar.Enabled == false && Btn_Ingresar.Enabled == false)
                {
                    foreach (Control componente in Controls)
                    {
                        if (componente.Text != "" && componente is TextBox)
                        {
                            DialogResult respuestaEliminar = MessageBox.Show(
                                "Se ha detectado una operación de eliminación en curso.\n\n" +
                                "¿Desea regresar y finalizar la operación antes de salir?",
                                "Confirmación de Salida - " + nomForm,
                                MessageBoxButtons.YesNoCancel,
                                MessageBoxIcon.Warning
                            );

                            if (respuestaEliminar == DialogResult.Yes)
                            {
                                return; // El usuario decide regresar al formulario
                            }
                            else if (respuestaEliminar == DialogResult.No)
                            {
                                cerrar.Visible = false; // Cierra el formulario sin finalizar la eliminación
                            }
                            else if (respuestaEliminar == DialogResult.Cancel)
                            {
                                return; // Cancela la salida y permanece en el formulario
                            }
                        }
                    }
                }

                // Confirmación final antes de cerrar el formulario si no hay operaciones pendientes
                DialogResult confirmacionFinal = MessageBox.Show(
                    "¿Está seguro de que desea salir del formulario?",
                    "Confirmación de Salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacionFinal == DialogResult.Yes)
                {
                    cerrar.Visible = false; // Cierra el formulario si el usuario confirma la salida
                }
                else
                {
                    return; // El usuario decide quedarse en el formulario
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores con un mensaje profesional
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

        public void botonesYPermisosSinMensaje()
        {
            try
            {
                string[] permisosText = { "INGRESAR", "BUSCAR", "MODIFICAR", "ELIMINAR", "IMPRIMIR" };
                Button[] botones = { Btn_Ingresar, Btn_Consultar, Btn_Modificar, Btn_Eliminar, Btn_Imprimir };

                for (int i = 0; i < permisosText.Length; i++)
                {
                    // Consultar permisos para cada botón
                    string idUsuario1 = logic.ObtenerIdUsuario(idUsuario);
                    sentencia sen = new sentencia();
                    bool tienePermiso = sn.consultarPermisos(idUsuario1, idAplicacion, i + 1);

                    // Verificar si el botón no es nulo y asignar permisos
                    if (botones[i] != null)
                    {
                        botones[i].Enabled = tienePermiso;
                    }
                }
            }
            catch (Exception ex)
            {
                // Opción: Podrías registrar el error en un log en lugar de mostrar un MessageBox
                // LogError(ex);  // Un método para registrar errores
                Console.WriteLine("Error al configurar los botones y permisos: " + ex.Message);  // Mostrar el error en la consola
            }
        }


        public void botonesYPermisos()
        {
            try
            {
                string[] permisosText = { "INGRESAR", "BUSCAR", "MODIFICAR", "ELIMINAR", "IMPRIMIR" };
                Button[] botones = { Btn_Ingresar, Btn_Consultar, Btn_Modificar, Btn_Eliminar, Btn_Imprimir };

                string botonesPermitidos = "";
                string botonesNoPermitidos = "";

                for (int i = 0; i < permisosText.Length; i++)
                {
                    // bool tienePermiso = sn.consultarPermisos("2", "1000", i + 1);

                    string idUsuario1 = logic.ObtenerIdUsuario(idUsuario);
                    // MessageBox.Show("El usuario es: " + idUsuario1 + " " + idAplicacion);
                    sentencia sen = new sentencia();
                    bool tienePermiso = sn.consultarPermisos(idUsuario1, idAplicacion, i + 1);

                    if (botones[i] != null)
                    {
                        botones[i].Enabled = tienePermiso;

                        if (botones[i].Enabled)
                        {
                            // Acumular los botones permitidos en la cadena
                            botonesPermitidos += permisosText[i] + ", ";
                        }
                        else
                        {
                            // Acumular los botones no permitidos (que existen pero no tienen permiso)
                            botonesNoPermitidos += permisosText[i] + ", ";
                        }
                    }
                    else
                    {
                        // Acumular los botones no permitidos (que no se encontraron)
                        botonesNoPermitidos += permisosText[i] + ", ";
                    }
                }

                // Formatear el mensaje final
                string mensaje = "";

                if (!string.IsNullOrEmpty(botonesPermitidos))
                {
                    mensaje += "Botones permitidos: " + botonesPermitidos.TrimEnd(',', ' ') + ".\n";
                }

                if (!string.IsNullOrEmpty(botonesNoPermitidos))
                {
                    mensaje += "Botones no permitidos: " + botonesNoPermitidos.TrimEnd(',', ' ') + ".";
                }

                if (!string.IsNullOrEmpty(mensaje))
                {
                    // Mostrar un solo MessageBox con el resumen de botones permitidos y no permitidos
                    MessageBox.Show(mensaje);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al configurar los botones y permisos: " + ex.Message);
            }
        }


        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "Está a punto de guardar un nuevo registro en el sistema.\n\n" +
                    "Asegúrese de que toda la información ingresada sea correcta.\n\n" +
                    "¿Desea continuar con el guardado?",
                    "Confirmación de Guardado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    return;
                }

                bool lleno = true;

                foreach (Control componente in Controls)
                {
                    if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                    {
                        if (string.IsNullOrEmpty(componente.Text))
                        {
                            lleno = false;
                            break;
                        }
                    }
                }

                if (!lleno)
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

                List<string> queries = new List<string>();

                switch (activar)
                {
                    case 1: // Actualizar
                        string clavePrimariaPrincipal = logic.ObtenerClavePrimaria(tabla);
                        string queryPrincipal = crearUpdate(tabla, clavePrimariaPrincipal, null);
                        queries.Add(queryPrincipal);

                        foreach (string tablaAdicional in listaTablasAdicionales)
                        {
                            if (!string.IsNullOrEmpty(tablaAdicional))
                            {
                                string clavePrimariaAdicional = logic.ObtenerClavePrimaria(tablaAdicional);
                                string claveForaneaAdicional = logic.ObtenerClaveForanea(tablaAdicional, tabla);
                                string queryAdicional = crearUpdate(tablaAdicional, clavePrimariaAdicional, claveForaneaAdicional);

                                if (!string.IsNullOrEmpty(queryAdicional))
                                {
                                    queries.Add(queryAdicional);
                                }
                            }
                        }

                        logic.insertarDatosEnMultiplesTablas(queries);
                        MessageBox.Show("El registro ha sido actualizado correctamente en todas las tablas.", "Actualización Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sn.insertarBitacora(idUsuario, "Actualizó registros en múltiples tablas", tabla);
                        break;

                    case 2: // Insertar
                        string queryPrimeraTabla = crearInsert(tabla);
                        logic.nuevoQuery(queryPrimeraTabla);
                        sn.insertarBitacora(idUsuario, "Se insertó en " + tabla, tabla);

                        string ultimoIdPrimeraTabla = logic.lastID(tabla);

                        foreach (string tablaAdicional in listaTablasAdicionales)
                        {
                            if (!string.IsNullOrEmpty(tablaAdicional))
                            {
                                List<(string nombreColumna, bool esAutoIncremental, bool esClaveForanea, bool esTinyInt)> columnasAdicionales = logic.obtenerColumnasYPropiedadesLogica(tablaAdicional);

                                List<string> valoresTablaAdicional = new List<string>();
                                int pos = 1;

                                foreach (var columna in columnasAdicionales)
                                {
                                    string valorCampo;

                                    if (columna.esAutoIncremental)
                                    {
                                        continue;
                                    }
                                    else if (columna.esTinyInt)
                                    {
                                        valorCampo = "1";
                                    }
                                    else if (columna.esClaveForanea)
                                    {
                                        valorCampo = ultimoIdPrimeraTabla.ToString();
                                    }
                                    else
                                    {
                                        valorCampo = obtenerDatoCampos(pos);
                                    }

                                    valoresTablaAdicional.Add($"'{valorCampo}'");
                                    pos++;
                                }

                                string camposQuery = string.Join(", ", columnasAdicionales.Where(c => !c.esAutoIncremental).Select(c => c.nombreColumna));
                                string valoresQuery = string.Join(", ", valoresTablaAdicional);
                                string queryAdicional = $"INSERT INTO {tablaAdicional} ({camposQuery}) VALUES ({valoresQuery});";
                                queries.Add(queryAdicional);
                            }
                        }

                        logic.insertarDatosEnMultiplesTablas(queries);
                        MessageBox.Show("El registro ha sido guardado correctamente.", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    default:
                        MessageBox.Show("Opción no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                actualizardatagriew();
                deshabilitarcampos_y_botones();
                botonesYPermisosSinMensaje();
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



        // Aquí está la función crearInsertFactura


        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            foreach (Control componente in Controls)
            {
                if (componente is TextBox || componente is DateTimePicker || componente is ComboBox)
                {
                    componente.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                    i++;
                }
                if (componente is Button)
                {
                    string var1 = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                    if (var1 == "0")
                    {
                        componente.Text = "Desactivado";
                        componente.BackColor = Color.Red;
                    }
                    if (var1 == "1")
                    {
                        componente.Text = "Activado";
                        componente.BackColor = Color.Green;
                    }
                }

            }
        }

        private void Contenido_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Ayuda_Click_1(object sender, EventArgs e)
        {
            // Construir la ruta completa manualmente
            string helpFilePath = AppDomain.CurrentDomain.BaseDirectory + @"..\..\AyudaHTML\AyudaNavegador.chm";

            // Normaliza la ruta para obtener la absoluta correctamente
            helpFilePath = System.IO.Path.GetFullPath(helpFilePath);

            // Verifica si el archivo existe antes de intentar abrirlo
            if (System.IO.File.Exists(helpFilePath))
            {
                Help.ShowHelp(this, helpFilePath, "AyudaNav.html");
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de ayuda: " + helpFilePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_MasAyuda_Click(object sender, EventArgs e)
        {
            string AyudaOK = logic.TestTabla("ayuda");
            if (AyudaOK == "")
            {
                Ayudas nuevo = new Ayudas();
                nuevo.Show();
            }
            else
            {
                DialogResult validacion = MessageBox.Show(AyudaOK + " \n Solucione este error para continuar...", "Verificación de requisitos", MessageBoxButtons.OK);
                if (validacion == DialogResult.OK)
                {

                }
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LblTabla_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btn_Imprimir_Click_1(object sender, EventArgs e)
        {
            Capa_Controlador_Reporteria.Controlador controlador = new Capa_Controlador_Reporteria.Controlador();


            ObtenerIdAplicacion(idAplicacion);
            string ruta = controlador.queryRuta(idAplicacion);
            if (!string.IsNullOrEmpty(idAplicacion))
            {
                Capa_Vista_Reporteria.visualizar visualizar = new Capa_Vista_Reporteria.visualizar(ruta);
                // MessageBox.Show(ruta);
                visualizar.ShowDialog();
            }
        }

        private void btn_Reportes_Principal_Click(object sender, EventArgs e)
        {
            menu_reporteria reportes = new menu_reporteria();

            reportes.Show();
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {

            string idUsuario1 = logic.ObtenerIdUsuario(idUsuario);
            //MessageBox.Show("el usuario es: " + idUsuario1 + " " + idAplicacion);
            sentencia sen = new sentencia();
            //DLL DE CONSULTAS
            sentencia con = new sentencia();
            bool per1 = con.consultarPermisos(idUsuario1, idAplicacion, 1);
            bool per2 = con.consultarPermisos(idUsuario1, idAplicacion, 2);
            bool per3 = con.consultarPermisos(idUsuario1, idAplicacion, 3);
            bool per4 = con.consultarPermisos(idUsuario1, idAplicacion, 4);
            bool per5 = con.consultarPermisos(idUsuario1, idAplicacion, 5);

            if (per1 == true && per2 == true && per3 == true && per4 == true && per5 == true)
            {
                ConsultaInteligente nuevo = new ConsultaInteligente(tabla);
                nuevo.Show();
            }
            else
            {
                ConsultaSimple nueva = new ConsultaSimple(tabla);
                nueva.Show();
            }

            //habilitar y deshabilitar según Usuario
            botonesYPermisosSinMensaje();
        }

        private void btn_Reportes_Principal_Click_1(object sender, EventArgs e)
        {
            menu_reporteria reportes = new menu_reporteria();

            reportes.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ayudas ayudas = new Ayudas();
            ayudas.Show();
        }
    }
}
  