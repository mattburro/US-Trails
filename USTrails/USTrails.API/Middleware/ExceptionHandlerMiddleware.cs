using System.Net;

namespace USTrails.API.Middleware
{
    public class ExceptionHandlerMiddleware
    {
        private readonly ILogger<ExceptionHandlerMiddleware> logger;
        private readonly RequestDelegate request;

        public ExceptionHandlerMiddleware(ILogger<ExceptionHandlerMiddleware> logger,
            RequestDelegate request)
        {
            this.logger = logger;
            this.request = request;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await request(httpContext);
            }
            catch (Exception ex)
            {
                var errorId = Guid.NewGuid();

                // Log this exception
                logger.LogError(ex, $"{errorId} : {ex.Message}");

                // Return custom error response
                httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                httpContext.Response.ContentType = "application/json";

                var error = new
                {
                    Id = errorId,
                    ErrorMessage = "Something went wrong. We are looking into it."
                };

                await httpContext.Response.WriteAsJsonAsync(error);
            }
        }
    }
}
