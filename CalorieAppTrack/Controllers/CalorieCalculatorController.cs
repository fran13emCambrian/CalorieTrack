using CalorieAppTrack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph;

namespace CalorieAppTrack.Controllers
{
    public class CalorieCalculatorController : Controller
    {
        public ActionResult CalcCal()
        {
            return View(new CalorieCalculatorModel());
        }

        [HttpPost]
        public ActionResult CalcCal(CalorieCalculatorModel cc)
        {
           
                cc.CalorieIntake = 66 + (13.7 * cc.ActualWeight) + (5 * cc.Height) - (6.75 * cc.Age);
           
            return View(cc);
        }

    }
}
