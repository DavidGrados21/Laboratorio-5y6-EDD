namespace Laboratorio_5_y_6.EJERCICIO_C5
{
    partial class C5
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminarR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(16, 47);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(166, 20);
            this.txtDato.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dato";
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(204, 21);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(174, 251);
            this.lstDatos.TabIndex = 2;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(121, 73);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(61, 32);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminarR
            // 
            this.btnEliminarR.Location = new System.Drawing.Point(78, 249);
            this.btnEliminarR.Name = "btnEliminarR";
            this.btnEliminarR.Size = new System.Drawing.Size(104, 23);
            this.btnEliminarR.TabIndex = 4;
            this.btnEliminarR.Text = "Eliminar repetidos";
            this.btnEliminarR.UseVisualStyleBackColor = true;
            this.btnEliminarR.Click += new System.EventHandler(this.btnEliminarR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dato a Eliminar";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(16, 223);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(166, 20);
            this.txtEliminar.TabIndex = 5;
            // 
            // C5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(388, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btnEliminarR);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDato);
            this.Name = "C5";
            this.Text = "C5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminarR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEliminar;
    }
}