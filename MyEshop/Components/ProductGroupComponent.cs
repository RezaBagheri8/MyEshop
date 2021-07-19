using Microsoft.AspNetCore.Mvc;
using MyEshop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyEshop.Models;

namespace MyEshop.Components
{
    public class ProductGroupComponent : ViewComponent
    {
        private MyEshopContext _context;

        public ProductGroupComponent(MyEshopContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Categories = _context.Categories
                .Select(r => new ShowProductCountViewModel()
                {
                    CategoryId = r.Id,
                    CategoryName = r.Name,
                    ProductCount = _context.CategoryToProducts.Count(p => p.CategoryId == r.Id)
                }).ToList();

            return View("/Views/Components/ProductGroupCompnents.cshtml", Categories);
        }
    }
}
