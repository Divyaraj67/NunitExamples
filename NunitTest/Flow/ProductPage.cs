using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NunitTest.Flow
{
    public class ProductPage
    {
        


        IWebDriver driver = new ChromeDriver();

        #region Elements
        private IWebElement productOne => driver.FindElement(By.Id(""));
        private IWebElement productTwo => driver.FindElement(By.Id(""));
        private IWebElement cartIcon => driver.FindElement(By.Id(""));
        public string Url => driver.Url;
        public string title => driver.Title;
        #endregion Elements

        #region Methods
        public void productSelection(out string currentUrl)
        {
            productOne.Click();
            productTwo.Click();
            cartIcon.Click();
            currentUrl = Url;
        }
        #endregion Methods
    }
}
