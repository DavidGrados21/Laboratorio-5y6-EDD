namespace Laboratorio_5_y_6.EJERCICIO_C9
{
    partial class C9
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
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dato";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(76, 60);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(63, 27);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(149, 12);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(203, 199);
            this.lstDatos.TabIndex = 2;
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(80, 181);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(63, 27);
            this.btnInvertir.TabIndex = 3;
            this.btnInvertir.Text = "Invertir";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(12, 34);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(127, 20);
            this.txtDato.TabIndex = 4;
            // 
            // C9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(364, 220);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label1);
            this.Name = "C9";
            this.Text = "C9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.TextBox txtDato;
    }
}