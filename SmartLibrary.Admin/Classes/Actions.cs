// <copyright file="Actions.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Admin.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Actions Name
    /// <CreatedBy>Hardik Panchal</CreatedBy>
    /// <CreatedDate>14-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy>Hardik Panchal</ReviewBy>
    /// <ReviewDate>14-Aug-2018</ReviewDate>
    /// </summary>
    public class Actions
    {
        /// <summary>
        /// Index View
        /// </summary>
        public const string Index = "index";

        /// <summary>
        /// Sign Up
        /// </summary>
        public const string StaffSignUp = "staffsignup";

        /// <summary>
        /// Sign Up
        /// </summary>
        public const string SignUp = "signup";

        /// <summary>
        /// Is Session Expired
        /// </summary>
        public const string IsSessionExpired = "is-session-expired";

        /// <summary>
        /// Forgot Password View
        /// </summary>
        public const string ForgotPassword = "forgot-password";

        /// <summary>
        /// Change Password View
        /// </summary>
        public const string ChangePassword = "change-password";

        /// <summary>
        /// The reset password
        /// </summary>
        public const string ResetPassword = "reset-password";

        /// <summary>
        /// Logout View
        /// </summary>
        public const string Logout = "logout";

        /// <summary>
        /// Session Expired
        /// </summary>
        public const string SessionExpired = "session-expired";

        /// <summary>
        /// My Profile View
        /// </summary>
        public const string MyProfile = "my-profile";

        /// <summary>
        /// Personal Information View
        /// </summary>
        public const string PersonalInformation = "personal-information";

        /// <summary>
        /// Access Denied Ajax
        /// </summary>
        public const string AccessDeniedAjax = "access-denied-ajax";

        /// <summary>
        /// The session expired for customer
        /// </summary>
        public const string SessionExpiredForCustomer = "session-expired-for-customer";

        /// <summary>
        /// Access Denied
        /// </summary>
        public const string AccessDenied = "access-denied";

        /// <summary>
        /// Set Language
        /// </summary>
        public const string SetLanguage = "set-language";

        /// <summary>
        /// Change Status
        /// </summary>
        public const string ChangeStatus = "change-status";

        /// <summary>
        /// All Activity
        /// </summary>
        public const string AllActivities = "All-Activities";

        /// <summary>
        /// All Activity List
        /// </summary>
        public const string AllActivitiesList = "All-Activity-List";

        /// <summary>
        /// Staff Login View
        /// </summary>
        public const string StaffLogin = "StaffLogin";

        /// <summary>
        /// Staff Login View
        /// </summary>
        public const string StaffDirectLogin = "StaffDirectLogin";

        /// <summary>
        /// Active Directory Login View
        /// </summary>
        public const string ActiveDirectoryLogin = "ActiveDirectoryLogin";

        #region Report

        /// <summary>
        /// View Report
        /// </summary>
        public const string ManageReport = "Manage-Report";

        /// <summary>
        /// Report Count
        /// </summary>
        public const string ReportCount = "ReportCount";

        /// <summary>
        /// Total Book Count
        /// </summary>
        public const string TotalBookCount = "TotalBookCount";

        /// <summary>
        /// Total Event Count
        /// </summary>
        public const string TotalEventCount = "TotalEventCount";

        /// <summary>
        /// Popular Book
        /// </summary>
        public const string PopularBook = "PopularBook";

        /// <summary>
        /// Active Borrower
        /// </summary>
        public const string ActiveBorrower = "ActiveBorrower";

        /// <summary>
        /// Popular User Organizing Event
        /// </summary>
        public const string PopularUserOrganizingEvent = "PopularUserOrganizingEvent";

        /// <summary>
        /// Total Returning Book on time
        /// </summary>
        public const string ReturningBookOnTime = "ReturningBookOnTime";

        /// <summary>
        /// Total Book Borrowed Through Library
        /// </summary>
        public const string TotalBooksBorrowedthroughLibrary = "TotalBooksBorrowedthroughLibrary"; 

        /// <summary>
        /// Total Book Borrowed Through Library
        /// </summary>
        public const string MostPopularGenre = "MostPopularGenre";

        /// <summary>
        /// Most Popular Author
        /// </summary>
        public const string MostPopularAuthor = "MostPopularAuthor";

        /// <summary>
        /// Most Popular Time For Borrowing Books
        /// </summary>
        public const string MostPopularTimeForBorrowingBooks = "MostPopularTimeForBorrowingBooks";

        #endregion

        #region Users

        /// <summary>
        /// The User
        /// </summary>
        public const string Users = "Manage-User";

        /// <summary>
        /// The manage user
        /// </summary>
        public const string AddEditUser = "manage-user";

        /// <summary>
        /// The delete User
        /// </summary>
        public const string DeleteUser = "delete-user";

        /// <summary>
        /// Change Status
        /// </summary>
        public const string ChangeUserStatus = "user-change-status";

        /// <summary>
        /// User Profile
        /// </summary>
        public const string UserProfile = "userprofile";

        #endregion

        #region customer

        /// <summary>
        /// Customer
        /// </summary>
        public const string Customer = "Manage-Customer";

        /// <summary>
        /// Customer Grid
        /// </summary>
        public const string CustomerGrid = "Manage-Customer-Grid-View";

        /// <summary>
        /// Customer List
        /// </summary>
        public const string CustomerList = "Manage-Customer-List-View";

        /// <summary>
        /// InviteCustomer
        /// </summary>
        public const string InviteCustomer = "invitecustomer";

        /// <summary>
        /// History of Member
        /// </summary>
        public const string HistoryOfMember = "Member-History";

        /// <summary>
        /// The export to excel
        /// </summary>
        public const string CustomersExportToExcel = "Customer-Export-to-Excel";
        
        /// <summary>
        /// Edit Customer.
        /// </summary>
        public const string EditCustomer = "EditCustomer";

        #endregion

        #region Pages

        /// <summary>
        /// The Page
        /// </summary>
        public const string Pages = "Manage-Page";

        /// <summary>
        ///  The manage Page
        /// </summary>
        public const string AddEditPages = "addeditpage";

        /// <summary>
        /// The delete Page
        /// </summary>
        public const string DeletePages = "delete-pages";

        /// <summary>
        /// Change Status
        /// </summary>
        public const string ChangePageStatus = "page-change-status";

        #endregion

        #region Role

        /// <summary>
        /// The Role
        /// </summary>
        public const string Role = "Manage-Role";

        /// <summary>
        /// The manage role
        /// </summary>
        public const string AddEditRole = "addeditrole";

        /// <summary>
        /// The delete role
        /// </summary>
        public const string DeleteRole = "delete-role";

        /// <summary>
        /// The search role
        /// </summary>
        public const string SearchRole = "delete-role";

        /// <summary>
        /// Change Status
        /// </summary>
        public const string ChangeRoleStatus = "change-role-status";

        #endregion

        #region BookGenres

        /// <summary>
        /// The BookGenres
        /// </summary>
        public const string BookGenre = "Manage-Bookgenre";

        /// <summary>
        ///  The manage BookGenres
        /// </summary>
        public const string AddEditBookGenre = "addeditgenre";

        /// <summary>
        /// The delete BookGenres
        /// </summary>
        public const string DeleteBookGenre = "delete-book-genre";

        /// <summary>
        /// Change Status
        /// </summary>
        public const string ChangeBookGenreStatus = "book-change-status";

        #endregion

        #region Space

        /// <summary>
        /// The Space
        /// </summary>
        public const string Space = "Manage-Space";

        /// <summary>
        /// The manage Space
        /// </summary>
        public const string AddEditSpace = "addeditSpace";

        /// <summary>
        /// The delete Space
        /// </summary>
        public const string DeleteSpace = "delete-space";

        /// <summary>
        /// Change Status
        /// </summary>
        public const string ChangeSpaceStatus = "space-change-status";

        /// <summary>
        /// Approve Cancel Space Booking
        /// </summary>
        public const string ApproveCancelSpaceBooking = "Approve-Cancel-Space-Booking";

        /// <summary>
        ///  Book the Space
        /// </summary>
        public const string RescheduleBookSpace = "Book-Space";

        /// <summary>
        ///  Space Booking Requests
        /// </summary>
        public const string SpaceBookingRequests = "Space-Booking-Requests";

        /// <summary>
        ///  View of the Book Status
        /// </summary>
        public const string ViewSpaceStatus = "View-Space-Status";

        /// <summary>
        /// The Space Bookings
        /// </summary>
        public const string LibraryRoomBookings = "Library-Room-Bookings";

        /// <summary>
        ///  Space Booking Requests
        /// </summary>
        public const string GetSpaceBookingRequestTimings = "Space-Booking-Requests-Timings";
        #endregion

        #region BookLocations

        /// <summary>
        ///  The BookLocation
        /// </summary>
        public const string BookLocation = "Manage-Booklocation";

        /// <summary>
        ///  The manage BookLocation
        /// </summary>
        public const string AddEditBookLocation = "addeditbooklocation";

        /// <summary>
        /// The delete BookLocation
        /// </summary>
        public const string DeleteBookLocation = "delete-book-location";

        /// <summary>
        /// The Manage ActiveLocation
        /// </summary>
        public const string ChangeLocationStatus = "change-location-status";

        #endregion

        #region Books

        /// <summary>
        /// Book
        /// </summary>
        public const string Book = "Manage-Book";

        /// <summary>
        /// Book List
        /// </summary>
        public const string BookList = "Manage-Book-List-View";

        /// <summary>
        /// Book Grid
        /// </summary>
        public const string BookGrid = "Manage-Book-Grid-View";

        /// <summary>
        /// Manage Book
        /// </summary>
        public const string AddEditBook = "addeditbook";

        /// <summary>
        /// Manage Book Status
        /// </summary>
        public const string ChangeBookStatus = "ChangeBookStatus";

        /// <summary>
        /// Get Book Detail by ISBN
        /// </summary>
        public const string GetBookByISBN = "get-book-by-isbn";

        /// <summary>
        /// Book Detail Side Bar
        /// </summary>
        public const string BookDetailSideBar = "BookDetailSideBar";

        /// <summary>
        /// Book Detail View
        /// </summary>
        public const string BookDetailView = "Book-Detail-View";

        /// <summary>
        /// Book Detail View
        /// </summary>
        public const string BorrowerDetails = "BorrowerDetails";

        /// <summary>
        /// Approve Reject Borrowed Book
        /// </summary>
        public const string ApproveRejectBorrowedBook = "Approve-Reject-Borrowed-Book";

        /// <summary>
        /// Return Book
        /// </summary>
        public const string ReturnBook = "Return-Book";

        /// <summary>
        /// Book Detail View Reload
        /// </summary>
        public const string BookDetailViewReload = "BookDetailViewReload";

        /// <summary>
        /// The export to excel
        /// </summary>
        public const string BookExportToExcel = "Book-Export-to-Excel";

        /// <summary>
        /// The Book Comments
        /// </summary>
        public const string BookComments = "Book-Comments";

        /// <summary>
        /// The BorrowBook
        /// </summary>
        public const string BorrowBook = "Borrow-Book";

        /// <summary>
        /// The OverDue Mail
        /// </summary>
        public const string OverDueMail = "Overdue-Mail";

        /// <summary>
        /// The DeleteComments Comments
        /// </summary>
        public const string DeleteComments = "Delete-Comments";

        #endregion

        #region Notifications

        /// <summary>
        /// Get New Notification Count
        /// </summary>
        public const string GetNewNotificationCount = "Get-New-Notification-Count";

        /// <summary>
        ///  Get Notifications
        /// </summary>
        public const string GetNotifications = "Get-Notifications";

        /// <summary>
        ///  Get Event Requests
        /// </summary>
        public const string GetEventRequests = "Get-Event-Requests";

        #endregion

        #region Messages

        /// <summary>
        /// The Get Messages
        /// </summary>
        public const string ManageMessages = "Manage-Messages";

        /// <summary>
        /// The Get Messages
        /// </summary>
        public const string GetMessages = "get-messages";

        /// <summary>
        /// The Send Messages
        /// </summary>
        public const string SendMessage = "send-message";

        /// <summary>
        /// Chat list
        /// </summary>
        public const string GetChatList = "get-chat-list";

        /// <summary>
        /// send message modal
        /// </summary>
        public const string SendMessageModal = "send-message-modal";

        /// <summary>
        /// Get New Message Count
        /// </summary>
        public const string GetNewMessageCount = "Get-New-Message-Count";
        #endregion

        #region :: Error Page ::

        /// <summary>
        /// Page not found Action
        /// </summary>
        public const string PageNotFound = "page-not-found";

        /// <summary>
        /// UnAuthorizePage
        /// </summary>
        public const string UnAuthorizePage = "Un-Authorize";

        /// <summary>
        /// UnAuthorizePage
        /// </summary>
        public const string ErrorPage = "error";

        #endregion
    }
}
