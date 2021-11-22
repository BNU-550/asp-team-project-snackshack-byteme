using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Snack_Shack.Models
{
    public class OrderItem
    {
        // Do we need a limit?
        [DisplayName("Item Price (£)"), Required]
        public decimal SalePrice { get; set; }

        [DisplayName("Item Quantity"), Required]
        public  int Quantity { get; set; }
    }
}
