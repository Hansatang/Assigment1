using Models;

namespace Assigment_1.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string Password);
    }
}