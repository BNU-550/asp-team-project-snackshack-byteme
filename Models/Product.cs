using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Snack_Shack.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        // Make it product name?
        [DisplayName("Name"), Required, StringLength(20)]
        public string Name { get; set; }

        [DisplayName("More details"), Required, StringLength(100)]
        public string Description { get; set; }

        // Do we need a display name if the same?
        [DisplayName("Price"), Required]
        public decimal Price { get; set; }

        [DisplayName("Available"), Required]
        // Needs to be nullable?
        public bool IsActive { get; set; }

        // Kayley and I don't think it's required
        [DisplayName("Image"), Required, StringLength(150)]
        public string ImageURL { get; set; }
    }
}
