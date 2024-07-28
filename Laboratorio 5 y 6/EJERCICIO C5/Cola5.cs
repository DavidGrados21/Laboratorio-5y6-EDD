using Laboratorio_5_y_6.EJERCICIO_C1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6.EJERCICIO_C5
{
    internal class Cola5
    {
        private nodo5 vprimero;
        private nodo5 vultimo;

        public nodo5 primero
        {
            get { return vprimero; }
            set { vprimero = value; }
        }

        public nodo5 ultimo
        {
            get { return vultimo; }
            set { vultimo = value; }
        }

        public void encolar(string x)
        {
            nodo5 nuevo = new nodo5(x);

            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                ultimo.sgte = nuevo;
            }
            ultimo = nuevo;
        }
        public bool esVacia()
        {
            if (primero == null)
            {
                return true;
            }
            else
                return false;
        }

        public void mostrar (ListBox lst)
        {
            lst.Items.Clear();
            nodo5 p = primero;
            while (p!= null) 
            {
                lst.Items.Add(p.info);
                p = p.sgte;
            }
        }

        public void eliminarRepetidas (string x, Cola5 aux)
        {
            while (primero != null)
            {
                if (primero.info != x)
                {
                    aux.encolar(primero.info);
                    primero = primero.sgte;
                }
                else
                    primero = primero.sgte;
            }
        }
    }
}
