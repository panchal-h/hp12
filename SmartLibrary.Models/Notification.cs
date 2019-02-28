// <copyright file="Notification.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Infrastructure;
    using Infrastructure.DataAnnotations;

    /// <summary>
    /// This class is used to Define Entity for Table - Notifications
    /// </summary>
    /// <CreatedBy>Bhoomi</CreatedBy>
    /// <CreatedDate>30-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    [Table("Notifications")]
    public sealed class Notification : BaseModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the IsAdmin UserId belong to Admin or Customer.
        /// </summary>
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Gets or sets the UserId value.
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or sets the BorrowedBookId value.
        /// </summary>
        public int? BorrowedBookId { get; set; }

        /// <summary>
        /// Gets or sets the BookId value.
        /// </summary>
        public int? BookId { get; set; }

        /// <summary>
        /// Gets or sets the SpaceBookingId value.
        /// </summary>
        public int? SpaceBookingId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the IsRead is enabled.
        /// </summary>
        public bool? IsRead { get; set; }

        /// <summary>
        /// Gets or sets the NotificationTypeId value.
        /// </summary>
        public int? NotificationTypeId { get; set; }

        /// <summary>
        /// Gets or sets the NotificationStartDate value.
        /// </summary>
        public DateTime? NotificationStartDate { get; set; }

        /// <summary>
        /// Gets or sets the NotificationEndDate value.
        /// </summary>
        public DateTime? NotificationEndDate { get; set; }

        /// <summary>
        /// Gets or sets the CreatedDate value.
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the Title value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the Description value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "Description")]
        public string Description { get; set; }
        #endregion
    }
}
