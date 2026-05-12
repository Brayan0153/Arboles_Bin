using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles_Bin
{
    internal class Nodo
    {
        public int dato;
        public Nodo izquierda, derecha;

        public Nodo(int dato, Nodo izquierda, Nodo derecha)
        {
            this.dato = dato;
            this.izquierda = null;
            this.derecha = null;
        }

    }
}


