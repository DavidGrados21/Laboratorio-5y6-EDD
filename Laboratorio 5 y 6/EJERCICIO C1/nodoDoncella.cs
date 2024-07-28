using Laboratorio_5_y_6.EJERCICIO_1P;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5_y_6.EJERCICIO_C1
{
    internal class nodoDoncella
    {
        private Doncella vinfo;
        private nodoDoncella vsgte;

        public Doncella info
        {
            get { return vinfo; }
            set { vinfo = value; }
        }
        public nodoDoncella sgte
        {
            get { return vsgte; }
            set { vsgte = value; }
        }

        public nodoDoncella(Doncella vinfo)
        {
            info = vinfo;
            sgte = null;
        }

        public nodoDoncella(Doncella vinfo, nodoDoncella vsgte)
        {
            info = vinfo;
            sgte = vsgte;
        }
    }
}
