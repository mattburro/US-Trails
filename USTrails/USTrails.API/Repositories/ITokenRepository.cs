using Microsoft.AspNetCore.Identity;

namespace USTrails.API.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWT(IdentityUser user, List<string> roles);
    }
}
