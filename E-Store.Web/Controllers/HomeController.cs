using E_Store.Domain.Models;
using E_Store.Repository.Infrastructure.Interface;
using Microsoft.AspNetCore.Mvc;

namespace E_Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            Product product = new Product()
            {
                Name = "item1",
                Description = "New"
            };

            unitOfWork.ProductRepository.Add(product);
            unitOfWork.save();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}