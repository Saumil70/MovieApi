using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using User_UserApi.Models;

namespace User_UserApi.ViewModel
{
    public class ScreenViewModel
    {
        public int Id { get; set; } 
        public int ScreenId { get; set; }
        public int MovieId { get; set; }

        public int TheatreId { get; set; }  


        public int TotalSeats { get; set; }

        public int RemainingSeats {  get; set; }
        public List<DateTime> ShowTime { get; set; }

        [ForeignKey("MovieId")]

        [ValidateNever]
        public virtual Movie Movie { get; set; }

        [ForeignKey("TheatreId")]

        [ValidateNever]
        public virtual Theatre Theatre { get; set; }
    }
}
