using Microsoft.AspNetCore.Builder;
using Net5Middlewares.Logging;

namespace Net5Middlewares
{
    public static class LoggingMiddlewareExtension
    {
        public static IApplicationBuilder UseLogging(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }
    }
}
