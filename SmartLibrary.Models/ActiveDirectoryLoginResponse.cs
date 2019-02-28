// <copyright file="ActiveDirectoryLoginResponse.cs" company="Caspian Pacific Tech">
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
    public class ActiveDirectoryLoginResponse : ActiveDirectoryResponseBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDirectoryLoginResponse"/> class.
        /// </summary>
        public ActiveDirectoryLoginResponse()
        {
        }

        /// <summary>
        /// Gets or sets a value userId
        /// </summary>        
        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets a value UserName
        /// </summary>        
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets a value email
        /// </summary>        
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a token_type
        /// </summary>
        [JsonProperty(PropertyName = "token_type")]
        public string Token_Type { get; set; }

        /// <summary>
        /// Gets or sets Access
        /// </summary>
        [JsonProperty(PropertyName = "access_token")]
        public string Access_Token { get; set; }

        /// <summary>
        /// Gets or sets Expire.
        /// </summary>
        [JsonProperty(PropertyName = "expires_in")]
        public int Expires_in { get; set; }

        /// <summary>
        /// Gets or sets issued date.
        /// </summary>
        [JsonProperty(PropertyName = ".issued")]
        public string Issued { get; set; }

        /// <summary>
        /// Gets or sets Expires
        /// </summary>
        [JsonProperty(PropertyName = ".expires")]
        public string Expires { get; set; }

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
        /// Gets or sets a value indicating whether IsAppUser.
        /// </summary>
        [JsonProperty(PropertyName = "IsAppUser")]
        public bool IsAppUser { get; set; }
    }
}
