using Microsoft.EntityFrameworkCore;

using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using User_UserApi.Models;
using User_UserApi.Repository.IRepository;



namespace User_UserApi.Repository
{
    public class BookingRepository : Repository<BookingDetails>, IBookingRepository
    {
        private MovieEntites _db;
        public BookingRepository(MovieEntites db) : base(db)
        {
            _db = db;
        }


        public void Update(BookingDetails obj)
        {
            Update(obj);
        }




    }
}
