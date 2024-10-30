using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Capa_Modelo_Navegador
{
    public class sentencias
    {
        conexion cn = new conexion();
        private OdbcTransaction transaction;
        private OdbcConnection connection;
        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 
        // Método que llena una tabla con datos relacionados a otra tabla si es necesario.
        public OdbcDataAdapter LlenaTbl(string sTabla, List<Tuple<string, string, string, string>> relacionesForaneas)
        {
            OdbcConnection conn = cn.ProbarConexion();

            try
            {
                // Verifica que las relaciones no sean nulas
                if (relacionesForaneas == null)
                {
                    relacionesForaneas = new List<Tuple<string, string, string, string>>();
                }

                // Verificar que la conexión esté activa
                if (conn == null)
                {
                    throw new InvalidOperationException("La conexión a la base de datos no está disponible.");
                }

                // Obtener los campos de la tabla principal de forma dinámica
                string[] sCamposDesc = ObtenerCampos(sTabla);
                if (sCamposDesc == null || sCamposDesc.Length == 0)
                {
                    throw new InvalidOperationException("No se pudieron obtener los campos de la tabla principal.");
                }

                // Crear alias para la tabla principal
                string aliasPrincipal = "tc"; // Alias para la tabla principal
                string sCamposSelect = aliasPrincipal + "." + sCamposDesc[0];

                // Diccionario para evitar duplicados de columnas
                Dictionary<string, int> dicColumnasRegistradas = new Dictionary<string, int>();
                dicColumnasRegistradas[sCamposDesc[0]] = 1;

                // Obtener las propiedades de las columnas de la tabla principal
                var vColumnasPropiedades = ObtenerColumnasYPropiedades(sTabla);
                if (vColumnasPropiedades == null)
                {
                    throw new InvalidOperationException("No se pudieron obtener las propiedades de las columnas de la tabla.");
                }

                // Recorrer los campos de la tabla principal
                foreach (var (sNombreColumna, bEsAutoIncremental, bEsClaveForanea, bEsTinyInt) in vColumnasPropiedades)
                {
                    // Evitar agregar la columna principal dos veces
                    if (sNombreColumna == sCamposDesc[0])
                        continue;

                    // Si es una clave foránea, buscar si hay una relación foránea que la reemplace
                    bool columnaReemplazada = false;

                    foreach (var relacion in relacionesForaneas)
                    {
                        if (string.IsNullOrEmpty(relacion.Item1) || string.IsNullOrEmpty(relacion.Item2) || string.IsNullOrEmpty(relacion.Item3) || string.IsNullOrEmpty(relacion.Item4))
                        {
                            throw new ArgumentException("Uno de los valores en las relaciones foráneas es nulo o vacío.");
                        }

                        // Crear alias dinámico para la tabla relacionada
                        string aliasRelacion = "t" + relacionesForaneas.IndexOf(relacion);
                        string sTablaRelacionada = relacion.Item1;
                        string sCampoDescriptivo = relacion.Item2;
                        string sColumnaForanea = relacion.Item3;

                        // Si la columna actual es una clave foránea, la reemplazamos por su campo descriptivo
                        if (sNombreColumna == sColumnaForanea)
                        {
                            if (!dicColumnasRegistradas.ContainsKey(sCampoDescriptivo))
                            {
                                sCamposSelect += ", " + aliasRelacion + "." + sCampoDescriptivo + " AS " + sCampoDescriptivo;
                                dicColumnasRegistradas[sCampoDescriptivo] = 1;
                            }
                            columnaReemplazada = true;
                            break;
                        }
                    }

                    // Si no fue reemplazada como clave foránea, agregarla como está
                    if (!columnaReemplazada)
                    {
                        if (!dicColumnasRegistradas.ContainsKey(sNombreColumna))
                        {
                            sCamposSelect += ", " + aliasPrincipal + "." + sNombreColumna;
                            dicColumnasRegistradas[sNombreColumna] = 1;
                        }
                    }
                }

                // Crear el comando SQL para seleccionar los campos usando alias
                string sSql = "SELECT " + sCamposSelect + " FROM " + sTabla + " AS " + aliasPrincipal;

                // Agregar los LEFT JOIN para cada relación foránea usando alias
                foreach (var relacion in relacionesForaneas)
                {
                    string aliasRelacion = "t" + relacionesForaneas.IndexOf(relacion); // Alias para la tabla relacionada
                    string sTablaRelacionada = relacion.Item1;
                    string sColumnaForanea = relacion.Item3;
                    string sColumnaPrimariaRelacionada = relacion.Item4;

                    // Añadir el LEFT JOIN con la tabla relacionada usando alias
                    sSql += " LEFT JOIN " + sTablaRelacionada + " AS " + aliasRelacion + " ON " + aliasPrincipal + "." + sColumnaForanea + " = " + aliasRelacion + "." + sColumnaPrimariaRelacionada;
                }

                // Filtrar por estado (activo o inactivo)
                sSql += " WHERE " + aliasPrincipal + ".estado = 0 OR " + aliasPrincipal + ".estado = 1";

                // Ordenar por la columna principal en orden descendente
                sSql += " ORDER BY " + aliasPrincipal + "." + sCamposDesc[0] + " DESC;";

                Console.WriteLine(sSql); // Imprimir la consulta SQL generada para debugging

                // Crear un adaptador de datos para ejecutar la consulta
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sSql, conn);

                return dataTable;
            }
            catch (Exception ex)
            {
                // Capturar detalles del error y volver a lanzar la excepción
                Console.WriteLine("Ocurrió un error al llenar la tabla: " + ex.Message);
                throw;
            }
            finally
            {
                // Cerrar la conexión después de ejecutar la consulta
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    Console.WriteLine("Conexión cerrada después de llenar la tabla");
                }
            }
        }

        public string ObtenerValorClave(string sTabla, string sCampoClave, string sCampoDescriptivo, string valorDescriptivo)
        {
            string sQuery = $"SELECT {sCampoClave} FROM {sTabla} WHERE {sCampoDescriptivo} = '{valorDescriptivo}'";
            OdbcCommand command = new OdbcCommand(sQuery, cn.ProbarConexion());
            string resultado = command.ExecuteScalar()?.ToString();
            Console.WriteLine(sQuery);
            return resultado;
        }





        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 


        //******************************************** CODIGO HECHO POR EMANUEL BARAHONA ***************************** 
        // Método que obtiene el último ID de una tabla
        public string ObtenerId()
        {
            string sId = "";
            OdbcConnection conn = cn.ProbarConexion();

            try
            {
                // Verificar si la conexión está abierta
                if (conn.State != ConnectionState.Open)
                {
                    throw new Exception("La conexión no está abierta.");
                }

                // Utilizar LAST_INSERT_ID() en lugar de SELECT MAX(...)
                string sSql = "SELECT LAST_INSERT_ID();";
                OdbcCommand command = new OdbcCommand(sSql, conn);
                OdbcDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    sId = reader.GetValue(0).ToString();
                    Console.WriteLine("Último ID obtenido: " + sId);
                }
                else
                {
                    Console.WriteLine("No se pudo obtener el último ID.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el último ID: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    Console.WriteLine("Conexión cerrada después de obtener el último ID.");
                }
            }

            return sId;
        }
        public string ContadorID(string sTabla)
        {
            string[] sCamposDesc = ObtenerCampos(sTabla);
            string sSql = "SELECT MAX(" + sCamposDesc[0] + ") FROM " + sTabla + ";";
            string sId = "";
            OdbcCommand command = new OdbcCommand(sSql, cn.ProbarConexion());
            OdbcDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    if (reader.GetValue(0).ToString() == null || reader.GetValue(0).ToString() == "")
                    {
                        sId = "1";
                    }
                    else
                    {
                        sId = reader.GetValue(0).ToString();
                    }
                }
            }
            else
            {
                sId = "1";
            }
            return sId;
        }

        // Método para obtener datos adicionales de una tabla (no se especifica para qué se usan)
        public string[] ObtenerExtra(string sTabla)
        {
            string[] sCampos = new string[30];
            int iIndex = 0;
            OdbcCommand command = new OdbcCommand("DESCRIBE " + sTabla + "", cn.ProbarConexion());
            OdbcDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                sCampos[iIndex] = reader.GetValue(5).ToString();
                iIndex++;
            }
            return sCampos;
        }

        //******************************************** CODIGO HECHO POR EMANUEL BARAHONA ***************************** 



        //******************************************** CODIGO HECHO POR ANIKA ESCOTO ***************************** 
        // Método para obtener el ID de usuario basado en su nombre de usuario
        public string ObtenerIdUsuarioPorUsername(string sUsername)
        {
            string sSql = "SELECT Pk_id_usuario FROM tbl_usuarios WHERE username_usuario = ?";

            using (OdbcCommand command = new OdbcCommand(sSql, cn.ProbarConexion()))
            {
                command.Parameters.AddWithValue("@username", sUsername);

                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["Pk_id_usuario"].ToString();
                    }
                    else
                    {
                        return "-1";
                    }
                }
            }
        }

        // Método que cuenta los campos en una tabla
        public int ContarAlias(string sTabla)
        {
            int iCampos = 0;

            try
            {
                OdbcCommand command = new OdbcCommand("DESCRIBE " + sTabla + "", cn.ProbarConexion());
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    iCampos++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtenerTipo, revise los parámetros de la tabla  \n -" + sTabla.ToUpper() + "\n -");
            }
            return iCampos;
        }
        //******************************************** CODIGO HECHO POR ANIKA ESCOTO ***************************** 


        //******************************************** CODIGO HECHO POR JOEL LOPEZ ***************************** 
        // Método para contar registros en la tabla de ayuda
        public int ContarReg(string sIdIndice)
        {
            int iCampos = 0;
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM ayuda WHERE id_ayuda = " + sIdIndice + ";", cn.ProbarConexion());
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    iCampos++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtenerTipo, revise los parámetros de la tabla  \n -" + sIdIndice.ToUpper() + "\n -");
            }
            return iCampos;
        }


        public string ModRuta(string sIdAyuda)
        {
            string sRuta = "";
            string sQuery = "SELECT Ruta FROM ayuda WHERE Id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(sQuery, cn.ProbarConexion()))
            {
                command.Parameters.AddWithValue("id_ayuda", sIdAyuda);
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        sRuta = reader.GetString(0); // Asignamos el valor de la columna Ruta
                    }
                }
            }

            return sRuta;
        }
        //******************************************** CODIGO HECHO POR JOEL LOPEZ ***************************** 


        //******************************************** CODIGO HECHO POR JORGE AVILA ***************************** 
        // Método que obtiene la ruta del reporte basada en el ID de la aplicación
        public string RutaReporte(string sIdIndice)
        {
            string sIndice2 = "";
            OdbcCommand command = new OdbcCommand("SELECT ruta FROM tbl_aplicaciones WHERE Pk_id_aplicacion = " + sIdIndice + ";", cn.ProbarConexion());
            OdbcDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                sIndice2 = reader["ruta"].ToString();
            }

            reader.Close();
            return sIndice2;
        }

        // Método para obtener un índice modificado basado en el ID de ayuda
        public string ModIndice(string sIdAyuda)
        {
            string sIndice = "";
            string sQuery = "SELECT indice FROM ayuda WHERE id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(sQuery, cn.ProbarConexion()))
            {
                command.Parameters.AddWithValue("Id_ayuda", sIdAyuda);
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        sIndice = reader.GetString(0); // Asignamos el valor de la columna Indice
                    }
                }
            }

            return sIndice;
        }
        //******************************************** CODIGO HECHO POR JORGE AVILA ***************************** 


        //******************************************** CODIGO HECHO POR DIEGO MARROQUIN ***************************** 
        // Método para probar si una tabla existe en la base de datos
        public string ProbarTabla(string sTabla)
        {
            string sError = "";
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM " + sTabla + ";", cn.ProbarConexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
            }
            catch (Exception)
            {
                sError = "La tabla " + sTabla.ToUpper() + " no existe.";
            }
            return sError;
        }

        // Método para probar si una tabla tiene un campo de estado
        public string ProbarEstado(string sTabla)
        {
            string sError = "";
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT estado FROM " + sTabla + ";", cn.ProbarConexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
            }
            catch (Exception)
            {
                sError = "La tabla " + sTabla.ToUpper() + " no contiene el campo de ESTADO";
            }
            return sError;
        }

        // Método que cuenta los registros activos en una tabla
        public int ProbarRegistros(string sTabla)
        {
            int iRegistros = 0;
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM " + sTabla + " where estado=1;", cn.ProbarConexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    iRegistros++;
                }
            }
            catch (Exception)
            {
            }

            return iRegistros;
        }
        //******************************************** CODIGO HECHO POR DIEGO MARROQUIN ***************************** 


        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 
        // Método para obtener los nombres de los campos de una tabla
        public string[] ObtenerCampos(string sTabla)
        {
            string[] sCampos = new string[30];
            int iIndex = 0;
            OdbcConnection conn = null;

            try
            {
                conn = cn.ProbarConexion();
                OdbcCommand command = new OdbcCommand("DESCRIBE " + sTabla + "", conn);
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    sCampos[iIndex] = reader.GetValue(0).ToString();
                    iIndex++;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en asignarCombo, revise los parámetros \n -" + sTabla);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    Console.WriteLine("Conexión cerrada después de obtener los campos");
                }
            }

            return sCampos;
        }
        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 


        //******************************************** CODIGO HECHO POR SEBASTIAN LETONA ***************************** 
        // Método para obtener las propiedades de las columnas de una tabla
        public List<(string nombreColumna, bool esAutoIncremental, bool esClaveForanea, bool esTinyInt)> ObtenerColumnasYPropiedades(string sNombreTabla)
        {
            List<(string, bool, bool, bool)> lColumnas = new List<(string, bool, bool, bool)>();

            try
            {
                string sQueryColumnas = $"SHOW COLUMNS FROM {sNombreTabla};";
                OdbcCommand comando = new OdbcCommand(sQueryColumnas, cn.ProbarConexion());
                OdbcDataReader lector = comando.ExecuteReader();

                HashSet<string> clavesForaneas = new HashSet<string>();

                string sQueryClavesForaneas = $@"
                    SELECT COLUMN_NAME
                    FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
                    WHERE TABLE_NAME = '{sNombreTabla}' AND REFERENCED_TABLE_NAME IS NOT NULL;";
                OdbcCommand comandoClaves = new OdbcCommand(sQueryClavesForaneas, cn.ProbarConexion());
                OdbcDataReader lectorClaves = comandoClaves.ExecuteReader();

                while (lectorClaves.Read())
                {
                    string sNombreColumnaForanea = lectorClaves.GetString(0);
                    clavesForaneas.Add(sNombreColumnaForanea);
                }

                lectorClaves.Close();

                while (lector.Read())
                {
                    string sNombreColumna = lector.GetString(0);
                    string sTipoColumna = lector.GetString(1);
                    string sColumnaExtra = lector.GetString(5);

                    bool bEsAutoIncremental = sColumnaExtra.Contains("auto_increment");
                    bool bEsClaveForanea = clavesForaneas.Contains(sNombreColumna);
                    bool bEsTinyInt = sTipoColumna.StartsWith("tinyint");

                    lColumnas.Add((sNombreColumna, bEsAutoIncremental, bEsClaveForanea, bEsTinyInt));
                }

                lector.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener columnas: " + ex.Message);
            }

            return lColumnas;
        }
        //******************************************** CODIGO HECHO POR SEBASTIAN LETONA ***************************** 


        //******************************************** CODIGO HECHO POR PABLO FLORES ***************************** 
        // Método para ejecutar una serie de consultas SQL dentro de una transacción
        public void EjecutarQueryConTransaccion(List<string> sQueries)
        {
            OdbcConnection connection = cn.ProbarConexion();
            OdbcTransaction transaction = null;

            try
            {
                transaction = connection.BeginTransaction();

                foreach (string sQuery in sQueries)
                {
                    OdbcCommand command = new OdbcCommand(sQuery, connection, transaction);
                    command.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                Console.WriteLine("Error en la transacción: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        // Método para obtener los tipos de datos de los campos en una tabla
        public string[] ObtenerTipo(string sTabla)
        {
            string[] sCampos = new string[30];
            int iIndex = 0;
            OdbcConnection conn = null;

            try
            {
                conn = cn.ProbarConexion();
                OdbcCommand command = new OdbcCommand("DESCRIBE " + sTabla + "", conn);
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    sCampos[iIndex] = LimpiarTipo(reader.GetValue(1).ToString());
                    iIndex++;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtenerTipo, revise los parámetros de la tabla  \n -" + sTabla.ToUpper() + "\n -");
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    Console.WriteLine("Conexión cerrada después de obtener el tipo de los campos");
                }
            }

            return sCampos;
        }
        //******************************************** CODIGO HECHO POR PABLO FLORES ***************************** 


        //******************************************** CODIGO HECHO POR JOSUE CACAO ***************************** 
        // Método para obtener las llaves de los campos en una tabla
        public string[] ObtenerLLave(string sTabla)
        {
            string[] sCampos = new string[30];
            int iIndex = 0;
            try
            {
                OdbcCommand command = new OdbcCommand("DESCRIBE " + sTabla + "", cn.ProbarConexion());
                OdbcDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    sCampos[iIndex] = reader.GetValue(3).ToString();
                    iIndex++;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtenerTipo, revise los parametros de la tabla  \n -" + sTabla + "\n -");
            }

            return sCampos;
        }

        // Método para obtener los ítems de un ComboBox desde la base de datos
        public Dictionary<string, string> ObtenerItems(string sTabla, string sCampoClave, string sCampoDisplay)
        {
            Dictionary<string, string> items = new Dictionary<string, string>();

            try
            {
                using (OdbcConnection connection = cn.ProbarConexion())
                {
                    // Validar si las columnas existen en la tabla
                    DataTable schemaTable = connection.GetSchema("Columns", new string[] { null, null, sTabla, null });
                    bool columnClaveExists = schemaTable.AsEnumerable().Any(row => row["COLUMN_NAME"].ToString() == sCampoClave);
                    bool columnDisplayExists = schemaTable.AsEnumerable().Any(row => row["COLUMN_NAME"].ToString() == sCampoDisplay);
                    Console.WriteLine($"Columna Clave Existe: {columnClaveExists}, Columna Display Existe: {columnDisplayExists}");

                    if (!columnClaveExists || !columnDisplayExists)
                    {
                        throw new Exception("El campo clave o el campo display no existen en la tabla.");
                    }

                    foreach (DataRow row in schemaTable.Rows)
                    {
                        Console.WriteLine(row["COLUMN_NAME"].ToString());
                    }

                    // Ejecutar la consulta
                    string query = $"SELECT {sCampoClave} AS KeyField, {sCampoDisplay} AS DisplayField FROM {sTabla} WHERE estado = 1";
                    Console.WriteLine("Query: " + query);

                    OdbcCommand command = new OdbcCommand(query, connection);
                    OdbcDataReader reader = command.ExecuteReader();

                    // Llenar el diccionario con los resultados
                    while (reader.Read())
                    {
                        string key = reader["KeyField"].ToString();
                        string value = reader["DisplayField"].ToString();

                        // Agregar los valores al diccionario
                        items.Add(key, value);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }

            return items;
        }

        //******************************************** CODIGO HECHO POR JOSUE CACAO ***************************** 


        //******************************************** CODIGO HECHO POR MATY MANCILLA ***************************** 
        // Método que limpia el tipo de dato de una cadena, eliminando la dimensión del campo
        string LimpiarTipo(string sCadena)
        {
            bool bDim = false;
            string sNuevaCadena = "";

            for (int iJIndex = 0; iJIndex < sCadena.Length; iJIndex++)
            {
                if (sCadena[iJIndex] == '(')
                {
                    bDim = true;
                }
            }

            if (bDim == true)
            {
                int iIndex = 0;

                int iTam = sCadena.Length;

                while (sCadena[iIndex] != '(')
                {
                    sNuevaCadena += sCadena[iIndex];
                    iIndex++;
                }

            }
            else
            {
                return sCadena;
            }

            return sNuevaCadena;
        }

        // Método para obtener la llave de un campo en la tabla
        public string LlaveCampo(string sTabla, string sCampo, string sValor)
        {
            string sLlave = "";
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM " + sTabla + " where " + sCampo + " = '" + sValor + "' ;", cn.ProbarConexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                sLlave = reader.GetValue(0).ToString();
            }
            catch (Exception)
            {

            }
            return sLlave;
        }

        // Método para obtener la llave de un campo en reverso 
        public string LlaveCampoReverso(string sTabla, string sCampo, string sValor)
        {
            string sLlave = "";
            string[] sCampos = ObtenerCampos(sTabla);
            try
            {
                string sValorFormateado = "'" + sValor + "'";

                string sQuery = $"SELECT {sCampo} FROM {sTabla} WHERE {sCampos[0]} = {sValorFormateado};";

                OdbcCommand command = new OdbcCommand(sQuery, cn.ProbarConexion());
                OdbcDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    sLlave = reader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dio errore: " + ex.ToString());
            }
            return sLlave;
        }
        //******************************************** CODIGO HECHO POR MATY MANCILLA ***************************** 


        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 
        // Método para obtener el ID del módulo basado en el ID de la aplicación
        public string IdModulo(string sAplicacion)
        {
            string sLlave = "";
            try
            {
                OdbcCommand command = new OdbcCommand("SELECT * FROM tbl_aplicacion" + " where" + " PK_id_aplicacion= " + sAplicacion + " ;", cn.ProbarConexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                sLlave = reader.GetValue(0).ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dio errore " + "SELECT * FROM tbl_aplicacion" + " where" + " PK_id_aplicacion= " + sAplicacion + " ;" + ex.ToString());
            }
            return sLlave;
        }

        // Método para ejecutar una consulta SQL
        public void EjecutarQuery(string sQuery)
        {
            try
            {
                OdbcCommand consulta = new OdbcCommand(sQuery, cn.ProbarConexion());
                consulta.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 


        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS ***************************** 
        // Método para obtener la clave primaria de una tabla
        public string ObtenerClavePrimaria(string sNombreTabla)
        {
            string sClavePrimaria = "";
            try
            {
                string sQuery = $"SHOW KEYS FROM {sNombreTabla} WHERE Key_name = 'PRIMARY';";

                OdbcCommand command = new OdbcCommand(sQuery, cn.ProbarConexion());

                OdbcDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    sClavePrimaria = reader["Column_name"].ToString();
                    Console.WriteLine($"Clave primaria de {sNombreTabla}: {sClavePrimaria}");
                }
                else
                {
                    throw new Exception("No se encontró una clave primaria para la tabla: " + sNombreTabla);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener la clave primaria de la tabla " + sNombreTabla + ": " + ex.ToString());
            }

            return sClavePrimaria;
        }

        // Método para obtener la clave foránea que referencia a otra tabla
        public string ObtenerClaveForanea(string sTablaOrigen, string sTablaReferencia)
        {
            string sClaveForanea = null;

            try
            {
                string sQuery = $@"
            SELECT COLUMN_NAME 
            FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE 
            WHERE TABLE_SCHEMA = DATABASE()
            AND TABLE_NAME = '{sTablaOrigen}' 
            AND REFERENCED_TABLE_NAME = '{sTablaReferencia}';";

                OdbcCommand command = new OdbcCommand(sQuery, cn.ProbarConexion());
                OdbcDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    sClaveForanea = reader.GetString(0);
                    Console.WriteLine($"Clave foránea de {sTablaOrigen} que referencia a {sTablaReferencia}: {sClaveForanea}");
                }
                else
                {
                    Console.WriteLine($"No se encontró clave foránea en {sTablaOrigen} que referencia a {sTablaReferencia}");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener clave foránea: " + ex.Message);
            }

            return sClaveForanea;
        }

        // Asumiendo que tienes una clase para la conexión

        // Método para obtener las relaciones de claves foráneas desde la base de datos

        public string ObtenerCampoDisplay(string tablaRelacionada)
        {
            string campoDisplay = null;

            try
            {
                using (OdbcConnection connection = cn.ProbarConexion())
                {
                    // Consulta para encontrar columnas que probablemente sean descriptivas
                    string sQuery = $@"
            SELECT COLUMN_NAME 
            FROM INFORMATION_SCHEMA.COLUMNS 
            WHERE TABLE_SCHEMA = DATABASE() 
            AND TABLE_NAME = '{tablaRelacionada}' 
            AND (COLUMN_NAME LIKE '%nombre%' OR COLUMN_NAME LIKE '%descripcion%' OR COLUMN_NAME LIKE '%titulo%' OR COLUMN_NAME LIKE '%detalle%');";

                    OdbcCommand command = new OdbcCommand(sQuery, connection);
                    OdbcDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        campoDisplay = reader.GetString(0);  // Toma el primer resultado como campo display
                        Console.WriteLine($"Campo descriptivo encontrado en {tablaRelacionada}: {campoDisplay}");
                    }
                    else
                    {
                        Console.WriteLine($"No se encontró un campo descriptivo en {tablaRelacionada}. Usando la clave primaria.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el campo display: {ex.Message}");
            }

            return campoDisplay;
        }

        public (string tablaRelacionada, string campoClave, string campoDisplay) ObtenerRelacionesForaneas(string sTablaOrigen, string sCampo)
        {
            string tablaRelacionada = null;
            string campoClave = null;
            string campoDisplay = null;

            try
            {
                string sQuery = $@"
        SELECT REFERENCED_TABLE_NAME, REFERENCED_COLUMN_NAME 
        FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE 
        WHERE TABLE_SCHEMA = DATABASE()
        AND TABLE_NAME = '{sTablaOrigen}' 
        AND COLUMN_NAME = '{sCampo}';";

                OdbcCommand command = new OdbcCommand(sQuery, cn.ProbarConexion());
                OdbcDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    tablaRelacionada = reader.GetString(0);  // Tabla relacionada
                    campoClave = reader.GetString(1);        // Clave relacionada (ID)

                    Console.WriteLine($"Clave foránea de {sTablaOrigen} que referencia a {tablaRelacionada}: {campoClave}");

                    // Usar la nueva función para obtener el campo display
                    campoDisplay = ObtenerCampoDisplay(tablaRelacionada);

                    // Si no se encontró un campo display, usar la clave
                    if (string.IsNullOrEmpty(campoDisplay))
                    {
                        campoDisplay = campoClave;
                    }
                }
                else
                {
                    Console.WriteLine($"No se encontró clave foránea en {sTablaOrigen} para el campo {sCampo}");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener clave foránea: " + ex.Message);
            }

            return (tablaRelacionada, campoClave, campoDisplay);
        }


        public OdbcDataAdapter llenarTblAyuda(string tabla)
        {
            string sql = "SELECT * FROM " + tabla + " ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.ProbarConexion());
            return dataTable;
        }

        //******************************************** CODIGO HECHO POR VICTOR CASTELLANOS ***************************** 

        //******************************************** CODIGO HECHO POR BRAYAN HERNANDEZ ***************************** 
        public List<Dictionary<string, string>> ObtenerDatosTablaRelacionada(string tabla, string primaryKeyValue, string tablaPrincipal)
        {
            List<Dictionary<string, string>> listaDatosExtra = new List<Dictionary<string, string>>();

            string claveForanea = ObtenerClaveForanea(tabla, tablaPrincipal);
            if (string.IsNullOrEmpty(claveForanea))
            {
                Console.WriteLine($"No se encontró clave foránea para la tabla {tabla} con la tabla principal {tablaPrincipal}");
                return listaDatosExtra;
            }

            string consultaSQL = $"SELECT * FROM {tabla} WHERE {claveForanea} = ?";
            using (var connection = cn.ProbarConexion())
            {
                using (OdbcCommand command = new OdbcCommand(consultaSQL, connection))
                {
                    command.Parameters.AddWithValue("", primaryKeyValue);

                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, string> datosExtra = new Dictionary<string, string>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string nombreCampo = reader.GetName(i);
                                string valorCampo = reader[i].ToString();
                                datosExtra[nombreCampo] = valorCampo;
                            }
                            listaDatosExtra.Add(datosExtra);
                        }
                    }
                }
            }

            return listaDatosExtra;
        }

        public string ObtenerValorCampo(string tabla, string campo, string clavePrimaria, string valorClavePrimaria)
        {
            string valor = "";
            try
            {
                // Ajustamos la consulta para que busque en base a la clave primaria específica
                string query = $"SELECT {campo} FROM {tabla} WHERE {clavePrimaria} = {valorClavePrimaria} AND estado = 1 LIMIT 1;";

                OdbcCommand command = new OdbcCommand(query, cn.ProbarConexion());
                OdbcDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    valor = reader[campo].ToString();  // Se obtiene el valor del campo
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el valor del campo: " + ex.Message);
            }
            return valor;
        }


        public void ActualizarCampo(string tabla, string campo, string nuevoValor, string claveCondicional, string valorCondicional)
        {
            try
            {
                // Construir la consulta UPDATE usando la clave condicional para identificar el registro correcto
                string query = $"UPDATE {tabla} SET {campo} = {nuevoValor} WHERE {claveCondicional} = {valorCondicional} AND estado = 1;";

                // Ejecutar la consulta
                using (OdbcCommand command = new OdbcCommand(query, cn.ProbarConexion()))
                {
                    command.ExecuteNonQuery();
                }

                Console.WriteLine("Campo actualizado exitosamente.");
                Console.WriteLine(" Query generado: " + query);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el campo: " + ex.Message);
            }
        }





        // Capa Modelo: sentencias
        public string ObtenerTipoCampo(string tabla, string campo)
        {
            string tipoCampo = "";
            OdbcConnection conn = null;

            try
            {
                conn = cn.ProbarConexion();
                string sQuery = $"DESCRIBE {tabla} {campo};"; // Comando SQL para obtener la descripción del campo
                OdbcCommand command = new OdbcCommand(sQuery, conn);
                OdbcDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    tipoCampo = reader.GetString(1); // Tipo de dato está en la segunda columna (índice 1)
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el tipo de campo {campo} en la tabla {tabla}: {ex.Message}");
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return tipoCampo; // Retorna el tipo de dato (ejemplo: int, varchar, etc.)
        }
        public void IniciarTransaccion()
        {
            connection = cn.ProbarConexion();
            transaction = connection.BeginTransaction();
        }

        // Método para ejecutar una consulta dentro de una transacción
        public void EjecutarQueryTransaccion(string sQuery)
        {
            try
            {
                OdbcCommand command = new OdbcCommand(sQuery, connection, transaction);
                command.ExecuteNonQuery();
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al ejecutar consulta en transacción: " + ex.Message);
                throw;
            }
        }

        // Método para confirmar (commit) la transacción
        public void CommitTransaccion()
        {
            try
            {
                if (transaction != null)
                {
                    transaction.Commit();
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al hacer commit de la transacción: " + ex.Message);
                throw;
            }
            finally
            {
                CerrarConexion();
            }
        }

        // Método para deshacer (rollback) la transacción
        public void RollbackTransaccion()
        {
            try
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error al hacer rollback de la transacción: " + ex.Message);
                throw;
            }
            finally
            {
                CerrarConexion();
            }
        }

        // Método para cerrar la conexión
        private void CerrarConexion()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Conexión cerrada después de la transacción.");
            }
        }

        public string InsertarYObtenerUltimoId(string queryInsert)
        {
            string ultimoId = "";
            try
            {
                // Usar la misma conexión y transacción para el INSERT y la obtención del ID
                using (OdbcCommand cmd = new OdbcCommand(queryInsert, connection, transaction))
                {
                    cmd.ExecuteNonQuery();
                    // Obtener el último ID insertado
                    OdbcCommand getIdCmd = new OdbcCommand("SELECT LAST_INSERT_ID();", connection, transaction);
                    ultimoId = getIdCmd.ExecuteScalar()?.ToString();
                    if (string.IsNullOrEmpty(ultimoId))
                    {
                        throw new Exception("No se pudo obtener el último ID.");
                    }
                    Console.WriteLine("Último ID insertado: " + ultimoId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar y obtener el último ID: " + ex.Message);
                throw;
            }
            return ultimoId;
        }

        public void InsertarConTransaccion(string queryInsertPrincipal, List<string> queriesAdicionales)
        {
            try
            {
                IniciarTransaccion(); // Inicia la transacción

                // Inserta en la tabla principal y obtiene el último ID
                string ultimoId = InsertarYObtenerUltimoId(queryInsertPrincipal);

                if (string.IsNullOrEmpty(ultimoId) || ultimoId == "0")
                {
                    throw new Exception("Error al obtener el último ID después de insertar en la tabla principal.");
                }

                // Inserta en las tablas adicionales usando el último ID
                foreach (var queryAdicional in queriesAdicionales)
                {
                    EjecutarQueryTransaccion(queryAdicional.Replace("{ultimoId}", ultimoId));
                }

                CommitTransaccion(); // Confirma la transacción si todo está bien
                Console.WriteLine("Transacción realizada exitosamente.");
            }
            catch (Exception ex)
            {
                RollbackTransaccion(); // Reversa la transacción si algo falla
                Console.WriteLine("Error en la transacción: " + ex.Message);
            }
        }

        public string ObtenerIdPorValorDescriptivo(string tabla, string campoClave, string campoDescriptivo, string valorDescriptivo)
        {
            string id = null;

            // Construimos la consulta SQL utilizando parámetros
            string query = $"SELECT {campoClave} FROM {tabla} WHERE {campoDescriptivo} = ?";

            try
            {
                // Abre la conexión y ejecuta la consulta
                using (OdbcConnection conexion = cn.ProbarConexion())
                {
                    conexion.Open(); // Aseguramos que la conexión esté abierta
                    using (OdbcCommand command = new OdbcCommand(query, conexion))
                    {
                        // Agrega el valor descriptivo como parámetro
                        command.Parameters.AddWithValue("?", valorDescriptivo);

                        // Ejecuta la consulta y lee el resultado
                        using (OdbcDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Asigna el valor del campo clave encontrado
                                id = reader[campoClave].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Muestra en consola el error encontrado
                Console.WriteLine($"Error al obtener el ID para {valorDescriptivo}: {ex.Message}");
                Console.WriteLine($"Error al obtener el ID para {query}: {ex.Message}");
                return null; // Retorna null si hubo un error
            }

            // Retorna el ID encontrado, o null si no se encontró ningún registro
            Console.WriteLine($"Error al obtener el ID para {query}");
            return id;
        }

        public string GenerarInsertCondicional(string tabla, Dictionary<string, string> valoresComponentes, Dictionary<string, string> mapeoComponentesCampos)
        {
            try
            {
                var columnasPropiedades = ObtenerColumnasYPropiedades(tabla);
                var camposValidos = columnasPropiedades
                    .Where(c => !c.esAutoIncremental) // Permitir claves foráneas
                    .Select(c => c.nombreColumna)
                    .ToList();

                var sCampos = new List<string>();
                var sValoresCampos = new List<string>();

                // Construir el mapeo de valores para el `INSERT`
                foreach (var map in mapeoComponentesCampos)
                {
                    string campo = map.Value; // Campo en la tabla
                    if (camposValidos.Contains(campo) && valoresComponentes.TryGetValue(map.Key, out var valor))
                    {
                        sCampos.Add(campo);
                        sValoresCampos.Add($"'{valor}'");
                    }
                }

                if (!sCampos.Any())
                {
                    Console.WriteLine("Error: No hay valores válidos para insertar.");
                    return null;
                }

                // Crear la consulta `INSERT` como `string`
                string query = $"INSERT INTO {tabla} ({string.Join(", ", sCampos)}) VALUES ({string.Join(", ", sValoresCampos)});";
                Console.WriteLine("CONDICIONAL QUERY GENERADA: " + query);
                return query;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al generar la consulta de inserción: {ex.Message}");
                return null;
            }
        }

    }
}
