// <copyright file="ControllerNameAttribute.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// ControllerNameAttribute
    /// </summary>
    public class ControllerNameAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControllerNameAttribute"/> class.
        /// constructor  ControllerNameAttribute
        /// </summary>
        /// <param name="controllerName">controllerName</param>
        public ControllerNameAttribute(string controllerName)
        {
            this.ControllerName = controllerName;
        }

        /// <summary>
        /// Gets or sets the ControllerName value.
        /// </summary>
        public string ControllerName { get; set; }
    }
}
