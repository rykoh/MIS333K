using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kohanski_Ryan_HW6.Models
{
    public class Product
    {
        //PRODUCT ID
        //This should be an auto-generated number
        //The productID is already auto generated when you create an instance of the class.
        //Pretty sure there should be a class in utilities similar to OrderID
        public Int32 ProductID { get; set; }

        //PRODUCT NAME
        //This field is required.
        [Required(ErrorMessage = "Product name is required")]
        [Display(Name = "Product Name")]
        public String ProductName { get; set; }

        //PRODUCT DESCRIPTION
        //This field is not required
        [Display(Name = "Product Description")]
        public String ProductDescription { get; set; }

        //PRODUCT PRICE
        //This field is required and should be displayed with a $ and 2 decimal places.
        [Required(ErrorMessage = "Product Price is required")]
        [Display(Name = "Product Price")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal ProductPrice { get; set; }

        //Navigational Properties
        public List<OrderDetail> OrderDetails { get; set; }
        public List<ProductSupplier> ProductSuppliers { get; set; }

    }
}
