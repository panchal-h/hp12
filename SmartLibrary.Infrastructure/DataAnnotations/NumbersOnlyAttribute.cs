//-----------------------------------------------------------------------
// <copyright file="NumbersOnlyAttribute.cs" company="Caspian Pacific Tech">
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
    /// Numbers Only Attribute
    /// </summary>
    public class NumbersOnlyAttribute : RegularExpressionAttribute, IClientValidatable
    {
        /// <summary>
        /// error message constant
        /// </summary>
        private string eRRORMESSAGE = "Only Numbers are Allowed!";

        /// <summary>
        /// Initializes a new instance of the <see cref="NumbersOnlyAttribute" /> class.
        /// </summary>
        public NumbersOnlyAttribute()
            : base(@"^\s*[0-9]*\s*$")
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
            mvr.ValidationType = "numbersonly";
            return new[] { mvr };
        }
    }
}