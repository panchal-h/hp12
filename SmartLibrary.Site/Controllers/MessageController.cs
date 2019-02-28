// <copyright file="MessageController.cs" company="Caspian Pacific Tech">
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
    /// Message Controller
    /// </summary>
    public class MessageController : BaseController
    {
        private MessageDataBL messageDataBL;

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageController"/> class.
        /// MasterController
        /// </summary>
        public MessageController()
        {
            if (this.messageDataBL == null)
            {
                this.messageDataBL = new MessageDataBL();
            }
        }

        #endregion Constructor

        #region ::Message::

        /// <summary>
        ///  Messages List
        /// </summary>
        /// <returns>Messages View page</returns>
        public ActionResult Index()
        {
            this.messageDataBL.MarkMessageAsRead(true, ProjectSession.CustomerId);
            return this.View(Views.Message, new Message());
        }

        /// <summary>
        /// Get Unread Message Count
        /// </summary>
        /// <returns>Unread Message Count</returns>
        [HttpGet]
        [ActionName(Actions.GetNewMessageCount)]
        public JsonResult GetNewMessageCount()
        {
            var messagesCount = this.messageDataBL.Search<Message>(new Message()
            {
                CustomerId = ProjectSession.CustomerId,
                IsSendByAdmin = true,
                IsRead = false
            })?.Count() ?? 0;
            return this.Json(new { resultData = messagesCount }, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        ///  list of messages
        /// </summary>
        /// <param name="startIndex">startIndex</param>
        /// <param name="length">length</param>
        /// <param name="id">id</param>
        /// <returns>List of Spaces</returns>
        [HttpPost]
        [ActionName(Actions.GetMessages)]
        public ActionResult GetMessages(int startIndex, int length, int id = 0)
        {
            List<Message> messages = this.messageDataBL.Search<Message>(new Message()
            {
                ID = id,
                CustomerId = ProjectSession.CustomerId
                ////,StartRowIndex = startIndex + 1,
                ////EndRowIndex = startIndex + length
            }) ?? new List<Message>();

            return this.PartialView(PartialViews.MessageList, messages.OrderBy(m => m.ID));
        }

        /// <summary>
        ///  list of chat users
        /// </summary>
        /// <returns>List of Spaces</returns>
        [HttpGet]
        [ActionName(Actions.GetChatList)]
        public ActionResult GetChatList()
        {
            List<Message> messages = this.messageDataBL.Search<Message>(new Message()
            {
                CustomerId = ProjectSession.CustomerId,
                StartRowIndex = 1,
                EndRowIndex = 1
            });

            return this.PartialView(PartialViews.ChatList, messages);
        }

        /// <summary>
        /// Send Message Modal.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Send Message  modal</returns>
        [ActionName(Actions.SendMessageModal)]
        public ActionResult SendMessageModal(int id = 0)
        {
            return this.PartialView(PartialViews.SendMessageModal, new Message() { BookId = id });
        }

        /// <summary>
        ///  send messages
        /// </summary>
        /// <param name="message">message</param>
        /// <returns>Send Message</returns>
        [HttpPost]
        [ActionName(Actions.SendMessage)]
        public JsonResult SendMessage(Message message)
        {
            if (this.ModelState.IsValid)
            {
                message.CustomerId = ProjectSession.CustomerId;
                message.IsSendByAdmin = false;
                message.SenderId = message.CustomerId;
                int status = this.messageDataBL.Save<Message>(message, false, false);
                if (status > 0)
                {
                    // SmartLibrary.Services.NotificationFactory.AddNotification(SystemEnumList.NotificationType.NewMessage, status);
                    return this.Json(new { resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.SendMessageSuccess, title = General.Send + " " + General.Message }, JsonRequestBehavior.DenyGet);
                }

                return this.Json(new { resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.SendMessageError }, JsonRequestBehavior.DenyGet);
            }
            else
            {
                string errorMsg = string.Empty;
                foreach (ModelState modelState in this.ViewData.ModelState.Values)
                {
                    foreach (ModelError error in modelState.Errors)
                    {
                        if (!string.IsNullOrEmpty(errorMsg))
                        {
                            errorMsg = errorMsg + " , ";
                        }

                        errorMsg = errorMsg + error.ErrorMessage;
                    }
                }

                return this.Json(new { resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = errorMsg }, JsonRequestBehavior.DenyGet);
            }
        }
        #endregion Message

    }
}