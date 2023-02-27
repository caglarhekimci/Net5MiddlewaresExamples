namespace ExeptionMiddleware.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext)
        {

            try
            {
                await _next.Invoke(httpContext);
            }
            catch (Exception ex)
            {

                //Exception Handler
            }
        }
    }
}
