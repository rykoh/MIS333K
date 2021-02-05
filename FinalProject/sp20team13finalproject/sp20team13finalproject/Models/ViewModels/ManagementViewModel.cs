using sp20team13finalproject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sp20team13finalproject.Models.ViewModels
{
    public class ManagementViewModel
    {
        public Int32 AdvantageNum { get; set; }
        public Int32 ReservationNum { get; set; }
        public Int32 FlightNum { get; set; }
        public DateTime Date { get; set; }
        public Seat Seat { get; set; }

        public Reservation Reservation { get; set; }
    }
}