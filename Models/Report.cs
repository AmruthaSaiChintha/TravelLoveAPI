using System;
using System.ComponentModel.DataAnnotations;
using TravelLove.Models;

namespace TravelLove.Models
{
    public class Report
    {
            [Key]
        
            public int reportId { get; set; }
            public string PName { get; set; }
            public int Age { get; set; }
            public string gender { get; set; }
            public string Class { get; set; }
            public int BookingId { get; set; }
            public double fare { get; set; }
            public DateTime Date { get; set; }
            public string Status { get; set; }
            public int SeatNum { get; set; }
    }
}
