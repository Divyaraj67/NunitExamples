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

namespace NunitTest.Login
{
    public class Elements
    {

        public string Element(string username, string password)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            IWebElement UserID = driver.FindElement(By.Id("user-name"));
            UserID.SendKeys(username);
            IWebElement Password= driver.FindElement(By.Id("password"));
            Password.SendKeys(password);
            string title = driver.Title;
            return title;

        }
    }
}
