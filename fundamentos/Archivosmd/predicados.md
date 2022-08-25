


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

        public class Beer
        {
            public string Name { get; set; }
            public int Alcohol { get; set; }

        }
        static async Task Main(string[] args)
        {
            //el predicado solo regresa un true o false.
            var numbers = new List<int> { 1,123,12312,3123,132};

            //creacion del predicado
            var predicado = new Predicate<int>(IsDivider2);
            var predicado2 = new Predicate<int>(x => x % 2 == 0);

            //creacion de predicado negativo
            Predicate<int> negativePredicate = x => !predicado(x);

            var divisibles2 = numbers.FindAll(predicado);

            divisibles2.ForEach(x => { Console.WriteLine(x); });



            var beers = new List<Beer>()
            {
                new Beer(){Name ="UNA", Alcohol=7},
                new Beer(){Name="dos", Alcohol=1}
            };

            ShowBeerThat(beers, x => x.Alcohol >= 5);
        }

        static bool IsDivider2(int x) => x% 2 == 0;

        static void ShowBeerThat(List<Beer> beers, Predicate<Beer> condicion)
        {
            var evilBeers= beers.FindAll(condicion).ToList();
            evilBeers.ForEach(x => { Console.WriteLine(x.Name); });
        }
    }
}
```
