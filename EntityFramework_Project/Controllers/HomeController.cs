using EntityFramework_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using EntityFramework_Project.Context;

namespace EntityFramework_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ShopContext _context;

        public HomeController(ShopContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var item = new Product("Csgo" , 1000);
            //_context.Products.Add(item);
            _context.Add(item);
            _context.SaveChanges();

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
