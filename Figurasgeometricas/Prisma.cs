using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurasgeometricas
{
    class Prisma: Figura
    {
        private float lado2;
        private float lado3;

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
        public Prisma(float lado1, float lado2, float lado3)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
        }
        public override float area()
        {
            return (2*Lado1 * Lado2)+(2*Lado1*Lado3)+(2*Lado2*Lado3);
        }
        public override float perimetro()
        {
            return (4*Lado1)+(4*Lado2)+(4*Lado3);
        }
        public override float volumen()
        {
            return Lado1*Lado2*Lado3;
        }
    }
}
