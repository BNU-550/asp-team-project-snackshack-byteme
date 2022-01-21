using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Snack_Shack.Models
{
    /// <summary>
    /// This class inherits from Product to create a drink item.
    /// The class describes what category and subcategory a drink
    /// belongs to, whether or not it contains alcohol, the alcohol
    /// percentage and the drinks brand name. 
    /// 
    /// Created by Isabelle Thorpe and Kayley Syrett (22/11/21)
    /// Modified by Isabelle Thorpe (23/11/21)
    /// </summary>
    public class Drink
    {
        [Key]
        public int DrinkID { get; set; }
        /// <summary>
        /// The Drink's Category type i.e.,
        /// wine, beer, spirits, soft drinks,
        /// hot drinks.
        /// </summary>
        [Required]
        public DrinkCategory DrinkCategory { get; set; }

        /// <summary>
        /// A drinks SubCategory i.e., Red Wine,
        /// White Wine, Lager etc.
        /// </summary>
        /// 

        public DrinkSubCategory SubCategory { get; set; }
        /// <summary>
        /// Whether or not the drink
        /// contains alcohol. True if it
        /// does, False if it doesn't.
        /// 
        /// // If true then need to add a percentage?
        /// </summary>
        /// 
        [UIHint("_myTemplate")]
        public bool ContainsAlcohol { get; set; }

        /// <summary>
        /// The amount in of alcohol (%) in
        /// a drink. Cannot be above 50.
        /// </summary>
        /// 

        [DisplayName("ABV %"), Range(0,100)]
        public double AlcoholPercentage { get; set; }
        
        /// <summary>
        /// The Brand that the drink
        /// belongs to.
        /// </summary>
        [DisplayName("Brand"), Required]
        public string DrinkBrand { get; set; }

        public int ProductID { get; set; }
        public virtual Product Product { get; set; }



        // Added range - 50%
        // Added Brand
        // Added Category and Subcategroy
        // Navigation properties
    }
    // Contains Alcohol here? Or seperate Classes for alcohol and non alcoholic drinks

}
