// <copyright file="ActiveDirectoryRegisterDataResponse.cs" company="Caspian Pacific Tech">
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
    /// This class is used to Get Active Directory Register Data response.
    /// </summary>
    /// <CreatedBy>Bhargav Aboti</CreatedBy>
    /// <CreatedDate>26-Dec-2018</CreatedDate>
    public class ActiveDirectoryRegisterDataResponse
    {
        /// <summary>
        /// Gets or sets a value indicating whether IsUserExists value.
        /// </summary> 
        public bool IsUserExists { get; set; }

        /// <summary>
        /// Gets or sets the UserId value.
        /// </summary> 
        public string UserId { get; set; }
    }
}
