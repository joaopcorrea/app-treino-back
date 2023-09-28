namespace Fit.AppDomain.Interfaces
{
    public interface IUserService
    {
        public Task<bool> Login(string username, string password);
    }
}
