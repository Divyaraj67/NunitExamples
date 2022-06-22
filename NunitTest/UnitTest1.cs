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

namespace NunitTest
{
    [TestFixture]
    public class FIrstTest
    {

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
             driver = new ChromeDriver();
           
        }

        [Test, Order(2)]
        
        public void Test1()
        {
            driver.Url = "https://demoqa.com/";
            Actions action = new Actions(driver);
            IWebElement elementsBtn = driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div/div[1]/div/div[1]"));
            elementsBtn.Click();
            Thread.Sleep(2000);
            IWebElement buttonsBtn = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[5]/span"));
            buttonsBtn.Click();
            Thread.Sleep(2000);
            WebElement btndblclick = (WebElement)driver.FindElement(By.Id("doubleClickBtn"));
            action.DoubleClick(btndblclick).Perform();
            Thread.Sleep(2000);
            WebElement rgtclick = (WebElement)driver.FindElement(By.Id("rightClickBtn"));
            action.ContextClick(rgtclick).Perform();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/button")).Click();
            Thread.Sleep(2000);

            Assert.Pass();
        }

        [Test, Order(1)]
        public void Test2()
        {
            driver.Url = "https://demoqa.com/";
            Actions action = new Actions(driver);
            IWebElement elementsBtn = driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div/div[1]/div/div[1]"));
            elementsBtn.Click();
            Thread.Sleep(2000);
            IWebElement ChkBtn = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[2]/span"));
            ChkBtn.Click();
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div/div/button[1]")).Click(); ///This is absoute Xpath and above all are relative Xpath
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[1]/ol/li/ol/li[2]/span/label/span[1]")).Click();//selects document
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[1]/ol/li/ol/li[2]/ol/li[1]/ol/li[1]/span/label/span[1]")).Click();//unselects react
            Thread.Sleep(2000);
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[1]/ol/li/ol/li[2]/ol/li[2]/ol/li[2]/span/label/span[1]")).Click();//deselects private
            Thread.Sleep(2000);
        }

        [TearDown]
        
        public void Teardown()
        {
            driver.Quit();
        }
    }
}