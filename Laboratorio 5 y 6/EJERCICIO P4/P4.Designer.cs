namespace Laboratorio_5_y_6.EJERCICIO_P4
{
    partial class P4
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.Rbt_Pila1 = new System.Windows.Forms.RadioButton();
            this.Rbt_Pila2 = new System.Windows.Forms.RadioButton();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnComparar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(63, 18);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(105, 20);
            this.txtValor.TabIndex = 1;
            // 
            // Rbt_Pila1
            // 
            this.Rbt_Pila1.AutoSize = true;
            this.Rbt_Pila1.Location = new System.Drawing.Point(51, 44);
            this.Rbt_Pila1.Name = "Rbt_Pila1";
            this.Rbt_Pila1.Size = new System.Drawing.Size(51, 17);
            this.Rbt_Pila1.TabIndex = 2;
            this.Rbt_Pila1.TabStop = true;
            this.Rbt_Pila1.Text = "Pila 1";
            this.Rbt_Pila1.UseVisualStyleBackColor = true;
            // 
            // Rbt_Pila2
            // 
            this.Rbt_Pila2.AutoSize = true;
            this.Rbt_Pila2.Location = new System.Drawing.Point(51, 61);
            this.Rbt_Pila2.Name = "Rbt_Pila2";
            this.Rbt_Pila2.Size = new System.Drawing.Size(51, 17);
            this.Rbt_Pila2.TabIndex = 3;
            this.Rbt_Pila2.TabStop = true;
            this.Rbt_Pila2.Text = "Pila 2";
            this.Rbt_Pila2.UseVisualStyleBackColor = true;
            // 
            // lstDatos
            // 
            this.lstDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lstDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDatos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(12, 84);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(156, 197);
            this.lstDatos.TabIndex = 4;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(174, 15);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(98, 23);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(174, 260);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(98, 23);
            this.btnComparar.TabIndex = 6;
            this.btnComparar.Text = "Comparacion";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // P4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(282, 295);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.Rbt_Pila2);
            this.Controls.Add(this.Rbt_Pila1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "P4";
            this.Text = "P4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.RadioButton Rbt_Pila1;
        private System.Windows.Forms.RadioButton Rbt_Pila2;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnComparar;
    }
}