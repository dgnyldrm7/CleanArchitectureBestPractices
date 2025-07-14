using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces.Services
{
    public class ITokenService
    {
        ResultTokenMessage GenerateToken();
        string GenerateAccessToken();
        string GenerateRefreshToken();

    }
}
