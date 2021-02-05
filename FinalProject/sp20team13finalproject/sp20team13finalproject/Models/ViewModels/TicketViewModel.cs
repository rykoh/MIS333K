using sp20team13finalproject.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sp20team13finalproject.Models.ViewModels
{
    public class TicketViewModel
    {
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Enter Customer Email")]
        [Required(ErrorMessage = "Please select a customer email")]
        public String CustomerEmail { get; set; }

        [Display(Name = "Select a Seat")]
        [Required(ErrorMessage = "Please select a seat")]
        public String SeatName { get; set; }

        [Display(Name = "Departure City:")]
        [Required(ErrorMessage = "Please specify the departure city.")]
        public Int32 DepartureSearch { get; set; }

        [Display(Name = "Destination City:")]
        [Required(ErrorMessage = "Please specify the arrival city.")]
        public Int32 ArrivalSearch { get; set; }

        public FareType SeatFare { get; set; }

        public Decimal Price { get; set; }

        public FlightDetail FlightDetail { get; set; }

        public AppUser User { get; set; }

        public Reservation Reservation { get; set; }
    }
}
