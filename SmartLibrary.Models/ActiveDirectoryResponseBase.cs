// <copyright file="ActiveDirectoryResponseBase.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Infrastructure.DataAnnotations;
    using Newtonsoft.Json;

    /// <summary>
    /// User Login with Active Directory Model
    /// </summary>
    /// <CreatedBy>Bhargav Aboti</CreatedBy>
    /// <CreatedDate>20-Dec-2018</CreatedDate>
    public class ActiveDirectoryResponseBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDirectoryResponseBase"/> class.
        /// </summary>
        public ActiveDirectoryResponseBase()
        {
        }
                
        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        /// <summary>
        /// Gets or sets Error_description.
        /// </summary>
        [JsonProperty(PropertyName = "error_description")]
        public string Error_description { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets StatusCode.
        /// </summary>
        [JsonProperty(PropertyName = "StatusCode")]
        public string StatusCode { get; set; }
    }
}