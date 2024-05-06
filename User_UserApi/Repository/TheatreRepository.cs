using Microsoft.EntityFrameworkCore;

using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using User_UserApi.Models;
using User_UserApi.Repository.IRepository;



namespace User_UserApi.Repository
{
    public class TheatreRepository : Repository<Theatre>, ITheatreRepository
    {
        private MovieEntites _db;
        public TheatreRepository(MovieEntites db) : base(db)
        {
            _db = db;
        }


        public void Update(Theatre obj)
        {
            _db.Update(obj);
        }




    }
}
