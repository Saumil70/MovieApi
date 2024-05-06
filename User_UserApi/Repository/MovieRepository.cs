


using User_UserApi.Models;
using User_UserApi.Repository.IRepository;

namespace User_UserApi.Repository
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        private MovieEntites _db;
        public MovieRepository(MovieEntites db) : base(db)
        {
            _db = db;
        }
        public void Update(Movie obj)
        {
            _db.Update(obj);
        }

    }
}
