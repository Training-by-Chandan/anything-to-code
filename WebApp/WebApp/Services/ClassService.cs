using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApp.Repository;

namespace WebApp.Services
{
    public class ClassService
    {
        private readonly ClassRepository classRepository;

        public ClassService()
        {
            this.classRepository = new ClassRepository();
        }

        public List<SelectListItem> GetClassesSeclect()
        {
            var data = classRepository.GetAll().Select(p => new SelectListItem
            {
                Text = p.Name,
                Value = p.Id.ToString()
            });
            return data.ToList();
        }
    }
}