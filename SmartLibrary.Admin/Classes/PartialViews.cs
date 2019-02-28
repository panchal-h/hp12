// <copyright file="PartialViews.cs" company="Caspian Pacific Tech">
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
    /// Partial View Name
    /// <CreatedBy>Hardik Panchal</CreatedBy>
    /// <CreatedDate>14-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy>Hardik Panchal</ReviewBy>
    /// <ReviewDate>14-Aug-2018</ReviewDate>
    /// </summary>
    public class PartialViews
    {
        /// <summary>
        /// Access Denied Partial View
        /// </summary>
        public const string AccessDenied = "_accessdenied";

        /// <summary>
        /// Program Member Partial View
        /// </summary>
        public const string ProgramMember = "_programmember";

        /// <summary>
        /// Personal Details Partial View
        /// </summary>
        public const string PersonalDetails = "_personaldetails";

        /// <summary>
        /// Business Description Partial View
        /// </summary>
        public const string BusinessDescription = "_businessdescription";

        /// <summary>
        /// Business Identification Partial View
        /// </summary>
        public const string BusinessIdentification = "_businessidentification";

        /// <summary>
        /// Manage Business Identification Partial View
        /// </summary>
        public const string ManageBusinessIdentification = "_managebusinessidentification";

        /// <summary>
        /// Project Details Partial View
        /// </summary>
        public const string ProjectDetails = "_projectdetails";

        /// <summary>
        /// Team Members Partial View
        /// </summary>
        public const string TeamMembers = "_teammembers";

        /// <summary>
        /// Program Status Partial View
        /// </summary>
        public const string ProgramStatus = "_programstatus";

        /// <summary>
        /// Personal Details Partial View
        /// </summary>
        public const string PersonalDetailHeader = "_personaldetailheader";

        /// <summary>
        /// Invite Applicant Partial View
        /// </summary>
        public const string InviteApplicant = "_inviteapplicant";

        /// <summary>
        /// The reject application
        /// </summary>
        public const string RejectApplication = "_rejectapplication";

        /// <summary>
        /// The product sell details
        /// </summary>
        public const string ProductSellDetails = "_productselldetails";

        /// <summary>
        /// Assessment Partial View
        /// </summary>
        public const string Assessment = "_assessment";

        /// <summary>
        /// The new
        /// </summary>
        public const string New = "_new";

        /// <summary>
        /// The previous messages
        /// </summary>
        public const string PreviousMessages = "_previousmessages";

        /// <summary>
        /// The drafts
        /// </summary>
        public const string Drafts = "_drafts";

        /// <summary>
        /// The message details
        /// </summary>
        public const string MessageDetails = "_messagedetails";

        /// <summary>
        /// The Messages
        /// </summary>
        public const string Messages = "_messages";

        /// <summary>
        /// The message details
        /// </summary>
        public const string MessageMembers = "_messagemembers";

        /// <summary>
        /// Financial Information Partial View
        /// </summary>
        public const string FinancialInformations = "_financialinformations";

        /// <summary>
        /// The manage financial information
        /// </summary>
        public const string ManageFinancialInformation = "_managefinancialinformation";

        /// <summary>
        /// The business owners
        /// </summary>
        public const string BusinessOwners = "_businessowners";

        /// <summary>
        /// The business owner header
        /// </summary>
        public const string BusinessOwnerHeader = "_businessownerheader";

        /// <summary>
        /// The reply
        /// </summary>
        public const string Reply = "_reply";

        /// <summary>
        /// The BookGenres
        /// </summary>
        public const string BookGenres = "_BookGenres";

        /// <summary>
        /// The Spaces
        /// </summary>
        public const string Spaces = "_Spaces";

        /// <summary>
        /// The Book Location
        /// </summary>
        public const string BookLocation = "_BookLocation";

        /// <summary>
        /// The Book Location
        /// </summary>
        public const string AddEditBookLocation = "_AddEditBookLocation";

        /// <summary>
        /// The ManageBookGenre
        /// </summary>
        public const string AddEditBookGenre = "_AddEditBookGenre";

        /// <summary>
        /// The Pages
        /// </summary>
        public const string AddEditPage = "_AddEditPage";

        /// <summary>
        /// The Pages
        /// </summary>
        public const string Pages = "_Pages";

        /// <summary>
        /// The Users
        /// </summary>
        public const string AddEditUsers = "_AddEditUsers";

        /// <summary>
        /// The CustomerList
        /// </summary>
        public const string CustomerList = "_CustomerList";

        /// <summary>
        /// The CustomerGrid
        /// </summary>
        public const string CustomerGrid = "_CustomerGrid";

        /// <summary>
        /// The Users
        /// </summary>
        public const string Users = "_Users";

        /// <summary>
        /// The ManageSpace
        /// </summary>
        public const string AddEditSpace = "_AddEditSpace";

        /// <summary>
        /// The Role
        /// </summary>
        public const string ManageRole = "_ManageRole";

        /// <summary>
        /// The Role
        /// </summary>
        public const string Roles = "_Roles";

        /// <summary>
        /// InviteCustomer
        /// </summary>
        public const string InviteCustomer = "_InviteCustomer";

        #region Books

        /// <summary>
        /// Manage Book
        /// </summary>
        public const string ManageBook = "_managebook";

        /// <summary>
        /// The BookGrid
        /// </summary>
        public const string BookGrid = "_BookGrid";

        /// <summary>
        /// The BookGrid
        /// </summary>
        public const string BookDetailSideBar = "_BookDetailSideBar";

        /// <summary>
        /// The BorrowerDetails
        /// </summary>
        public const string BorrowerDetails = "_BorrowerDetails";

        /// <summary>
        /// The BookDetailViewReload
        /// </summary>
        public const string BookDetailViewReload = "_BookDetailViewReload";

        /// <summary>
        /// The ReturnBook
        /// </summary>
        public const string ReturnBook = "_ReturnBook";

        #endregion

        #region SpaceBookings

        /// <summary>
        ///  Book the Space
        /// </summary>
        public const string BookSpace = "_bookspace";

        /// <summary>
        ///  Book the Space
        /// </summary>
        public const string ViewSpaceStatus = "_ViewSpaceStatus";

        /// <summary>
        ///  Book the Space
        /// </summary>
        public const string SpaceBookingRequests = "_BookingRequests";
        #endregion

        /// <summary>
        /// The Notifications Side Bar
        /// </summary>
        public const string Notifications = "_notification";

        /// <summary>
        /// The Messages
        /// </summary>
        public const string MessageList = "_messagelist";

        /// <summary>
        /// The Chat Users List
        /// </summary>
        public const string ChatList = "_chatlist";

        /// <summary>
        /// The Chat Users List
        /// </summary>
        public const string SendMessageModal = "_sendmessage";

        /// <summary>
        /// The Edit Customer
        /// </summary>
        public const string EditCustomer = "_EditCustomer";

        /// <summary>
        ///  Event Requests
        /// </summary>
        public const string EventRequests = "_EventRequests";
    }
}