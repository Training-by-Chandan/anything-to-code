using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            var model = GenerateDashboardData();

            return View(model);
        }

        private DashboardViewModel GenerateDashboardData()
        {
            var data = new DashboardViewModel();
            data.Widgets.Add(new Widget() { WidgetType = "success", Icon = "copy", Title = "Sales", Numbers = 100 });
            data.Widgets.Add(new Widget() { WidgetType = "info", Icon = "edit", Title = "purchase", Numbers = 100 });
            var displayBox = new List<DisplayBoxViewModel>();
            displayBox.Add(new DisplayBoxViewModel() { BoxType = "danger", Icon = "copy", Body = "50% in 30 days", Numbers = "2,990", Progress = 50, Title = "Purchase" });
            displayBox.Add(new DisplayBoxViewModel() { BoxType = "success", Icon = "copy", Body = "80% in 30 days", Numbers = "23,990", Progress = 80, Title = "Sales" });

            data.DisplayBoxes = displayBox;
            return data;
        }
    }
}