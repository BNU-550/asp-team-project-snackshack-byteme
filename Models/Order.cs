using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Snack_Shack.Models
{
    public class Order : Person
    {
        public int OrderID { get; set; }

        public int TableNo { get; set; }

        [DisplayName("Order Time Stamp"), DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        public Order()
        { }
                
    }
}

