using System.Threading.Tasks;
using Api.Models;

namespace Api.Data
{
    public interface IAuthRepository
    {
         Task<User> Login(string username, string password);
         Task<User> Register(User user, string password);
         Task<bool> UserExists(string username);
    }
}