using System.Linq;
using WebApp.Models;

namespace WebApp.Repository
{
    public interface IClassRepository
    {
        IQueryable<Class> GetAll();
    }

    public class ClassRepository : IClassRepository
    {
        private readonly ApplicationDbContext db;

        public ClassRepository(
            ApplicationDbContext db
            )
        {
            this.db = db;
        }

        public IQueryable<Class> GetAll()
        {
            return db.Classes;
        }
    }
}