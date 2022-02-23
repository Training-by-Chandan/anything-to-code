using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;
using WebApp.Repository;
using WebApp.ViewModels;

namespace WebApp.Services
{
    public class StudentService
    {
        private StudentRepository studentRep = new StudentRepository();

        public List<StudentViewModel> GetAll()
        {
            var data = studentRep.GetAll().Select(p => new StudentViewModel
            {
                ClassId = p.ClassId,
                FirstName = p.FirstName,
                Id = p.Id,
                LastName = p.LastName,
                ClassName = p.Class != null ? p.Class.Name : ""
            }).ToList();
            return data;
        }

        public bool Create(StudentViewModel model)
        {
            try
            {
                var student = new Student()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    ClassId = model.ClassId,
                };
                var res = studentRep.Create(student);
                return res;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}