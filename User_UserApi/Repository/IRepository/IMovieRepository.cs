

using User_UserApi.Models;

namespace User_UserApi.Repository.IRepository
{
    public interface IMovieRepository : IRepository<Movie>
    {
        void Update(Movie obj);


    }
}
