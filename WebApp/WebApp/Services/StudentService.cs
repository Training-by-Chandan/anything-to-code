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

        public (int, StudentViewModel) GetById(int id)
        {
            try
            {
                var res = studentRep.GetById(id);
                if (res == null) return (404, null);
                else
                {
                    return (200, new StudentViewModel()
                    {
                        ClassId = res.ClassId,
                        ClassName = res.Class != null ? res.Class.Name : "",
                        FirstName = res.FirstName,
                        LastName = res.LastName,
                        Id = res.Id
                    });
                }
            }
            catch (Exception ex)
            {
                return (500, null);
            }
        }

        public (bool, string) Edit(StudentViewModel model)
        {
            try
            {
                var existing = studentRep.GetById(model.Id);
                if (existing == null) return (false, "Not found");
                else
                {
                    existing.FirstName = model.FirstName;
                    existing.LastName = model.LastName;
                    existing.ClassId = model.ClassId;
                    existing.Id = existing.Id;
                    var res = studentRep.Edit(existing);
                    return res;
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}