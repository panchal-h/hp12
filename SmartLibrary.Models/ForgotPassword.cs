//-----------------------------------------------------------------------
// <copyright file="ForgotPassword.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace SmartLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    /// <summary>Forgot Password </summary>
    /// <CreatedBy>Dhruvi Shah</CreatedBy>
    /// <CreatedDate>12-Sep-2017</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class ForgotPassword
    {
        /// <summary>
        /// Gets or sets User name
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Display(Name = "Username", ResourceType = typeof(Resources.Account))]
        [RegularExpression(SmartLibrary.Models.RegularExpressions.Email, ErrorMessageResourceType = typeof(Resources.Account), ErrorMessageResourceName = "InvalidEmailAddress")]
        public string Username { get; set; }
    }
}