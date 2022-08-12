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
