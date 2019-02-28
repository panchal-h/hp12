// <copyright file="ActiveDirectoryUserDetailsResponse.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// User Login with Active Directory Model
    /// </summary>
    /// <CreatedBy>Bhargav Aboti</CreatedBy>
    /// <CreatedDate>26-Dec-2018</CreatedDate>
    public class ActiveDirectoryUserDetailsResponse : ActiveDirectoryResponseBase
    {
        /// <summary>
        /// Gets or sets the Data list.
        /// </summary> 
        public ActiveDirectoryUserData Data { get; set; }
    }
}
