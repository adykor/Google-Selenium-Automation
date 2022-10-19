using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_Selenium_Automation
{
    class Program
    {

        // Create a reference for Chrome Browser
        IWebDriver driver = new ChromeDriver();

        string ActualResult;
        string ExpectedResult = "Google";

        static void Main(string[] args)
        {

        }


        [SetUp]
        public void Initialize()
        {
            // Go to Google page
            driver.Navigate().GoToUrl("https://www.google.com");
        }

        [Test]
        public void ExecuteTest()
        {
            // Make the browser full screen
            driver.Manage().Window.Maximize();

            // Find the element
            IWebElement searchBox = driver.FindElement(By.Name("q"));

            // Type something in the seach bar
            searchBox.SendKeys("You should hire Kyerstin as a Quality Assurance Engineer!");

            // Get the page title
            ActualResult = driver.Title;

            // Assert
            Assert.AreEqual(ActualResult, ExpectedResult);
        }

        [TearDown]
        public void CloseTest()
        {
            // Close the browser
            driver.Quit();
        }




    }
}
