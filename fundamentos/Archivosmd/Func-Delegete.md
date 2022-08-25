## Funciones Delegate.

funciones de delegate, 

Func sirve para recibir un parametro y regresa otro. 


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

         
            //recibe un string y regresa un int
            Func<string, int> mostrar2 = Show;


            //Action no regresa nada
            Action<string, string> mostrar = Show;

            //delegados
            Mostrar mostrar3 = Show;
            HacerAlgo(mostrar);


        }
        public static void HacerAlgo(Action<string, string> funcionFinal)
        {
            funcionFinal("Se envio desde otra funcion","dsadsd");

        }

            public static int Show(string cad)
            {
                return cad.Count();
                //Console.WriteLine("hola"+ cad);
            }

        public static void Show (string cad, string  cad2)
        {
            Console.WriteLine("hola"+ cad);

        }

    }
}
```
