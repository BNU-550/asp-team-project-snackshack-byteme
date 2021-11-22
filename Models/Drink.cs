using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Snack_Shack.Models
{
    public class Drink
    {
        /// <summary>
        /// The Drink's Category type.
        /// </summary>
        [Required]
        public DrinkCategory DrinkCategory { get; set; }

        public bool ContainsAlcohol { get; set; }
    }
    // Definitely could make use of Enums
    // Contains Alcohol here? Or seperate Classes for alcohol and non alcoholic drinks
}
