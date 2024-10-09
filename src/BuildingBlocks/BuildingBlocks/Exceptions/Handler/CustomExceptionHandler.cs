using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace BuildingBlocks.Exceptions.Handler;
internal class CustomExceptionHandler : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext context, Exception exception, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
