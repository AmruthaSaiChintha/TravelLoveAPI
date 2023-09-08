using System;
using TravelLove.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelLove.Models
{
    public class BusDetails
    {
        [Key]
        public int BusId { get; set; }
        [Required]
        public string BusName { get; set; }
        [Required]
        public string Source { get; set; }
       [Required]
       public string image { get; set; }

        [Required]
        public string Destination { get; set; }
        [Required]
        public DateTime DepartureDate { get; set; }
        [Required]
        public string DepartureTime { get; set; }
        [Required]
        public int charges { get; set; }


    
    }
}
