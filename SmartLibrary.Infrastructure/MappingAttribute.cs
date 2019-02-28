//-----------------------------------------------------------------------
// <copyright file="MappingAttribute.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure
{
    using System;

    /// <summary>
    /// Mapping attribure class
    /// </summary>
    public class MappingAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets MapName
        /// </summary>
        public string MapName { get; set; }
    }
}
