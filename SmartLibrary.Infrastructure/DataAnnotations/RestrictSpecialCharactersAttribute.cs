//-----------------------------------------------------------------------
// <copyright file="RestrictSpecialCharactersAttribute.cs" company="Caspian Pacific Tech">
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
    /// Restrict Special Characters([,],<,>,{,},) Attribute
    /// </summary>
    public class RestrictSpecialCharactersAttribute : RegularExpressionAttribute, IClientValidatable
    {
        /// <summary>
        /// error message constant
        /// </summary>
        private string eRRORMESSAGE = Messages.RestrictIllegalCharacters;

        /// <summary>
        /// Initializes a new instance of the <see cref="RestrictSpecialCharactersAttribute"/> class.
        /// </summary>
        public RestrictSpecialCharactersAttribute()
            : base(@"^([^()<>\{\}\[\]\\\/]*)$")
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
            mvr.ValidationType = "restrictspecialchar";
            return new[] { mvr };
        }
    }
}