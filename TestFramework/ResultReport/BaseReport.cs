using AkaNewMedia.CommonRepository;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.ResultReport
{
    public class BaseReport
    {
        public ExtentReports extent;
        public ExtentTest test;
        public TestContext testcontext = null;
        public string date = DateTime.Now.ToString("yyyyMMddTHHmmss");

        string BrowserName = ConfigurationManager.AppSettings["BrowserName"];
        string screenShotPath;
        [SetUp]
        public void StartReport()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            string ts = date;
            string reportPath = projectPath + "Results\\AnicitusReport.html";
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Host Name", "ANICITUS");
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("User Name", "Suneetha");
            extent.AddSystemInfo("Browser Name", BrowserName);
            //extent.LoadConfig(projectPath + "extent-config.xml");
        }

        public void ReportPass(string methodname, string category)
        {
            try
            {
                //StartReport();

                test = extent.CreateTest(methodname);
                test.AssignCategory(category);
                Assert.IsTrue(true);
                test.Log(Status.Pass, methodname + " PASSED");
                string screenshotname = DateTime.Now.ToString("yyyy-MM-dd-THHmmss");
               // screenShotPath = GeneralMethod.ScreenShotCapture(screenshotname);
                // test.Log(Status.Pass, test.AddScreenCaptureFromPath(screenShotPath));
               // GetResult();
                EndReport();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public void ReportFail(string methodname, string category)
        {
            try
            {
                //StartReport();
                test = extent.CreateTest(methodname);
                test.AssignCategory(category);
                Assert.IsTrue(true);
                test.Log(Status.Fail, methodname + " FAILED");
                string screenshotname = DateTime.Now.ToString("yyyy-MM-dd-THHmmss");
             //   screenShotPath = GeneralMethod.ScreenShotCapture(screenshotname);
                // test.Log(Status.Fail, test.AddScreenCaptureFromPath(screenShotPath));
               // GetResult();
                EndReport();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
  
        public void EndReport()
        {
            extent.Flush();

        }

        internal void ReportPass(object editingUser)
        {
            throw new NotImplementedException();
        }

    }
}
