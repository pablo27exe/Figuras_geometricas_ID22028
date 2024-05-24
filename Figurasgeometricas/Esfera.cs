using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurasgeometricas
{
    internal class Esfera: Figura
    {
    //Uso del constructor de la clase padre
        public Esfera(float radio)
        {//El radio se lee de la caja de texto con el boton de guardar
            Lado1 = radio;
        }
        //Uso de los metods de la clase padre
        //Sobreescribir el comportamiento
        public override float area()
        {
            return (4*3.1416F) * (Lado1 * Lado1);
        }
        public override float perimetro()
        {
            return 3.1416F * (Lado1 * 2);
        }
        public override float volumen()
        {
            return ((4 * 3.1426F) * (float)Math.Pow(Lado1,3)) / 3;
        }
    }
}

