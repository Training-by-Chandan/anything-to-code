using AutoMapper;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;
using WebApp.Repository;
using WebApp.ViewModels;

namespace WebApp.Services
{
    public interface IStudentService
    {
        bool Create(StudentViewModel model);

        (bool, string) Delete(int id);

        (bool, string) Edit(StudentViewModel model);

        List<StudentViewModel> GetAll();

        (int, StudentViewModel) GetById(int id);
    }

    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;

        public StudentService(
            IStudentRepository studentRepository,
            IMapper mapper,
            IUserRepository userRepository
            )
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
            this.userRepository = userRepository;
        }

        public List<StudentViewModel> GetAll()
        {
            try
            {
                throw new Exception("Throwing this exception intentionally");
                var data = studentRepository.GetAll().ToList();
                var result = mapper.Map<List<Student>, List<StudentViewModel>>(data);
                return result;
            }
            catch (Exception ex)
            {
                Elmah.ErrorSignal.FromCurrentContext().Raise(ex);
                return null;
            }
        }

        public bool Create(StudentViewModel model)
        {
            try
            {
                //create student user
                var hash = new PasswordHasher();
                var applicationUser = new ApplicationUser()
                {
                    UserName = model.Username,
                    PasswordHash = hash.HashPassword(model.Password),
                    Email = model.Username
                };
                var result = userRepository.CreateUser(applicationUser);
                if (result.Item1)
                {
                    //create student
                    var student = mapper.Map<StudentViewModel, Student>(model);
                    student.UserId = result.Item2.Id;
                    var res = studentRepository.Create(student);
                    //assign role "student"
                    var roleResult = userRepository.AssignUserToRole(result.Item2.Id, "Student");
                    //send email

                    return res;
                }
                else
                {
                    return false;
                }
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
                var res = studentRepository.GetById(id);
                if (res == null) return (404, null);
                else
                {
                    var data = mapper.Map<Student, StudentViewModel>(res);
                    return (200, data);
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
                var existing = studentRepository.GetById(model.Id);
                if (existing == null) return (false, "Not found");
                else
                {
                    var result = mapper.Map<StudentViewModel, Student>(model, existing);
                    var res = studentRepository.Edit(result);
                    return res;
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Delete(int id) => studentRepository.Delete(id);
    }
}