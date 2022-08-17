using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CalorieAppTrack.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relationships
        public ICollection<FoodEntryModel> FoodEntries { get; set; }

        public ICollection<RecipesModel> RecipesModels { get; set; }

        public IdealWeightCalculatorModel IdealWeightCalculatorModel { get; set; }
        public CalorieCalculatorModel CalorieCalculatorModel { get; set; }
    }
}
