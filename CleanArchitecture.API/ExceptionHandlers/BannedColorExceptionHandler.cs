using CleanArchitecture.Application.Exceptions;
using System;

namespace CleanArchitecture.WebApi.ExceptionHandlers
{
    public class BannedColorExceptionHandler : IExceptionHandler<BannedColorException>
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext context, BannedColorException exception, CancellationToken cancellationToken)
        {
            context.Response.StatusCode = StatusCodes.Status409Conflict;
            await context.Response.WriteAsJsonAsync(new
            {
                StatusCode = 409,
                Error = exception.Message
            }, cancellationToken);

            return true;
        }
    }
}
