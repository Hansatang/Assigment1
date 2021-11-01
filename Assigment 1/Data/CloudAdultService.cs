using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace Assigment_1.Data
{
    public class CloudAdultService : ICloudAdultInterface
    {
        private string uri = "https://localhost:5003";


        public async Task<IList<Adult>> GetAdultAsync()
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync(uri + "/adult");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception(@"Error : (responseMessage.Status), (responseMessage.ReasonPhrase");
            }

            string message = await responseMessage.Content.ReadAsStringAsync();
            List<Adult> result = JsonSerializer.Deserialize<List<Adult>>(message);
            return result;
        }

        public async Task AddAdultAsync(Adult adult)
        {
            Console.WriteLine(1);
            using (HttpClient client = new HttpClient())
            {
                string adultAsJson = JsonSerializer.Serialize(adult);
                HttpContent content = new StringContent(adultAsJson,
                    Encoding.UTF8,
                    "application/json");
                Console.WriteLine(2);
                HttpResponseMessage responseMessage = await client.PostAsync(uri + "/adult", content);
                Console.WriteLine(responseMessage.Content);

                if (!responseMessage.IsSuccessStatusCode)
                {
                    throw new Exception(@"Error : (responseMessage.Status), (responseMessage.ReasonPhrase");
                }
            }
        }

        public async Task RemoveAdultAsync(int adultId)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.DeleteAsync($"{uri}/adult/{adultId}");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception(@"Error : (responseMessage.Status), (responseMessage.ReasonPhrase");
            }
        }

        public async Task UpdateAsync(Adult adult)
        {
            using (HttpClient client = new HttpClient())
            {
                string adultAsJson = JsonSerializer.Serialize(adult);
                HttpContent content = new StringContent(adultAsJson,
                    Encoding.UTF8,
                    "application/json");
                HttpResponseMessage responseMessage = await client.PatchAsync($"{uri}/adult/{adult.Id}", content);
                if (!responseMessage.IsSuccessStatusCode)
                {
                    throw new Exception(@"Error : (responseMessage.Status), (responseMessage.ReasonPhrase");
                }
            }
        }
    }
}