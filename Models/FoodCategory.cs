using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Snack_Shack.Models
{
    /// <summary>
    /// Represents the Food categories.
    /// 
    /// Created by Isabelle Thorpe (22/11/21)
    /// </summary>
    public enum FoodCategory
    {
        [Display(Name = "Starters")]
        Starters,
        [Display(Name = "Mains")]
        Mains,
        [Display(Name = "Desserts")]
        Desserts,
        [Display(Name = "Sides")]
        Sides
    }
}
