
using Microsoft.AspNetCore.Identity;
using User_UserApi.Models;
using User_UserApi.Repository.IRepository;




namespace User_UserApi.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private MovieEntites _db;
        public ITheatreRepository TheatreRepository { get; private set; }

        public IMovieRepository MovieRepository { get; private set; }

        public IScreenRepository ScreenRepository { get; private set; }

     

        public ICountryRepository   CountryRepository { get; private set; } 
        public IStateRepository StateRepository { get; private set; }   
        public ICityRepository CityRepository { get; private set; }
        public IBookingRepository BookingRepository { get; private set; }



        public UnitOfWork(MovieEntites db)
        {
            _db = db;
            TheatreRepository = new TheatreRepository(_db);
            MovieRepository = new MovieRepository(_db);
            ScreenRepository = new  ScreenRepository(_db);
         
            CountryRepository = new CountryRepository(_db);
            CityRepository = new CityRepository(_db);   
            StateRepository = new StateRepository(_db);
            BookingRepository = new BookingRepository(_db);
        }
        

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
