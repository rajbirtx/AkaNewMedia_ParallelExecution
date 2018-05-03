using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using AkaNewMedia.ElementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using AventStack.ExtentReports;
using NUnit.Framework;
using System.IO;
using System.Collections;
//using ICSharpCode.SharpZipLib.Zip;
using System.IO.Compression;
using System.Web;
using System.Threading;
//using OpenQA.Selenium.Remote;

namespace AkaNewMedia.CommonRepository
{
    public class GeneralMethod
    {
        public IWebDriver driver;
        public GeneralMethod(IWebDriver dr)
        {
            driver = dr;
        }

        public string ScenarioName = string.Empty;
        public string TestCaseName = string.Empty;
        public static string browserName = string.Empty;
        EnumClasses.LogStatus status;
        public void maximiseBrowser()
        {
            driver.Manage().Window.Maximize();
        }
        public void explicitWait(By aByElement, int aWaitTimeInSec)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(aWaitTimeInSec));
                wait.Until(ExpectedConditions.ElementIsVisible(aByElement));
            }
            catch (TimeoutException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void threadWait(int aWaitTimeInSec)
        {
            Thread.Sleep(aWaitTimeInSec);
        }
        public bool WaitUntillElementIsVisible(By aByeValue, int timeOut)
        {
            int iTimer = 0;
            while (iTimer <= timeOut)
            {
                bool status = IsElementVisible(aByeValue);
                if (status)
                    return true;
            }
            return false;
        }
        public void browserBackNavigation()
        {
            driver.Navigate().Back();
        }
        public void browserForwardNavigation()
        {
            driver.Navigate().Forward();
        }
        public String getAttributeOfWebelementByLocator(By aByValue, String aAttribute)
        {
            explicitWait(aByValue, 300);
            IWebElement element = driver.FindElement(aByValue);
            return element.GetAttribute(aAttribute);
        }
        public IWebElement getWebElementByLocator(By aBy)
        {
            explicitWait(aBy, 300);
            IWebElement webElement = driver.FindElement(aBy);
            return webElement;
        }
        public string getTextOfWebElementByLocator(By aWebElementID)
        {
            return getWebElementByLocator(aWebElementID).Text;
        }
        public IWebElement getElement(By locatorKey)
        {
            IWebElement e = null;
            try
            {
                e = driver.FindElement(locatorKey);
                e = driver.FindElement(locatorKey);
                e = driver.FindElement(locatorKey);
            }
            catch (Exception)
            {
                //   Assert.Fail("Failure in element extraction " + locatorKey);
            }
            return e;
        }
        public EnumClasses.LogStatus ClickOnElementWhenElementFound(By aByValue)
        {
            try
            {
                explicitWait(aByValue, 300);
                IWebElement webElement = getWebElementByLocator(aByValue);
                webElement.Click();
                return status = EnumClasses.LogStatus.Passed;
            }
            catch (Exception)
            {
                return status = EnumClasses.LogStatus.Failed;
            }
        }
        public EnumClasses.LogStatus SendKeysForElement(By aByValue, String aTestData)
        {
            try
            {
                driver.FindElement(aByValue).SendKeys(aTestData);
                return status = EnumClasses.LogStatus.Passed;
            }
            catch (ElementNotVisibleException e)
            {
                Console.WriteLine(e.ToString());
                return status = EnumClasses.LogStatus.Failed;
            }
            catch (Exception)
            {
                return status = EnumClasses.LogStatus.Failed;
            }
        }
        public EnumClasses.LogStatus SendKeysForWebElement(By aByValue, String aTestData)
        {
            try
            {
                driver.FindElement(aByValue).Clear();
                driver.FindElement(aByValue).SendKeys(aTestData);
                return status = EnumClasses.LogStatus.Passed;
            }
            catch (ElementNotVisibleException e)
            {
                Console.WriteLine(e.ToString());
                return status = EnumClasses.LogStatus.Warning;
            }
            catch (Exception)
            {
                return status = EnumClasses.LogStatus.Failed;
            }
        }
        public bool IsElementVisible(By aByValue)
        {
            try
            {
                IWebElement element = driver.FindElement(aByValue);
                if (element.Displayed)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public bool waitUntilElementNotVisible(By aByeValue, int timeOut)
        {

            int iTimer = 0;
            while (iTimer <= timeOut)
            {
                bool status = !(IsElementVisible(aByeValue));
                if (status)
                    return true;
            }
            return false;
        }
        public bool IsElementPresent(By aByValue)
        {
            try
            {
                driver.FindElement(aByValue);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public String selectValueFromDropdown(By aByValue, string value)
        {
            try
            {
                SelectElement oSelect = new SelectElement(driver.FindElement(aByValue));
                oSelect.SelectByText(value);
                return value;
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }
        public void mouseHover(By aByValue)
        {
            Actions act = new Actions(driver);
            act.MoveToElement(driver.FindElement(aByValue)).Click();
        }
        public string selectValueFromDropdownByText(By aByValue, string value)
        {
            try
            {
                SelectElement oSelect = new SelectElement(driver.FindElement(aByValue));
                oSelect.SelectByText(value);
                return value;
            }
            catch (NoSuchElementException)
            {
                return null;
            }
        }
        public int selectValueByIndex(By aByValue, int index)
        {
            try
            {
                SelectElement oSelect = new SelectElement(driver.FindElement(aByValue));
                oSelect.SelectByIndex(index);
                return index;
            }
            catch (NoSuchElementException)
            {
                return -1;
            }
        }
        public EnumClasses.LogStatus AssertAreEqual(By expected, string actual)
        {
            try
            {
                Assert.AreEqual(getTextOfWebElementByLocator(expected), actual);
                return status = EnumClasses.LogStatus.Passed;
            }
            catch (Exception)
            {
                return status = EnumClasses.LogStatus.Failed;
            }
        }
        public EnumClasses.LogStatus AssertIsTrue(By eWebElement)
        {
            try
            {
                Assert.IsTrue(IsElementVisible(eWebElement));
                return status = EnumClasses.LogStatus.Passed;
            }
            catch (Exception)
            {
                return status = EnumClasses.LogStatus.Failed;
            }
        }
        public EnumClasses.LogStatus AssertIsFalse(By eWebElement)
        {
            try
            {
                Assert.IsFalse(IsElementVisible(eWebElement));
                return status = EnumClasses.LogStatus.Passed;
            }
            catch (Exception)
            {
                return status = EnumClasses.LogStatus.Failed;
            }
        }
        public void jsClick(By aByValue)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", aByValue);
        }
        /// <summary>
        /// Desc:Method is used to capture the ScreenShots
        /// </summary>
        /// <returns></returns>
        public string ScreenShotCapture()
        {
            try
            {
                DirectoryInfo dirScreenshotPath = new DirectoryInfo(GetScreenshotPath());
                foreach (FileInfo fi in dirScreenshotPath.GetFiles())
                {
                    fi.Delete();
                }
                string filename = DateTime.Now.ToString().Replace("/", "_").Replace("-", "_").Replace(":", "_").Replace(" ", "_") + ".jpeg";
                string finalpath = @".\TestFramework\ResultReport\Screenshots\" + filename;
                ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
                Screenshot screenshot = screenshotDriver.GetScreenshot();
                screenshot.SaveAsFile(finalpath, ScreenshotImageFormat.Jpeg);
                finalpath = "Screenshots//" + filename;
                return finalpath;
            }
            catch (Exception e)
            {
                throw;
            }
        }
        /// <summary>
        /// Desc:Method is used to GetDrivers path
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
        /// Desc:Method is used to get generated report's path
        /// </summary>
        /// <returns></returns>
        public static string GetReportPath()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string reportPath = new Uri(actualPath).LocalPath;
            reportPath = reportPath + "ResultReport\\ExtentReport.html";
            return reportPath;
        }
        /// <summary>
        /// Desc:Method is used to Get Screenshot's Path
        /// </summary>
        /// <returns></returns>
        public static string GetScreenshotPath()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string screenshotPath = new Uri(actualPath).LocalPath;
            screenshotPath = screenshotPath + @"ResultReport\Screenshots";
            return screenshotPath;
        }
        /// <summary>
        /// Desc:Method is used to Get Report Folder's Path
        /// </summary>
        /// <returns></returns>
        public static string GetReportFolderPath()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string reportPath = new Uri(actualPath).LocalPath;
            reportPath = reportPath + "ResultReport";
            return reportPath;
        }
        /// <summary>
        /// Desc:Method is used to Get zip Folder's Path
        /// </summary>
        /// <returns></returns>
        public static string GetZipFolderPath()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string reportPath = new Uri(actualPath).LocalPath;
            reportPath = reportPath + "ZipFolder";
            return reportPath;
        }
        /// <summary>
        /// Desc:Method is used to set report into zip file
        /// </summary>
        /// <returns></returns>
        public static void createZipFile()
        {
            string reportPath = GetReportFolderPath();
            string zipFilePath = GetZipFolderPath();
            bool exists = System.IO.Directory.Exists(reportPath);
            if (!exists)
                System.IO.Directory.CreateDirectory(reportPath);
            addIntoZip(reportPath, zipFilePath);
        }
        public static void addIntoZip(string directoryPath, string zipFilePath)
        {
            DirectoryInfo dirZipPath = new DirectoryInfo(zipFilePath);
            foreach (FileInfo fi in dirZipPath.GetFiles())
            {
                fi.Delete();
            }
            ZipFile.CreateFromDirectory(directoryPath, Path.Combine(zipFilePath, "ExtentReport.zip"), CompressionLevel.Optimal, true);
        }

        /// <summary>
        /// Desc:Method is used to GetExcel path
        /// </summary>
        /// <returns></returns>
        public void MethodtToOpenNewtab()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Navigate().GoToUrl("https://google.com");
        }
    }
}
