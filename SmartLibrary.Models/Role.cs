//-----------------------------------------------------------------------
// <copyright file="Role.cs" company="Caspian Pacific Tech">
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
    using Infrastructure.DataAnnotations;
    using SmartLibrary.Models;

    /// <summary>
    /// This class is used to Define Model for Table - Role
    /// </summary>
    /// <CreatedBy>Dhruvi</CreatedBy>
    /// <CreatedDate>28-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    [Table("Roles")]
    public sealed class Role : BaseModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Name value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [RestrictSpecialCharacters]
        [StringLength(100, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "StringLengthMessage")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets the Active value.
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
        /// Gets or sets the ModifiedDate Name value.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the PageAccesses value.
        /// </summary>
        [NotMapped]
        public string PageAccesses { get; set; }

        /// <summary>
        /// Gets or sets the PageAccessList value.
        /// </summary>
        [NotMapped]     
        public List<PageAccess> PageAccessList { get; set; }

        #endregion
    }
}
