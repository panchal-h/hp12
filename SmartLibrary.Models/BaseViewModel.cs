// <copyright file="BaseViewModel.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// BaseViewModel
    /// </summary>
    public class BaseViewModel
    {      
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseViewModel"/> class.
        /// </summary>
        public BaseViewModel()
        {
            this.CurrentPage = 1;
        }

        /// <summary>
        /// Gets or sets Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets PageSize
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or sets CurrentPage
        /// </summary>
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Gets or sets TotalPage
        /// </summary>
        public int? TotalPage { get; set; }

        /// <summary>
        /// Gets or sets SortExpression
        /// </summary>
        public string SortExpression { get; set; }

        /// <summary>
        /// Gets or sets SortDirection
        /// </summary>
        public string SortDirection { get; set; }

        /// <summary>
        /// Gets or sets Searchtext
        /// </summary>
        public string Searchtext { get; set; }
    }
}