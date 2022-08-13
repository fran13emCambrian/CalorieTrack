namespace CalorieAppTrack.Models
{
    public class FoodEntryModel
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public string Description { get; set; } 
        public int Calories { get; set; }   

        public int Servings { get; set; }   

        public double TotalCalories { get; set; }

        public double TotalDayCalories { get; set; }
    }
}
