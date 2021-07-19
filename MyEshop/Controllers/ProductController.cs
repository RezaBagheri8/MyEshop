using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyEshop.Data;

namespace MyEshop.Controllers
{
    public class ProductController : Controller
    {
        private MyEshopContext _context;

        public ProductController(MyEshopContext context)
        {
            _context = context;
        }

        [Route("Products/{id}/{name}")]
        public IActionResult ShowProductByCategoryId(int id, string name)
        {
            var products = _context.CategoryToProducts
                .Where(c => c.CategoryId == id)
                .Include(p => p.Product)
                .Select(f => f.Product)
                .ToList();

            ViewData["CategoryName"] = name;

            return View(products);
        }
    }
}
