using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace User_UserApi.Models
{
    public class BookingDetails
    {
        [Key]
        public int BookingId { get; set; }
        public int TotalSeatSelected { get; set; }
        public decimal Amount { get; set; }

        public int MovieId { get; set; }
        public int TheatreId { get; set; }
        public int ScreenId { get; set; }

   



        [ForeignKey("MovieId")]
        [ValidateNever]
        public virtual Movie Movie { get; set; }


        [ForeignKey("TheatreId")]
        [ValidateNever]
        public virtual Theatre Theatre { get; set; }

        [ForeignKey("ScreenId")]
        [ValidateNever]
        public virtual Screen Screen { get; set; }
    }
}

