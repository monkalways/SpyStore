using SpyStore.MVC.Validations;
using SpyStore.MVC.ViewModels.Base;

namespace SpyStore.MVC.ViewModels
{
    public class AddToCartViewModel : CartViewModelBase
    {
        [MustNotBeGreaterThan(nameof(UnitsInStock)), MustBeGreaterThanZero]
        public int Quantity { get; set; }
    }
}
