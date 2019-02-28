//-----------------------------------------------------------------------
// <copyright file="ProjectSession.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Web;    

    /// <summary>
    /// Project sessions.
    /// </summary>
    /// <CreatedBy> Hardik Panchal. </CreatedBy>
    /// <CreatedDate>14-Aug-2018.</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class ProjectSession
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSession"/> class.
        /// </summary>
        private ProjectSession()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets Properties to store current Database Name.
        /// </summary>
        public static string DatabaseName => "SmartLibraryEntities";

        /// <summary>
        /// Gets or sets Properties to store project session for Page Size.
        /// </summary>
        public static int PageSize
        {
            get
            {
                if (ConvertTo.ToInteger(HttpContext.Current.Session["PageSize"]) == 0)
                {
                    HttpContext.Current.Session["PageSize"] = ProjectConfiguration.PageSize;
                }

                return ConvertTo.ToInteger(HttpContext.Current.Session["PageSize"]);
            }

            set
            {
                HttpContext.Current.Session["PageSize"] = value;
            }
        }

        /// <summary>
        /// Gets or sets Properties to store project session for Login type.
        /// </summary>
        public static int LoginType
        {
            get
            {
                return ConvertTo.ToInteger(HttpContext.Current.Session["LoginType"]);
            }

            set
            {
                HttpContext.Current.Session["LoginType"] = value;
            }
        }

        /// <summary>
        /// Gets or sets Properties to store project session for UserId.
        /// </summary>
        public static int UserId
        {
            get
            {
                return ConvertTo.ToInteger(HttpContext.Current.Session["UserId"]);
            }

            set
            {
                HttpContext.Current.Session["UserId"] = value;
            }
        }

        /// <summary>
        /// Gets or sets Properties to store project session for Email.
        /// </summary>
        public static string Email
        {
            get
            {
               return ConvertTo.String(HttpContext.Current.Session["Email"]);
            }

            set
            {
                HttpContext.Current.Session["Email"] = value;
            }
        }

        /// <summary>
        /// Gets or sets UserRole.
        /// </summary>
        /// <value>
        /// UserRole.
        /// </value>
        public static int? UserRole
        {
            get
            {
                return ConvertTo.ToInteger(HttpContext.Current.Session["UserRole"]);
            }

            set
            {
                HttpContext.Current.Session["UserRole"] = value;
            }
        }

        /// <summary>
        /// Gets or sets User Role Rights.
        /// </summary>
        public static object UserRoleRights
        {
            get
            {
                return HttpContext.Current.Session["UserRoleRights"];
            }

            set
            {
                HttpContext.Current.Session["UserRoleRights"] = value;
            }
        }
    
        /// <summary>
        /// Gets or sets Properties to store project session for LanguageId.
        /// </summary>
        public static int UserPortalLanguageId
        {
            get
            {
                // return 1;
                return string.IsNullOrEmpty(Convert.ToString(HttpContext.Current.Session["UserPortalLanguageId"])) ? SystemEnumList.Language.English.GetHashCode() : (int)HttpContext.Current.Session["UserPortalLanguageId"];
            }

            set
            {
                HttpContext.Current.Session["UserPortalLanguageId"] = value;
            }
        }

        /// <summary>
        /// Gets or sets Properties to store project session for Site AdminPortalLanguageId.
        /// </summary>
        public static int AdminPortalLanguageId
        {
            get
            {
                return string.IsNullOrEmpty(Convert.ToString(HttpContext.Current.Session["AdminPortalLanguageId"])) ? SystemEnumList.Language.English.GetHashCode() : (int)HttpContext.Current.Session["AdminPortalLanguageId"];
            }

            set
            {
                HttpContext.Current.Session["AdminPortalLanguageId"] = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets Properties to store project session for SuperAdmin.
        /// </summary>
        public static bool SuperAdmin
        {
            get
            {
                return string.IsNullOrEmpty(Convert.ToString(HttpContext.Current.Session["SuperAdmin"])) ? false : (bool)HttpContext.Current.Session["SuperAdmin"];
            }

            set
            {
                HttpContext.Current.Session["SuperAdmin"] = value;
            }
        }

        /// <summary>
        /// Gets or sets Properties to store project session for CustomerId.
        /// </summary>
        public static int CustomerId
        {
            get
            {
                return ConvertTo.ToInteger(HttpContext.Current.Session["CustomerId"]);
            }

            set
            {
                HttpContext.Current.Session["CustomerId"] = value;
            }
        }

        /// <summary>
        /// Gets or sets Properties to store project session for CustomerLanguageId.
        /// </summary>
        public static short? CustomerLanguageId
        {
            get
            {
                return ConvertTo.ToShort(HttpContext.Current.Session["CustomerLanguageId"]);
            }

            set
            {
                HttpContext.Current.Session["CustomerLanguageId"] = value;
            }
        }

        /// <summary>
        /// Gets or sets Properties to store project session for ProfileImagePath.
        /// </summary>
        public static string CustomerProfileImagePath
        {
            get
            {
                return ConvertTo.ToStringTrim(HttpContext.Current.Session["ProfileImagePath"]);
            }

            set
            {
                HttpContext.Current.Session["ProfileImagePath"] = value;
            }
        }

        #endregion
    }
}
