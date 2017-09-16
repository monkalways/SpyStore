using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpyStore.MVC.ViewModels.Base
{
    public class AddToCartViewModel : CartViewModelBase
    {
        public int Quantity { get; set; }
    }
}
