using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaNewMedia.ElementRepository
{
    public class GeneralDonation_Locator
    {
        //Homepage Elements
        public static By DonateButton = By.XPath("//*[@id='raisinRegion_89']/table/tbody/tr[2]/td/a/img");
        public static By InHonourButton = By.XPath("//input[@id='ctl00_content_ucDonationType_rbInHonour']");

        //General Donation Page Elements
        public static By rdo_GeneralDonation = By.Id("ctl00_content_ucDonationType_rbGeneral");
        public static By rdo_Tribute_InHoner = By.Id("ctl00_content_ucDonationType_rbInHonour");
        public static By rdo_Tribute_InMemory = By.Id("ctl00_content_ucDonationType_rbInMemory");
        public static By btn_Continue = By.Id("ctl00_content_ucDonationType_btnContinue");

        //FirstPage  Donation Information        
        public static By btn_OneTimeDonationType = By.XPath("//table[@class='donation-btn-container']/tbody/tr/td/a[@id='ctl00_contentAmount_ucAmount_btnOneTimeDonation']");
        public static By btn_RecurringDonationType = By.Id("ctl00_contentAmount_ucAmount_btnRepeatingDonation");
        public static By ddl_DonationFrequency = By.Id("ctl00_contentAmount_ucAmount_ddlDonationFrequency");
        public static By Selected_Frequency = By.XPath("//*[@id='ctl00_contentAmount_ucAmount_ddlDonationFrequency']/option[2]");
        public static By rdo_DonationAmount_1 = By.XPath("//*[@id='ctl00_contentAmount_ucAmount_rdoDonationAmount']/label[1]");
        public static By rdo_Amount = By.XPath("//*[@id='ctl00_contentAmount_ucAmount_rdoDonationAmount']/label[2]");
        public static By lst_StartMonth = By.Id("ctl00_contentAmount_ucAmount_lstStartMonth");
        public static By ddl_April = By.XPath("//*[@id='ctl00_contentAmount_ucAmount_lstStartMonth']/option[2]");
        public static By lst_Day = By.Id("ctl00_contentAmount_ucAmount_lstStartDay");
        public static By ddl_date1 = By.XPath("//*[@id='ctl00_contentAmount_ucAmount_lstStartDay']/option[2]");
        public static By lst_StartYear = By.Id("ctl00_contentAmount_ucAmount_lstStartYear");
        public static By rdo_OngoingUntilINotify = By.Id("ctl00_contentAmount_ucAmount_rdoOngoingUntilINotify");
        public static By td_FundType = By.Id("ctl00_contentAmount_ucAmount_tdFundType");
        public static By td_SampleFile2 = By.XPath("//*[@id='ctl00_contentAmount_ucAmount_radComboBoxFundType_DropDown']/div/ul/li[2]");

        // FirstPage My Contact Information
        public static By rdo_IndividualUserType = By.Id("ctl00_contentContactInformation_ucProfile_rdoIsCompany_0");
        public static By ddl_Title = By.Id("ctl00_contentContactInformation_ucProfile_ddlTitle");
        public static By ddl_OptionMr = By.XPath("//*[@id='ctl00_contentContactInformation_ucProfile_ddlTitle']/option[2]");
        public static By txt_FirstName = By.XPath("//*[contains(@id,'ctl00_contentContactInformation_ucProfile_txtFirstName')]");
        public static By txt_MiddleName = By.XPath("//*[@id='ctl00_contentContactInformation_ucProfile_txtMiddleName']");
        public static By txt_LastName = By.XPath("//*[contains(@id,'ctl00_contentContactInformation_ucProfile_txtLastName')]");
        public static By txt_EmailId = By.XPath("//*[@id='ctl00_contentContactInformation_ucProfile_txtEmailAddress']");
        public static By txt_ConfirmEmailId = By.XPath("//*[@id='ctl00_contentContactInformation_ucProfile_txtEmailAddressRepeat']");
        public static By ddl_Country = By.Id("ctl00_contentContactInformation_ucProfile_ddlCountry");
        public static By SelectedValue_Australia = By.XPath("//*[@id='ctl00_contentContactInformation_ucProfile_ddlCountry']/option[16]");
        public static By txt_Address1 = By.XPath("//*[@id='ctl00_contentContactInformation_ucProfile_txtAddressLine1']");
        public static By txt_Address2 = By.XPath("//*[@id='ctl00_contentContactInformation_ucProfile_txtAddressLine2']");
        public static By txt_City = By.Id("ctl00_contentContactInformation_ucProfile_txtCity");
        public static By ddl_State = By.Id("ctl00_contentContactInformation_ucProfile_ddlProvince");
        public static By ddl_OptionAllRegions = By.XPath("//*[@id='ctl00_contentContactInformation_ucProfile_ddlProvince']/option[2]");
        public static By txt_Postal = By.Id("ctl00_contentContactInformation_ucProfile_txtPostalCode");
        public static By txt_PhoneNumber = By.Id("ctl00_contentContactInformation_ucProfile_txtPhone");

        //FirstPage Payment Information
        public static By txt_CreditCardNumber = By.Id("txtCardNumber");
        public static By txt_CardHolderName = By.XPath("//*[@aria-labelledby='lblCardHolder' and contains(@id,'ctl00_contentPaymentInformation_ucPayment_ucCardPayment_txtCardHolder')]");
        public static By ddl_ExpMonth = By.Id("ctl00_contentPaymentInformation_ucPayment_ucCardPayment_ddlExpirationMonth");
        public static By Selected_Month = By.XPath("//*[@id='ctl00_contentPaymentInformation_ucPayment_ucCardPayment_ddlExpirationMonth']/option[3]");
        public static By ddl_ExpYear = By.Id("ctl00_contentPaymentInformation_ucPayment_ucCardPayment_ddlExpirationYear");
        public static By Selected_Year = By.XPath("//*[@id='ctl00_contentPaymentInformation_ucPayment_ucCardPayment_ddlExpirationYear']/option[9]");
        public static By btn_Main_Continue = By.Id("ctl00_contentSurvey_btnContinue");
        public static By btn_Edit = By.Id("ctl00_content_ucDonationReview_ucPayment_btnEdit");
        public static By btn_ProcessPaymentNow = By.Id("ctl00_content_ucDonationReview_btnContinue");
        public static By btn_PaymentStatus_Continue = By.Id("ctl00_content_ucEnd_btnContinue");

        // FirstPage lables
        public static By validation_ErrorMessage = By.ClassName("ErrorMessage");
        public static By lbl_DonateNow = By.XPath("//*[@id='raisinRegion_97']/p[1]");
        public static By td_TributeClick = By.XPath("//*[@id='raisinRegion_84']/div/table/tbody/tr[3]/td[5]");
        public static By lbl_DonorProfile = By.XPath("//*[@class='region']/div/p");

        //Review & Process Payment
        public static By lbl_ctl00_content_ucDonationReview_ucAmount_lblFirstDonation = By.Id("ctl00_content_ucDonationReview_ucAmount_lblFirstDonation");
        public static By lbl_ctl00_content_ucDonationReview_ucAmount_lblAmountCaption = By.XPath("//*[@id='ctl00_content_ucDonationReview_divAmount']/table/tbody/tr[3]/td/table/tbody/tr[2]/td[2]/span");
        public static By lbl_ctl00_content_ucDonationReview_ucAmount_lblFund = By.Id("ctl00_content_ucDonationReview_ucAmount_lblFund");
        public static By lbl_ctl00_content_ucDonationReview_ucProfile_lblName = By.Id("ctl00_content_ucDonationReview_ucProfile_lblName");
        public static By lbl_ctl00_content_ucDonationReview_ucProfile_lblEmail = By.Id("ctl00_content_ucDonationReview_ucProfile_lblEmail");
        public static By lbl_ctl00_content_ucDonationReview_ucProfile_lblCompanyName = By.Id("ctl00_content_ucDonationReview_ucProfile_lblCompanyName");
        public static By lbl_ctl00_content_ucDonationReview_ucProfile_lblCountry = By.Id("ctl00_content_ucDonationReview_ucProfile_lblCountry");
        public static By lbl_ctl00_content_ucDonationReview_ucProfile_lblAddressLine1 = By.Id("ctl00_content_ucDonationReview_ucProfile_lblAddressLine1");
        public static By lbl_ctl00_content_ucDonationReview_ucProfile_lblCity = By.Id("ctl00_content_ucDonationReview_ucProfile_lblCity");
        public static By lbl_ctl00_content_ucDonationReview_ucProfile_lblProvince = By.Id("ctl00_content_ucDonationReview_ucProfile_lblProvince");
        public static By lbl_ctl00_content_ucDonationReview_ucProfile_lblPostalCode = By.Id("ctl00_content_ucDonationReview_ucProfile_lblPostalCode");
        public static By lbl_ctl00_content_ucDonationReview_ucProfile_lblPhone = By.Id("ctl00_content_ucDonationReview_ucProfile_lblPhone");
        public static By lbl_ctl00_content_ucDonationReview_ucProfile_lblGender = By.Id("ctl00_content_ucDonationReview_ucProfile_lblGender");
        public static By lbl_ctl00_content_ucDonationReview_ucProfile_lblDOB = By.Id("ctl00_content_ucDonationReview_ucProfile_lblDOB");
        public static By lbl_ctl00_content_ucDonationReview_ucProfile_lblCorrespondenceLanguage = By.Id("ctl00_content_ucDonationReview_ucProfile_lblCorrespondenceLanguage");
        public static By lbl_ctl00_content_ucDonationReview_ucPayment_ucCardPayment_lblCardType = By.Id("ctl00_content_ucDonationReview_ucPayment_ucCardPayment_lblCardType");
        public static By lbl_ctl00_content_ucDonationReview_ucPayment_ucCardPayment_lblCardNumber = By.Id("ctl00_content_ucDonationReview_ucPayment_ucCardPayment_lblCardNumber");
        public static By lbl_ctl00_content_ucDonationReview_ucPayment_ucCardPayment_lblCardHolder = By.Id("ctl00_content_ucDonationReview_ucPayment_ucCardPayment_lblCardHolder");
        public static By lbl_ctl00_content_ucDonationReview_ucPayment_ucCardPayment_lblExpirationMonth = By.Id("ctl00_content_ucDonationReview_ucPayment_ucCardPayment_lblExpirationMonth");
        public static By lbl_ctl00_content_ucDonationReview_ucPayment_ucCardPayment_lblExpirationYear = By.Id("ctl00_content_ucDonationReview_ucPayment_ucCardPayment_lblExpirationYear");

        //Payment Status
        public static By lbl_TransactionCode = By.XPath("//*[@id='ctl00_content_ucEnd_lblPaymentStatus']/span[2]/span[1]");
    }
}
