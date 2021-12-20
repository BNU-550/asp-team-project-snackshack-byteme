using System;
using System.ComponentModel.DataAnnotations;

namespace Snack_Shack.Models
{
    /// <summary>
    /// Represents all the categories a drink 
    /// item can belong to.
    /// 
    /// Created by Isabelle Thorpe (22/11/21)
    /// </summary>
    public enum DrinkCategory
    {
        [Display(Name = "Wines")]
        Wines,
        [Display(Name = "Beers")]
        Beers,
        [Display(Name = "Spirits")]
        Spirits,
        [Display(Name = "Soft Drinks")]
        SoftDrinks,
        [Display(Name = "Hot Drinks")]
        HotDrinks
    }
}
