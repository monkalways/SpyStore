using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpyStore.DAL.Repos.Interfaces;
using SpyStore.Models.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpyStore.Service.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly IProductRepo _productRepo;

        public CategoryController(ICategoryRepo categoryRepo, IProductRepo productRepo)
        {
            _categoryRepo = categoryRepo;
            _productRepo = productRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_categoryRepo.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = _categoryRepo.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Json(item);
        }

        [HttpGet("{categoryId}/products")]
        public IEnumerable<ProductAndCategoryBase> GetProductsForCategory(int categoryId)
            => _productRepo.GetProductsForCategory(categoryId).ToList();
    }
}
