using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Snack_Shack.Models
{
    /// <summary>
    /// Represents payments made by customer. This class will  store the
    /// customer's payment card details such as their cardholder name,
    /// card number, the card expiry date and the 3-digit CVV. 
    /// 
    /// Payment uses Order class so to apply the card an OrderID????
    /// 
    /// Customers will be able to add multiple cards and save them securely
    /// on our database. They are also able to update already saved cards.
    /// 
    /// Created by Isabelle Thorpe and Kayley Styrett (22/11/2021)
    /// Modified by Isabelle Thorpe (22/11/2021)
    /// </summary>
    public class Payment : Order
    {
        /// <summary>
        /// Utilising the card number's 
        /// uniqueness to be the primary
        /// key.
        /// </summary>
        [Key]
        // Can you have annotations on a primary key?
        [DisplayName("Card number"), Required, MinLength(16), MaxLength(16)]
        public string CardNumber { get; set; }

        /// <summary>
        /// The cardholders name.
        /// As a customer can use
        /// someone else card to pay
        /// we have not used their
        /// name given in Person class.
        /// </summary>
        [DisplayName("Cardholder Name"), Required, StringLength(20)]
        public int CardHolderName { get; set; }

        /// <summary>
        /// Customer's card expiration date
        /// This is month and year and can
        /// only be up to 4 numbers.
        /// </summary>
        [DisplayName("Expiration Date"), Required, MinLength(4), MaxLength(4)]
        public int ExpiryDate { get; set; }

        /// <summary>
        /// Customer's card CVC. This
        /// can either be 3 or 4 numbers
        /// </summary>
        [DisplayName("CVC"), Required, MinLength(3), MaxLength(4)]
        public int CardCVV { get; set; }

        // Navigation properties 
        public virtual Order Order { get; set; }
}
}

// Added payment card number
// Added max length
// Now inherits from Order class
// Can min and max lenght be the same?
// Navigation properties?