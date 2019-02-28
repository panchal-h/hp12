//-----------------------------------------------------------------------
// <copyright file="ProjectConfiguration.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Web;

    /// <summary>
    /// Project Configuration used to initialize all configuration setting.
    /// </summary>
    /// <CreatedBy> Hardik Panchal. </CreatedBy>
    /// <CreatedDate>14-Aug-2018.</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class ProjectConfiguration
    {
        #region Variable
        #endregion

        #region Configuration Settings

        /// <summary>
        /// Gets the Configuration From Email Address.
        /// </summary>
        public static string FromEmailAddress
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["FromEmailAddress"]);
            }
        }

        /// <summary>
        /// Gets the Configuration From Guest Login URL.
        /// </summary>
        public static string FormAunthenticationGuestLoginUrl
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["FormAunthenticationGuestLoginUrl"]);
            }
        }

        /// <summary>
        /// Gets the Configuration From Guest Login URL.
        /// </summary>
        public static string GetADuserDataWithPCNo
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["GetADuserDataWithPCNo"]);
            }
        }

        /// <summary>
        /// Gets the Configuration From Active Directory Register.
        /// </summary>
        public static string ActiveDirectoryRegisterUrl
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["ActiveDirectoryRegisterUrl"]);
            }
        }

        /// <summary>
        /// Gets the Configuration From Active Directory Register.
        /// </summary>
        public static string ActiveDirectoryUpdateUrl
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["ActiveDirectoryUpdateUrl"]);
            }
        }

        /// <summary>
        /// Gets the Configuration From Active Directory Register.
        /// </summary>
        public static string ActiveDirectoryChangePasswordUrl
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["ActiveDirectoryChangePasswordUrl"]);
            }
        }

        /// <summary>
        /// Gets the Configuration Test To Email Address.
        /// </summary>
        public static string TestEmailToAddress
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["TestEmailToAddress"]);
            }
        }

        /// <summary>
        /// Gets a value indicating whether is Send mail on Test account or not.
        /// </summary>
        public static bool IsEmailTest
        {
            get
            {
                return ConvertTo.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["IsEmailTest"]);
            }
        }

        /// <summary>
        /// Gets the RSA Public Key.
        /// </summary>
        public static string RSAPublicKey
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["RSAPublicKey"]);
            }
        }

        /// <summary>
        /// Gets the Configuration Web Admin Email Address.
        /// </summary>
        public static string AdminEmailAddress
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["AdminEmailAddress"]);
            }
        }

        /// <summary>
        /// Gets the Active Directory Login url.
        /// </summary>
        public static string ActiveDirectoryLoginUrl
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["ActiveDirectoryLoginUrl"]);
            }
        }

        /// <summary>
        /// Gets the Active Directory Login url.
        /// </summary>
        public static string ActiveDirectoryDirectLoginIFrameURL
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["ActiveDirectoryDirectLoginIFrameURL"]);
            }
        }

        /// <summary>
        /// Gets the Active Directory Login url.
        /// </summary>
        public static string ActiveDirectoryDirectLogin
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["ActiveDirectoryDirectLogin"]);
            }
        }

        /// <summary>
        /// Gets the Active Directory User list Url.
        /// </summary>
        public static string ActiveDirectoryUserUrl
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["ActiveDirectoryUserUrl"]);
            }
        }

        /// <summary>
        /// Gets the main site URL.
        /// </summary>
        public static string MainSiteURL
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["MainSiteURL"]);
            }
        }

        /// <summary>
        /// Gets the Configuration database server name.
        /// </summary>
        public static string DatabaseServerName
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["DatabaseServerName"]);
            }
        }

        /// <summary>
        /// Gets a value indicating whether [is log error].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [is log error]; otherwise, <c>false</c>.
        /// </value>
        public static bool IsLogError
        {
            get
            {
                return ConvertTo.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["IsLogError"]);
            }
        }

        /// <summary>
        /// Gets Image Path.
        /// </summary>
        public static string ImagePath
        {
            get
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets Video Path.
        /// </summary>
        public static string VideoPath
        {
            get
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets Allowed Media Format.
        /// </summary>
        public static string[] AllowedMediaFormat
        {
            get
            {
                return new string[] { ".png", ".jpg", ".jpeg", ".mp4" };
            }
        }

        /// <summary>
        /// Gets Allowed Document Format.
        /// </summary>
        public static string[] AllowedDocumentFormat
        {
            get
            {
                return new string[] { ".pdf", ".doc", ".docx", ".xls", ".xlsx", ".png", ".jpg", ".jpeg", ".ppt", ".pptx", ".txt" };
            }
        }

        /// <summary>
        /// Gets the Configuration Reset Password Expire Time in Minutes.
        /// </summary>
        public static int ResetPasswordExpireTime
        {
            get
            {
                return ConvertTo.ToInteger(System.Configuration.ConfigurationManager.AppSettings["ResetPasswordExpireTime"]);
            }
        }

        /// <summary>
        /// Gets the Configuration Google Book API APIKey.
        /// </summary>
        public static string GoogleBookService_APIKey
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["GoogleBookAPIKey"]);
            }
        }

        /// <summary>
        /// Gets the Configuration Active ISBN API.
        /// </summary>
        public static string ActiveISBNAPI
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["ActiveISBNAPI"]);
            }
        }

        /// <summary>
        /// Gets Error message temp data string.
        /// </summary>
        /// <value>
        /// Error message temp data string.
        /// </value>
        public static string ErrorMessageTempData => "ErrorMessage";

        /// <summary>
        /// Gets the Configuration SignalR Hub Proxy Url.
        /// </summary>
        public static string SignalRHubProxyUrl
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["SignalRHubProxyUrl"]);
            }
        }

        /// <summary>
        /// Gets the Return Book Remaining Day Count for display notifications.
        /// </summary>
        public static int ReturnBookRemainingDayCount
        {
            get
            {
                return ConvertTo.ToInteger(System.Configuration.ConfigurationManager.AppSettings["ReturnBookRemainingDayCount"]);
            }
        }

        /// <summary>
        /// Gets a value indicating whether [is log error].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [is log error]; otherwise, <c>false</c>.
        /// </value>
        public static bool SkipEmail
        {
            get
            {
                return ConvertTo.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["SkipEmail"]);
            }
        }

        /// <summary>
        /// Gets a value indicating whether is Active Directory or not.
        /// </summary>
        public static bool IsActiveDirectory
        {
            get
            {
                return ConvertTo.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["IsActiveDirectory"]);
            }
        }

        /// <summary>
        /// Gets a value of Access in Active Directory login.
        /// </summary>
        public static string AccessTokenForActiveDirectoryLogin
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["AccessTokenForActiveDirectoryLogin"]);
            }
        }

        /// <summary>
        /// Gets a value of Access in Active Directory delete.
        /// </summary>
        public static string ActiveDirectoryDeleteUserUrl
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["ActiveDirectoryDeleteUserUrl"]);
            }
        }
        #endregion

        #region Format      

        /// <summary>
        /// Gets the Date Format.
        /// </summary>
        public static string DateFormat
        {
            get
            {
                return "dd MMM yyyy";
            }
        }

        /// <summary>
        /// Gets the Date Format.
        /// </summary>
        public static string EmailDateTimeFormat
        {
            get
            {
                return "yyyyMMddHHmm";
            }
        }

        /// <summary>
        /// Gets the Date Format.
        /// </summary>
        public static string DateTimeFormat
        {
            get
            {
                return "dd MMM yyyy HH:mm";
            }
        }

        /// <summary>
        /// Gets the Decimal Place.
        /// </summary>
        public static int DecimalPlace
        {
            get
            {
                return 2;
            }
        }

        /// <summary>
        /// Gets the Minimum Date.
        /// </summary>
        public static string MinDate
        {
            get
            {
                return "1/1/1753 12:00:00 AM";
            }
        }

        /// <summary>
        /// Gets the Time Format.
        /// </summary>
        public static string TimeFormat
        {
            get
            {
                return "HH:mm";
            }
        }

        /// <summary>
        /// Gets a page value.
        /// </summary>
        public static int PageSize
        {
            get
            {
                return ConvertTo.ToInteger(ConfigurationManager.AppSettings.Get("PageSize"));
            }
        }

        /// <summary>
        /// Gets a Comment Value
        /// </summary>
        public static int CommentSize
        {
            get
            {
                return ConvertTo.ToInteger(ConfigurationManager.AppSettings.Get("CommentSize"));
            }
        }

        /// <summary>
        /// Gets a page value for Grid.
        /// </summary>
        public static int PageSizeGrid
        {
            get
            {
                return ConvertTo.ToInteger(ConfigurationManager.AppSettings.Get("PageSizeForGrid"));
            }
        }

        /// <summary>
        /// Gets Start Time Value for timepicker
        /// </summary>
        public static string StartTimeForTimepicker => ConfigurationManager.AppSettings.Get("StartTimeForTimepicker");

        /// <summary>
        /// Gets End Time Value for timepicker
        /// </summary>
        public static string EndTimeForTimepicker => ConfigurationManager.AppSettings.Get("EndTimeForTimepicker");

        /// <summary>
        /// Gets End Time Value for timepicker
        /// </summary>
        public static string StepForTimepicker => ConfigurationManager.AppSettings.Get("StepForTimepicker");

        #endregion

        #region System Path

        /// <summary>
        /// Gets the Root Path of the Project
        /// </summary>
        public static string ApplicationRootPath
        {
            get
            {
                string rootPath = HttpContext.Current.Server.MapPath("~");
                if (rootPath.EndsWith("\\", StringComparison.CurrentCulture))
                {
                    return rootPath;
                }
                else
                {
                    return rootPath + "\\";
                }
            }
        }

        /// <summary>
        /// Gets HostName.
        /// </summary>
        public static string HostName
        {
            get { return HttpContext.Current.Request.Url.Host; }
        }

        /// <summary>
        /// Gets Secure User Base.
        /// </summary>
        public static string SecureUrlBase
        {
            get
            {
                return "https://" + UrlSuffix;
            }
        }

        /// <summary>
        /// Gets Url Base.
        /// </summary>
        public static string UrlBase
        {
            get
            {
                return "http://" + UrlSuffix;
            }
        }

        /// <summary>
        /// Gets Site Url Base.
        /// </summary>
        public static string SiteUrlBase
        {
            get
            {
                if (HttpContext.Current.Request.IsSecureConnection)
                {
                    return SecureUrlBase;
                }
                else
                {
                    return UrlBase;
                }
            }
        }

        /// <summary>
        /// Gets FrontEndSite Url Base.
        /// </summary>
        public static string FrontEndSiteUrl
        {
            get
            {
                return ConvertTo.String(System.Configuration.ConfigurationManager.AppSettings["FrontEndSiteUrl"]);
            }
        }

        /// <summary>
        /// Gets Secure User.
        /// </summary>
        public static string SecureUrl
        {
            get
            {
                return "https://" + HostName;
            }
        }

        /// <summary>
        /// Gets Url.
        /// </summary>
        public static string Url
        {
            get
            {
                return "http://" + HostName;
            }
        }

        /// <summary>
        /// Gets Site Url.
        /// </summary>
        public static string SiteUrl
        {
            get
            {
                if (HttpContext.Current.Request.IsSecureConnection)
                {
                    return SecureUrl;
                }
                else
                {
                    return Url;
                }
            }
        }

        /// <summary>
        /// Gets Email Template Path.
        /// </summary>
        public static string EmailTemplatePath
        {
            get
            {
                return HttpContext.Current.Server.MapPath("~/EmailTemplates/");
            }
        }

        /// <summary>
        /// Gets Email Template Path.
        /// </summary>
        public static string EmailTemplatePathJobs
        {
            get
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"EmailTemplates");
                return path;
            }
        }

        /// <summary>
        /// Gets Notification Template Path.
        /// </summary>
        public static string NotificationTemplatePath
        {
            get
            {
                return HttpContext.Current.Server.MapPath("~/NotificationTemplates/");
            }
        }

        /// <summary>
        /// Gets the allowed image format.
        /// </summary>
        /// <value>
        /// The allowed image format.
        /// </value>
        public static string[] AllowedImageFormat
        {
            get
            {
                return new string[] { ".png", ".jpg", ".jpeg" };
            }
        }

        /// <summary>
        /// Gets the default country code.
        /// </summary>
        public static string DefaultCountryCode
        {
            get
            {
                return "+971";
            }
        }

        /// <summary>
        /// Gets current Url.
        /// </summary>
        public static string CurrentUrl
        {
            get
            {
                return HttpContext.Current.Request.Url.ToString();
            }
        }

        /// <summary>
        /// Gets current Url.
        /// </summary>
        public static string CurrentRawUrl
        {
            get
            {
                return HttpContext.Current.Request.RawUrl.ToString();
            }
        }

        /// <summary>
        /// Gets Book Images Url 
        /// </summary>
        public static string BookImagesPath => "BookImages";

        /// <summary>
        /// Gets Book Images Url while Importing 
        /// </summary>
        public static string ImportBookImagesPath => "BookImages/ImportBooks";

        /// <summary>
        /// Gets User Images Url 
        /// </summary>
        public static string UserProfileImagePath => "UserProfileImage";

        /// <summary>
        /// Gets Book temp Images Url 
        /// </summary>
        public static string BookImagesTempPath => "BookImages//temp";

        /// <summary>
        /// Gets Url Suffix.
        /// </summary>
        private static string UrlSuffix
        {
            get
            {
                if (HttpContext.Current.Request.ApplicationPath == "/")
                {
                    return HttpContext.Current.Request.Url.Host + HttpContext.Current.Request.ApplicationPath;
                }
                else
                {
                    return HttpContext.Current.Request.Url.Host + HttpContext.Current.Request.ApplicationPath + "/";
                }
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Add Exception For SCC Web.
        /// </summary>
        /// <param name="e">Exception Value.</param>
        /// <param name="functionName">Function Name.</param>
        /// <returns>Return exception message.</returns>
        public static string ExceptionMessage(Exception e, string functionName)
        {
            string exceptionMessage = string.Empty;
            try
            {
                exceptionMessage += Environment.NewLine + string.Format("----------------------------- {0} ------------------------------", DateTime.Now.ToString(SmartLibrary.Infrastructure.ProjectConfiguration.DateTimeFormat));
                exceptionMessage += Environment.NewLine + string.Format("Function Name : {0}", functionName);
                exceptionMessage += Environment.NewLine + string.Format("Exception Message : {0}", e.Message);

                if (e.InnerException != null)
                {
                    exceptionMessage += Environment.NewLine + string.Format("Exception Inner Exception  : {0}", e.InnerException.ToString());
                }

                exceptionMessage += Environment.NewLine + string.Format("Exception Source : {0}", e.Source);
                exceptionMessage += Environment.NewLine + string.Format("Exception Stack Trace : {0}", e.StackTrace);
                exceptionMessage += Environment.NewLine + string.Format("--------------------------------------------------------------");
            }
            catch (Exception)
            {
            }

            return exceptionMessage;
        }

        /// <summary>
        /// Gets the country alpha3 code.
        /// </summary>
        /// <returns>Country Alpha3 Code</returns>
        public static Dictionary<string, string> GetCountryAlpha3Code()
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            list.Add("AFG", "AFGHANISTAN");
            list.Add("ALA", "ALAND ISLANDS");
            list.Add("ALB", "ALBANIA");
            list.Add("DZA", "ALGERIA");
            list.Add("ASM", "AMERICAN SAMOA");
            list.Add("AND", "ANDORRA");
            list.Add("AGO", "ANGOLA");
            list.Add("AIA", "ANGUILLA");
            list.Add("ATA", "ANTARCTICA");
            list.Add("ATG", "ANTIGUA AND BARBUDA");
            list.Add("ARG", "ARGENTINA");
            list.Add("ARM", "ARMENIA");
            list.Add("ABW", "ARUBA");
            list.Add("AUS", "AUSTRALIA");
            list.Add("AUT", "AUSTRIA");
            list.Add("AZE", "AZERBAIJAN");
            list.Add("BHS", "BAHAMAS");
            list.Add("BHR", "BAHRAIN");
            list.Add("BGD", "BANGLADESH");
            list.Add("BRB", "BARBADOS");
            list.Add("BLR", "BELARUS");
            list.Add("BEL", "BELGIUM");
            list.Add("BLZ", "BELIZE");
            list.Add("BEN", "BENIN");
            list.Add("BMU", "BERMUDA");
            list.Add("BTN", "BHUTAN");
            list.Add("BOL", "BOLIVIA");
            list.Add("BIH", "BOSNIA AND HERZEGOVINA");
            list.Add("BWA", "BOTSWANA");
            list.Add("BVT", "BOUVET ISLAND");
            list.Add("BRA", "BRAZIL");
            list.Add("VGB", "BRITISH VIRGIN ISLANDS");
            list.Add("IOT", "BRITISH INDIAN OCEAN TERRITORY");
            list.Add("BRN", "BRUNEI DARUSSALAM");
            list.Add("BGR", "BULGARIA");
            list.Add("BFA", "BURKINA FASO");
            list.Add("BDI", "BURUNDI");
            list.Add("KHM", "CAMBODIA");
            list.Add("CMR", "CAMEROON");
            list.Add("CAN", "CANADA");
            list.Add("CPV", "CAPE VERDE");
            list.Add("CYM", "CAYMAN ISLANDS");
            list.Add("CAF", "CENTRAL AFRICAN REPUBLIC");
            list.Add("TCD", "CHAD");
            list.Add("CHL", "CHILE");
            list.Add("CHN", "CHINA");
            list.Add("HKG", "HONG KONG, SAR CHINA");
            list.Add("MAC", "MACAO, SAR CHINA");
            list.Add("CXR", "CHRISTMAS ISLAND");
            list.Add("CCK", "COCOS (KEELING) ISLANDS");
            list.Add("COL", "COLOMBIA");
            list.Add("COM", "COMOROS");
            list.Add("COG", "CONGO (BRAZZAVILLE)");
            list.Add("COD", "CONGO, (KINSHASA)");
            list.Add("COK", "COOK ISLANDS");
            list.Add("CRI", "COSTA RICA");
            list.Add("HRV", "CROATIA");
            list.Add("CUB", "CUBA");
            list.Add("CYP", "CYPRUS");
            list.Add("CZE", "CZECH REPUBLIC");
            list.Add("DNK", "DENMARK");
            list.Add("DJI", "DJIBOUTI");
            list.Add("DMA", "DOMINICA");
            list.Add("DOM", "DOMINICAN REPUBLIC");
            list.Add("ECU", "ECUADOR");
            list.Add("EGY", "EGYPT");
            list.Add("SLV", "EL SALVADOR");
            list.Add("GNQ", "EQUATORIAL GUINEA");
            list.Add("ERI", "ERITREA");
            list.Add("EST", "ESTONIA");
            list.Add("ETH", "ETHIOPIA");
            list.Add("FLK", "FALKLAND ISLANDS (MALVINAS)");
            list.Add("FRO", "FAROE ISLANDS");
            list.Add("FJI", "FIJI");
            list.Add("FIN", "FINLAND");
            list.Add("FRA", "FRANCE");
            list.Add("GUF", "FRENCH GUIANA");
            list.Add("PYF", "FRENCH POLYNESIA");
            list.Add("ATF", "FRENCH SOUTHERN TERRITORIES");
            list.Add("GAB", "GABON");
            list.Add("GMB", "GAMBIA");
            list.Add("GEO", "GEORGIA");
            list.Add("DEU", "GERMANY");
            list.Add("GHA", "GHANA");
            list.Add("GIB", "GIBRALTAR");
            list.Add("GRC", "GREECE");
            list.Add("GRL", "GREENLAND");
            list.Add("GRD", "GRENADA");
            list.Add("GLP", "GUADELOUPE");
            list.Add("GUM", "GUAM");
            list.Add("GTM", "GUATEMALA");
            list.Add("GGY", "GUERNSEY");
            list.Add("GIN", "GUINEA");
            list.Add("GNB", "GUINEA-BISSAU");
            list.Add("GUY", "GUYANA");
            list.Add("HTI", "HAITI");
            list.Add("HMD", "HEARD AND MCDONALD ISLANDS");
            list.Add("VAT", "HOLY SEE (VATICAN CITY STATE)");
            list.Add("HND", "HONDURAS");
            list.Add("HUN", "HUNGARY");
            list.Add("ISL", "ICELAND");
            list.Add("IND", "INDIA");
            list.Add("IDN", "INDONESIA");
            list.Add("IRN", "IRAN, ISLAMIC REPUBLIC OF");
            list.Add("IRQ", "IRAQ");
            list.Add("IRL", "IRELAND");
            list.Add("IMN", "ISLE OF MAN");
            list.Add("ISR", "ISRAEL");
            list.Add("ITA", "ITALY");
            list.Add("JAM", "JAMAICA");
            list.Add("JPN", "JAPAN");
            list.Add("JEY", "JERSEY");
            list.Add("JOR", "JORDAN");
            list.Add("KAZ", "KAZAKHSTAN");
            list.Add("KEN", "KENYA");
            list.Add("KIR", "KIRIBATI");
            list.Add("PRK", "KOREA (NORTH)");
            list.Add("KOR", "KOREA (SOUTH)");
            list.Add("KWT", "KUWAIT");
            list.Add("KGZ", "KYRGYZSTAN");
            list.Add("LAO", "LAO PDR");
            list.Add("LVA", "LATVIA");
            list.Add("LBN", "LEBANON");
            list.Add("LSO", "LESOTHO");
            list.Add("LBR", "LIBERIA");
            list.Add("LBY", "LIBYA");
            list.Add("LIE", "LIECHTENSTEIN");
            list.Add("LTU", "LITHUANIA");
            list.Add("LUX", "LUXEMBOURG");
            list.Add("MKD", "MACEDONIA, REPUBLIC OF");
            list.Add("MDG", "MADAGASCAR");
            list.Add("MWI", "MALAWI");
            list.Add("MYS", "MALAYSIA");
            list.Add("MDV", "MALDIVES");
            list.Add("MLI", "MALI");
            list.Add("MLT", "MALTA");
            list.Add("MHL", "MARSHALL ISLANDS");
            list.Add("MTQ", "MARTINIQUE");
            list.Add("MRT", "MAURITANIA");
            list.Add("MUS", "MAURITIUS");
            list.Add("MYT", "MAYOTTE");
            list.Add("MEX", "MEXICO");
            list.Add("FSM", "MICRONESIA, FEDERATED STATES OF");
            list.Add("MDA", "MOLDOVA");
            list.Add("MCO", "MONACO");
            list.Add("MNG", "MONGOLIA");
            list.Add("MNE", "MONTENEGRO");
            list.Add("MSR", "MONTSERRAT");
            list.Add("MAR", "MOROCCO");
            list.Add("MOZ", "MOZAMBIQUE");
            list.Add("MMR", "MYANMAR");
            list.Add("NAM", "NAMIBIA");
            list.Add("NRU", "NAURU");
            list.Add("NPL", "NEPAL");
            list.Add("NLD", "NETHERLANDS");
            list.Add("ANT", "NETHERLANDS ANTILLES");
            list.Add("NCL", "NEW CALEDONIA");
            list.Add("NZL", "NEW ZEALAND");
            list.Add("NIC", "NICARAGUA");
            list.Add("NER", "NIGER");
            list.Add("NGA", "NIGERIA");
            list.Add("NIU", "NIUE");
            list.Add("NFK", "NORFOLK ISLAND");
            list.Add("MNP", "NORTHERN MARIANA ISLANDS");
            list.Add("NOR", "NORWAY");
            list.Add("OMN", "OMAN");
            list.Add("PAK", "PAKISTAN");
            list.Add("PLW", "PALAU");
            list.Add("PSE", "PALESTINIAN TERRITORY");
            list.Add("PAN", "PANAMA");
            list.Add("PNG", "PAPUA NEW GUINEA");
            list.Add("PRY", "PARAGUAY");
            list.Add("PER", "PERU");
            list.Add("PHL", "PHILIPPINES");
            list.Add("PCN", "PITCAIRN");
            list.Add("POL", "POLAND");
            list.Add("PRT", "PORTUGAL");
            list.Add("PRI", "PUERTO RICO");
            list.Add("QAT", "QATAR");
            list.Add("REU", "RÉUNION");
            list.Add("ROU", "ROMANIA");
            list.Add("RUS", "RUSSIAN FEDERATION");
            list.Add("RWA", "RWANDA");
            list.Add("BLM", "SAINT-BARTHÉLEMY");
            list.Add("SHN", "SAINT HELENA");
            list.Add("KNA", "SAINT KITTS AND NEVIS");
            list.Add("LCA", "SAINT LUCIA");
            list.Add("MAF", "SAINT-MARTIN (FRENCH PART)");
            list.Add("SPM", "SAINT PIERRE AND MIQUELON");
            list.Add("VCT", "SAINT VINCENT AND GRENADINES");
            list.Add("WSM", "SAMOA");
            list.Add("SMR", "SAN MARINO");
            list.Add("STP", "SAO TOME AND PRINCIPE");
            list.Add("SAU", "SAUDI ARABIA");
            list.Add("SEN", "SENEGAL");
            list.Add("SRB", "SERBIA");
            list.Add("SYC", "SEYCHELLES");
            list.Add("SLE", "SIERRA LEONE");
            list.Add("SGP", "SINGAPORE");
            list.Add("SVK", "SLOVAKIA");
            list.Add("SVN", "SLOVENIA");
            list.Add("SLB", "SOLOMON ISLANDS");
            list.Add("SOM", "SOMALIA");
            list.Add("ZAF", "SOUTH AFRICA");
            list.Add("SGS", "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS");
            list.Add("SSD", "SOUTH SUDAN");
            list.Add("ESP", "SPAIN");
            list.Add("LKA", "SRI LANKA");
            list.Add("SDN", "SUDAN");
            list.Add("SUR", "SURINAME");
            list.Add("SJM", "SVALBARD AND JAN MAYEN ISLANDS");
            list.Add("SWZ", "SWAZILAND");
            list.Add("SWE", "SWEDEN");
            list.Add("CHE", "SWITZERLAND");
            list.Add("SYR", "SYRIAN ARAB REPUBLIC (SYRIA)");
            list.Add("TWN", "TAIWAN, REPUBLIC OF CHINA");
            list.Add("TJK", "TAJIKISTAN");
            list.Add("TZA", "TANZANIA, UNITED REPUBLIC OF");
            list.Add("THA", "THAILAND");
            list.Add("TLS", "TIMOR-LESTE");
            list.Add("TGO", "TOGO");
            list.Add("TKL", "TOKELAU");
            list.Add("TON", "TONGA");
            list.Add("TTO", "TRINIDAD AND TOBAGO");
            list.Add("TUN", "TUNISIA");
            list.Add("TUR", "TURKEY");
            list.Add("TKM", "TURKMENISTAN");
            list.Add("TCA", "TURKS AND CAICOS ISLANDS");
            list.Add("TUV", "TUVALU");
            list.Add("UGA", "UGANDA");
            list.Add("UKR", "UKRAINE");
            list.Add("ARE", "UNITED ARAB EMIRATES");
            list.Add("GBR", "UNITED KINGDOM");
            list.Add("USA", "UNITED STATES OF AMERICA");
            list.Add("UMI", "US MINOR OUTLYING ISLANDS");
            list.Add("URY", "URUGUAY");
            list.Add("UZB", "UZBEKISTAN");
            list.Add("VUT", "VANUATU");
            list.Add("VEN", "VENEZUELA (BOLIVARIAN REPUBLIC)");
            list.Add("VNM", "VIET NAM");
            list.Add("VIR", "VIRGIN ISLANDS, US");
            list.Add("WLF", "WALLIS AND FUTUNA ISLANDS");
            list.Add("ESH", "WESTERN SAHARA");
            list.Add("YEM", "YEMEN");
            list.Add("ZMB", "ZAMBIA");
            list.Add("ZWE", "ZIMBABWE");

            return list;
        }

        #endregion
    }
}
