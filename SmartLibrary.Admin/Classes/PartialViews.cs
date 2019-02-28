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
        public static string AccessDenied { get { return "_accessdenied"; } }

        /// <summary>
        /// Program Member Partial View
        /// </summary>
        public static string ProgramMember { get { return "_programmember"; } }

        /// <summary>
        /// Personal Details Partial View
        /// </summary>
        public static string PersonalDetails { get { return "_personaldetails"; } }

        /// <summary>
        /// Business Description Partial View
        /// </summary>
        public static string BusinessDescription { get { return "_businessdescription"; } }

        /// <summary>
        /// Business Identification Partial View
        /// </summary>
        public static string BusinessIdentification { get { return "_businessidentification"; } }

        /// <summary>
        /// Manage Business Identification Partial View
        /// </summary>
        public static string ManageBusinessIdentification { get { return "_managebusinessidentification"; } }

        /// <summary>
        /// Project Details Partial View
        /// </summary>
        public static string ProjectDetails { get { return "_projectdetails"; } }

        /// <summary>
        /// Team Members Partial View
        /// </summary>
        public static string TeamMembers { get { return "_teammembers"; } }

        /// <summary>
        /// Program Status Partial View
        /// </summary>
        public static string ProgramStatus { get { return "_programstatus"; } }

        /// <summary>
        /// Personal Details Partial View
        /// </summary>
        public static string PersonalDetailHeader { get { return "_personaldetailheader"; } }

        /// <summary>
        /// Invite Applicant Partial View
        /// </summary>
        public static string InviteApplicant { get { return "_inviteapplicant"; } }

        /// <summary>
        /// The reject application
        /// </summary>
        public static string RejectApplication { get { return "_rejectapplication"; } }

        /// <summary>
        /// The product sell details
        /// </summary>
        public static string ProductSellDetails { get { return "_productselldetails"; } }

        /// <summary>
        /// Assessment Partial View
        /// </summary>
        public static string Assessment { get { return "_assessment"; } }

        /// <summary>
        /// The new
        /// </summary>
        public static string New { get { return "_new"; } }

        /// <summary>
        /// The previous messages
        /// </summary>
        public static string PreviousMessages { get { return "_previousmessages"; } }

        /// <summary>
        /// The drafts
        /// </summary>
        public static string Drafts { get { return "_drafts"; } }

        /// <summary>
        /// The message details
        /// </summary>
        public static string MessageDetails { get { return "_messagedetails"; } }

        /// <summary>
        /// The Messages
        /// </summary>
        public static string Messages { get { return "_messages"; } }

        /// <summary>
        /// The message details
        /// </summary>
        public static string MessageMembers { get { return "_messagemembers"; } }

        /// <summary>
        /// Financial Information Partial View
        /// </summary>
        public static string FinancialInformations { get { return "_financialinformations"; } }

        /// <summary>
        /// The manage financial information
        /// </summary>
        public static string ManageFinancialInformation { get { return "_managefinancialinformation"; } }

        /// <summary>
        /// The business owners
        /// </summary>
        public static string BusinessOwners { get { return "_businessowners"; } }

        /// <summary>
        /// The business owner header
        /// </summary>
        public static string BusinessOwnerHeader { get { return "_businessownerheader"; } }

        /// <summary>
        /// The reply
        /// </summary>
        public static string Reply { get { return "_reply"; } }

        /// <summary>
        /// The BookGenres
        /// </summary>
        public static string BookGenres { get { return "_BookGenres"; } }

        /// <summary>
        /// The Spaces
        /// </summary>
        public static string Spaces { get { return "_Spaces"; } }

        /// <summary>
        /// The Book Location
        /// </summary>
        public static string BookLocation { get { return "_BookLocation"; } }

        /// <summary>
        /// The Book Location
        /// </summary>
        public static string AddEditBookLocation { get { return "_AddEditBookLocation"; } }

        /// <summary>
        /// The ManageBookGenre
        /// </summary>
        public static string AddEditBookGenre { get { return "_AddEditBookGenre"; } }

        /// <summary>
        /// The Pages
        /// </summary>
        public static string AddEditPage { get { return "_AddEditPage"; } }

        /// <summary>
        /// The Pages
        /// </summary>
        public static string Pages { get { return "_Pages"; } }

        /// <summary>
        /// The Users
        /// </summary>
        public static string AddEditUsers { get { return "_AddEditUsers"; } }

        /// <summary>
        /// The CustomerList
        /// </summary>
        public static string CustomerList { get { return "_CustomerList"; } }

        /// <summary>
        /// The CustomerGrid
        /// </summary>
        public static string CustomerGrid { get { return "_CustomerGrid"; } }

        /// <summary>
        /// The Users
        /// </summary>
        public static string Users { get { return "_Users"; } }

        /// <summary>
        /// The ManageSpace
        /// </summary>
        public static string AddEditSpace { get { return "_AddEditSpace"; } }

        /// <summary>
        /// The Role
        /// </summary>
        public static string ManageRole { get { return "_ManageRole"; } }

        /// <summary>
        /// The Role
        /// </summary>
        public static string Roles { get { return "_Roles"; } }

        /// <summary>
        /// InviteCustomer
        /// </summary>
        public static string InviteCustomer { get { return "_InviteCustomer"; } }

        #region Books

        /// <summary>
        /// Manage Book
        /// </summary>
        public static string ManageBook { get { return "_managebook"; } }

        /// <summary>
        /// The BookGrid
        /// </summary>
        public static string BookGrid { get { return "_BookGrid"; } }

        /// <summary>
        /// The BookGrid
        /// </summary>
        public static string BookDetailSideBar { get { return "_BookDetailSideBar"; } }

        /// <summary>
        /// The BorrowerDetails
        /// </summary>
        public static string BorrowerDetails { get { return "_BorrowerDetails"; } }

        /// <summary>
        /// The BookDetailViewReload
        /// </summary>
        public static string BookDetailViewReload { get { return "_BookDetailViewReload"; } }

        /// <summary>
        /// The ReturnBook
        /// </summary>
        public static string ReturnBook { get { return "_ReturnBook"; } }

        #endregion

        #region SpaceBookings

        /// <summary>
        ///  Book the Space
        /// </summary>
        public static string BookSpace { get { return "_bookspace"; } }

        /// <summary>
        ///  Book the Space
        /// </summary>
        public static string ViewSpaceStatus { get { return "_ViewSpaceStatus"; } }

        /// <summary>
        ///  Book the Space
        /// </summary>
        public static string SpaceBookingRequests { get { return "_BookingRequests"; } }
        #endregion

        /// <summary>
        /// The Notifications Side Bar
        /// </summary>
        public static string Notifications { get { return "_notification"; } }

        /// <summary>
        /// The Messages
        /// </summary>
        public static string MessageList { get { return "_messagelist"; } }

        /// <summary>
        /// The Chat Users List
        /// </summary>
        public static string ChatList { get { return "_chatlist"; } }

        /// <summary>
        /// The Chat Users List
        /// </summary>
        public static string SendMessageModal { get { return "_sendmessage"; } }

        /// <summary>
        /// The Edit Customer
        /// </summary>
        public static string EditCustomer { get { return "_EditCustomer"; } }

        /// <summary>
        ///  Event Requests
        /// </summary>
        public static string EventRequests { get { return "_EventRequests"; } }
    }
}