﻿using System;
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
        private readonly IStudentService studentService;
        private readonly IClassService classService;

        public StudentController(
            IStudentService studentService,
            IClassService classService
            )
        {
            this.studentService = studentService;
            this.classService = classService;
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

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = studentService.GetById(id);
            if (data.Item1 != 200)
            {
                ViewBag.ErrorMessage = data.Item1 == 404 ? "Student Not found" : data.Item1 == 500 ? "Server Error Occured. Contact your Administrator" : "Please contact your admin. We are investigating";
                return View("~/Areas/Admin/Views/Shared/Error.cshtml");
            }
            ViewData["ClassList"] = classService.GetClassesSeclect().AsEnumerable();
            return View(data.Item2);
        }

        [HttpPost]
        public ActionResult Edit(StudentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewData["ClassList"] = classService.GetClassesSeclect().AsEnumerable();
                return View(model);
            }
            else
            {
                var res = studentService.Edit(model);
                if (res.Item1)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("Error", res.Item2);
                    ViewData["ClassList"] = classService.GetClassesSeclect().AsEnumerable();
                    return View(model);
                }
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            ViewBag.StudentId = id;
            return View();
        }

        [HttpGet]
        public ActionResult DeleteConfirmed(int id)
        {
            var res = studentService.Delete(id);
            if (res.Item1)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorMessage = res.Item2;
                return View("~/Areas/Admin/Views/Shared/Error.cshtml");
            }
        }
    }
}