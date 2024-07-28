using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5_y_6.EJERCICIO_C5
{
    internal class nodo5
    {
        private string vinfo;
        private nodo5 vsgte;

        public string info
        {
            get { return vinfo; }
            set { vinfo = value; }
        }

        public nodo5 sgte 
        {
            get { return vsgte; }
            set { vsgte = value; }
        }

        public nodo5( string vinfo)
        {
            info = vinfo;
            vsgte = null;
        }

        public nodo5(string vinfo, nodo5 vsgte)
        {
            info = vinfo;
            sgte = vsgte;
        }
    }
}
