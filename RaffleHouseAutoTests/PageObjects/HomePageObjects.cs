using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaffleHouseAutoTests.PageObjects
{
    class HomePageObjects
    {
        private IWebDriver _driver;

        private readonly By _signInButton = By.XPath(".//*[@class='btnSignInHeader']");

        private readonly string login = "qatester91311@gmail.com";
        private readonly string password = "Qaz11111";

        public string Login => login;

        public string Password => password;

        public HomePageObjects(IWebDriver driver)
        {
            _driver = driver;
        }

        public AuthorizationPageObject clickSignInButton()
        {
            _driver.FindElement(_signInButton).Click();

            return new AuthorizationPageObject(_driver);
        }


    }
}
