namespace MiddlewareSample
{
    public static class MiddlewareExtension
    {
        public static IApplicationBuilder UseHeaderCheckMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HeaderCheckMiddleware>();
        }
     
    }
}
