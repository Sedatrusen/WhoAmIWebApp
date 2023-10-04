using WhoAmIWebApp.Models;

namespace WhoAmIWebApp.Services.Interfaces
{
    public interface IMyUserService
    {
        Task<MyUser> Create(MyUser user);
    }
}
