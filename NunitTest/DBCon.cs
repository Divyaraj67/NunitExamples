using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Data.SqlClient;
using System.Data;


namespace NunitTest
{
   public class DBtest
    {

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

        }

        [Test]
       public void DatabaseTest()
        {
            string connectionString = "data source=.; database=EmployeeMgtSys; Integrated Security=SSPI";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            Console.WriteLine("Connection to Database established");
            string str;
            str = "select * from tblTestSelenium";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader sdr = cmd.ExecuteReader();
            if(sdr.Read())
            {
                Console.WriteLine("Required data is available");

            }
            else
            {
                Console.WriteLine("No Data available");
            }
                int UserID = sdr.GetOrdinal("UserID");
                string LoginId = sdr.GetString(UserID);
                int Password = sdr.GetOrdinal("Password");
                string LoginPwd = sdr.GetString(Password);

            driver.Url = "http://www.testyou.in/Login.aspx";

            IWebElement LoginID = driver.FindElement(By.XPath("//*[@id='ctl00_CPHContainer_txtUserLogin']"));
            LoginID.SendKeys(LoginId);

            IWebElement Pwd = driver.FindElement(By.XPath("//*[@id='ctl00_CPHContainer_txtPassword']"));
            Pwd.SendKeys(LoginPwd);

        }
    }
}
