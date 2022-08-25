using fundamentos.Errors;
using fundamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos.Service
{
    public class SearcherBeer
    {
        List<Cerveza> cervezas = new List<Cerveza>()
        {
            new Cerveza(){Alcohol=12, Cantidad=21 , Marca="tecate", Nombre="azul"},
            new Cerveza(){Alcohol=13, Cantidad=21 , Marca="tecate", Nombre="Roja"}

        };

        public int GetCantidad(string Nombre)
        {
            var cerveza =(from c in cervezas
                          where c.Nombre == Nombre
                          select c).First();
            if (cerveza == null)
                throw new NotFoundBeerException("se a terminado");
            
            return cerveza.Cantidad;
        }

    }
}
