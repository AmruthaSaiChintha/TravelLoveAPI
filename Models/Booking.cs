using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using TravelLove.Models;

namespace TravelLove.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [ForeignKey("RegisterUser")]
        public int UserId { get; set; }
        public virtual RegisterUser RegisterUser { get; set; }

        [ForeignKey("BusDetails")] // Specify the navigation property name
        public int BusId { get; set; }
        public virtual BusDetails BusDetails { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string BusName { get; set; }

        [Required]
        public string ContactNo { get; set; }
        [Required]
        public string Source { get; set; }
        [Required]
        public string Destination { get; set; }
        [Required]
        public string DepartureDate { get; set; }
        [Required]

        public int charges { get; set; }

        public string cancelticket { get; set; }

      //  public virtual BusDetails busName { get; set; }
       // public virtual RegisterUser  username{ get; set; }

    }


}
