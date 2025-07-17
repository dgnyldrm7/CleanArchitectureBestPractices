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
            // Middleware'in işlevselliği burada gerçekleştirilir
            // Örneğin, gelen istek üzerinde bazı işlemler yapabiliriz

            // Sonraki middleware'e geçmeden önce bir işlem yap
            await context.Response.WriteAsync("Security Middleware öncesi işlem\n");

            // Sonraki middleware bileşenine geç
            await _next(context);

            // Sonraki middleware'den sonra bir işlem yap
            await context.Response.WriteAsync("Security Middleware sonrası işlem\n");
        }
    }
}
