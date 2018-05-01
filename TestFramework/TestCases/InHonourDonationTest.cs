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
using TestFramework.ResultReport;

namespace TestFramework.TestCases
{
    [TestFixture]
    [Parallelizable]
    public class InHonourDonationTest : BaseTest
    {
        [Test, TestCaseSource("getData")]
        public void inHonourDonation(Dictionary<string, string> data)
        {
            DataRow dataRow = DriverInitialization(data, EnumClasses.SheetNames.InHonourDonation.ToString());
            LaunchPage lPage = new LaunchPage(driver);
            PageFactory.InitElements(driver, lPage);
            DonatePage donatePage = lPage.ClickDonateButton();
            InHonourDonationPage inHonourDonationPage = donatePage.ClickOnInHonourButtonAndContinue();
            inHonourDonationPage.fillMandatoryFields(dataRow);
            inHonourDonationPage.fillTributeDetails(dataRow);
            inHonourDonationPage.fillRecipientDetails(dataRow);
            inHonourDonationPage.verifyInHonourData(dataRow);
        }
        public static object[] getData()
        {
            return DataUtil.getData(xls, EnumClasses.SheetNames.InHonourDonation.ToString());
        }
    }
}