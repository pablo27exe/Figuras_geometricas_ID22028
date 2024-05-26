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
            this.button1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.draw = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Button();
            this.Calcular = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.poliedros = new System.Windows.Forms.RadioButton();
            this.figura = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.exit);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.export);
            this.groupBox1.Controls.Add(this.draw);
            this.groupBox1.Controls.Add(this.info);
            this.groupBox1.Controls.Add(this.Calcular);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.poliedros);
            this.groupBox1.Controls.Add(this.figura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(836, 683);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(545, 333);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Retroceder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(674, 333);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(121, 32);
            this.exit.TabIndex = 18;
            this.exit.Text = "Salir";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // clear
            // 
            this.clear.Enabled = false;
            this.clear.Location = new System.Drawing.Point(416, 333);
            this.clear.Margin = new System.Windows.Forms.Padding(4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(121, 32);
            this.clear.TabIndex = 17;
            this.clear.Text = "Limpiar";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // export
            // 
            this.export.Enabled = false;
            this.export.Location = new System.Drawing.Point(286, 333);
            this.export.Margin = new System.Windows.Forms.Padding(4);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(121, 32);
            this.export.TabIndex = 16;
            this.export.Text = "Exportar";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // draw
            // 
            this.draw.Enabled = false;
            this.draw.Location = new System.Drawing.Point(157, 333);
            this.draw.Margin = new System.Windows.Forms.Padding(4);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(121, 32);
            this.draw.TabIndex = 15;
            this.draw.Text = "Dibujar";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click);
            // 
            // info
            // 
            this.info.Enabled = false;
            this.info.Location = new System.Drawing.Point(28, 333);
            this.info.Margin = new System.Windows.Forms.Padding(4);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(121, 32);
            this.info.TabIndex = 14;
            this.info.Text = "Información";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Calcular
            // 
            this.Calcular.Enabled = false;
            this.Calcular.Location = new System.Drawing.Point(465, 277);
            this.Calcular.Margin = new System.Windows.Forms.Padding(4);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(121, 32);
            this.Calcular.TabIndex = 13;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // save
            // 
            this.save.Enabled = false;
            this.save.Location = new System.Drawing.Point(594, 277);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 32);
            this.save.TabIndex = 12;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(279, 285);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // poliedros
            // 
            this.poliedros.AutoSize = true;
            this.poliedros.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poliedros.Location = new System.Drawing.Point(477, 118);
            this.poliedros.Margin = new System.Windows.Forms.Padding(4);
            this.poliedros.Name = "poliedros";
            this.poliedros.Size = new System.Drawing.Size(178, 55);
            this.poliedros.TabIndex = 4;
            this.poliedros.TabStop = true;
            this.poliedros.Text = "Prisma";
            this.poliedros.UseVisualStyleBackColor = true;
            // 
            // figura
            // 
            this.figura.AutoSize = true;
            this.figura.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.figura.Location = new System.Drawing.Point(199, 118);
            this.figura.Margin = new System.Windows.Forms.Padding(4);
            this.figura.Name = "figura";
            this.figura.Size = new System.Drawing.Size(165, 55);
            this.figura.TabIndex = 2;
            this.figura.Text = "Figura";
            this.figura.UseVisualStyleBackColor = true;
            this.figura.CheckedChanged += new System.EventHandler(this.figura_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(80, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSTRUCTOR DE FIGURAS GEOMETRICAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 723);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton poliedros;
        public System.Windows.Forms.RadioButton figura;
        public System.Windows.Forms.Button clear;
        public System.Windows.Forms.Button export;
        public System.Windows.Forms.Button draw;
        public System.Windows.Forms.Button info;
        public System.Windows.Forms.Button Calcular;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button exit;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}
