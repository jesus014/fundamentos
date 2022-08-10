using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos.Models
{
    //Se tiene herencia de la classe bebida y de la interfaz IBebida alcoholica
     class Vino : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public Vino(int Cantidad, string Nombre = "Vinos") : base(Nombre, Cantidad)
        {

        }
        public void MaxRecomendado()
        {
            Console.WriteLine("el maximo es 60");

        }
    }
}
