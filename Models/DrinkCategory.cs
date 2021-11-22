using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Snack_Shack.Models
{
    /// <summary>
    /// Represents the Drink categories.
    /// 
    /// Created by Isabelle Thorpe (22/11/21)
    /// </summary>
    public enum DrinkCategory
    {
        [Display(Name = "Wines")]
        Wines,
        [Display(Name = "Beers")]
        Beers,
        [Display(Name = "Spritis")]
        Spirits,
        [Display(Name = "Soft Drinks")]
        SoftDrinks,
        [Display(Name = "Coffee's")]
        Coffee
    }
}
