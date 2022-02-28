using AutoMapper;
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

        public StudentService(
            IStudentRepository studentRepository,
            IMapper mapper
            )
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }

        public List<StudentViewModel> GetAll()
        {
            var data = studentRepository.GetAll().ToList();
            var result = mapper.Map<List<Student>, List<StudentViewModel>>(data);
            return result;
        }

        public bool Create(StudentViewModel model)
        {
            try
            {
                var student = mapper.Map<StudentViewModel, Student>(model);
                var res = studentRepository.Create(student);
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