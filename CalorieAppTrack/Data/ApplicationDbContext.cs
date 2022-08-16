using CalorieAppTrack.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CalorieAppTrack.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalorieAppTrack.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomIdentityUser>
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CalorieCalculatorModel> CalorieCalculatorModel { get; set; }
        public DbSet<FoodEntryModel> FoodEntryModel { get; set; }
        
       public DbSet<UserInfoModel> UserInfoModel { get; set; }
    }   
}
