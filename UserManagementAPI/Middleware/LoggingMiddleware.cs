using System.Text;

namespace UserManagementAPI.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            // Log request
            Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");

            // Continue pipeline
            await _next(context);

            // Log response
            Console.WriteLine($"Response: {context.Response.StatusCode}");
        }
    }
}