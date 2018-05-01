using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.PageObjects;
using AkaNewMedia.CommonRepository;
using AkaNewMedia.ElementRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace AkaNewMedia.Pages
{
    public class GeneralDonationPage : GeneralMethod
    {
        public GeneralDonationPage(IWebDriver dr)
            : base(dr)
        {

        }
        List<string> lst_detail;
        EnumClasses.LogStatus status;
        string screenShotPath = string.Empty;

        /// <summary>
        /// Desc:Method is used to fill all the mandatory fields that are on registeration page and click on Continue.
        /// </summary>
        public void FillMandatoryFields(DataRow dataRow)
        {
            try
            {
                if (dataRow != null)
                {
                    lst_detail = new List<string>();
                    explicitWait(GeneralDonation_Locator.btn_OneTimeDonationType, 10000);
                    status = ClickOnElementWhenElementFound(GeneralDonation_Locator.btn_OneTimeDonationType);
                    MethodToAddDataInList("Click on one time donation -" + status);
                    explicitWait(GeneralDonation_Locator.rdo_DonationAmount_1, 5000);
                    status = ClickOnElementWhenElementFound(GeneralDonation_Locator.rdo_Amount);
                    MethodToAddDataInList("Select Amount -" + status);
                    int value = selectValueByIndex(GeneralDonation_Locator.lst_StartMonth, 2);
                    //Assert.AreEqual("1", -1, "Month not selected", MethodToAddDataInList("Month not selected-"+EnumClasses.LogStatus.Failed));
                    selectValueByIndex(GeneralDonation_Locator.lst_Day, 1);
                    explicitWait(GeneralDonation_Locator.td_FundType, 2000);
                    status = ClickOnElementWhenElementFound(GeneralDonation_Locator.td_FundType);
                    MethodToAddDataInList("Clicking on Fund Allocation -" + status);
                    status = ClickOnElementWhenElementFound(GeneralDonation_Locator.td_SampleFile2);
                    MethodToAddDataInList("Clicking on Fund Allocation -" + status);
                    status = ClickOnElementWhenElementFound(GeneralDonation_Locator.ddl_Title);
                    MethodToAddDataInList("Click on Title dropdown-" + status);
                    explicitWait(GeneralDonation_Locator.ddl_Title, 2000);
                    selectValueFromDropdown(GeneralDonation_Locator.ddl_Title, dataRow["title"].ToString());
                    MethodToAddDataInList("Select Title-" + status);
                    explicitWait(GeneralDonation_Locator.txt_FirstName, 2000);
                    status = SendKeysForElement(GeneralDonation_Locator.txt_FirstName, dataRow["firstname"].ToString());
                    MethodToAddDataInList("Entering into first name-" + status);
                    status = SendKeysForElement(GeneralDonation_Locator.txt_MiddleName, dataRow["middlename"].ToString());
                    MethodToAddDataInList("Entering into middle name-" + status);
                    status = SendKeysForElement(GeneralDonation_Locator.txt_LastName, dataRow["lastname"].ToString());
                    MethodToAddDataInList("Entering into lastname-" + status);
                    status = SendKeysForElement(GeneralDonation_Locator.txt_EmailId, dataRow["emailid"].ToString());
                    MethodToAddDataInList("Entering into email-" + status);
                    status = SendKeysForElement(GeneralDonation_Locator.txt_ConfirmEmailId, dataRow["confirmemailid"].ToString());
                    MethodToAddDataInList("Entering into confirm email-" + status);
                    //explicitWait(GeneralDonation_Locator.ddl_Country, 5000);
                    //ClickOnElementWhenElementFound(GeneralDonation_Locator.ddl_Country);
                    //selectValueFromDropdown(GeneralDonation_Locator.ddl_Country, dataRow["country"].ToString());
                    explicitWait(GeneralDonation_Locator.txt_Address1, 2000);
                    status = SendKeysForElement(GeneralDonation_Locator.txt_Address1, dataRow["address1"].ToString());
                    MethodToAddDataInList("Entering into address1-" + status);
                    status = SendKeysForElement(GeneralDonation_Locator.txt_Address2, dataRow["address2"].ToString());
                    MethodToAddDataInList("Entering into address2-" + status);
                    explicitWait(GeneralDonation_Locator.txt_City, 2000);
                    status = SendKeysForElement(GeneralDonation_Locator.txt_City, dataRow["city"].ToString());
                    MethodToAddDataInList("Entering into city-" + status);
                    explicitWait(GeneralDonation_Locator.ddl_State, 6000);
                    status = ClickOnElementWhenElementFound(GeneralDonation_Locator.ddl_State);
                    MethodToAddDataInList("Click on state-" + status);
                    selectValueFromDropdown(GeneralDonation_Locator.ddl_State, dataRow["state"].ToString());
                    status = SendKeysForElement(GeneralDonation_Locator.txt_Postal, dataRow["postal"].ToString());
                    MethodToAddDataInList("Enter postal-" + status);
                    explicitWait(GeneralDonation_Locator.ddl_ExpMonth, 5000);
                    status = ClickOnElementWhenElementFound(GeneralDonation_Locator.ddl_ExpMonth);
                    selectValueFromDropdown(GeneralDonation_Locator.ddl_ExpMonth, dataRow["expmonth"].ToString());
                    MethodToAddDataInList("Click on expmonth-" + status);
                    explicitWait(GeneralDonation_Locator.ddl_ExpYear, 2000);
                    status = ClickOnElementWhenElementFound(GeneralDonation_Locator.ddl_ExpYear);
                    selectValueFromDropdown(GeneralDonation_Locator.ddl_ExpYear, dataRow["expyear"].ToString());
                    MethodToAddDataInList("Click on expyear-" + status);
                    explicitWait(GeneralDonation_Locator.txt_CreditCardNumber, 10000);
                    //ClickOnElementWhenElementFound(GeneralDonation_Locator.txt_CreditCardNumber);
                    status = SendKeysForWebElement(GeneralDonation_Locator.txt_CreditCardNumber, dataRow["creditcardnumber"].ToString());
                    MethodToAddDataInList("Enter creditcard number-" + status);
                    explicitWait(GeneralDonation_Locator.txt_CardHolderName, 5000);
                    status = SendKeysForWebElement(GeneralDonation_Locator.txt_CardHolderName, dataRow["cardholdername"].ToString());
                    MethodToAddDataInList("Enter cardholder name-" + status);
                    status = ClickOnElementWhenElementFound(GeneralDonation_Locator.btn_Main_Continue);
                    MethodToAddDataInList("Click on continue button-" + status);
                    var assertStatus = AssertIsFalse(GeneralDonation_Locator.lbl_DonorProfile);
                    if (assertStatus == EnumClasses.LogStatus.Failed)
                    {
                        MethodToAddDataInList("All mandatory fields are not filled-" + assertStatus);
                        ReportFailure("TestFailure", System.Reflection.MethodBase.GetCurrentMethod().Name);
                    }
                    else if (assertStatus != EnumClasses.LogStatus.Failed)
                        ReportReader.AfterTest(System.Reflection.MethodBase.GetCurrentMethod().Name, lst_detail);
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        /// <summary>
        /// Desc:Method is used to Verify all the filled fields and after verified click on edit button.
        /// </summary>
        public void VerifyAllTheFiledsAndClickOnEdit(DataRow dataRow)
        {
            try
            {
                if (dataRow != null)
                {
                    lst_detail = new List<string>();
                    string name = dataRow["title"].ToString() + ' ' + dataRow["firstname"].ToString() + ' ' + dataRow["middlename"].ToString() + ' ' + dataRow["lastname"].ToString();
                    status = AssertAreEqual((GeneralDonation_Locator.lbl_ctl00_content_ucDonationReview_ucProfile_lblName), name);
                    MethodToAddDataInList("Verify the name-" + status);
                    status = AssertAreEqual((GeneralDonation_Locator.lbl_ctl00_content_ucDonationReview_ucProfile_lblEmail), dataRow["emailid"].ToString());
                    MethodToAddDataInList("Verify the email-" + status);
                    status = AssertAreEqual((GeneralDonation_Locator.lbl_ctl00_content_ucDonationReview_ucProfile_lblCountry), dataRow["country"].ToString());
                    MethodToAddDataInList("Verify the country-" + status);
                    status = AssertAreEqual((GeneralDonation_Locator.lbl_ctl00_content_ucDonationReview_ucProfile_lblCity), dataRow["city"].ToString());
                    MethodToAddDataInList("Verify the city-" + status);
                    status = AssertAreEqual((GeneralDonation_Locator.lbl_ctl00_content_ucDonationReview_ucProfile_lblPostalCode), dataRow["postal"].ToString());
                    MethodToAddDataInList("Verify the postal-" + status);
                    status = AssertAreEqual((GeneralDonation_Locator.lbl_ctl00_content_ucDonationReview_ucPayment_ucCardPayment_lblCardHolder), dataRow["cardholdername"].ToString());
                    MethodToAddDataInList("Verify the cardholdername-" + status);
                    status = AssertAreEqual((GeneralDonation_Locator.lbl_ctl00_content_ucDonationReview_ucPayment_ucCardPayment_lblExpirationMonth), dataRow["expmonth"].ToString());
                    MethodToAddDataInList("Verify the expmonth-" + status);
                    status = AssertAreEqual((GeneralDonation_Locator.lbl_ctl00_content_ucDonationReview_ucPayment_ucCardPayment_lblExpirationYear), dataRow["expyear"].ToString());
                    MethodToAddDataInList("Verify the expyear-" + status);
                }
                status = ClickOnElementWhenElementFound(GeneralDonation_Locator.btn_Edit);
                MethodToAddDataInList("Click on edit button-" + status);
                ReportReader.AfterTest(System.Reflection.MethodBase.GetCurrentMethod().Name, lst_detail);
            }
            catch (Exception e)
            {
                ReportFailure(e.Message, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
        }

        /// <summary>
        /// Desc:Method is used to update some fileds and then click on continue button
        /// </summary>
        public void UpdateSomeFieldsAndContinue(DataRow dataRow)
        {
            try
            {
                lst_detail = new List<string>();
                status = SendKeysForWebElement(GeneralDonation_Locator.txt_FirstName, dataRow["ufirstname"].ToString());
                MethodToAddDataInList("Enter the updated first name-" + status);
                status = SendKeysForWebElement(GeneralDonation_Locator.txt_MiddleName, dataRow["umiddlename"].ToString());
                MethodToAddDataInList("Enter the updated middle name-" + status);
                status = SendKeysForWebElement(GeneralDonation_Locator.txt_LastName, dataRow["ulastname"].ToString());
                MethodToAddDataInList("Enter the updated last name-" + status);
                status = SendKeysForWebElement(GeneralDonation_Locator.txt_EmailId, dataRow["uemailid"].ToString());
                MethodToAddDataInList("Enter the updated emailid-" + status);
                status = SendKeysForWebElement(GeneralDonation_Locator.txt_ConfirmEmailId, dataRow["uconfirmemailid"].ToString());
                MethodToAddDataInList("Enter the updated confirmemailid-" + status);
                explicitWait(GeneralDonation_Locator.txt_CreditCardNumber, 1000);
                status = SendKeysForWebElement(GeneralDonation_Locator.txt_CreditCardNumber, dataRow["creditcardnumber"].ToString());
                MethodToAddDataInList("Enter the creditcardnumber-" + status);
                explicitWait(GeneralDonation_Locator.txt_CardHolderName, 2000);
                status = SendKeysForWebElement(GeneralDonation_Locator.txt_CardHolderName, dataRow["ucardholdername"].ToString());
                MethodToAddDataInList("Enter the updated card holder name-" + status);
                explicitWait(GeneralDonation_Locator.ddl_ExpMonth, 2000);
                status = ClickOnElementWhenElementFound(GeneralDonation_Locator.ddl_ExpMonth);
                MethodToAddDataInList("Click on expmonth dropdown-" + status);
                selectValueFromDropdown(GeneralDonation_Locator.ddl_ExpMonth, dataRow["expmonth"].ToString());
                status = ClickOnElementWhenElementFound(GeneralDonation_Locator.ddl_ExpYear);
                selectValueFromDropdown(GeneralDonation_Locator.ddl_ExpYear, dataRow["expyear"].ToString());
                MethodToAddDataInList("Click on expyear dropdown-" + status);
                status = ClickOnElementWhenElementFound(GeneralDonation_Locator.btn_Main_Continue);
                MethodToAddDataInList("Click on continue button-" + status);
                ReportReader.AfterTest(System.Reflection.MethodBase.GetCurrentMethod().Name, lst_detail);
            }
            catch (Exception e)
            {
                ReportFailure(e.Message, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
        }
        /// <summary>
        /// Desc:Method is used to verify all the filled fields and click on payment process button
        /// </summary>
        public void VerifyTheFieldsAndClickonPaymentProcess(DataRow dataRow)
        {
            try
            {
                lst_detail = new List<string>();
                string name = dataRow["title"].ToString() + ' ' + dataRow["ufirstname"].ToString() + ' ' + dataRow["umiddlename"].ToString() + ' ' + dataRow["ulastname"].ToString();
                status = AssertAreEqual((GeneralDonation_Locator.lbl_ctl00_content_ucDonationReview_ucProfile_lblName), name);
                MethodToAddDataInList("Verify the updated name-" + status);
                status = AssertAreEqual((GeneralDonation_Locator.lbl_ctl00_content_ucDonationReview_ucPayment_ucCardPayment_lblCardHolder), dataRow["ucardholdername"].ToString());
                MethodToAddDataInList("Verify the updated cardholdername-" + status);
                status = AssertAreEqual((GeneralDonation_Locator.lbl_ctl00_content_ucDonationReview_ucPayment_ucCardPayment_lblExpirationMonth), dataRow["expmonth"].ToString());
                MethodToAddDataInList("Verify the updated expmonth-" + status);
                status = AssertAreEqual((GeneralDonation_Locator.lbl_ctl00_content_ucDonationReview_ucPayment_ucCardPayment_lblExpirationYear), dataRow["expyear"].ToString());
                MethodToAddDataInList("Verify the updated expyear-" + status);
                status = ClickOnElementWhenElementFound(GeneralDonation_Locator.btn_ProcessPaymentNow);
                MethodToAddDataInList("Click on Process Payment button-" + status);
                ReportReader.AfterTest(System.Reflection.MethodBase.GetCurrentMethod().Name, lst_detail);
            }
            catch (Exception e)
            {
                ReportFailure(e.Message, System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
        }
        /// <summary>
        /// Desc:Method is used to Verify the transaction code is visible on the successful page.
        /// </summary>
        public void VerifyTheTransectionCodeVisible()
        {
            try
            {
                lst_detail = new List<string>();
                status = AssertIsFalse(GeneralDonation_Locator.lbl_TransactionCode);
                MethodToAddDataInList("Verify the TransectionCode is visible-" + status);
                status = ClickOnElementWhenElementFound(GeneralDonation_Locator.btn_PaymentStatus_Continue);
                MethodToAddDataInList("Click on continue button-" + status);
                ReportReader.AfterTest(System.Reflection.MethodBase.GetCurrentMethod().Name, lst_detail);
            }
            catch (Exception e)
            {
                ReportFailure(e.Message, System.Reflection.MethodBase.GetCurrentMethod().Name);
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
        /// <summary>
        /// Desc:Method is used to log the report failure
        /// </summary>
        /// <param name="e"></param>
        private void ReportFailure(string e, string methodName)
        {
            screenShotPath = ScreenShotCapture();
            ReportReader.AfterTest(methodName, lst_detail, screenShotPath);
            Assert.Fail(e);
        }
    }
}
