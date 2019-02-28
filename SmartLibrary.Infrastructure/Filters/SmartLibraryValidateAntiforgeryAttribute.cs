// <copyright file="SmartLibraryValidateAntiforgeryAttribute.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Infrastructure.Filters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using Infrastructure;
    using static EnumHelper;

    /// <summary>
    /// Validate Anti Forgery Tooken
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class SmartLibraryValidateAntiforgeryAttribute : FilterAttribute, IAuthorizationFilter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmartLibraryValidateAntiforgeryAttribute"/> class.
        /// </summary>
        public SmartLibraryValidateAntiforgeryAttribute()
        {
        }

        /// <summary>
        /// On Authorozation Event
        /// </summary>
        /// <param name="filterContext">Filter Context</param>
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            var httpContext = filterContext.HttpContext;

            if (filterContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }

            // only POST requests
            if (!string.Equals(filterContext.HttpContext.Request.HttpMethod, "POST", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            if (filterContext.ActionDescriptor.GetCustomAttributes(typeof(NoAntiForgeryCheckAttribute), true).Length > 0)
            {
                return;
            }

            // don't apply filter to child methods
            if (filterContext.IsChildAction)
            {
                return;
            }

            if (filterContext.HttpContext.Request.IsAjaxRequest())
            {
                var cookie = httpContext.Request.Cookies[AntiForgeryConfig.CookieName];
                AntiForgery.Validate(cookie != null ? cookie.Value : null, httpContext.Request.Headers["__RequestVerificationToken"]);
            }
            else
            {
                new ValidateAntiForgeryTokenAttribute().OnAuthorization(filterContext);
            }
        }
    }
}
