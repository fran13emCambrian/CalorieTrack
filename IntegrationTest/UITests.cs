using CalorieAppTrack;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using Xunit;
using CalorieAppTrack.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace IntegrationTest
{
    [TestClass]
    public class UITests
    {
        private IWebDriver _driver;
        [TestMethod]
        public void Startup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
        }

        [TestMethod]
        public void TestHomeTitle()
        {
            _driver.Navigate().GoToUrl("https://localhost:44383/");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Home Page", _driver.Title);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(_driver.Title.Contains("Home Page"));
        }

        [TestMethod]
        public void TestCalorieCalculatorPageTitle()
        {
            _driver.Navigate().GoToUrl("https://localhost:44383/CalorieCalculatorModels/Create");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Calorie Calculator", _driver.Title);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(_driver.Title.Contains("Calorie Calculator"));
        }

        [TestMethod]
        public void CalorieCalculatorLogPageTitle()
        {
            _driver.Navigate().GoToUrl("https://localhost:44383/CalorieCalculatorModels");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Calorie Calculator Log", _driver.Title);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(_driver.Title.Contains("Calorie Calculator Log"));
        }

        [TestMethod]
        public void PrivacyPageTitle()
        {
            _driver.Navigate().GoToUrl("https://localhost:44383/Home/Privacy");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Privacy", _driver.Title);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(_driver.Title.Contains("Privacy"));
        }

        [TestMethod]
        public void FoodDiaryPageTitle()
        {
            _driver.Navigate().GoToUrl("https://localhost:44383/FoodEntryModels");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Food Diary", _driver.Title);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(_driver.Title.Contains("Food Diary"));
        }

        public void RegisterPageTitle()
        {
            _driver.Navigate().GoToUrl("https://localhost:44383/Identity/Account/Register");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Register", _driver.Title);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(_driver.Title.Contains("Register"));
        }

        public void LoginPageTitle()
        {
            _driver.Navigate().GoToUrl("https://localhost:44383/Identity/Account/Login");
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Login", _driver.Title);
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(_driver.Title.Contains("Login"));
        }

    }
}
