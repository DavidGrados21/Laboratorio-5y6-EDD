using Laboratorio_5_y_6.EJERCICIO_1P;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6.EJERCICIO_P2
{
    internal class Pila2
    {
        private Nodo2 vinicio;
        public Nodo2 inicio
        {
            get { return vinicio; }
            set { vinicio = value; }
        }

        public Pila2()
        {
            inicio = null;
        }

        public bool esVacia()
        {
            if (inicio == null)
            {
                return true;
            }
            else
                return false;
        }
        public void push(string valor)
        {
            Nodo2 nuevo = new Nodo2(valor);
            nuevo.sgte = inicio;
            inicio = nuevo;

        }
        public string pop()
        {
            string x;
            x = inicio.info;
            inicio = inicio.sgte;
            return x;
        }
        public void mostrar(ListBox lst)
        {
            Nodo2 actual = inicio;
            lst.Items.Clear();
            while (actual != null)
            {
                lst.Items.Add(actual.info);
                actual = actual.sgte;
            }
        }
        public void generartxt(ListBox lst, Pila2 pilaux)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\David\\Desktop\\PRUBEA\\Ejercicio 2 de Pilas.txt");
            while (!esVacia())
            {
                string q = pop();
                sw.WriteLine(q);
                pilaux.push(q);
            }
            sw.Close();
        }
    }
}
