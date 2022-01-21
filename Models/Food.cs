using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Snack_Shack.Models
{
    /// <summary>
    /// This class is going to be the death of me 
    /// 
    /// Created by Isabelle Thorpe and Kayley Syrett (22/11/21)
    /// Modified by Isabelle Thorpe (23/11/21)
    /// </summary>
    public class Food 
    {

        [Key]
        public int FoodID { get; set; }
        /// <summary>
        /// The Drink's Category type.
        /// </summary>
        [Required]
        public FoodCategory FoodCategory { get; set; }

        /// <summary>
        /// Number of Calories in each
        /// Food item. Drinks do not
        /// show calories.
        /// </summary>
        [DisplayName("Calories"), Required, MaxLength(4)]
        public int Calories { get; set; }

        /// <summary>
        /// Whether the food contains 
        /// nuts. It does if true,
        /// it does not if false.
        /// 
        /// Does this need to be nullable?
        /// </summary>
        /// 
        [UIHint("_myTemplate")]
        [DisplayName("Nut Allergy")]

        public  bool ContainsNuts { get; set; }

        /// <summary>
        /// Whether the food contains 
        /// gluten. It does if true,
        /// it does not if false.
        /// 
        /// Does this need to be nullable?
        /// </summary>
        /// 
        [UIHint("_myTemplate")]
        [DisplayName("Gluten Allergy")]

        public bool ContainsGluten { get; set; }

        /// <summary>
        /// Whether the food is suitable
        /// for vegetarians or not. It if
        /// is, then true. If not, then false.
        /// 
        /// Does this need to be nullable?
        /// </summary>
        /// 
        [UIHint("_myTemplate")]
        [DisplayName("Vegetarian")]

        public bool IsVegetarian { get; set; }

        /// <summary>
        /// Whether the food is suitable
        /// for vegans or not. It if is,
        /// then true. If not, then false.
        /// 
        /// Does this need to be nullable?
        /// </summary>
        /// 
        [UIHint("_myTemplate")]
        [DisplayName("Vegan")]

        public bool IsVegan { get; set; }

        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
