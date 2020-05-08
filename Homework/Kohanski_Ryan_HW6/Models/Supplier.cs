using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kohanski_Ryan_HW6.Models
{
    public class Supplier
    {

        //Note that a supplier is a company, and not a person.  Thus, the supplier has no direct relationship to AppUser.

        //SUPPLIER ID
        //(Primary key)
        public Int32 SupplierID { get; set; }

        //SUPPLIER NAME
        //(String)
        [Display(Name = "Supplier Name")]
        public String SupplierName { get; set; }

        //SUPPLIER EMAIL
        //(String)
        [Display(Name = "Supplier Email")]
        public String SupplierEmail { get; set; }

        //SUPPLIER PHONE NUMBER
        //(String)
        [Display(Name = "Supplier Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public String SupplierPhoneNumber { get; set; }

        //Navigational Properties
        public List<ProductSupplier> ProductSuppliers { get; set; }

    }
}
