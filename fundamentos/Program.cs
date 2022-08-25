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

            //CervezaBD cervezaBD = new CervezaBD();
            ////agregar datos 
            //{
            //    //los dos primeros datos estan en el constructor

            //    Cerveza cerveza = new Cerveza(20, "tecate");
            //    cerveza.Marca = "otra";
            //    cerveza.Alcohol = 5;
            //    cervezaBD.Add(cerveza);

            //}

            ////editar cerveza
            //{

            //    Cerveza cerveza = new Cerveza(20, "tecate");
            //    cerveza.Marca = "otra";
            //    cerveza.Alcohol = 20;
            //    cervezaBD.Edit(cerveza, 4);
            //}


            ////obtener datos
            //var cervezas = cervezaBD.Get();
            //foreach (var ce in cervezas)
            //{
            //    Console.WriteLine(ce.Nombre);
            //    Console.WriteLine(ce.Cantidad);
            //}

            ////eliminar
            //{


            //    cervezaBD.Delete(4);
            //}



            // SE PUEDE CREAR UN JSON 

            //Cerveza cerveza = new Cerveza(10, "cerzveza");
            //string miJson = JsonSerializer.Serialize(cerveza);
            //File.WriteAllText("objeto.txt", miJson);

            //Se desiariliza el json a un objeto.

            //string miJson= File.ReadAllText("objeto.txt");
            //Cerveza cerveza=JsonSerializer.Deserialize<Cerveza>(miJson);

            //solicitudes http a un webService  
            //string url = "https://jsonplaceholder.typicode.com/posts";
            //HttpClient client = new HttpClient();

            //metodo async
            //var httpResponse = await  client.GetAsync(url);

            //if (httpResponse.IsSuccessStatusCode)
            //{
            //    var content = await httpResponse.Content.ReadAsStringAsync();

            //    List<Post> posts = JsonSerializer.Deserialize<List<Post>>(content);

            //}


            //metodo post a un servicio.

            //Post post = new Post()
            //{
            //    userId = 1,
            //    body = "hola hola",
            //    title = "hola bye",
            //};

            //obtjeto a json
            //var data = JsonSerializer.Serialize<Post>(post);
            //HttpContent content1 = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            //var httpResponse1 = await client.PostAsync(url, content1);

            //if (httpResponse1.IsSuccessStatusCode)
            //{

            //    var result = await httpResponse1.Content.ReadAsStringAsync();
            //    var postResult = JsonSerializer.Deserialize<Post>(result);
            //}


            //metodo para eliminar service
            //a la url se le puede agregar un 1. 
            //var httpResponse2 = await client.DeleteAsync(url);

            //if (httpResponse2.IsSuccessStatusCode)
            //{

            //    var result = await httpResponse2.Content.ReadAsStringAsync();
            //var postResult = JsonSerializer.Deserialize<Post>(result);
            //}


            //Generics 
            //var cerveza = new Cerveza()
            //{ Alcohol = 10, Cantidad = 100, Marca = "mexico", Nombre = "mm,m" };


            //Service.sendRequest<Cerveza> service = new Service.sendRequest<Cerveza>();
            //var CervezaRespuesta= await service.Send(cerveza);


            //var post = new Post()
            //{ body = "hola", title = "asas", userId = 212 };

            //Service.sendRequest<Post> service2 = new Service.sendRequest<Post>();
            //var CervezaRespuestaa = await service2.Send(post);


            //List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

            //var numero5 = numeros.Where(x => x == 7).FirstOrDefault();
            //Console.WriteLine(numero5);

            //var numerosOrdenados = numeros.OrderBy(x => x);

            //foreach (var item in numerosOrdenados)
            //{
            //    Console.WriteLine(item);
            //}

            //var total = numeros.Sum(d=>d);  
            //Console.WriteLine(total);


            //List<Cerveza> cervezas = new List<Cerveza>()
            //{
            //    new Cerveza(){Alcohol=12, Cantidad=12, Nombre="cheve", Marca="vadfasdf"},
            //    new Cerveza(){Alcohol=23, Cantidad=11, Nombre="cheve2", Marca="vadfasdf3"},
            //    new Cerveza(){Alcohol=234, Cantidad=12, Nombre="cheve", Marca="vadfasdf"},


            //};

            //var cervezasOrdenadas = from d in cervezas orderby d.Marca select d;

            //foreach (var item in cervezasOrdenadas)
            //{
            //    Console.WriteLine($"{item.Marca}");
            //}

            //var cervezasOrdening = cervezas.OrderBy(x => x.Marca);


            ////Linq mas detallado.
            ////Se utiliza para realizar consultas.

            //List<Bar> bares = new List<Bar>()
            //{
            //    new Bar ("el bar")
            //    {
            //        CervezaList = new List<Cerveza>()
            //        {
            //            new Cerveza(){Alcohol=12, Cantidad=12, Nombre="cheve", Marca="vadfasdf"},
            //            new Cerveza(){Alcohol=23, Cantidad=11, Nombre="cheve2", Marca="vadfasdf3"},
            //            new Cerveza(){Alcohol=234, Cantidad=12, Nombre="cheve", Marca="vadfasdf"},

            //        }
            //    },

            //    new Bar ("el bar2")
            //    {
            //        CervezaList = new List<Cerveza>()
            //        {
            //            new Cerveza(){Alcohol=12, Cantidad=12, Nombre="cheve3", Marca="vadfasdf"},
            //            new Cerveza(){Alcohol=23, Cantidad=11, Nombre="cheve4", Marca="vadfasdf3"},
            //            new Cerveza(){Alcohol=234, Cantidad=12, Nombre="chev5", Marca="vadfasdf"},

            //        }
            //    }
            //};


            //var bar = (from d in bares where d.CervezaList.Where(c => c.Nombre == "cheve3").Count() > 0 select d).ToList();


            //var bar2 = (from d in bares where d.CervezaList.Where(c => c.Nombre == "cheve3").Count() > 0
            //            select new BarData(d.Nombre)
            //{
            //    bebidas = (from c in d.CervezaList select new Bebida(c.Nombre, c.Cantidad).ToList()
            //}.ToList();
            //    try
            //    {
            //        var searcherBeer = new SearcherBeer();
            //        var cantidad = searcherBeer.GetCantidad("csdds");
            //    }
            //    catch (FieldAccessException ex)
            //    {
            //        Console.WriteLine(ex.Message);

            //    }
            //    catch (NotFoundBeerException ex){
            //        Console.WriteLine(ex.Message);

            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //    finally
            //    {
            //        Console.WriteLine("siempre se ejecuta");
            //    }
            //    //recibe un string y regresa un int
            //    Func<string, int> mostrar2 = Show;


            //    //Action no regresa nada
            //    Action<string, string> mostrar = Show;

            //    //delegados
            //    Mostrar mostrar3 = Show;
            //    HacerAlgo(mostrar);


            //}
            //public static void HacerAlgo(Action<string, string> funcionFinal)
            //{
            //    funcionFinal("Se envio desde otra funcion","dsadsd");

            //}

            //    public static int Show(string cad)
            //    {
            //        return cad.Count();
            //        //Console.WriteLine("hola"+ cad);
            //    }

            //public static void Show (string cad, string  cad2)
            //{
            //    Console.WriteLine("hola"+ cad);

            //}
            
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