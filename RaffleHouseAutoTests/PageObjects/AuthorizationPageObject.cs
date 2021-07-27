using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseAutoTests.PageObjects
{
    class AuthorizationPageObject
    {
        private IWebDriver _driver;

        private readonly By _emailInput = By.XPath(".//*[@name='email']");
        private readonly By _passwordInput = By.XPath(".//*[@name='password']");
        private readonly By _loginButton = By.XPath(".//*[@class='rafflebtn primary full-width']");

        public AuthorizationPageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public HomePageObjects SignIn(string login, string password)
        {
            _driver.FindElement(_emailInput).SendKeys(login);
            _driver.FindElement(_passwordInput).SendKeys(password);
            _driver.FindElement(_loginButton).Click();
            return new HomePageObjects(_driver);
        }

    }
}
