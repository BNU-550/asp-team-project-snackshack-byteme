using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Snack_Shack.Models
{
    /// <summary>
    /// Represents a product stored in the web application's database.
    /// 
    /// Each product has an associated ID. This class stores the product's
    /// name, description, price, availability and image.
    /// 
    /// Created by Isabelle Thorpe and Kayley Syrett (22/11/2021)
    /// Modified by Isabelle Thorpe (22/11/2021)
    /// Modified by Isabelle Thorpe (25/11/2021)

    /// </summary>
    public class Product
    {
        /// <summary>
        /// The product's ID, marked as the primary key.
        /// </summary>
        [Key]
        public int ProductID { get; set; }

        /// <summary>
        /// The product's name.
        /// </summary>
        [DisplayName("Name"), Required, StringLength(40)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the product.
        /// </summary>
        [DisplayName("More details"), StringLength(200)]
        public string Description { get; set; }

        /// <summary>
        /// The product's price.
        /// </summary>
        [DisplayName("Price"), Required, DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal ProductPrice { get; set; }

        /// <summary>
        /// If the product is available or not.
        /// True if it is, false if it is not.
        /// </summary>
        [DisplayName("Available"), Required]
        public bool? IsActive { get; set; }

        /// <summary>
        /// An image of the product expressed as
        /// string - image filepath, not saved
        /// into database.
        /// </summary>
        // Kayley and I don't think it's required
        [DisplayName("Image"), StringLength(150), DataType(DataType.Url)]
        public string ImageURL { get; set; }

        // Navigation Property 

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
