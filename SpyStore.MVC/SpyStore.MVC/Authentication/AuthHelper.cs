using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpyStore.Models.Entities;
using SpyStore.MVC.WebServiceAccess;

namespace SpyStore.MVC.Authentication
{
    public class AuthHelper : IAuthHelper
    {
        private readonly IWebApiCalls _webApiCalls;
        public AuthHelper(IWebApiCalls webApiCalls)
        {
            _webApiCalls = webApiCalls;
        }
        public Customer GetCustomerInfo()
        {
            return _webApiCalls.GetCustomersAsync().Result.FirstOrDefault();
        }
    }
}
