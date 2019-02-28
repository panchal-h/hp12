//-----------------------------------------------------------------------
// <copyright file="APIResponse.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    /// <summary>
    /// this class use for web API
    /// </summary>
    public sealed class APIResponse
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Status value.
        /// </summary>
        [NotMapped]
        public bool? Status { get; set; }

        /// <summary>
        /// Gets or sets the Message value.
        /// </summary>
        [NotMapped]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the Token value.
        /// </summary>
        [NotMapped]
        public string Token { get; set; }

        /// <summary>
        /// Gets or sets the Expired value.
        /// </summary>
        [NotMapped]
        public bool? Expired { get; set; }

        /// <summary>
        /// Gets or sets the Data value.
        /// </summary>
        [NotMapped]
        public object Data { get; set; }

        /// <summary>
        /// Gets or sets the Data value.
        /// </summary>
        [NotMapped]
        public int NextPageIndex { get; set; }

        /// <summary>
        /// Gets or sets the Language Id
        /// </summary>
        [NotMapped]
        public int LanguageId { get; set; }

        /////// <summary>
        /////// Gets or sets memberId Value
        /////// </summary>
        ////[NotMapped]
        ////public long MemberId { get; set; }

        /////// <summary>
        /////// Gets or sets the Token Value
        /////// </summary>
        ////[NotMapped]
        ////public string DeviceToken { get; set; }

        /////// <summary>
        /////// Gets or sets Device Type Value
        /////// </summary>
        ////[NotMapped]
        ////public string DeviceType { get; set; }

        /////// <summary>
        /////// Gets or sets Id Value
        /////// </summary>
        ////[NotMapped]
        ////public long Id { get; set; }

        /////// <summary>
        /////// Gets or sets Email Value
        /////// </summary>
        ////[NotMapped]
        ////public string Email { get; set; }

        /////// <summary>
        /////// Gets or sets First Name Value
        /////// </summary>
        ////[NotMapped]
        ////public string FirstName { get; set; }

        /////// <summary>
        /////// Gets or sets Last Name Value
        /////// </summary>
        ////[NotMapped]
        ////public string LastName { get; set; }

        /////// <summary>
        /////// Gets or sets Contact No Value
        /////// </summary>
        ////[NotMapped]
        ////public string ContactNo { get; set; }

        #endregion
    }
}
