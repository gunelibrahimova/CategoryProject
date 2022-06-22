using System.Diagnostics;
using Category.Models;
using Category.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Category.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CategoryServices _categoryServices;
        private readonly SubCategoryServices _subCategoryServices;

        public HomeController(ILogger<HomeController> logger, CategoryServices categoryServices, SubCategoryServices subCategoryServices)
        {
            _logger = logger;
            _categoryServices = categoryServices;
            _subCategoryServices = subCategoryServices;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new()
            {
                Categoryys = _categoryServices.GetAll(),
                SubCategories = _subCategoryServices.GetAll(),
            };
            return View(homeVM);
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