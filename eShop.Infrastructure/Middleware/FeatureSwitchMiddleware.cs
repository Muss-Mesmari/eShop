
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
            var endpoint = httpContext.GetEndpoint()?.Metadata.GetMetadata<RouteAttribute>();

            if (endpoint != null)
            {
                var featureSwitch = config.GetSection("FeatureSwitches")
                    .GetChildren().FirstOrDefault(x => x.Key == endpoint.Name);

                if (featureSwitch != null && !bool.Parse(featureSwitch.Value))
                {
                    httpContext.SetEndpoint(new Endpoint((context) =>
                    {
                        context.Response.StatusCode = StatusCodes.Status404NotFound;
                        return Task.CompletedTask;
                    },
                    EndpointMetadataCollection.Empty,
                    "Feature Not Found"));
                }
            }

            await _next(httpContext);
            //if (httpContext.Request.Path.Value.Contains("/admin"))
            //{
            //    var switches = config.GetSection("Features");
            //    var report = switches.GetChildren().Select(x => $"{x.Key} : {x.Value}");
            //    await httpContext.Response.WriteAsync(string.Join("\n", report));
            //}
            //else
            //{
            //    // Call the next delegate/middleware in the pipeline
            //    await _next(httpContext);
            //}                        
        }
    }
}
