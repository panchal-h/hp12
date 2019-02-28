//-----------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary
{
    using System.Web.Mvc;
    using System.Web.Routing;

    /// <summary>
    /// Used to Route
    /// </summary>
    /// <CreatedBy>Tirthak Shah</CreatedBy>
    /// <CreatedDate>14-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class RouteConfig
    {
        /// <summary>
        /// use to Register routes
        /// </summary>
        /// <param name="routes">routes value</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.aspx/{*pathInfo}");
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "ActiveDirectory", action = "ActiveDirectoryLogin", id = UrlParameter.Optional });
        }
    }
}