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

namespace Laboratorio_5_y_6.EJERCICIO_C8
{
    public partial class C8 : Form
    {
        PilaC8 pila = new PilaC8();
        Cola8 cola = new Cola8();
        public C8()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string numero = txtNumero.Text;
                int n = numero.Length;
                if (n != 0)
                {
                    if (pila.Palindrome(numero,n,pila,cola))
                    {
                        MessageBox.Show("El numero es capicua", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNumero.Clear();
                        txtNumero.Focus();

                    }
                    else
                    {
                        MessageBox.Show("El numero no es capicua", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNumero.Clear();
                        txtNumero.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor introduca un caracter valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumero.Clear();
                    txtNumero.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Clear();
                txtNumero.Focus();
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
