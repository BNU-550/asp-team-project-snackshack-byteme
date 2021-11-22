using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Snack_Shack.Models
{
    public class Payment
    {
        public string CardNo { get; set; }

        // Range too small? Use String instead?
        [DisplayName("Cardholder Name"), Required, Range(0,60)]
        public int CardHolderName { get; set; }

        // Range too small? Use String instead?
        [DisplayName("Expiration Date"), Required, Range(0, 10)]
        public int ExpiryDate { get; set; }

        // Range too small? Use String instead? Underscore ok?
        [DisplayName("CVC"), Required, Range(0, 10)]
        public int CVC_Number { get; set; }

    }
}
