using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos.Models
{
    internal interface IBebidaAlcoholica
    {
        //interfaz que se utiliza como una regla para las classes. 
        public int Alcohol { get; set; }

        //Se declaran los metodos. 
        public void MaxRecomendado();
    }
}
