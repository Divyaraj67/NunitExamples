using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NunitTest.Login2
{
    [TestFixture]
    public class TestLogin : Page
    {

        string validuserId = "standard_user";
        string validpass = "secret_sauce";


        [SetUp]
        
        public void setup()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Test]
        [TestCase(TestName = "TC101")]
        [Description("Verify Login functionality with valid credentials")]
        
        public void loginWithValidCreds()
        {
            string expectedTitle = "Swag Labs";
            string expectedUrl = "https://www.saucedemo.com/inventory.html";

            /*
             string webSite= objPage.getTitle();
             StringAssert.AreEqualIgnoringCase("Swag Labs", webSite);
             Console.WriteLine("Title matches");


             string urlAfterLogin= objPage.UserLogin(userId,pass);
             StringAssert.IsMatch("https://www.saucedemo.com/inventory.html", urlAfterLogin);
             Console.WriteLine("User has successfully logged in and redirected to inventory page");
             Thread.Sleep(2000); */


            UserLogin(validuserId, validpass, out var actualUrl);
            getTitle(out var actualtitle);

            Assert.IsNotNull(title, "titile should not be null");
            Assert.AreEqual(actualtitle, expectedTitle, "actual title and expected title should be same");
            Assert.That(actualUrl, Is.EqualTo(expectedUrl), "actual Ural and expected Url should match");
        }

        
        [TearDown]
        public void tearDown()
        {
            driver.Quit();
        }

    }
}
