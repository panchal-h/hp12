//-----------------------------------------------------------------------
// <copyright file="FilterConfig.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary
{
    using System.Web;
    using System.Web.Mvc;
    using Infrastructure.Filters;

    /// <summary>
    /// Used to Filter
    /// </summary>
    /// <CreatedBy>Tirthak Shah</CreatedBy>
    /// <CreatedDate>14-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class FilterConfig
    {
        /// <summary>
        /// use to Register Global Filters
        /// </summary>
        /// <param name="filters">filters value</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new SmartLibraryValidateAntiforgeryAttribute());
        }
    }
}