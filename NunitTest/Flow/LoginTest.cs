using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTest.Flow
{
    [TestFixture]
    public class LoginTest :LoginPage
    {
        string validuserId = "standard_user";
        string validpass = "secret_sauce";


        [SetUp]
        public void setup()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }
        [Test,Order(1)]
        [TestCase(TestName = "TC105")]
        [Description("Verify Login functionality with valid credentials")]
        public void loginWithValidCreds()
        {
            string expectedTitle = "Swag Labs";
            string expectedUrl = "https://www.saucedemo.com/inventory.html";
            userLogin(validuserId, validpass, out var actualUrl);
            getTitle(out var actualtitle);

            Assert.IsNotNull(title, "titile should not be null");
            Assert.AreEqual(actualtitle, expectedTitle, "actual title and expected title should be same");
            Assert.That(actualUrl, Is.EqualTo(expectedUrl), "actual Ural and expected Url should match");
        }




    }
}
