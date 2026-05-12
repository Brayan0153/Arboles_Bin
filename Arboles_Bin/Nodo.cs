using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles_Bin
{
    internal class Nodo
    {
        public int Dato {  get; set; }
        public Nodo izquierda { get; set; }
        public Nodo derecha { get; set; }

        public Nodo(int dato)
        {
            this.Dato = dato;
            this.izquierda = null;
            this.derecha = null;
        }

        public override string? ToString()
        {
            return Dato.ToString();
        }

    }
}


