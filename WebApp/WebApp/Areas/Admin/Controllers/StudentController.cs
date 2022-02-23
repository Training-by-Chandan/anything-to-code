using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Areas.Admin.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService studentService;
        private readonly ClassService classService;

        public StudentController()
        {
            this.studentService = new StudentService();
            this.classService = new ClassService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var data = studentService.GetAll();
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewData["ClassList"] = classService.GetClassesSeclect().AsEnumerable();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewData["ClassList"] = classService.GetClassesSeclect();
                return View(model);
            }
            if (studentService.Create(model))
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewData["ClassList"] = classService.GetClassesSeclect();
                return View(model);
            }
        }
    }
}