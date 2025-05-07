using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Sales.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anonymous = new ClaimsIdentity();
            var juanUser = new ClaimsIdentity(new List<Claim>
            {
                new Claim("FirstName", "Juan"),
                new Claim("LastName", "Perez"),
                new Claim(ClaimTypes.Name, "jperez@yopmail.com"),
                new Claim(ClaimTypes.Role, "Admin")
            }, 
            authenticationType: "test");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(juanUser)));
        }
    }
}
