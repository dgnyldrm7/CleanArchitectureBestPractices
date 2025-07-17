namespace CleanArchitecture.WebApi.ExceptionHandlers
{
    public class BannedColorExceptionHandler : IExceptionHandler
    {
        private readonly BannedColorException bannedColorException;
        public BannedColorExceptionHandler(BannedColorException bannedColorException)
        {
            this.bannedColorException = bannedColorException;
        }

        //process burada yer alacaktır!
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            httpContext.Response.StatusCode = 500;

            await httpContext.Response.WriteAsJsonAsync(new
            {
                Title = "ServerError",
                StatusCode = 500,
                Message = exception.Message,
                BannedColor = bannedColorException.Color,
            }, cancellationToken);

            return true;
        }
    }
}