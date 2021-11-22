using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Snack_Shack.Models
{
    /// <summary>
    /// Represents a product stored in the web application's database.
    /// 
    /// Each product has an associated ID. This class stores the product's
    /// name, description, price, availability and image.
    /// 
    /// Created by Isabelle Thorpe and Kayley Syrett
    /// Modified by Isabelle Thorpe (22/11/2021)
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
        [DisplayName("Name"), Required, StringLength(20)]
        public string Name { get; set; }

        /// <summary>
        /// Description of the product.
        /// </summary>
        [DisplayName("More details"), Required, StringLength(100)]
        public string Description { get; set; }

        /// <summary>
        /// The product's price.
        /// </summary>
        [DisplayName("Price"), Required]
        public decimal Price { get; set; }

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
        [DisplayName("Image"), Required, StringLength(150)]
        public string ImageURL { get; set; }

        // Use of enums?
    }
}
