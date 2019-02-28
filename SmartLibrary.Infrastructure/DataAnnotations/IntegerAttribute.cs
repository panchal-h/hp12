//-----------------------------------------------------------------------
// <copyright file="IntegerAttribute.cs" company="Caspian Pacific Tech">
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
    /// Integer Attribute
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class IntegerAttribute : RegularExpressionAttribute, IClientValidatable
    {
        /// <summary>
        /// error message constant
        /// </summary>
        protected const string ERRORMESSAGE = "Only Whole Numbers Allowed";

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegerAttribute" /> class.
        /// </summary>
        public IntegerAttribute()
            : base(@"^\s*(\+|-)?\d+\s*$")
        {
            this.ErrorMessage = "Only Whole Numbers Allowed";
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
            mvr.ErrorMessage = "Only Whole Numbers Allowed";
            mvr.ValidationType = "integer";
            return new[] { mvr };
        }
    }
}