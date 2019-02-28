// <copyright file="Views.cs" company="Caspian Pacific Tech">
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
        /// All Movies View
        /// </summary>
        public const string AllMovies = "AllMovies";

        /// <summary>
        /// Create Movie View
        /// </summary>
        public const string CreateMovies = "ManageMovie";

        /// <summary>
        /// Access Denied
        /// </summary>
        public const string AccessDenied = "accessdenied";

        /// <summary>
        /// Staff Login
        /// </summary>
        public const string StaffLogin = "StaffLogin";

        #region User

        /// <summary>
        /// The Admin User
        /// </summary>
        public const string User = "user";

        /// <summary>
        /// The manage Admin User
        /// </summary>
        public const string ManageUser = "manageuser";

        /// <summary>
        /// The manage User Profile
        /// </summary>
        public const string MyProfile = "myprofile";

        /// <summary>
        /// The Customer Grid
        /// </summary>
        public const string CustomerGrid = "Manage-Customer-Grid-View";

        /// <summary>
        /// The Customer List
        /// </summary>
        public const string CustomerList = "Manage-Customer-List-View";

        /// <summary>
        /// The History of Member
        /// </summary>
        public const string HistoryOfMember = "Member-History";

        #endregion

        #region Page

        /// <summary>
        /// The Page
        /// </summary>
        public const string Page = "Manage-Page";

        /// <summary>
        /// The manage Page
        /// </summary>
        public const string ManagePage = "managepage";
        #endregion

        #region Role

        /// <summary>
        /// The Page
        /// </summary>
        public const string Role = "Manage-Role";

        /// <summary>
        /// The manage Role
        /// </summary>
        public const string ManageRole = "managerole";
        #endregion

        #region Accounts

        /// <summary>
        /// The city
        /// </summary>
        public const string Individual = "individual";

        /// <summary>
        /// The manage city
        /// </summary>
        public const string ManageIndividual = "manageindividual";

        /// <summary>
        /// The manage User Profile
        /// </summary>
        public const string UserProfile = "userprofile";

        #endregion

        #region BookGenres

        /// <summary>
        /// The BookGenre
        /// </summary>
        public const string BookGenre = "Manage-Bookgenre";

        /// <summary>
        /// The manage BookGenres
        /// </summary>
        public const string ManageBookGenre = "managebookgenre";
        #endregion

        #region Spaces

        /// <summary>
        /// The BookGenres
        /// </summary>
        public const string Space = "Manage-Space";

        /// <summary>
        /// The manage BookGenres
        /// </summary>
        public const string ManageSpaces = "managebookgenres";

        /// <summary>
        /// Space Booking list
        /// </summary>
        public const string ManageSpaceBooking = "ManageSpaceBooking";

        #endregion

        #region BookLocations

        /// <summary>
        /// The BookLocations
        /// </summary>
        public const string BookLocation = "Manage-Booklocation";

        #endregion

        #region Books

        /// <summary>
        /// Book List
        /// </summary>
        public const string BookList = "Manage-Book-List-View";

        /// <summary>
        /// Book Grid
        /// </summary>
        public const string BookGrid = "Manage-Book-Grid-View";

        #endregion

        #region Message

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