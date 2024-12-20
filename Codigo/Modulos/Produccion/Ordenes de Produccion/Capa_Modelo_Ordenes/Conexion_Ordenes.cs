﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Ordenes // Espacio de nombres actualizado
{
    public class Conexion_Ordenes // Clase con nombre estandarizado y modificador 'public'
    {
        // Método que prueba la conexión a la base de datos utilizando una DSN específica.
        public OdbcConnection Probar_Conexion() // Método estandarizado
        {
            OdbcConnection conn = new OdbcConnection("dsn=colchoneria");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No conectó");
            }
            return conn;
        }
    }
}
