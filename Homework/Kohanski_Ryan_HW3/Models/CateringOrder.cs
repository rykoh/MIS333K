using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Kohanski_Ryan_HW3.Models
{
    public class CateringOrder : Order
    {
        //PROPERTIES
        //CustomerCode
        [Display(Name = "Customer Code: ")]
        [StringLength(4, MinimumLength = 2, ErrorMessage = "Must be between 2 and 4 characters")]
        [Required(ErrorMessage = "Customer Code is required.")]
        //Add verification for no numbers or special characters (uses regex data annotation)
        public String CustomerCode { get; set; }

        //DeliveryFee
        [Display(Name = "Delivery Fee: ")]
        [Range(minimum: 0, maximum: 250, ErrorMessage = "Must be between 0 and 250")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal DeliveryFee { get; set; }

        //PreferredCustomer
        //True if the customer is a preferred customer; false if not
        [Display(Name = "Is this a preferred customer? ")]
        public Boolean PreferredCustomer { get; set; }

        //METHODS
        public void CalcTotals(Decimal decDeliveryFee)
        {
            if (PreferredCustomer == false)
                {
                DeliveryFee = decDeliveryFee;
                }
            else
                {
                DeliveryFee = 0;
                }

            base.CalcSubtotals();

            Total = Subtotal + DeliveryFee;
        }
    }
}
