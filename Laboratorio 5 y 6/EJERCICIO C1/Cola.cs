using Laboratorio_5_y_6.EJERCICIO_1P;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6.EJERCICIO_C1
{
    internal class Cola
    {
        private nodoDoncella vprimero;
        private nodoDoncella vultimo;

        public nodoDoncella primero
        {
            get { return vprimero; }
            set { vprimero = value; }
        }

        public nodoDoncella ultimo
        {
            get { return vultimo; }
            set { vultimo = value; }
        }

        public void encolar (Doncella x )
        {
            nodoDoncella nuevo = new nodoDoncella(x);

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
        public void mostrar(ListView lstv)
        {
            nodoDoncella actual = primero;
            while (actual != null)
            {
                ListViewItem listItem = new ListViewItem(actual.info.Nombre);
                listItem.SubItems.Add(actual.info.Talla.ToString());
                lstv.Items.Add(listItem);
                actual = actual.sgte;

            }
        }

        public string comparar()
        {
            string NC = "";
            while (!esVacia())
            {
                int TI = 43;
                if (primero.info.Talla == TI)
                {
                     NC = primero.info.Nombre;
                     return NC;
                }
                    primero = primero.sgte;
            }
            return NC;
        }
    }
}
