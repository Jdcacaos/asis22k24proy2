using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_CierreContable
{
    public class sentencias
    {

        private conexion con = new conexion();


        public OdbcConnection ObtenerConexion()
        {
            return con.Conexion(); // Asegúrate de que este método retorne la conexión
        }

        // Método para llenar la tabla genérico

        public OdbcDataAdapter llenarTbl(string tabla)
        {
            string sql = "SELECT * FROM " + tabla + ";";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.Conexion());
            return dataTable;

        }

        public (decimal sumaSaldoAnt, decimal sumaSaldoAct) ObtenerSumasSaldos(int periodo, string cuenta)
        {
            decimal sumaSaldoAnt = 0;
            decimal sumaSaldoAct = 0;


            // Actualiza la consulta para incluir el JOIN con tbl_cuentas

            string query = "SELECT SUM(hc.saldo_ant) AS SumaSaldoAnt, SUM(hc.saldo_act) AS SumaSaldoAct " +
                           "FROM tbl_historico_cuentas hc " +
                           "JOIN tbl_cuentas c ON hc.Pk_id_cuenta = c.Pk_id_cuenta " +
                           "WHERE hc.mes = ? AND c.nombre_cuenta = ?";


            using (OdbcConnection conn = con.Conexion())
            {
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", periodo); // Agregar el parámetro del periodo
                cmd.Parameters.AddWithValue("?", cuenta);   // Agregar el parámetro de cuenta

                OdbcDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Manejo de valores nulos y conversión
                    sumaSaldoAnt = reader.IsDBNull(0) ? 0 : Convert.ToDecimal(reader["SumaSaldoAnt"]);
                    sumaSaldoAct = reader.IsDBNull(1) ? 0 : Convert.ToDecimal(reader["SumaSaldoAct"]);
                }

                reader.Close();

            }

            return (sumaSaldoAnt, sumaSaldoAct);
        }

        public int VerificarCuentaPorMes(int mes, int idCuenta)
        {
            int cuentaExistente = 0;

            using (OdbcConnection con = ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM tbl_historico_cuentas WHERE mes = ? AND Pk_id_cuenta = ?";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.Parameters.AddWithValue("?", mes);
                cmd.Parameters.AddWithValue("?", idCuenta);

                cuentaExistente = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return cuentaExistente;
        }



        public string modRuta(string idAyuda)
        {
            string sRuta = "";
            string sSql = "SELECT Ruta FROM ayuda WHERE Id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(sSql, ObtenerConexion()))
            {
                command.Parameters.AddWithValue("id_ayuda", idAyuda);
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

        public string modIndice(string idAyuda)
        {
            string sIndice = "";
            string sSql = "SELECT indice FROM ayuda WHERE id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(sSql, ObtenerConexion()))
            {
                command.Parameters.AddWithValue("Id_ayuda", idAyuda);
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

        // Método para ejecutar una consulta específica
        public DataTable EjecutarConsulta(string query)
        {
            DataTable dt = new DataTable();

            using (OdbcConnection conn = con.Conexion())

            {
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn);
                adapter.Fill(dt);
            }
            return dt;
        }


    }

}

