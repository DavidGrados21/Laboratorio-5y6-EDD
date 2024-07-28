using Laboratorio_5_y_6.EJERCICIO_C1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6.EJERCICIO_C3
{
    internal class Colas3
    {
        private nodoPersona vprimero;
        private nodoPersona vultimo;

        public nodoPersona primero
        {
            get { return vprimero; }
            set { vprimero = value; }
        }

        public nodoPersona ultimo
        {
            get { return vultimo; }
            set { vultimo = value; }
        }

        public void encolar(Personas x)
        {
            nodoPersona nuevo = new nodoPersona(x);

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
            nodoPersona actual = primero;
            while (actual != null)
            {
                ListViewItem listItem = new ListViewItem(actual.info.Nombre);
                listItem.SubItems.Add(actual.info.edad.ToString());
                lstv.Items.Add(listItem);
                actual = actual.sgte;
            }
        }
        public void Dividir(Colas3 Infantes, Colas3 Niños, Colas3 Adolescentes, Colas3 Jovenes, Colas3 Adultos, Colas3 Adultos_Mayores)
        {
            while (primero != null)
            {
                if (primero.info.edad >= 0 && primero.info.edad <= 6)
                {
                    Infantes.encolar(primero.info);
                    primero = primero.sgte;
                }   
                else if (primero.info.edad >= 7 && primero.info.edad <= 14)
                {
                    Niños.encolar(primero.info);
                    primero = primero.sgte;
                }
                else if (primero.info.edad >= 15 && primero.info.edad <= 18)
                {
                    Adolescentes.encolar(primero.info);
                    primero = primero.sgte;
                }
                else if (primero.info.edad >= 19 && primero.info.edad <= 35)
                {
                    Jovenes.encolar(primero.info);
                    primero = primero.sgte;
                }
                else if (primero.info.edad >= 36 && primero.info.edad <= 50)
                {
                    Adultos.encolar(primero.info);
                    primero = primero.sgte;
                }   
                else
                {
                    Adultos_Mayores.encolar(primero.info);
                    primero = primero.sgte;
                }
            }
        }

        public void Mostrar_Todo(ListView lstv, Colas3 Infantes, Colas3 Niños, Colas3 Adolescentes, Colas3 Jovenes, Colas3 Adultos, Colas3 Adultos_Mayores)
        {
           // lstv.Items.Add("\n----------------");
            lstv.Items.Add("\n------- INFANTES -------");
            //lstv.Items.Add("----------------");
            Infantes.mostrar(lstv);

            //lstv.Items.Add("\n-----------------");
            lstv.Items.Add("\n------- NIÑOS -------");
            //lstv.Items.Add("-----------------");
            Niños.mostrar(lstv);

            //lstv.Items.Add("\n----------------");
            lstv.Items.Add("\n------- ADOLESCENTES -------");
            //lstv.Items.Add("----------------");
            Adolescentes.mostrar(lstv);

            //lstv.Items.Add("\n----------------");
            lstv.Items.Add("\n------- JOVENES -------");
            //lstv.Items.Add("----------------");
            Jovenes.mostrar(lstv);

            //lstv.Items.Add("\n----------------");
            lstv.Items.Add("\n------- ADULTOS -------");
            //lstv.Items.Add("----------------");
            Adultos.mostrar(lstv);

            //lstv.Items.Add("\n----------------");
            lstv.Items.Add("\n------- ADULTOS MAYORES -------");
            //lstv.Items.Add("----------------");
            Adultos_Mayores.mostrar(lstv);
        }
    }
}
