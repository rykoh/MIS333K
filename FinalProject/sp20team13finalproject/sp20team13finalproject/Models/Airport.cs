using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sp20team13finalproject.Models
{
    public class Airport
    {
        //Unique Airport Identifier
        public Int32 AirportID { get; set; }

        // Airport City Number (8001, 8002, 8003, 8004)
        [Display(Name = "City Number")]
        public String CityNum { get; set; }

        // Airport City (Austin, Dallas, Houston, El Paso)
        [Display(Name = "City")]
        public String City { get; set; }

        // Airport State (TX)
        [Display(Name = "State")]
        public String State { get; set; }

        // Airport Code (AUS, DFW, HOU, ELP)
        [Display(Name = "Airport Code")]
        public String APCode { get; set; }

        // Distances To Each City (Miles)
        [Display(Name = "Distance To Austin")]
        public Int32 DisToAus { get; set; }
        [Display(Name = "Distance To Dallas")]
        public Int32 DisToDal { get; set; }
        [Display(Name = "Distance To El Paso")]
        public Int32 DisToEP { get; set; }
        [Display(Name = "Distance To Houston")]
        public Int32 DisToHou { get; set; }

        // Duration To Each City (Time)
        [Display(Name = "Duration To Austin")]
        public TimeSpan DurToAus { get; set; }
        [Display(Name = "Duration To Dallas")]
        public TimeSpan DurToDal { get; set; }
        [Display(Name = "Duration To El Paso")]
        public TimeSpan DurToEP { get; set; }
        [Display(Name = "Duration To Houston")]
        public TimeSpan DurToHou { get; set; }


        // Navigational Properties 
        // Airport Departed From (Flight Table)
        [InverseProperty("DepartingAirport")]
        public List<Flight> DepartingFlights { get; set; }

        // Airport Arriving At (Flight Table)
        [InverseProperty("ArrivingAirport")]
        public List<Flight> ArrivingFlights { get; set; }
    }
}
