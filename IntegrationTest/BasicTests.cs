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

namespace IntegrationTest
{
    public class BasicTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        public BasicTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }
        //HomeControllerTests
        [Theory]
        [InlineData("/")]
        [InlineData("/Home")]
        [InlineData("/Home/Index")]
        [InlineData("/Home/Privacy")]
        [InlineData("/Home/Error")]
        public async Task GetHttpRequest(string url)
        {
            //Arrange
            var client = _factory.CreateClient();

            //Act 
            var response = await client.GetAsync(url);  

            //Assert
            response.EnsureSuccessStatusCode();
            Xunit.Assert.Equal("text/html; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }
    }


}
