using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos.Models
{
    public class Cerveza : Bebida, IBebidaAlcoholica, IRequest
    {
        //Se tiene herencia de la classe bebida y de la interfaz IBebida alcoholica
        public int Alcohol { get; set; }

        public string Marca { get; set; }

        public int id { get; set; }

        //el ctor es un metodo
        public Cerveza(int Cantidad, string Nombre="Cervezas") : base(Nombre, Cantidad)
        {

        }
        public Cerveza():base(null,0)
        {

        }
        

        public void MaxRecomendado()
        {

            Console.WriteLine("el maximo es 50");
        }
    }
}
