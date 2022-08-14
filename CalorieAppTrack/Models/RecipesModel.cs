namespace CalorieAppTrack.Models
{
    public class RecipesModel
    {
        public int Id { get; set; }
        public string RecipeName { get; set; }

        public string RecipeDescription { get; set; }

        public string Ingredients { get; set; }

        public string PreparationTime { get; set; }

    }
}
