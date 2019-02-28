//-----------------------------------------------------------------------
// <copyright file="ISBNAttribute.cs" company="Caspian Pacific Tech">
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
    /// Proper Name Attribute
    /// </summary>
    public class ISBNAttribute : RegularExpressionAttribute, IClientValidatable
    {
        /// <summary>
        /// RegEx Pattern
        /// </summary>
        private const string PATTERN = @"^([a-zA-Z\d]{10}|[a-zA-Z\d]{13})$";

        /// <summary>
        /// error message constant
        /// </summary>
        private string eRRORMESSAGE = Messages.InvalidISBNMessage;

        /// <summary>
        /// Initializes static members of the <see cref="ISBNAttribute"/> class.
        /// You need to register an adapter for the new attribute in order to enable client side validation.
        /// Since the RegularExpressionAttribute already has an adapter, which is RegularExpressionAttributeAdapter, all you have to do is reuse it.
        /// Use a static constructor to keep all the necessary code within the same class.
        /// </summary>
        static ISBNAttribute()
        {
            // necessary to enable client side validation
            DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof(ISBNAttribute), typeof(RegularExpressionAttributeAdapter));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ISBNAttribute" /> class.
        /// </summary>
        public ISBNAttribute()
            : base(PATTERN)
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
            mvr.ValidationType = "isbn";
            return new[] { mvr };
        }
    }
}