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
using excel = Microsoft.Office.Interop.Excel;
using NPOI.XSSF.UserModel;

namespace NunitTest
{
   
    public class ReadExcel
    {
        [Test]
        public void readData()
        {
            string path = @"C:\Users\Atharva\Desktop\Data.xls";
            XSSFWorkbook workbook = new XSSFWorkbook(File.Open(path,FileMode.Open));
            var sheet = workbook.GetSheetAt(0);
            var row = sheet.GetRow(1);
            string username = row.GetCell(0).StringCellValue.Trim();
            string password = row.GetCell(1).StringCellValue.Trim();
            Console.WriteLine(username);
            Console.WriteLine(password);
        }
        
        
    }
}
