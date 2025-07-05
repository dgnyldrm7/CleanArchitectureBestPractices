using CleanArchitecture.Application.Interfaces.Common;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace CleanArchitecture.Presentation.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public CurrentUserService(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public string? UserId
        {
            get
            {
                return _contextAccessor.HttpContext?.User?.Claims
                    .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            }
        }

        public string? UserName
        {
            get
            {
                return _contextAccessor.HttpContext?.User?.Claims
                    .FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
            }
        }
        public string? UserRole
        {
            get
            {
                return _contextAccessor.HttpContext?.User?.Claims
                    .FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
            }
        }
    }
}
