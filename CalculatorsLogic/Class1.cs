using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorsLogic
{
    public class Class1
    {
        //Calculate Ideal Weight
        //Values Height = cm 
        //Weight kg
        public static double IdealWeight(Double height)
        {
            return 0.75 * height - 62.5;
        }

        //Calculate  Calorie Intake
        public static double CalorieIntake(Double height, Double actualWeight, Double age)
        {
            return 66+(13.7*actualWeight)+(5*height)-(6.75*age);
        }

    }
}
