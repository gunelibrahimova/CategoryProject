using Microsoft.AspNetCore.Mvc;
using Services;
using Entities;

namespace Category.Controllers
{
    public class CategoryController : Controller
    {

        private readonly CategoryServices _categoryServices;

        public CategoryController(CategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public IActionResult Index()
        {
            var category = _categoryServices.GetAll();
            return View(category);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Categoryy category)
        {
            _categoryServices.Create(category);
            return RedirectToAction(nameof(Index)); 
        }



    }
}
