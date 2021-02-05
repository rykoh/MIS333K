using sp20team13finalproject.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sp20team13finalproject.Models.ViewModels
{
    public class SearchViewModel
    {

        [Display(Name = "Departure City:")]
        [Required(ErrorMessage = "Please specify the departure city.")]
        public Int32 DepartureSearch { get; set; }

        [Display(Name = "Destination City:")]
        [Required(ErrorMessage = "Please specify the arrival city.")]
        public Int32 ArrivalSearch { get; set; }

        [Display(Name = "Number of Passengers:")]
        [Required(ErrorMessage = "Please specify the number of passengers for your reservation.")]
        public Int32 NumPassSearch { get; set; }

        
        public enum TripType
        {
            OneWay,
            RoundTrip
        }

        [Required(ErrorMessage = "Please choose a trip type.")]
        public TripType tripType { get; set; }

        [Display(Name = "Start Date")]
        public DateTime? StartDateSearch { get; set; }

        

        [Display(Name = "End Date")]
        public DateTime? EndDateSearch { get; set; }



        [Display(Name = "Start Time")]
        public Int32? StartTimeSearch { get; set; }

        // Store the FlightDetail chosen
        public FlightDetail FlightDetail { get; set; }

        public FlightDetail FlightDetail2 { get; set; }


        //[Display(Name = "End Time")]
        //public DateTime? EndTimeSearch { get; set; }

    }
}
