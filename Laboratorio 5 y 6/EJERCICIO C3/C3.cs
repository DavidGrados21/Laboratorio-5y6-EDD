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

namespace Laboratorio_5_y_6.EJERCICIO_C3
{
    public partial class C3 : Form
    {
        Colas3 COLA = new Colas3 ();
        Colas3 COLAinfantes = new Colas3();
        Colas3 COLAniños = new Colas3();
        Colas3 COLAadolescentes = new Colas3();
        Colas3 COLAjovenes = new Colas3();
        Colas3 COLAadultos = new Colas3();
        Colas3 COLAdultosM = new Colas3();
        public C3()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string S = txtNombre.Text;
                int I = int.Parse(txtEdad.Text);

                Personas x = new Personas(S, I);

                COLA.encolar(x);

                txtNombre.Clear();
                txtEdad.Clear();
                txtNombre.Focus();

                lstvdatos.Items.Clear();
                COLA.mostrar(lstvdatos);
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            COLA.Dividir(COLAinfantes, COLAniños, COLAadolescentes, COLAjovenes, COLAadultos, COLAdultosM);
            lstvdatos.Items.Clear();
            COLA.Mostrar_Todo(lstvdatos,COLAinfantes, COLAniños, COLAadolescentes, COLAjovenes, COLAadultos, COLAdultosM);
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstvdatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
