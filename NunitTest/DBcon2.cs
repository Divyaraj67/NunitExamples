using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Data.SqlClient;
using System.Data;

namespace NunitTest
{
    public class DBtest2
    {

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

        }

        [Test]
        public void DataCheck()
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
            if (sdr.Read())
            {
               // Console.WriteLine("Required data is available");

            }
            else
            {
                //Console.WriteLine("No Data available");
            }
            int UserID = sdr.GetOrdinal("UserID");
            string LoginId = sdr.GetString(UserID);
            int Password = sdr.GetOrdinal("Password");
            string LoginPwd = sdr.GetString(Password);

            string Username = "Divyaraj";
            string Pwd = "Dev123";

           StringAssert.AreEqualIgnoringCase(Username,LoginId,"UserID Do not match");
           
            StringAssert.AreEqualIgnoringCase(LoginPwd, Pwd,"Password Do not match ");
        }
    }
}
