using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_Modelo_Cuentas_Corrientes
{
    public class Sentencias
    {
       string sTabla_transaccion = "Tbl_Transaccion_cliente";
        Conexion conexion = new Conexion();
        public OdbcDataAdapter DisplayTransacciones()// método que obtiene el contenido de la tabla reportes
        {
            string sSql = "SELECT PK_id_transaccion, Fk_id_clientes, Fk_id_pais, fecha_transaccion, cuenta_transaccion, cuotas_transaccion, Fk_id_deuda" +
                "monto_deuda, monto_transaccion, saldo_pendiente, Fk_id_pago, tipo_moneda, serie_transaccion, estado_transaccion FROM " 
                + sTabla_transaccion + " WHERE Pk_id_transaccion IS NOT NULL AND Pk_id_transaccion != '';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_transaccion);
            }
            return dataTable;
        }

        public int getMaxIdTransaccion()
        {
            int iPk_id_transaccion = 0;
            string sSql = "SELECT max(Pk_id_transaccion) FROM " + sTabla_transaccion + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                iPk_id_transaccion = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo obtener el id del registro en la tabla " + sTabla_transaccion);
            }
            return iPk_id_transaccion;
        }

        public List<string> getDeudas()
        {
            string sQuery = "SELECT Pk_id_deuda, estado_deuda FROM Tbl_Deudas_Clientes;";
            List<string> deudasCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado_deuda"].ToString().Equals("1"))
                    {
                        string sCodigoDeuda = row["Pk_id_deuda"].ToString();
                        deudasCodes.Add(sCodigoDeuda);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_transaccion);
            }

            return deudasCodes;
        }
        public List<string> getPagos()
        {
            string sQuery = "SELECT Pk_id_pago, estado_pago FROM Tbl_tipodepago;";
            List<string> pagosCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado_pago"].ToString().Equals("1"))
                    {
                        string sCodigoPago = row["Pk_id_pago"].ToString();
                        pagosCodes.Add(sCodigoPago);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_transaccion);
            }

            return pagosCodes;
        }

        public List<string> getClientes()
        {
            string sQuery = "SELECT Pk_id_cliente, estado_cliente FROM Tbl_clientes;";
            List<string> clientesCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado_cliente"].ToString().Equals("1"))
                    {
                        string sCodigoCliente = row["Pk_id_cliente"].ToString();
                        clientesCodes.Add(sCodigoCliente);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_transaccion);
            }

            return clientesCodes;
        }

        public List<string> getPais()
        {
            string sQuery = "SELECT Pk_id_pais, estatus_pais FROM Tbl_paises;";
            List<string> paisCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estatus_pais"].ToString().Equals("1"))
                    {
                        string sCodigoPais = row["Pk_id_pais"].ToString();
                        paisCodes.Add(sCodigoPais);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_transaccion);
            }

            return paisCodes;
        }

        public void registrarTransaccion (string Pk_id_transaccion, string Fk_id_clientes, string Fk_id_pais, string fecha_transaccion, 
            string cuenta_transaccion, string cuotas_transaccion, string Fk_id_deuda, string monto_deuda, string monto_transaccion, 
            string saldo_pendiente, string Fk_id_pago, string tipo_moneda, string serie_transaccion, string estado_transaccion )
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {
                string sCampos = "PK_id_transaccion, Fk_id_clientes, Fk_id_pais, fecha_transaccion, cuenta_transaccion, cuotas_transaccion, Fk_id_deuda" +
                "monto_deuda, monto_transaccion, saldo_pendiente, Fk_id_pago, tipo_moneda, serie_transaccion, estado_transaccion";
                string sSql = "INSERT INTO " + sTabla_transaccion + " (" + sCampos + ") VALUES ('" + Pk_id_transaccion + "', '" + Fk_id_clientes + "', '" 
                    + Fk_id_pais + "', '" + fecha_transaccion + "', '" + cuenta_transaccion + "', '" + cuotas_transaccion + "', '" + Fk_id_deuda + "'" +
                    ", '" + monto_deuda + "', '" + monto_transaccion + "', '" + saldo_pendiente + "', '" + Fk_id_pago + "', '" + tipo_moneda + "', '" + serie_transaccion + "', '" + estado_transaccion + "');";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + sTabla_transaccion);
            }
        }

        /// <summary>
        /// PAISES
        /// </summary>
       string sTabla_Paises = "Tbl_paises";
 
        public OdbcDataAdapter DisplayPaises()// método que obtiene el contenido de la tabla PAISES
        {
            string sSql = "SELECT Pk_id_pais, nombre_pais, region_pais, estatus_pais FROM  "
                + sTabla_Paises + " WHERE Pk_id_pais IS NOT NULL AND Pk_id_pais != '';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Paises);
            }
            return dataTable;
        }

        public void registrarPais(string Pk_id_pais, string nombre_pais, string region_pais, string estatus_pais)
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {
                string sCampos = "Pk_id_pais, nombre_pais, region_pais, estatus_pais";
                string sSql = "INSERT INTO " + sTabla_Paises + " (" + sCampos + ") VALUES ('" + Pk_id_pais + "', '" + nombre_pais + "', '"
                    + region_pais + "', '" + estatus_pais + "');";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + sTabla_Paises);
            }
        }

        public int getMaxIdPaises()
        {
            int iPk_id_paises = 0;
            string sSql = "SELECT max(Pk_id_pais) FROM " + sTabla_Paises + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                iPk_id_paises = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo obtener el id del registro en la tabla " + sTabla_Paises);
            }
            return iPk_id_paises;
        }

        public OdbcDataAdapter queryPaises(string sQuery)
        {
            string sql = "SELECT Pk_id_pais, nombre_pais, region_pais, estatus_pais FROM " + sTabla_Paises + " WHERE nombre_pais LIKE '%" + sQuery + "%' OR nombre_pais LIKE '%" + sQuery + "%';";

            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexion.conexion());
            return dataTable;
        }

        public void eliminarPais(string sId_pais)
        {
            //funcioón para eliminar el reporte seleccionado, donde se utiliza la tabla declarada globalmente y el número de reporte que se pasa por parametro.
            try
            {
                string sSql = "delete from " + sTabla_Paises + " where Pk_id_pais = " + sId_pais + "; ";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar el registro " + sId_pais + " en la tabla " + sTabla_Paises);
            }
        }

        //Vendedores
        string sTabla_Vendedor = "Tbl_vendedor";

        public OdbcDataAdapter DisplayVendedores()// método que obtiene el contenido de la tabla VENDEDORES
        {
            string sSql = "SELECT Pk_id_vendedor, nombre_vendedor, direccion_vendedor, telefono_vendedor, departamento_vendedor, estado_vendedor FROM  "
                + sTabla_Vendedor + " WHERE Pk_id_vendedor IS NOT NULL AND Pk_id_vendedor != '';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Vendedor);
            }
            return dataTable;
        }

        public void registrarVendedor(string Pk_id_vendedor, string nombre_vendedor, string direccion_vendedor, string telefono_vendedor,
            string departamento_vendedor, string estado_vendedor)
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {
                string sCampos = "Pk_id_vendedor, nombre_vendedor, direccion_vendedor, telefono_vendedor, departamento_vendedor, estado_vendedor";
                string sSql = "INSERT INTO " + sTabla_Vendedor + " (" + sCampos + ") VALUES ('" + Pk_id_vendedor + "', '" + nombre_vendedor + "', '"
                    + direccion_vendedor + "', '" + telefono_vendedor + "', '" + departamento_vendedor + "', '" + estado_vendedor + "');";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + sTabla_Vendedor);
            }
        }

        public int getMaxIdVendedor()
        {
            int iPk_id_vendedor = 0;
            string sSql = "SELECT max(Pk_id_vendedor) FROM " + sTabla_Vendedor + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                iPk_id_vendedor = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo obtener el id del registro en la tabla " + sTabla_Vendedor);
            }
            return iPk_id_vendedor;
        }

        public OdbcDataAdapter queryVendedor(string sQuery)
        {
            string sql = "SELECT  Pk_id_vendedor, nombre_vendedor, direccion_vendedor, telefono_vendedor, departamento_vendedor, estado_vendedor FROM " 
                + sTabla_Vendedor + " WHERE nombre_vendedor LIKE '%" + sQuery + "%' OR nombre_vendedor LIKE '%" + sQuery + "%';";

            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexion.conexion());
            return dataTable;
        }

        public void eliminarVendedor(string sId_vendedor)
        {
            //funcioón para eliminar el reporte seleccionado, donde se utiliza la tabla declarada globalmente y el número de reporte que se pasa por parametro.
            try
            {
                string sSql = "delete from " + sTabla_Vendedor + " where Pk_id_vendedor = " + sId_vendedor + "; ";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar el registro " + sId_vendedor + " en la tabla " + sTabla_Vendedor);
            }
        }

        //DEUDAS
        string sTabla_Deuda = "Tbl_Deudas_Clientes";
        public int getMaxIdDeudas()
        {
            int iPk_id_deuda = 0;
            string sSql = "SELECT max(Pk_id_deuda) FROM " + sTabla_Deuda + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                iPk_id_deuda = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo obtener el id del registro en la tabla " + sTabla_Deuda);
            }
            return iPk_id_deuda;
        }

        public OdbcDataAdapter DisplayDeudas()// método que obtiene el contenido de la tabla VENDEDORES
        {
            string sSql = "SELECT Pk_id_deuda, Fk_id_cliente, Fk_id_cobrador, Fk_id_pago, monto_deuda, fecha_inicio_deuda, " +
                "fecha_vencimiento_deuda, descripcion_deuda, estado_deuda FROM  "
                + sTabla_Deuda + " WHERE Pk_id_deuda IS NOT NULL AND Pk_id_deuda != '';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Deuda);
            }
            return dataTable;
        }
        public List<string> getPagosd()
        {
            string sQuery = "SELECT Pk_id_pago, estado_pago FROM Tbl_tipodepago;";
            List<string> pagosCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado_pago"].ToString().Equals("1"))
                    {
                        string sCodigoPago = row["Pk_id_pago"].ToString();
                        pagosCodes.Add(sCodigoPago);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Deuda);
            }

            return pagosCodes;
        }

        public List<string> getClientesd()
        {
            string sQuery = "SELECT Pk_id_cliente, estado_cliente FROM Tbl_clientes;";
            List<string> clientesCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado_cliente"].ToString().Equals("1"))
                    {
                        string sCodigoCliente = row["Pk_id_cliente"].ToString();
                        clientesCodes.Add(sCodigoCliente);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Deuda);
            }

            return clientesCodes;
        }

        public List<string> getCobrador()
        {
            string sQuery = "SELECT Pk_id_cobrador, estado_cobrador FROM Tbl_cobrador;";
            List<string> cobradorCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado_cobrador"].ToString().Equals("1"))
                    {
                        string sCodigoCobrador = row["Pk_id_cobrador"].ToString();
                        cobradorCodes.Add(sCodigoCobrador);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Deuda);
            }

            return cobradorCodes;
        }

        public void registrarDeuda(string Pk_id_deuda, string Fk_id_cliente, string Fk_id_cobrador, string Fk_id_pago,
            string monto_deuda, string fecha_inicio_deuda, string fecha_vencimiento_deuda, string descripcion_deuda, string estado_deuda)
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {
                string sCampos = " Pk_id_deuda, Fk_id_cliente, Fk_id_cobrador, Fk_id_pago, monto_deuda, fecha_inicio_deuda, fecha_vencimiento_deuda, descripcion_deuda, estado_deuda";
                string sSql = "INSERT INTO " + sTabla_Deuda + " (" + sCampos + ") VALUES ('" + Pk_id_deuda + "', '" + Fk_id_cliente + "', '"
                    + Fk_id_cobrador + "', '" + Fk_id_pago + "', '" + monto_deuda + "', '" + fecha_inicio_deuda + "', '" + fecha_vencimiento_deuda +
                    "', '" + descripcion_deuda+ "', '" + estado_deuda + "');";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + sTabla_Deuda);
            }
        }

        public OdbcDataAdapter queryDeuda(string sQuery)
        {
            string sql = "SELECT  Pk_id_deuda, Fk_id_cliente, Fk_id_cobrador, Fk_id_pago, monto_deuda, fecha_inicio_deuda, " +
                "fecha_vencimiento_deuda, descripcion_deuda, estado_deuda FROM "
                + sTabla_Deuda + " WHERE Pk_id_deuda LIKE '%" + sQuery + "%' OR Pk_id_deuda LIKE '%" + sQuery + "%';";

            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexion.conexion());
            return dataTable;
        }

        public void eliminarDeuda(string sId_deuda)
        {
            //funcioón para eliminar el reporte seleccionado, donde se utiliza la tabla declarada globalmente y el número de reporte que se pasa por parametro.
            try
            {
                string sSql = "delete from " + sTabla_Deuda + " where Pk_id_vendedor = " + sId_deuda + "; ";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar el registro " + sId_deuda + " en la tabla " + sTabla_Deuda);
            }
        }

        //Clientes
        string sTabla_Clientes = "Tbl_Clientes";

        public OdbcDataAdapter DisplayClientes()//
        {
            string sSql = "SELECT Pk_id_cliente, Fk_id_vendedor, nombre_cliente, direccion_cliente, telefono_cliente, saldo_cuenta, estado_cliente FROM  "
                + sTabla_Clientes + " WHERE Pk_id_cliente IS NOT NULL AND Pk_id_cliente != '';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Clientes);
            }
            return dataTable;
        }
        public int getMaxIdClientes()
        {
            int iPk_id_clientes = 0;
            string sSql = "SELECT max(Pk_id_cliente) FROM " + sTabla_Clientes + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                iPk_id_clientes = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo obtener el id del registro en la tabla " + sTabla_Clientes);
            }
            return iPk_id_clientes;
        }

        public List<string> getVendedores()
        {
            string sQuery = "SELECT Pk_id_vendedor, estado_vendedor FROM Tbl_vendedor;";
            List<string> vendedorCodes = new List<string>();

            try
            {
                OdbcDataAdapter dataTable = new OdbcDataAdapter(sQuery, conexion.conexion());
                DataTable table = new DataTable();
                dataTable.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    if (row["estado_vendedor"].ToString().Equals("1"))
                    {
                        string sCodigoPago = row["Pk_id_vendedor"].ToString();
                        vendedorCodes.Add(sCodigoPago);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Clientes);
            }

            return vendedorCodes;
        }

        public void registrarClientes(string Pk_id_cliente, string Fk_id_vendedor, string nombre_cliente, string direccion_cliente, string telefono_cliente,
            string saldo_cuenta, string estado_cliente)
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {
                string sCampos = " Pk_id_cliente, Fk_id_vendedor, nombre_cliente, direccion_cliente, telefono_cliente, saldo_cuenta,estado_cliente";
                string sSql = "INSERT INTO " + sTabla_Clientes + " (" + sCampos + ") VALUES ('" + Pk_id_cliente + "', '" + Fk_id_vendedor + "', '"
                    + nombre_cliente + "', '" + direccion_cliente + "', '" + telefono_cliente + "', '" + saldo_cuenta + "', '" + estado_cliente + "');";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + sTabla_Clientes);
            }
        }

        public OdbcDataAdapter queryCliente(string sQuery)
        {
            string sql = "SELECT  Pk_id_cliente, Fk_id_vendedor, nombre_cliente, direccion_cliente, telefono_cliente, saldo_cuenta, estado_cliente FROM "
                + sTabla_Clientes + " WHERE Pk_id_cliente LIKE '%" + sQuery + "%' OR Pk_id_cliente LIKE '%" + sQuery + "%';";

            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexion.conexion());
            return dataTable;
        }

        public void eliminarCliente(string sId_cliente)
        {
            //funcioón para eliminar el reporte seleccionado, donde se utiliza la tabla declarada globalmente y el número de reporte que se pasa por parametro.
            try
            {
                string sSql = "delete from " + sTabla_Clientes + " where Pk_id_cliente = " + sId_cliente + "; ";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar el registro " + sId_cliente + " en la tabla " + sTabla_Clientes);
            }
        }

        //Cobrador
        public OdbcDataAdapter DisplayCobradores()// método que obtiene el contenido de la tabla reportes
        {
            string sSql = "SELECT Pk_id_cobrador, nombre_cobrador, direccion_cobrador, telefono_cobrador, departamento_cobrador, estado_cobrador FROM " + Tbl_cobrador + " WHERE Pk_id_cobrador IS NOT NULL AND Pk_id_cobrador != '';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + Tbl_cobrador);
            }
            return dataTable;
        }

        string Tbl_cobrador = "Tbl_cobrador";
        public void registrarCobrador(string idCobrador, string sNombre, string sDireccion, string sTelefono, string sDepartamento, string sEstado)
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {
                string sCampos = "Pk_id_cobrador, nombre_cobrador, direccion_cobrador, telefono_cobrador, departamento_cobrador, estado_cobrador";
                string sSql = "INSERT INTO " + Tbl_cobrador + " (" + sCampos + ") VALUES ('" + idCobrador + "', '" + sNombre + "', '" + sDireccion + "', '" + sTelefono + "', '" + sDepartamento + "', '" + sEstado + "');";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + Tbl_cobrador);
            }
        }

        public OdbcDataAdapter queryCobrador(string sQuery)
        {
            string sql = "SELECT  Pk_id_cobrador, nombre_cobrador, direccion_cobrador, telefono_cobrador, departamento_cobrador, estado_cobrador FROM "
                + Tbl_cobrador + " WHERE nombre_cobrador LIKE '%" + sQuery + "%' OR nombre_cobrador LIKE '%" + sQuery + "%';";

            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexion.conexion());
            return dataTable;
        }

        public int getMaxIdCobrador()
        {
            int iPk_id_paises = 0;
            string sSql = "SELECT max(Pk_id_cobrador) FROM " + Tbl_cobrador + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                iPk_id_paises = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo obtener el id del registro en la tabla " + Tbl_cobrador);
            }
            return iPk_id_paises;
        }

        public void eliminarcobrador(string sId_cobrador)
        {
            //funcioón para eliminar el reporte seleccionado, donde se utiliza la tabla declarada globalmente y el número de reporte que se pasa por parametro.
            try
            {
                string sSql = "delete from " + Tbl_cobrador + " where Pk_id_cobrador = " + sId_cobrador + "; ";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar el registro " + sId_cobrador + " en la tabla " + Tbl_cobrador);
            }
        }
        
        //Forma de pago
        public int getMaxIdFrmPago()
        {
            int iPk_id_paises = 0;
            string sSql = "SELECT max(Pk_id_pago) FROM " + Tbl_tipodepago + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                iPk_id_paises = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo obtener el id del registro en la tabla " + Tbl_tipodepago);
            }
            return iPk_id_paises;
        }

        string Tbl_tipodepago = "Tbl_tipodepago";
        public void registrarFrmpago(string idFormaPago, string sNombreFrmPago, string sMoneda, string sEstadoFrmPago)
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {
                string sCamposFrmPago = "Pk_id_pago, nombre_pago, tipo_moneda, estado_pago";
                string sSql = "INSERT INTO " + Tbl_tipodepago + " (" + sCamposFrmPago + ") VALUES ('" + idFormaPago + "', '" + sNombreFrmPago + "', '" + sMoneda + "', '" + sEstadoFrmPago + "');";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + Tbl_cobrador);
            }
        }

        public OdbcDataAdapter DisplayFrmPago()// método que obtiene el contenido de la tabla reportes
        {
            string sSql = "SELECT Pk_id_pago, nombre_pago, tipo_moneda, estado_pago FROM " + Tbl_tipodepago + " WHERE Pk_id_pago IS NOT NULL AND Pk_id_pago != '';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + Tbl_cobrador);
            }
            return dataTable;
        }

        public OdbcDataAdapter queryFrmPago(string sQuery)
        {
            string sql = "SELECT  Pk_id_pago, nombre_pago, tipo_moneda, estado_pago FROM "
                + Tbl_tipodepago + " WHERE Pk_id_pago LIKE '%" + sQuery + "%' OR pk_id_pago LIKE '%" + sQuery + "%';";

            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexion.conexion());
            return dataTable;
        }

        public void eliminarFrmPago(string sPk_id_pago)
        {
            //funcioón para eliminar el reporte seleccionado, donde se utiliza la tabla declarada globalmente y el número de reporte que se pasa por parametro.
            try
            {
                string sSql = "delete from " + Tbl_tipodepago + " where Pk_id_pago = " + sPk_id_pago + "; ";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar el registro " + sPk_id_pago + " en la tabla " + Tbl_tipodepago);
            }
        }

        ////PROVEEDOR
        ///
        //proveedor

        string sTabla_Proveedor = "Tbl_proveedores";

        public OdbcDataAdapter DisplayProv()
        {
            string sSql = "SELECT Pk_id_proveedor, fecha_registro, nombre_proveedor, direccion, telefono, email, saldo_cuenta, estado_proveedor FROM  "
                + sTabla_Proveedor + " WHERE Pk_id_proveedor IS NOT NULL AND Pk_id_proveedor != '';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sSql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + sTabla_Proveedor);
            }
            return dataTable;
        }
        public int getMaxIdPr()
        {
            int iPk_id_proveedor = 0;
            string sSql = "SELECT max(Pk_id_proveedor) FROM " + sTabla_Proveedor + ";";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                iPk_id_proveedor = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo obtener el id del registro en la tabla " + sTabla_Proveedor);
            }
            return iPk_id_proveedor;
        }

        public void registrarProveedor(string Pk_id_proveedor, string  sfecha_registro, string  snombre_proveedor, 
            string sdireccion, string  stelefono, string  semail, string ssaldo_cuenta, string sestado_proveedor)
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            try
            {
                string sCampos = " Pk_id_proveedor, fecha_registro, nombre_proveedor, direccion, telefono, email, saldo_cuenta, estado_proveedor";
                string sSql = "INSERT INTO " + sTabla_Proveedor + " (" + sCampos + ") VALUES ('" + Pk_id_proveedor + "', '" + sfecha_registro + "', '"
                    + snombre_proveedor + "', '" + sdireccion + "', '" + stelefono + "', '" + semail + "', '" + ssaldo_cuenta + "', '" + sestado_proveedor+ "');";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + sTabla_Proveedor);
            }
        }

        public OdbcDataAdapter queryProv(string sQuery)
        {
            string sql = "SELECT  Pk_id_proveedor, fecha_registro, nombre_proveedor, direccion, telefono, email, saldo_cuenta, estado_proveedor FROM "
                + sTabla_Proveedor + " WHERE Pk_id_proveedor LIKE '%" + sQuery + "%' OR Pk_id_proveedor LIKE '%" + sQuery + "%';";

            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexion.conexion());
            return dataTable;
        }

        public void eliminarProv(string sId_proveedor)
        {
            //funcioón para eliminar el reporte seleccionado, donde se utiliza la tabla declarada globalmente y el número de reporte que se pasa por parametro.
            try
            {
                string sSql = "delete from " + sTabla_Proveedor + " where Pk_id_proveedor = " + sId_proveedor + "; ";
                OdbcCommand cmd = new OdbcCommand(sSql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar el registro " + sId_proveedor + " en la tabla " + sTabla_Proveedor);
            }
        }
    }
}
