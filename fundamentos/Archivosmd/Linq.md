

```csharp

// See https://aka.ms/new-console-template for more information
using fundamentos.Models;
using System.Text.Json;

namespace fundamentos
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //Service.sendRequest<Post> service2 = new Service.sendRequest<Post>();
            //var CervezaRespuestaa = await service2.Send(post);


            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

            var numero5 = numeros.Where(x => x == 7).FirstOrDefault();
            Console.WriteLine(numero5);

            var numerosOrdenados = numeros.OrderBy(x => x);

            foreach (var item in numerosOrdenados)
            {
                Console.WriteLine(item);
            }

            var total = numeros.Sum(d=>d);  
            Console.WriteLine(total);


            List<Cerveza> cervezas = new List<Cerveza>()
            {
                new Cerveza(){Alcohol=12, Cantidad=12, Nombre="cheve", Marca="vadfasdf"},
                new Cerveza(){Alcohol=23, Cantidad=11, Nombre="cheve2", Marca="vadfasdf3"},
                new Cerveza(){Alcohol=234, Cantidad=12, Nombre="cheve", Marca="vadfasdf"},


            };

            var cervezasOrdenadas = from d in cervezas orderby d.Marca select d;

            foreach (var item in cervezasOrdenadas)
            {
                Console.WriteLine($"{item.Marca}");
            }

            var cervezasOrdening = cervezas.OrderBy(x => x.Marca);


            //Linq mas detallado.
            //Se utiliza para realizar consultas.

            List<Bar> bares = new List<Bar>()
            {
                new Bar ("el bar")
                {
                    CervezaList = new List<Cerveza>()
                    {
                        new Cerveza(){Alcohol=12, Cantidad=12, Nombre="cheve", Marca="vadfasdf"},
                        new Cerveza(){Alcohol=23, Cantidad=11, Nombre="cheve2", Marca="vadfasdf3"},
                        new Cerveza(){Alcohol=234, Cantidad=12, Nombre="cheve", Marca="vadfasdf"},

                    }
                },

                new Bar ("el bar2")
                {
                    CervezaList = new List<Cerveza>()
                    {
                        new Cerveza(){Alcohol=12, Cantidad=12, Nombre="cheve3", Marca="vadfasdf"},
                        new Cerveza(){Alcohol=23, Cantidad=11, Nombre="cheve4", Marca="vadfasdf3"},
                        new Cerveza(){Alcohol=234, Cantidad=12, Nombre="chev5", Marca="vadfasdf"},

                    }
                }
            };


            var bar = (from d in bares where d.CervezaList.Where(c => c.Nombre == "cheve3").Count() > 0 select d).ToList();


            //var bar2 = (from d in bares where d.CervezaList.Where(c => c.Nombre == "cheve3").Count() > 0
            //            select new BarData(d.Nombre)
            //{
            //    bebidas = (from c in d.CervezaList select new Bebida(c.Nombre, c.Cantidad).ToList()
            //}.ToList();

        }

    }
}
```
