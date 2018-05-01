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
    public class DonatePage : GeneralMethod
    {
        public DonatePage(IWebDriver dr)
            : base(dr)
        {

        }
        public GeneralDonationPage ClickOnGeneralButtonAndContinue()
        {
            ClickOnElementWhenElementFound(GeneralDonation_Locator.rdo_GeneralDonation);
            ClickOnElementWhenElementFound(GeneralDonation_Locator.btn_Continue);
            GeneralDonationPage generalDonationPage = new GeneralDonationPage(driver);
            PageFactory.InitElements(driver, generalDonationPage);
            return generalDonationPage;
        }
        public InHonourDonationPage ClickOnInHonourButtonAndContinue()
        {
            ClickOnElementWhenElementFound(GeneralDonation_Locator.InHonourButton);
            ClickOnElementWhenElementFound(GeneralDonation_Locator.btn_Continue);
            InHonourDonationPage inHonourPage = new InHonourDonationPage(driver);
            PageFactory.InitElements(driver, inHonourPage);
            return inHonourPage;
        }
    }
}
