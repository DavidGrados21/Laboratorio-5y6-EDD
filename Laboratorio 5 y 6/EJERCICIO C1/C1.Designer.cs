namespace Laboratorio_5_y_6.EJERCICIO_C1
{
    partial class C1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C1));
            this.lstvdatos = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Talla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnelejir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstvdatos
            // 
            this.lstvdatos.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lstvdatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Talla});
            this.lstvdatos.HideSelection = false;
            this.lstvdatos.Location = new System.Drawing.Point(480, -3);
            this.lstvdatos.Name = "lstvdatos";
            this.lstvdatos.Size = new System.Drawing.Size(280, 295);
            this.lstvdatos.TabIndex = 0;
            this.lstvdatos.UseCompatibleStateImageBehavior = false;
            this.lstvdatos.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Talla
            // 
            this.Talla.Text = "Talla";
            this.Talla.Width = 120;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la Doncella";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Talla de la Doncella";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(168, 111);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(99, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(352, 111);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(99, 20);
            this.txtTalla.TabIndex = 5;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(261, 146);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(95, 22);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnelejir
            // 
            this.btnelejir.Location = new System.Drawing.Point(361, 261);
            this.btnelejir.Name = "btnelejir";
            this.btnelejir.Size = new System.Drawing.Size(90, 31);
            this.btnelejir.TabIndex = 7;
            this.btnelejir.Text = "ELEGIR";
            this.btnelejir.UseVisualStyleBackColor = true;
            this.btnelejir.Click += new System.EventHandler(this.btnelejir_Click);
            // 
            // C1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(767, 298);
            this.Controls.Add(this.btnelejir);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstvdatos);
            this.Name = "C1";
            this.Text = "Colas1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvdatos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnelejir;
        private System.Windows.Forms.ColumnHeader Talla;
        private System.Windows.Forms.ColumnHeader Nombre;
    }
}