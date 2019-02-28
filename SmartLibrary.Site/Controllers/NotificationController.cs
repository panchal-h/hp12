// <copyright file="NotificationController.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Site.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Mvc;
    using DataTables.Mvc;
    using Infrastructure;
    using Infrastructure.Filters;
    using Models;
    using Pages;
    using Resources;
    using Services;
    using SmartLibrary.Models;

    /// <summary>
    /// Notification Controller
    /// </summary>
    public class NotificationController : BaseController
    {
        private NotificationDataBL notificationDataBL;

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationController"/> class.
        /// MasterController
        /// </summary>
        public NotificationController()
        {
            if (this.notificationDataBL == null)
            {
                this.notificationDataBL = new NotificationDataBL();
            }
        }

        #endregion Constructor

        #region ::Notifications::

        /// <summary>
        /// Get Unread Notification Count
        /// </summary>
        /// <returns>Unread Notification Count</returns>
        [HttpGet]
        [ActionName(Actions.GetNewNotificationCount)]
        [SkipAuthorizationAttribute]
        public JsonResult GetNewNotificationCount()
        {
            var notificationsCount = this.notificationDataBL.Search<Notification>(new Notification()
            {
                IsAdmin = false,
                UserId = ProjectSession.CustomerId,
                IsRead = false
            })?.Count() ?? 0;

            return this.Json(new { resultData = notificationsCount }, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Get Notifications
        /// </summary>
        /// <returns>List of Notifications</returns>
        [HttpGet]
        [ActionName(Actions.GetNotifications)]
        [SkipAuthorizationAttribute]
        public ActionResult GetNotifications()
        {
            var notifications = this.notificationDataBL.Search<Notification>(new Notification()
            {
                IsAdmin = false,
                UserId = ProjectSession.CustomerId
            });

            if (notifications?.Count > 0 && notifications.Any(n => n.IsRead == false))
            {
                this.notificationDataBL.MarkNotificationAsRead(string.Join(",", notifications.Where(n => n.IsRead == false).Select(n => n.ID)));
            }

            return this.PartialView(PartialViews.Notifications, notifications);
        }
        #endregion
    }
}
