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

        public CloudUserService() {
        
            client = new HttpClient();
        }
        

        public async Task<User> ValidateUser(string userName, string password)
        {
            
            Console.WriteLine("hi");
            Task<string> stringAsync = client.GetStringAsync(uri+$"/users?userName={userName}&password={password}");
            string message = await stringAsync;
            Console.WriteLine(message);
            User result = JsonSerializer.Deserialize<User>(message);
            Console.WriteLine(1+" "+result.UserName);
            Console.WriteLine(2+" "+result.Password);
            Console.WriteLine(3+" "+result.Domain);
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
            Console.WriteLine(user.UserName);
            string todoAsJson = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(todoAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync(uri+"/users", content);

        }
    }
}