//-----------------------------------------------------------------------
// <copyright file="User.cs" company="Caspian Pacific Tech">
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
    using SmartLibrary;
    using SmartLibrary.Infrastructure;
    using SmartLibrary.Infrastructure.DataAnnotations;
    using SmartLibrary.Models;

    /// <summary>
    /// This class is used to Define Model for Table - User
    /// </summary>
    /// <CreatedBy>Dhruvi</CreatedBy>
    /// <CreatedDate>28-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    [Table("Users")]
    public sealed class User : BaseModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MappingAttribute(MapName = "Id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Email value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Display(Name = "EmailAddress", ResourceType = typeof(Resources.Account))]
        [StringLength(75, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "StringLengthMessage")]
        [RegularExpression(SmartLibrary.Models.RegularExpressions.Email, ErrorMessageResourceType = typeof(Resources.Account), ErrorMessageResourceName = "InvalidEmailAddress")]
        [MappingAttribute(MapName = "Email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the Password value.
        /// </summary>
        ////[Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [StringLength(125, MinimumLength = 6, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "PasswordLengthMessageMinMax")]
        [DataType(DataType.Password)]
        [MappingAttribute(MapName = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Encrypted Pass
        /// </summary>
        [NotMapped]
        public string EncryptedPassword { get; set; }

        /// <summary>
        /// Gets or sets the FirstName value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Display(Name = "First Name")]
        [MappingAttribute(MapName = "FirstName")]
        [StringLength(50, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "StringLengthMessage")]
        [RestrictSpecialCharacters]       
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the LastName value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Display(Name = "Last Name")]
        [MappingAttribute(MapName = "LastName")]
        [StringLength(50, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "StringLengthMessage")]
        [RestrictSpecialCharacters]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the SuperAdmin value.
        /// </summary>
        [MappingAttribute(MapName = "SuperAdmin")]
        public bool? SuperAdmin { get; set; }

        /// <summary>
        /// Gets or sets the Active value.
        /// </summary>
        [MappingAttribute(MapName = "Active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or sets the RoleId value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [MappingAttribute(MapName = "RoleId")]
        public int? RoleId { get; set; }

        /// <summary>
        /// Gets or sets the Language value.
        /// </summary>
        [MappingAttribute(MapName = "Language")]
        public short? Language { get; set; }

        /// <summary>
        /// Gets or sets the LoginType value.
        /// </summary>
        [MappingAttribute(MapName = "LoginType")]
        public int LoginType { get; set; }

        /// <summary>
        /// Gets or sets the AGUserId value.
        /// </summary>
        [MappingAttribute(MapName = "AGUserId")]
        public string AGUserId { get; set; }

        /// <summary>
        /// Gets or sets the AGUserId value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [MappingAttribute(MapName = "PCNumber")]
        public string PCNumber { get; set; }

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
        /// Gets or sets the Role Name value.
        /// </summary>
        [NotMapped]
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or sets Password
        /// </summary>
        [NotMapped]
        [StringLength(125, MinimumLength = 6, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "PasswordLengthMessageMinMax")]
        [DataType(DataType.Password)]
        [Display(Name = "NewPassword", ResourceType = typeof(Resources.Account))]
        [RegularExpression(SmartLibrary.Models.RegularExpressions.HtmlTag, ErrorMessageResourceType = typeof(Resources.Account), ErrorMessageResourceName = "InvalidNewPassword")]
        public string NewPassword { get; set; }

        /// <summary>
        /// Gets or sets Password
        /// </summary>
        [NotMapped]
        [StringLength(125, MinimumLength = 6, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "PasswordLengthMessageMinMax")]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(Resources.Account))]
        [Compare(nameof(NewPassword), ErrorMessageResourceType = typeof(Resources.Account), ErrorMessageResourceName = "NewPasswordAndConfirmPasswordNotMatch")]
        [RegularExpression(SmartLibrary.Models.RegularExpressions.HtmlTag, ErrorMessageResourceType = typeof(Resources.Account), ErrorMessageResourceName = "InvalidConfirmPassword")]
        public string ConfirmPassword { get; set; }
        
        #endregion
    }
}
