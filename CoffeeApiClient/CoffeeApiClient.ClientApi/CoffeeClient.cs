using System;
using System.Net.Http;
using System.Net.Http.Headers;
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
      * (6) In main program, ask for the Tasks result and do stuff with it
     */
    public class CoffeeClient
    {
        public async Task<string> GetCoffeeById(int id)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage reponse;
            try
            {
                reponse = await client.GetAsync("http://localhost:45553/api/Home/"+id);
            }
            catch (Exception exception)
            {
                return String.Format("Go run the API in a different VS instance first. Exception info: {0}", exception.Message);
            }

            if (reponse.IsSuccessStatusCode)
                return await reponse.Content.ReadAsStringAsync();
            return "Request Failed";
        }

        public async Task<string> GetAllCoffees()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage reponse;
            try
            {
                reponse = await client.GetAsync("http://localhost:45553/api/Home/");

            }
            catch (Exception exception)
            {
                return String.Format("Go run the API in a different VS instance first. Exception info: {0}", exception.Message);
            }
            if (reponse.IsSuccessStatusCode)
                return await reponse.Content.ReadAsStringAsync();
            return "Request Failed";
        }
    }
}
