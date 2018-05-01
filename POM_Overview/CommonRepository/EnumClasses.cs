using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkaNewMedia.CommonRepository
{

    public class EnumClasses
    {
        public enum BrowserName
        {
            ie,
            firefox,
            chrome,
            opera,
            edge
        }
        public enum SheetNames
        {
            TestCases,
            GeneralDonation,
            InHonourDonation
        }
        public enum LogStatus
        {
            Inconclusive,
            Skipped,
            Passed,
            Warning,
            Failed
        }
    }
}
