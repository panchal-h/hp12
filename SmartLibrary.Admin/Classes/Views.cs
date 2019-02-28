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
        /// All Movies View
        /// </summary>
        public static string AllMovies { get { return "AllMovies"; } }

        /// <summary>
        /// Create Movie View
        /// </summary>
        public static string CreateMovies { get { return "ManageMovie"; } }

        /// <summary>
        /// Access Denied
        /// </summary>
        public static string AccessDenied { get { return "accessdenied"; } }

        /// <summary>
        /// Staff Login
        /// </summary>
        public static string StaffLogin { get { return "StaffLogin"; } }

        #region User

        /// <summary>
        /// The Admin User
        /// </summary>
        public static string User { get { return "user"; } }

        /// <summary>
        /// The manage Admin User
        /// </summary>
        public static string ManageUser { get { return "manageuser"; } }

        /// <summary>
        /// The manage User Profile
        /// </summary>
        public static string MyProfile { get { return "myprofile"; } }

        /// <summary>
        /// The Customer Grid
        /// </summary>
        public static string CustomerGrid { get { return "Manage-Customer-Grid-View"; } }

        /// <summary>
        /// The Customer List
        /// </summary>
        public static string CustomerList { get { return "Manage-Customer-List-View"; } }

        /// <summary>
        /// The History of Member
        /// </summary>
        public static string HistoryOfMember { get { return "Member-History"; } }

        #endregion

        #region Page

        /// <summary>
        /// The Page
        /// </summary>
        public static string Page { get { return "Manage-Page"; } }

        /// <summary>
        /// The manage Page
        /// </summary>
        public static string ManagePage { get { return "managepage"; } }
        #endregion

        #region Role

        /// <summary>
        /// The Page
        /// </summary>
        public static string Role { get { return "Manage-Role"; } }

        /// <summary>
        /// The manage Role
        /// </summary>
        public static string ManageRole { get { return "managerole"; } }
        #endregion

        #region Accounts

        /// <summary>
        /// The city
        /// </summary>
        public static string Individual { get { return "individual"; } }

        /// <summary>
        /// The manage city
        /// </summary>
        public static string ManageIndividual { get { return "manageindividual"; } }

        /// <summary>
        /// The manage User Profile
        /// </summary>
        public static string UserProfile { get { return "userprofile"; } }

        #endregion

        #region BookGenres

        /// <summary>
        /// The BookGenre
        /// </summary>
        public static string BookGenre { get { return "Manage-Bookgenre"; } }

        /// <summary>
        /// The manage BookGenres
        /// </summary>
        public static string ManageBookGenre { get { return "managebookgenre"; } }
        #endregion

        #region Spaces

        /// <summary>
        /// The BookGenres
        /// </summary>
        public static string Space { get { return "Manage-Space"; } }

        /// <summary>
        /// The manage BookGenres
        /// </summary>
        public static string ManageSpaces { get { return "managebookgenres"; } }

        /// <summary>
        /// Space Booking list
        /// </summary>
        public static string ManageSpaceBooking { get { return "ManageSpaceBooking"; } }

        #endregion

        #region BookLocations

        /// <summary>
        /// The BookLocations
        /// </summary>
        public static string BookLocation { get { return "Manage-Booklocation"; } }

        #endregion

        #region Books

        /// <summary>
        /// Book List
        /// </summary>
        public static string BookList { get { return "Manage-Book-List-View"; } }

        /// <summary>
        /// Book Grid
        /// </summary>
        public static string BookGrid { get { return "Manage-Book-Grid-View"; } }

        #endregion

        #region Message

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