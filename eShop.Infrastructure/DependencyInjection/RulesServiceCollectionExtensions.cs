using eShop.Infrastructure.Rule;
using eShop.Infrastructure.Rule.GeneralRules;
using eShop.Infrastructure.Rule.Membership;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class RulesServiceCollectionExtensions
    {
        public static IServiceCollection AddPurchaseRules(this IServiceCollection services)
        {
            services.AddScoped<IRuleProcessor, RuleProcessor>();
            services.AddSingleton<IRule, RuleOne>();
            services.AddSingleton<IRule, RuleTwo>();
            services.AddScoped<IRule, MembershipRuleOneConfiguration>();
            services.AddScoped<IRule, MembershipRuleTwoConfiguration>();
            services.AddScoped<IRule, MembershipRuleThreeConfiguration>();

            services.TryAddSingleton<IMembershipRules>(sp => sp.GetRequiredService<IOptions<MembershipRules>>().Value);

            //Scrutor assembly scanning
            //services.Scan(scan => scan
            //    .FromAssemblyOf<IRule>()
            //        .AddClasses(classes => classes.AssignableTo<IRule>())
            //            .As<IRule>()
            //            .WithScopedLifetime()
            //        .AddClasses(classes => classes.AssignableTo<IRule>())
            //            .As<IRule>()
            //            .WithSingletonLifetime());

            //services.TryAddScoped<IRuleProcessor, RuleProcessor>();
            return services;
        }
    }
}
