using System;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApp.Services;
using WebApp.ViewModels;

namespace Web.API.Controllers
{
    [Authorize(Roles ="Admin")]
    public class StudentController : ApiController
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
        public IHttpActionResult Index()
        {
            var data = studentService.GetAll();
            return Ok(data);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var data = studentService.GetById(id);
            return Ok(data);
        }

        [HttpPost]
        public IHttpActionResult Create(StudentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if (studentService.Create(model))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPut]
        public IHttpActionResult Edit(StudentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var res = studentService.Edit(model);
            if (res.Item1)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var res = studentService.Delete(id);
            if (res.Item1)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}