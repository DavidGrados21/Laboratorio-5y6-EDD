using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6.EJERCICIO_C1
{
    public partial class C1 : Form
    {
        Cola cola = new Cola();
        public C1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                int talla = int.Parse(txtTalla.Text);
                Doncella x = new Doncella(nombre, talla);
                txtNombre.Clear();
                txtTalla.Clear();
                txtNombre.Focus();

                cola.encolar(x);
                lstvdatos.Items.Clear();
                cola.mostrar(lstvdatos);
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnelejir_Click(object sender, EventArgs e)
        {
            string T = cola.comparar();
            if (T == "")
                MessageBox.Show("Ninguna es cenicienta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("La señorita " + T + " es la cenicienta 👸", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
