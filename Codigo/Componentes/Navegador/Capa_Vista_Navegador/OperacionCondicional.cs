using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Vista_Navegador
{
    public class OperacionCondicional
    {
        public string ComponenteOrigen { get; set; }  // Nombre del componente (ej. "Monto")
        public string TablaDestino { get; set; }       // Tabla en la que se hará la operación (ej. "Clientes")
        public string CampoDestino { get; set; }       // Campo donde se aplicará la operación (ej. "saldo")
        public string Operacion { get; set; }          // Tipo de operación ("restar", "sumar")
        public string CampoCondicional { get; set; }   // Campo condicional (ej. "codigoCliente")
        public string ValorCondicional { get; set; }   // Valor que se comparará en el condicional (ej. "123")
        public string Condicion { get; set; }          // Condición (ej. "mayor", "menor", "igual")
        public decimal? ValorReferencia { get; set; }  // Valor con el cual comparar (ej. 100 para "mayor a 100")

        public OperacionCondicional(string componenteOrigen, string tablaDestino, string campoDestino, string operacion, string campoCondicional, string valorCondicional, string condicion, decimal? valorReferencia)
        {
            ComponenteOrigen = componenteOrigen;
            TablaDestino = tablaDestino;
            CampoDestino = campoDestino;
            Operacion = operacion;
            CampoCondicional = campoCondicional;
            ValorCondicional = valorCondicional;
            Condicion = condicion;
            ValorReferencia = valorReferencia;
        }
    }
}
