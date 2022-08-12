// See https://aka.ms/new-console-template for more information
using fundamentos.Models;
using System.Text.Json;

namespace fundamentos
{
    class Program
    {
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