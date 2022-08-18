using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalorieAppTrack.Models
{
    public class CalorieCalculatorModel
    {
        [Key]
        public int Id { get; set; }
        public double Height {get; set;}

        public double Age { get; set; }

        public double ActualWeight { get; set; }

        public double CalorieIntake {get; set;}

        //Relationships
       // public int UserId { get; set; }
        public UserModel User { get; set; }
    }
}
