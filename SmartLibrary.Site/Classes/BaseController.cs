// <copyright file="BaseController.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Site.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Web;
    using System.Web.Mvc;
    using Classes;
    using Infrastructure.Code;
    using Infrastructure.Filters;
    using SmartLibrary.Infrastructure;
    using SmartLibrary.Models;
    using SmartLibrary.Site.Classes;
    using static Infrastructure.SystemEnumList;

    /// <summary>
    /// Areas Name
    /// <CreatedBy>Dhruvi Shah</CreatedBy>
    /// <CreatedDate>20-Sep-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy>Hardik Panchal</ReviewBy>
    /// <ReviewDate>14-Aug-2018</ReviewDate>
    /// </summary>
    [SmartLibraryValidateAntiforgery]
    public abstract class BaseController : Controller
    {       
        /// <summary>
        /// Gets a value indicating whether gets Disable Async Support
        /// </summary>
        protected override bool DisableAsyncSupport
        {
            get { return true; }
        }

        /// <summary>
        /// override base class method, it will be called before every action initialize.
        /// </summary>
        protected override void ExecuteCore()
        {
            CultureInfo cultureInfo = new CultureInfo(General.GetCultureName(ProjectSession.UserPortalLanguageId), true);
            cultureInfo.DateTimeFormat.FullDateTimePattern = ProjectConfiguration.DateTimeFormat;
            cultureInfo.DateTimeFormat.ShortDatePattern = ProjectConfiguration.DateFormat;
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
            base.ExecuteCore();
        }

        /// <summary>
        ///  override base class method, it will be called for every action method in the class.
        /// </summary>
        /// <param name="filterContext">filter Context</param>
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (ProjectSession.CustomerId <= 0)
            {
                if (filterContext.HttpContext.Request.IsAjaxRequest())
                {
                    filterContext.HttpContext.Response.StatusCode = 403;
                    filterContext.Result = new JsonResult { Data = Resources.Messages.SessionExpiredMessage, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
                }
                else
                {
                    this.AddToastMessage(Resources.General.SessionExpired, Resources.Account.SessionTimeOut, MessageBoxType.Info, true);
                    filterContext.Result = this.RedirectToAction(Actions.ActiveDirectoryLogin, Controllers.ActiveDirectory, new { returnUrl = ProjectConfiguration.CurrentRawUrl });
                }
            }

            base.OnActionExecuting(filterContext);
        }

        /// <summary>
        /// Max JSON Length
        /// </summary>
        /// <param name="data">data value</param>
        /// <param name="contentType">content Type value</param>
        /// <param name="contentEncoding">content Encoding</param>
        /// <param name="behavior">behavior value</param>
        /// <returns>This ActionResult will override the existing JSONResult and will automatically set the</returns>
        protected override JsonResult Json(object data, string contentType, System.Text.Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new JsonResult()
            {
                Data = data,
                ContentType = contentType,
                ContentEncoding = contentEncoding,
                JsonRequestBehavior = behavior,
                MaxJsonLength = int.MaxValue
                //// Use this value to set your maximum size for all of your Requests
            };
        }
    }
}