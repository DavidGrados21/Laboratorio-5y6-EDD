using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5_y_6.EJERCICIO_C3
{
    internal class nodoPersona
    {
        private Personas vinfo;
        private nodoPersona vsgte;

        public Personas info
        {
            get { return vinfo; }
            set { vinfo = value; }
        }

        public nodoPersona sgte
        {
            get { return vsgte; }
            set { vsgte = value; }
        }

        public nodoPersona()
        {

        }
        public nodoPersona(Personas vinfo)
        {
            info = vinfo;
            sgte = null;
        }
        public nodoPersona(Personas vinfo, nodoPersona vsgte)
        {
            info = vinfo;
            sgte = vsgte;
        }
    }
}
