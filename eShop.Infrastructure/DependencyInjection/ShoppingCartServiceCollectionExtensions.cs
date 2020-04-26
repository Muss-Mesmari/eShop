using eShop.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Infrastructure.DependencyInjection
{
    public static class ShoppingCartServiceCollectionExtensions
    {
        public static IServiceCollection AddShoppingCart(this IServiceCollection services)
        {
            services.AddScoped<ShoppingCartService>(sp => ShoppingCartService.GetCart(sp));
            return services;
        }
    }
}
