using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SpyStore.DAL.Repos.Interfaces;
using System.Linq;
using SpyStore.Models.ViewModels;

namespace SpyStore.Service.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepo _repo;

        public ProductController(IProductRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<ProductAndCategoryBase> Get()
            => _repo.GetAllWithCategoryName().ToList();

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = _repo.GetOneWithCategoryName(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpGet("featured")]
        public IEnumerable<ProductAndCategoryBase> GetFeatured()
            => _repo.GetFeaturedWithCategoryName().ToList();
    }
}