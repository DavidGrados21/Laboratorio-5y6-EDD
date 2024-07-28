using Laboratorio_5_y_6.EJERCICIO_1P;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6.EJERCICIO_C7
{
    internal class cola7
    {
        private NodoC vprimero;
        private NodoC vultimo;

        public NodoC primero
        {
            get { return vprimero; }
            set { vprimero = value; }
        }
        public NodoC ultimo
        {
            get { return vultimo; }
            set { vultimo = value; }
        }
        public void encolar(char x)
        {
            NodoC nuevo = new NodoC(x);
            if (primero == null)
                primero = nuevo;

            else
                ultimo.sgte = nuevo;
            ultimo = nuevo;
        }

        public char desencolar()
        {
            char x;
            x = primero.info;
            primero = primero.sgte;
            if (primero == null)
                ultimo = null;
            return x;
        }

        public bool esvacia()
        {
            if (primero == null)
                return true;
            else
                return false;
        }

        public void mostrar(ListBox lst)
        {
            lst.Items.Clear();
            NodoC p = primero;
            while (p != null)
            {
                lst.Items.Add(p.info);
                p = p.sgte;
            }
        }
    }
}
