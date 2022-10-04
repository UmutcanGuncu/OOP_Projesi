using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Controllers
{
    public class JobController : Controller
    {
        JobManager jobManager = new JobManager(new EFJobDal());
        public IActionResult Index()
        {
            var values = jobManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddJob(Job p)
        {

            jobManager.TInsert(p);
            return RedirectToAction("Index");

        }

        public IActionResult DeleteJob(int id)
        {
            var values = jobManager.TGetById(id);
            jobManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateJob(int id)
        {
            var values = jobManager.TGetById(id);

            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateJob(Job p)
        {

            jobManager.TUpdate(p);
            return RedirectToAction("Index");
        }

    }
}
