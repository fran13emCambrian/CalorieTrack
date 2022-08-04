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
    public class IdealWeightCalculator : Controller
    {
            //Takes data to calculate Ideal Weight
            [HttpGet]
            public double CalculateIdealWeight([FromQuery] Double height)
            {
                return Class1.IdealWeight(height);
            }
        
    }
}
