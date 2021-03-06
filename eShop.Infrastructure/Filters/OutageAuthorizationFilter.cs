﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eShop.Infrastructure.Filters
{
    // This filter for turning off and on pages through
    // decorating thier actions with the class Attribute
    // [TypeFilter(typeof(OutageAuthorizationFilter))]
    public class OutageAuthorizationFilter : Attribute, IAuthorizationFilter
    {
        private IConfiguration _config;

        public OutageAuthorizationFilter(IConfiguration config)
        {
            _config = config;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var applicationSwitch = _config.GetSection("FeatureSwitches")
                .GetChildren().FirstOrDefault(x => x.Key == "Outage");

            if (!bool.Parse(applicationSwitch.Value))
            {
                context.Result = new ViewResult() { ViewName = "Outage" };
            }
        }
    }
}
