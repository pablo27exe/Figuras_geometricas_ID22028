using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurasgeometricas
{
    class Triangulo: Figura
    {
        //Uso del constructor de la clase padre
        //CREAR LADO 2/Altura
        private float altura;
        private float lado3;
        //Constructor para rectangulo
        public float Altura
        {
            //MODIFICADOR PARA PONER EL VALOR EN CAJA DE MEMORIA
            set//poner el valor
            {
                //pregunta si el lado es menor  0
                if (value < 0)
                {
                    altura = 0; //manda el valor a cero ya que no hay lados negativos
                }
                else
                {
                    altura = value;//Valor del textbox
                }
            }
            get { return altura; }//regresa o cacha el valor de la variable lado1
        }
        public float Lado3
        {
            //MODIFICADOR PARA PONER EL VALOR EN CAJA DE MEMORIA
            set//poner el valor
            {
                //pregunta si el lado es menor  0
                if (value < 0)
                {
                    lado3 = 0; //manda el valor a cero ya que no hay lados negativos
                }
                else
                {
                    lado3 = value;//Valor del textbox
                }
            }
            get { return lado3; }//regresa o cacha el valor de la variable lado1
        }


        public Triangulo(float lado1, float altura, float lado3)
        {
            this.Lado1 = lado1;//Hace que el valor del lado sea dispoible uncamente para rectangulo, en otro caso será igual a 0
            this.Altura = altura;
            this.Lado3 = lado3;
        }
        //Uso de los metods de la clase padre
        //Sobreescribir el comportamiento
        public override float area()
        {
            return (Lado1 * Altura);
        }
        public override float perimetro()
        {
            return Lado1 + Altura + Lado3;
        }
        public override float volumen()
        {
            throw new NotImplementedException();//Caso de excepción debido a que el circulo no necesita calcular volumen
        }
    }
}
