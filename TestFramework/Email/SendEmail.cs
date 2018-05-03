using AkaNewMedia.CommonRepository;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Web;

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
            GeneralMethod.createZipFile();
            string fromEmail = ConfigurationManager.AppSettings["FromEmail"];
            string fromPassword = ConfigurationManager.AppSettings["FromPassword"];
            try
            {
                ContentType ctype = new ContentType("application/zip");
                string zipFile = GeneralMethod.GetZipFolderPath() + @"\ExtentReport.zip";
                mail.From = new MailAddress(fromEmail, "Testingxpters");
                mail.To.Add(new MailAddress("gunjan.garg@testingxperts.com", "Testingxperts"));
                mail.To.Add(new MailAddress("rajbir.kaur@testingxperts.com", "Testingxperts"));
                mail.Subject = "Automation Test Reports";
                mail.Body = "Hi \n\n Please find the reports attached.\n\n Regards \n Testingxperts";
                mail.Attachments.Add(new Attachment(zipFile, ctype));
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
