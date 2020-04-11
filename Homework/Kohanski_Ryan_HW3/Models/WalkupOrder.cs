using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Kohanski_Ryan_HW3.Models
{
    public class WalkupOrder : Order
    {
        //FIELDS (Named Constants) 
        const Decimal SALES_TAX_RATE = 0.085m;

        //PROPERTIES
        //CustomerName
        [Display(Name = "Customer Name: ")]
        public String CustomerName { get; set; }

        //SalesTax
        //Subtotal * Sales tax rate
        [Display(Name = "Sales Tax: ")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal SalesTax { get; set; }

        //METHODS
        //Calculates SalesTax and Total
        public void CalcTotals()
        {
            //Decimal SalesTax;
            base.CalcSubtotals();

            SalesTax = Subtotal * SALES_TAX_RATE;
            Total = Subtotal + SalesTax;

        }

    }
}
