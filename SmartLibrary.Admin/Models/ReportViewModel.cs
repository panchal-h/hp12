// <copyright file="ReportViewModel.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// This class is used to Define Model for report.
    /// </summary>
    /// <CreatedBy>Bhargav Aboti</CreatedBy>
    /// <CreatedDate>11-Oct-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class ReportViewModel
    {
        /// <summary>
        /// Gets or sets TotalBooksBorrowed
        /// </summary>
        public int TotalBooksBorrowed { get; set; }

        /// <summary>
        /// Gets or sets TotalBooks
        /// </summary>
        public int TotalBooks { get; set; }

        /// <summary>
        /// Gets or sets TotalRoomsBooked
        /// </summary>
        public int TotalRoomsBooked { get; set; }

        /// <summary>
        /// Gets or sets TotalBooks
        /// </summary>
        public int TotalBooksBorrowedThroughLibrary { get; set; }

        /// <summary>
        /// Gets or sets PopularBook
        /// </summary>
        public DataTable PopularBook { get; set; }

        /// <summary>
        /// Gets or sets ActiveBorrower
        /// </summary>
        public DataTable ActiveBorrower { get; set; }

        /// <summary>
        /// Gets or sets PopularGenre
        /// </summary>
        public DataTable PopularGenre { get; set; }

        /// <summary>
        /// Gets or sets PopularAuthorName
        /// </summary>
        public DataTable PopularAuthor { get; set; }

        /// <summary>
        /// Gets or sets PopularUserBookingRoom
        /// </summary>
        public DataTable PopularUserBookingRoom { get; set; }

        /// <summary>
        /// Gets or sets PopularTime
        /// </summary>
        public DataTable PopularTime { get; set; }

        /// <summary>
        /// Gets or sets ReturnBookDelay
        /// </summary>
        public decimal ReturnedBookDelay { get; set; }

        /// <summary>
        /// Gets or sets ReturnedBookOnTime
        /// </summary>
        public decimal ReturnedBookOnTime { get; set; }
    }
}