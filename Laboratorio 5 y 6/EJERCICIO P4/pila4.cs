using Laboratorio_5_y_6.EJERCICIO_1P;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6.EJERCICIO_P4
{
    internal class pila4
    {
        private Nodo vinicio;

        public Nodo inicio
        {
            get { return vinicio; }
            set { vinicio = value; }
        }

        public pila4()
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

        public void mostrarTodo(ListBox lst, pila4 pila)
        {
            Nodo actual = inicio;
            lst.Items.Clear();
            lst.Items.Add("---------------------");
            lst.Items.Add("Pila 1");
            lst.Items.Add("---------------------");
            while (actual != null)
            {
                lst.Items.Add(actual.info);
                actual = actual.sgte;
            }

            Nodo actual1 = pila.inicio;
            lst.Items.Add("---------------------");
            lst.Items.Add("Pila 2");
            lst.Items.Add("---------------------");
            while (actual1 != null)
            {
                lst.Items.Add(actual1.info);
                actual1 = actual1.sgte;

            }
        }

        public bool EsIgual( pila4 Pila2)
        {
            Nodo actual = inicio;
            Nodo actual2 = Pila2.inicio;

            while (actual != null && actual2 != null)
            {
                if (actual.info != actual2.info)
                {
                    return false;
                }

                actual = actual.sgte;
                actual2 = actual2.sgte;
            }

            return actual == null && actual2 == null;
        }
    }
}
