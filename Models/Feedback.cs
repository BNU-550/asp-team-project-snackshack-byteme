using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Snack_Shack.Models
{
    /// <summary>
    /// This class contains the customers feedback. They can
    /// send a feedback message which will be timestamped and
    /// stored in the database.
    /// 
    /// Created by Isabelle Thorpe and Kayley Styrett
    /// Modified by Isabelle Thorpe (22/11/2021)
    /// </summary>
    public class Feedback
    {
        // Primary Key
        [Key]
        public int FeedbackID { get; set; }

        // Foreign keys
        public int OrderID { get; set; }

        /// <summary>
        /// The customer's review for the order item.
        /// </summary>
        [DisplayName("Customer Review"), StringLength(300)]
        public string FeedbackMessage { get; set; }

        /// <summary>
        /// The date the customer created this review.
        /// </summary>
        [DisplayName("Customer Review Date"), DataType(DataType.Date)]
        public DateTime CustomerReviewDate { get; set; }

        public virtual Order Order { get; set; }
    }
    // Do we need Person if we have Order? 
    // Probably not as Person already attached
    // to order

    // Added primary key for feedback? If this stays
    // it will need to go into ERD

    // Do we want to add a star review/ 1-5 rating system
}
