using System;
using System.ComponentModel.DataAnnotations;

namespace Snack_Shack.Models
{
    /// <summary>
    /// Represents all the Sub categories a drink 
    /// item can belong to.
    /// 
    /// Created by Isabelle Thorpe (22/11/21)
    /// Updated to an Enum (17/12/21) Isabelle Thorpe
    /// </summary>
    public enum DrinkSubCategory
    {
        [Display(Name = "White")]
        White,
        [Display(Name = "Red")]
        Red,
        [Display(Name = "Rosé")]
        Rosé,
        [Display(Name = "Sparkling")]
        Sparkling,
        [Display(Name = "Champage")]
        Champagne,
        [Display(Name = "Lager")]
        Lager,
        [Display(Name = "Ale")]
        Ale,
        [Display(Name = "Gin")]
        Gin,
        [Display(Name = "Vodka")]
        Vodka,
        [Display(Name = "Whisky")]
        Whisky,
        [Display(Name = "Juice")]
        Juice,
        [Display(Name = "Water")]
        Water,
        [Display(Name = "Pop")]
        Pop,
        [Display(Name = "Tonic")]
        Tonic,
        [Display(Name = "Coffee")]
        Coffee,
        [Display(Name = "Tea")]
        Tea,
    }
}
