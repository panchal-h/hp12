// <copyright file="PageAccessRight.cs" company="Caspian Pacific Tech">
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
    /// public class PageAccessRight.
    /// </summary>
    public class PageAccessRight
    {
        /// <summary>
        /// Gets or sets the Controller.
        /// </summary>
        /// <value>
        /// Controller.
        /// </value>
        public string Controller { get; set; }

        /// <summary>
        /// Gets or sets the PageName.
        /// </summary>
        /// <value>
        /// PageName.
        /// </value>
        public string PageName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [view].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [view]; otherwise, <c>false</c>.
        /// </value>
        public bool View { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [AddUpdate].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [AddUpdate]; otherwise, <c>false</c>.
        /// </value>
        public bool AddUpdate { get; set; }       

        /// <summary>
        /// Gets or sets a value indicating whether [delete].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [delete]; otherwise, <c>false</c>.
        /// </value>
        public bool Delete { get; set; }
    }
}
