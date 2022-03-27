using AutoMapper;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Lifetime;
using Unity.Mvc5;
using WebApp.Controllers;
using WebApp.Models;
using WebApp.Repository;
using WebApp.Services;

namespace WebApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<ApplicationDbContext>(new HierarchicalLifetimeManager());
            container.RegisterType<AccountController>(new InjectionConstructor());
            container.RegisterType<ManageController>(new InjectionConstructor());

            #region AutoMapper

            MapperConfiguration config = MapperConfig.Configure(); ;
            //build the mapper
            IMapper mapper = config.CreateMapper();
            //..register mapper with the dependency container used by your application.
            container.RegisterInstance<IMapper>(mapper);

            #endregion AutoMapper

            #region Repository

            container.RegisterType<IClassRepository, ClassRepository>();
            container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IGithubRepository, GithubRepository>();

            #endregion Repository

            #region Services

            container.RegisterType<IClassService, ClassService>();
            container.RegisterType<IStudentService, StudentService>();

            #endregion Services

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}