using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos.Models
{
    public class BarData
    {
        public string Nombre { get; set; }
        //Se crea una lista de bebidas
        public List<Bebida> bebidas = new List<Bebida>();

        //Se inicializa el constructor con un nombre.
        public BarData(string Nombre)
        {
            this.Nombre = Nombre;
        }
    }
}
