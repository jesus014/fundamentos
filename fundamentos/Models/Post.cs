using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos.Models
{
    //Clase que sirve para usar servicio. 
    public class Post: IRequest
    {
        public int userId { get; set; }

        public int id { get; set; } 

        public string title { get; set; }   

        public string body { get; set; }

    }
}
