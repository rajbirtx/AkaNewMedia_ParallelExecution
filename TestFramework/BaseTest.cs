using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using AkaNewMedia.CommonRepository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using NUnit.Framework;
using TestFramework.ResultReport;
using NUnit.Framework.Interfaces;
using AventStack.ExtentReports;


namespace TestFramework
{

    public class BaseTest
    {
        //public BaseTest(IWebDriver dr) : base(dr) { }
       
        public IWebDriver driver;
        public ExtentTest test;
        DataTable dt;
        DataRow datarow;
        static string ExcelPath = GetExcelPath();
        public static ExcelReaderUsingNPOI xls = new ExcelReaderUsingNPOI(ExcelPath.ToString());

        /// <summary>
        /// Desc:Method is used to get driver's path
        /// </summary>
        /// <returns></returns>
        public string GetDriversPath()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string driverPath = new Uri(actualPath).LocalPath;
            driverPath = driverPath + "Drivers";
            return driverPath;
        }

        /// <summary>
        /// Desc:Method is used to GetExcel path
        /// </summary>
        /// <returns></returns>
        public static string GetExcelPath()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string excelPath = new Uri(actualPath).LocalPath;
            excelPath = excelPath + "ExcelSheet\\Aka_Excel_Sheet.xlsx";
            return excelPath;
        }
        /// <summary>
        /// Desc:Method is used to initializatied the driver
        /// </summary>
        /// <param name="data"></param>
        /// <param name="testCaseName"></param>
        /// <returns></returns>
        public DataRow DriverInitialization(Dictionary<string, string> data, string testCaseName)
        {
            DataRow dr = null;
            ExcelReaderUsingOleDb excelReader = new ExcelReaderUsingOleDb();
            dt = excelReader.ReadExcelData(EnumClasses.SheetNames.TestCases.ToString());
            if (dt.Rows.Count > 0)
            {
                datarow = dt.Select("testcaseid =" + data["testcaseid"]).FirstOrDefault();
                DataTable dt1 = excelReader.ReadExcelData(testCaseName);
                dr = dt1.Select("testcaseid =" + datarow["testcaseid"].ToString() + "AND id=" + data["id"].ToString()).FirstOrDefault();

                string BrowserName = dr["browsername"].ToString();
                string Url = ConfigurationManager.AppSettings["Url"];
                string driverPath = GetDriversPath();
                if (BrowserName == EnumClasses.BrowserName.ie.ToString())
                {
                    var options = new InternetExplorerOptions();
                    options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    driver = new InternetExplorerDriver(options);
                    driver = new InternetExplorerDriver(driverPath);
                }
                else if (BrowserName == EnumClasses.BrowserName.firefox.ToString())
                {
                    FirefoxProfileManager Manager = new FirefoxProfileManager();
                    FirefoxProfile profile = Manager.GetProfile("Default");
                    FirefoxDriverService Services = FirefoxDriverService.CreateDefaultService(driverPath);
                    FirefoxOptions option = new FirefoxOptions();
                    option.Profile = profile;
                    driver = new FirefoxDriver(Services, option, TimeSpan.FromSeconds(60));
                }
                else if (BrowserName == EnumClasses.BrowserName.chrome.ToString())
                {
                    driver = new ChromeDriver(driverPath);
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments("--start-maximized");
                }
                else
                {
                    driver = new ChromeDriver(driverPath);
                }
                driver.Navigate().GoToUrl(Url);
                System.Threading.Thread.Sleep(100);
                driver.Manage().Window.Maximize();
            }
            return dr;
        }

        [OneTimeSetUp]
        public void Setup()
        {
            ExtentTestManager.CreateParentTest(GetType().Name);
        }

        
    }
}
