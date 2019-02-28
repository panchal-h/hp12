//-----------------------------------------------------------------------
// <copyright file="BookModel.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Book Model for API response.
    /// </summary>
    public class BookModel
    {
        /// <summary>
        /// Gets or sets the BookName value.
        /// </summary>
        public string BookName { get; set; }

        /// <summary>
        /// Gets or sets the ISBNNo value.
        /// </summary>
        public string ISBNNo { get; set; }

        /// <summary>
        /// Gets or sets the Image Thumbnail Links.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets the Description value.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Authors value.
        /// </summary>
        public string Authors { get; set; }

        /// <summary>
        /// Gets or sets the Publisher value.
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the PublishDate value.
        /// </summary>
        public DateTime? PublishDate { get; set; }
    }
}
