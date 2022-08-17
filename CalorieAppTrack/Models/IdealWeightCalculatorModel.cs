using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalorieAppTrack.Models
{
    public class IdealWeightCalculatorModel
    {
        [Key]
        public int WeightId { get; set; }
        public int ActualWeight { get; set; }
        
        public int Height { get; set; } 

        public double IdealWeight { get; set; }

        //RelationShip
        public int UserId { get; set; }
        public UserModel UserModel { get; set; } 
    }
}
