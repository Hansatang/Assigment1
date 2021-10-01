using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Assigment_1.Data
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new[]
            {
                new User
                {
                    Domain = "via.dk", Password = "123", Role = "Teacher",
                    SecurityLevel = 4, UserName = "123"
                },
                new User
                {
                    Domain = "hotmail.com", Password = "qwe", Role = "Student",
                    SecurityLevel = 2, UserName = "qwe"
                }
            }.ToList();
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