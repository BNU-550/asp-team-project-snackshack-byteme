using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Snack_Shack.Models
{
    /// <summary>
    /// Represents staff members in the database. Staff inherit their
    /// details such as name, email address, phone number from the
    /// Person class. The Person primary key is linked to this class.
    /// 
    /// The Staff class has their StaffID as their primary key as
    /// to differeniate which staff member served which order.
    /// 
    /// This class also includes the staff members job title and 
    /// their salary.
    /// 
    /// Created Isabelle Thorpe and Kayley Syrett
    /// Modified by Isabelle Thorpe (22/11/2021)
    /// </summary>
    public class Staff : Person
    {
        [Key]
        public int StaffID { get; set; }

        /// <summary>
        /// The staff member's current job title.
        /// </summary>
        [DisplayName("Job Title"), StringLength(20)]
        public string JobTitle { get; set; }
        
        /// <summary>
        /// The staff members current salary.
        /// </summary>
        public decimal Salary { get; set; }
    }
}
