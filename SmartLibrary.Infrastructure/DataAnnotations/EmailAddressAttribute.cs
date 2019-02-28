//-----------------------------------------------------------------------
// <copyright file="EmailAddressAttribute.cs" company="Caspian Pacific Tech">
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
    using SmartLibrary.Resources;

    /// <summary>
    /// Email Address Attribute.
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class EmailAddressAttribute : RegularExpressionAttribute, IClientValidatable
    {
        /// <summary>
        /// error message constant
        /// </summary>
        private string eRRORMESSAGE = "E-Mail is InValid!";

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAddressAttribute" /> class.
        /// </summary>
        public EmailAddressAttribute()
            : base(@"^\s*\w+([a-zA-Z0-9!#$%^&*\-+._=])*@(([\w-]+\.)+[\w-]{2,})+\s*$")
        {
            this.ErrorMessage = this.eRRORMESSAGE;
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
            mvr.ErrorMessage = this.eRRORMESSAGE;
            mvr.ValidationType = "email";
            return new[] { mvr };
        }
    }
}