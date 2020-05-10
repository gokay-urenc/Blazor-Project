using BlazorUI.Models;
using System.Threading.Tasks;

namespace BlazorUI.Services
{
    public interface IAuthService
    {
        Task Login(LoginModel loginModel);
        Task Logout();
    }
}