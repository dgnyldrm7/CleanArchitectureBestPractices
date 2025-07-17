namespace CleanArchitecture.API.Middlewares
{
    internal sealed class GlobalExceptionHandler : IExceptionHandler
    {
        private readonly ILogger<GlobalExceptionHandler> _logger;

        public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
        {
            _logger = logger;
        }

        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            _logger.LogError(exception, "An unhandled exception occurred: {Message}", exception.Message);

            var response = new
            {
                StatusCode = (int)HttpStatusCode.InternalServerError,
                Message = "Bir hata oluştu. Lütfen daha sonra tekrar deneyin."
            };

            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            httpContext.Response.ContentType = "application/json";

            var json = JsonSerializer.Serialize(response);

            await httpContext.Response.WriteAsync(json);

            return true;
        }
    }
}
