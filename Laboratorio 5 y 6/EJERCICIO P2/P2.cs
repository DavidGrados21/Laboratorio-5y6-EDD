using Laboratorio_5_y_6.EJERCICIO_1P;
using Laboratorio_5_y_6.EJERCICIO_P1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_5_y_6.EJERCICIO_P2
{
    public partial class P2 : Form
    {
        Pila2 PILA = new Pila2 ();
        Pila2 PILAUX = new Pila2 ();
        public P2()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            PILA.generartxt(lstTexto,PILAUX);
            lstTexto.Items.Add("-------------------");
            while (!PILAUX.esVacia())
            {
                lstTexto.Items.Add(PILAUX.pop());
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string x = txtFrase.Text;
                txtFrase.Clear();
                txtFrase.Focus();
                PILA.push(x);
                PILA.mostrar(lstTexto);
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFrase.Clear();
                txtFrase.Focus();
            }
        }
        private void btnabrir_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "E:\\";
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";;


            DialogResult result = openFileDialog.ShowDialog();
            string filePath = null;

            if (result == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
            StreamReader sr = new StreamReader(filePath);
            String Line = sr.ReadLine();
            while (Line != null)
            {
                Console.WriteLine(Line);
                PILA.push(Line);
                Line = sr.ReadLine();
            }
            sr.Close();
            PILA.mostrar(lstTexto);
        }
    }
}