// <copyright file="Actions.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Site.Pages
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
        public static string ResetPassword { get { return "Resetpassword"; } }

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
        /// InviteCustomer
        /// </summary>
        public static string InviteCustomer { get { return "invitecustomer"; } }

        /// <summary>
        ///  View of the Book Status
        /// </summary>
        public static string ViewSpaceStatus { get { return "View-Space-Status"; } }

        /// <summary>
        /// All Activity
        /// </summary>
        public static string AllActivities { get { return "All-Activities"; } }

        /// <summary>
        /// All Activity List
        /// </summary>
        public static string AllActivitiesList { get { return "All-Activity-List"; } }

        /// <summary>
        /// Notify Me
        /// </summary>
        public static string AddNotifyMe { get { return "Add-Notify-Me"; } }

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

        #region Books

        /// <summary>
        /// Book
        /// </summary>
        public static string Book { get { return "Manage-Book"; } }

        /// <summary>
        /// Book List
        /// </summary>
        public static string BookList { get { return "Book-List-View"; } }

        /// <summary>
        /// Book Grid
        /// </summary>
        public static string BookGrid { get { return "Book-Grid-View"; } }

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
        /// Borrowe rDetails View
        /// </summary>
        public static string BorrowerDetails { get { return "BorrowerDetails"; } }

        /// <summary>
        /// Add Book Interest 
        /// </summary>
        public static string AddBookInterest { get { return "Add-Book-Interest"; } }

        /// <summary>
        /// Remove Book Interest 
        /// </summary>
        public static string RemoveBookInterest { get { return "Remove-Book-Interest"; } }

        /// <summary>
        /// Current Book Status
        /// </summary>
        public static string CurrentBookStatus { get { return "Current-Book-Status"; } }

        /// <summary>
        /// BorrowBook
        /// </summary>
        public static string BorrowBook { get { return "Borrow-Book"; } }

        /// <summary>
        /// Add Comment
        /// </summary>
        public static string AddComment { get { return "Add-Comment"; } }

        /// <summary>
        /// Comment List
        /// </summary>
        public static string CommentList { get { return "Comment-List"; } }

        /// <summary>
        /// Book Detail View reload
        /// </summary>
        public static string BookDetailViewReload { get { return "BookDetailViewReload"; } }

        /// <summary>
        /// Book History.
        /// </summary>
        public static string BookProfile { get { return "Book-Profile"; } }
        #endregion

        #region UserProfile

        /// <summary>
        /// User Profile
        /// </summary>
        public static string UserProfile { get { return "userprofile"; } }

        #endregion UserProfile

        #region SpaceBookings

        /// <summary>
        /// The Space Bookings
        /// </summary>
        public static string LibraryRoomBookings { get { return "library-room-bookings"; } }

        /// <summary>
        ///  Book the Space
        /// </summary>
        public static string BookSpace { get { return "Book-Space"; } }

        /// <summary>
        ///  Space Booking Requests
        /// </summary>
        public static string SpaceBookingRequests { get { return "Space-Booking-Requests"; } }

        /// <summary>
        ///  Space Booking Requests
        /// </summary>
        public static string GetSpaceBookingRequestTimings { get { return "Space-Booking-Requests-Timings"; } }

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

        #endregion

        #region Messages

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
