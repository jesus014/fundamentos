using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos.Models
{
    internal class Cerveza:Bebida,IBebidaAlcoholica
    {
        public int Alcohol { get; set; }



        //el ctor es un metodo
        public Cerveza(int Cantidad, string Nombre="Cervezas"):base(Nombre, Cantidad)
        {

        }

        public void MaxRecomendado()
        {

            Console.WriteLine("el maximo es 50");
        }
    }
}
