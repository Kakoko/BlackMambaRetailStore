using System.Threading.Tasks;
using BMRSDesktopUI.Models;

namespace BMRSDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}