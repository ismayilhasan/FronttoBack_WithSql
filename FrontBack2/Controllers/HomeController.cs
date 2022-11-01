using FrontBack2.DAL;
using FrontBack2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace FrontBack2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var products = _dbContext.Products.ToList();
            var categoires = _dbContext.Categories.ToList();
            var ViewModel = new HomeViewModel()
            {
                Products = products,
                Categories = categoires
            };


            return View(ViewModel);
        }

    }
      
}

