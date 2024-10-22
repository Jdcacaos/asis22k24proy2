using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;


namespace Capa_Modelo_Logistica
{
    public class Sentencias
    {
        string sTabla_chofer = "Tbl_chofer";
        Conexion cn = new Conexion();

        // Método para cargar las existencias de una bodega en particular (Realizado por Daniel Sierra 0901-21-12740)
        public OdbcDataReader ObtenerExistenciasBodega(string idBodega)
        {
            OdbcDataReader dr = null;
            OdbcConnection conn = cn.conexion(); // Mover la conexión aquí

            try
            {
                string query = $"SELECT * FROM TBL_EXISTENCIAS_BODEGA WHERE Fk_ID_BODEGA = '{idBodega}'";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener existencias: " + ex.Message);
                dr = null; // Asegurarse de que dr sea null en caso de error
            }

            // La conexión se cerrará cuando el DataReader haya sido cerrado en el controlador
            return dr;
        }



        // Método para insertar una auditoría de inventario (Realizado por Daniel Sierra 0901-21-12740)
        public void InsertarAuditoria(string idBodega, string idProducto, int cantidadFisica, int cantidadRegistrada, bool discrepancia)
        {
            OdbcConnection conn = cn.conexion();
            try
            {
                string query = "INSERT INTO Auditorias (BodegaID, ProductoID, CantidadFisica, CantidadRegistrada, Discrepancia) VALUES (?, ?, ?, ?, ?)";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("@BodegaID", idBodega);
                cmd.Parameters.AddWithValue("@ProductoID", idProducto);
                cmd.Parameters.AddWithValue("@CantidadFisica", cantidadFisica);
                cmd.Parameters.AddWithValue("@CantidadRegistrada", cantidadRegistrada);
                cmd.Parameters.AddWithValue("@Discrepancia", discrepancia);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar auditoría: " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close(); // Asegurarse de cerrar la conexión
                }
            }
        }


        public void InsertarSolicitudMantenimiento(int idMantenimiento, string nombreSolicitante, string tipoMantenimiento, string componenteAfectado, string fecha, string responsableAsignado, string codigo_error_Problema, string estadoMantenimiento, string tiempoEstimado, int id_Movimiento)
        {
            OdbcConnection conn = cn.conexion();
            try
            {
                string query = "INSERT INTO tbl_mantenimiento VALUES (Pk_id_Mantenimiento, nombre_Solicitante, tipo_de_Mantenimiento, componente_Afectado, fecha, responsable_Asignado, codigo_Error_Problema, Estado, tiempo_Estimado, Fk_id_movimiento)";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("@Pk_id_Mantenimiento", idMantenimiento);
                cmd.Parameters.AddWithValue("@nombre_Solicitante", nombreSolicitante);
                cmd.Parameters.AddWithValue("@tipo_de_mantenimiento", tipoMantenimiento);
                cmd.Parameters.AddWithValue("@componente_Afectado", componenteAfectado);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@responsable_Asignado", responsableAsignado);
                cmd.Parameters.AddWithValue("@codigo_Error_Problema", codigo_error_Problema);
                cmd.Parameters.AddWithValue("@Estado", estadoMantenimiento);
                cmd.Parameters.AddWithValue("@tiempo_Estimado", tiempoEstimado);
                cmd.Parameters.AddWithValue("@Fk_id_movimiento", id_Movimiento);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar solicitud de mantenimiento: " + ex.Message);

            }
            finally
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close(); // Asegurarse de cerrar la conexión
                }
            }
        }
        // Método para obtener Bodegas en la tabla (Realizado por Daniel Sierra 0901-21-12740)

        public List<KeyValuePair<int, string>> GetBodegas()
        {
            string sQuery = "SELECT Pk_ID_BODEGA, NOMBRE_BODEGA FROM TBL_BODEGAS;";
            List<KeyValuePair<int, string>> bodegas = new List<KeyValuePair<int, string>>();

            using (OdbcConnection conn = cn.conexion())
            {
                try
                {
                    OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conn);
                    DataTable table = new DataTable();
                    dataTable.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        int idBodega = Convert.ToInt32(row["Pk_ID_BODEGA"]);
                        string nombreBodega = row["NOMBRE_BODEGA"].ToString();
                        bodegas.Add(new KeyValuePair<int, string>(idBodega, nombreBodega));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla TBL_BODEGAS");
                }
            }

            return bodegas;
        }
        // Método para obtener Productos en la tabla (Realizado por Daniel Sierra 0901-21-12740)

        public List<KeyValuePair<int, string>> GetProductos()
        {
            string sQuery = "SELECT Pk_id_Producto, nombreProducto FROM Tbl_Productos;";
            List<KeyValuePair<int, string>> productos = new List<KeyValuePair<int, string>>();

            using (OdbcConnection conn = cn.conexion())
            {
                try
                {
                    OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conn);
                    DataTable table = new DataTable();
                    dataTable.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        int idProducto = Convert.ToInt32(row["Pk_id_Producto"]);
                        string nombreProducto = row["nombreProducto"].ToString();
                        productos.Add(new KeyValuePair<int, string>(idProducto, nombreProducto));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla Tbl_Productos");
                }
            }

            return productos;
        }

        public List<string> GetProductosPorBodega(string idBodega)
        {
            string sQuery = $"SELECT Pk_ID_PRODUCTO, NOMBRE_PRODUCTO FROM Tbl_Productos WHERE Fk_ID_BODEGA = '{idBodega}';"; // Asegúrate de que esta consulta sea correcta según tu esquema
            List<string> productos = new List<string>();

            using (OdbcConnection conn = cn.conexion())
            {
                try
                {
                    OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conn);
                    DataTable table = new DataTable();
                    dataTable.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        productos.Add(row["NOMBRE_PRODUCTO"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla Tbl_Productos");
                }
            }

            return productos;
        }
        // Método para insertar auditorías (Realizado por José daniel sierra cruz)

        public string InsertarAuditoria(int idBodega, int idProducto, DateTime fechaAuditoria, string observaciones, int cantidadRegistrada, int cantidadFisica, bool discrepancia)
        {
            using (OdbcConnection conn = cn.conexion())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO TBL_AUDITORIAS (Fk_ID_BODEGA, Fk_ID_PRODUCTO, FECHA_AUDITORIA, OBSERVACIONES, CANTIDAD_REGISTRADA, CANTIDAD_FISICA, DISCREPANCIA_DETECTADA) " +
                                   "VALUES (?, ?, ?, ?, ?, ?, ?)";
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        // Establecer los parámetros
                        cmd.Parameters.AddWithValue("?", idBodega);
                        cmd.Parameters.AddWithValue("?", idProducto);
                        cmd.Parameters.AddWithValue("?", fechaAuditoria);
                        cmd.Parameters.AddWithValue("?", observaciones);
                        cmd.Parameters.AddWithValue("?", cantidadRegistrada);
                        cmd.Parameters.AddWithValue("?", cantidadFisica);
                        cmd.Parameters.AddWithValue("?", discrepancia);

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0 ? "Auditoría realizada con éxito" : "No se insertaron registros en la auditoría.";
                    }
                }
                catch (OdbcException ex)
                {
                    return "Error al realizar auditoría: " + ex.Message;
                }
                catch (Exception ex)
                {
                    return "Error inesperado: " + ex.Message;
                }
            }
        }

        // Método para obtener auditorías (Realizado por José daniel sierra cruz)
        public DataTable ObtenerAuditorias()
        {
            DataTable dtAuditorias = new DataTable();

            try
            {
                using (OdbcConnection conn = cn.conexion())
                {
                    string query = "SELECT * FROM TBL_AUDITORIAS";
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                        {
                            da.Fill(dtAuditorias); // Llenar el DataTable con los datos de auditorías
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener auditorías: " + ex.Message);
            }

            return dtAuditorias;
        }


        // Realizado  Metodo de ingreso de chofer por Ammy Patricia Catún López - 0901-21-4857
        public void registrarChofer(string id_chofer, string nombreEmp, string numeroIdent, string nombre, string licencia, string telefono, string direccion)
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {
                int ingreso = 0;
                string sCampos = "Pk_id_chofer, nombreEmpresa, numeroIdentificacion, nombre, licencia, telefono, direccion";
                string sSql = "INSERT INTO " + sTabla_chofer + " (" + sCampos + ") VALUES ('" + id_chofer + "', '" + nombreEmp + "', '" + numeroIdent + "', '" + nombre + "', '" + licencia + "', '" + telefono + "', '" + direccion + "');";
                OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion());
                ingreso = cmd.ExecuteNonQuery();
                if (ingreso > 0)
                {
                    MessageBox.Show("Datos Ingresados Correctamente");
                }
                else
                {
                    MessageBox.Show("Datos No Ingresados Correctamente");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + sTabla_chofer);
            }
        }
        public int getMaxIdChofer()
        {
            int iIdRegistro = 0;
            string sSql = "SELECT max(Pk_id_chofer) FROM " + sTabla_chofer + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion());
                iIdRegistro = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo obtener el id del registro en la tabla " + sTabla_chofer);
            }
            return iIdRegistro;
        }


        // Boton eliminado de chofer realizado por Ammy Patricia Catún López - 0901-21-4857
        public void eliminarChofer(string idChofer)
        {
            try
            {
                string sSql = "DELETE FROM " + sTabla_chofer + " WHERE Pk_id_chofer = '" + idChofer + "';";
                OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion());
                int resultado = cmd.ExecuteNonQuery();
                if (resultado > 0)
                {
                    MessageBox.Show("Chofer eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el chofer para eliminar.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo eliminar el registro en la tabla " + sTabla_chofer);
            }
        }
        //Metodo de modificar chofer realizado por Ammy Patricia Catún López - 0901-21-4857
        public void modificarChofer(string idChofer, string nombreEmp, string numeroIdent, string nombre, string licencia, string telefono, string direccion)
        {
            try
            {
                string sSql = "UPDATE " + sTabla_chofer + " SET nombreEmpresa = @nombreEmp, numeroIdentificacion = @numeroIdent, nombre = @nombre, licencia = @licencia, telefono = @telefono, direccion = @direccion WHERE Pk_id_chofer = @idChofer;";

                using (OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion()))
                {
                    cmd.Parameters.AddWithValue("@idChofer", idChofer);
                    cmd.Parameters.AddWithValue("@nombreEmp", nombreEmp);
                    cmd.Parameters.AddWithValue("@numeroIdent", numeroIdent);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@licencia", licencia);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@direccion", direccion);

                    int resultado = cmd.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Chofer modificado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el chofer para modificar.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo modificar el registro en la tabla " + sTabla_chofer);
            }
        }


        //Metodo de buscar chofer realizado por Ammy Patricia Catún López - 0901-21-4857
        public DataTable buscarChofer(string idChofer)
        {
            DataTable dt = new DataTable();
            try
            {
                string sSql = "SELECT * FROM " + sTabla_chofer + " WHERE Pk_id_chofer = @idChofer;";
                using (OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion()))
                {
                    cmd.Parameters.AddWithValue("@idChofer", idChofer);
                    OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo buscar el registro en la tabla " + sTabla_chofer);
            }
            return dt;
        }
        public DataTable cargarChoferes()
        {
            DataTable dt = new DataTable();
            try
            {
                string sSql = "SELECT * FROM " + sTabla_chofer + ";";
                using (OdbcCommand cmd = new OdbcCommand(sSql, cn.conexion()))
                {
                    OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " \nNo se pudo cargar los choferes desde la tabla " + sTabla_chofer);
            }
            return dt;
        }
    }
}