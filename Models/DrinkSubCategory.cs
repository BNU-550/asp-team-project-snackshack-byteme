using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snack_Shack.Models
{
    /// <summary>
    /// Represents the Drink Sub-categories.
    /// 
    /// Created by Isabelle Thorpe (22/11/21)
    /// </summary>
    public enum DrinkSubCategory
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

    // Make each of these into it's own Enum Class?! Then Wines, Beers and Spirits are 
    // "true" to be alcoholic, and Soft Drinks and coffee's not. Could remove 
    // code duplication if had categories of "Alcoholic" and "non Alcoholic" drinks.
}
