// <copyright file="ActiveDirectoryUser.cs" company="Caspian Pacific Tech">
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
    /// This class is used to Get Active Directory User List.
    /// </summary>
    /// <CreatedBy>Tirthak Shah</CreatedBy>
    /// <CreatedDate>06-Sep-2018</CreatedDate>
    public class ActiveDirectoryUser
    {
        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>        
        public int? EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the PhoneNumber value.
        /// </summary> 
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the Name value.
        /// </summary> 
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Email value.
        /// </summary> 
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the PCNumber value.
        /// </summary> 
        public string PCNumber { get; set; }
    }
}
