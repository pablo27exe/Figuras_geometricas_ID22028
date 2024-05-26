using FiguraGeometrica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figurasgeometricas
{
    public partial class Form2figuras : Form1
    {
        public Form2figuras()
        {
            InitializeComponent();
        }

        private void figura_CheckedChanged(object sender, EventArgs e)
        {

        }
        //EN ESTA PARTE SE COLOCA LA INSTRUCCIÓN PARA QUE EL MENSAJE DEL LABEL
        //CAMBIE DE ACUERDO A LA FIGURA QUE SE ELIJA
        private void circulo_CheckedChanged(object sender, EventArgs e)
        {
            if (circulo.Checked)
            {
                label2.Text = "Ingresa el valor del radio";
            }
        }


        private void trinagulo_CheckedChanged(object sender, EventArgs e)
        {
            if (trinagulo.Checked)
            {
                label2.Text = "Ingresa el valor de los lados";
            }
        }
         
        //en el caso de dar clic en cuadrilateros se abrirá un nuevo formulario 
        private void cuadrilateros_CheckedChanged(object sender, EventArgs e)
        {
            Form3cuadrilateros f3 = new Form3cuadrilateros();
            f3.Show();
            this.Hide();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            //En esta parte se hace el calculo del area y perímetro del circulo
            if (circulo.Checked)
            {
                // Asegurarse de que el texto se puede convertir a float
                if (float.TryParse(textBox1.Text, out float radio))
                {
                    Circulo circulo = new Circulo(radio);
                    textBox2.Text = circulo.area().ToString();
                    textBox3.Text = circulo.perimetro().ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un valor válido para el radio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //calculo del triangulo
            if (trinagulo.Checked)
            {
                //Stringstring[] parts se crea un arreglo llamado partes
                //textBox1 es de donde se obtienen los datos
                //Split es un método que divide una cadena en partes más pequeñas delimitadas por un caracter
                string[] partes = textBox1.Text.Split(',');
                // Asegurarse de que el texto se puede convertir a float
                if (partes.Length == 3 &&
                    float.TryParse(partes[0], out float Lado1) &&
                    float.TryParse(partes[1], out float Altura) &&
                    float.TryParse(partes[2], out float Lado3))
                {
                    Triangulo triangulo = new Triangulo(Lado1, Altura, Lado3);
                    textBox2.Text = triangulo.area().ToString();
                    textBox3.Text = triangulo.perimetro().ToString();
                }
                else
                {
                    MessageBox.Show("Ingresa los valores de base, altura y lado 3 separados por una coma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //calculo del poligono
            if (poligono.Checked)
            {
                //Stringstring[] parts se crea un arreglo llamado partes
                //textBox1 es de donde se obtienen los datos
                //Split es un método que divide una cadena en partes más pequeñas delimitadas por un caracter
                string[] partes = textBox1.Text.Split(',');
                // Asegurarse de que el texto se puede convertir a float
                if (partes.Length == 3 &&
                    float.TryParse(partes[0], out float N) &&
                    float.TryParse(partes[1], out float Lado1) &&
                    float.TryParse(partes[2], out float Apo))
                {
                    PoligonoReg poligono = new PoligonoReg(N, Lado1, Apo);
                    textBox2.Text = poligono.area().ToString();
                    textBox3.Text = poligono.perimetro().ToString();
                }
                else
                {
                    MessageBox.Show("Ingresa los valores de numero de lados, lado y apotema separados por una coma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void poligono_CheckedChanged_1(object sender, EventArgs e)
        {
            if (poligono.Checked)
            {
                label2.Text = "Ingresa el numero de lados, medida de lado y apotema";
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
