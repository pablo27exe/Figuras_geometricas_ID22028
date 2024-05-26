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
    public partial class Form3cuadrilateros : Form2figuras
    {
        public Form3cuadrilateros()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //El label se modifica dependiendo de la figura
        private void cuadrado_CheckedChanged(object sender, EventArgs e)
        {
            if(cuadrado.Checked)
            {
                label2.Text = "Ingrese el valor del lado";
            }
        }

        private void rectangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rectangulo.Checked)
            {
                label2.Text = "Ingrese el valor de la base y la altura";
            }
        }

        private void rombo_CheckedChanged(object sender, EventArgs e)
        {
            if (rombo.Checked)
            {
                label2.Text = "Ingrese el valor del lado, diagonal mayor y menor";
            }
        }

        private void paralelogramo_CheckedChanged(object sender, EventArgs e)
        {
            /*if (paralelogramo.Checked)
            {
                label2.Text = "Ingrese el valor del lado";
            }*/
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            //Calculo de area y perimetro de cuadrado
            if (cuadrado.Checked)
            {
                // Asegurarse de que el texto se puede convertir a float
                if (float.TryParse(textBox1.Text, out float Lado1))
                {
                    Cuadrado cuadrado = new Cuadrado(Lado1);
                    textBox2.Text = cuadrado.area().ToString();
                    textBox3.Text = cuadrado.perimetro().ToString();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un valor válido para el lado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Calculo de rectangulo
            if (rectangulo.Checked)
            {
                //Stringstring[] parts se crea un arreglo llamado partes
                //textBox1 es de donde se obtienen los datos
                //Split es un método que divide una cadena en partes más pequeñas delimitadas por un caracter
                string[] partes = textBox1.Text.Split(',');
                // Asegurarse de que el texto se puede convertir a float
                if (partes.Length == 2 &&
                    float.TryParse(partes[0], out float Lado1) &&
                    float.TryParse(partes[1], out float Lado2))
                {
                    Rectangulo rectangulo = new Rectangulo(Lado1, Lado2);
                    textBox2.Text = rectangulo.area().ToString();
                    textBox3.Text = rectangulo.perimetro().ToString();
                }
                else
                {
                    MessageBox.Show("Ingresa los valores de base, altura separados por una coma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //calculo del rombo
            if (rombo.Checked)
            {
                //Stringstring[] parts se crea un arreglo llamado partes
                //textBox1 es de donde se obtienen los datos
                //Split es un método que divide una cadena en partes más pequeñas delimitadas por un caracter
                string[] partes = textBox1.Text.Split(',');
                // Asegurarse de que el texto se puede convertir a float
                if (partes.Length == 3 &&
                    float.TryParse(partes[0], out float Lado1) &&
                    float.TryParse(partes[1], out float DiagonalMayor) &&
                    float.TryParse(partes[2], out float DiagonalMenor))
                {
                    PoligonoIrregular.Rombo rombo = new PoligonoIrregular.Rombo(Lado1, DiagonalMayor, DiagonalMenor);
                    textBox2.Text = rombo.area().ToString();
                    textBox3.Text = rombo.perimetro().ToString();
                }
                else
                {
                    MessageBox.Show("Ingresa los valores de base, altura separados por una coma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //calculo del paralelogramo

        }
        //regresar al formulario anterior
        private void retoceder_Click(object sender, EventArgs e)
        {
            Form2figuras form2Figuras = new Form2figuras();
            form2Figuras.Show();
            this.Hide();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
