using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CalorieAppTracker.Models;

namespace CalorieAppTracker.Data
{
    public class CalorieAppTrackerContext : DbContext
    {
        public CalorieAppTrackerContext (DbContextOptions<CalorieAppTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<CalorieAppTracker.Models.WeightCalculator> WeightCalculator { get; set; }
    }
}
