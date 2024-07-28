using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6.EJERCICIO_P3
{
    public partial class P3 : Form
    {
        Pila3 pila = new Pila3();
        public P3()
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
                    pila.capicua(numero, n);
                    if (pila.capicua(numero, n))
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
    }
}
