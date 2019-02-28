// <copyright file="BaseController.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Admin.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Web;
    using System.Web.Mvc;
    using Infrastructure.Code;
    using Infrastructure.Filters;
    using SmartLibrary.Admin.Classes;
    using SmartLibrary.Infrastructure;
    using SmartLibrary.Models;
    using static Infrastructure.SystemEnumList;

    /// <summary>
    /// Areas Name
    /// <CreatedBy>Tirthak SHah</CreatedBy>
    /// <CreatedDate>14-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy>Hardik Panchal</ReviewBy>
    /// <ReviewDate>14-Aug-2018</ReviewDate>
    /// </summary>
    [SmartLibraryValidateAntiforgery]
    public abstract class BaseController : Controller
    {
        /// <summary>
        /// The access right
        /// </summary>
        private PageAccessRight pageAccessRight;

        /// <summary>
        /// Gets the access right.
        /// </summary>
        /// <value>
        /// The access right.
        /// </value>
        protected PageAccessRight PageAccessRight
        {
            get { return this.pageAccessRight; }
        }

        /// <summary>
        /// Gets a value indicating whether gets Disable Async Support
        /// </summary>
        protected override bool DisableAsyncSupport
        {
            get { return true; }
        }

        /// <summary>
        /// GetPageAccessRight
        /// </summary>
        /// <param name="controllerName">controllerName</param>
        /// <param name="actionName">actionName</param>    
        public void GetPageAccessRight(string controllerName, string actionName = "")
        {
            this.pageAccessRight = new PageAccessRight();
            this.pageAccessRight.PageName = actionName;
            this.pageAccessRight.Controller = controllerName;
            this.pageAccessRight.Delete = false;
            this.pageAccessRight.AddUpdate = false;
            this.pageAccessRight.View = false;
            List<PageAccess> lstRights = (List<PageAccess>)ProjectSession.UserRoleRights;
            PageAccess rights = lstRights.Where(x => x.ActionName.ToLower() == actionName.ToLower()).FirstOrDefault();
            if (rights != null)
            {
                if (rights?.IsView ?? false)
                {
                    this.pageAccessRight.View = true;
                }

                if (rights?.IsAddUpdate ?? false)
                {
                    this.pageAccessRight.AddUpdate = true;
                }

                if (rights?.IsDelete ?? false)
                {
                    this.pageAccessRight.Delete = true;
                }
            }

            if (ProjectSession.UserId > 0 && ProjectSession.SuperAdmin)
            {
                this.pageAccessRight.AddUpdate = true;
                this.pageAccessRight.View = true;
                this.pageAccessRight.Delete = true;
            }
        }

        /// <summary>
        /// override base class method, it will be called before every action initialize.
        /// </summary>
        protected override void ExecuteCore()
        {
            CultureInfo cultureInfo = new CultureInfo(General.GetCultureName(ProjectSession.AdminPortalLanguageId), true);
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
            string permissionName = string.Empty;
            string actionName = filterContext.ActionDescriptor.ActionName;
            if (filterContext.ActionDescriptor.IsDefined(typeof(PageAccessAttribute), true))
            {
                PageAccessAttribute pageAccessAttibute = (PageAccessAttribute)filterContext.ActionDescriptor.GetCustomAttributes(true).Where(x => x.GetType() == typeof(PageAccessAttribute)).FirstOrDefault();
                permissionName = pageAccessAttibute.PermissionName;
                actionName = pageAccessAttibute.ActionName;
            }

            if (ProjectSession.UserId <= 0)
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
            else if (ProjectSession.UserId > 0)
            {
                if (filterContext.ActionDescriptor.GetCustomAttributes(typeof(SkipAuthorizationAttribute), true).Length > 0 || filterContext.ActionDescriptor.ControllerDescriptor.GetCustomAttributes(typeof(SkipAuthorizationAttribute), true).Length > 0)
                {
                    return;
                }

                // no need to check for manage profile and change password.
                if ((filterContext.ActionDescriptor.ControllerDescriptor.ControllerName == Controllers.User && !(actionName == Actions.ChangePassword || actionName == Actions.MyProfile || actionName == Actions.UserProfile)) || filterContext.ActionDescriptor.ControllerDescriptor.ControllerName != Controllers.User)
                {
                    this.GetPageAccessRight(filterContext.ActionDescriptor.ControllerDescriptor.ControllerName, actionName);
                    if (filterContext.HttpContext.Request.IsAjaxRequest())
                    {
                        if (filterContext.HttpContext.Request.RequestType.ToLower() != "post")
                        {
                            if (!Rights.HasAccess(filterContext.ActionDescriptor.ControllerDescriptor.ControllerName, actionName: actionName, permissionName: permissionName))
                            {
                                filterContext.Result = this.RedirectToAction(Actions.AccessDenied, Controllers.Account);
                            }
                        }
                    }
                    else
                    {
                        if (!Rights.HasAccess(filterContext.ActionDescriptor.ControllerDescriptor.ControllerName, actionName: actionName, permissionName: permissionName))
                        {
                            filterContext.Result = this.RedirectToAction(Actions.AccessDenied, Controllers.Account);
                        }
                    }
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