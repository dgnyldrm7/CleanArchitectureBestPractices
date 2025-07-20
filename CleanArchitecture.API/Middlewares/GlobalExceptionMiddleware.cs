namespace CleanArchitecture.API.Middlewares
{
    internal sealed class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public GlobalExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            //process the request and catch any exceptions

            await _next(context);
        }
    }
}
