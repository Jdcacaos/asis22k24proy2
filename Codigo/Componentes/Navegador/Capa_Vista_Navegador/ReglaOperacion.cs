using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Vista_Navegador
{
    public class ReglaOperacion
    {
        public string ComponenteOrigen { get; set; }
        public string CampoComparacion { get; set; }
        public string TablaComparacion { get; set; }
        public string Condicion { get; set; }
        public string Accion { get; set; }
        public string TablaInsercion { get; set; }
        public string ClavePrimaria { get; set; }  // Nombre del componente que contiene la clave primaria

        // Diccionario que mapea cada componente de la vista con el nombre de su campo en la base de datos
        public Dictionary<string, string> MapeoComponentesCampos { get; set; }
    }
}
