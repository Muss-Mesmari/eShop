using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace eShop.Infrastructure.Filters
{
    // This filter for redircting URLs throught targeting actions
    // by decorating thier actions with the class Attribute

    //  [MobileRedirectActionFilter(Action ="ActionName", Controller ="Home")]
    //  To target the action name that we want to be generated for mobile phones
    public class MobileRedirectActionFilter : Attribute, IActionFilter
    {
        public string Controller { get; set; }
        public string Action { get; set; }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Request.Headers.Keys.Contains("x-mobile"))
            {
                context.Result = new RedirectToActionResult(Action, Controller, null);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("Action Executed");
        }
    }
}
