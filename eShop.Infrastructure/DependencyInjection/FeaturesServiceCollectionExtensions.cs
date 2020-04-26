using eShop.Infrastructure.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace eShop.Infrastructure.DependencyInjection
{
    public static class FeaturesServiceCollectionExtensions
    {
        public static IServiceCollection AddConfiguration(this IServiceCollection services, IConfiguration config)
        {
            services.Configure<FeaturesConfiguration>(config.GetSection("Features"));
            return services;
        }
    }
}
