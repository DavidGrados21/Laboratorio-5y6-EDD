using Laboratorio_5_y_6.EJERCICIO_C1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6.EJERCICIO_C5
{
    public partial class C5 : Form
    {
        Cola5 cola = new Cola5();
        Cola5 colaux = new Cola5();
        public C5()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string x = txtDato.Text;
                txtDato.Clear();
                txtDato.Focus();

                cola.encolar(x);
                lstDatos.Items.Clear();
                cola.mostrar(lstDatos);
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarR_Click(object sender, EventArgs e)
        {
            string f = txtEliminar.Text;
            txtEliminar.Clear();
            cola.eliminarRepetidas(f, colaux);
            colaux.mostrar(lstDatos);
        }
    }
}
