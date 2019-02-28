//-----------------------------------------------------------------------
// <copyright file="AlphaNumericAttribute.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure.DataAnnotations
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    /// <summary>
    /// Proper Name Attribute
    /// </summary>
    public class AlphaNumericAttribute : RegularExpressionAttribute, IClientValidatable
    {
        /// <summary>
        /// error message constant
        /// </summary>
        public const string ERRORMESSAGE = "This field only accepts alpha numeric characters";

        /// <summary>
        /// Initializes a new instance of the <see cref="AlphaNumericAttribute" /> class.
        /// </summary>
        public AlphaNumericAttribute()
            : base(@"^([a-zA-Z0-9][a-zA-Z0-9\s]*)$")
        {
            this.ErrorMessage = ERRORMESSAGE;
        }

        /// <summary>
        /// Get Client Validation Rules
        /// </summary>
        /// <param name="metadata">metadata object</param>
        /// <param name="context">context Object</param>
        /// <returns>Return ModelClientValidationRule List</returns>
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            ModelClientValidationRule mvr = new ModelClientValidationRule();
            mvr.ErrorMessage = ERRORMESSAGE;
            mvr.ValidationType = "alphanumeric";
            return new[] { mvr };
        }
    }
}