using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5_y_6.EJERCICIO_C3
{
    internal class Personas
    {
        private String vNombre;
        private int vEdad;

        public string Nombre
        {
            get { return vNombre; }
            set { vNombre = value; }
        }

        public int edad
        {
            get { return vEdad; } 
            set { vEdad = value; }
        }
        public Personas(String vNombre, int vEdad) 
        { 
            Nombre = vNombre;
            edad = vEdad;
        }
    }
}
