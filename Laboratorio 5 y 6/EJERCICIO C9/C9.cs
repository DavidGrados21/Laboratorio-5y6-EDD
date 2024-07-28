using Laboratorio_5_y_6.EJERCICIO_P1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6.EJERCICIO_C9
{
    public partial class C9 : Form
    {
        Cola9 cola = new Cola9();
        Pila pila = new Pila();
        public C9()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int x = int.Parse (txtDato.Text);
            txtDato.Clear();
            txtDato.Focus();
            cola.encolar(x);
            lstDatos.Items.Clear();
            cola.mostrar(lstDatos);
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            cola.invertir(pila, lstDatos);
        }
    }
}
