namespace CleanArchitecture.Application.Interfaces
{
    public interface ISignalRTypeSafe
    {
        Task SendMessageAsync(string user, string message);
    }
}