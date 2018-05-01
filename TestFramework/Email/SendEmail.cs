using AkaNewMedia.CommonRepository;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.TestCases
{
    [SetUpFixture]
    public class SendEmail
    {
        [OneTimeTearDown]
        public void sendMail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            string fromEmail= ConfigurationManager.AppSettings["FromEmail"];
            string fromPassword = ConfigurationManager.AppSettings["FromPassword"];
            try
            {
                mail.From = new MailAddress(fromEmail, "Testingxpters");
                mail.To.Add(new MailAddress("gunjan.garg@testingxperts.com", "Testingxperts"));
                mail.To.Add(new MailAddress("rajbir.kaur@testingxperts.com", "Testingxperts"));
                mail.Subject = "Automation Test Reports";
                mail.Body = "Hi \n\n Please find the reports attached.\n\n Regards \n Testingxperts";
                mail.Attachments.Add(new Attachment(GeneralMethod.GetReportPath()));
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 25;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(fromEmail, fromPassword);
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
