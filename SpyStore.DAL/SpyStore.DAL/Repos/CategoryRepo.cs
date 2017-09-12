using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SpyStore.DAL.EF;
using SpyStore.DAL.Repos.Base;
using SpyStore.DAL.Repos.Interfaces;
using SpyStore.Models.Entities;

namespace SpyStore.DAL.Repos
{
    public class CategoryRepo : RepoBase<Category>, ICategoryRepo
    {
        public CategoryRepo()
        {
        }

        public CategoryRepo(DbContextOptions<StoreContext> options) : base(options)
        {   
        }

        public override IEnumerable<Category> GetAll() => Table.OrderBy(x => x.CategoryName);

        public override IEnumerable<Category> GetRange(int skip, int take) => GetRange(
            Table.OrderBy(x => x.CategoryName), skip, take);

        public IEnumerable<Category> GetAllWithProducts() => Table.Include(x => x.Products).ToList();

        public Category GetOneWithProducts(int? id) => Table.Include(x => x.Products).SingleOrDefault(x => x.Id == id);
    }
}
