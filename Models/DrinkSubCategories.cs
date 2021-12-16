using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Snack_Shack.Models
{
    /// <summary>
    /// This class is to be utilised as a table to 
    /// create a drop down list for wines, beers,
    /// spirits etc. Further broken down into their
    /// sub categries such as Reds, Whites, Sparkling
    /// etc.
    /// 
    /// Created by Isabelle Thorpe (22/11/21)
    /// </summary>
    public class DrinkSubCategories
    {
        

        [Key]
        public int ID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        /// <summary>
        /// The Drink's Category type i.e.,
        /// wine, beer, spirits, soft drinks,
        /// hot drinks.
        /// </summary>

        public DrinkCategory MainCategory { get; set; }

        /// <summary>
        /// A drinks SubCategory i.e., Red Wine,
        /// White Wine, Lager etc.
        /// </summary>
        /// 

        public string SubCategory { get; set; }
    }
}
