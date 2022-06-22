using Entities;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Category.Controllers
{
    public class SubCategoryController : Controller
    {
        private readonly SubCategoryServices _subCategoryServices;
        private readonly CategoryServices _categoryServices;

        public SubCategoryController(SubCategoryServices subCategoryServices, CategoryServices categoryServices)
        {
            _subCategoryServices = subCategoryServices;
            _categoryServices = categoryServices;
        }

        public IActionResult Index()
        {
            var subCategory = _subCategoryServices.GetAll();
            return View(subCategory);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = _categoryServices.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(SubCategory subCategory)
        {
            _subCategoryServices.Create(subCategory);
            return RedirectToAction(nameof(Index));
        }
    }
}
