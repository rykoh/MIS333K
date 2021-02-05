using sp20team13finalproject.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static sp20team13finalproject.Controllers.ReservationsController;

namespace sp20team13finalproject.Models
{
    public class Reservation
    {
        public const Decimal SENIOR_DISCOUNT = 0.10m; // Senior Discount: 10% - Age 65+
        public const Decimal CHILD_DISCOUNT = 0.15m; // Child Discount: 15% - Age 0-12
        public const Decimal FIRST_CLASS = 1.20m; // First Class Seat Premium: 20%
        public const Decimal SALES_TAX = 0.0775m; // Sales Tax: 7.75%
        public const Decimal MODIFICATION_FEE = 50.00m; // Reservation Modification Fee: $50 (does NOT include changing seats on same flight)

        // Unique Reservation Identifier - not used solely
        public Int32 ReservationID { get; set; }

        //This is the reference number that starts at 10000 and increases by 1
        [Display(Name = "Reservation Number")]
        public Int32 ReservationNum { get; set; }

        //Controller creates a time when the reservation is created
        [Display(Name = "Reservation Date")]
        public DateTime ReservationDate { get; set; }

        // How many passengers are on this reservations
        public Int32 NumPassengers { get; set; }

        [Display(Name = "Reservation Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal BaseFareSubtotal
        {
            get { return Tickets.Sum(t => t.FlightDetail.BaseFare); }
        }

        [Display(Name = "Tax Rate (7.75%)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal TaxTotal
        {
            get { return (BaseFareSubtotal + DiscountTotal) * SALES_TAX; }
        }

        [Display(Name = "Premium/Discount")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal DiscountTotal
        {
            get { return Tickets.Sum(t => t.DiscountPrem); }
        }

        [Display(Name = "Modification Fee")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ModFee
        {
            get { return MODIFICATION_FEE - 50; }
        }

        [Display(Name = "TOTAL")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ReservationTotal
        {
            get { return BaseFareSubtotal + DiscountTotal + TaxTotal + ModFee; }
        }

        [Required(ErrorMessage = "Payment Method is required.")]
        public PaymentType PaymentMethod { get; set; }
        


        //Navigational Properties
        // Ticket Table
        public List<Ticket> Tickets { get; set; }
        // User Table
        public AppUser AppUser { get; set; }

        public FlightDetail FlightDetail { get; set; }

        // Create new reservation if it does not exist
        public Reservation()
        {
            if (Tickets == null)
            {
                Tickets = new List<Ticket>();
            }
        }
        
        
    }
}
