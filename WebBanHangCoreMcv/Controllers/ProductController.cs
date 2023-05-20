using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHangCoreMcv.Models;

namespace WebBanHangCoreMcv.Controllers
{
    public class ProductController : Controller
    {
        private readonly DBContext _dbContext;

        public ProductController(DBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ByCategory(int categoryId)
        {
            var products = new List<Product>();
            var category = _dbContext.Categories.FirstOrDefault(x => x.CategoryId == categoryId);
            if(category.ParrentId == 0) {
                var categorys = _dbContext.Categories.Where(x => x.ParrentId == categoryId).Select(x => x.CategoryId).ToList();
                products = _dbContext.Products.Where(x => categorys.Contains(x.CategoryId)).ToList();
            }
            else
            {
                products = _dbContext.Products
                    .Where(p => p.CategoryId == categoryId)
                    .ToList();
            }
            ViewBag.CategoryName = category.Name;
            return View(products);
        }

        public IActionResult Detail(int productId)
        {
            var product = _dbContext.Products.Include(p => p.Category).FirstOrDefault(x => x.ProductId == productId);
            var products = new List<Product>();
            if (product.Category.ParrentId == 0)
            {
                var categorys = _dbContext.Categories.Where(x => x.ParrentId == product.Category.CategoryId).Select(x => x.CategoryId).ToList();
                products = _dbContext.Products.Where(x => categorys.Contains(x.CategoryId)).ToList();
            }
            else
            {
                products = _dbContext.Products
                    .Where(p => p.CategoryId == product.Category.CategoryId)
                    .ToList();
            }
            ViewBag.ProductRelated = products;
            return View(product);
        }
    }
}
