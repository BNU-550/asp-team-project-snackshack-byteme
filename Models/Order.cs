using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Snack_Shack.Models
{   /// <summary>
    /// Represents the Customers orders. This class consists of the order
    /// identifier, when the order was placed, the customer who made the 
    /// order.
    /// 
    /// The customer will be able to view their order.
    /// 
    /// A Staff ID will be attached to each order to identity which staff
    /// member has accepted the order.
    /// 
    /// Created by Isabelle Thorpe and Kayley Styrett (22/11/2021)
    /// Modified by Isabelle Thorpe (22/11/2021)
    /// Modified by Isabelle Thorpe (25/11/2021)
    /// </summary>
    public class Order
    {
        // The orders ID - primary key
        [Key]
        public int OrderID { get; set; }

        // Foreign Key
        // How do we get Customer ID?
        // Do we need to add Payment Card number?
        public int  PersonID { get; set; }
        public int StaffID { get; set; }

        /// <summary>
        /// The table at which the customer
        /// is ordering food to (1-50)
        /// </summary>
        [DisplayName("Table Number"), Required, MaxLength(2)]
        public int TableNo { get; set; }

        /// <summary>
        /// What time the order was placed.
        /// </summary>
        [DisplayName("Order Time Stamp"), DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        // Navigation properites
        public virtual Person Person { get; set; }
        public virtual Payment Payment { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        // public virtual ICollection<Product> Products { get; set; }
    }
    // Enum?

    // Payment card attached to the order?
    // Order confirmation?
}

