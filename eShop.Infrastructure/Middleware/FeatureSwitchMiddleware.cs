using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Infrastructure.Middleware
{
    public  class FeatureSwitchMiddleware
    {
        private readonly RequestDelegate _next;

        public FeatureSwitchMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext, IConfiguration config)
        {
            if (httpContext.Request.Path.Value.Contains("/admin"))
            {
                var switches = config.GetSection("Features");
                var report = switches.GetChildren().Select(x => $"{x.Key} : {x.Value}");
                await httpContext.Response.WriteAsync(string.Join("\n", report));
            }
            else
            {
                // Call the next delegate/middleware in the pipeline
                await _next(httpContext);
            }                        
        }
    }
}
