using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApp.Repository;

namespace WebApp.Services
{
    public interface IClassService
    {
        List<SelectListItem> GetClassesSeclect();
    }

    public class ClassService : IClassService
    {
        private readonly IClassRepository classRepository;

        public ClassService(
            IClassRepository classRepository
            )
        {
            this.classRepository = classRepository;
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