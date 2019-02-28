// <copyright file="MessageController.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Admin.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Mvc;
    using DataTables.Mvc;
    using EmailServices;
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
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.ManageMessages)]
        [ActionName(Actions.ManageMessages)]
        public ActionResult Index()
        {
            return this.View(Views.Message, new Message());
        }

        /// <summary>
        /// Get Unread Message Count
        /// </summary>
        /// <returns>Unread Message Count</returns>
        [HttpGet]
        [ActionName(Actions.GetNewMessageCount)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.ManageMessages)]
        [SkipAuthorizationAttribute]
        public JsonResult GetNewMessageCount()
        {
            var messagesCount = this.messageDataBL.Search<Message>(new Message()
            {
                IsSendByAdmin = false,
                IsRead = false
            })?.Count() ?? 0;
            return this.Json(new { resultData = messagesCount }, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        ///  list of messages
        /// </summary>
        /// <param name="startIndex">startIndex</param>
        /// <param name="length">length</param>
        /// <param name="customerId">customerId</param>
        /// <param name="id">id</param>
        /// <returns>List of Spaces</returns>
        [HttpPost]
        [ActionName(Actions.GetMessages)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.ManageMessages)]
        public ActionResult GetMessages(int startIndex, int length, int customerId = 0, int id = 0)
        {
            List<Message> messages = this.messageDataBL.Search(new Message()
            {
                ID = id,
                CustomerId = customerId
                ////,StartRowIndex = startIndex + 1,
                ////EndRowIndex = startIndex + length
            }) ?? new List<Message>();

            if (customerId > 0)
            {
                this.messageDataBL.MarkMessageAsRead(false, customerId);
            }

            return this.PartialView(PartialViews.MessageList, messages.OrderBy(m => m.ID));
        }

        /// <summary>
        ///  list of chat users
        /// </summary>
        /// <param name="customerName">customerName</param>
        /// <returns>List of Spaces</returns>
        [HttpGet]
        [ActionName(Actions.GetChatList)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.ManageMessages)]
        public ActionResult GetChatList(string customerName = "")
        {
            List<Message> messages = this.messageDataBL.GetChatList(new Message()
            {
                CustomerName = customerName
            });

            return this.PartialView(PartialViews.ChatList, messages);
        }

        /// <summary>
        /// Send Message Modal.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Send Message  modal</returns>
        [HttpGet]
        [ActionName(Actions.SendMessageModal)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.ManageMessages)]
        public ActionResult SendMessageModal(int id = 0)
        {
            var customer = this.messageDataBL.Search<Customer>(new Customer() { Id = id }).FirstOrDefault();
            return this.PartialView(PartialViews.SendMessageModal, new Message()
            {
                CustomerId = customer?.Id ?? 0,
                CustomerName = customer?.FirstName + " " + customer?.LastName,
                ProfileImagePath = customer?.ProfileImagePath
            });
        }

        /// <summary>
        ///  send messages
        /// </summary>
        /// <param name="message">message</param>
        /// <returns>Send Message</returns>
        [HttpPost]
        [ActionName(Actions.SendMessage)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.ManageMessages)]
        public JsonResult SendMessage(Message message)
        {
            if (this.ModelState.IsValid)
            {
                message.IsSendByAdmin = true;
                message.SenderId = ProjectSession.UserId;
                int status = this.messageDataBL.Save<Message>(message, false, false);
                if (status > 0)
                {
                    Customer customer = this.messageDataBL.SelectObject<Customer>(message.CustomerId);

                    EmailViewModel emailModel = new EmailViewModel()
                    {
                        Email = customer.Email,
                        Name = customer.Name,
                        AdminMessage = message.Description,
                        LanguageId = ConvertTo.ToInteger(ProjectSession.AdminPortalLanguageId)
                    };
                    UserMail.MessageAlertForCustomer(emailModel);
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