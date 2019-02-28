//-----------------------------------------------------------------------
// <copyright file="HttpPostedFileExtensionAndSizeAttribute.cs" company="Caspian Pacific Tech">
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
    using SmartLibrary.Infrastructure;

    /// <summary>
    /// Http Posted File Extension And Size Attribute
    /// </summary>
    public class HttpPostedFileExtensionAndSizeAttribute : ValidationAttribute, IClientValidatable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpPostedFileExtensionAndSizeAttribute" /> class.
        /// </summary>
        /// <param name="validExtensions">valid Extensions</param>
        public HttpPostedFileExtensionAndSizeAttribute(SystemEnumList.FileExtension[] validExtensions)
        {
            this.ValidExtensions = validExtensions;
            this.ErrorMessage = "The file type of the attempted upload is invalid.";
        }

        /// <summary>
        /// Gets or sets Valid Extensions value
        /// </summary>
        private SystemEnumList.FileExtension[] ValidExtensions { get; set; }

        /// <summary>
        /// Get Client Validation Rules
        /// </summary>
        /// <param name="metadata">metadata object</param>
        /// <param name="context">context Object</param>
        /// <returns>Return ModelClientValidationRule List</returns>
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var validTypes = string.Join(",", this.ValidExtensions.Select(ext => ext.ToString()).ToArray());
            var result = new ModelClientValidationRule()
            {
                ValidationType = this.GetType().Name.Replace("Attribute", string.Empty).ToLower(),
                ////ErrorMessage = $"File extension for field {metadata.DisplayName ?? metadata.PropertyName} is invalid. Valid file types: {validTypes}"
                ErrorMessage = "File extension for field " + metadata.DisplayName ?? metadata.PropertyName + " is invalid. Valid file types: " + validTypes + " OR the file exceeds the maximum allowed file size."
            };

            result.ValidationParameters.Add("validtypes", validTypes);

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
            if (value != null)
            {
                var uploadFile = value as HttpPostedFileBase;
                var fileName = uploadFile.FileName;
                int fileSize = 0; // in bytes

                byte[] fileContent = null;
                var reader = new System.IO.BinaryReader(uploadFile.InputStream);
                fileContent = reader.ReadBytes(uploadFile.ContentLength); ////Get file data byte array
                fileSize = uploadFile.ContentLength;

                return CommonValidation.ValidateFileType(fileName, fileContent, Constants.MAXIMUM_FILE_UPLOAD_SIZE_BYTES, this.ValidExtensions) ? ValidationResult.Success : new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));
            }

            return ValidationResult.Success;
        }
    }
}