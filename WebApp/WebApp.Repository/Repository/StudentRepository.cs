using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.Repository
{
    public interface IStudentRepository
    {
        bool Create(Student model);

        (bool, string) Delete(int id);

        (bool, string) Edit(Student model);

        IQueryable<Student> GetAll();

        Student GetById(int id);
    }

    public class StudentRepository : IStudentRepository
    {
        private ApplicationDbContext db;

        public StudentRepository(
            ApplicationDbContext db
            )
        {
            this.db = db;
        }

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

        public (bool, string) Delete(int id)
        {
            try
            {
                var existing = db.Students.Find(id);
                db.Students.Remove(existing);
                db.SaveChanges();
                return (true, "Deleted Successully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}