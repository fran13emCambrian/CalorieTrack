using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorsLogic;
using Microsoft.AspNetCore.Mvc; 

namespace CalorieTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalorieCalculator
    {

        [HttpGet]
        //Takes data to calculate Calorie Diary Intake

        public double CalculateCalorieIntake([FromQuery] Double height, [FromQuery] Double actualWeight, [FromQuery] Double age)
        {
            return Class1.CalorieIntake(height, actualWeight, age);
        }
    } 
}
