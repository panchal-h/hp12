// <copyright file="PageAccessAttribute.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    /// <summary>
    /// Page Access Attribute class
    /// </summary>
    public class PageAccessAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// Gets or sets PermissionName
        /// </summary>
        public string PermissionName { get; set; }

        /// <summary>
        /// Gets or sets ActionName
        /// </summary>
        public string ActionName { get; set; }     
    }
}
