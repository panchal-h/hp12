// <copyright file="Message.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Infrastructure.Code
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static SystemEnumList;

    /// <summary>
    ///  This class is for Message.
    /// </summary>
    /// <CreatedBy>Bhoomi Shah.</CreatedBy>
    /// <CreatedDate>7-Sept-2018.</CreatedDate>
    public class Message
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        public Message()
        {
            this.ResponseMessages = new List<ResponseMessages>();
            this.ShowNewestOnTop = false;
            this.ShowCloseButton = false;
        }

        /// <summary>
        /// Gets or sets a value indicating whether show Message at top
        /// </summary>
        public bool ShowNewestOnTop { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether show close button
        /// </summary>
        public bool ShowCloseButton { get; set; }

        /// <summary>
        /// Gets or sets Response Messages
        /// </summary>
        public List<ResponseMessages> ResponseMessages { get; set; }

        /// <summary>
        /// Show Toast Message
        /// </summary>
        /// <param name="title">title</param>
        /// <param name="message">message</param>
        /// <param name="messageType">messageType</param>
        /// <returns>the ResponseMessages</returns>
        public ResponseMessages AddToastMessage(string title, string message, MessageBoxType messageType)
        {
            var toast = new ResponseMessages()
            {
                Title = title,
                Message = message,
                MessageType = messageType
            };
            this.ResponseMessages.Add(toast);
            return toast;
        }
    }
}
