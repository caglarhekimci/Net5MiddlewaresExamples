namespace FiltersMiddlewares.Middlewares
{
    public class SampleExample
    {
        private readonly RequestDelegate _next;

        private readonly ILogger<SampleMiddleware> _logger;

        public SampleExample(RequestDelegate next, ILogger<SampleMiddleware> logger)

        {

            _next = next ?? throw new ArgumentNullException(nameof(next));

            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        }

        public async Task Invoke(HttpContext httpContext)
        {

            _logger.LogInformation("sırası 2 oldu mu");

            await _next(httpContext);

            _logger.LogInformation("çıkış yapıoz");

        }
        public async Task asdfasf(HttpContext httpContext)
        {

            _logger.LogInformation("sırası 2 oldu mu");

            await _next(httpContext);

            _logger.LogInformation("çıkış yapıoz");

        }
    }
}
