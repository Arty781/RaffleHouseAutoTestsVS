using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RaffleHouseAutoTests.PageObjects;

namespace RaffleHouseAutoTests
{
    [TestFixture]
    public class RaffleHouseAutoTests : BaseTest
    {


        [Test]
        public void BasicSignInBehavior()
        {

            var mainHome = new HomePageObjects(_driver);
            mainHome
                .clickSignInButton()
                .SignIn(CredentialsForTest.StartLogin, CredentialsForTest.startPassword);
        }


    }
}
