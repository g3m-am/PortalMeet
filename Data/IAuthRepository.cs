using System.Threading.Tasks;
using PortalMeet.API.Models;

namespace PortalMeet.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Login(string username, string password);
         Task<User> Register(User user, string password);
         Task<bool> UserExists(string username);
    }
}