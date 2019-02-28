// <copyright file="Views.cs" company="Caspian Pacific Tech">
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
    /// View Name
    /// <CreatedBy>Hardik Panchal</CreatedBy>
    /// <CreatedDate>14-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy>Hardik Panchal</ReviewBy>
    /// <ReviewDate>14-Aug-2018</ReviewDate>
    /// </summary>
    public class Views
    {
        /// <summary>
        /// Index View
        /// </summary>
        public static string Index { get { return "index"; } }

        /// <summary>
        /// Manage view
        /// </summary>
        public static string Manage { get { return "manage"; } }

        /// <summary>
        /// Profile view
        /// </summary>
        public static string Profile { get { return "Profile"; } }

        /// <summary>
        /// Forgot Password View
        /// </summary>
        public static string ForgotPassword { get { return "forgotpassword"; } }

        /// <summary>
        /// Change Password View
        /// </summary>
        public static string ChangePassword { get { return "changepassword"; } }

        /// <summary>
        /// The reset password
        /// </summary>
        public static string ResetPassword { get { return "resetpassword"; } }

        /// <summary>
        /// Session Expired
        /// </summary>
        public static string SessionExpired { get { return "sessionexpired"; } }

        /// <summary>
        /// Access Denied
        /// </summary>
        public static string AccessDenied { get { return "accessdenied"; } }

        /// <summary>
        /// Staff Login
        /// </summary>
        public static string StaffLogin { get { return "StaffLogin"; } }

        #region Books

        /// <summary>
        /// Book List
        /// </summary>
        public static string BookList { get { return "Book-List-View"; } }

        /// <summary>
        /// Book Grid
        /// </summary>
        public static string BookGrid { get { return "Book-Grid-View"; } }

        /// <summary>
        /// SignUp
        /// </summary>
        public static string SignUp { get { return "SignUp"; } }

        /// <summary>
        /// Book History.
        /// </summary>
        public static string BookProfile { get { return "Book-Profile"; } }

        #endregion

        #region Space Booking

        /// <summary>
        /// Space Booking list
        /// </summary>
        public static string ManageSpaceBooking { get { return "ManageSpaceBooking"; } }

        #endregion

        #region Space Booking

        /// <summary>
        /// Message View page
        /// </summary>
        public static string Message { get { return "Message"; } }

        #endregion

        /// <summary>
        /// Page not found view
        /// </summary>
        public static string PageNotFound { get { return "PageNotfound"; } }

        /// <summary>
        /// UnAuthorized
        /// </summary>
        public static string UnAuthorizePage { get { return "UnAuthorized"; } }

        /// <summary>
        /// UnAuthorized
        /// </summary>
        public static string ErrorPage { get { return "ErrorPage"; } }
    }
}