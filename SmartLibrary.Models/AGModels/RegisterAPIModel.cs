// <copyright file="RegisterAPIModel.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

/// <summary>
/// Register Model
/// </summary>
namespace SmartLibrary.Models.AGModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Register API Model
    /// </summary>
    public class RegisterAPIModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterAPIModel"/> class.
        /// </summary>
        public RegisterAPIModel()
        {
            this.RegisterSmartLibrary = new SmartLibraryAPIData();
        }

        /// <summary>
        /// Gets or sets the FromWhere value.
        /// </summary>
        public int FromWhere { get; set; }

        /// <summary>
        /// Gets or sets the UserId value.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the Email value.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the Password value.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets the FullName value.
        /// </summary>
        public string FullName
        {
            get { return (this.FirstName ?? string.Empty) + " " + (this.LastName ?? string.Empty); }
        }

        /// <summary>
        /// Gets or sets the FirstName value.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the LastName value.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the CountryId value.
        /// </summary>
        public string CountryId { get; set; }

        /// <summary>
        /// Gets or sets the StateId value.
        /// </summary>
        public string StateId { get; set; }

        /// <summary>
        /// Gets or sets the LanguageId value.
        /// </summary>
        public int LanguageId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsADUser value.
        /// </summary>
        public bool IsADUser { get; set; }

        /// <summary>
        /// Gets or sets the CurrentPassword value.
        /// </summary>
        public string CurrentPassword { get; set; }

        /// <summary>
        /// Gets or sets the NewPassword value.
        /// </summary>
        public string NewPassword { get; set; }

        /// <summary>
        /// Gets or sets the ConfirmPassword value.
        /// </summary>
        public string ConfirmPassword { get; set; }

        /// <summary>
        /// Gets or sets the RegisterSmartLibrary value.
        /// </summary>
        public SmartLibraryAPIData RegisterSmartLibrary { get; set; }
    }
}
