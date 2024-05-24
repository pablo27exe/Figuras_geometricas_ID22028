using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurasgeometricas
{
    /*Se definió a la clase Polígono Irregular como una clase abstracta, heredó de figura los métodos de área, perímetro y volumen.
Se añadió la propiedad Lado1 para representar el lado del polígono, y su valor se inicializa a través del constructor de la clase.

En las clases que surgen del PolígonoIrregular (es decir Rombo y Paralelogramo), se usa el constructor base ":base(lado1)" para poder inicializar la propiedad de lado1 que anteriormente fue definida en PolígonoIrregular.
Esto permite que lado1 inicie de manera correcta antes que lo que se ha programado para los casos de Rombo y Paralelogramo.

La palabra clave base se usa para acceder a los miembros de la clase base desde una clase derivada. Se usa para especificar a qué constructor de clase base se debe llamar cuando se crean instancias de la clase derivada.*/
    abstract class PoligonoIrregular : Figura
    {
        public PoligonoIrregular(float lado1)
        {//El radio se lee de la caja de texto con el boton de guardar
            this.Lado1 = lado1;//Hace que el valor del lado sea dispoible uncamente para rectangulo, en otro caso será igual a 0
        }
        //Uso de los metods de la clase padre
        //Sobreescribir el comportamiento
        public override float area()
        {
            return (float)Math.Pow(Lado1, 2);
        }
        public override float perimetro()
        {
            return (4 * Lado1);
        }
        public override float volumen()
        {
            throw new NotImplementedException();//Caso de excepción debido a que el poligono no necesita calcular volumen
        }

        class Rombo : PoligonoIrregular
        {
            private float diagonalMayor;
            private float diagonalMenor;

            public float DiagonalMayor
            {
                set
                {
                    if (value < 0)
                    {
                        diagonalMayor = value;
                    }
                    else
                    {
                        diagonalMayor = value;
                    }
                }
                get
                {
                    return diagonalMayor;
                }
            }

            public float DiagonalMenor
            {
                set
                {
                    if (value < 0)
                    {
                        diagonalMenor = value;
                    }
                    else
                    {
                        diagonalMenor = value;
                    }
                }
                get
                {
                    return diagonalMenor;
                }
            }

            public Rombo(float lado1, float diagonalMayor, float diagonalMenor)
            : base(lado1)  // Llama al constructor de PoligonoIrregular para inicializar Lado1
            {
                this.DiagonalMayor = diagonalMayor;
                this.DiagonalMenor = diagonalMenor;
                this.Lado1 = lado1;
            }

            public override float area()
            {
                return (DiagonalMayor * DiagonalMenor) / 2;
            }
            public override float perimetro()
            {
                return 4 * Lado1;
            }
            public override float volumen()
            {
                throw new NotImplementedException();
            }
        }
        class Paralelogramo : PoligonoIrregular
        {
            private float base1;
            private float altura;

            public float Base1
            {
                set
                {
                    if (value < 0)
                    {
                        base1 = value;
                    }
                    else
                    {
                        base1 = value;
                    }
                }
                get
                {
                    return base1;
                }
            }


            public float Altura
            {
                set
                {
                    if (value < 0)
                    {
                        altura = value;
                    }
                    else
                    {
                        altura = value;
                    }
                }
                get
                {
                    return altura;
                }
            }

            public Paralelogramo(float lado1, float base1, float altura)
                : base(lado1)  // Llama al constructor de PoligonoIrregular para inicializar Lado1
            {
                this.Base1 = base1;
                this.Lado1 = lado1;
                this.Altura = altura;
            }

            public override float area()
            {
                return Base1 * altura;
            }
            public override float perimetro()
            {
                return 2 * (Lado1 + Base1);
            }
            public override float volumen()
            {
                throw new NotImplementedException();
            }
        }
    }
}

