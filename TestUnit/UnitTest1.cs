using CalculatorsLogic;
using CalorieAppTrack;
using CalorieAppTrack.Controllers;
using CalorieAppTrack.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nest;

namespace TestUnit
{
    [TestClass]
    public class UnitTest1
    {
        //Ideal Weight Caloculator Unit Test
        [TestMethod]
        public void IdealWeightUnitTest1()
        {
            double height = 1;
            double desired = -61.75;

            double actualResult = Class1.IdealWeight(height);
            Assert.AreEqual(desired, actualResult);
        }

        [TestMethod]
        public void IdealWeightUnitTest2()
        {
            double height = 170;
            double desired = 65;

            double actualResult = Class1.IdealWeight(height);
            Assert.AreEqual(desired, actualResult);
        }

        [TestMethod]
        public void IdealWeightUnitTest3()
        {
            double height = 175;
            double desired = 68.75;

            double actualResult = Class1.IdealWeight(height);
            Assert.AreEqual(desired, actualResult);
        }

        //Daily Calorie Intake Caloculator Unit Test

        [TestMethod]
        public void CalorieIntakeCalculatorUnitTest1()
        {
            double height = 175;
            double actualWeight = 100;
            double age = 25;
            double desired = 2142.25;

            double actualResult = Class1.CalorieIntake(height, actualWeight, age);
            Assert.AreEqual(desired, actualResult);
        }
 
        public void CalorieIntakeCalculatorUnitTest2()
        {
            double height = 180;
            double actualWeight = 120;
            double age = 50;
            double desired = 2205;

            double actualResult = Class1.CalorieIntake(height, actualWeight, age);
            Assert.AreEqual(desired, actualResult);
        }

        [TestMethod]
        public void CalorieIntakeCalculatorUnitTest3()
        {
            double height = 190;
            double actualWeight = 110;
            double age = 18;
            double desired = 2401.5;

            double actualResult = Class1.CalorieIntake(height, actualWeight, age);
            Assert.AreEqual(desired, actualResult);
        }

        [TestMethod]
        //FoodEntryMathTests
        public void FoodEntryCalculationsUnitTest1()
        {
            double Calories = 200;
            double Servings = 3;
            double desired = 600;
            
            double actualResult = Calories * Servings;
            Assert.AreEqual(desired, actualResult);
        }
        [TestMethod]
        public void FoodEntryCalculationsUnitTest2()
        {
            double Calories = 200; 
            double Servings = 3;
            double TotalCalories = Calories * Servings;
            double desired = 1200;
            
            double actualResult = TotalCalories += TotalCalories;
            Assert.AreEqual(desired, actualResult);
        }
        [TestMethod]
        public void FoodEntryCalculationsUnitTest3()
        {
            double Calories = 150;
            double Servings = 3;
            double desired = 450;

            double actualResult = Calories * Servings;
            Assert.AreEqual(desired, actualResult);
        }
        [TestMethod]
        public void FoodEntryCalculationsUnitTest4()
        {
            double Calories = 200;
            double Servings = 2;
            double TotalCalories = Calories * Servings;
            double desired = 800;

            double actualResult = TotalCalories += TotalCalories;
            Assert.AreEqual(desired, actualResult);
        }
        [TestMethod]
        public void FoodEntryCalculationsUnitTest5()
        {
            double Calories = 300;
            double Servings = 1;
            double desired = 300;

            double actualResult = Calories * Servings;
            Assert.AreEqual(desired, actualResult);
        }
   
        public void FoodEntryCalculationsUnitTest6()
        {
            double Calories = 500;
            double Servings = 1;
            double TotalCalories = Calories * Servings;
            double desired = 500;

            double actualResult = TotalCalories += TotalCalories;
            Assert.AreEqual(desired, actualResult);
        }

        [TestMethod]
        public void WeightToLooseCalculationsUnitTest1()
        {
            double ActualWeight = 500;
            double IdealWeight = 1;
            double WeightToLoose = ActualWeight - IdealWeight;
            double desired = 500;

            double actualResult = ActualWeight - IdealWeight;
            Assert.AreEqual(desired, actualResult);
        }

        [TestMethod]
        public void WeightToLooseCalculationsUnitTest2()
        {
            double ActualWeight = 200;
            double IdealWeight = 100;
            double WeightToLoose = ActualWeight - IdealWeight;
            double desired = 100;

            double actualResult = ActualWeight - IdealWeight;
            Assert.AreEqual(desired, actualResult);
        }

        [TestMethod]
        public void WeightToLooseCalculationsUnitTest3()
        {
            double ActualWeight = 275;
            double IdealWeight = 150;
            double WeightToLoose = ActualWeight - IdealWeight;
            double desired = 125;

            double actualResult = ActualWeight - IdealWeight;
            Assert.AreEqual(desired, actualResult);
        }

        [TestMethod]
        public void WeightToLooseCalculationsUnitTest4()
        {
            double ActualWeight = 260;
            double IdealWeight = 60;
            double WeightToLoose = ActualWeight - IdealWeight;
            double desired = 220;

            double actualResult = ActualWeight - IdealWeight;
            Assert.AreEqual(desired, actualResult);
        }

        [TestMethod]
        public void WeightToLooseCalculationsUnitTest5()
        {
            double ActualWeight = 500;
            double IdealWeight = 0;
            double WeightToLoose = ActualWeight - IdealWeight;
            double desired = 500;

            double actualResult = ActualWeight - IdealWeight;
            Assert.AreEqual(desired, actualResult);
        }
    }
}