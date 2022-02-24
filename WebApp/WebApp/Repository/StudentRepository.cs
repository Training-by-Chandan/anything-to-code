using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.Repository
{
    public class StudentRepository
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //todo explain iqueryable
        public IQueryable<Student> GetAll()
        {
            return db.Students;
        }

        public bool Create(Student model)
        {
            try
            {
                db.Students.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Student GetById(int id)
        {
            return db.Students.Find(id);
        }

        public (bool, string) Edit(Student model)
        {
            try
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return (true, "Successfully updated");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}