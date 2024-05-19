using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurasgeometricas
{
    abstract class Figura//Clase padre
    {
        //Esta clase permite el ingreso de un lado para poder crear una nueva figura geometrica
        //Una figura para existir debe tener minimo un lado
        //VARIABLES (se va a pasar a las clases hijas que servir+an para guardar en caja de memoria el valor del primer lado

        //La variable debe ser privada
        private float lado1;

        //CREACION DE ATRIBUTOS Y PROPIEDADES
        //SE DEFINE EL CONSTRUCTOR
        public float Lado1
        {
            //MODIFICADOR PARA PONER EL VALOR EN CAJA DE MEMORIA
            set//poner el valor
            {
                //pregunta si el lado es menor  0
                if (value < 0)
                {
                    lado1 = 0; //manda el valor a cero ya que no hay lados negativos
                }
                else
                {
                    lado1 = value;//Valor del textbox
                }
            }
            get { return lado1; }//regresa o cacha el valor de la variable lado1
        }
        //DEFINIR METODOS , FUNCIONES Y OPERACIONES DE LA CLASE PADRE
        //METODOS PUBLICOS PARA QUE SE USEN
        //METODS ABSTRACTOS
        public abstract float area();
        public abstract float perimetro();
        public abstract float volumen();
    }
    
}
