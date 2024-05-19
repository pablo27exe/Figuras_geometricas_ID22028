namespace Figurasgeometricas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.poligonoirreg = new System.Windows.Forms.RadioButton();
            this.sphere = new System.Windows.Forms.RadioButton();
            this.poligonoreg = new System.Windows.Forms.RadioButton();
            this.Prisma = new System.Windows.Forms.RadioButton();
            this.rectangulo = new System.Windows.Forms.RadioButton();
            this.cube = new System.Windows.Forms.RadioButton();
            this.triangulo = new System.Windows.Forms.RadioButton();
            this.circle = new System.Windows.Forms.RadioButton();
            this.cuadrado = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.Calcular = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.draw = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exit);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.export);
            this.groupBox1.Controls.Add(this.draw);
            this.groupBox1.Controls.Add(this.info);
            this.groupBox1.Controls.Add(this.Calcular);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.poligonoirreg);
            this.groupBox1.Controls.Add(this.sphere);
            this.groupBox1.Controls.Add(this.poligonoreg);
            this.groupBox1.Controls.Add(this.Prisma);
            this.groupBox1.Controls.Add(this.rectangulo);
            this.groupBox1.Controls.Add(this.cube);
            this.groupBox1.Controls.Add(this.triangulo);
            this.groupBox1.Controls.Add(this.circle);
            this.groupBox1.Controls.Add(this.cuadrado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 468);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // poligonoirreg
            // 
            this.poligonoirreg.AutoSize = true;
            this.poligonoirreg.Location = new System.Drawing.Point(507, 52);
            this.poligonoirreg.Name = "poligonoirreg";
            this.poligonoirreg.Size = new System.Drawing.Size(107, 17);
            this.poligonoirreg.TabIndex = 10;
            this.poligonoirreg.TabStop = true;
            this.poligonoirreg.Text = "Poligono Irregular";
            this.poligonoirreg.UseVisualStyleBackColor = true;
            // 
            // sphere
            // 
            this.sphere.AutoSize = true;
            this.sphere.Location = new System.Drawing.Point(375, 105);
            this.sphere.Name = "sphere";
            this.sphere.Size = new System.Drawing.Size(55, 17);
            this.sphere.TabIndex = 9;
            this.sphere.TabStop = true;
            this.sphere.Text = "Esfera";
            this.sphere.UseVisualStyleBackColor = true;
            // 
            // poligonoreg
            // 
            this.poligonoreg.AutoSize = true;
            this.poligonoreg.Location = new System.Drawing.Point(375, 52);
            this.poligonoreg.Name = "poligonoreg";
            this.poligonoreg.Size = new System.Drawing.Size(101, 17);
            this.poligonoreg.TabIndex = 8;
            this.poligonoreg.TabStop = true;
            this.poligonoreg.Text = "Poligono regular";
            this.poligonoreg.UseVisualStyleBackColor = true;
            // 
            // Prisma
            // 
            this.Prisma.AutoSize = true;
            this.Prisma.Location = new System.Drawing.Point(250, 105);
            this.Prisma.Name = "Prisma";
            this.Prisma.Size = new System.Drawing.Size(56, 17);
            this.Prisma.TabIndex = 7;
            this.Prisma.TabStop = true;
            this.Prisma.Text = "Prisma";
            this.Prisma.UseVisualStyleBackColor = true;
            // 
            // rectangulo
            // 
            this.rectangulo.AutoSize = true;
            this.rectangulo.Location = new System.Drawing.Point(250, 52);
            this.rectangulo.Name = "rectangulo";
            this.rectangulo.Size = new System.Drawing.Size(80, 17);
            this.rectangulo.TabIndex = 6;
            this.rectangulo.TabStop = true;
            this.rectangulo.Text = "Rectangulo";
            this.rectangulo.UseVisualStyleBackColor = true;
            // 
            // cube
            // 
            this.cube.AutoSize = true;
            this.cube.Location = new System.Drawing.Point(120, 105);
            this.cube.Name = "cube";
            this.cube.Size = new System.Drawing.Size(50, 17);
            this.cube.TabIndex = 5;
            this.cube.TabStop = true;
            this.cube.Text = "Cubo";
            this.cube.UseVisualStyleBackColor = true;
            // 
            // triangulo
            // 
            this.triangulo.AutoSize = true;
            this.triangulo.Location = new System.Drawing.Point(120, 52);
            this.triangulo.Name = "triangulo";
            this.triangulo.Size = new System.Drawing.Size(69, 17);
            this.triangulo.TabIndex = 4;
            this.triangulo.TabStop = true;
            this.triangulo.Text = "Triangulo";
            this.triangulo.UseVisualStyleBackColor = true;
            // 
            // circle
            // 
            this.circle.AutoSize = true;
            this.circle.Location = new System.Drawing.Point(20, 105);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(57, 17);
            this.circle.TabIndex = 3;
            this.circle.TabStop = true;
            this.circle.Text = "Circulo";
            this.circle.UseVisualStyleBackColor = true;
            // 
            // cuadrado
            // 
            this.cuadrado.AutoSize = true;
            this.cuadrado.Location = new System.Drawing.Point(20, 52);
            this.cuadrado.Name = "cuadrado";
            this.cuadrado.Size = new System.Drawing.Size(71, 17);
            this.cuadrado.TabIndex = 2;
            this.cuadrado.TabStop = true;
            this.cuadrado.Text = "Cuadrado";
            this.cuadrado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar medida de lado, radio, etc.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSTRUCTOR DE FIGURAS GEOMETRICAS";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(308, 155);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 12;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = true;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(389, 152);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(91, 26);
            this.Calcular.TabIndex = 13;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(14, 215);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(91, 26);
            this.info.TabIndex = 14;
            this.info.Text = "Información";
            this.info.UseVisualStyleBackColor = true;
            // 
            // draw
            // 
            this.draw.Location = new System.Drawing.Point(111, 215);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(91, 26);
            this.draw.TabIndex = 15;
            this.draw.Text = "Dibujar";
            this.draw.UseVisualStyleBackColor = true;
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(208, 215);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(91, 26);
            this.export.TabIndex = 16;
            this.export.Text = "Exportar";
            this.export.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(305, 215);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(91, 26);
            this.clear.TabIndex = 17;
            this.clear.Text = "Limpiar";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(402, 215);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(91, 26);
            this.exit.TabIndex = 18;
            this.exit.Text = "Salir";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 498);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton poligonoirreg;
        private System.Windows.Forms.RadioButton sphere;
        private System.Windows.Forms.RadioButton poligonoreg;
        private System.Windows.Forms.RadioButton Prisma;
        private System.Windows.Forms.RadioButton rectangulo;
        private System.Windows.Forms.RadioButton cube;
        private System.Windows.Forms.RadioButton triangulo;
        private System.Windows.Forms.RadioButton circle;
        private System.Windows.Forms.RadioButton cuadrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button exit;
    }
}

