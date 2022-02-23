using System.Linq;
using WebApp.Models;

namespace WebApp.Repository
{
    public class ClassRepository
    {
        private readonly ApplicationDbContext db;

        public ClassRepository()
        {
            this.db = new ApplicationDbContext();
        }

        public IQueryable<Class> GetAll()
        {
            return db.Classes;
        }
    }
}