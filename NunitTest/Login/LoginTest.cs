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
    [TestFixture]
    public class LoginTest:Method
    {
        [SetUp]
        public void setup()
        {

        }

        [Test]

        [TestCase]

        [Description("Verify Login functionality with valid credentials")]
        public void TestLogin()
        {
            string Username = "standard_user";
            string Password = "secret_sauce";
            string title;
            title= LoginMethod(Username, Password); 
            StringAssert.AreEqualIgnoringCase("Swag Labs",title);           
        }
        
    }
}
