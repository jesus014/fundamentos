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

        //uso de clases genericas
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
