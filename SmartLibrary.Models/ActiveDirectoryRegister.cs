// <copyright file="ActiveDirectoryRegister.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// User Login with Active Directory Model
    /// </summary>
    /// <CreatedBy>Bhargav Aboti</CreatedBy>
    /// <CreatedDate>26-Dec-2018</CreatedDate>
    public class ActiveDirectoryRegister
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDirectoryRegister"/> class.
        /// </summary>
        public ActiveDirectoryRegister()
        {
        }

        /// <summary>
        /// Gets or sets a value FromWhere
        /// </summary>    
        public int FromWhere { get; set; }

        /// <summary>
        /// Gets or sets a value UserId
        /// </summary>    
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets a value Email
        /// </summary>    
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a value Password
        /// </summary>    
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets a value EncryptedPassword
        /// </summary>    
        public string EncryptedPassword { get; set; }

        /// <summary>
        /// Gets or sets a value FullName
        /// </summary>    
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets a value FirstName
        /// </summary>    
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets a value LastName
        /// </summary>    
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets a value CountryId
        /// </summary>    
        public string CountryId { get; set; }

        /// <summary>
        /// Gets or sets a value StateId
        /// </summary>    
        public string StateId { get; set; }

        /// <summary>
        /// Gets or sets a value LanguageId
        /// </summary>    
        public int LanguageId { get; set; }
                
        /// <summary>
        /// Gets or sets a value SmartLibraryId
        /// </summary>    
        public bool? SmartLibraryId { get; set; }

        /// <summary>
        /// Gets or sets a value ProfileImage
        /// </summary>    
        public string ProfileImage { get; set; }

        /// <summary>
        /// Gets or sets a value Gender
        /// </summary>    
        public int? Gender { get; set; }

        /// <summary>
        /// Gets or sets a value Phone
        /// </summary>    
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the LoginType value.
        /// </summary>
        public int? LoginType { get; set; }

        /// <summary>
        /// Gets or sets the LoginType value.
        /// </summary>
        public string NewPassword { get; set; }

        /// <summary>
        /// Gets or sets the LoginType value.
        /// </summary>
        public string ConfirmPassword { get; set; }

        /// <summary>
        /// Gets or sets the LoginType value.
        /// </summary>
        public string EncryptedNewPassword { get; set; }

        /// <summary>
        /// Gets or sets the LoginType value.
        /// </summary>
        public string EncryptedConfirmPassword { get; set; }
    }
}
