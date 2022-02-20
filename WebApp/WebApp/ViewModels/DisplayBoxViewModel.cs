using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.ViewModels
{
    public class DisplayBoxViewModel
    {
        public string BoxType { get; set; }
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Numbers { get; set; }
        public int Progress { get; set; }
    }

    public class DashboardViewModel
    {
        public DashboardViewModel()
        {
            this.DisplayBoxes = new List<DisplayBoxViewModel>();
            this.Widgets = new List<Widget>();
        }
        public List<DisplayBoxViewModel> DisplayBoxes { get; set; }
       public List<Widget> Widgets { get; set; }
    }

    public class Widget
    {
        public string Icon { get; set; }
        public string WidgetType { get; set; }
        public string Title { get; set; }
        public double Numbers { get; set; }
    }
}