namespace Figurasgeometricas
{
    partial class Form3cuadrilateros
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
            this.cuadrado = new System.Windows.Forms.RadioButton();
            this.rectangulo = new System.Windows.Forms.RadioButton();
            this.rombo = new System.Windows.Forms.RadioButton();
            this.paralelogramo = new System.Windows.Forms.RadioButton();
            this.retoceder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // circulo
            // 
            this.circulo.Location = new System.Drawing.Point(17, 145);
            this.circulo.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(283, 259);
            // 
            // cuadrilateros
            // 
            this.cuadrilateros.Location = new System.Drawing.Point(17, 146);
            this.cuadrilateros.Visible = false;
            // 
            // trinagulo
            // 
            this.trinagulo.Location = new System.Drawing.Point(17, 146);
            this.trinagulo.Visible = false;
            // 
            // poligono
            // 
            this.poligono.Location = new System.Drawing.Point(17, 146);
            this.poligono.Visible = false;
            // 
            // clear
            // 
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Calcular
            // 
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // button1
            // 
            this.button1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.retoceder);
            this.groupBox1.Controls.Add(this.paralelogramo);
            this.groupBox1.Controls.Add(this.rombo);
            this.groupBox1.Controls.Add(this.rectangulo);
            this.groupBox1.Controls.Add(this.cuadrado);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            this.groupBox1.Controls.SetChildIndex(this.textBox3, 0);
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
            this.groupBox1.Controls.SetChildIndex(this.cuadrado, 0);
            this.groupBox1.Controls.SetChildIndex(this.rectangulo, 0);
            this.groupBox1.Controls.SetChildIndex(this.rombo, 0);
            this.groupBox1.Controls.SetChildIndex(this.paralelogramo, 0);
            this.groupBox1.Controls.SetChildIndex(this.retoceder, 0);
            // 
            // cuadrado
            // 
            this.cuadrado.AutoSize = true;
            this.cuadrado.Location = new System.Drawing.Point(302, 114);
            this.cuadrado.Name = "cuadrado";
            this.cuadrado.Size = new System.Drawing.Size(88, 20);
            this.cuadrado.TabIndex = 26;
            this.cuadrado.TabStop = true;
            this.cuadrado.Text = "Cuadrado";
            this.cuadrado.UseVisualStyleBackColor = true;
            this.cuadrado.CheckedChanged += new System.EventHandler(this.cuadrado_CheckedChanged);
            // 
            // rectangulo
            // 
            this.rectangulo.AutoSize = true;
            this.rectangulo.Location = new System.Drawing.Point(416, 114);
            this.rectangulo.Name = "rectangulo";
            this.rectangulo.Size = new System.Drawing.Size(97, 20);
            this.rectangulo.TabIndex = 27;
            this.rectangulo.TabStop = true;
            this.rectangulo.Text = "Rectangulo";
            this.rectangulo.UseVisualStyleBackColor = true;
            this.rectangulo.CheckedChanged += new System.EventHandler(this.rectangulo_CheckedChanged);
            // 
            // rombo
            // 
            this.rombo.AutoSize = true;
            this.rombo.Location = new System.Drawing.Point(302, 145);
            this.rombo.Name = "rombo";
            this.rombo.Size = new System.Drawing.Size(73, 20);
            this.rombo.TabIndex = 28;
            this.rombo.TabStop = true;
            this.rombo.Text = "Rombo";
            this.rombo.UseVisualStyleBackColor = true;
            this.rombo.CheckedChanged += new System.EventHandler(this.rombo_CheckedChanged);
            // 
            // paralelogramo
            // 
            this.paralelogramo.AutoSize = true;
            this.paralelogramo.Location = new System.Drawing.Point(416, 141);
            this.paralelogramo.Name = "paralelogramo";
            this.paralelogramo.Size = new System.Drawing.Size(118, 20);
            this.paralelogramo.TabIndex = 29;
            this.paralelogramo.TabStop = true;
            this.paralelogramo.Text = "Paralelogramo";
            this.paralelogramo.UseVisualStyleBackColor = true;
            this.paralelogramo.CheckedChanged += new System.EventHandler(this.paralelogramo_CheckedChanged);
            // 
            // retoceder
            // 
            this.retoceder.Location = new System.Drawing.Point(545, 333);
            this.retoceder.Name = "retoceder";
            this.retoceder.Size = new System.Drawing.Size(120, 31);
            this.retoceder.TabIndex = 30;
            this.retoceder.Text = "Retroceder";
            this.retoceder.UseVisualStyleBackColor = true;
            this.retoceder.Click += new System.EventHandler(this.retoceder_Click);
            // 
            // Form3cuadrilateros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 723);
            this.Name = "Form3cuadrilateros";
            this.Text = "Form3cuadrilateros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton paralelogramo;
        private System.Windows.Forms.RadioButton rombo;
        private System.Windows.Forms.RadioButton rectangulo;
        private System.Windows.Forms.RadioButton cuadrado;
        private System.Windows.Forms.Button retoceder;
    }
}