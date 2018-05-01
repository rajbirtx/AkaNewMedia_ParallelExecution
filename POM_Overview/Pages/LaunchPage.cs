using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using AkaNewMedia.CommonRepository;
using AkaNewMedia.ElementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AkaNewMedia.Pages
{
    public class LaunchPage : GeneralMethod
    {
        public LaunchPage(IWebDriver dr)
            : base(dr)
        {

        }
        List<string> lst_detail;
        public DonatePage ClickDonateButton()
        {
            DonatePage donatePage=null;
            try
            {
                lst_detail = new List<string>();
                EnumClasses.LogStatus status = ClickOnElementWhenElementFound(GeneralDonation_Locator.DonateButton);
                MethodToAddDataInList("Click on DonateButton-" + status);
                donatePage = new DonatePage(driver);
                PageFactory.InitElements(driver, donatePage);
                ReportReader.AfterTest(System.Reflection.MethodBase.GetCurrentMethod().Name, lst_detail);
                return donatePage;
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
                return donatePage;
            }
        }
        /// <summary>
        /// Desc:Method is used to add data of all the items into the list
        /// </summary>
        /// <param name="_data"></param>
        /// <returns></returns>
        public string MethodToAddDataInList(string _data)
        {
            lst_detail.Add(_data);
            return _data;
        }
    }
}
