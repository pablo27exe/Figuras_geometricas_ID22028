using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurasgeometricas
{
    class Cuadrado: Figura
    {
        public Cuadrado(float lado1)
        {//El radio se lee de la caja de texto con el boton de guardar
            this.Lado1 = lado1;//Hace que el valor del lado sea dispoible uncamente para rectangulo, en otro caso será igual a 0
        }
        //Uso de los metods de la clase padre
        //Sobreescribir el comportamiento
        public override float area()
        {
            return (float)Math.Pow(Lado1,2);
        }
        public override float perimetro()
        {
            return (4 * Lado1);
        }
        public override float volumen()
        {
            throw new NotImplementedException();//Caso de excepción debido a que el circulo no necesita calcular volumen
        }
    }
}
