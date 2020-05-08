using Kohanski_Ryan_HW6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kohanski_Ryan_HW6.Models
{
    public class OrderDetail
    {

        //There is a many-to-many relationship between products and orders.  
        //This relationship has several payload fields, so you will need a model class called OrderDetail. 

        //ORDER DETAIL ID
        public Int32 OrderDetailID { get; set; }

        //ORDER QUANTITY

        [Display(Name = "Order Quantity:")]
        [Required(ErrorMessage = "You must specify a quantity of products to enroll")]
        [Range(1, 1000, ErrorMessage = "Number of items must be between 1 and 1000")]
        public Int32 OrderQuantity { get; set; }

        //PRODUCT PRICE
        //(the price of the product at the time of order)
        [Display(Name = "Product Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ProductPrice { get; set; }

        //EXTENDED PRICE
        //(quantity*product price at the time of the order)
        [Display(Name = "Extended Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ExtendedPrice { get; set; }
        //{
            //get { return OrderQuantity * ProductPrice; }
        //}


        //Navigational Properties
        public Order Order { get; set; }
        public Product Product { get; set; }

    }
}
