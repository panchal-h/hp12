// <copyright file="Global.asax.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Site
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.SessionState;
    using System.Web.UI;
    using Infrastructure;
    using Pages;

    /// <summary>
    /// Global
    /// </summary>  
    public class Global : System.Web.HttpApplication
    {
        /// <summary>
        /// Check is exception being ignored or not.
        /// </summary>
        /// <param name="exception">exception</param>
        /// <returns>returns bool</returns>
        public bool IsExceptionIgnored(Exception exception)
        {
            if (exception == null)
            {
                throw new ArgumentNullException("exception");
            }

            var nestedExceptions = exception.GetExceptionChain();
            return nestedExceptions.Any(ex =>
                ex is ViewStateException ||
                ex.Message.Contains("Timeout") ||
                ex.Message.StartsWith("Invalid viewstate") ||
                ex.Message.Contains("potentially dangerous") ||
                ex.Message.Contains("The remote host closed the connection") ||
                ex.Message.Contains("System.Web.UI.ViewStateException: Invalid viewstate") ||
                ex.Message.Contains("System.Web.Hosting.IIS7WorkerRequest.RaiseCommunicationError") ||
                ex.Message.Contains("0x80070032") ||
                ex.Message.Contains("/images/") ||
                ////(ex is HttpException && ((HttpException)ex).GetHttpCode() == 404) ||
                ex is ThreadAbortException);
        }

        /// <summary>
        /// Application Start Event
        /// </summary>
        /// <param name="sender">sender value</param>
        /// <param name="e">e value</param>
        protected void Application_Start(object sender, EventArgs e)
        {
            ////In Server TLS 1.0 is disabled to to run this application, need to write below line.
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        /// <summary>
        /// Application Start Event
        /// </summary>
        /// <param name="sender">sender value</param>
        /// <param name="e">e value</param>
        protected void Session_Start(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Application Post Authorize Request
        /// </summary>
        protected void Application_PostAuthorizeRequest()
        {
            HttpContext.Current.SetSessionStateBehavior(System.Web.SessionState.SessionStateBehavior.Required);
        }

        /// <summary>
        /// application request state
        /// </summary>
        /// <param name="sender">object sender</param>
        /// <param name="e">event argument e</param>
        protected void Application_AcquireRequestState(object sender, EventArgs e)
        {
            string language = string.Empty;
            if (this.Request.UserLanguages != null && this.Session["UserPortalLanguageId"] == null)
            {
                language = this.Request.UserLanguages[0];
                if (language.ToLower().Contains("ar"))
                {
                    SmartLibrary.Infrastructure.ProjectSession.UserPortalLanguageId = SmartLibrary.Infrastructure.SystemEnumList.Language.Arabic.GetHashCode();
                }
                else
                {
                    SmartLibrary.Infrastructure.ProjectSession.UserPortalLanguageId = SmartLibrary.Infrastructure.SystemEnumList.Language.English.GetHashCode();
                }
            }

            language = SmartLibrary.Site.Classes.General.GetCultureName(SmartLibrary.Infrastructure.ProjectSession.UserPortalLanguageId);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
        }

        /// <summary>
        /// Application Begin Request
        /// </summary>
        /// <param name="sender">sender value</param>
        /// <param name="e">e value</param>
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (this.Request.HttpMethod != "POST")
            {
                ////Convert URL to lowercase
                string lowercaseURL = this.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Authority + HttpContext.Current.Request.Url.AbsolutePath;
                if (Regex.IsMatch(lowercaseURL, @"[A-Z]"))
                {
                    System.Web.HttpContext.Current.Response.RedirectPermanent(lowercaseURL.ToLower() + HttpContext.Current.Request.Url.Query);
                }
            }
        }

        /// <summary>
        ///  Handles the Error event of the Application control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = this.Server.GetLastError();
            this.Response.Clear();

            if (this.IsExceptionIgnored(exception) || exception.Message.ToString().Contains("was not found or does not implement IController."))
            {
                return;
            }

            string controller = SmartLibrary.Site.Pages.Controllers.Error;
            string action = string.Empty;

            if (exception.InnerException?.Message == "The remote server returned an error: (404) Not Found.")
            {
                action = Actions.UnAuthorizePage;
                this.Session.Abandon();
                this.Session.Clear();
            }
            else if (exception.InnerException?.Message == "The remote server returned an error: (401) Unauthorized.")
            {
                action = Actions.UnAuthorizePage;

                this.Session.Abandon();
                this.Session.Clear();
            }
            else
            {
                action = Actions.ErrorPage;
                var httpException = exception as HttpException;
                if (httpException?.GetHttpCode() == 404)
                {
                    action = Actions.PageNotFound;
                }
            }

            bool throwError = System.Configuration.ConfigurationManager.AppSettings["ThrowError"].ToBoolean();

            if ((!throwError || action == Actions.UnAuthorizePage) && !string.IsNullOrEmpty(action))
            {
                var routeData = new RouteData();
                routeData.Values.Add("controller", controller);
                routeData.Values.Add("action", action);
                routeData.Values.Add("exception", exception);
                this.Server.ClearError();
                this.Response.TrySkipIisCustomErrors = true;
                this.Response.Headers.Add("Content-Type", "text/html");
                if (controller != SmartLibrary.Site.Pages.Controllers.Home)
                {
                    IController errorController = new SmartLibrary.Site.Controllers.ErrorController();
                    errorController.Execute(new RequestContext(new HttpContextWrapper(this.Context), routeData));
                }
                else
                {
                    IController loginController = new SmartLibrary.Site.Controllers.ErrorController();
                    loginController.Execute(new RequestContext(new HttpContextWrapper(this.Context), routeData));
                }
            }

            LogWritter.WriteErrorFile(exception, ProjectSession.Email);
        }
    }
}