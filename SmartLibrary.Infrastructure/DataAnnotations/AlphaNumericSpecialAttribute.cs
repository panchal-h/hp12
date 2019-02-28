//-----------------------------------------------------------------------
// <copyright file="AlphaNumericSpecialAttribute.cs" company="Caspian Pacific Tech">
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
    public class AlphaNumericSpecialAttribute : RegularExpressionAttribute, IClientValidatable
    {
        /// <summary>
        /// error message constant
        /// </summary>
        public const string ERRORMESSAGE = "Invalid data format in field";

        /// <summary>
        /// Initializes a new instance of the <see cref="AlphaNumericSpecialAttribute" /> class.
        /// </summary>
        public AlphaNumericSpecialAttribute()
            : base(@"(^[A-Za-z0-9:_@.\/#&+-]+(\s*[ A-Za-z0-9:_@.\/#&+-]+)*$)|(^$)")
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
            mvr.ValidationType = "alphanumericspecial";
            return new[] { mvr };
        }
    }
}