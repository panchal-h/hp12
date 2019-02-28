//-----------------------------------------------------------------------
// <copyright file="SystemEnumList.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Used to Define List of System Enum
    /// </summary>
    /// <CreatedBy>Hardik Panchal</CreatedBy>
    /// <CreatedDate>14-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class SystemEnumList
    {
        /// <summary>
        /// BookPeriod
        /// </summary>
        public enum BookPeriod
        {
            [Description("1W")]
            OneWeek = 6,
            [Description("2W")]
            TwoWeek = 13,
            [Description("1M")]
            OneMonth = 29,                       
        }

        /// <summary>
        /// LoginType
        /// </summary>
        public enum LoginType
        {
            [Description("Staff")]
            Staff = 1,
            [Description("Guest")]
            Guest = 2,
        }

        /// <summary>
        /// ChangePasswordFor
        /// </summary>
        public enum ChangePasswordFor
        {
            [Description("USER")]
            User = 1,
            [Description("CUSTOMER")]
            Customer = 2,
        }

        /// <summary>
        /// DaysOfWeek
        /// </summary>
        public enum RequestTypeTodayActivity
        {
            [Description("BD")]
            BookDetails = 1,
            [Description("RB")]
            RoomBookings = 3,
        }

        /// <summary>
        /// DaysOfWeek
        /// </summary>
        public enum DaysOfWeek
        {
            [Description("Monday")]
            Monday = 1,
            [Description("Tuesday")]
            Tuesday = 2,
            [Description("Wednesday")]
            Wednesday = 3,
            [Description("Thursday")]
            Thursday = 4,
            [Description("Friday")]
            Friday = 5,
            [Description("Saturday")]
            Saturday = 6,
            [Description("Sunday")]
            Sunday = 7
        }

        /// <summary>
        /// Reporting
        /// </summary>
        public enum Reports
        {
            [Description("Borrowed Books Count")]
            BorrowedBooksCount = 1,
            [Description("Total Books Count")]
            TotalBooksCount = 2,
            [Description("Total Events")]
            TotalEvents = 3,
            [Description("Total Books Borrowed through Library")]
            TotalBooksBorrowedthroughLibrary = 4,
            [Description("Most Popular Book")]
            MostPopularBook = 5,
            [Description("Most Active Borrower")]
            MostActiveBorrower = 6,
            [Description("Most Popular Genre")]
            MostPopularGenre = 7,
            [Description("Most Popular Author")]
            MostPopularAuthor = 8,
            [Description("Popular User Organizing Event")]
            PopularUserOrganizingEvent = 9,
            [Description("Popular Time For Borrowing Books")]
            PopularTimeForBorrowingBooks = 10,
            [Description("Book Returned On Time")]
            BookReturnedOnTime = 12,
        }

        /// <summary>
        /// Enumeration for EmailTemplateName
        /// </summary>
        public enum EmailTemplateFileName
        {
            /// <summary>
            /// Email Template Master.
            /// </summary>
            [Description("MasterEmailTemplate")]
            MasterEmailTemplate = 1,

            /// <summary>
            /// Email Template Master.
            /// </summary>
            [Description("MasterEmailTemplateForAdmin")]
            MasterEmailTemplateForAdmin,

            /// <summary>
            /// Email Template Forgot Password Body.
            /// </summary>
            [Description("ForgotPassword")]
            ForgotPassword,

            /// <summary>
            /// Email Template Invite Customer Body.
            /// </summary>
            [Description("InviteCustomer")]
            InviteCustomer,

            /// <summary>
            /// Email Template Admin Forgot Password Body.
            /// </summary>
            [Description("AdminForgotPassword")]
            AdminForgotPassword,

            /// <summary>
            /// Email Template PasswordChanged Body.
            /// </summary>
            [Description("PasswordChanged")]
            PasswordChanged,

            /// <summary>
            /// Email Template ResetPassword Body.
            /// </summary>
            [Description("ResetPassword")]
            ResetPassword,

            /// <summary>
            /// Email Template AddClient Body.
            /// </summary>
            [Description("AddClient")]
            AddClient,

            /// <summary>
            /// Email Template for Confirm Boo kBorrow.
            /// </summary>
            [Description("ConfirmBookBorrow")]
            ConfirmBookBorrow,

            /// <summary>
            /// Email Template for Confirm Boo kBorrow.
            /// </summary>
            [Description("CancelBookBorrow")]
            CancelBookBorrow,

            /// <summary>
            /// Email Template for Request Room Booking
            /// </summary>
            [Description("RoomBookingRequest")]
            RoomBookingRequest,

            /// <summary>
            /// Email Template for Approve Room Booking
            /// </summary>
            [Description("RoomBookingApproval")]
            RoomBookingApproval,

            /// <summary>
            /// Email Template for Cancel Room Booking
            /// </summary>
            [Description("RoomBookingCancellation")]
            RoomBookingCancellation,

            /// <summary>
            /// Email Template for Reschedule Room Booking
            /// </summary>
            [Description("RoomBookingReschedule")]
            RoomBookingReschedule,

            /// <summary>
            /// Email Template for Request Room Booking for Admin.
            /// </summary>
            [Description("RoomBookingRequestForAdmin")]
            RoomBookingRequestForAdmin,

            /// <summary>
            /// Email Template for Book Borrow Request for Admin.
            /// </summary>
            [Description("BookBorrowRequestForAdmin")]
            BookBorrowRequestForAdmin,

            /// <summary>
            /// Email Template for Overdue Book Reminder.
            /// </summary>
            [Description("OverdueBookReminderWithDays")]
            OverdueBookReminderWithDays,

            /// <summary>
            /// Email Template for Message Alert For Customer.
            /// </summary>
            [Description("MessageAlertForCustomer")]
            MessageAlertForCustomer,

            /// <summary>
            /// Email Template for Overdue Book Reminder.
            /// </summary>
            [Description("OverdueBookReminder")]
            OverdueBookReminder,

            /// <summary>
            /// Email Template for Book Notification.
            /// </summary>
            [Description("NotifyCustomerForBook")]
            NotifyCustomerForBook
        }

        /// <summary>
        /// New file extensions must match up to an item in the MagicNumbers list below. When adding an enum value
        /// here, see comments on the MagicNumber list on adding the associated magic number as well.
        /// </summary>
        public enum FileExtension
        {
            Gif,
            Jpg,
            Jpeg,
            Png,
            Pdf,
            Tiff,
            Tif,
            Mtiff,
            Xml,
            Mp3,
            Doc,
            Docx,
            Xls,
            Xlsx,
            Csv,
            Ppt,
            Pptx,
            Unknown
        }

        /// <summary>
        /// Enum for date format
        /// </summary>
        public enum DATEFORMAT
        {
            /// <summary>
            /// Date format
            /// </summary>
            [Display(Name = "dd-MM-yyyy")]
            DDMMYYYY,

            /// <summary>
            /// Date format
            /// </summary>
            [Display(Name = "MM/dd/yyyy")]
            MMDDYYYY,

            /// <summary>
            /// Date format
            /// </summary>
            [Display(Name = "yyyy-MM-dd")]
            YYYYMMDD,

            /// <summary>
            /// Date format
            /// </summary>
            [Display(Name = "yyyy/MM/dd")]
            YYYYMMDDS
        }

        /// <summary>
        /// Enumeration for  Message Box Type
        /// </summary>
        public enum MessageBoxType
        {
            /// <summary>
            /// for Success message Class
            /// </summary>            
            [Description("success")]
            Success = 1,

            /// <summary>
            /// for error message Class
            /// </summary>
            [Description("error")]
            Error = 2,

            /// <summary>
            /// for Warning message Class
            /// </summary>
            [Description("warning")]
            Warning = 3,

            /// <summary>
            /// for Info message Class
            /// </summary>
            [Description("info")]
            Info = 4
        }

        /// <summary>
        /// Enumeration for  Gender
        /// </summary>
        public enum Gender
        {
            /// <summary>
            /// For Male
            /// </summary>
            [Description("M")]
            Male,

            /// <summary>
            /// for Female
            /// </summary>
            [Description("F")]
            Female
        }

        /// <summary>
        /// Enumeration for  API status
        /// </summary>
        public enum ApiStatus
        {
            /// <summary>
            /// For Success
            /// </summary>
            [Description("Success")]
            Success,

            /// <summary>
            /// for Female
            /// </summary>
            [Description("Failure")]
            Failure
        }

        /// <summary>
        /// Enumeration for Page
        /// </summary>
        public enum Page
        {
            /// <summary>
            /// The administration
            /// </summary>
            [Description("Administration")]
            Administration = 4,
        }

        /// <summary>
        /// Enumeration for Device Type
        /// </summary>
        public enum DeviceType
        {
            /// <summary>
            /// The IOS
            /// </summary>
            [Description("IOS")]
            IOS = 1,

            /// <summary>
            /// The Android
            /// </summary>
            [Description("Android")]
            Android = 2
        }

        /// <summary>
        /// Enumeration for Language
        /// </summary>
        public enum Language
        {
            /// <summary>
            /// The English
            /// </summary>
            [Description("English")]
            English = 2,

            /// <summary>
            /// The Arabic
            /// </summary>
            [Description("Arabic")]
            Arabic = 1
        }

        /// <summary>
        /// Enumeration for From Type
        /// </summary>
        public enum FromType
        {
            /// <summary>
            /// The Web
            /// </summary>
            [Description("Web")]
            Web = 1,

            /// <summary>
            /// The App
            /// </summary>
            [Description("App")]
            App = 2
        }

        /// <summary>
        /// Enumeration for MasterDropDownType
        /// </summary>
        public enum MasterDropDownType
        {
            /// <summary>
            /// Role
            /// </summary>
            [Description("Role")]
            Role = 1,

            /// <summary>
            /// Book Genre
            /// </summary>
            [Description("Book Genre")]
            BookGenre = 2,

            /// <summary>
            /// Book Type
            /// </summary>
            [Description("Book Type")]
            BookType = 3,

            /// <summary>
            /// Location
            /// </summary>
            [Description("Location")]
            Location = 4,

            /// <summary>
            /// Message Type
            /// </summary>
            [Description("Message Type")]
            MessageType = 5,

            /// <summary>
            /// Book Location
            /// </summary>
            [Description("Book Location")]
            BookLocation = 6,

            /// <summary>
            /// Book Sector(Section)
            /// </summary>
            [Description("Book Section")]
            BookSector = 7,

            /// <summary>
            /// Statuses(Statuses)
            /// </summary>
            [Description("Statuses")]
            Statuses = 8
        }

        /// <summary>
        /// Enumeration for MessageTitle
        /// </summary>
        public enum Title
        {
            /// <summary>
            /// The page
            /// </summary>
            /// [Description("Page")]           
            [LocalizedDescription("Page", typeof(SmartLibrary.Resources.General))]
            Page = 1,

            /// <summary>
            /// The BookGenre
            /// </summary>
            /// [Description("BookGenre")]
            [LocalizedDescription("BookGenre", typeof(SmartLibrary.Resources.General))]
            BookGenre = 2,

            /// <summary>
            /// The BookLocation
            /// </summary>
            /// [Description("BookLocation")]
            [LocalizedDescription("BookLocation", typeof(SmartLibrary.Resources.General))]
            BookLocation = 3,

            /// <summary>
            /// The Space
            /// </summary>
            /// [Description("Space")]
            [LocalizedDescription("Space", typeof(SmartLibrary.Resources.General))]
            Space = 4,

            /// <summary>
            /// The User
            /// </summary>
            /// [Description("User")]
            [LocalizedDescription("User", typeof(SmartLibrary.Resources.General))]
            User = 5,

            /// <summary>
            /// The BookSector
            /// </summary>
            /// [Description("BookSector")]
            [LocalizedDescription("BookSector", typeof(SmartLibrary.Resources.General))]
            BookSector = 6,

            /// <summary>
            /// The Role
            /// </summary>
            /// [Description("Role")]
            [LocalizedDescription("Role", typeof(SmartLibrary.Resources.General))]
            Role = 7,

            /// <summary>
            /// The Member
            /// </summary>
            /// [Description("Member")]
            [LocalizedDescription("Member", typeof(SmartLibrary.Resources.General))]
            Member = 8,

            /// <summary>
            /// The Book
            /// </summary>
            /// [Description("Book")]
            [LocalizedDescription("Book", typeof(SmartLibrary.Resources.General))]
            Book = 9
        }

        /// <summary>
        /// Enumeration for Borrow Book Status
        /// </summary>
        public enum BorrowBookStatus
        {
            /// <summary>
            /// The All
            /// </summary>
            // [Description("All")]
            [LocalizedDescription("All", typeof(SmartLibrary.Resources.General))]
            All = -1,

            /// <summary>
            /// The Approved
            /// </summary>
            // [Description("Approved")]
            [LocalizedDescription("Approved", typeof(SmartLibrary.Resources.General))]
            Approved = 1,

            /// <summary>
            /// The Pending
            /// </summary>
            /// [Description("Pending")]
            [LocalizedDescription("Pending", typeof(SmartLibrary.Resources.General))]            
            Pending = 2,

            /// <summary>
            /// The Cancel
            /// </summary>
            /// [Description("Cancelled")]
            [LocalizedDescription("Cancelled", typeof(SmartLibrary.Resources.General))]                    
            Cancel = 3,

            /// <summary>
            /// The Available
            /// </summary>
            // [Description("Available")]
            [LocalizedDescription("Available", typeof(SmartLibrary.Resources.General))]
            Available = 4,

            /// <summary>
            /// The Returned
            /// </summary>
            /// [Description("Returned")]
            [LocalizedDescription("Returned", typeof(SmartLibrary.Resources.General))]
            Returned = 5,

            /// <summary>
            /// The Borrowed
            /// </summary>
            /// [Description("Borrowed")]
            [LocalizedDescription("Borrowed", typeof(SmartLibrary.Resources.General))]
            Borrowed = 6,

            /// <summary>
            /// The OverDue
            /// </summary>
            /// [Description("OverDue")]
            [LocalizedDescription("OverDue", typeof(SmartLibrary.Resources.General))]
            OverDue = 7,
        }

        /// <summary>
        /// Enumeration for Space booking Status
        /// </summary>
        public enum SpaceBookingStatus
        {
            /// <summary>
            /// The All
            /// </summary>
            /// [Description("All")]
            [LocalizedDescription("All", typeof(SmartLibrary.Resources.General))]
            All = -1,

            /// <summary>
            /// The Approved
            /// </summary>
            /// [Description("Approved")]
            [LocalizedDescription("Approved", typeof(SmartLibrary.Resources.General))]
            Approved = 6,

            /// <summary>
            /// The Pending
            /// </summary>
            /// [Description("Pending")]
            [LocalizedDescription("Pending", typeof(SmartLibrary.Resources.General))]
            Pending = 7,

            /// <summary>
            /// The Cancel
            /// </summary>
            /// [Description("Cancelled")]
            [LocalizedDescription("Cancelled", typeof(SmartLibrary.Resources.General))]
            Cancel = 8,

            /// <summary>
            /// The Available
            /// </summary>
            /// [Description("Available")]
            [LocalizedDescription("Available", typeof(SmartLibrary.Resources.General))]
            Available = 9,

            /// <summary>
            /// The Confirmed
            /// </summary>
            // [Description("Confirmed")]
            [LocalizedDescription("Confirmed", typeof(SmartLibrary.Resources.General))]
            Confirmed = 10,

            /// <summary>
            /// The Rescheduled
            /// </summary>
            /// [Description("Rescheduled")]
            [LocalizedDescription("Rescheduled", typeof(SmartLibrary.Resources.General))]
            Rescheduled = 11,
        }

        /// <summary>
        /// ActiveStatus
        /// </summary>
        public enum ActiveStatus
        {
            [Description("All")]
            All = -1,
            [Description("Active")]
            Active = 1,
            [Description("Inactive")]
            Inactive = 0
        }

        /// <summary>
        /// Enumeration for Table
        /// </summary>
        public enum Table
        {
            /// <summary>
            /// The page
            /// </summary>
            [Description("Pages")]
            Pages = 1,

            /// <summary>
            /// The BookGenre
            /// </summary>
            [Description("BookGenres")]
            BookGenres = 2,

            /// <summary>
            /// The BookLocation
            /// </summary>
            [Description("BookLocations")]
            BookLocations = 3,

            /// <summary>
            /// The Space
            /// </summary>
            [Description("Spaces")]
            Spaces = 4,

            /// <summary>
            /// The User
            /// </summary>
            [Description("Users")]
            Users = 5,

            /// <summary>
            /// The BookSector
            /// </summary>
            [Description("BookSectors")]
            BookSectors = 6,

            /// <summary>
            /// The Role
            /// </summary>
            [Description("Roles")]
            Roles = 7,

            /// <summary>
            /// The Member
            /// </summary>
            [Description("Members")]
            Members = 8,

            /// <summary>
            /// The Book
            /// </summary>
            [Description("Books")]
            Books = 9
        }

        /// <summary>
        /// Enumeration for NotificationType
        /// </summary>
        public enum NotificationType
        {
            BookBorrow = 1,
            BookApprove = 2,
            BookCancel = 3,
            BookAvailable = 4,
            SpaceBooking = 5,
            SpaceBookingApprove = 6,
            SpaceBookingReject = 7,
            SpaceBookingReschedule = 8,
            BookReturnDelay = 9,
            BookPending = 10,
            SpaceBookingPending = 11,
            BookReturnReminder = 12,
            BookReturnTodayReminder = 13,
            BookBorrowedByAdmin = 14,
            NewMessage = 15,
            BookReturn = 16
        }

        /// <summary>
        /// Enumeration for MessageType
        /// </summary>
        public enum MessageType
        {
            [Description("Chat Message")]
            ChatMessage = 1,
            [Description("Request book purchase")]
            BookRequest = 2,
            [Description("Book inquiry")]
            BookInquiry = 3,
            [Description("Booking inquiry")]
            BookingInquiry = 4,
            [Description("General inquiry")]
            GeneralInquiry = 5
        }
       
        #region Property

        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>
        public long ID { get; set; }

        /// <summary>
        /// Gets or sets the Country Code value.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets the Name value.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Description value.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Primary ID value.
        /// </summary>
        public int PrimaryID { get; set; }

        /// <summary>
        /// Gets or sets TotalRecords,  Common Property for All Entity which return Total Records for current List
        /// </summary>
        public int TotalRecords { get; set; }

        /// <summary>
        /// Gets or sets RowIndex, Common Property for All Entity which return Total Records for current List
        /// </summary>
        public long RowIndex { get; set; }

        #endregion

    }
}
