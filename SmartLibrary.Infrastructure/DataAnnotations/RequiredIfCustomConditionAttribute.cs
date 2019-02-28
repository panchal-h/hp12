//-----------------------------------------------------------------------
// <copyright file="RequiredIfCustomConditionAttribute.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure.DataAnnotations
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using SmartLibrary.Infrastructure;

    /// <summary>
    /// Required If Either Value Attribute
    /// </summary>
    public class RequiredIfCustomConditionAttribute : RequiredAttribute, IClientValidatable
    {
        /// <summary>
        /// Unknown Property Constant
        /// </summary>
        private const string UnknownProperty = "The property {0} could not be found.";

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredIfCustomConditionAttribute" /> class.
        /// </summary>
        /// <param name="customCondition">Custom Condition Value</param>
        public RequiredIfCustomConditionAttribute(string customCondition)
        {
            if (string.IsNullOrWhiteSpace(customCondition))
            {
                throw new ArgumentNullException(customCondition + " cannot but null or empty.");
            }

            this.CustomCondition = customCondition;
        }

        /// <summary>
        /// Gets CustomCondition Value
        /// </summary>
        protected string CustomCondition { get; private set; }

        /// <summary>
        /// Get Client Validation Rules
        /// </summary>
        /// <param name="metadata">metadata object</param>
        /// <param name="context">context Object</param>
        /// <returns>Return ModelClientValidationRule List</returns>
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var result = new ModelClientValidationRule()
            {
                ValidationType = this.GetType().Name.Replace("Attribute", string.Empty).ToLower(),
                ErrorMessage = this.FormatErrorMessage(metadata.DisplayName ?? metadata.PropertyName)
            };

            result.ValidationParameters.Add("customcondition", Json.Encode(this.CustomCondition));

            yield return result;
        }

        /// <summary>
        /// Check Validity of Attribute
        /// </summary>
        /// <param name="value">object value</param>
        /// <param name="validationContext">validation Context</param>
        /// <returns>Return Validation Result</returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                MatchCollection mc = Regex.Matches(this.CustomCondition, @"\[([^]]*)\]");
                string strFinalCondition = this.CustomCondition;
                DataRow[] rows = null;

                foreach (Match m in mc)
                {
                    var propertyInfo = validationContext.ObjectType.GetProperty(m.Value.Replace("[", string.Empty).Replace("]", string.Empty));
                    if (propertyInfo != null)
                    {
                        strFinalCondition = strFinalCondition.Replace(m.Value, "'" + propertyInfo.GetValue(validationContext.ObjectInstance).ToString() + "'");
                    }
                }

                strFinalCondition = strFinalCondition.Replace("&&", "AND").Replace("||", "OR").Replace("==", "=");

                if (this.IsValid(strFinalCondition))
                {
                    var dt = new DataTable();
                    dt.Columns.Add("col");
                    dt.Rows.Add("row");
                    rows = dt.Select(strFinalCondition);
                }

                if (rows != null && rows.Count() > 0 && this.IsValid(value))
                {
                    return ValidationResult.Success;
                }

                return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));
            }
        }
    }
}