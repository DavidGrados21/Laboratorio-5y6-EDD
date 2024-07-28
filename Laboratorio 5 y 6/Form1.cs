using Laboratorio_5_y_6.EJERCICIO_P1;
using Laboratorio_5_y_6.EJERCICIO_P2;
using Laboratorio_5_y_6.EJERCICIO_P3;
using Laboratorio_5_y_6.EJERCICIO_P4;
using Laboratorio_5_y_6.EJERCICIO_P5;
using Laboratorio_5_y_6.EJERCICIO_P6;
using Laboratorio_5_y_6.EJERCICIO_C1;
using Laboratorio_5_y_6.EJERCICIO_C3;
using Laboratorio_5_y_6.EJERCICIO_C4;
using Laboratorio_5_y_6.EJERCICIO_C5;
using Laboratorio_5_y_6.EJERCICIO_C6;
using Laboratorio_5_y_6.EJERCICIO_C7;
using Laboratorio_5_y_6.EJERCICIO_C8;
using Laboratorio_5_y_6.EJERCICIO_C9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los integrantes son\n" +
    "\n- ARNOLD EMILIO CHOMBA SUAREZ" +
    "\n- DEYBY MAURICIO GRADOS SHUPINGAHUA" +
    "\n- KATHERINE LISBETH LLACCOLLA GAMBOA" +
    "\n- LAURA THALIA GARCIA LUJAN", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnP1_Click(object sender, EventArgs e)
        {
            Form ventana = new P1();
            ventana.Show();
        }

        private void btnP2_Click(object sender, EventArgs e)
        {
            Form ventana = new P2();
            ventana.Show();
        }

        private void btnP3_Click(object sender, EventArgs e)
        {
            Form ventana = new P3();
            ventana.Show();
        }

        private void btnP4_Click(object sender, EventArgs e)
        {
            Form ventana = new P4();
            ventana.Show();
        }

        private void btnP5_Click(object sender, EventArgs e)
        {
            Form ventana = new P5();
            ventana.Show();
        }

        private void btnP6_Click(object sender, EventArgs e)
        {
            Form ventana = new P6();
            ventana.Show();
        }
        private void btnC1_Click(object sender, EventArgs e)
        {
            Form ventana = new C1();
            ventana.Show();
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            Form ventana = new C3();
            ventana.Show();
        }
        private void btnC4_Click(object sender, EventArgs e)
        {
            Form ventana = new C4();
            ventana.Show();
        }
        private void btnC5_Click(object sender, EventArgs e)
        {
            Form ventana = new C5();
            ventana.Show();
        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            Form ventana = new C6();
            ventana.Show();
        }
        private void btnC7_Click(object sender, EventArgs e)
        {
            Form ventana = new C7();
            ventana.Show();
        }

        private void btnC8_Click(object sender, EventArgs e)
        {
            Form ventana = new C8();
            ventana.Show();
        }
        private void btnC9_Click(object sender, EventArgs e)
        {
            Form ventana = new C9();
            ventana.Show();
        }
    }
}
