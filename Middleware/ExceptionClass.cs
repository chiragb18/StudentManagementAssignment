namespace StudentManagementAssignment.Middleware
{
    public class ExceptionClass
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionClass> _logger;

        // constructor for the class exception class
        public ExceptionClass(RequestDelegate next, ILogger<ExceptionClass> logger)
        {
            _next = next;
            _logger = logger;
        }

        // if any error or exception is occur then here we solved the problem and show the msg to the user
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred.");
                context.Response.StatusCode = 500;
                context.Response.ContentType = "application/json";

                var result = new
                {
                    message = "Something went wrong",
                    error = ex.Message
                };

                await context.Response.WriteAsJsonAsync(result);
            }
        }
    }
}
