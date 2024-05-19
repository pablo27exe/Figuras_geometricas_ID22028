using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurasgeometricas
{
    class Circulo: Figura//Clase hija de figura
    {
        //Uso del constructor de la clase padre
        public Circulo(float radio) 
        {//El radio se lee de la caja de texto con el boton de guardar
        Lado1 = radio;
        }
        //Uso de los metods de la clase padre
        //Sobreescribir el comportamiento
        public override float area()
        {
            return 3.1416F * (Lado1 * Lado1);
        }
        public override float perimetro()
        {
            return 3.1416F * (Lado1 * 2);
        }
        public override float volumen()
        {
            throw new NotImplementedException();//Caso de excepción debido a que el circulo no necesita calcular volumen
        }
    }
}
