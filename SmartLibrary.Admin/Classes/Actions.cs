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
        public static string Index { get { return "index"; } }

        /// <summary>
        /// Sign Up
        /// </summary>
        public static string StaffSignUp { get { return "staffsignup"; } }

        /// <summary>
        /// Sign Up
        /// </summary>
        public static string SignUp { get { return "signup"; } }

        /// <summary>
        /// Is Session Expired
        /// </summary>
        public static string IsSessionExpired { get { return "is-session-expired"; } }

        /// <summary>
        /// Forgot Password View
        /// </summary>
        public static string ForgotPassword { get { return "forgot-password"; } }

        /// <summary>
        /// Change Password View
        /// </summary>
        public static string ChangePassword { get { return "change-password"; } }

        /// <summary>
        /// The reset password
        /// </summary>
        public static string ResetPassword { get { return "reset-password"; } }

        /// <summary>
        /// Logout View
        /// </summary>
        public static string Logout { get { return "logout"; } }

        /// <summary>
        /// Session Expired
        /// </summary>
        public static string SessionExpired { get { return "session-expired"; } }

        /// <summary>
        /// My Profile View
        /// </summary>
        public static string MyProfile { get { return "my-profile"; } }

        /// <summary>
        /// Personal Information View
        /// </summary>
        public static string PersonalInformation { get { return "personal-information"; } }

        /// <summary>
        /// Access Denied Ajax
        /// </summary>
        public static string AccessDeniedAjax { get { return "access-denied-ajax"; } }

        /// <summary>
        /// The session expired for customer
        /// </summary>
        public static string SessionExpiredForCustomer { get { return "session-expired-for-customer"; } }

        /// <summary>
        /// Access Denied
        /// </summary>
        public static string AccessDenied { get { return "access-denied"; } }

        /// <summary>
        /// Set Language
        /// </summary>
        public static string SetLanguage { get { return "set-language"; } }

        /// <summary>
        /// Change Status
        /// </summary>
        public static string ChangeStatus { get { return "change-status"; } }

        /// <summary>
        /// All Activity
        /// </summary>
        public static string AllActivities { get { return "All-Activities"; } }

        /// <summary>
        /// All Activity List
        /// </summary>
        public static string AllActivitiesList { get { return "All-Activity-List"; } }

        /// <summary>
        /// Staff Login View
        /// </summary>
        public static string StaffLogin { get { return "StaffLogin"; } }

        /// <summary>
        /// Staff Login View
        /// </summary>
        public static string StaffDirectLogin { get { return "StaffDirectLogin"; } }

        /// <summary>
        /// Active Directory Login View
        /// </summary>
        public static string ActiveDirectoryLogin { get { return "ActiveDirectoryLogin"; } }

        #region Report

        /// <summary>
        /// View Report
        /// </summary>
        public static string ManageReport { get { return "Manage-Report"; } }

        /// <summary>
        /// Report Count
        /// </summary>
        public static string ReportCount { get { return "ReportCount"; } }

        /// <summary>
        /// Total Book Count
        /// </summary>
        public static string TotalBookCount { get { return "TotalBookCount"; } }

        /// <summary>
        /// Total Event Count
        /// </summary>
        public static string TotalEventCount { get { return "TotalEventCount"; } }

        /// <summary>
        /// Popular Book
        /// </summary>
        public static string PopularBook { get { return "PopularBook"; } }

        /// <summary>
        /// Active Borrower
        /// </summary>
        public static string ActiveBorrower { get { return "ActiveBorrower"; } }

        /// <summary>
        /// Popular User Organizing Event
        /// </summary>
        public static string PopularUserOrganizingEvent { get { return "PopularUserOrganizingEvent"; } }

        /// <summary>
        /// Total Returning Book on time
        /// </summary>
        public static string ReturningBookOnTime { get { return "ReturningBookOnTime"; } }

        /// <summary>
        /// Total Book Borrowed Through Library
        /// </summary>
        public static string TotalBooksBorrowedthroughLibrary { get { return "TotalBooksBorrowedthroughLibrary"; } } 

        /// <summary>
        /// Total Book Borrowed Through Library
        /// </summary>
        public static string MostPopularGenre { get { return "MostPopularGenre"; } }

        /// <summary>
        /// Most Popular Author
        /// </summary>
        public static string MostPopularAuthor { get { return "MostPopularAuthor"; } }

        /// <summary>
        /// Most Popular Time For Borrowing Books
        /// </summary>
        public static string MostPopularTimeForBorrowingBooks { get { return "MostPopularTimeForBorrowingBooks"; } }

        #endregion

        #region Users

        /// <summary>
        /// The User
        /// </summary>
        public static string Users { get { return "Manage-User"; } }

        /// <summary>
        /// The manage user
        /// </summary>
        public static string AddEditUser { get { return "manage-user"; } }

        /// <summary>
        /// The delete User
        /// </summary>
        public static string DeleteUser { get { return "delete-user"; } }

        /// <summary>
        /// Change Status
        /// </summary>
        public static string ChangeUserStatus { get { return "user-change-status"; } }

        /// <summary>
        /// User Profile
        /// </summary>
        public static string UserProfile { get { return "userprofile"; } }

        #endregion

        #region customer

        /// <summary>
        /// Customer
        /// </summary>
        public static string Customer { get { return "Manage-Customer"; } }

        /// <summary>
        /// Customer Grid
        /// </summary>
        public static string CustomerGrid { get { return "Manage-Customer-Grid-View"; } }

        /// <summary>
        /// Customer List
        /// </summary>
        public static string CustomerList { get { return "Manage-Customer-List-View"; } }

        /// <summary>
        /// InviteCustomer
        /// </summary>
        public static string InviteCustomer { get { return "invitecustomer"; } }

        /// <summary>
        /// History of Member
        /// </summary>
        public static string HistoryOfMember { get { return "Member-History"; } }

        /// <summary>
        /// The export to excel
        /// </summary>
        public static string CustomersExportToExcel { get { return "Customer-Export-to-Excel"; } }
        
        /// <summary>
        /// Edit Customer.
        /// </summary>
        public static string EditCustomer { get { return "EditCustomer"; } }

        #endregion

        #region Pages

        /// <summary>
        /// The Page
        /// </summary>
        public static string Pages { get { return "Manage-Page"; } }

        /// <summary>
        ///  The manage Page
        /// </summary>
        public static string AddEditPages { get { return "addeditpage"; } }

        /// <summary>
        /// The delete Page
        /// </summary>
        public static string DeletePages { get { return "delete-pages"; } }

        /// <summary>
        /// Change Status
        /// </summary>
        public static string ChangePageStatus { get { return "page-change-status"; } }

        #endregion

        #region Role

        /// <summary>
        /// The Role
        /// </summary>
        public static string Role { get { return "Manage-Role"; } }

        /// <summary>
        /// The manage role
        /// </summary>
        public static string AddEditRole { get { return "addeditrole"; } }

        /// <summary>
        /// The delete role
        /// </summary>
        public static string DeleteRole { get { return "delete-role"; } }

        /// <summary>
        /// The search role
        /// </summary>
        public static string SearchRole { get { return "delete-role"; } }

        /// <summary>
        /// Change Status
        /// </summary>
        public static string ChangeRoleStatus { get { return "change-role-status"; } }

        #endregion

        #region BookGenres

        /// <summary>
        /// The BookGenres
        /// </summary>
        public static string BookGenre { get { return "Manage-Bookgenre"; } }

        /// <summary>
        ///  The manage BookGenres
        /// </summary>
        public static string AddEditBookGenre { get { return "addeditgenre"; } }

        /// <summary>
        /// The delete BookGenres
        /// </summary>
        public static string DeleteBookGenre { get { return "delete-book-genre"; } }

        /// <summary>
        /// Change Status
        /// </summary>
        public static string ChangeBookGenreStatus { get { return "book-change-status"; } }

        #endregion

        #region Space

        /// <summary>
        /// The Space
        /// </summary>
        public static string Space { get { return "Manage-Space"; } }

        /// <summary>
        /// The manage Space
        /// </summary>
        public static string AddEditSpace { get { return "addeditSpace"; } }

        /// <summary>
        /// The delete Space
        /// </summary>
        public static string DeleteSpace { get { return "delete-space"; } }

        /// <summary>
        /// Change Status
        /// </summary>
        public static string ChangeSpaceStatus { get { return "space-change-status"; } }

        /// <summary>
        /// Approve Cancel Space Booking
        /// </summary>
        public static string ApproveCancelSpaceBooking { get { return "Approve-Cancel-Space-Booking"; } }

        /// <summary>
        ///  Book the Space
        /// </summary>
        public static string RescheduleBookSpace { get { return "Book-Space"; } }

        /// <summary>
        ///  Space Booking Requests
        /// </summary>
        public static string SpaceBookingRequests { get { return "Space-Booking-Requests"; } }

        /// <summary>
        ///  View of the Book Status
        /// </summary>
        public static string ViewSpaceStatus { get { return "View-Space-Status"; } }

        /// <summary>
        /// The Space Bookings
        /// </summary>
        public static string LibraryRoomBookings { get { return "Library-Room-Bookings"; } }

        /// <summary>
        ///  Space Booking Requests
        /// </summary>
        public static string GetSpaceBookingRequestTimings { get { return "Space-Booking-Requests-Timings"; } }
        #endregion

        #region BookLocations

        /// <summary>
        ///  The BookLocation
        /// </summary>
        public static string BookLocation { get { return "Manage-Booklocation"; } }

        /// <summary>
        ///  The manage BookLocation
        /// </summary>
        public static string AddEditBookLocation { get { return "addeditbooklocation"; } }

        /// <summary>
        /// The delete BookLocation
        /// </summary>
        public static string DeleteBookLocation { get { return "delete-book-location"; } }

        /// <summary>
        /// The Manage ActiveLocation
        /// </summary>
        public static string ChangeLocationStatus { get { return "change-location-status"; } }

        #endregion

        #region Books

        /// <summary>
        /// Book
        /// </summary>
        public static string Book { get { return "Manage-Book"; } }

        /// <summary>
        /// Book List
        /// </summary>
        public static string BookList { get { return "Manage-Book-List-View"; } }

        /// <summary>
        /// Book Grid
        /// </summary>
        public static string BookGrid { get { return "Manage-Book-Grid-View"; } }

        /// <summary>
        /// Manage Book
        /// </summary>
        public static string AddEditBook { get { return "addeditbook"; } }

        /// <summary>
        /// Manage Book Status
        /// </summary>
        public static string ChangeBookStatus { get { return "ChangeBookStatus"; } }

        /// <summary>
        /// Get Book Detail by ISBN
        /// </summary>
        public static string GetBookByISBN { get { return "get-book-by-isbn"; } }

        /// <summary>
        /// Book Detail Side Bar
        /// </summary>
        public static string BookDetailSideBar { get { return "BookDetailSideBar"; } }

        /// <summary>
        /// Book Detail View
        /// </summary>
        public static string BookDetailView { get { return "Book-Detail-View"; } }

        /// <summary>
        /// Book Detail View
        /// </summary>
        public static string BorrowerDetails { get { return "BorrowerDetails"; } }

        /// <summary>
        /// Approve Reject Borrowed Book
        /// </summary>
        public static string ApproveRejectBorrowedBook { get { return "Approve-Reject-Borrowed-Book"; } }

        /// <summary>
        /// Return Book
        /// </summary>
        public static string ReturnBook { get { return "Return-Book"; } }

        /// <summary>
        /// Book Detail View Reload
        /// </summary>
        public static string BookDetailViewReload { get { return "BookDetailViewReload"; } }

        /// <summary>
        /// The export to excel
        /// </summary>
        public static string BookExportToExcel { get { return "Book-Export-to-Excel"; } }

        /// <summary>
        /// The Book Comments
        /// </summary>
        public static string BookComments { get { return "Book-Comments"; } }

        /// <summary>
        /// The BorrowBook
        /// </summary>
        public static string BorrowBook { get { return "Borrow-Book"; } }

        /// <summary>
        /// The OverDue Mail
        /// </summary>
        public static string OverDueMail { get { return "Overdue-Mail"; } }

        /// <summary>
        /// The DeleteComments Comments
        /// </summary>
        public static string DeleteComments { get { return "Delete-Comments"; } }

        #endregion

        #region Notifications

        /// <summary>
        /// Get New Notification Count
        /// </summary>
        public static string GetNewNotificationCount { get { return "Get-New-Notification-Count"; } }

        /// <summary>
        ///  Get Notifications
        /// </summary>
        public static string GetNotifications { get { return "Get-Notifications"; } }

        /// <summary>
        ///  Get Event Requests
        /// </summary>
        public static string GetEventRequests { get { return "Get-Event-Requests"; } }

        #endregion

        #region Messages

        /// <summary>
        /// The Get Messages
        /// </summary>
        public static string ManageMessages { get { return "Manage-Messages"; } }

        /// <summary>
        /// The Get Messages
        /// </summary>
        public static string GetMessages { get { return "get-messages"; } }

        /// <summary>
        /// The Send Messages
        /// </summary>
        public static string SendMessage { get { return "send-message"; } }

        /// <summary>
        /// Chat list
        /// </summary>
        public static string GetChatList { get { return "get-chat-list"; } }

        /// <summary>
        /// send message modal
        /// </summary>
        public static string SendMessageModal { get { return "send-message-modal"; } }

        /// <summary>
        /// Get New Message Count
        /// </summary>
        public static string GetNewMessageCount { get { return "Get-New-Message-Count"; } }
        #endregion

        #region :: Error Page ::

        /// <summary>
        /// Page not found Action
        /// </summary>
        public static string PageNotFound { get { return "page-not-found"; } }

        /// <summary>
        /// UnAuthorizePage
        /// </summary>
        public static string UnAuthorizePage { get { return "Un-Authorize"; } }

        /// <summary>
        /// UnAuthorizePage
        /// </summary>
        public static string ErrorPage { get { return "error"; } }

        #endregion
    }
}
