using CleanArchitecture.Domain.Entities.Users;

namespace CleanArchitecture.Persistance.Identity
{
    public class ApplicationUser : IdentityUser, IUser
    {
        public string FullName { get; set; } = default!;
    }
}