namespace User_UserApi.Models
{
    public class Movie
    {
        public int MovieId { get; set; } 
        public string MovieName { get; set; }   
        public string Genre { get; set; }   
        public TimeSpan Time {  get; set; }

        public string ImageUrl { get; set; }


    }
}
