using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpyStore.MVC.Configuration
{
    public interface IWebServiceLocator
    {
        string ServiceAddress { get; }
    }
}
