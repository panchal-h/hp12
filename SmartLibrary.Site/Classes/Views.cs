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
        public const string Index = "index";

        /// <summary>
        /// Manage view
        /// </summary>
        public const string Manage = "manage";

        /// <summary>
        /// Profile view
        /// </summary>
        public const string Profile = "Profile";

        /// <summary>
        /// Forgot Password View
        /// </summary>
        public const string ForgotPassword = "forgotpassword";

        /// <summary>
        /// Change Password View
        /// </summary>
        public const string ChangePassword = "changepassword";

        /// <summary>
        /// The reset password
        /// </summary>
        public const string ResetPassword = "resetpassword";

        /// <summary>
        /// Session Expired
        /// </summary>
        public const string SessionExpired = "sessionexpired";

        /// <summary>
        /// Access Denied
        /// </summary>
        public const string AccessDenied = "accessdenied";

        /// <summary>
        /// Staff Login
        /// </summary>
        public const string StaffLogin = "StaffLogin";

        #region Books

        /// <summary>
        /// Book List
        /// </summary>
        public const string BookList = "Book-List-View";

        /// <summary>
        /// Book Grid
        /// </summary>
        public const string BookGrid = "Book-Grid-View";

        /// <summary>
        /// SignUp
        /// </summary>
        public const string SignUp = "SignUp";

        /// <summary>
        /// Book History.
        /// </summary>
        public const string BookProfile = "Book-Profile";

        #endregion

        #region Space Booking

        /// <summary>
        /// Space Booking list
        /// </summary>
        public const string ManageSpaceBooking = "ManageSpaceBooking";

        #endregion

        #region Space Booking

        /// <summary>
        /// Message View page
        /// </summary>
        public const string Message = "Message";

        #endregion

        /// <summary>
        /// Page not found view
        /// </summary>
        public const string PageNotFound = "PageNotfound";

        /// <summary>
        /// UnAuthorized
        /// </summary>
        public const string UnAuthorizePage = "UnAuthorized";

        /// <summary>
        /// UnAuthorized
        /// </summary>
        public const string ErrorPage = "ErrorPage";
    }
}