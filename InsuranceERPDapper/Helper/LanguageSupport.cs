using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace InsuranceERPDapper.Helper
{
    public class LanguageSupport
    {
        private static CultureInfo En = new CultureInfo("en-US");
        private static CultureInfo Fr = new CultureInfo("fr-CA");
        public static CultureInfo CultureInfo;

        public static int Lang
        {
            get
            {
                if (CultureInfo == null)
                {
                    return 0;
                }

                switch (CultureInfo.Name.ToLower())
                {
                    case "fr-ca":
                        return 1;
                    case "en-us":
                        return 0;
                    default:
                        return 0;
                }
            }
        }

        public static int SetCultureInfo
        {
            set
            {
                switch (value)
                {
                    case 0:
                        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = CultureInfo = En;
                        break;
                    case 1:
                        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = CultureInfo = Fr;
                        break;
                    default:
                        Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = CultureInfo = En;
                        break;
                }
            }
        }

        public static CultureInfo Default
        {
            get
            {
                switch (Thread.CurrentThread.CurrentUICulture.Name.ToLower())
                {
                    case "fr-ca":
                        return Fr;
                    case "en-us":
                        return En;
                    default:
                        return En;
                }
            }
        }
    }
}