// <copyright file="ControllerExtensions.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Infrastructure.Code
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using static SystemEnumList;

    /// <summary>
    /// Controller Extensions.
    /// </summary>
    public static class ControllerExtensions
    {
        /// <summary>
        /// Add Toast Message. 
        /// </summary>
        /// <param name="controller">controller</param>
        /// <param name="title">title.</param>
        /// <param name="message">message.</param>
        /// <param name="toastType">toastType.</param>
        /// <param name="showCloseButton">showCloseButton.</param>
        /// <returns>ResponseMessages.</returns>
        public static ResponseMessages AddToastMessage(this Controller controller, string title, string message, MessageBoxType toastType = MessageBoxType.Info, bool showCloseButton = false)
        {
            Message toastr = controller.TempData["SessionMessageList"] as Message;
            toastr = toastr ?? new Message();
            if (toastr.ResponseMessages.Any(m => m.Message == message && m.Title == title))
            {
                return null;
            }

            toastr.ShowCloseButton = showCloseButton;
            var toastMessage = toastr.AddToastMessage(title, message, toastType);
            controller.TempData["SessionMessageList"] = toastr;
            return toastMessage;
        }
    }
}
