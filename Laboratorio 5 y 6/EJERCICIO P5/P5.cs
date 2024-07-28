using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6.EJERCICIO_P5
{
    public partial class P5 : Form
    {
        pila5 pila5 = new pila5();
        pila5 pilaux5 = new pila5();
        public P5()
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
                pila5.push(x);
                pila5.mostrar(listBox1);
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDato.Clear();
                txtDato.Focus();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            int x = 0;
            while (!pila5.esVacia())
            {
                pilaux5.push(pila5.pop());
                x++;
            }
            while (!pilaux5.esVacia())
            {
                pila5.push(pilaux5.pop());
            }

            MessageBox.Show("La pila contiene " + x + " elementos.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
