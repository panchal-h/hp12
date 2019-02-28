// <copyright file="SmartLibraryAPIData.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

/// <summary>
/// Register Model
/// </summary>
namespace SmartLibrary.Models.AGModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Register API Model
    /// </summary>
    public class SmartLibraryAPIData
    {
        /// <summary>
        /// Gets or sets the SmartLibraryId value.
        /// </summary>
        public object SmartLibraryId { get; set; }

        /// <summary>
        /// Gets or sets the ProfileImage value.
        /// </summary>
        public object ProfileImage { get; set; }

        /// <summary>
        /// Gets or sets the Gender value.
        /// </summary>
        public object Gender { get; set; }

        /// <summary>
        /// Gets or sets the Phone value.
        /// </summary>
        public object Phone { get; set; }
    }    
}
