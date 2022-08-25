using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos.Errors
{
    public class NotFoundBeerException:Exception
    {
        public NotFoundBeerException():base(){}
        public NotFoundBeerException(string message): base(message){}
        public NotFoundBeerException(string message, Exception inner):base(message, inner){}
    }
}
