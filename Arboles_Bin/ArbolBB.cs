using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles_Bin
{
    internal class ArbolBB
    {
        
        private Nodo Raiz {get;set;}
        public ArbolBB()
        {
            Raiz = null;
        }
        public void Insertar(int v)
        {
            Raiz = InsertarRecursivo(Raiz, v);
        }
        private Nodo InsertarRecursivo(Nodo r, int valor)
        {
            if (r == null)
            {
                return new Nodo(valor);
            }
            else if (valor < r.Dato)
            {
                r.izquierda = InsertarRecursivo(r.izquierda, valor);
            }
            else if (valor > r.Dato)
            {
                r.derecha= InsertarRecursivo(r.derecha, valor);
            }
            return r;

        }

        //regresa true si el valor esta en el arbol


        public bool Buscar(int v)
        {
            return true;
        }
        
        
        public void Preorden()
        {
            PreordenRecursivo(Raiz);
            
        }

        private void PreordenRecursivo(Nodo r)
        {
            if (r != null)
            {
                Console.Write(r.Dato + " ");   
                PreordenRecursivo(r.izquierda);
                PreordenRecursivo(r.derecha);
            }
        }
        public void Inorden()
        {
            InordenRecursivo(Raiz);
            
        }

        private void InordenRecursivo(Nodo r)
        {
            if (r != null)
            {
                InordenRecursivo(r.izquierda);
                Console.Write(r.Dato + " ");
                InordenRecursivo(r.derecha);
            }
        }

        public void Postorden()
        {
            PostordenRecursivo(Raiz);
            
        }

        private void PostordenRecursivo(Nodo r)
        {
            if (r != null)
            {
                PostordenRecursivo(r.izquierda);
                PostordenRecursivo(r.derecha);
                Console.Write(r.Dato + " ");
            }
        }


    }

}
