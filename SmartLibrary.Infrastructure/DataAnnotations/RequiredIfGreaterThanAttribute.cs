//-----------------------------------------------------------------------
// <copyright file="RequiredIfGreaterThanAttribute.cs" company="Caspian Pacific Tech">
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
    using System.Web.Mvc;

    /// <summary>
    /// Required If Greater Than Attribute
    /// </summary>
    public class RequiredIfGreaterThanAttribute : RequiredAttribute, IClientValidatable
    {
        /// <summary>
        /// Unknown Property Constant
        /// </summary>
        private const string UnknownProperty = "The property {0} could not be found.";

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredIfGreaterThanAttribute" /> class.
        /// </summary>
        /// <param name="otherProperty">other Property</param>
        /// <param name="otherValue">other Value</param>
        public RequiredIfGreaterThanAttribute(string otherProperty, int otherValue)
        {
            if (string.IsNullOrWhiteSpace(otherProperty))
            {
                ////throw new ArgumentNullException($"{nameof(otherProperty)} cannot but null or empty.");
                throw new ArgumentNullException(otherProperty + " cannot but null or empty.");
            }

            this.OtherValue = otherValue;
            this.OtherProperty = otherProperty;
        }

        /// <summary>
        /// Gets Other Value
        /// </summary>
        protected int OtherValue { get; private set; }

        /// <summary>
        /// Gets Other Property Value
        /// </summary>
        protected string OtherProperty { get; private set; }

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

            result.ValidationParameters.Add("otherproperty", this.OtherProperty);
            result.ValidationParameters.Add("othervalue", this.OtherValue);

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
            var otherPropertyInfo = validationContext.ObjectType.GetProperty(this.OtherProperty);

            if (otherPropertyInfo == null)
            {
                return new ValidationResult(string.Format(CultureInfo.CurrentCulture, UnknownProperty, this.OtherProperty));
            }

            var otherPropertyValue = (int)otherPropertyInfo.GetValue(validationContext.ObjectInstance);

            return this.IsValid(otherPropertyValue) && this.OtherValue < otherPropertyValue
                ? this.IsValid(value) ? ValidationResult.Success : new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName))
                : ValidationResult.Success;
        }
    }
}