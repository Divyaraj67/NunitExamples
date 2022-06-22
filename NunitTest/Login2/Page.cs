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

namespace NunitTest.Login2
{
    public class Page
    {
        #region Elements
        
        public  IWebDriver driver = new ChromeDriver();

        By username = By.Id("user-name");
        
        private IWebElement Username => driver.FindElement(By.Id("user-name"));
        private IWebElement Password => driver.FindElement(By.Id("password"));
        private IWebElement LoginBtn => driver.FindElement(By.Id("login-button"));
        public string title => driver.Title;
        public string Url => driver.Url;
        #endregion Elements

        #region Methods

        public void UserLogin(string UserID,string Pass, out string currneturl)
        {
            IWebElement LoginBtn1 = driver.FindElement(By.Id("login-button"));
            Username.SendKeys(UserID);
            Password.SendKeys(Pass);
            LoginBtn.Click();
            currneturl = Url;
               
        }
        public void getTitle(out string pagetitle)
        {
            pagetitle = title;
            //return pagetitle;
        }
        #endregion

    }
}
