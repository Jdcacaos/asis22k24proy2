using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Vista_Navegador
{
    // Clase para representar cada operación
    public class OperacionCampo
    {
        public string CampoOrigen { get; set; }
        public string TablaDestino { get; set; }
        public string CampoDestino { get; set; }
        public string Operacion { get; set; }
        public string CampoCondicional { get; set; }
        public string ValorCondicional { get; set; }

        public OperacionCampo(string campoOrigen, string tablaDestino, string campoDestino, string operacion, string campoCondicional, string valorCondicional)
        {
            CampoOrigen = campoOrigen;
            TablaDestino = tablaDestino;
            CampoDestino = campoDestino;
            Operacion = operacion;
            CampoCondicional = campoCondicional;
            ValorCondicional = valorCondicional;
        }
    }
}
