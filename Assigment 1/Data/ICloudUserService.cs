using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Assigment_1.Data
{
    public interface ICloudUserService
    {
        
        Task<User>  ValidateUser(string userName, string Password);
        Task  Save(User user);
        
    }
}