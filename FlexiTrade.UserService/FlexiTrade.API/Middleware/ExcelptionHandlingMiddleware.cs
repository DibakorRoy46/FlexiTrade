

namespace FlexiTrade.API.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ExcelptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ExcelptionHandlingMiddleware(RequestDelegate next, ILogger logger)
        {
            _next = next;
            _logger = logger;
        }

        public Task Invoke(HttpContext httpContext)
        {
            try
            {
                return _next(httpContext);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Type: {type} Inner exception details: {Message}", ex.GetType().ToString(), ex.Message);
               
                if(ex.InnerException is not null)
                {
                   _logger.LogError(ex.InnerException, "Type: {type} Inner exception details: {Message}",ex.GetType().ToString(), ex.InnerException.Message);
                }

                httpContext.Response.StatusCode = 500; 
                httpContext.Response.ContentType = "application/json";
                // Optionally, you can return a custom error response
                var errorResponse = new {
                    message = ex.Message,
                    Type= ex.GetType().ToString()
                };
                return httpContext.Response.WriteAsJsonAsync(errorResponse);
            }

        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ExcelptionHandlingMiddlewareExtensions
    {
        public static IApplicationBuilder UseExcelptionHandlingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExcelptionHandlingMiddleware>();
        }
    }
}
