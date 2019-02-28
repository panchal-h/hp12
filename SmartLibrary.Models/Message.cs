//-----------------------------------------------------------------------
// <copyright file="Message.cs" company="Caspian Pacific Tech">
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
    /// This class is used to Define Model for Table - Messages
    /// </summary>
    /// <CreatedBy>Karan Patel</CreatedBy>
    /// <CreatedDate>01-Oct-2018</CreatedDate>
    [Table("Messages")]
    public sealed class Message : BaseModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the CustomerId value.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the IsSendByAdmin is enabled.
        /// </summary>
        public bool? IsSendByAdmin { get; set; }

        /// <summary>
        /// Gets or sets the SenderId value.
        /// </summary>
        public int? SenderId { get; set; }

        /// <summary>
        /// Gets or sets the MessageTypeId value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Display(Name = "MessageType", ResourceType = typeof(Resources.General))]
        public int? MessageTypeId { get; set; }

        /// <summary>
        /// Gets or sets the BookId value.
        /// </summary>
        public int? BookId { get; set; }

        /// <summary>
        /// Gets or sets the Message value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Display(Name = "Description", ResourceType = typeof(Resources.General))]
        [RestrictSpecialCharacters]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the message is Read or not.
        /// </summary>
        public bool? IsRead { get; set; }

        /// <summary>
        /// Gets or sets the CreatedDate value.
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the CustomerName value.
        /// </summary>
        [MappingAttribute(MapName = "CustomerName")]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the SenderName value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "SenderName")]
        public string SenderName { get; set; }

        /// <summary>
        /// Gets or sets the ProfileImage value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "ProfileImagePath")]
        public string ProfileImagePath { get; set; }

        /// <summary>
        /// Gets or sets the BookName value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "BookName")]
        public string BookName { get; set; }
        #endregion
    }
}
