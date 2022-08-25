## Uso de excepciones haciendo uso de try catch.


```csharp
// See https://aka.ms/new-console-template for more information
using fundamentos.Errors;
using fundamentos.Models;
using fundamentos.Service;
using System.Text.Json;

namespace fundamentos
{
    class Program
    {
         public delegate string Mostrar(string cadena);

        static async Task Main(string[] args)
        {

            try
            {
                var searcherBeer = new SearcherBeer();
                var cantidad = searcherBeer.GetCantidad("csdds");
            }
            catch (FieldAccessException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (NotFoundBeerException ex){
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("siempre se ejecuta");
            }
       

    }
}
```


## Creacion de excepcion personalizada.


```csharp
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

```


## Uso de excepcion personalizada.


```csharp
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

```
