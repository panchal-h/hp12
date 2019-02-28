// <copyright file="Login.cs" company="Caspian Pacific Tech">
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
    using Infrastructure.DataAnnotations;

    /// <summary>
    /// Login model
    /// </summary>
    /// <CreatedBy>Dhruvi Shah</CreatedBy>
    /// <CreatedDate>04-Sept-2018</CreatedDate>
    public class Login
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Login"/> class.
        /// </summary>
        public Login()
        {
        }

        /// <summary>
        /// Gets or sets a value UserAccount
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [RestrictSpecialCharacters]
        [StringLength(75, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "StringLengthMessage")]            
        [Display(Name = "EmailAddress", ResourceType = typeof(Resources.Account))]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a Password
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(Resources.Account))]
        [StringLength(125, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "StringLengthMessage")]
        [RegularExpression(SmartLibrary.Models.RegularExpressions.HtmlTag, ErrorMessageResourceType = typeof(Resources.Account), ErrorMessageResourceName = "InvalidPassword")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets Encrypted Pass
        /// </summary>
        [NotMapped]
        public string EncryptedPassword { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is RememberMe
        /// </summary>
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }

        /// <summary>
        /// Gets or sets ReturnUrl
        /// </summary>
        public string ReturnUrl { get; set; }
        
        /// <summary>
        /// Gets or sets userdata
        /// </summary>
        [NotMapped]
        public User Userdata { get; set; }

        /// <summary>
        /// Gets or sets customerdata
        /// </summary>
        [NotMapped]
        public Customer Customerdata { get; set; }
    }
}
