using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Assigment_1.Data
{
    public class CloudUserService : ICloudUserService
    {
        private string uri = "https://localhost:5003";
      

        public async Task<User> ValidateUser(string userName, string password)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync(uri + $"/users?userName={userName}&password={password}");
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception(@"Error : (responseMessage.Status), (responseMessage.ReasonPhrase");
            }
            string message = await responseMessage.Content.ReadAsStringAsync();
            User result = JsonSerializer.Deserialize<User>(message);
            if (result == null)
            {
                throw new Exception("User not found");
            }

            if (!result.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return result;
        }

        public async Task Save(User user)
        {
            using HttpClient client = new HttpClient();
            string userAsJson = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(userAsJson,
                Encoding.UTF8,
                "application/json");
            HttpResponseMessage responseMessage = await client.PostAsync(uri + "/users", content);
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception(@"Error : {responseMessage.Status}, {responseMessage.ReasonPhrase}");
            }
        }
    }
}