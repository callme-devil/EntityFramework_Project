using EntityFramework_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
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
            //var item = new Product("Dota 2", 800);
            ////_context.Products.Add(item);
            //_context.Add(item);
            //_context.SaveChanges();

            //var product = _context.Products.ToList();// Select all
            //var product = _context.Products.FirstOrDefault(); //first record of database
            //var product = _context.Products.FirstOrDefault(x => x.Id == 1); //first record of sequence
            //var product = _context.Products.FirstOrDefault(x => x.Id == 32255325); //return null
            //var product = _context.Products.First(x => x.Id == 121324); //exception

            //var product = _context.Products.SingleOrDefault(x => x.Id == 1);//throw exception if more than 1 item founded && can return null if not founded
            //var product = _context.Products.Single(x => x.Id == 2);//throw exception if more than 1 && cant return null

            //var product = _context.Products.Find(2); //Get primary key (Id) if item exists in ram show that else Use Database query (high performance)
            var product = _context.Products.Where(x => x.UnitPrice < 1000 && x.IsDeleted == false).ToList();

            //var maxUP = _context.Products.Max(x => x.UnitPrice);
            //var minUP = _context.Products.Min(x => x.UnitPrice);
            //var PCount = _context.Products.Count();
            //var PCount1 = _context.Products.Count(x=>x.UnitPrice <1000);
            //var exist = _context.Products.Any(x => x.Name == "Apex");

            //Physical Delete
            //var item = _context.Products.FirstOrDefault(x => x.Id == 3);
            //if (item != null)
            //{
            //    _context.Products.Remove(item);
            //    _context.SaveChanges();
            //}


            //Logical Remove
            //var item = _context.Products.FirstOrDefault(x => x.Id == 2);
            //if (item != null)
            //{
            //    item.IsDeleted = true;
            //    _context.SaveChanges();
            //}



            return View(product);
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
