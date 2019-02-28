// <copyright file="ActiveDirectoryUserApiResponse.cs" company="Caspian Pacific Tech">
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
    /// This class is used to Get Active Directory User Api response.
    /// </summary>
    /// <CreatedBy>Tirthak Shah</CreatedBy>
    /// <CreatedDate>06-Sep-2018</CreatedDate>
    public class ActiveDirectoryUserApiResponse : ActiveDirectoryResponseBase
    {
        /// <summary>
        /// Gets or sets the Data list.
        /// </summary> 
        public virtual IEnumerable<ActiveDirectoryUser> Data { get; set; }
    }
}
