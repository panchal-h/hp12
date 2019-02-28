// <copyright file="PartialViews.cs" company="Caspian Pacific Tech">
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
        /// The Comment
        /// </summary>
        public const string CommentList = "_CommentList";

        /// <summary>
        /// The Book Detail View Reload
        /// </summary>
        public const string BookDetailViewReload = "_BookDetailViewReload";

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
        #endregion

        #region SpaceBookings

        /// <summary>
        ///  Book the Space
        /// </summary>
        public const string BookSpace = "_bookspace";

        /// <summary>
        ///  Book the Space
        /// </summary>
        public const string SpaceBookingRequests = "_BookingRequests";

        /// <summary>
        ///  Book the Space
        /// </summary>
        public const string ViewSpaceStatus = "_ViewSpaceStatus";

        #endregion
    }
}