using Laboratorio_5_y_6.EJERCICIO_C1;
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

namespace Laboratorio_5_y_6.EJERCICIO_C6
{
    public partial class C6 : Form
    {
        Cola6 Cola = new Cola6();
        PilaC6 Pila = new PilaC6();
        public C6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numero = txtValor.Text;
            if(numero != "")
            {
                int n = numero.ToString().Length;

                for (int i = 0; i < n; i++)
                {
                    int num = int.Parse(numero[i].ToString()); ;
                    Cola.encolar(num);
                }
                while (!Cola.esVacia())
                {
                    Pila.push(Cola.desencolar());
                }
                lstDatos.Items.Clear();
                Pila.mostrar(lstDatos);
            }
            else
            {
                MessageBox.Show("Por favor, coloca un valor valido");
            }

            txtValor.Clear();
            txtValor.Focus();
        }
    }
}
