namespace Figurasgeometricas
{
    partial class Form2figuras
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.circulo = new System.Windows.Forms.RadioButton();
            this.poligono = new System.Windows.Forms.RadioButton();
            this.trinagulo = new System.Windows.Forms.RadioButton();
            this.cuadrilateros = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = true;
            // 
            // poliedros
            // 
            this.poliedros.Location = new System.Drawing.Point(17, 83);
            this.poliedros.Visible = false;
            // 
            // figura
            // 
            this.figura.Location = new System.Drawing.Point(17, 84);
            this.figura.Visible = false;
            this.figura.CheckedChanged += new System.EventHandler(this.figura_CheckedChanged);
            // 
            // clear
            // 
            this.clear.Enabled = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // export
            // 
            this.export.Enabled = true;
            // 
            // draw
            // 
            this.draw.Enabled = true;
            // 
            // info
            // 
            this.info.Enabled = true;
            // 
            // Calcular
            // 
            this.Calcular.Enabled = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // save
            // 
            this.save.Enabled = true;
            // 
            // button1
            // 
            this.button1.Enabled = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.cuadrilateros);
            this.groupBox1.Controls.Add(this.trinagulo);
            this.groupBox1.Controls.Add(this.poligono);
            this.groupBox1.Controls.Add(this.circulo);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.figura, 0);
            this.groupBox1.Controls.SetChildIndex(this.poliedros, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.save, 0);
            this.groupBox1.Controls.SetChildIndex(this.Calcular, 0);
            this.groupBox1.Controls.SetChildIndex(this.info, 0);
            this.groupBox1.Controls.SetChildIndex(this.draw, 0);
            this.groupBox1.Controls.SetChildIndex(this.export, 0);
            this.groupBox1.Controls.SetChildIndex(this.clear, 0);
            this.groupBox1.Controls.SetChildIndex(this.exit, 0);
            this.groupBox1.Controls.SetChildIndex(this.button1, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.circulo, 0);
            this.groupBox1.Controls.SetChildIndex(this.poligono, 0);
            this.groupBox1.Controls.SetChildIndex(this.trinagulo, 0);
            this.groupBox1.Controls.SetChildIndex(this.cuadrilateros, 0);
            this.groupBox1.Controls.SetChildIndex(this.textBox3, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(552, 402);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 21;
            // 
            // circulo
            // 
            this.circulo.AutoSize = true;
            this.circulo.Location = new System.Drawing.Point(279, 118);
            this.circulo.Name = "circulo";
            this.circulo.Size = new System.Drawing.Size(69, 20);
            this.circulo.TabIndex = 22;
            this.circulo.TabStop = true;
            this.circulo.Text = "Circulo";
            this.circulo.UseVisualStyleBackColor = true;
            this.circulo.CheckedChanged += new System.EventHandler(this.circulo_CheckedChanged);
            // 
            // poligono
            // 
            this.poligono.AutoSize = true;
            this.poligono.Location = new System.Drawing.Point(407, 165);
            this.poligono.Name = "poligono";
            this.poligono.Size = new System.Drawing.Size(82, 20);
            this.poligono.TabIndex = 23;
            this.poligono.TabStop = true;
            this.poligono.Text = "Poligono";
            this.poligono.UseVisualStyleBackColor = true;
            this.poligono.CheckedChanged += new System.EventHandler(this.poligono_CheckedChanged_1);
            // 
            // trinagulo
            // 
            this.trinagulo.AutoSize = true;
            this.trinagulo.Location = new System.Drawing.Point(279, 165);
            this.trinagulo.Name = "trinagulo";
            this.trinagulo.Size = new System.Drawing.Size(85, 20);
            this.trinagulo.TabIndex = 24;
            this.trinagulo.TabStop = true;
            this.trinagulo.Text = "Triangulo";
            this.trinagulo.UseVisualStyleBackColor = true;
            this.trinagulo.CheckedChanged += new System.EventHandler(this.trinagulo_CheckedChanged);
            // 
            // cuadrilateros
            // 
            this.cuadrilateros.AutoSize = true;
            this.cuadrilateros.Location = new System.Drawing.Point(407, 118);
            this.cuadrilateros.Name = "cuadrilateros";
            this.cuadrilateros.Size = new System.Drawing.Size(108, 20);
            this.cuadrilateros.TabIndex = 25;
            this.cuadrilateros.TabStop = true;
            this.cuadrilateros.Text = "Cuadrilateros";
            this.cuadrilateros.UseVisualStyleBackColor = true;
            this.cuadrilateros.CheckedChanged += new System.EventHandler(this.cuadrilateros_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(552, 430);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 26;
            // 
            // Form2figuras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 723);
            this.Name = "Form2figuras";
            this.Text = "Form2figuras";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RadioButton circulo;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.RadioButton cuadrilateros;
        public System.Windows.Forms.RadioButton trinagulo;
        public System.Windows.Forms.RadioButton poligono;
        public System.Windows.Forms.TextBox textBox3;
    }
}