using sp20team13finalproject.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sp20team13finalproject.Models
{
    public class FlightDetail
    {
        // Unique Flight Detail Identifier
        public Int32 FlightDetailID { get; set; }

        // Flight Number (1000-1014)
        [Display(Name = "Flight Number")]
        public Int32 FlightNum { get; set; }

        // Flight Date
        // TODO: Your system should schedule flights between April 15, 2020 and June 30, 2020
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        // Pilot For Flight (One Per Flight)
        [Display(Name = "Pilot")]
        public String Pilot { get; set; }

        // Co-Pilot For Flight (One Per Flight)
        [Display(Name = "Co-Pilot")]
        public String CoPilot { get; set; }

        // Flight Attendant For Flight (One Per Flight)
        [Display(Name = "Flight Attendant")]
        public String FlightAttendant { get; set; }

        // Base Fare (Before Any Discounts or Premiums)
        [Display(Name = "Base Fare")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal BaseFare { get; set; }

        // Flight Status (Departed, Delayed, Cancelled)
        public enum FlightStatus
        {
            OnTime, //0 
            Departed, //1
            Cancelled, //2
        }
        [Display(Name = "Flight Status")]
        public FlightStatus flightStatus { get; set; }

        // Uses SeatHelper Utility to get seatsleft
        public Int32 SeatsLeft
        {
            get { return (16 - FindAvailableSeats.GetTakenSeats().Count); }
        }


        //public List<Int32> SeatIDsTaken { get; set; }
        // Navigational Properties
        // Flight Table
        public Flight Flight { get; set; }

        // Ticket Table
        public List<Ticket> Tickets { get; set; }
    }
}
