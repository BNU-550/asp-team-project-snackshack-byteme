using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Snack_Shack.Models
{
    /// <summary>
    /// Represents each order item for the customers order.
    /// 
    /// This class contains the order item's sale price, quantity within the order.
    /// This will link to the Order and Product classes to act as an item/s within the
    /// Order/Basket.
    /// 
    /// Created by Isabelle Thorpe and Kayley Syrett
    /// Modified by Isabelle Thorpe (22/11/2021)
    /// </summary>
    public class OrderItem
    {
        // Primary key
        [Key]
        public int OrderItemID { get; set; }
        // Foreign keys
        public int OrderID { get; set; }
        public int ProductID { get; set; }

        /// <summary>
        /// The price of a single item
        /// </summary>
        // Do we need a limit?
        [DisplayName("Item Price (£)"), Required]
        public decimal SalePrice { get; set; }

        /// <summary>
        /// The quantity of items in the order.
        /// </summary>
        [DisplayName("Item Quantity"), Required]
        public  int Quantity { get; set; }

        // Navigation properties
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
    // Does it need a primary key? Has been added.
    // Would need to add that to the ERD if kept.
}
