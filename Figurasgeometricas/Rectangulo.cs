using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurasgeometricas
{
    class Rectangulo:Figura
    {
        //Uso del constructor de la clase padre
        //CREAR LADO 2
        private float lado2;
        //Constructor para rectangulo
        public float Lado2
        {
            //MODIFICADOR PARA PONER EL VALOR EN CAJA DE MEMORIA
            set//poner el valor
            {
                //pregunta si el lado es menor  0
                if (value < 0)
                {
                    lado2 = 0; //manda el valor a cero ya que no hay lados negativos
                }
                else
                {
                    lado2 = value;//Valor del textbox
                }
            }
            get { return lado2; }//regresa o cacha el valor de la variable lado1
        }

        public Rectangulo(float lado1, float lado2)
        {//El radio se lee de la caja de texto con el boton de guardar
            this.Lado1 = lado1;//Hace que el valor del lado sea dispoible uncamente para rectangulo, en otro caso será igual a 0
            this.Lado2 = lado2;
        }
        //Uso de los metods de la clase padre
        //Sobreescribir el comportamiento
        public override float area()
        {
            return Lado1 * Lado2;
        }
        public override float perimetro()
        {
            return (2 * Lado1) + (2 * Lado2);
        }
        public override float volumen()
        {
            throw new NotImplementedException();//Caso de excepción debido a que el circulo no necesita calcular volumen
        }
    }
}
