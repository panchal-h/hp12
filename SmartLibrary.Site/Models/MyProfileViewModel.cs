// <copyright file="MyProfileViewModel.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Site.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Infrastructure;
    using SmartLibrary.Infrastructure.DataAnnotations;
    using SmartLibrary.Models;

    /// <summary>
    /// This class is used to Define Model for Table - Customer
    /// </summary>
    /// <CreatedBy>Bhargav Aboti</CreatedBy>
    /// <CreatedDate>20-Sep-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class MyProfileViewModel : BaseModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MappingAttribute(MapName = "Id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the FirstName value.
        /// </summary>
        [RestrictSpecialCharacters]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [StringLength(50, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "StringLengthMessage")]
        [MappingAttribute(MapName = "FirstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the LastName value.
        /// </summary>
        [RestrictSpecialCharacters]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [StringLength(50, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "StringLengthMessage")]
        [MappingAttribute(MapName = "LastName")]
        public string LastName { get; set; }

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
        /// Gets or sets the Gender value.
        /// </summary>
        [MappingAttribute(MapName = "Gender")]
        public int? Gender { get; set; }

        /// <summary>
        /// Gets or sets the Phone value.
        /// </summary>
        [RegularExpression(@"^(?:\+971|00971|0)(?:2|3|4|6|7|9|50|51|52|55|56)[0-9]{7}$", ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "InvalidPhoneNumber")]
        [MappingAttribute(MapName = "Phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the Password value.
        /// </summary>
        [StringLength(125, MinimumLength = 6, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "PasswordLengthMessageMinMax")]
        [DataType(DataType.Password)]
        [MappingAttribute(MapName = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the Active value.
        /// </summary>
        [MappingAttribute(MapName = "Active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or sets the ProfileImage value.
        /// </summary>
        [MappingAttribute(MapName = "ProfileImagePath")]
        public string ProfileImagePath { get; set; }

        /// <summary>
        /// Gets or sets the Language value.
        /// </summary>
        [MappingAttribute(MapName = "Language")]
        public short? Language { get; set; }

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
        /// Gets or sets the ModifiedDate value.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the Name value.
        /// </summary>
        [NotMapped]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Status value.
        /// </summary>
        [NotMapped]
        public string Status { get; set; }

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