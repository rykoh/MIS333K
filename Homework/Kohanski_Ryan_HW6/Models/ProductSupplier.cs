using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kohanski_Ryan_HW6.Models
{
    public class ProductSupplier
    {
        //PRODUCT SUPPLIER ID
        //(Primary Key)
        public Int32 ProductSupplierID { get; set; }

        //Navigational Properties
        public Product Product { get; set; }
        public Supplier Supplier { get; set; }

    }
}
