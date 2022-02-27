using AutoMapper;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp
{
    public class MapperConfig
    {
        public static MapperConfiguration Configure()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentViewModel>().AfterMap((src, dest) =>
                {
                    dest.ClassNames = src.Class != null ? src.Class.Name : "";
                });
                cfg.CreateMap<StudentViewModel, Student>();
            });

            return mapperConfiguration;
        }
    }
}