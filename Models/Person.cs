using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Snack_Shack.Models
{
    /// <summary>
    /// Represents each person in the database, storing their details such as their
    /// name, email address, phone number, 18+ verification, and indicates whether the
    /// individual is a customer or staff member.
    /// 
    /// Created by Isabelle Thorpe and Kayley Syrett (22/11/2021)
    /// Modified by Isabelle Thorpe (22/11/2021)
    /// </summary>
    public class Person
    {
        /// <summary>
        /// The person's ID, acting as the database's primary key.
        /// </summary>
        [Key]
        public int PersonID { get; set; }

        /// <summary>
        /// The person's first name.
        /// </summary>
        /// 
        [DisplayName("First Name"), Required, StringLength(20)]
        public string FirstName { get; set; }

        /// <summary>
        /// The person's last name.
        /// </summary>
        [DisplayName("Last Name"), Required, StringLength(20)]
        public string LastName { get; set; }

        /// <summary>
        /// The person's email address.
        /// </summary>
        [DisplayName("Email Address"), Required, StringLength(60)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The person's mobile number.
        /// </summary>
        [DisplayName("Mobile"), Required, StringLength(15)]
        public string MobileNumber { get; set; }

        /// <summary>
        /// Whether the customer is Over 18 or not.
        /// True if they are, false if they are not.
        /// </summary>
        [DisplayName("Over 18?")]
        // Needs to be nullable?
        public bool IsMinor { get; set; }

        /// <summary>
        /// Need to ensure how to create a log in which
        /// differentiates between staff and customer.
        /// Not sure how to do this.
        /// </summary>
        public bool IsCustomer { get; set; }

        /// <summary>
        /// Returns full Name of person.
        /// </summary>
        
        // Calculated property 
        public string FullName
        {
            get
            {
                return LastName + (" ") + FirstName;
            }
        }
    }
}
