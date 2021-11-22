using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Snack_Shack.Models
{
    public class Person
    {
        public int PersonID { get; set; }

        [DisplayName("Last Name"), Required, StringLength(20)]
        public string LastName { get; set; }

        [DisplayName("First Name"), Required, StringLength(20)]
        public string FirstName { get; set; }

        [DisplayName("Email Address"), Required, StringLength(60)]
        public string EmailAddress { get; set; }

        [DisplayName("Over 18?"), Required]
        // Needs to be nullable?
        public bool IsMinor { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
