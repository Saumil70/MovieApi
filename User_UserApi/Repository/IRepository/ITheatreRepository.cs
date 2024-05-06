
using User_UserApi.Models;

namespace User_UserApi.Repository.IRepository
{
    public interface ITheatreRepository : IRepository<Theatre>
    {
       void Update(Theatre obj);

    }
}
