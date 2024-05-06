

namespace User_UserApi.Repository.IRepository
{
    public interface IUnitOfWork
    {


        ITheatreRepository TheatreRepository { get; }
        IMovieRepository  MovieRepository { get; }
        IScreenRepository ScreenRepository { get; } 

        ICountryRepository CountryRepository { get; }
        IStateRepository StateRepository { get; }   
        ICityRepository CityRepository { get; }
        IBookingRepository BookingRepository { get; }
        void Save();
    }
}
