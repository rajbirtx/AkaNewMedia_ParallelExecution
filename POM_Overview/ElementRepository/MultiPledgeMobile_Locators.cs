using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaNewMedia.ElementRepository
{
    public class MultiPledgeMobile_Locators
    {
        //Registeration Page
        public By btn_Register = By.XPath("//*[@id='navigation']/ul/li[1]/a");
        public By ddl_City = By.Id("SelectSubEventGroupId");
        public By btn_RegisterationFee_Individual = By.XPath("//*[@id='main']/ul[1]/li[2]/a");
        public By btn_IAgree = By.XPath("//*[@id='main']/a");
        public By chk_Individual = By.Id("individual");
        public By txt_FirstName = By.Id("UserDetails_Profile_FirstName");
        public By txt_LastName = By.Id("UserDetails_Profile_LastName");
        public By txt_Email = By.Id("UserDetails_Profile_Email");
        public By txt_ConfirmEmail = By.Id("UserDetails_Profile_EmailConfirm");
        public By ddl_Country = By.Id("UserDetails_Profile_Address_CountryId");
        public By txt_AddressLine1 = By.Id("UserDetails_Profile_Address_Line1");
        public By txt_City = By.Id("UserDetails_Profile_Address_City");
        public By ddl_State = By.Id("UserDetails_Profile_Address_RegionId");
        public By txt_Postal = By.Id("UserDetails_Profile_Address_PostalCode");
        public By txt_PersonalGoal = By.Id("UserDetails_PersonalGoal");
        public By txt_UserName = By.Id("UserDetails_Username");
        public By txt_Password = By.Id("UserDetails_Password");
        public By txt_ConfirmPassword = By.Id("UserDetails_PasswordConfirm");
        public By btn_SaveAndAddAnotherParticipant = By.XPath("//*[@id='registration_form_container']/button[1]");
        public By txt_AdditionalUserFirstName = By.Id("AdditionalUserDetails_0__Profile_FirstName");
        public By txt_AdditionalUserLastName = By.Id("AdditionalUserDetails_0__Profile_LastName");
        public By txt_AdditionalUserEmail = By.Id("AdditionalUserDetails_0__Profile_Email");
        public By ddl_RegistrationType = By.Id("AdditionalUserDetails_0__SelectedRegistrationItemId");
        public By chk_IAccept = By.Id("AdditionalUserDetails_0__AgreeToWaiver");
        public By btn_SaveAndContinue = By.XPath("//*[@id='registration_form_container']/button[2]");
        public By chk_PayWithCreditCard = By.Id("payCard");
        public By txt_CardNumber = By.Id("txtCardNumber");
        public By txt_CardholderName = By.Id("UserDetails_PaymentDetails_CardholderName");
        public By ddl_ExpMonth = By.Id("UserDetails_PaymentDetails_CardExpiration_Month");
        public By ddl_ExpYear = By.Id("UserDetails_PaymentDetails_CardExpiration_Year");
        public By btn_Next = By.Id("btnSubmit");

        //labels 
        public By lbl_NewParticipant = By.XPath("//a[contains(.,'New Participant')]");
        public By lbl_IAccept = By.XPath("//*[@id='Additional_Registration_Form']/div[8]/label");
        public By lbl_PaymentInformation = By.XPath("//*[@id='fee_payment_container']/div[2]/div[2]/h4");
        public By lbl_Review = By.XPath("//*[@id='main']/h2");

        //labels for Review
        public By lbl_Review_Name = By.XPath("//*[@id='main']/table/tbody/tr[2]/td/table/tbody/tr[1]/td[2]");
        public By lbl_Review_Email = By.XPath("//*[@id='main']/table/tbody/tr[2]/td/table/tbody/tr[2]/td[2]");
        public By lbl_Review_OrganizationName = By.XPath("//*[@id='main']/table/tbody/tr[2]/td/table/tbody/tr[3]/td[2]");
        public By lbl_Review_Address = By.XPath("//*[@id='main']/table/tbody/tr[2]/td/table/tbody/tr[4]/td[2]");
        public By lbl_Review_Phone = By.XPath("//*[@id='main']/table/tbody/tr[2]/td/table/tbody/tr[5]/td[2]");
        public By lbl_Review_Gender = By.XPath("//*[@id='main']/table/tbody/tr[2]/td/table/tbody/tr[6]/td[2]");
        public By lbl_Review_Goal = By.XPath("//*[@id='main']/table/tbody/tr[3]/td[2]");
        public By lbl_Review_CorrespondenceLanguage = By.XPath("//*[@id='main']/table/tbody/tr[2]/td/table/tbody/tr[8]/td[2]");
        public By lbl_Review_UserName = By.XPath("//*[@id='main']/table/tbody/tr[4]/td[2]");

        //labels for review for Additional user
        public By lbl_Review_Additional_Name = By.XPath("//*[@id='main']/table/tbody/tr[7]/td[2]");
        public By lbl_Review_Additional_RegistrationType = By.XPath("//*[@id='main']/table/tbody/tr[8]/td[2]");
        public By lbl_Review_Additional_RegistrationFee = By.XPath("//*[@id='main']/table/tbody/tr[9]/td[2]");
        public By lbl_Review_RegisteredFor = By.XPath("//*[@id='main']/table/tbody/tr[13]/td[2]");
        public By lbl_Review_RegistrationType = By.XPath("//*[@id='main']/table/tbody/tr[14]/td[2]");
        public By lbl_Review_RegistrationFee = By.XPath("//*[@id='main']/table/tbody/tr[16]/td[2]");
        public By lbl_Review_AdditionalRegistrantsTotalAmount = By.XPath("//*[@id='main']/table/tbody/tr[17]/td[2]");
        public By lbl_Review_TotalAmount = By.XPath("//*[@id='main']/table/tbody/tr[18]/td[2]");

        //labels for Payment Information
        public By lbl_Review_CardType = By.XPath("//*[@id='main']/table/tbody/tr[19]/td/table/tbody/tr[2]/td[2]");
        public By lbl_Review_CreditCardNumber = By.XPath("//*[@id='main']/table/tbody/tr[19]/td/table/tbody/tr[3]/td[2]");
        public By lbl_Review_CardholdersName = By.XPath("//*[@id='trCardHolder']/td[2]");
        public By lbl_ExpirationDate = By.XPath("//*[@id='main']/table/tbody/tr[19]/td/table/tbody/tr[5]/td[2]");

        //For Proceed payment
        public By btn_ProcessPaymentNow = By.XPath("//*[@id='main']/table/tbody/tr[20]/td/a");

        //For Transection Code
        public By lbl_TransactionCode = By.XPath("//*[contains(@id,'raisinRegion')]/br[3]");
    }
}
