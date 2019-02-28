// <copyright file="LocalizedDescriptionAttribute.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Reflection;
    using System.Resources;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// LocalizedDescriptionAttribute
    /// </summary>
    public class LocalizedDescriptionAttribute : DescriptionAttribute
    {
        private readonly string resourceKey;
        private readonly ResourceManager resource;      

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedDescriptionAttribute"/> class.
        /// </summary>
        /// <param name="resourceKey">resourceKey</param>
        /// <param name="resourceType">resourceType</param>
        public LocalizedDescriptionAttribute(string resourceKey, Type resourceType)
        {
            this.resource = new ResourceManager(resourceType);
            this.resourceKey = resourceKey;
        }

        /// <inheritdoc/>
        public override string Description
        {
            get
            {
                string displayName = this.resource.GetString(this.resourceKey);

                return string.IsNullOrEmpty(displayName)
                    ? string.Format("[[{0}]]", this.resourceKey)
                    : displayName;
            }
        }        
    }
}
