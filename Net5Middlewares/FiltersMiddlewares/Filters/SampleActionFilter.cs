using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersMiddlewares.Filters
{
    public class SampleActionFilter : IActionFilter
    {
        private readonly ILogger<SampleActionFilter> _logger;

        public SampleActionFilter(ILogger<SampleActionFilter> logger)

        {

            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation($"From OnActionExecuting method of {nameof(SampleActionFilter)}");
        }
        public void OnActionExecuted(ActionExecutedContext context) 
        { 
            _logger.LogInformation($"From OnActionExecuted method of {nameof(SampleActionFilter)}");
        }

    
    }
}
