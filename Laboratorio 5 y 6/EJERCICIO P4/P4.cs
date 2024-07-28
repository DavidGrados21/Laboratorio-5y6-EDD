using Laboratorio_5_y_6.EJERCICIO_1P;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6.EJERCICIO_P4
{
    public partial class P4 : Form
    {
        pila4 pila = new pila4();
        pila4 pila1 = new pila4();
        public P4()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Rbt_Pila1.Checked == true)
                {
                    int x = int.Parse(txtValor.Text);
                    txtValor.Clear();
                    txtValor.Focus();
                    pila.push(x);
                    pila.mostrarTodo(lstDatos, pila1);

                }
                else if (Rbt_Pila2.Checked == true)
                {

                    int x = int.Parse(txtValor.Text);
                    txtValor.Clear();
                    txtValor.Focus();
                    pila1.push(x);
                    pila.mostrarTodo(lstDatos, pila1);

                }
            }
            catch
            {
                MessageBox.Show("Por favor, insertar un valor valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Clear();
                txtValor.Focus();
            }
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            if (pila.EsIgual(pila1) == true)

                MessageBox.Show("Las pilas son iguales ");
            else
                MessageBox.Show("Las Pilas no son iguales ");
        }
    }
}
