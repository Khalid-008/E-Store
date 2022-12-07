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
            unitOfWork.ProductRepository.delete(1);
            unitOfWork.save();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}