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
using Docker.DotNet.Models;

namespace NunitTest
{
    internal class Screenshot
    {
        IWebDriver driver = new ChromeDriver();
        [Test]
        public void screenshotTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ("https://www.saucedemo.com/");
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Test.png", ScreenshotImageFormat.Png);
            
            driver.Quit();
        }

        [Test]
        public void SSonException()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = ("https://www.saucedemo.com/");

            IWebElement username = driver.FindElement(By.Id("user-name"));
            IWebElement password = driver.FindElement(By.Id("password"));
            IWebElement loginBtn = driver.FindElement(By.Id("login-button"));
            username.SendKeys("standard_user");
            password.SendKeys("secret_sauce");
            loginBtn.Click();

            try
            {
                IWebElement cart = driver.FindElement(By.XPath("//*[@id='shopping_cart_contner']/a"));
            }
            catch(Exception ex)
            {
                ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Exception.png", ScreenshotImageFormat.Png);
            }
            driver.Quit();
        }

        [Test]
        public void SSTearDown()
        {
            
            driver.Url = ("https://www.saucedemo.com/");

            IWebElement username = driver.FindElement(By.Id("user-name"));
            IWebElement password = driver.FindElement(By.Id("password"));
            IWebElement loginBtn = driver.FindElement(By.Id("login-button"));
            username.SendKeys("standard_user");
            password.SendKeys("secret_sauce");
            loginBtn.Click();

            
            
        }
        [TearDown]
        public void teardown()
        {
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Teardown.png", ScreenshotImageFormat.Png);
            driver.Quit();
        }
    }
}
