using Laboratorio_5_y_6.EJERCICIO_1P;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5_y_6.EJERCICIO_C7
{
    internal class NodoC
    {
        private char vinfo;
        private NodoC vsgte;

        public char info
        {
            get { return vinfo; }
            set { vinfo = value; }
        }
        public NodoC sgte
        {
            get { return vsgte; }
            set { vsgte = value; }

        }

        public NodoC (char vinfo)
        {
            info = vinfo;
            sgte = null;
        }

        public NodoC (char vinfo, NodoC vsgte)
        {
            info = vinfo;
            sgte = vsgte;
        }
    }
}
