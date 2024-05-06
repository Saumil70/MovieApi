

using User_UserApi.Models;
using User_UserApi.Repository.IRepository;

namespace User_UserApi.Repository
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        private MovieEntites _db;
        public CityRepository(MovieEntites db) : base(db)
        {
            _db = db;
        }
        public void Update(City obj)
        {
            Update(obj);
        }



    }
}
