using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpyStore.DAL.Repos.Interfaces;
using SpyStore.Models.Entities;
using SpyStore.Models.ViewModels;

namespace SpyStore.Service.Controllers
{
    [Route("api/[controller]/{customerId}")]
    public class OrdersController : Controller
    {
        private readonly IOrderRepo _repo;

        public OrdersController(IOrderRepo repo)
        {
            _repo = repo;
        }

        public IActionResult GetOrderHistory(int customerId)
        {
            IEnumerable<Order> orderWithTotals = _repo.GetOrderHistory(customerId);
            return orderWithTotals == null ? (IActionResult) NotFound()
                : new ObjectResult(orderWithTotals);
        }

        [HttpGet("{orderId}", Name = "GetOrderDetails")]
        public IActionResult GetOrderForCustomer(int customerId, int orderId)
        {
            OrderWithDetailsAndProductInfo orderWithDetails = 
                _repo.GetOneWithDetails(customerId, orderId);
            return orderWithDetails == null ? (IActionResult) NotFound()
                : new ObjectResult(orderWithDetails);
        }

    }

}
