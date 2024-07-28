using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5_y_6.EJERCICIO_C1
{
    internal class Doncella
    {
        private string vnombre;
        private int vtalla;

        public string Nombre
        {
            get { return vnombre; }
            set { vnombre = value; }
        }
        public int Talla
        {
            get { return vtalla; }
            set { vtalla = value; }
        }
        public Doncella(string vnombre, int vtalla)
        {
            Nombre = vnombre;
            Talla = vtalla;
        }
    }
}
