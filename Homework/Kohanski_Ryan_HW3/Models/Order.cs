using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Kohanski_Ryan_HW3.Models
{
    public abstract class Order
    {
        //FIELDS (Named Constants) 
        const Decimal TACO_PRICE = 3.00m;
        const Decimal SANDWICH_PRICE = 5.00m;

        //PROPERTIES
        //CustomerType
        //Stores whether the customer is a walkup or catering customer.
        public enum CustomerType
        {
            Walkup, //0
            Catering //1
        }
        [Display(Name = "Customer Type: ")]
        public CustomerType customerType { get; set; }

        //NumberOfSandwiches
        //# of sandwiches requested by the customer
        [Display(Name = "Number of Sandwiches: ")]
        public Int32 NumberOfSandwiches { get; set; }

        //NumberOfTacos
        //# of tacos requested by the customer
        [Display(Name = "Number of Tacos: ")]
        public Int32 NumberOfTacos { get; set; }

        //SandwichSubtotal
        //# of sandwiches * price per sandwich
        [Display(Name = "Sandwich Subtotal: ")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal SandwichSubtotal { get; set; }

        //Subtotal
        //TacoSubtotal + SandwichSubtotal
        [Display(Name = "Subtotal: ")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Subtotal { get; set; }

        //TacoSubtotal
        //# of tacos * price per taco
        [Display(Name = "Taco Subtotal: ")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal TacoSubtotal { get; set; }

        //Total
        //Subtotal + Tax (for walkup), Subtotal + Delivery Fee(for catering)
        [Display(Name = "Total: ")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Total { get; set; }

        //TotalItems
        //# of sandwiches + # of tacos
        [Display(Name = "Total Items: ")]
        public Int32 TotalItems { get; set; }

        //METHODS
        public void CalcSubtotals()
        {
            // TotalItems
            TotalItems = NumberOfSandwiches + NumberOfTacos;

            // TacoSubtotal
            TacoSubtotal = NumberOfTacos * TACO_PRICE;

            // SandwichSubtotal
            SandwichSubtotal = NumberOfSandwiches * SANDWICH_PRICE;

            // Subtotal 
            Subtotal = TacoSubtotal + SandwichSubtotal;
        }

    }

}
