using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApiClient.ClientApi
{
     /*
     * For Tawqir's reference only --
      * (1) Create new client object
      * (2) Ask for JSON as the return format
      * (3) Await a response from the the URI
      * (4) Check if response has been successful
      * (5) Return content Task<string>
     */
    public class CoffeeClient
    {
        public async Task<string> GetCoffeeFromApiById(int id)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage reponse;
            try
            {
                reponse = await client.GetAsync("http://localhost:45553/api/Home/"+id);

            }
            catch (Exception)
            {
                return "Go run the API in a different VS instance first.";
            }
            if (reponse.IsSuccessStatusCode)
                return await reponse.Content.ReadAsStringAsync();
            return "Request Failed";
        }
    }
}
