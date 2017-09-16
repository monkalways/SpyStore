using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpyStore.Models.Entities;
using SpyStore.Models.ViewModels;

namespace SpyStore.MVC.WebServiceAccess
{
    public interface IWebApiCalls
    {
        Task<IList<Category>> GetCategoriesAsync();
        Task<Category> GetCategoryAsync(int id);
        Task<IList<ProductAndCategoryBase>> GetProductsForACategoryAsync(int categoryId);
        Task<IList<Customer>> GetCustomersAsync();
        Task<Customer> GetCustomerAsync(int id);
        Task<IList<Order>> GetOrdersAsync(int customerId);
        Task<OrderWithDetailsAndProductInfo> GetOrderDetailsAsync(int customerId, int orderId);
        Task<ProductAndCategoryBase> GetOneProductAsync(int productId);
        Task<IList<ProductAndCategoryBase>> GetFeaturedProductsAsync();
        Task<IList<ProductAndCategoryBase>> SearchAsync(string searchTerm);
        Task<IList<CartRecordWithProductInfo>> GetCartAsync(int customerId);
        Task<CartRecordWithProductInfo> GetCartRecordAsync(int customerId, int productId);
        Task<string> AddToCartAsync(int customerId, int productId, int quantity);
        Task<string> UpdateCartItemAsync(ShoppingCartRecord item);
        Task RemoveCartItemAsync(int customerId, int shoppingCartRecordId, byte[] timeStamp);
        Task<int> PurchaseCartAsync(Customer customer);
    }
}
