using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using AkaNewMedia.CommonRepository;
using AkaNewMedia.ElementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaNewMedia.Pages
{
    public class LaunchPage : GeneralMethod
    {
        public LaunchPage(IWebDriver dr)
            : base(dr)
        {

        }
        public DonatePage ClickDonateButton()
        {
            ClickOnElementWhenElementFound(GeneralDonation_Locator.DonateButton);
            DonatePage donatePage = new DonatePage(driver);
            PageFactory.InitElements(driver, donatePage);
            return donatePage;
        }
    }
}
