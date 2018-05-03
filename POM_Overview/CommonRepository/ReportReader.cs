using AkaNewMedia.CommonRepository;

using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaNewMedia.CommonRepository
{
    public class ReportReader
    {
        public static ExtentReports extent;
        public static ExtentTest test;
        static string status = string.Empty;
        static string html;

        /// <summary>
        /// Desc:Method is used to create the report after the funtions that are called in the test
        /// </summary>
        /// <param name="desc"></param>
        /// <param name="vs"></param>
        /// <param name="screenShotPath"></param>
        public static void AfterTest(string desc, List<string> vs, string screenShotPath = "")
        {
            ExtentTestManager.CreateTest(desc);
            Status logstatus;
            foreach (var item in vs)
            {
                if (item.Contains('-'))
                {
                    status = item.Split('-')[1].ToString();
                    if (status.Equals(EnumClasses.LogStatus.Failed.ToString()))
                    {
                        logstatus = Status.Fail;
                    }
                    else if (status.Equals(EnumClasses.LogStatus.Inconclusive.ToString()))
                    {
                        logstatus = Status.Warning;
                    }
                    else if (status.Equals(EnumClasses.LogStatus.Skipped.ToString()))
                    {
                        logstatus = Status.Skip;
                    }
                    else
                    {
                        logstatus = Status.Pass;
                    }
                    ExtentTestManager.GetTest().Log(logstatus, item);
                    if (logstatus == Status.Fail)
                    {
                        ExtentTestManager.GetTest().Fail("Screenshot -", MediaEntityBuilder.CreateScreenCaptureFromPath(screenShotPath).Build());
                    }
                }
            }
        }
        public static string passStringGreenColor(String logName)
        {
            html = "<span style='color:#008000'><b>" + logName + "</b></span>";
            return html;
        }
        public static string passStringOliveColor(String stepName)
        {
            html = "<span style='color:#808000'><b>" + stepName + "</b></span>";
            return html;
        }
        public static string passStringRedColor(String logName)
        {
            html = "<span style='color:#FF0000'><b>" + logName + "</b></span>";
            return html;
        }
        public static string passStringWarningColor(String stepName)
        {
            html = "<span style='color:#FF8C00'><b>" + stepName + "</b></span>";
            return html;
        }
        public static string passStringSkipColor(String stepName)
        {
            html = "<span style='color:#00FFFF'><b>" + stepName + "</b></span>";
            return html;
        }
    }
}
