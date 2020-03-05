using System.Threading.Tasks;
using DatingAppp.API.Models;

namespace DatingAppp.API.Data
{
    public interface IAuthRepository
    {
         // regisster login and if exist
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}