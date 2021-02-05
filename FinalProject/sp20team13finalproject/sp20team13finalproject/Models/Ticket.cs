using sp20team13finalproject.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sp20team13finalproject.Models
{
    public class Ticket
    {
        // Unique Ticket Identifier
        public Int32 TicketID { get; set; }

        // First Name Listed Under Ticket For Search Purposes
        [Display(Name = "Customer First Name")]
        public String CustomerFirstName { get; set; }

        // Last Name Listed Under Ticket For Search Purposes
        [Display(Name = "Customer Last Name")]
        public String CustomerLastName { get; set; }

        // Email Listed Under Reservation For Search Purposes
        [Display(Name = "Customer Email")]
        public String CustomerEmail { get; set; }

        // Customer Advantage Number
        [Display(Name = "Customer Advantage Number")]
        public Int32 CustomerAdvantageNum { get; set; }

        // Date of Birth
        [Display(Name = "Date of Birth")]
        public String CustomerDOB { get; set; }

        // Uses SeatHelper Utility to get seatname
        [Display(Name = "Seat Selection")]
        public String SeatName { get; set; }

        [Display(Name = "FareType")]
        public FareType SeatFare { get; set; }

        // Seat Price (After Discounts and Premiums)
        [Display(Name = "Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal Price { get; set; }

        [Display(Name = "Discount")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal DiscountPrem
        {
            get { return Price - FlightDetail.BaseFare; }
        }

        // Navigational Properties
        // Reservation Table
        public Reservation Reservation { get; set; }

        // Flight Detail Table
        public FlightDetail FlightDetail { get; set; }

        public AppUser User { get; set; }

        public Ticket()
        {
            if (FlightDetail == null)
            {
                FlightDetail = new FlightDetail();
            }
        }
    }
}
