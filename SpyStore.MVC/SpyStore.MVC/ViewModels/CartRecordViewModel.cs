using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpyStore.MVC.ViewModels.Base;

namespace SpyStore.MVC.ViewModels
{
    public class CartRecordViewModel : CartViewModelBase
    {
        public int Quantity { get; set; }
    }
}
