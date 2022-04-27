using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos.Models
{
     class vino : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public vino(int Cantidad, string Nombre = "Vinos") : base(Nombre, Cantidad)
        {

        }
        public void MaxRecomendado()
        {
            Console.WriteLine("el maximo es 60");

        }
    }
}
