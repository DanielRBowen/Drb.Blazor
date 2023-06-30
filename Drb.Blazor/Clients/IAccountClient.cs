using Drb.Blazor.Dtos;

namespace Drb.Blazor.Clients
{
    public interface IAccountClient
    {
        public string ServiceUrl { get; }
        public string UserName { get; }
        public string TenantName { get; }
        Task<bool> Login(UserLoginDto user);
        Task<bool> Logout();
        Task<bool> SetAccount();
        Task GetAuthenticationState();
    }
}