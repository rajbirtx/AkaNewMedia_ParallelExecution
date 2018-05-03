using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using AkaNewMedia.CommonRepository;
using AkaNewMedia.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Web;

namespace TestFramework.TestCases
{
    [TestFixture]
    [Parallelizable]
    public class GeneralDonationTest : BaseTest
    {
        [Test, TestCaseSource("getData")]
        public void generalDonation(Dictionary<string, string> data)
        {
            try
            {
                ExtentTestManager.CreateParentTest(GetType().Name + '-' + data["browsername"].ToString());
                DataRow dataRow = DriverInitialization(data, EnumClasses.SheetNames.GeneralDonation.ToString());
                LaunchPage lPage = new LaunchPage(driver);
                PageFactory.InitElements(driver, lPage);
                DonatePage donatePage = lPage.ClickDonateButton();
                GeneralDonationPage generalDonationPage = donatePage.ClickOnGeneralButtonAndContinue();
                generalDonationPage.FillMandatoryFields(dataRow);
                generalDonationPage.VerifyAllTheFiledsAndClickOnEdit(dataRow);
                generalDonationPage.UpdateSomeFieldsAndContinue(dataRow);
                generalDonationPage.VerifyTheFieldsAndClickonPaymentProcess(dataRow);
                generalDonationPage.VerifyTheTransectionCodeVisible();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
        public static object[] getData()
        {
            try
            {
                return DataUtil.getData(xls, EnumClasses.SheetNames.GeneralDonation.ToString());
            }
            catch (Exception)
            {
                throw;
            }
        }
        [TearDown]
        protected void TearDown()
        {
            ExtentManager.Instance.Flush();
            driver.Quit();
        }
    }
}
