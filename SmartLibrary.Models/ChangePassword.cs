// <copyright file="ChangePassword.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Web;

    /// <summary>
    /// Change Password Model
    /// </summary>
    /// <CreatedBy>Tirthak Shah</CreatedBy>
    /// <CreatedDate>14-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class ChangePassword
    {
        /// <summary>
        /// Gets or sets Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets Current Password
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [StringLength(125, MinimumLength = 6, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "PasswordLengthMessageMinMax")]
        [DataType(DataType.Password)]
        [Display(Name = "CurrentPassword", ResourceType = typeof(Resources.Account))]
        [RegularExpression(SmartLibrary.Models.RegularExpressions.HtmlTag, ErrorMessageResourceType = typeof(Resources.Account), ErrorMessageResourceName = "InvalidCurrentPassword")]
        public string CurrentPassword { get; set; }

        /// <summary>
        /// Gets or sets Current Password
        /// </summary>
        [NotMapped]
        public string EncryptedCurrentPassword { get; set; }

        /// <summary>
        /// Gets or sets Password
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [StringLength(125, MinimumLength = 6, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "PasswordLengthMessageMinMax")]
        [DataType(DataType.Password)]
        [Display(Name = "NewPassword", ResourceType = typeof(Resources.Account))]
        [RegularExpression(SmartLibrary.Models.RegularExpressions.HtmlTag, ErrorMessageResourceType = typeof(Resources.Account), ErrorMessageResourceName = "InvalidNewPassword")]
        public string NewPassword { get; set; }

        /// <summary>
        /// Gets or sets Current Password
        /// </summary>
        [NotMapped]
        public string EncryptedNewPassword { get; set; }

        /// <summary>
        /// Gets or sets Password
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [StringLength(125, MinimumLength = 6, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "PasswordLengthMessageMinMax")]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword", ResourceType = typeof(Resources.Account))]
        [Compare("NewPassword", ErrorMessageResourceType = typeof(Resources.Account), ErrorMessageResourceName = "NewPasswordAndConfirmPasswordNotMatch")]
        [RegularExpression(SmartLibrary.Models.RegularExpressions.HtmlTag, ErrorMessageResourceType = typeof(Resources.Account), ErrorMessageResourceName = "InvalidConfirmPassword")]
        public string ConfirmPassword { get; set; }

        /// <summary>
        /// Gets or sets Current Password
        /// </summary>
        [NotMapped]
        public string EncryptedConfirmPassword { get; set; }
    }
}