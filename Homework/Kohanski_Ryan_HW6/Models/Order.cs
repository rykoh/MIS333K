using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kohanski_Ryan_HW6.Models
{
    public class Order
    {
        //TAX RATE
        //A named constant for the TAX_RATE, which is 0.0825.
        private const Decimal TAX_RATE = 0.0825m;

        //ORDER ID
        //(Primary Key)
        public Int32 OrderID { get; set; }

        //ORDER NUMBER
        //Order numbers start with 10001 and go up by one from there (10002, 10003, etc.)
        //Write a utility that generates the next order number (can be found on the relational demo thing on github.)
        //Then, on your post create on your orders controller, call it(example can be found on the registrations controller on our example)
        [Display(Name = "Order Number")]
        public Int32 OrderNumber { get; set; }

        //ORDER DATE
        [Display(Name = "Order Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime OrderDate { get; set; }

        //ORDER NOTES
        [Display(Name = "Order Notes")]
        public String OrderNotes { get; set; }

        //ORDER SUBTOTAL CALULCATION
        [Display(Name = "Order Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderSubtotal
        {
            get { return OrderDetails.Sum(od => od.ExtendedPrice); }
        }

        //TAX CALCULATION
        [Display(Name = "Sales Tax (8.25%)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal SalesTax
        {
            get { return OrderSubtotal * TAX_RATE; }
        }

        //ORDER TOTAL CALCULATION
        [Display(Name = "Registration Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderTotal
        {
            get { return OrderSubtotal + SalesTax; }
        }

        public Order()
        {
            if (OrderDetails == null)
            {
                OrderDetails = new List<OrderDetail>();
            }
        }

        //Navigational Properties
        public AppUser User { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
