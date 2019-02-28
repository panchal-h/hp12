//-----------------------------------------------------------------------
// <copyright file="ErrorController.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Site.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using DataTables.Mvc;
    using SmartLibrary.Site.Pages;

    /// <summary>
    /// Error
    /// </summary>
    public class ErrorController : Controller
    {
        /// <summary>
        /// PageNotFound view
        /// </summary>
        /// <returns>view</returns>
        [ActionName(Actions.PageNotFound)]
        public ActionResult PageNotFound()
        {
            return this.View(Views.PageNotFound);
        }

        /// <summary>
        /// UnAuthorizePage view
        /// </summary>
        /// <returns>view</returns>
        [ActionName(Actions.UnAuthorizePage)]
        public ActionResult UnAuthorizePage()
        {
            return this.View(Views.UnAuthorizePage);
        }

        /// <summary>
        /// UnAuthorizePage view
        /// </summary>
        /// <returns>view</returns>
        [ActionName(Actions.ErrorPage)]
        public ActionResult ErrorPage()
        {
            return this.View(Views.ErrorPage);
        }
    }
}