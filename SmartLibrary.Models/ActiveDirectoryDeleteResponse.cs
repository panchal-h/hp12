// <copyright file="ActiveDirectoryDeleteResponse.cs" company="Caspian Pacific Tech">
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
    /// This class is used to Get Active Directory Delete response.
    /// </summary>
    /// <CreatedBy>Bhargav Aboti</CreatedBy>
    /// <CreatedDate>26-Dec-2018</CreatedDate>
    public class ActiveDirectoryDeleteResponse : ActiveDirectoryResponseBase
    {
        /// <summary>
        /// Gets or sets the Data list.
        /// </summary> 
        public virtual ActiveDirectoryDeleteDataResponse Data { get; set; }
    }
}