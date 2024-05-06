


using User_UserApi.Models;

namespace User_UserApi.Repository.IRepository
{
    public interface IScreenRepository : IRepository<Screen>
    {
        void Update(Screen obj);
      


    }
}
