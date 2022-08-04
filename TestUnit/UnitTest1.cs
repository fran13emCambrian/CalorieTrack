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
    }
}