using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
        public IActionResult Index()
        {
            var values = categoryManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category c)
        {
            categoryManager.TInsert(c);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCategory (int id)
        {
            var values = categoryManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category c)
        {
            categoryManager.TUpdate(c);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int id)
        {
            var values = categoryManager.TGetById(id);
            categoryManager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
