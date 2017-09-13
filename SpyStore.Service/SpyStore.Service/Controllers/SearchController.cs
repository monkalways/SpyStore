using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpyStore.DAL.Repos.Interfaces;
using SpyStore.Models.ViewModels;

namespace SpyStore.Service.Controllers
{
    [Route("api/[controller]")]
    public class SearchController : Controller
    {
        private readonly IProductRepo _repo;

        public SearchController(IProductRepo repo)
        {
            _repo = repo;
        }

        [HttpGet("{searchString}", Name = "SearchProducts")]
        public IEnumerable<ProductAndCategoryBase> Search(string searchString)
            => _repo.Search(searchString);
    }
}
