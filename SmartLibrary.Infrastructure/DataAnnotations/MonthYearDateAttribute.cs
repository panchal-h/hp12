//-----------------------------------------------------------------------
// <copyright file="MonthYearDateAttribute.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure.DataAnnotations
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    /// <summary>
    /// Month Year Date Attribute
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class MonthYearDateAttribute : ValidationAttribute, IClientValidatable
    {
        /// <summary>
        /// error message constant
        /// </summary>
        public const string ERRORMESSAGE = "Date can not be in the future or too old";

        /// <summary>
        /// error invalid date.
        /// </summary>
        public const string ERRORINVALIDDATE = "Invalid date";

        /// <summary>
        /// error validation type
        /// </summary>
        public const string VALIDATIONTYPE = "monthyear";

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
            mvr.ValidationType = VALIDATIONTYPE;
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
            if (value != null && value.ToString() != "mm/yyyy" && value.ToString() != string.Empty)
            {
                try
                {
                    DateTime monthYearDate = Convert.ToDateTime(value.ToString().Trim());
                }
                catch
                {
                    return new ValidationResult(ERRORINVALIDDATE);
                }
            }

            return ValidationResult.Success;
        }
    }
}