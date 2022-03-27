using System.Linq;
using WebApp.Models;

namespace WebApp.Repository
{
    public interface IGithubRepository
    {
        bool Create(GithubModel model);

        IQueryable<GithubModel> GetAll();
    }

    public class GithubRepository : IGithubRepository
    {
        private readonly ApplicationDbContext db;

        public GithubRepository(
            ApplicationDbContext db
            )
        {
            this.db = db;
        }

        public IQueryable<GithubModel> GetAll()
        {
            return db.GithubModels;
        }

        public bool Create(GithubModel model)
        {
            try
            {
                db.GithubModels.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}