using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaModeloActivofijo
{
    public class Sentencias
    {
        Conexion conectar = new Conexion();

        public OdbcDataAdapter llenarTablaActivoFijo(string tabla)
        {
            // Construye la consulta SQL para obtener los datos de la tabla tbl_ActivoFijo
            string sql = "SELECT af.Pk_Id_ActivoFijo AS ID_Activo, " + // Asegúrate de que este nombre coincida con tu esquema
                          "af.Codigo_Activo AS Codigo_Activo, " +
                          "af.Pk_Id_TipoActivoFijo AS ID_Tipo_Activo, " + // Ajusta si el nombre es diferente
                          "af.Descripcion AS Descripcion, " +
                          "af.Pk_Id_Identidad AS ID_Marca, " + // Asegúrate de que este nombre coincida con tu esquema
                          "af.Modelo AS Modelo, " +
                          "af.Fecha_Adquisicion AS Fecha_de_Aquisicion, " +
                          "af.Costo_Adquisicion AS Costo_de_Aquisicion, " +
                          "af.Vida_Util AS Vida_Util, " +
                          "af.Valor_Residual AS Valor_Residual, " +
                          "af.Estado AS Estado, " +
                          "af.Pk_Id_Cuenta AS ID_Cuenta " +
                          "FROM " + tabla + " af";

            // Crea un objeto OdbcDataAdapter y le pasa la consulta SQL y la conexión
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conectar.conectar());

            // Retorna el objeto OdbcDataAdapter con los datos obtenidos
            return dataTable;
        }

        public DataTable Buscar(string tabla, string columna, string dato)
        {
            string consulta = $"SELECT * FROM {tabla} WHERE {columna} = '{dato}'";
            OdbcDataAdapter datos = new OdbcDataAdapter(consulta, conectar.conectar());

            DataTable dt = new DataTable();
            datos.Fill(dt);

            return dt;
        }

        public List<string> llenarCombo(string columna1, string tabla)
        {
            List<string> datos = new List<string>();
            try
            {

                string consulta = $"SELECT {columna1} FROM {tabla}";

                OdbcCommand command = new OdbcCommand(consulta, conectar.conectar());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string ID = reader[columna1].ToString();
                    datos.Add(ID);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return datos;

        }

        public void InsertarDepreciacionActivo(DateTime fechaDepreciacion, int idActivoFijo, string nombreActivo, string tipoActivo, string encargado, string departamento, double depreciacion, double depreciacionFiscal, string descripcion, int estado, int idCuenta)
        {
            using (OdbcConnection connection = conectar.conectar())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Insertar en la tabla tbl_Depreciacion_ActivoFijo
                            string insertQuery = "INSERT INTO tbl_Depreciacion_ActivoFijo (Pk_Id_ActivoFijo, Nombre_Activo, Tipo_Activo, " +
                                                 "Encargado, Departamento, Fecha_Depreciacion, Depreciacion, Depreciacion_Fiscal, " +
                                                 "Descripcion, Estado, Pk_Id_Cuenta) " +
                                                 "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Pk_Id_ActivoFijo", idActivoFijo);
                                cmd.Parameters.AddWithValue("@Nombre_Activo", nombreActivo);
                                cmd.Parameters.AddWithValue("@Tipo_Activo", tipoActivo);
                                cmd.Parameters.AddWithValue("@Encargado", encargado);
                                cmd.Parameters.AddWithValue("@Departamento", departamento);
                                cmd.Parameters.AddWithValue("@Fecha_Depreciacion", fechaDepreciacion);
                                cmd.Parameters.AddWithValue("@Depreciacion", depreciacion);
                                cmd.Parameters.AddWithValue("@Depreciacion_Fiscal", depreciacionFiscal);
                                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                                cmd.Parameters.AddWithValue("@Estado", estado); // Cambiado a int según la nueva definición
                                cmd.Parameters.AddWithValue("@Pk_Id_Cuenta", idCuenta);

                                cmd.ExecuteNonQuery();
                            }

                            // Confirmar la transacción si la inserción fue exitosa
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            // Revertir la transacción si ocurre algún error
                            transaction.Rollback();
                            Console.WriteLine($"Error al insertar depreciación de activo fijo: {ex.Message}");
                            MessageBox.Show("Error al guardar datos en la tabla de depreciación.");
                        }
                    }
                }
            }
        
    }

        public DataTable BuscarConEstado(string tabla, string columna, string dato, string estado)
        {
            // Crear la consulta con parámetros
            string query = $"SELECT * FROM {tabla} WHERE {columna} = ? AND Estado = ?";

            // Crear una conexión usando Odbc
            using (OdbcConnection connection = conectar.conectar())
            {
                // Crear el comando y agregar los parámetros
                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@dato", dato);
                    cmd.Parameters.AddWithValue("@estado", estado);

                    // Usar OdbcDataAdapter para llenar el DataTable
                    OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable ObtenerRegistrosConEstado(string tabla, string columna, string estado)
        {
            DataTable dt = new DataTable();

            // Crear la consulta con parámetros
            string query = $"SELECT {columna} FROM {tabla} WHERE Estado = ?";

            // Crear una conexión usando Odbc
            using (OdbcConnection connection = conectar.conectar())
            {
                // Crear el comando y agregar el parámetro
                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);

                    // Usar OdbcDataAdapter para llenar el DataTable
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }


        public void ActualizarEstadoActivoFijo(int idActivoFijo, int estado)
        {
            // Crear la consulta con parámetros
            string query = "UPDATE tbl_ActivoFijo SET Estado = ? WHERE Pk_Id_ActivoFijo = ?";

            // Crear una conexión usando Odbc                          
            using (OdbcConnection connection = conectar.conectar())
            {
                // Crear el comando y agregar los parámetros
                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    // Agregar parámetros en el orden correcto
                    cmd.Parameters.AddWithValue("@estado", estado); // Cambiado a int según la nueva definición
                    cmd.Parameters.AddWithValue("@idActivoFijo", idActivoFijo);

                    // Abrir la conexión
                    

                    // Ejecutar la consulta
                    cmd.ExecuteNonQuery();
                } // El using cerrará automáticamente el OdbcCommand
            } // El using cerrará automáticamente la OdbcConnection
        }

        public DataTable ObtenerRegistrosDepreciacion(int idActivoFijo)
        {
            DataTable dt = new DataTable();

            // Crear la consulta con parámetros
            string query = "SELECT * FROM tbl_Depreciacion_ActivoFijo WHERE Pk_Id_ActivoFijo = ?";

            // Crear una conexión usando Odbc
            using (OdbcConnection connection = conectar.conectar())
            {
              

                // Crear el comando y agregar el parámetro
                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    // Usar el símbolo correcto para el parámetro de ODBC (no es necesario especificar nombre)
                    cmd.Parameters.AddWithValue("?", idActivoFijo);

                    // Usar OdbcDataAdapter para llenar el DataTable
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt; // Devolver solo los registros para el idActivoFijo especificado
        }

        public DataTable CargarReporte(int idActivoFijo)
        {
            // Obtener los registros de depreciación para el activo fijo especificado
            DataTable dtReporte = ObtenerRegistrosDepreciacion(idActivoFijo);

            return dtReporte; 
        }

        public void InsertarMantenimiento(int idActivoFijo2, string companiaAsegurada, string agenteSeguro, string telSiniestro, string tipoCobertura, double montoAsegurado, double primaTotal, double deducible,  DateTime vigencia, DateTime fechaUtil, double costoServicio, int periodoServicio, DateTime proxServicio, int estado)
        {
            using (OdbcConnection connection = conectar.conectar())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO tbl_historial_servicio (Pk_Id_ActivoFijo, Compania_Asegurada, Agente_Seguro, " +
                                         "Tel_Siniestro, Tipo_Cobertura, Monto_Asegurado, Prima_Total, Deducible, Vigencia, " +
                                         "Fecha_Util, Costo_Servicio, Periodo_Servicio, Prox_Servicio, Estado) " +
                                         "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                        using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("Pk_Id_ActivoFijo", idActivoFijo2);
                            cmd.Parameters.AddWithValue("Compania_Asegurada", companiaAsegurada);
                            cmd.Parameters.AddWithValue("Agente_Seguro", agenteSeguro);
                            cmd.Parameters.AddWithValue("Tel_Siniestro", telSiniestro);
                            cmd.Parameters.AddWithValue("Tipo_Cobertura", tipoCobertura);
                            cmd.Parameters.AddWithValue("Monto_Asegurado", montoAsegurado);
                            cmd.Parameters.AddWithValue("Prima_Total", primaTotal);
                            cmd.Parameters.AddWithValue("Deducible", deducible);
                            cmd.Parameters.AddWithValue("Vigencia", vigencia);
                            cmd.Parameters.AddWithValue("Fecha_Util", fechaUtil);
                            cmd.Parameters.AddWithValue("Costo_Servicio", costoServicio);
                            cmd.Parameters.AddWithValue("Periodo_Servicio", periodoServicio);
                            cmd.Parameters.AddWithValue("Prox_Servicio", proxServicio);
                            cmd.Parameters.AddWithValue("Estado", estado);

                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error al guardar datos en la tabla de historial de servicio: {ex.Message}");
                        }
                    }
                }
            }
        }

        public DataTable ObtenerRegistrosHistorialServicio(int idActivoFijo)
        {
            DataTable dt = new DataTable();

            // Crear la consulta con parámetros
            string query = "SELECT * FROM tbl_historial_servicio WHERE Pk_Id_ActivoFijo = ?";

            // Crear una conexión usando Odbc
            using (OdbcConnection connection = conectar.conectar())
            {
                // Crear el comando y agregar el parámetro
                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    // Usar el símbolo correcto para el parámetro de ODBC (no es necesario especificar nombre)
                    cmd.Parameters.AddWithValue("?", idActivoFijo);

                    // Usar OdbcDataAdapter para llenar el DataTable
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt; // Devolver solo los registros para el idActivoFijo especificado
        }

    }
}
    








