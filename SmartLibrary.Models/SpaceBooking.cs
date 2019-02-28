//-----------------------------------------------------------------------
// <copyright file="SpaceBooking.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

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
    /// This class is used to Define Entity for Table - SpaceBookings
    /// </summary>
    /// <CreatedBy>Bhoomi</CreatedBy>
    /// <CreatedDate>17-Sep-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    [Table("SpaceBookings")]
    public sealed class SpaceBooking : BaseModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MappingAttribute(MapName = "ID")]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the Book Name.
        /// </summary>
        [MappingAttribute(MapName = "SpaceName")]       
        public string SpaceName { get; set; }

        /// <summary>
        /// Gets or sets the BookingTitle value.
        /// </summary>
        [MappingAttribute(MapName = "BookingTitle")]
        public string BookingTitle { get; set; }

        /// <summary>
        /// Gets or sets the NoOfPeople value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Range(1, 10000, ErrorMessageResourceName = "InvalidRangeMessage", ErrorMessageResourceType = typeof(Resources.Messages))]
        [RegularExpression(@"^[0-9]*$", ErrorMessageResourceName = "InvalidInputMessage", ErrorMessageResourceType = typeof(Resources.Messages))]
        [Display(Name = "TotalAttendees", ResourceType = typeof(Resources.General))]
        [MappingAttribute(MapName = "NoOfPeople")]
        public short? NoOfPeople { get; set; }

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
        /// Gets or sets the CustomerId value.
        /// </summary>
        public int? CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the CustomerName value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "CustomerName")]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the CustomerEmail value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "CustomerEmail")]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// Gets or sets the SpaceId value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Display(Name = "BookingArea", ResourceType = typeof(Resources.General))]
        public int? SpaceId { get; set; }

        /// <summary>
        /// Gets or sets the Reschedule value.
        /// </summary>
        public bool? Reschedule { get; set; }

        /// <summary>
        /// Gets or sets the RescheduleId value.
        /// </summary>
        public int? RescheduleId { get; set; }

        /// <summary>
        /// Gets or sets the ReturnNotes value.
        /// </summary>
        [Display(Name = "Comment", ResourceType = typeof(Resources.General))]
        [StringLength(500, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "StringLengthMessage")]
        [RestrictSpecialCharacters]
        [MappingAttribute(MapName = "Comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the Active value.
        /// </summary>
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or sets the StatusId value.
        /// </summary>
        [Display(Name = "Status", ResourceType = typeof(Resources.General))]
        [MappingAttribute(MapName = "StatusId")]
        public int? StatusId { get; set; }

        /// <summary>
        /// Gets or sets the Status value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "Status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the CreatedBy value.
        /// </summary>
        public int? CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the CreatedBy Name value.
        /// </summary>
        [NotMapped]
        public string CreatedByName { get; set; }

        /// <summary>
        /// Gets or sets the CreatedDate value.
        /// </summary>
        [MappingAttribute(MapName = "CreatedDate")]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the ModifiedBy value.
        /// </summary>
        public int? ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the ModifiedBy Name value.
        /// </summary>
        [NotMapped]
        public string ModifiedByName { get; set; }

        /// <summary>
        /// Gets or sets the ModifiedDate value.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the Bookingtime value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "Bookingtime")]
        public string Bookingtime { get; set; }

        /// <summary>
        /// Gets or sets the BookingDate value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [NotMapped]
        [MappingAttribute(MapName = "BookingDate")]
        [Display(Name = "BookingDate", ResourceType = typeof(Resources.General))]
        public string BookingDate { get; set; }

        /// <summary>
        /// Gets or sets the FromTime value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [NotMapped]
        [MappingAttribute(MapName = "FromTime")]
        [Display(Name = "FromTime", ResourceType = typeof(Resources.General))]
        public string FromTime { get; set; }

        /// <summary>
        /// Gets or sets the ToTime value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [NotMapped]
        [MappingAttribute(MapName = "ToTime")]
        [Display(Name = "ToTime", ResourceType = typeof(Resources.General))]
        public string ToTime { get; set; }

        /// <summary>
        /// Gets the DaysLeft value.
        /// </summary>
        [NotMapped]
        public int? DaysLeft => this.FromDate.HasValue && this.FromDate.Value.Date > DateTime.Now.Date ? (int?)this.FromDate.Value.Date.Subtract(DateTime.Now.Date).TotalDays : 0;

        /// <summary>
        /// Gets or sets the ProfileImagePath value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "ProfileImagePath")]
        public string ProfileImagePath { get; set; }     
        #endregion
    }
}
