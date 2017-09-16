using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpyStore.Models.Entities;

namespace SpyStore.MVC.Authentication
{
    public interface IAuthHelper
    {
        Customer GetCustomerInfo();
    }
}
