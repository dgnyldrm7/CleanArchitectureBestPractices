namespace CleanArchitecture.Domain.Entities.Users
{
    public class User : IUser
    {
        public string FullName { get; set; } = default!;
    }
}