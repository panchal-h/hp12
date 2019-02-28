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
        public const string ResetPassword = "Resetpassword";

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
        /// InviteCustomer
        /// </summary>
        public const string InviteCustomer = "invitecustomer";

        /// <summary>
        ///  View of the Book Status
        /// </summary>
        public const string ViewSpaceStatus = "View-Space-Status";

        /// <summary>
        /// All Activity
        /// </summary>
        public const string AllActivities = "All-Activities";

        /// <summary>
        /// All Activity List
        /// </summary>
        public const string AllActivitiesList = "All-Activity-List"; 

        /// <summary>
        /// Notify Me
        /// </summary>
        public const string AddNotifyMe = "Add-Notify-Me";

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

        #region Books

        /// <summary>
        /// Book
        /// </summary>
        public const string Book = "Manage-Book";

        /// <summary>
        /// Book List
        /// </summary>
        public const string BookList = "Book-List-View";

        /// <summary>
        /// Book Grid
        /// </summary>
        public const string BookGrid = "Book-Grid-View";

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
        /// Borrowe rDetails View
        /// </summary>
        public const string BorrowerDetails = "BorrowerDetails";

        /// <summary>
        /// Add Book Interest 
        /// </summary>
        public const string AddBookInterest = "Add-Book-Interest";

        /// <summary>
        /// Remove Book Interest 
        /// </summary>
        public const string RemoveBookInterest = "Remove-Book-Interest";

        /// <summary>
        /// Current Book Status
        /// </summary>
        public const string CurrentBookStatus = "Current-Book-Status";

        /// <summary>
        /// BorrowBook
        /// </summary>
        public const string BorrowBook = "Borrow-Book";

        /// <summary>
        /// Add Comment
        /// </summary>
        public const string AddComment = "Add-Comment";

        /// <summary>
        /// Comment List
        /// </summary>
        public const string CommentList = "Comment-List";

        /// <summary>
        /// Book Detail View reload
        /// </summary>
        public const string BookDetailViewReload = "BookDetailViewReload";

        /// <summary>
        /// Book History.
        /// </summary>
        public const string BookProfile = "Book-Profile";
        #endregion

        #region UserProfile

        /// <summary>
        /// User Profile
        /// </summary>
        public const string UserProfile = "userprofile";

        #endregion UserProfile

        #region SpaceBookings

        /// <summary>
        /// The Space Bookings
        /// </summary>
        public const string LibraryRoomBookings = "library-room-bookings";

        /// <summary>
        ///  Book the Space
        /// </summary>
        public const string BookSpace = "Book-Space";

        /// <summary>
        ///  Space Booking Requests
        /// </summary>
        public const string SpaceBookingRequests = "Space-Booking-Requests";

        /// <summary>
        ///  Space Booking Requests
        /// </summary>
        public const string GetSpaceBookingRequestTimings = "Space-Booking-Requests-Timings";

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

        #endregion

        #region Messages

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
