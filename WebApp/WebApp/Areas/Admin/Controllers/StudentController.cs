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
        private readonly StudentService studentService = new StudentService();

        [HttpGet]
        public ActionResult Index()
        {
            var data = studentService.GetAll();
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentViewModel model)
        {
            if (studentService.Create(model))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}