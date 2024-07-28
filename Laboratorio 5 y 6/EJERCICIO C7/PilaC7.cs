using Laboratorio_5_y_6.EJERCICIO_1P;
using Laboratorio_5_y_6.EJERCICIO_C1;
using Laboratorio_5_y_6.EJERCICIO_P1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6.EJERCICIO_C7
{
    internal class PilaC7
    {
        private NodoC vinicio;

        public NodoC inicio
        {
            get { return vinicio; }
            set { vinicio = value; }
        }

        public PilaC7()
        {
            inicio = null;
        }


        public bool esVacia()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }
        public void push(char valor)
        {
            NodoC nuevo = new NodoC(valor);
            nuevo.sgte = inicio;
            inicio = nuevo;
        }

        public char pop()
        {
            char x;
            x = inicio.info;
            inicio = inicio.sgte;
            return x;
        }

        public void mostar(ListBox lst)
        {
            NodoC actual = inicio;
            lst.Items.Clear();
            while (actual != null)
            {
                lst.Items.Add(actual.info);
                actual = actual.sgte;
            }
        }

        public bool Palindromo(string palabra, int n , PilaC7 pila, cola7 cola)
        {
            for (int i = 0; i < n; i++)
            {
                char x = palabra[i];
                pila.push(x);
                cola.encolar(x);
            }

            bool exito = true;

            while (!pila.esVacia())
            {
                //char x = pila.pop();
                //char y = cola.desencolar();

                if (pila.pop() != cola.desencolar())
                {
                    exito = false;
                }
            }
            return exito;
        }
    }
}
