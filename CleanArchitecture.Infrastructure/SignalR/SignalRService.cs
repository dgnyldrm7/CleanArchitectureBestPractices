namespace CleanArchitecture.Infrastructure.SignalR
{
    public class SignalRService<THub> : ISignalRTypeSafe where THub : Hub
    {
        private readonly IHubContext<THub> _hubContext;

        public SignalRService(IHubContext<THub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task SendMessageAsync(string user, string message)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}