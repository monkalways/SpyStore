using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SpyStore.MVC.Authentication;

namespace SpyStore.MVC.Filters
{
    public class AuthActionFilter : IActionFilter
    {
        private IAuthHelper _authHelper;
        public AuthActionFilter(IAuthHelper authHelper)
        {
            _authHelper = authHelper;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var viewBag = ((Controller)context.Controller).ViewBag;
            var customer = _authHelper.GetCustomerInfo();
            viewBag.CustomerId = customer.Id;
            viewBag.CustomerName = customer.FullName;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // do something after the action executes
        }
    }
}
