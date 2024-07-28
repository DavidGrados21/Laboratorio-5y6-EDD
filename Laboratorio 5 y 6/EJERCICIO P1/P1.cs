using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6.EJERCICIO_P1
{
    public partial class P1 : Form
    {
        Pila pila = new Pila();
        Pila pilaux = new Pila();
        public P1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtDato.Text);
                txtDato.Clear();
                txtDato.Focus();
                pila.push(x);
                pila.mostrar(listBox1);
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDato.Clear();
                txtDato.Focus();
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int m = int.Parse(numericUpDown1.Value.ToString());
            while (!pila.esVacia())
            {
                pilaux.push(pila.pop());
            }
            while (!pilaux.esVacia())
            {
                pila.push(pilaux.pop() * m);
            }

            pila.mostrar(listBox1);
        }
    }
}
