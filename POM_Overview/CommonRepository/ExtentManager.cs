using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaNewMedia.CommonRepository
{
    public class ExtentManager
    {
        private static readonly Lazy<ExtentReports> _lazy = new Lazy<ExtentReports>(() => new ExtentReports());

        public static ExtentReports Instance { get { return _lazy.Value; } }

        static ExtentManager()
        {
            var htmlReporter = new ExtentHtmlReporter(GeneralMethod.GetReportPath());
            htmlReporter.Configuration().ChartLocation = ChartLocation.Bottom;
            htmlReporter.Configuration().ChartVisibilityOnOpen = true;
            htmlReporter.Configuration().DocumentTitle = "Extent/NUnit Samples";
            htmlReporter.Configuration().ReportName = "Extent/NUnit Samples";
            htmlReporter.Configuration().Theme = Theme.Standard;
            Instance.AttachReporter(htmlReporter);
            Instance.AddSystemInfo("os", "win7");
            Instance.AddSystemInfo("Host Name", "LocalHost");
            Instance.AddSystemInfo("Environment", "QA");
            Instance.AddSystemInfo("User Name", "Rajbir");
            Instance.AddSystemInfo("Selenium Version", "3.11");
        }

        private ExtentManager()
        {
        }
    }
}
