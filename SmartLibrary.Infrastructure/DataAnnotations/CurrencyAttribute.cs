//-----------------------------------------------------------------------
// <copyright file="CurrencyAttribute.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure.DataAnnotations
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    /// <summary>
    /// Currency Attribute
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1122:UseStringEmptyForEmptyStrings", Justification = "Reviewed.")]
    [SuppressMessage("StyleCop.CSharp.ReadabilityRules", "SA1121:UseBuiltInTypeAlias", Justification = "Reviewed.")]
    public class CurrencyAttribute : ValidationAttribute, IClientValidatable
    {
        /// <summary>
        /// error message constant
        /// </summary>
        public const string ERRORMESSAGE = "Invalid currency";

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
            mvr.ValidationType = "currency";
            return new[] { mvr };
        }

        /// <summary>
        /// Check Validity of Attribute
        /// </summary>
        /// <param name="value">object value</param>
        /// <param name="validationContext">validation Context</param>
        /// <returns>Return Validation Result</returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && value.ToString() != string.Empty)
            {
                try
                {
                    NumberFormatInfo myNFI = new NumberFormatInfo();
                    myNFI.CurrencySymbol = "$";
                    decimal.Parse(value.ToString().Trim(), NumberStyles.Currency, myNFI); ////yields 15.55
                }
                catch
                {
                    return new ValidationResult(ERRORMESSAGE);
                }
            }

            return ValidationResult.Success;
        }
    }
}