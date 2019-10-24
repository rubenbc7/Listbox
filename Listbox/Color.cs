using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listbox
{
    class Color
    {
        public string Nombre { get; set; }
        public string Hexa { get; set; }
        public string RGB { get; set; }

        public Color(string nombre, string hexa, string rgb)
        {
            this.Nombre = nombre;
            this.Hexa = hexa;
            this.RGB = rgb;

        }
        public override string ToString()
        {
            return this.Nombre + "(" + this.Hexa + ")";
        }
    }
}
