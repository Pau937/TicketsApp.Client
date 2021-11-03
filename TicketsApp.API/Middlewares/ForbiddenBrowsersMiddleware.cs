using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TicketsApp.API.Middlewares
{
    public class ForbiddenBrowsersMiddleware
    {
        public ForbiddenBrowsersMiddleware(RequestDelegate nextDelegate) => _nextDelegate = nextDelegate;
        
        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Headers["User-Agent"].Any(header => header.ToLower().Contains("edg")))
            {
                httpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
            }
            else
            {
                await _nextDelegate.Invoke(httpContext);
            }
        }

        private readonly RequestDelegate _nextDelegate;
    }
}
