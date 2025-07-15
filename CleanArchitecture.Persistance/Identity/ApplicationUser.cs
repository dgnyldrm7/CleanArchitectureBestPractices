using CleanArchitecture.Domain.Entities.Users;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Persistance.Identity
{
    public class ApplicationUser : IdentityUser, IUser
    {
        public string FullName { get; set; } = default!;
    }
}