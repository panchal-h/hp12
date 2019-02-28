//-----------------------------------------------------------------------
// <copyright file="PageAccess.cs" company="Caspian Pacific Tech">
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

    /// <summary>
    /// This class is used to Define Model for Table - PageAccess
    /// </summary>
    /// <CreatedBy>Dhruvi</CreatedBy>
    /// <CreatedDate>28-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    [Table("PageAccesses")]
    public sealed class PageAccess : BaseModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MappingAttribute(MapName = "Id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the RoleId value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [MappingAttribute(MapName = "RoleId")]
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the PageId value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [MappingAttribute(MapName = "PageId")]
        public int PageId { get; set; }

        /// <summary>
        /// Gets or sets the IsView value.
        /// </summary>
        [MappingAttribute(MapName = "IsView")]
        public bool? IsView { get; set; }       

        /// <summary>
        /// Gets or sets the IsAddUpdate value.
        /// </summary>
        [MappingAttribute(MapName = "IsAddUpdate")]
        public bool? IsAddUpdate { get; set; }

        /// <summary>
        /// Gets or sets the IsDelete value.
        /// </summary>
        [MappingAttribute(MapName = "IsDelete")]
        public bool? IsDelete { get; set; }

        /// <summary>
        /// Gets or sets the CreatedBy value.
        /// </summary>
        public int CreatedBy { get; set; }

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

        /// <summary>
        /// Gets or sets the PageName value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "PageName")]
        public string PageName { get; set; }

        /// <summary>
        /// Gets or sets the ActionName value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "ActionName")]
        public string ActionName { get; set; }
        #endregion
    }
}
