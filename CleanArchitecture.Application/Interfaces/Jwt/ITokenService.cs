using CleanArchitecture.Application.JwtOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces.Jwt
{
    public interface ITokenService
    {
        TokenMessageResponse GenerateToken(string userName, IList<string> roles);
        GenerateAccessTokenResponse GenerateAccessToken(string userId, string userName, IList<string> roles);
        string GenerateRefreshToken();
    }
}
