using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaNewMedia.ElementRepository
{
    public class InHonourDonation_Locator
    {
        public static By Amount = By.XPath("//*[@id='ctl00_contentAmount_ucAmount_rdoDonationAmount']/label[5]");

        public static By InHonourMonth = By.XPath("//select[@id='ctl00_contentAmount_ucAmount_lstStartMonth']");
        public static By InHonourDay = By.XPath("//select[@id='ctl00_contentAmount_ucAmount_lstStartDay']");

        public static By NumberOfTimesRadio = By.XPath("//*[@id='ctl00_contentAmount_ucAmount_rdoSpecificNumberOfTimes']");
        public static By NumberOfTimesText = By.XPath("//tr[@id='ctl00_contentAmount_ucAmount_trSpecificTimes']/td[2]/input");
        public static By FundAllocation = By.XPath("//input[@id='ctl00_contentAmount_ucAmount_radComboBoxFundType_Input']");

        public static By InHonourButton = By.XPath("//input[@id='ctl00_content_ucDonationType_rbInHonour']");
        public static By HonourFirstName = By.XPath("//input[@id='ctl00_contentTributee_ucTributeInHonour_txtFirstName']");
        public static By HonourLastName = By.XPath("//input[@id='ctl00_contentTributee_ucTributeInHonour_txtLastName']");
        public static By eCardType = By.XPath("//input[@id='ctl00_contentCardType_ucCardType_lstCardType_0']");
        public static By ContinueCardType = By.XPath("//input[@id='ctl00_contentCardType_ucCardType_btnContinue']");
        public static By RecipientFirstName = By.XPath("//input[@id='ctl00_content_ucCardDetail_ucECardDetail_ucRecipients_txtFirstName']");
        public static By RecipientLastName = By.XPath("//input[@id='ctl00_content_ucCardDetail_ucECardDetail_ucRecipients_txtLastName']");
        public static By RecipientEmail = By.XPath("//input[@id='ctl00_content_ucCardDetail_ucECardDetail_ucRecipients_txtEmail']");
        public static By AddButton = By.XPath("//input[@id='ctl00_content_ucCardDetail_ucECardDetail_ucRecipients_btnAddRecipient']");
        public static By Image1 = By.XPath("//*[@id='ctl00_content_ucCardDetail_ucECardDetail_ucTemplates_repCards_ctl01_imgPreview']");
        public static By ImageVerify = By.XPath("//*[@id='ecard-contents']/table/tbody/tr/td[1]/img");
        public static By CloseImagePopup = By.XPath("//div[@id='fancybox-overlay']");
        public static By ImageScroller = By.XPath("//*[@id='ecard_scroller']/a[2]/img");
        public static By Image6 = By.XPath("//*[@id='items']/ul/li[6]/span/label");
        public static By TextColorPicker = By.XPath("//*[@id='ctl00_content_ucCardDetail_ucECardDetail_ucTemplates_clrText_label']/a");
        public static By GreyColor = By.XPath("//div[@id='ctl00_content_ucCardDetail_ucECardDetail_ucTemplates_clrText_webPalette']/ul[@class='rcpWebPalette']/li[9]/a/span");
        public static By SampleMessageDropdown = By.XPath("//*[@id='ctl00_content_ucCardDetail_ucECardDetail_ucPersonalization_ddlPersonalizedMessage']");
        public static By MessageTextArea = By.XPath("//table[@id='ctl00_content_ucCardDetail_ucECardDetail_ucPersonalization_edtPersonalizedCustomMessageWrapper']/tbody/tr[3]/td/textarea");
        //*[@id="ctl00_content_ucCardDetail_ucECardDetail_ucPersonalization_edtPersonalizedCustomMessageCenter"]/textarea
        public static By NotifyOption = By.XPath("//input[@id='ctl00_content_ucCardDetail_ucECardDetail_ucOptions_chkNotifyOpened']");
        public static By SaveContinueButton = By.XPath("//input[@id='ctl00_content_ucCardDetail_btnContinue']");
        public static By ProcessPaymentButton = By.XPath("//input[@id='ctl00_content_ucDonationReview_btnContinue']");

        public static By FundAllocationText = By.XPath("//*[@id='ctl00_content_ucDonationReview_ucAmount_lblFund']");
        public static By CountryText = By.XPath("//*[@id='ctl00_content_ucDonationReview_ucProfile_lblCountry']");
        public static By EmailText = By.Id("ctl00_content_ucDonationReview_ucProfile_lblEmail");
        public static By StateText = By.XPath("//*[@id='ctl00_content_ucDonationReview_ucProfile_lblProvince']");
        public static By Address1Text = By.XPath("//*[@id='ctl00_content_ucDonationReview_ucProfile_lblAddressLine1']");
        public static By CityText = By.XPath("//*[@id='ctl00_content_ucDonationReview_ucProfile_lblCity']");
        public static By PostalText = By.XPath("//*[@id='ctl00_content_ucDonationReview_ucProfile_lblPostalCode']");
        public static By CardHolderText = By.XPath("//*[@id='ctl00_content_ucDonationReview_ucPayment_ucCardPayment_lblCardHolder']");
        public static By TributeHonourNameText = By.XPath("//*[@id='ctl00_content_ucDonationReview_ucTribute_lblName']");
        //public static By ProcessPaymentButton = By.XPath("//*[@id='ctl00_content_ucDonationReview_btnContinue']");
    }
}
