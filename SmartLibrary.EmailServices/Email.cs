//-----------------------------------------------------------------------
// <copyright file="Email.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.EmailServices
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text.RegularExpressions;
    using SmartLibrary.Infrastructure;

    /// <summary>
    /// This class is used for email sending.
    /// </summary>
    /// <CreatedBy>Tirthak Shah.</CreatedBy>
    /// <CreatedDate>14-Aug-2018.</CreatedDate>
    internal class Email
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        public Email()
        {
        }

        /// <summary>
        /// Email type.
        /// </summary>
        public enum EmailType
        {
            /// <summary>
            /// Default Type with Master Template
            /// </summary>
            Default,

            /// <summary>
            /// Mail without Master Template
            /// </summary>
            NoMaster,
        }

        /// <summary>
        /// Sending An Email with master mail template.
        /// </summary>
        /// <param name="mailFrom">Mail From.</param>
        /// <param name="mailTo">Mail To.</param>
        /// <param name="mailCC">Mail CC.</param>
        /// <param name="mailBCC">Mail BCC.</param>
        /// <param name="subject">Mail Subject.</param>
        /// <param name="body">Mail Body.</param>
        /// <param name="languageId">Mail Language.</param>
        /// <param name="emailType">Email Type.</param>
        /// <param name="attachment">Mail Attachment.</param>
        /// <param name="mailLogo">Mail Logo</param>
        /// <param name="LoginUrl">Login Url</param>
        /// <param name="attachmentByteList">Attachment byte list for the mail.</param>
        /// <param name="attachmentName">Attachment file name for the mail.</param>
        /// <param name="sender">Sender.</param>
        /// <returns>return send status.</returns>
        public static bool Send(string mailFrom, string mailTo, string mailCC, string mailBCC, string subject, string body, int languageId, EmailType emailType, string attachment, string mailLogo, string LoginUrl, List<byte[]> attachmentByteList = null, string attachmentName = null, string sender = null)
        {
            if (ProjectConfiguration.SkipEmail)
            {
                return true;
            }

            if (ProjectConfiguration.IsEmailTest)
            {
                mailTo = ProjectConfiguration.FromEmailAddress;
                mailCC = string.Empty;
                mailBCC = string.Empty;
            }

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            if (!string.IsNullOrEmpty(mailFrom))
            {
                mailFrom = mailFrom.Trim(';').Trim(',');
            }

            if (!string.IsNullOrEmpty(mailTo))
            {
                mailTo = mailTo.Trim(';').Trim(',');
            }

            if (!string.IsNullOrEmpty(mailCC))
            {
                mailCC = mailCC.Trim(';').Trim(',');
            }

            if (!string.IsNullOrEmpty(mailBCC))
            {
                mailBCC = mailBCC.Trim(';').Trim(',');
            }

            if (ValidateEmail(mailFrom, mailTo) && (string.IsNullOrEmpty(mailCC) || ValidateEmail(mailCC)) && (string.IsNullOrEmpty(mailBCC) || ValidateEmail(mailBCC)))
            {
                System.Net.Mail.MailMessage mailMesg = new System.Net.Mail.MailMessage();
                mailMesg.From = new System.Net.Mail.MailAddress(mailFrom);
                if (!string.IsNullOrEmpty(mailTo))
                {
                    mailTo = mailTo.Replace(";", ",");
                    mailMesg.To.Add(mailTo);
                }

                if (!string.IsNullOrEmpty(mailCC))
                {
                    mailCC = mailCC.Replace(";", ",");
                    mailMesg.CC.Add(mailCC);
                }

                if (!string.IsNullOrEmpty(mailBCC))
                {
                    mailBCC = mailBCC.Replace(";", ",");
                    mailMesg.Bcc.Add(mailBCC);
                }

                if (!string.IsNullOrEmpty(attachment) && string.IsNullOrEmpty(attachmentName))
                {
                    string[] attachmentArray = attachment.Trim(';').Split(';');
                    foreach (string attachFile in attachmentArray)
                    {
                        try
                        {
                            System.Net.Mail.Attachment attach = new System.Net.Mail.Attachment(attachFile);
                            mailMesg.Attachments.Add(attach);
                        }
                        catch
                        {
                        }
                    }
                }
                else if (!string.IsNullOrEmpty(attachment) && !string.IsNullOrEmpty(attachmentName))
                {
                    string[] attachmentArray = attachment.Trim(';').Split(';');
                    string[] attachmentNameArray = attachmentName.Trim(';').Split(';');

                    if (attachmentArray.Length == attachmentNameArray.Length)
                    {
                        for (int cnt = 0; cnt <= attachmentArray.Length - 1; cnt++)
                        {
                            if (System.IO.File.Exists(attachmentArray[cnt]))
                            {
                                try
                                {
                                    string fileName = ConvertTo.String(attachmentName[cnt]);
                                    if (!string.IsNullOrEmpty(fileName))
                                    {
                                        System.IO.FileStream fs = new System.IO.FileStream(attachmentArray[cnt], System.IO.FileMode.Open, System.IO.FileAccess.Read);
                                        System.Net.Mail.Attachment attach = new System.Net.Mail.Attachment(fs, fileName);
                                        mailMesg.Attachments.Add(attach);
                                    }
                                }
                                catch
                                {
                                }
                            }
                        }
                    }
                }

                if (attachmentByteList != null && attachmentName != null)
                {
                    string[] attachmentNameArray = attachmentName.Trim(';').Split(';');

                    if (attachmentByteList.Count == attachmentNameArray.Length)
                    {
                        for (int cnt = 0; cnt <= attachmentByteList.Count - 1; cnt++)
                        {
                            string fileName = attachmentNameArray[cnt];
                            if (!string.IsNullOrEmpty(fileName))
                            {
                                try
                                {
                                    MemoryStream ms = new MemoryStream(attachmentByteList[cnt]);
                                    System.Net.Mail.Attachment attach = new System.Net.Mail.Attachment(ms, fileName);
                                    mailMesg.Attachments.Add(attach);
                                }
                                catch
                                {
                                }
                            }
                        }
                    }
                }

                mailMesg.Subject = subject;
                mailMesg.AlternateViews.Add(GetMasterBody(body, subject, emailType, languageId, sender, mailLogo, LoginUrl));
                mailMesg.IsBodyHtml = true;

                System.Net.Mail.SmtpClient objSMTP = new System.Net.Mail.SmtpClient();
                try
                {
                    objSMTP.Send(mailMesg);
                    return true;
                }
                catch (Exception ex)
                {
                    LogWritter.WriteErrorFile(ex);
                }
                finally
                {
                    objSMTP.Dispose();
                    mailMesg.Dispose();
                    mailMesg = null;
                }
            }

            return false;
        }

        /// <summary>
        ///  Sending An Email with master mail template.
        /// </summary>
        /// <param name="mailFrom">Mail From.</param>
        /// <param name="mailTo">Mail To.</param>
        /// <param name="mailCC">Mail CC.</param>
        /// <param name="mailBCC">Mail BCC.</param>
        /// <param name="subject">Mail Subject.</param>
        /// <param name="body">Mail Body.</param>
        /// <param name="languageId">User Language.</param>
        /// <param name="sender">Sender</param>
        /// <param name="emailType">Email Type.</param>
        /// <param name="mailLogo">Mail Logo.</param>
        /// <returns>return send status.</returns>
        public static bool Send(string mailFrom, string mailTo, string mailCC, string mailBCC, string subject, string body, int languageId, string sender, EmailType emailType = EmailType.Default, string mailLogo = null, string LoginUrl = null)
        {
            return Send(mailFrom, mailTo, mailCC, mailBCC, subject, body, languageId, emailType, string.Empty, sender: sender, mailLogo: mailLogo, LoginUrl: LoginUrl);
        }

        /// <summary>
        /// Read the Template from Format and return.
        /// </summary>
        /// <param name="emailTemplate">Email Template.</param>
        /// <param name="languageId">User Language.</param>
        /// <param name="isFromJobs">isFromJobs.</param>
        /// <returns>Return body Of Email Template.</returns>
        public static string GetEmailTemplate(string emailTemplate, int languageId, bool isFromJobs = false)
        {
            string bodyTemplate = string.Empty;
            string filePath = isFromJobs ? ProjectConfiguration.EmailTemplatePathJobs + "\\" + emailTemplate + ".html" : ProjectConfiguration.EmailTemplatePath + emailTemplate + ".html";
            //// No Email Template for arabic laguage
            ////if (languageId == SystemEnumList.Language.Arabic.GetHashCode())
            ////{
            ////    filePath = ProjectConfiguration.EmailTemplatePath + emailTemplate + "_ar.html";
            ////}

            if (File.Exists(filePath))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        bodyTemplate = reader.ReadToEnd();
                    }
                }
                catch
                {
                    throw;
                }
            }

            return bodyTemplate;
        }

        /// <summary>
        /// Method is used to Validate Email.
        /// </summary>
        /// <param name="fromEmail">From email List.</param>
        /// <param name="toEmail">To Email list.</param>
        /// <returns>Returns validation result.</returns>
        private static bool ValidateEmail(string fromEmail, string toEmail)
        {
            bool isValid = true;
            if (!IsEmail(fromEmail))
            {
                isValid = false;
            }

            isValid = ValidateEmail(toEmail);

            return isValid;
        }

        /// <summary>
        /// Method is used to Validate Email.
        /// </summary>
        /// <param name="emails">Email list.</param>
        /// <returns>Returns validation result.</returns>
        private static bool ValidateEmail(string emails)
        {
            bool isValid = true;

            if (!string.IsNullOrEmpty(emails))
            {
                emails = emails.Replace(" ", string.Empty);
                string[] emailList = null;
                try
                {
                    emails = emails.Replace(';', ',');
                    emailList = emails.Split(',');
                }
                catch
                {
                    isValid = false;
                }

                if (emailList != null && emailList.Count() > 0)
                {
                    foreach (string email in emailList)
                    {
                        if (!IsEmail(email))
                        {
                            isValid = false;
                        }
                    }
                }
                else
                {
                    isValid = false;
                }
            }
            else
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Check email string is Email or not.
        /// </summary>
        /// <param name="email">Email to verify.</param>
        /// <returns>return email validation result.</returns>
        private static bool IsEmail(string email)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Get Master Body HTML.
        /// </summary>
        /// <param name="body">Body Text.</param>
        /// <param name="subject">Mail Subject.</param>
        /// <param name="emailType">Email Type.</param>
        /// <param name="languageId">User Language.</param>
        /// <returns>Alternate View.</returns>
        private static System.Net.Mail.AlternateView GetMasterBody(string body, string subject, EmailType emailType, int languageId, string sender, string mailLogo, string LoginUrl)
        {
            string logoPath = string.Empty;
            string mailLogoPath = string.Empty;
            if (emailType == EmailType.Default)
            {
                logoPath = ProjectConfiguration.SiteUrlBase + "/images/logo.png";
                mailLogoPath = ProjectConfiguration.SiteUrlBase + "/images/" + mailLogo;
                string masterEmailTemplate = string.Empty;
                if (subject == Constants.BORROWBOOK_REQUEST_FOR_ADMIN || subject == Constants.ROOM_BOOKING_REQUEST_FOR_ADMIN)
                {
                    masterEmailTemplate = Email.GetEmailTemplate(SystemEnumList.EmailTemplateFileName.MasterEmailTemplateForAdmin.ToString(), languageId);
                    masterEmailTemplate = masterEmailTemplate.Replace("[@SUBJECT]", subject);
                }
                else
                {
                    masterEmailTemplate = Email.GetEmailTemplate(SystemEnumList.EmailTemplateFileName.MasterEmailTemplate.ToString(), languageId);
                    masterEmailTemplate = masterEmailTemplate.Replace("[@SUBJECT]", subject.ToUpper());
                }

                body = masterEmailTemplate.Replace("[@BODYCONTENT]", body);
               
                body = body.Replace("[@Sender]", sender);
                if (LoginUrl == null)
                {
                    LoginUrl = ProjectConfiguration.FrontEndSiteUrl;
                }
                body = body.Replace("[@LoginUrl]", LoginUrl);
                if (subject == Constants.FORGOT_PASSWORD)
                {
                    body = body.Replace("[@LoginText]", "Reset");
                }
                else
                {
                    body = body.Replace("[@LoginText]", "Login");
                }
            }
            else
            {
                logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"images") + "/logo.png";
                mailLogoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"images") + "/" + mailLogo;
            }

            System.Net.Mail.AlternateView htmlView = System.Net.Mail.AlternateView.CreateAlternateViewFromString(body, null, "text/html");
            if (!string.IsNullOrEmpty(logoPath))
            {
                htmlView.LinkedResources.Add(GetImageResource("LogoImage", logoPath));

            }
            if (!string.IsNullOrEmpty(mailLogo))
            {
                htmlView.LinkedResources.Add(GetImageResource("MailHeaderIcon", mailLogoPath));
            }

            return htmlView;
        }

        private static System.Net.Mail.LinkedResource GetImageResource(string contentId, string imagePath)
        {
            byte[] imageBytes;
            using (WebClient webClient = new WebClient())
            {
                imageBytes = webClient.DownloadData(imagePath);
            }

            System.Net.Mail.LinkedResource imageResource = new System.Net.Mail.LinkedResource(new MemoryStream(imageBytes), "image/gif");
            imageResource.ContentId = contentId;
            imageResource.TransferEncoding = System.Net.Mime.TransferEncoding.Base64;
            return imageResource;
        }
    }
}
