//-----------------------------------------------------------------------
// <copyright file="StatusGroups.cs" company="Caspian Pacific Tech">
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

    /// <summary>
    /// This class is used to Define Model for Table - StatusGroups
    /// </summary>
    /// <CreatedBy>Bhargav</CreatedBy>
    /// <CreatedDate>30-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    [Table("StatusGroups")]
    public sealed class StatusGroups : BaseModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the Name value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [StringLength(100, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "StringLengthMessage")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Active value.
        /// </summary>
        public bool? Active { get; set; }

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

        #endregion
    }
}
