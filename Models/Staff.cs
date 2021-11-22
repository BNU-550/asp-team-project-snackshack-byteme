using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Snack_Shack.Models
{
    public class Staff
    {
        public int StaffID { get; set; }
        
        //Nullable?
        [DisplayName("Job Title"), StringLength(20)]
        public string JobTitle { get; set; }
        
        // No DisplayName?
        public decimal Salary { get; set; }

    }
}
