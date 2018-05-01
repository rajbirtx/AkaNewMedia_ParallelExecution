using OpenQA.Selenium;
using AkaNewMedia.CommonRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AkaNewMedia.ElementRepository;
using NUnit.Framework;
using System.Threading;

namespace AkaNewMedia.Pages
{
    public class InHonourDonationPage : GeneralMethod
    {
        public InHonourDonationPage(IWebDriver dr)
            : base(dr)
        {
        }

        List<string> lst_detail;
        EnumClasses.LogStatus status;
        string screenShotPath = string.Empty;
        /// <summary>
        /// Desc:Method is used to fill mendatiory fields
        /// </summary>
        /// <param name="datarow"></param>
        public void fillMandatoryFields(DataRow datarow)
        {
            try
            {
                lst_detail = new List<string>();
                status = ClickOnElementWhenElementFound(GeneralDonation_Locator.btn_RecurringDonationType);
                MethodToAddDataInList("Click on Recurring Donation -" + status);
                explicitWait(GeneralDonation_Locator.ddl_DonationFrequency, 3000);
                status = ClickOnElementWhenElementFound(GeneralDonation_Locator.ddl_DonationFrequency);
                MethodToAddDataInList("Click on DonationFrequency dropdown-" + status);
                explicitWait(GeneralDonation_Locator.ddl_DonationFrequency, 3000);
                selectValueFromDropdownByText(GeneralDonation_Locator.ddl_DonationFrequency, datarow["donationfrequency"].ToString());
                MethodToAddDataInList("Select Monthly Frequency -" + status);
                status = ClickOnElementWhenElementFound(InHonourDonation_Locator.Amount);
                //ClickOnElementWhenElementFound(honourPage.InHonourMonth);
                selectValueByIndex(InHonourDonation_Locator.InHonourMonth, 1);
                selectValueByIndex(InHonourDonation_Locator.InHonourDay, 2);
                status = ClickOnElementWhenElementFound(InHonourDonation_Locator.NumberOfTimesRadio);
                MethodToAddDataInList("Select Number Of Times RadioButton-" + status);
                explicitWait(InHonourDonation_Locator.NumberOfTimesText, 5000);
                mouseHover(InHonourDonation_Locator.NumberOfTimesText);
                explicitWait(InHonourDonation_Locator.NumberOfTimesText, 10000);
                status = SendKeysForWebElement(InHonourDonation_Locator.NumberOfTimesText, datarow["numberoftimes"].ToString());
                MethodToAddDataInList("Enter specific number of times -" + status);
                explicitWait(InHonourDonation_Locator.FundAllocation, 3000);
                //ClickOnElementWhenElementFound(honourPage.FundAllocation);
                explicitWait(InHonourDonation_Locator.FundAllocation, 3000);
                getWebElementByLocator(InHonourDonation_Locator.FundAllocation).Clear();
                status = SendKeysForElement(InHonourDonation_Locator.FundAllocation, datarow["fundallocation"].ToString() + Keys.Tab);
                MethodToAddDataInList("Select Fund Allocation -" + status);
                //SendKeysForElement(honourPage.FundAllocation, Keys.Enter);
                status = SendKeysForElement(GeneralDonation_Locator.txt_FirstName, datarow["firstname"].ToString());
                MethodToAddDataInList("Enter firstname -" + status);
                status = SendKeysForElement(GeneralDonation_Locator.txt_LastName, datarow["lastname"].ToString());
                MethodToAddDataInList("Enter lastname -" + status);
                status = SendKeysForElement(GeneralDonation_Locator.txt_EmailId, datarow["emailid"].ToString());
                MethodToAddDataInList("Enter email id -" + status);
                status = SendKeysForElement(GeneralDonation_Locator.txt_ConfirmEmailId, datarow["confirmemailid"].ToString());
                MethodToAddDataInList("Re enter email id -" + status);
                //selectValueFromDropdown(GeneralDonation_Locator.ddl_Country, datarow["country"].ToString());
                status = SendKeysForElement(GeneralDonation_Locator.txt_Address1, datarow["address1"].ToString());
                MethodToAddDataInList("Enter address -" + status);
                explicitWait(GeneralDonation_Locator.txt_City, 4000);
                status = SendKeysForWebElement(GeneralDonation_Locator.txt_City, datarow["city"].ToString());
                MethodToAddDataInList("Enter city -" + status);
                status = SendKeysForElement(GeneralDonation_Locator.ddl_State, datarow["state"].ToString());
                MethodToAddDataInList("Enter state -" + status);
                status = SendKeysForElement(GeneralDonation_Locator.txt_Postal, datarow["postal"].ToString());
                MethodToAddDataInList("Enter postal code -" + status);
                explicitWait(GeneralDonation_Locator.txt_CreditCardNumber, 10000);
                //ClickOnElementWhenElementFound(GeneralDonation.txt_CreditCardNumber);
                //explicitWait(GeneralDonation.txt_CreditCardNumber, 7000);
                status = SendKeysForWebElement(GeneralDonation_Locator.txt_CreditCardNumber, datarow["creditcardnumber"].ToString());
                MethodToAddDataInList("Enter creditcard number -" + status);
                explicitWait(GeneralDonation_Locator.txt_CardHolderName, 4000);
                status = SendKeysForWebElement(GeneralDonation_Locator.txt_CardHolderName, datarow["cardholdername"].ToString());
                MethodToAddDataInList("Enter card holder name -" + status);
                explicitWait(GeneralDonation_Locator.ddl_ExpMonth, 4000);
                selectValueFromDropdownByText(GeneralDonation_Locator.ddl_ExpMonth, datarow["expmonth"].ToString());
                MethodToAddDataInList("Select expiry Month -" + status);
                explicitWait(GeneralDonation_Locator.ddl_ExpYear, 4000);
                selectValueFromDropdownByText(GeneralDonation_Locator.ddl_ExpYear, datarow["expyear"].ToString());
                MethodToAddDataInList("Select expiry Year -" + status);
                //explicitWait(GeneralDonation.btn_Main_Continue, 2000);
                status = ClickOnElementWhenElementFound(GeneralDonation_Locator.btn_Main_Continue);
                MethodToAddDataInList("Click on Continue Button -" + status);
                var assertStatus = AssertIsFalse(GeneralDonation_Locator.lbl_DonorProfile);
                if (assertStatus == EnumClasses.LogStatus.Failed)
                {
                    MethodToAddDataInList("All mandatory fields are not filled-" + assertStatus);
                    ReportFailure("TestFailure", System.Reflection.MethodBase.GetCurrentMethod().Name);
                }
                else if (assertStatus != EnumClasses.LogStatus.Failed)
                    ReportReader.AfterTest(System.Reflection.MethodBase.GetCurrentMethod().Name, lst_detail);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        /// <summary>
        /// Desc:Method used for fill Tribute Details
        /// </summary>
        /// <param name="datarow"></param>
        public void fillTributeDetails(DataRow datarow)
        {
            try
            {
                status = SendKeysForElement(InHonourDonation_Locator.HonourFirstName, datarow["honourfirstname"].ToString());
                MethodToAddDataInList("Enter honourfirstname-" + status);
                status = SendKeysForElement(InHonourDonation_Locator.HonourLastName, datarow["honourlastname"].ToString());
                MethodToAddDataInList("Enter honourlastname-" + status);
                status = ClickOnElementWhenElementFound(InHonourDonation_Locator.eCardType);
                MethodToAddDataInList("Click on eCardType-" + status);
                status = ClickOnElementWhenElementFound(InHonourDonation_Locator.ContinueCardType);
                MethodToAddDataInList("Click on ContinueCardType-" + status);
            }
            catch (Exception e)
            {
                ReportFailure("TestFailure", System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
        }
        /// <summary>
        /// Desc:Method used for fill Recipient Details
        /// </summary>
        /// <param name="datarow"></param>
        public void fillRecipientDetails(DataRow datarow)
        {
            try
            {
                status = SendKeysForWebElement(InHonourDonation_Locator.RecipientFirstName, datarow["recipientfirstname"].ToString());
                status = SendKeysForWebElement(InHonourDonation_Locator.RecipientLastName, datarow["recipientlastname"].ToString());
                status = SendKeysForWebElement(InHonourDonation_Locator.RecipientEmail, datarow["recipientemailid"].ToString());
                status = ClickOnElementWhenElementFound(InHonourDonation_Locator.AddButton);
                status = ClickOnElementWhenElementFound(InHonourDonation_Locator.ImageScroller);
                status = ClickOnElementWhenElementFound(InHonourDonation_Locator.ImageScroller);
                //doubleClick(honourPage.ImageScroller);
                explicitWait(InHonourDonation_Locator.Image6, 4000);
                status = ClickOnElementWhenElementFound(InHonourDonation_Locator.Image6);
                //explicitWait(InHonourDonation.TextColorPicker, 6000);
                //mouseHover(InHonourDonation.TextColorPicker);
                //explicitWait(InHonourDonation.GreyColor, 5000);
                //mouseHover(InHonourDonation.GreyColor);
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("window.scrollTo(0,700)");
                explicitWait(InHonourDonation_Locator.SampleMessageDropdown, 4000);
                selectValueFromDropdownByText(InHonourDonation_Locator.SampleMessageDropdown, "----- Test message 2 -------");
                Thread.Sleep(10000);
                //driver.SwitchTo().Frame(0);
                //Thread.Sleep(5000);
                status = ClickOnElementWhenElementFound(InHonourDonation_Locator.MessageTextArea);
                status = SendKeysForElement(InHonourDonation_Locator.MessageTextArea, datarow["messagetextarea"].ToString());
                // SendKeysForElement(InHonourDonation.MessageTextArea, datarow["messagetextarea"].ToString());
                //driver.SwitchTo().DefaultContent();
                //getWebElementByLocator(InHonourDonation.MessageTextArea).SendKeys(Keys.Control + Keys.Enter);
                status = ClickOnElementWhenElementFound(InHonourDonation_Locator.NotifyOption);
                status = ClickOnElementWhenElementFound(InHonourDonation_Locator.SaveContinueButton);
                ReportReader.AfterTest(System.Reflection.MethodBase.GetCurrentMethod().Name, lst_detail);
            }
            catch (Exception e)
            {
                ReportFailure("TestFailure", System.Reflection.MethodBase.GetCurrentMethod().Name);
            }
        }
        /// <summary>
        /// Desc:Method used for verify In Honour Data
        /// </summary>
        /// <param name="datarow"></param>
        public void verifyInHonourData(DataRow dataRow)
        {
            try
            {
                if (dataRow != null)
                {
                    Assert.AreEqual(getTextOfWebElementByLocator(InHonourDonation_Locator.FundAllocationText), dataRow["fundallocation"].ToString());
                    Assert.AreEqual(getTextOfWebElementByLocator(InHonourDonation_Locator.CountryText), dataRow["country"].ToString());
                    Assert.AreEqual(getTextOfWebElementByLocator(InHonourDonation_Locator.StateText), dataRow["state"].ToString());
                    Assert.AreEqual(getTextOfWebElementByLocator(InHonourDonation_Locator.EmailText), dataRow["email"].ToString());
                    Assert.AreEqual(getTextOfWebElementByLocator(InHonourDonation_Locator.CityText), dataRow["city"].ToString());
                    Assert.AreEqual(getTextOfWebElementByLocator(InHonourDonation_Locator.Address1Text), dataRow["address1"].ToString());
                    Assert.AreEqual(getTextOfWebElementByLocator(InHonourDonation_Locator.PostalText), dataRow["postal"].ToString());
                    Assert.AreEqual(getTextOfWebElementByLocator(InHonourDonation_Locator.CardHolderText), dataRow["cardholdername"].ToString());
                    string tributeName = dataRow["honourfirstname"].ToString() + ' ' + dataRow["honourlastname"].ToString();
                    Assert.AreEqual(getTextOfWebElementByLocator(InHonourDonation_Locator.TributeHonourNameText), tributeName);
                }
                status = ClickOnElementWhenElementFound(InHonourDonation_Locator.ProcessPaymentButton);
                ReportReader.AfterTest(System.Reflection.MethodBase.GetCurrentMethod().Name, lst_detail);
            }
            catch (Exception e)
            {
                ReportFailure("TestFailure", System.Reflection.MethodBase.GetCurrentMethod().Name);
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
