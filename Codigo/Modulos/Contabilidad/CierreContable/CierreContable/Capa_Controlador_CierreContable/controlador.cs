using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using Capa_Modelo_CierreContable;
using System.Collections.Generic;


namespace Capa_Controlador_CierreContable
{
    public class Controlador
    {
        sentencias sn = new sentencias();

        // Método para llenar una tabla
        public DataTable llenarTbl(string tabla)
        {

            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public int ObtenerPeriodoPorMes(string mes)
        {
            mes = mes.ToUpper(); // Convertir el mes a mayúsculas para la comparación

            switch (mes)
            {
                case "ENERO": return 1;
                case "FEBRERO": return 2;
                case "MARZO": return 3;
                case "ABRIL": return 4;
                case "MAYO": return 5;
                case "JUNIO": return 6;
                case "JULIO": return 7;
                case "AGOSTO": return 8;
                case "SEPTIEMBRE": return 9;
                case "OCTUBRE": return 10;
                case "NOVIEMBRE": return 11;
                case "DICIEMBRE": return 12;
                default: return 0; // En caso de mes inválido
            }
        }

        public DataTable ObtenerMesesSinDatos(int ultimoMesConDatos, HashSet<int> idsCuentas)
        {
            DataTable mesesValidos = new DataTable();
            mesesValidos.Columns.Add("Mes"); // Columna para el nombre del mes

            // Verifica cada mes a partir del último mes con datos
            for (int mes = ultimoMesConDatos + 1; mes <= 12; mes++)
            {
                bool todasCuentasPresentes = true;

                foreach (int idCuenta in idsCuentas)
                {
                    // Usar la clase Sentencias para obtener el conteo de cuentas por mes
                    int cuentaExistente = sn.VerificarCuentaPorMes(mes, idCuenta);

                    if (cuentaExistente == 0)
                    {
                        todasCuentasPresentes = false;
                        break; // Salir si falta alguna cuenta
                    }
                }

                // Si no todas las cuentas están presentes, agregar el mes a la tabla y salir
                if (!todasCuentasPresentes)
                {
                    DataRow row = mesesValidos.NewRow();
                    row["Mes"] = new DateTime(2024, mes, 1).ToString("MMMM"); // Ajusta el año según sea necesario
                    mesesValidos.Rows.Add(row);
                    break; // Salir después de encontrar el primer mes sin datos
                }
            }

            return mesesValidos;
        }



        public DataTable ObtenerCuentas()
        {

            DataTable cuentas = new DataTable();
            try
            {
                string query = "SELECT pk_id_cuenta, nombre_cuenta FROM tbl_cuentas"; // Ajusta la consulta según tu tabla
                using (OdbcConnection con = sn.ObtenerConexion())
                {
                    OdbcDataAdapter adapter = new OdbcDataAdapter(query, con);
                    adapter.Fill(cuentas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener cuentas: {ex.Message}");
            }

            return cuentas;
        }

        public void ConsultarCierreG(string cuentaSeleccionada, TextBox txt_cargomes, TextBox txt_abonomes, TextBox txt_saldoantmes, TextBox txt_saldoactmes)
        {
            // Consulta para traer las sumas de cargo_mes, abono_mes, saldo_ant y saldo_act
            string query = "SELECT COALESCE(SUM(cargo_mes), 0) AS SumaCargoMes, " +
                           "COALESCE(SUM(abono_mes), 0) AS SumaAbonoMes, " +
                           "COALESCE(SUM(saldo_ant), 0) AS SumaSaldoAnt, " +
                           "COALESCE(SUM(saldo_act), 0) AS SumaSaldoAct " +
                           "FROM tbl_cuentas " +
                           "WHERE nombre_cuenta = ?";

            using (OdbcConnection con = sn.ObtenerConexion())
            {
                try
                {

                    using (OdbcCommand cmd = new OdbcCommand(query, con))
                    {
                        // Asignar el parámetro de cuenta seleccionada
                        cmd.Parameters.AddWithValue("?", cuentaSeleccionada);

                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Asignar valores sumados a los TextBox
                                // Asignar valores formateados a dos decimales a los TextBox
                                txt_cargomes.Text = reader["SumaCargoMes"] != DBNull.Value ? Convert.ToDecimal(reader["SumaCargoMes"]).ToString("F2") : "0.00";
                                txt_abonomes.Text = reader["SumaAbonoMes"] != DBNull.Value ? Convert.ToDecimal(reader["SumaAbonoMes"]).ToString("F2") : "0.00";
                                txt_saldoantmes.Text = reader["SumaSaldoAnt"] != DBNull.Value ? Convert.ToDecimal(reader["SumaSaldoAnt"]).ToString("F2") : "0.00";
                                txt_saldoactmes.Text = reader["SumaSaldoAct"] != DBNull.Value ? Convert.ToDecimal(reader["SumaSaldoAct"]).ToString("F2") : "0.00";

                            }
                            else
                            {
                                // Limpiar TextBox si no hay resultados
                                txt_cargomes.Clear();
                                txt_abonomes.Clear();
                                txt_saldoantmes.Clear();
                                txt_saldoactmes.Clear();
                                MessageBox.Show("No se encontraron datos para la cuenta especificada.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en la consulta: " + ex.Message);
                }
            }
        }

        public void GenerarNuevoCierre(int mes, int anio)
        {
            using (OdbcConnection con = sn.ObtenerConexion())
            {
                using (OdbcTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Seleccionar todos los IDs de cuentas
                        string selectQuery = "SELECT Pk_id_cuenta, cargo_mes, abono_mes, saldo_ant, saldo_act, cargo_acumulado, abono_acumulado FROM tbl_cuentas";
                        OdbcCommand selectCmd = new OdbcCommand(selectQuery, con, transaction);

                        using (OdbcDataReader reader = selectCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int cuentaId = reader.GetInt32(0);
                                decimal cargoMes = reader.GetDecimal(1);
                                decimal abonoMes = reader.GetDecimal(2);
                                decimal saldoAnt = reader.GetDecimal(3);
                                decimal saldoAct = reader.GetDecimal(4);
                                decimal cargoAcumulado = reader.GetDecimal(5);
                                decimal abonoAcumulado = reader.GetDecimal(6);

                                // Obtener el saldoanual del mes anterior, si existe
                                decimal saldoAnualPrevio = 0;
                                string saldoAnualQuery = "SELECT saldoanual FROM tbl_historico_cuentas WHERE Pk_id_cuenta = ? AND mes = ? AND anio = ?";
                                using (OdbcCommand saldoAnualCmd = new OdbcCommand(saldoAnualQuery, con, transaction))
                                {
                                    saldoAnualCmd.Parameters.AddWithValue("?", cuentaId);
                                    saldoAnualCmd.Parameters.AddWithValue("?", mes - 1); // Mes anterior
                                    saldoAnualCmd.Parameters.AddWithValue("?", anio);

                                    object result = saldoAnualCmd.ExecuteScalar();
                                    if (result != null)
                                    {
                                        saldoAnualPrevio = Convert.ToDecimal(result);
                                    }
                                }

                                // Sumar el saldo_act actual al saldoanual del mes anterior
                                decimal nuevoSaldoAnual = saldoAnualPrevio + saldoAct;

                                // Guardar el historial en tbl_historico_cuentas
                                string insertQuery = @"
                        INSERT INTO tbl_historico_cuentas 
                            (Pk_id_cuenta, mes, anio, cargo_mes, abono_mes, saldo_ant, saldo_act, cargo_acumulado, abono_acumulado, saldoanual)
                        VALUES 
                            (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                                using (OdbcCommand insertCmd = new OdbcCommand(insertQuery, con, transaction))
                                {
                                    insertCmd.Parameters.AddWithValue("?", cuentaId);
                                    insertCmd.Parameters.AddWithValue("?", mes);
                                    insertCmd.Parameters.AddWithValue("?", anio);
                                    insertCmd.Parameters.AddWithValue("?", cargoMes);
                                    insertCmd.Parameters.AddWithValue("?", abonoMes);
                                    insertCmd.Parameters.AddWithValue("?", saldoAnt);
                                    insertCmd.Parameters.AddWithValue("?", saldoAct);
                                    insertCmd.Parameters.AddWithValue("?", cargoAcumulado + cargoMes);
                                    insertCmd.Parameters.AddWithValue("?", abonoAcumulado + abonoMes);
                                    insertCmd.Parameters.AddWithValue("?", nuevoSaldoAnual);

                                    insertCmd.ExecuteNonQuery();
                                }

                                // Actualizar los valores en tbl_cuentas
                                string updateQuery = @"
                        UPDATE tbl_cuentas
                        SET 
                            cargo_mes = 0, 
                            abono_mes = 0, 
                            saldo_ant = saldo_act, 
                            saldo_act = 0,
                            cargo_acumulado = cargo_acumulado + ?,
                            abono_acumulado = abono_acumulado + ?
                        WHERE Pk_id_cuenta = ?";

                                using (OdbcCommand updateCmd = new OdbcCommand(updateQuery, con, transaction))
                                {
                                    updateCmd.Parameters.AddWithValue("?", cargoMes);
                                    updateCmd.Parameters.AddWithValue("?", abonoMes);
                                    updateCmd.Parameters.AddWithValue("?", cuentaId);

                                    updateCmd.ExecuteNonQuery();
                                }
                            }
                        }

                        // Confirmar la transacción
                        transaction.Commit();
                        MessageBox.Show("Cierre mensual guardado exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        // Revertir cambios en caso de error
                        transaction.Rollback();
                        MessageBox.Show($"Error al guardar el cierre: {ex.Message}");
                    }
                }
            }
        }

        public void VerificarYActualizarAnoCompleto(int anio)
        {
            using (OdbcConnection con = sn.ObtenerConexion())
            {
                string query = "SELECT COUNT(DISTINCT mes) FROM tbl_historico_cuentas WHERE anio = ?";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.Parameters.AddWithValue("?", anio);

                int mesesConCierre = Convert.ToInt32(cmd.ExecuteScalar());

                // Verificar si ya se completaron los 12 meses
                if (mesesConCierre == 12)
                {
                    int nuevoAnio = anio + 1;
                    MessageBox.Show($"Año actualizado a {nuevoAnio}.");
                    ActualizarSaldoAntYResetearCuentas(nuevoAnio); // Llamar a la función del paso 2 con el nuevo año
                }
            }
        }

        public void ActualizarSaldoAntYResetearCuentas(int anio)
        {
            using (OdbcConnection con = sn.ObtenerConexion())
            {
                using (OdbcTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        // Actualizar saldo_ant en tbl_cuentas con saldoanual de tbl_historico_cuentas
                        string updateSaldoAntQuery = @"
                    UPDATE tbl_cuentas c
                    JOIN tbl_historico_cuentas h ON c.Pk_id_cuenta = h.Pk_id_cuenta
                    SET c.saldo_ant = h.saldoanual
                    WHERE h.mes = 12 AND h.anio = ?";

                        OdbcCommand updateSaldoAntCmd = new OdbcCommand(updateSaldoAntQuery, con, transaction);
                        updateSaldoAntCmd.Parameters.AddWithValue("?", anio - 1);
                        updateSaldoAntCmd.ExecuteNonQuery();

                        // Reiniciar los valores de columnas flotantes en tbl_cuentas a 0
                        string resetCuentasQuery = @"
                    UPDATE tbl_cuentas
                    SET 
                        cargo_mes = 0, 
                        abono_mes = 0, 
                        saldo_act = 0, 
                        cargo_acumulado = 0, 
                        abono_acumulado = 0";

                        OdbcCommand resetCuentasCmd = new OdbcCommand(resetCuentasQuery, con, transaction);
                        resetCuentasCmd.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Saldo anual transferido y valores reiniciados para el nuevo año.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error al actualizar el saldo y reiniciar cuentas: {ex.Message}");
                    }
                }
            }
        }








        // Método para actualizar el ComboBox de meses, asegurando que el último mes no aparezca


        // Método para actualizar el ComboBox de meses, asegurando que el último mes no aparezca
        // Método para actualizar la lista de meses, asegurando que el último mes no aparezca
        public void ActualizarComboBoxMeses()
        {
            using (OdbcConnection con = sn.ObtenerConexion())
            {
                string query = "SELECT DISTINCT mes FROM tbl_historico_cuentas";
                OdbcCommand cmd = new OdbcCommand(query, con);
                using (OdbcDataReader reader = cmd.ExecuteReader())
                {
                    // Clear the list of months and repopulate it, excluding the last entered month
                    List<string> meses = new List<string>();
                    List<int> mesesExistentes = new List<int>();

                    while (reader.Read())
                    {
                        mesesExistentes.Add(reader.GetInt32(0));
                    }

                    // Add months to the list, skipping the last entered month
                    for (int i = 1; i <= 12; i++)
                    {
                        if (!mesesExistentes.Contains(i))
                        {
                            meses.Add(i.ToString()); // Convertir a string y agregar a la lista
                        }
                    }
                }
            }
        }



        public DataTable ObtenerDatosCierre(string nombreCuenta)
        {
            DataTable datosCierre = new DataTable();
            try
            {
                // Ajustar la consulta para obtener los datos necesarios
                string query;

                if (string.IsNullOrEmpty(nombreCuenta)) // Si nombreCuenta es null o vacío, selecciona todas las cuentas
                {
                    query = @"SELECT c.Pk_id_cuenta, 
                     tc.nombre_tipocuenta AS nombre_tipo_cuenta, 
                     ec.nombre_tipocuenta AS nombre_encabezado, 
                     c.nombre_cuenta, 
                     c.cargo_mes, 
                     c.abono_mes, 
                     c.saldo_ant, 
                     c.saldo_act, 
                     c.cargo_acumulado, 
                     c.abono_acumulado 
              FROM tbl_cuentas c
              JOIN tbl_tipocuenta tc ON c.Pk_id_tipocuenta = tc.Pk_id_tipocuenta
              JOIN tbl_encabezadoclasecuenta ec ON c.Pk_id_encabezadocuenta = ec.Pk_id_encabezadocuenta"; // Obtener todas las cuentas
                }
                else
                {
                    query = @"SELECT c.Pk_id_cuenta, 
                     tc.nombre_tipocuenta AS nombre_tipo_cuenta, 
                     ec.nombre_tipocuenta AS nombre_encabezado, 
                     c.nombre_cuenta, 
                     c.cargo_mes, 
                     c.abono_mes, 
                     c.saldo_ant, 
                     c.saldo_act, 
                     c.cargo_acumulado, 
                     c.abono_acumulado 
              FROM tbl_cuentas c
              JOIN tbl_tipocuenta tc ON c.Pk_id_tipocuenta = tc.Pk_id_tipocuenta
              JOIN tbl_encabezadoclasecuenta ec ON c.Pk_id_encabezadocuenta = ec.Pk_id_encabezadocuenta
              WHERE c.nombre_cuenta = ?"; // Filtrar por cuenta seleccionada
                }


                using (OdbcConnection con = sn.ObtenerConexion())
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, con))
                    {
                        if (!string.IsNullOrEmpty(nombreCuenta))
                        {
                            cmd.Parameters.AddWithValue("nombre_cuenta", nombreCuenta); // Asignar el valor del parámetro
                        }

                        OdbcDataAdapter adapter = new OdbcDataAdapter(cmd);
                        adapter.Fill(datosCierre);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos de cierre: {ex.Message}");
            }

            return datosCierre;
        }


        public int ObtenerUltimoMesConDatos(int anio)
        {
            // Lógica para obtener el último mes con datos en el año especificado
            int ultimoMes = 0;

            using (OdbcConnection con = sn.ObtenerConexion())
            {
                string query = "SELECT MAX(mes) FROM tbl_historico_cuentas WHERE anio = ?";
                OdbcCommand cmd = new OdbcCommand(query, con);
                cmd.Parameters.AddWithValue("?", anio);

                var resultado = cmd.ExecuteScalar();
                ultimoMes = resultado != DBNull.Value ? Convert.ToInt32(resultado) : 0;
            }

            return ultimoMes;
        }

        public bool VerificarCierresCompletos(int anio)
        {
            string query = @"
                SELECT COUNT(DISTINCT Mes) AS MesesRegistrados
                FROM tbl_historico_cuentas
                WHERE Anio = ?";

            using (OdbcConnection conn = sn.ObtenerConexion())
            {
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", anio);
                    int mesesRegistrados = Convert.ToInt32(cmd.ExecuteScalar());

                    // Verificar si existen registros para todos los meses (1 a 12)
                    return mesesRegistrados == 12;
                }
            }
        }





        // Método para actualizar el año en la tabla `tbl_historico_cuentas`
        public void ActualizarAnioHistorico(int anioActual, int nuevoAnio)
        {
            string queryActualizarSaldoAnt = @"
                UPDATE tbl_cuentas c
                INNER JOIN tbl_historico_cuentas h ON c.Pk_id_cuenta = h.Pk_id_cuenta
                SET c.saldo_ant = h.saldoanual
                WHERE h.Anio = ? AND h.Mes = 12";

            string queryReiniciarSaldos = @"
                UPDATE tbl_cuentas
                SET cargo_mes = 0, abono_mes = 0, saldo_act = 0, 
                    cargo_acumulado = 0, abono_acumulado = 0";

            using (OdbcConnection conn = sn.ObtenerConexion())
            {
                // Ejecutar la primera consulta para actualizar saldo_ant
                using (OdbcCommand cmd1 = new OdbcCommand(queryActualizarSaldoAnt, conn))
                {
                    cmd1.Parameters.AddWithValue("?", anioActual);
                    cmd1.ExecuteNonQuery();
                }

                // Ejecutar la segunda consulta para reiniciar saldos
                using (OdbcCommand cmd2 = new OdbcCommand(queryReiniciarSaldos, conn))
                {
                    cmd2.ExecuteNonQuery();
                }
            }
        }



        // Modifica el método ActualizarSumasSaldos para incluir la cuenta
        public void ActualizarSumasSaldos(TextBox txt_saldoant, TextBox txt_saldofinal, int periodo, string cuenta)
        {
            try
            {
                // Llama a ObtenerSumasSaldos pasando periodo y cuenta
                (decimal sumaSaldoAnt, decimal sumaSaldoAct) = sn.ObtenerSumasSaldos(periodo, cuenta);

                txt_saldoant.Text = sumaSaldoAnt.ToString("N2");
                txt_saldofinal.Text = sumaSaldoAct.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener sumas de saldos: {ex.Message}");
            }
        }



        public string MRuta(string Ruta1)
        {
            string ruta = sn.modRuta(Ruta1);

            return ruta;
        }

        public string MIndice(string Indice1)
        {
            string indice = sn.modIndice(Indice1);

            return indice;
        }

        public bool VerificarRegistrosVacios(string mes, string anio)
        {
            // Obtener el periodo correspondiente al mes
            int periodo = ObtenerPeriodoPorMes(mes);
            if (periodo < 1 || periodo > 12) // Si el mes no es válido, retorna false
            {
                MessageBox.Show("Mes inválido.");
                return false;
            }

            // Obtener todas las cuentas
            DataTable cuentas = ObtenerCuentas();

            // Recorrer cada cuenta y verificar si hay registros para el mes y año especificados
            foreach (DataRow cuenta in cuentas.Rows)
            {
                string nombreCuenta = cuenta["nombre_cuenta"].ToString();

                // Consulta para verificar si hay registros para el mes y año con un JOIN
                string query = @"
            SELECT COUNT(*) 
            FROM tbl_historico_cuentas hc
            INNER JOIN tbl_cuentas c ON hc.Pk_id_cuenta = c.Pk_id_cuenta
            WHERE c.nombre_cuenta = ? AND hc.mes = ? AND hc.anio = ?";

                using (OdbcConnection con = sn.ObtenerConexion())
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("?", nombreCuenta);
                        cmd.Parameters.AddWithValue("?", periodo);
                        cmd.Parameters.AddWithValue("?", anio);

                        int registros = Convert.ToInt32(cmd.ExecuteScalar());

                        // Si no hay registros para este mes, retorna false
                        if (registros == 0)
                        {
                            MessageBox.Show($"No existe cierre para la cuenta '{nombreCuenta}' en el mes {mes} del año {anio}.");
                            return false;
                        }
                    }
                }
            }

            // Si todas las cuentas tienen registros, retorna true
            return true;
        }

        public void ConsultaCG(int periodo, string anio, string cuenta, DataTable dt1, DataTable dt2)
        {
            // Define la consulta SQL con LEFT JOIN y filtros de mes, año, y cuenta si es necesario
            string consulta = @"
        SELECT 
            c.Pk_id_cuenta AS 'ID de Cuenta', 
            c.nombre_cuenta AS 'Nombre de Cuenta', 
            h.mes AS 'Mes', 
            h.anio AS 'Anio', 
            e.nombre_tipocuenta AS 'Encabezado Cuenta', 
            t.nombre_tipocuenta AS 'Tipo de Cuenta', 
            h.cargo_mes AS 'Cargo del Mes', 
            h.abono_mes AS 'Abono del Mes', 
            h.saldo_ant AS 'Saldo Anterior', 
            h.saldo_act AS 'Saldo Actual', 
            h.cargo_acumulado AS 'Cargo Acumulado', 
            h.abono_acumulado AS 'Abono Acumulado', 
            h.saldoanual AS 'Saldo Anual'
        FROM 
            tbl_cuentas AS c
        LEFT JOIN 
            tbl_historico_cuentas AS h ON c.Pk_id_cuenta = h.Pk_id_cuenta
        LEFT JOIN 
            tbl_encabezadoclasecuenta AS e ON c.Pk_id_encabezadocuenta = e.Pk_id_encabezadocuenta
        LEFT JOIN 
            tbl_tipocuenta AS t ON c.Pk_id_tipocuenta = t.PK_id_tipocuenta
        WHERE 
            (h.mes = ? AND h.anio = ?) 
            AND (c.nombre_cuenta = ? OR ? IS NULL)
            OR h.Pk_id_cuenta IS NULL";

            using (OdbcConnection con = sn.ObtenerConexion())
            {
                // Crea un adaptador con la consulta
                OdbcDataAdapter datos = new OdbcDataAdapter(consulta, con);

                // Añade los parámetros de mes y año
                datos.SelectCommand.Parameters.AddWithValue("?", periodo);
                datos.SelectCommand.Parameters.AddWithValue("?", anio);

                // Añade el parámetro de cuenta si es necesario
                if (!string.IsNullOrEmpty(cuenta))
                {
                    datos.SelectCommand.Parameters.AddWithValue("?", cuenta);
                    datos.SelectCommand.Parameters.AddWithValue("?", cuenta);
                }
                else
                {
                    datos.SelectCommand.Parameters.AddWithValue("?", DBNull.Value);
                    datos.SelectCommand.Parameters.AddWithValue("?", DBNull.Value);
                }

                // Llena ambos DataTables con la misma consulta (si es necesario, se pueden dividir más adelante)
                datos.Fill(dt1);
                datos.Fill(dt2);
            }
        }




    }
}
