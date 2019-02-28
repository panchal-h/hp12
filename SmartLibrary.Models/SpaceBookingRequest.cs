// <copyright file="SpaceBookingRequest.cs" company="Caspian Pacific Tech">
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
    /// This class is used to Define Entity for Table - SpaceBookingRequests
    /// </summary>
    /// <CreatedBy>Karan</CreatedBy>
    /// <CreatedDate>26-Sep-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    [Table("SpaceBookingRequests")]
    public sealed class SpaceBookingRequest : BaseModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the FromDate value.
        /// </summary>
        [MappingAttribute(MapName = "FromDate")]
        public DateTime? FromDate { get; set; }

        /// <summary>
        /// Gets or sets the ToDate value.
        /// </summary>
        [MappingAttribute(MapName = "ToDate")]
        public DateTime? ToDate { get; set; }

        /// <summary>
        /// Gets or sets the SpaceId value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Display(Name = "BookingArea", ResourceType = typeof(Resources.General))]
        public int? SpaceId { get; set; }
        #endregion
    }
}
