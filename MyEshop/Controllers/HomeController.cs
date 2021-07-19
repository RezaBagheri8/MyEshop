using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyEshop.Data;
using MyEshop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyEshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyEshopContext _context;
        private static Cart _cart = new Cart();

        public HomeController(ILogger<HomeController> logger, MyEshopContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        public IActionResult Detail(int id)
        {
            var product = _context.Products.Include(r => r.Item).SingleOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            var categories = _context.Products
                .Where(r => r.Id == id)
                .SelectMany(p => p.CategoryToProducts)
                .Select(t => t.Category)
                .ToList();

            var myModel = new DetailsViewModel()
            {
                Product = product,
                Categories = categories
            };

            return View(myModel);
        }

        public IActionResult AddToCart(int itemId)
        {
            var product = _context.Products.Include(r => r.Item).SingleOrDefault(p => p.ItemId == itemId);
            if (product != null)
            {
                var cartItem = new CartItem()
                {
                    Item = product.Item,
                    Quantity = 1
                };
                _cart.addItem(cartItem);
            }
            return RedirectToAction("ShowCart");
        }

        public IActionResult ShowCart()
        {
            var cartVM = new CartViewModel()
            {
                CartItems = _cart.CartItems,
                OrderTotal = _cart.CartItems.Sum(r => r.getTotalPrice())
            };
            return View(cartVM);
        }

        public IActionResult RemoveCart(int itemId)
        {
            _cart.removeItem(itemId);
            return RedirectToAction("ShowCart");
        }

        [Route("ContactUs")]
        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
