//-----------------------------------------------------------------------
// <copyright file="RequiredIfBothValuesAttribute.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure.DataAnnotations
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Linq;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using SmartLibrary.Infrastructure;

    /// <summary>
    /// Required If Both Values Attribute
    /// </summary>
    public class RequiredIfBothValuesAttribute : RequiredAttribute, IClientValidatable
    {
        /// <summary>
        /// Unknown Property Constant
        /// </summary>
        private const string UnknownProperty = "The property {0} could not be found.";

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredIfBothValuesAttribute" /> class.
        /// </summary>
        /// <param name="property1">property1 value</param>
        /// <param name="values1">values1 value</param>
        /// <param name="property2">property2 value</param>
        /// <param name="values2">values2 value</param>
        public RequiredIfBothValuesAttribute(string property1, string[] values1, string property2, string[] values2)
        {
            if (string.IsNullOrWhiteSpace(property1) || string.IsNullOrWhiteSpace(property2))
            {
                ////throw new ArgumentNullException($"{nameof(property1)} and {nameof(property2)} cannot but null or empty.");
                throw new ArgumentNullException(property1 + " and " + property2 + " cannot but null or empty.");
            }

            this.Property1 = property1;
            this.Values1 = values1;
            this.Property2 = property2;
            this.Values2 = values2;
        }

        /// <summary>
        /// Gets Property1 Value
        /// </summary>
        protected string Property1 { get; private set; }

        /// <summary>
        /// Gets Property1 Value
        /// </summary>
        protected string[] Values1 { get; private set; }

        /// <summary>
        /// Gets Property1 Value
        /// </summary>
        protected string Property2 { get; private set; }

        /// <summary>
        /// Gets Values2 Value
        /// </summary>
        protected string[] Values2 { get; private set; }

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

            result.ValidationParameters.Add("property1", this.Property1);
            result.ValidationParameters.Add("values1", Json.Encode(this.Values1));
            result.ValidationParameters.Add("property2", this.Property2);
            result.ValidationParameters.Add("values2", Json.Encode(this.Values2));

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
            var property1Info = validationContext.ObjectType.GetProperty(this.Property1);
            var property2Info = validationContext.ObjectType.GetProperty(this.Property2);

            if (property1Info == null)
            {
                return new ValidationResult(string.Format(CultureInfo.CurrentCulture, UnknownProperty, this.Property1));
            }

            if (property2Info == null)
            {
                return new ValidationResult(string.Format(CultureInfo.CurrentCulture, UnknownProperty, this.Property2));
            }

            var property1Value = ConvertTo.String(property1Info.GetValue(validationContext.ObjectInstance));
            var property2Value = ConvertTo.String(property2Info.GetValue(validationContext.ObjectInstance));

            if (((this.IsValid(property1Value) && this.Values1.Any(item => item == property1Value)) && (this.IsValid(property2Value) && this.Values2.Any(item => item == property2Value)))
                && !this.IsValid(value))
            {
                return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));
            }

            return ValidationResult.Success;
        }
    }
}