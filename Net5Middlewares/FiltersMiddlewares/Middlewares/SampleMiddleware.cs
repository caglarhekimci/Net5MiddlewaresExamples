namespace FiltersMiddlewares.Middlewares
{
    public class SampleMiddleware
    {
        private readonly RequestDelegate _next;

        private readonly ILogger<SampleMiddleware> _logger;

        public SampleMiddleware(RequestDelegate next, ILogger<SampleMiddleware> logger)

        {

            _next = next ?? throw new ArgumentNullException(nameof(next));

            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        }

        public async Task Invoke(HttpContext httpContext) 
        {

            _logger.LogInformation("Before Sample Middleware");

            await _next(httpContext);

            _logger.LogInformation("After Sample Middleware");

        }
    }
}
