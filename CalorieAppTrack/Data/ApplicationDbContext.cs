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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>()
            .HasOne(iwc => iwc.IdealWeightCalculatorModel)
            .WithOne(um => um.UserModel)
            .HasForeignKey<IdealWeightCalculatorModel>(iwc => iwc.UserId);

            modelBuilder.Entity<UserModel>()
            .HasOne(ccm => ccm.CalorieCalculatorModel)
            .WithOne(u => u.UserModel)
            .HasForeignKey<CalorieCalculatorModel>(ccm => ccm.UserId);

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<CalorieCalculatorModel> CalorieCalculatorModel { get; set; }
      
        public DbSet<FoodEntryModel> FoodEntryModel { get; set; }
        
        public DbSet<UserModel> UserModel { get; set; }

        public DbSet<IdealWeightCalculatorModel> IdealWeightCalculatorModel { get; set; }

        public DbSet<RecipesModel> RecipesModel { get; set; }


    }   
}
