// <copyright file="MasterDropdown.cs" company="Caspian Pacific Tech">
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
    ///   This class is used to Define properties for binding Dropdown.
    /// </summary>
    /// <CreatedBy>Bhoomi Shah</CreatedBy>
    /// <CreatedDate>5-Sep-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class MasterDropdown
    {
        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Gets or sets the Name value.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the helper item value.
        /// </summary>
        /// <value>
        /// The helper item value.
        /// </value>
        public string HelperItems { get; set; }

        /// <summary>
        /// Gets or sets TotalRecords,  Common Property for All Entity which return Total Records for current List.
        /// </summary>
        /// <value>
        /// The count of the list
        /// </value>
        public int TotalRecords { get; set; }
    }
}
