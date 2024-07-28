namespace Laboratorio_5_y_6.EJERCICIO_C4
{
    partial class C4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dato";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(10, 43);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(155, 20);
            this.txtDato.TabIndex = 1;
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(176, 15);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(127, 212);
            this.lstDatos.TabIndex = 2;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(97, 69);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(68, 38);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(97, 189);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(68, 38);
            this.btnContar.TabIndex = 4;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // C4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(315, 235);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.label1);
            this.Name = "C4";
            this.Text = "C4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnContar;
    }
}