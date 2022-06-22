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
    public class Method 
    {
        
        public string LoginMethod(string Username, string Password)
        {
            Elements ele = new Elements();           
            string title = ele.Element(Username,Password);
            return title;

        }
    }
}
