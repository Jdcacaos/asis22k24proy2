using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Vista_Navegador
{
    public class ComponenteInvisible
    {
        public string ValorClave { get; set; }
        public string ValorDisplay { get; set; }

        public ComponenteInvisible(string valorClave, string valorDisplay)
        {
            ValorClave = valorClave;
            ValorDisplay = valorDisplay;
        }
    }
}
