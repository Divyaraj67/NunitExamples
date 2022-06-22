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
  
    public class TestOnetimes
    {
        //When we use Parallelizable , always non-parallelizable gets executed first and then parallels



        [OneTimeSetUp]
        public void Setup()
        {
            IWebDriver driver;
            driver = new ChromeDriver();

        }

        [Test,Order(1)]
        //[Parallelizable(scope:ParallelScope.Self)]

        //public void Test3()
        //{
           
        //    driver.Url = "https://demoqa.com/";
        //    Actions action = new Actions(driver);
        //    IWebElement elementsBtn = driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div/div[1]/div/div[1]"));
        //    elementsBtn.Click();
        //    Thread.Sleep(2000);
        //    IWebElement buttonsBtn = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[5]/span"));
        //    buttonsBtn.Click();
        //    Thread.Sleep(2000);
        //    WebElement btndblclick = (WebElement)driver.FindElement(By.Id("doubleClickBtn"));
        //    action.DoubleClick(btndblclick).Perform();
        //    Thread.Sleep(2000);
        //    WebElement rgtclick = (WebElement)driver.FindElement(By.Id("rightClickBtn"));
        //    action.ContextClick(rgtclick).Perform();
        //    Thread.Sleep(2000);
        //    driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/button")).Click();
        //    Thread.Sleep(2000);

        //    bool rghtClk = driver.FindElement(By.Id("rightClickMessage")).Displayed;
        //    Assert.IsTrue(rghtClk);

        //    string check = driver.FindElement(By.Id("rightClickMessage")).Text;
        //    StringAssert.AreEqualIgnoringCase("", check);

        //    object typechk = driver.FindElement(By.Id("rightClickMessage")).Text;
        //    Assert.IsInstanceOf(typeof(string), typechk);
        //}

        //[Test,Order(2)]
        //[Parallelizable(scope: ParallelScope.Self)]

        //[Ignore("Ignore this test")]
        public void Test4()
        {
            IWebDriver driver;
            driver = new ChromeDriver();
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


        [Test,Order(3)]
        public void test5()
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/alerts");

            IWebElement Simple = driver.FindElement(By.XPath("//*[@id='alertButton']"));
            Simple.Click();
            Thread.Sleep(2000);
            IAlert simpleAlert = driver.SwitchTo().Alert();
            simpleAlert.Accept();

            Thread.Sleep(2000);

            IWebElement Confirm = driver.FindElement(By.XPath("//*[@id='confirmButton']"));
            Confirm.Click();
            Thread.Sleep(2000);
            IAlert ConfirmAlert = driver.SwitchTo().Alert();
            //ConfirmAlert.Accept();
            ConfirmAlert.Dismiss();
            Thread.Sleep(2000);
        }

        [OneTimeTearDown]

        public void Teardown()
        {
           
        }
    }
}
