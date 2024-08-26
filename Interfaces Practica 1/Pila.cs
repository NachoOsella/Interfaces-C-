using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Practica_1
{
    public class Pila : ICOllection
    {
        private object[] elementos;
        private int Contador;

        public Pila(int tamaño)
        {
            elementos = new object[tamaño];
            Contador = 0;
        }

        public bool EstaVacia()
        {
            if (Contador == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Extraer()
        {
            if (EstaVacia())
            {
                return null;
            }
            else
            {
                Contador--;
                object elemeto = elementos[Contador];
                elementos[Contador] = null;
                return elemeto;
            }
        }

        public object Primero()
        {
            if (EstaVacia())
            {
                return null;
            }
            else
            {
                return elementos[Contador - 1];
            }
        }

        public bool Añadir(object item)
        {
            if (Contador >= elementos.Length)
            {
                return false;
            }
            else
            {
                elementos[Contador] = item;
                Contador++;
                return true;
            }
        }
    }
}
