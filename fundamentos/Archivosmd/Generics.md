
# Modelo cerveza.


```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos.Models
{
    internal class Cerveza : Bebida, IBebidaAlcoholica, IRequest
    {
        //Se tiene herencia de la classe bebida y de la interfaz IBebida alcoholica
        public int Alcohol { get; set; }

        public string Marca { get; set; }

        public int id { get; set; }

        //el ctor es un metodo
        public Cerveza(int Cantidad, string Nombre="Cervezas") : base(Nombre, Cantidad)
        {

        }
        public Cerveza():base(null,0)
        {

        }
      

        public void MaxRecomendado()
        {

            Console.WriteLine("el maximo es 50");
        }
    }
}

```


# Creacion de interface.


```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentos
{
    public interface IRequest
    {
    }
}

```



# Uso de generics.


```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace fundamentos.Service
{
    public class sendRequest<T> where T : IRequest
    {
        //atributo privado.
        private HttpClient _httpClient = new HttpClient();


        public async Task<T> Send(T model)
        {
        
            string url = "https://jsonplaceholder.typicode.com/posts";

            var data = JsonSerializer.Serialize<T>(model);
            HttpContent content1 = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse1 = await _httpClient.PostAsync(url, content1);

            if (httpResponse1.IsSuccessStatusCode)
            {

                var result = await httpResponse1.Content.ReadAsStringAsync();
                var postResult = JsonSerializer.Deserialize<T>(result);

                return postResult;
            }
            return default(T);


        }


    }
}

```

# program.cs

llamada de generics.

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
            //Generics 
            var cerveza = new Cerveza()
            { Alcohol = 10, Cantidad = 100, Marca = "mexico", Nombre = "mm,m" };


            Service.sendRequest<Cerveza> service = new Service.sendRequest<Cerveza>();
            var CervezaRespuesta= await service.Send(cerveza);


            var post = new Post()
            { body = "hola", title = "asas", userId = 212 };
  
            Service.sendRequest<Post> service2 = new Service.sendRequest<Post>();
            var CervezaRespuestaa = await service2.Send(post);




        }

    }
}
```
