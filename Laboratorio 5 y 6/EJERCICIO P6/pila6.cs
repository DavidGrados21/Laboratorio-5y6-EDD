using Laboratorio_5_y_6.EJERCICIO_1P;
using Laboratorio_5_y_6.EJERCICIO_P1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6.EJERCICIO_P6
{
    internal class pila6
    {
        private Nodo vinicio;
        public Nodo inicio
        {
            get { return vinicio; }
            set { vinicio = value; }
        }

        public pila6()
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
            Nodo aux = inicio;
            int x;

            x = aux.info;
            inicio = inicio.sgte;
            aux = null;
            return x;
        }

        public void mostrar(ListBox lst)
        {
            Nodo actual = inicio;
            lst.Items.Clear();
            while (actual != null)
            {
                lst.Items.Add(actual.info);
                actual = actual.sgte;
            }
        }

        public void insertarPilaPosicion(int valor, int posicion)
        {
            pila6 pila2 = new pila6();

            int cont = 0;

            while (inicio != null)
            {
                if (posicion == cont)
                {
                    pila2.push(valor);

                }
                pila2.push(pop());
                cont++;
            }
            while (pila2.inicio != null)
            {
                push(pila2.pop());
            }
        }
    }
}
