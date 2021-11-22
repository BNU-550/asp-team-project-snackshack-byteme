using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Snack_Shack.Models
{
    public class Food
    {
        /// <summary>
        /// The Drink's Category type.
        /// </summary>
        [Required]
        public FoodCategory FoodCategory { get; set; }

    }
    // Definitely could make use of Enums
    // Could make an Enum for level of spice?!
    // Seperate categories for "Meat", "Fish", "Veggie" etc.???
}
