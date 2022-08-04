using CalorieTracker;
using CalculatorsLogic;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

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

        public void CalorieIntakeCalculatorUnitTest3()
        {
            double height = 190;
            double actualWeight = 110;
            double age = 18;
            double desired = 2401.5;

            double actualResult = Class1.CalorieIntake(height, actualWeight, age);
            Assert.AreEqual(desired, actualResult);
        }
    }
}