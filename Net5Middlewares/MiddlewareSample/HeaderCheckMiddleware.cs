namespace MiddlewareSample
{
    public class HeaderCheckMiddleware
    {
        private readonly RequestDelegate _next;
        public HeaderCheckMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var keyClient = httpContext.Request.Headers.Keys.Contains("Client-Key");
            var keyDevice = httpContext.Request.Headers.Keys.Contains("Device-Id");

            if (!keyClient || !keyDevice)
            {
                httpContext.Response.StatusCode = 400;
                await httpContext.Response.WriteAsync("Missing requeired keys !");
                return;
            }
            else
            {
                //todo
            }
            await _next.Invoke(httpContext);
        }




    }
}
