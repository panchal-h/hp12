// <copyright file="BookDiscussion.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Infrastructure;

    /// <summary>
    /// This class is used to Define Entity for Table - BookDiscussion
    /// </summary>
    /// <CreatedBy>Bhoomi</CreatedBy>
    /// <CreatedDate>21-Sep-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    [Table("BookDiscussion")]
    public sealed class BookDiscussion : BaseModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MappingAttribute(MapName = "ID")]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the BookId value.
        /// </summary>
        [MappingAttribute(MapName = "BookId")]
        public int BookId { get; set; }

        /// <summary>
        /// Gets or sets the CustomerId value.
        /// </summary>
        [MappingAttribute(MapName = "CustomerId")]
        public int? CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the UserId value.
        /// </summary>
        [MappingAttribute(MapName = "UserId")]
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or sets the MessageDescription value.
        /// </summary> 
        [StringLength(1500, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "StringLengthMessage")]
        [MappingAttribute(MapName = "MessageDescription")]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        public string MessageDescription { get; set; }

        /// <summary>
        /// Gets or sets the IsFromAdmin value.
        /// </summary>
        [MappingAttribute(MapName = "IsFromAdmin")]
        public bool? IsFromAdmin { get; set; }

        /// <summary>
        /// Gets or sets the Approved value.
        /// </summary>
        [MappingAttribute(MapName = "Approved")]
        public bool? Approved { get; set; }

        /// <summary>
        /// Gets or sets the CreatedBy value.
        /// </summary>
        [MappingAttribute(MapName = "CreatedBy")]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the CreatedBy Name value.
        /// </summary>
        [MappingAttribute(MapName = "CreatedByName")]
        [NotMapped]
        public string CreatedByName { get; set; }

        /// <summary>
        /// Gets or sets the CreatedDate value.
        /// </summary>
        [MappingAttribute(MapName = "CreatedDate")]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the ProfileImagePath value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "ProfileImagePath")]
        public string ProfileImagePath { get; set; }

        /// <summary>
        /// Gets or sets the CustomerName value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "CustomerName")]
        public string CustomerName { get; set; }
        #endregion
    }
}
