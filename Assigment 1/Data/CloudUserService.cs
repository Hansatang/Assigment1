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
        private readonly HttpClient client;

        public CloudUserService()
        {
            client = new HttpClient();
        }


        public async Task<User> ValidateUser(string userName, string password)
        {
            Task<string> stringAsync = client.GetStringAsync(uri + $"/users?userName={userName}&password={password}");
            string message = await stringAsync;
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
            string userAsJson = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(userAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync(uri + "/users", content);
        }
    }
}