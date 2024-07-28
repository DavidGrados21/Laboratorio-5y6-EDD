using Laboratorio_5_y_6.EJERCICIO_1P;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6.EJERCICIO_C8
{
    internal class PilaC8
    {
        private Nodo vinicio;

        public Nodo inicio
        {
            get { return vinicio; }
            set { vinicio = value; }


        }

        public PilaC8()
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
        public void push(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            nuevo.sgte = inicio;
            inicio = nuevo;
        }

        public int pop()
        {
            int x;
            x = inicio.info;
            inicio = inicio.sgte;
            return x;
        }

        public void mostar(ListBox lst)
        {
            Nodo actual = inicio;
            lst.Items.Clear();
            while (actual != null)
            {
                lst.Items.Add(actual.info);
                actual = actual.sgte;
            }
        }

        public bool Palindrome(String numero, int n, PilaC8 pila, Cola8 cola)
        {
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(numero[i].ToString());
                pila.push(x);
                cola.encolar(x);
            }

            bool exito = true;

            while (!pila.esVacia())
            {
                if (pila.pop() != cola.desencolar())
                {
                    exito = false;
                }
            }
            return exito;

        }
    }
}
