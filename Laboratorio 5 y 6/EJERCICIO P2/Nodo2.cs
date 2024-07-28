using Laboratorio_5_y_6.EJERCICIO_1P;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5_y_6.EJERCICIO_P2
{
    internal class Nodo2
    {
        private string vinfo;
        private Nodo2 vsgte;

        public string info
        {
            get { return vinfo; }
            set { vinfo = value; }
        }
        public Nodo2 sgte
        {
            get { return vsgte; }
            set { vsgte = value; }
        }

        public Nodo2(string vinfo)
        {
            info = vinfo;
            sgte = null;
        }

        public Nodo2(string vinfo, Nodo2 vsgte)
        {
            info = vinfo;
            sgte = vsgte;
        }
    }
}
