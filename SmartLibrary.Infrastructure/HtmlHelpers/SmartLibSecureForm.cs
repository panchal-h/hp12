// <copyright file="SmartLibSecureForm.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Infrastructure.HtmlHelpers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;

    /// <summary>
    /// HtmlHelperExtensions.
    /// </summary>
    public static partial class HtmlHelperExtensions
    {
        /// <summary>
        /// SmartLibSecureForm
        /// </summary>
        /// <param name="helper">HtmlHelper</param>
        /// <returns>MvcForm</returns>
        public static MvcForm SmartLibSecureForm(this HtmlHelper helper)
        {
            var form = helper.BeginForm();

            helper.ViewContext.Writer.Write(helper.AntiForgeryToken().ToHtmlString());

            return form;
        }

        /// <summary>
        /// SmartLibSecureForm.
        /// </summary>
        /// <param name="helper">helper.</param>
        /// <param name="actionName">actionName.</param>
        /// <param name="controllerName">controllerName.</param>
        /// <returns>MvcForm.</returns>
        public static MvcForm SmartLibSecureForm(this HtmlHelper helper, string actionName, string controllerName)
        {
            var form = helper.BeginForm(actionName, controllerName);

            helper.ViewContext.Writer.Write(helper.AntiForgeryToken().ToHtmlString());

            return form;
        }

        /// <summary>
        /// SmartLibSecureForm.
        /// </summary>
        /// <param name="helper">helper.</param>
        /// <param name="actionName">actionName.</param>
        /// <param name="controllerName">controllerName.</param>
        /// <param name="htmlAttributes">htmlAttributes.</param>
        /// <returns>MvcForm.</returns>
        public static MvcForm SmartLibSecureForm(this HtmlHelper helper, string actionName, string controllerName, object htmlAttributes)
        {
            var form = helper.BeginForm(actionName, controllerName, FormMethod.Post, htmlAttributes);

            helper.ViewContext.Writer.Write(helper.AntiForgeryToken().ToHtmlString());

            return form;
        }
    }
}