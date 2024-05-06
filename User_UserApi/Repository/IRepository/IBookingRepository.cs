

using User_UserApi.Models;

namespace User_UserApi.Repository.IRepository
{
    public interface IBookingRepository : IRepository<BookingDetails>
    {
       void Update(BookingDetails obj);

    }
}
