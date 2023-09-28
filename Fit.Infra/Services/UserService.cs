using Fit.AppDomain.Interfaces;

namespace Fit.Infra.Services
{
    public class UserService : IUserService
    {
        public async Task<bool> Login(string username, string password)
        {
            return true;
        }
    }
}
