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
        public static string AccessDenied { get { return "_accessdenied"; } }

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
        /// The Comment
        /// </summary>
        public static string CommentList { get { return "_CommentList"; } }

        /// <summary>
        /// The Book Detail View Reload
        /// </summary>
        public static string BookDetailViewReload { get { return "_BookDetailViewReload"; } }

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
        #endregion

        #region SpaceBookings

        /// <summary>
        ///  Book the Space
        /// </summary>
        public static string BookSpace { get { return "_bookspace"; } }

        /// <summary>
        ///  Book the Space
        /// </summary>
        public static string SpaceBookingRequests { get { return "_BookingRequests"; } }

        /// <summary>
        ///  Book the Space
        /// </summary>
        public static string ViewSpaceStatus { get { return "_ViewSpaceStatus"; } }

        #endregion
    }
}