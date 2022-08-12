# Program.cs

Ejemplos basicos.

```csharp

namespace fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida bebida = new Bebida("coca", 100);
            bebida.Beberse(50);
            Console.WriteLine(bebida.Nombre);
            Console.WriteLine(bebida.Cantidad);


            Cerveza cerveza = new Cerveza(20);
            Console.WriteLine(cerveza.Nombre);
            cerveza.Beberse(12);
            Console.WriteLine(cerveza.Cantidad);

            int[] numeros = new int[2];
            int[] numeross = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(i);
            }

            foreach (var item in numeross)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");

            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            lista.Add(9);
            lista.Add(0);
            lista.Remove(2);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza(20) };
            cervezas.Add(new Cerveza(500));
            Cerveza cheve = new Cerveza(500, "cerveza artesanalk");
            cervezas.Add(cheve);

            foreach (var item in cervezas)
            {
                Console.WriteLine(item.Cantidad);
                Console.WriteLine(item.Nombre);
            }


            var bebidaAlcoholica = new vino(100);
            MostrarRecomendacion(bebidaAlcoholica);

            CervezaBD cervezaBD = new CervezaBD();
            var cervezas1 =  cervezaBD.Get();

            foreach (var ce in cervezas1)
            {
                Console.WriteLine(ce.Nombre);
            }
    

        }
            static void MostrarRecomendacion(IBebidaAlcoholica bebida)
            {
                bebida.MaxRecomendado();
            }


    }
}
```






# Ejemplos de peticiones a webService.

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


    //solicitudes http a un webService

    string url="https://jsonplaceholder.typicode.com/posts";

    HttpClientclient=new HttpClient();

    //metodo async

    var httpResponse = await  client.GetAsync(url);

    if (httpResponse.IsSuccessStatusCode)

    {

    var content = await httpResponse.Content.ReadAsStringAsync();

    List `<Post>` posts = JsonSerializer.Deserialize<List`<Post>`>(content);

    }

    //metodo post a un servicio.

    Post post = new Post()

    {

    userId=1,

    body="hola hola",

    title="hola bye",

    };

    //obtjeto a json

    var data = JsonSerializer.Serialize`<Post>`(post);

    HttpContentcontent1 = new StringContent(data, System.Text.Encoding.UTF8, "application/json");

    var httpResponse1 = await client.PostAsync(url, content1);

    if (httpResponse1.IsSuccessStatusCode)

    {

    var result = await httpResponse1.Content.ReadAsStringAsync();

    var postResult = JsonSerializer.Deserialize`<Post>`(result);

    }

    //metodo para eliminar service

    //a la url se le puede agregar un 1.

    var httpResponse2 = await client.DeleteAsync(url);

    if (httpResponse2.IsSuccessStatusCode)

    {

    var result = await httpResponse2.Content.ReadAsStringAsync();

    //var postResult = JsonSerializer.Deserialize`<Post>`(result);

    }

    }

    }

}
```
