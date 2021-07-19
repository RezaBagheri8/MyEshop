using Microsoft.AspNetCore.Mvc;
using MyEshop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return View("/Views/Components/ProductGroupCompnents.cshtml",_context.Categories.ToList());
        }
    }
}
