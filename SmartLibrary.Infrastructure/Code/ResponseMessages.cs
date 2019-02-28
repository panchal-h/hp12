// <copyright file="ResponseMessages.cs" company="Caspian Pacific Tech">
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
    ///  This class is for Response Messages.
    /// </summary>
    /// <CreatedBy>Bhoomi Shah.</CreatedBy>
    /// <CreatedDate>7-Sept-2018.</CreatedDate>
    public class ResponseMessages 
    {
        /// <summary>
        /// Gets or sets title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets Message Type
        /// </summary>
        public MessageBoxType MessageType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets IsSticky
        /// </summary>
        public bool IsSticky { get; set; }
    }
}
