namespace CleanArchitecture.WebApi.ExceptionHandlers
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext context, Exception exception, CancellationToken cancellationToken)
        {
            context.Response.StatusCode = 500;

            await context.Response.WriteAsJsonAsync(new
            {
                Title = "Error",
                Message = exception.Message,
                StatusCode = 500
            }, cancellationToken);

            return true;
        }
    }

}