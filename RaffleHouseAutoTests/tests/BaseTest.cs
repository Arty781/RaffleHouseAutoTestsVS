using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace RaffleHouseAutoTests
{
    public class BaseTest
    {
        public IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://staging.rafflehouse.com/");
        }

        [TearDown]

        public void TearDown()
        {
            _driver.Quit();
        }
    }


}

