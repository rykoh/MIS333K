using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sp20team13finalproject.Models
{
    public class Flight
    {
        // Unique Flight Identifier
        public Int32 FlightID { get; set; }

        // Flight Number (1000-1014)
        [Display(Name = "Flight Number")]
        public Int32 FlightNum { get; set; }

        // Departure City (AP Code)
        [Display(Name = "Departure City")]
        public String DepCity { get; set; }

        // Arrival City (AP Code)
        [Display(Name = "Arrival City")]
        public String ArrivalCity { get; set; }

        // Departure Time
        // TODO: Flights are only scheduled on the hour or 15 minute intervals (i.e., 1:00pm, 1:15pm, 1:30pm, 1:45pm, etc.)
        [Display(Name = "Departure Time")]
        public TimeSpan DepTime { get; set; }

        // Days Of Week The Flight Operates
        [Display(Name = "Weekdays")]
        public String Days { get; set; }


        // Navigational Properties
        // Flight Detail Table
        public List<FlightDetail> FlightDetails { get; set; }

        // Airport Table
        public Airport DepartingAirport { get; set; }
        public Airport ArrivingAirport { get; set; }
    }
}
