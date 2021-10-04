using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Models;

namespace Assigment_1.Data
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users { get; set; }
        private string productsFile = "users.json";

        public InMemoryUserService()
        {
            if (!File.Exists(productsFile))
            {
                string productsAsJson = JsonSerializer.Serialize(users);
                File.WriteAllText(productsFile, productsAsJson);
            }
            else
            {
                string content = File.ReadAllText(productsFile);
                users = JsonSerializer.Deserialize<List<User>>(content);
            }
        }

        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}