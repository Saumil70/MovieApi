using Microsoft.EntityFrameworkCore;

using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using User_UserApi.Models;
using User_UserApi.Repository.IRepository;



namespace User_UserApi.Repository
{
    public class CountryRepository : Repository<Countries>, ICountryRepository
    {
        private MovieEntites _db;
        public CountryRepository(MovieEntites db) : base(db)
        {
            _db = db;
        }


        public void Update(Countries obj)
        {
            Update(obj);
        }




    }
}
