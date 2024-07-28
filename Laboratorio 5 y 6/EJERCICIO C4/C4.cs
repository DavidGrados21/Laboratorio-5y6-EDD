using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6.EJERCICIO_C4
{
    public partial class C4 : Form
    {
        Colas4 cola = new Colas4 ();
        Colas4 aux = new Colas4();
        public C4()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int k = int.Parse(txtDato.Text);
            txtDato.Clear();
            txtDato.Focus();

            cola.encolar(k);
            lstDatos.Items.Clear();
            cola.mostrar(lstDatos);
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int C = 0;
            while (!cola.esVacia())
            {
                aux.encolar(cola.desencolar());
                C++;
            }
            lstDatos.Items.Clear();
            aux.mostrar(lstDatos);

            MessageBox.Show("El numero de elementos de la cola es " + C);
        }
    }
}
