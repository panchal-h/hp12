//-----------------------------------------------------------------------
// <copyright file="UserMail.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.EmailServices
{
    using System;
    using Models;
    using Resources;
    using SmartLibrary.Infrastructure;

    /// <summary>
    /// This class is used for  information for user email.
    /// </summary>
    /// <CreatedBy>Dharmesh Kotadiya.</CreatedBy>
    /// <CreatedDate>13-Sep-2015.</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class UserMail
    {
        /// <summary>
        /// Send test mail.
        /// </summary>
        /// <param name="templateName">templateName.</param>
        /// <param name="email">email.</param>
        /// <returns>Return Send mail Status.</returns>
        public static bool SendTestEmail(string templateName, string email)
        {
            string subject = "Test Email - " + templateName;

            string emailbody = string.Empty;
            emailbody = Email.GetEmailTemplate(templateName, 1);
            return Email.Send(ProjectConfiguration.FromEmailAddress, email, string.Empty, null, subject, emailbody, 1, sender: "Testing", mailLogo: "book-stack.png");
        }

        /// <summary>
        /// Send forgot password mail.
        /// </summary>
        /// <param name="model">email Value.</param>
        /// <returns>Return Send mail Status.</returns>
        public static bool SendForgotPassword(EmailViewModel model)
        {
            string subject = Constants.FORGOT_PASSWORD;
            string emailbody = string.Empty;
            emailbody = Email.GetEmailTemplate(SystemEnumList.EmailTemplateFileName.ForgotPassword.GetDescription(), model.LanguageId);
            emailbody = emailbody.Replace("[@Email]", model.Email);
            emailbody = emailbody.Replace("[@UserName]", model.Name);
            emailbody = emailbody.Replace("[@LoginUrl]", ProjectConfiguration.SiteUrlBase);
            emailbody = emailbody.Replace("[@ResetUrl]", model.ResetUrl);
            return Email.Send(ProjectConfiguration.FromEmailAddress, model.Email, string.Empty, null, subject, emailbody, model.LanguageId, sender: Constants.COMPANY_NAME, mailLogo: "book-stack.png", LoginUrl: model.ResetUrl);
        }

        /// <summary>
        /// Invite Mail.
        /// </summary>
        /// <param name="model">model.</param>
        /// <returns>Return Send mail Status.</returns>
        public static bool SendInviteMail(EmailViewModel model)
        {
            string subject = Constants.INVITE_CUSTOMER_HEADER;
            string emailbody = string.Empty;
            emailbody = Email.GetEmailTemplate(SystemEnumList.EmailTemplateFileName.InviteCustomer.GetDescription(), model.LanguageId);
            emailbody = emailbody.Replace("[@Email]", model.Email);
            emailbody = emailbody.Replace("[@SignUpUrl]", model.ResetUrl);
            return Email.Send(ProjectConfiguration.FromEmailAddress, model.Email, string.Empty, null, subject, emailbody, model.LanguageId, sender: Constants.COMPANY_NAME, mailLogo: "book-stack.png", LoginUrl: model.ResetUrl);
        }

        /// <summary>
        /// Confirm Book Borrow.
        /// </summary>
        /// <param name="model">model.</param>
        /// <returns>Return Send mail Status.</returns>
        public static bool ConfirmBookBorrow(EmailViewModel model)
        {
            string subject = Constants.CONFIRM_BOOK_BORROW_HEADER;
            string emailbody = string.Empty;
            emailbody = Email.GetEmailTemplate(SystemEnumList.EmailTemplateFileName.ConfirmBookBorrow.GetDescription(), model.LanguageId);
            emailbody = emailbody.Replace("[@Name]", model.Name);
            emailbody = emailbody.Replace("[@BookName]", model.BookName);
            emailbody = emailbody.Replace("[@Author]", model.Author);
            emailbody = emailbody.Replace("[@Pickup]", model.Date);
            return Email.Send(ProjectConfiguration.FromEmailAddress, model.Email, string.Empty, null, subject, emailbody, model.LanguageId, Constants.COMPANY_NAME, mailLogo: "book-confirm.png");
        }

        /// <summary>
        /// Cancel Book Borrow.
        /// </summary>
        /// <param name="model">model.</param>
        /// <returns>Return Send mail Status.</returns>
        public static bool CancelBookBorrow(EmailViewModel model)
        {
            string subject = Constants.CANCEL_BOOK_BORROW_HEADER;
            string emailbody = string.Empty;
            emailbody = Email.GetEmailTemplate(SystemEnumList.EmailTemplateFileName.CancelBookBorrow.GetDescription(), model.LanguageId);
            emailbody = emailbody.Replace("[@Name]", model.Name);
            emailbody = emailbody.Replace("[@BookName]", model.BookName);
            emailbody = emailbody.Replace("[@Author]", model.Author);
            emailbody = emailbody.Replace("[@Pickup]", model.Date);
            return Email.Send(ProjectConfiguration.FromEmailAddress, model.Email, string.Empty, null, subject, emailbody, model.LanguageId, Constants.COMPANY_NAME, mailLogo: "book-cancel.png");
        }

        /// <summary>
        /// Room Booking Request.
        /// </summary>
        /// <param name="model">model.</param>
        /// <returns>Return Send mail Status.</returns>
        public static bool RoomBookingRequest(EmailViewModel model)
        {
            string subject = Constants.ROOM_BOOKING_REQUEST;
            string emailbody = string.Empty;
            emailbody = Email.GetEmailTemplate(SystemEnumList.EmailTemplateFileName.RoomBookingRequest.GetDescription(), model.LanguageId);
            emailbody = emailbody.Replace("[@SpaceName]", model.RoomName);
            emailbody = emailbody.Replace("[@Date]", model.Date);
            emailbody = emailbody.Replace("[@Name]", model.Name);
            emailbody = emailbody.Replace("[@People]", model.People);
            emailbody = emailbody.Replace("[@FromTime]", model.Fromtime);
            emailbody = emailbody.Replace("[@Totime]", model.Totime);
            return Email.Send(ProjectConfiguration.FromEmailAddress, model.Email, string.Empty, null, subject, emailbody, model.LanguageId, sender: Constants.COMPANY_NAME, mailLogo: "RoombookingRequest.png", LoginUrl: ProjectConfiguration.SiteUrlBase);
        }

        /// <summary>
        /// Room Booking Approve.
        /// </summary>
        /// <param name="model">model.</param>
        /// <returns>Return Send mail Status.</returns>
        public static bool RoomBookingApprove(EmailViewModel model)
        {
            string subject = Constants.ROOM_BOOKING_APPROVE_HEADER;
            string emailbody = string.Empty;
            emailbody = Email.GetEmailTemplate(SystemEnumList.EmailTemplateFileName.RoomBookingApproval.GetDescription(), model.LanguageId);
            emailbody = emailbody.Replace("[@SpaceName]", model.RoomName);
            emailbody = emailbody.Replace("[@Date]", model.Date);
            emailbody = emailbody.Replace("[@Name]", model.Name);
            emailbody = emailbody.Replace("[@People]", model.People);
            emailbody = emailbody.Replace("[@FromTime]", model.Fromtime);
            emailbody = emailbody.Replace("[@Totime]", model.Totime);
            return Email.Send(ProjectConfiguration.FromEmailAddress, model.Email, string.Empty, null, subject, emailbody, model.LanguageId, sender: Constants.COMPANY_NAME, mailLogo: "room-confirm.png");
        }

        /// <summary>
        /// Room Booking Cancel.
        /// </summary>
        /// <param name="model">model.</param>
        /// <returns>Return Send mail Status.</returns>
        public static bool RoomBookingCancel(EmailViewModel model)
        {
            string subject = Constants.ROOM_BOOKING_CANCEL_HEADER;
            string emailbody = string.Empty;
            emailbody = Email.GetEmailTemplate(SystemEnumList.EmailTemplateFileName.RoomBookingCancellation.GetDescription(), model.LanguageId);
            emailbody = emailbody.Replace("[@SpaceName]", model.RoomName);
            emailbody = emailbody.Replace("[@Date]", model.Date);
            emailbody = emailbody.Replace("[@FromTime]", model.Fromtime);
            emailbody = emailbody.Replace("[@Name]", model.Name);
            emailbody = emailbody.Replace("[@People]", model.People);
            emailbody = emailbody.Replace("[@Totime]", model.Totime);
            return Email.Send(ProjectConfiguration.FromEmailAddress, model.Email, string.Empty, null, subject, emailbody, model.LanguageId, sender: Constants.COMPANY_NAME, mailLogo: "room-cancel.png");
        }

        /// <summary>
        /// Room Booking Reschedule.
        /// </summary>
        /// <param name="model">model.</param>
        /// <returns>Return Send mail Status.</returns>
        public static bool RoomBookingReschedule(EmailViewModel model)
        {
            string subject = Constants.ROOM_BOOKING_RESCHEDULE_HEADER;
            string emailbody = string.Empty;
            emailbody = Email.GetEmailTemplate(SystemEnumList.EmailTemplateFileName.RoomBookingReschedule.GetDescription(), model.LanguageId);
            emailbody = emailbody.Replace("[@OldSpaceName]", model.OldroomName);
            emailbody = emailbody.Replace("[@NewSpaceName]", model.RoomName);
            emailbody = emailbody.Replace("[@OldDate]", model.OldDate);
            emailbody = emailbody.Replace("[@OldFromTime]", model.OldFromtime);
            emailbody = emailbody.Replace("[@OldTotime]", model.OldTotime);
            emailbody = emailbody.Replace("[@OldPeople]", model.OldPeople);
            emailbody = emailbody.Replace("[@NewDate]", model.Date);
            emailbody = emailbody.Replace("[@NewFromTime]", model.Fromtime);
            emailbody = emailbody.Replace("[@NewTotime]", model.Totime);
            emailbody = emailbody.Replace("[@NewPeople]", model.People);
            emailbody = emailbody.Replace("[@Name]", model.Name);
            return Email.Send(ProjectConfiguration.FromEmailAddress, model.Email, string.Empty, null, subject, emailbody, model.LanguageId, sender: Constants.COMPANY_NAME, mailLogo: "Reschedule.png");
        }

        /// <summary>
        /// Overdue of Book.
        /// </summary>
        /// <param name="model">model.</param>
        /// <returns>Return Send mail Status.</returns>
        public static bool OverdueBookReminderWithDays(EmailViewModel model)
        {
            string subject = Constants.BOOK_OVERDUE;
            string emailbody = string.Empty;
            emailbody = Email.GetEmailTemplate(SystemEnumList.EmailTemplateFileName.OverdueBookReminderWithDays.GetDescription(), model.LanguageId, model.IsFromJob.ToBoolean());
            emailbody = emailbody.Replace("[@Name]", model.Name);
            emailbody = emailbody.Replace("[@BookName]", model.BookName);
            emailbody = emailbody.Replace("[@Author]", model.Author);
            emailbody = emailbody.Replace("[@SUBJECT]", subject.ToUpper());
            emailbody = emailbody.Replace("[@Sender]", Constants.COMPANY_NAME);
            emailbody = emailbody.Replace("[@OverdueContent]", model.OverdueMessage);
            emailbody = emailbody.Replace("[@LoginUrl]", ProjectConfiguration.FrontEndSiteUrl);
            return Email.Send(ProjectConfiguration.FromEmailAddress, model.Email, string.Empty, null, subject, emailbody, model.LanguageId, Constants.COMPANY_NAME, Email.EmailType.NoMaster, mailLogo: "overdue.png");
        }

        /// <summary>
        /// Overdue of Book.
        /// </summary>
        /// <param name="model">model.</param>
        /// <returns>Return Send mail Status.</returns>
        public static bool OverdueBookReminder(EmailViewModel model)
        {
            string subject = Constants.BOOK_OVERDUE;
            string emailbody = string.Empty;
            emailbody = Email.GetEmailTemplate(SystemEnumList.EmailTemplateFileName.OverdueBookReminder.GetDescription(), model.LanguageId, model.IsFromJob.ToBoolean());
            emailbody = emailbody.Replace("[@Name]", model.Name);
            emailbody = emailbody.Replace("[@BookName]", model.BookName);
            emailbody = emailbody.Replace("[@Author]", model.Author);
            emailbody = emailbody.Replace("[@Sender]", Constants.COMPANY_NAME);
            emailbody = emailbody.Replace("[@Returndate]", model.Date);
            emailbody = emailbody.Replace("[@SUBJECT]", subject.ToUpper());
            emailbody = emailbody.Replace("[@LoginUrl]", ProjectConfiguration.FrontEndSiteUrl);
            return Email.Send(ProjectConfiguration.FromEmailAddress, model.Email, string.Empty, null, subject, emailbody, model.LanguageId, Constants.COMPANY_NAME, Email.EmailType.NoMaster, mailLogo: "overdue.png");
        }

        /// <summary>
        /// Room Booking Request for Admin.
        /// </summary>
        /// <param name="model">model.</param>
        /// <returns>Return Send mail Status.</returns>
        public static bool RoomBookingRequestToAdmin(EmailViewModel model)
        {
            string subject = Constants.ROOM_BOOKING_REQUEST_FOR_ADMIN;
            string emailbody = string.Empty;
            emailbody = Email.GetEmailTemplate(SystemEnumList.EmailTemplateFileName.RoomBookingRequestForAdmin.GetDescription(), model.LanguageId);
            emailbody = emailbody.Replace("[@CustomerName]", model.Name);
            emailbody = emailbody.Replace("[@SpaceName]", model.RoomName);
            emailbody = emailbody.Replace("[@Date]", model.Date);
            emailbody = emailbody.Replace("[@People]", model.People);
            emailbody = emailbody.Replace("[@FromTime]", model.Fromtime);
            emailbody = emailbody.Replace("[@Totime]", model.Totime);
            return Email.Send(ProjectConfiguration.FromEmailAddress, model.Email, string.Empty, null, subject, emailbody, model.LanguageId, sender: model.Name);
        }

        /// <summary>
        /// Request for Book Borrow to the Admin.
        /// </summary>
        /// <param name="model">model.</param> 
        /// <returns>Return Send mail Status.</returns>
        public static bool BookBorrowRequestForAdmin(EmailViewModel model)
        {
            string subject = Constants.BORROWBOOK_REQUEST_FOR_ADMIN;
            string emailbody = string.Empty;
            emailbody = Email.GetEmailTemplate(SystemEnumList.EmailTemplateFileName.BookBorrowRequestForAdmin.GetDescription(), model.LanguageId);
            emailbody = emailbody.Replace("[@CustomerName]", model.Name);
            emailbody = emailbody.Replace("[@BookName]", model.BookName);
            emailbody = emailbody.Replace("[@Author]", model.Author);
            emailbody = emailbody.Replace("[@Pickup]", model.Date);
            emailbody = emailbody.Replace("[@Duration]", model.Duration);
            return Email.Send(ProjectConfiguration.FromEmailAddress, model.Email, string.Empty, null, subject, emailbody, model.LanguageId, sender: model.Name);
        }

        /// <summary>
        /// Request for Book Borrow to the Admin.
        /// </summary>
        /// <param name="model">model.</param>
        /// <returns>Return Send mail Status.</returns>
        public static bool MessageAlertForCustomer(EmailViewModel model)
        {
            string subject = Constants.MESSAGE_NOTIFICATION_HEADER;
            string emailbody = string.Empty;
            emailbody = EmailServices.Email.GetEmailTemplate(SystemEnumList.EmailTemplateFileName.MessageAlertForCustomer.GetDescription(), model.LanguageId);
            emailbody = emailbody.Replace("[@Message]", model.AdminMessage);

            emailbody = emailbody.Replace("[@Name]", model.Name);
            return EmailServices.Email.Send(ProjectConfiguration.FromEmailAddress, model.Email, string.Empty, null, subject, emailbody, model.LanguageId, sender: Constants.COMPANY_NAME, mailLogo: "message.png");
        }

        /// <summary>
        /// Notify Customer 
        /// </summary>
        /// <param name="model">model.</param>
        /// <returns>Return Send mail Status.</returns>
        public static bool NotifyCustomerForBook(EmailViewModel model)
        {
            string subject = Constants.BOOK_AVAILABLE;
            string emailbody = string.Empty;
            emailbody = Email.GetEmailTemplate(SystemEnumList.EmailTemplateFileName.NotifyCustomerForBook.GetDescription(), model.LanguageId);
            emailbody = emailbody.Replace("[@Name]", model.Name);
            emailbody = emailbody.Replace("[@BookName]", model.BookName);
            emailbody = emailbody.Replace("[@Author]", model.Author);
            return Email.Send(ProjectConfiguration.FromEmailAddress, model.Email, string.Empty, null, subject, emailbody, model.LanguageId, sender: Constants.COMPANY_NAME, mailLogo: "book-stack.png");
        }
    }
}
