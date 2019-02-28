//-----------------------------------------------------------------------
// <copyright file="Rights.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Admin.Classes
{
    using System.Collections.Generic;
    using System.Linq;
    using Infrastructure;
    using SmartLibrary.Admin.Pages;
    using SmartLibrary.Models;

    /// <summary>
    /// User Rights
    /// </summary>
    /// <CreatedBy>Tirthak Shah</CreatedBy>
    /// <CreatedDate>14-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class Rights
    {
        /// <summary>
        /// Determines whether the specified program type has access.
        /// </summary>
        /// <param name="controller">The controller.</param>
        /// <returns>has access or not</returns>
        public static bool HasMenuAccess(string controller)
        {
            // if super admin then no rights need to check
            if (ProjectSession.SuperAdmin)
            {
                return true;
            }

            bool authorize = false;
            if (ProjectSession.UserId > 0)
            {
                var lstRights = (List<PageAccess>)ProjectSession.UserRoleRights;
                if (lstRights != null)
                {
                    if (controller == Controllers.Master)
                    {
                        if (lstRights.Exists(m => (m.ActionName == Actions.BookGenre && m.IsView.ToBoolean()) || (m.ActionName == Actions.BookLocation && m.IsView.ToBoolean()) || (m.ActionName == Actions.Space && m.IsView.ToBoolean()) || (m.ActionName == Actions.Pages && m.IsView.ToBoolean())))
                        {
                            authorize = true;
                        }
                    }

                    if (controller == Controllers.User)
                    {
                        if (lstRights.Exists(m => (m.ActionName == Actions.Users && m.IsView.ToBoolean()) || (m.ActionName == Actions.Role && m.IsView.ToBoolean())))
                        {
                            authorize = true;
                        }
                    }

                    if (controller == Controllers.Book)
                    {
                        if (lstRights.Exists(m => (m.ActionName == Actions.Book && m.IsView.ToBoolean())))
                        {
                            authorize = true;
                        }
                    }

                    if (controller == Controllers.Member)
                    {
                        if (lstRights.Exists(m => (m.ActionName == Actions.Customer && m.IsView.ToBoolean())))
                        {
                            authorize = true;
                        }
                    }

                    if (controller == Controllers.Message)
                    {
                        if (lstRights.Exists(m => (m.ActionName == Actions.ManageMessages && m.IsView.ToBoolean())))
                        {
                            authorize = true;
                        }
                    }

                    if (controller == Controllers.Report)
                    {
                        if (lstRights.Exists(m => (m.ActionName == Actions.ManageReport && m.IsView.ToBoolean())))
                        {
                            authorize = true;
                        }
                    }
                }
            }

            return authorize;
        }

        /// <summary>
        /// check user rights base on action and controller and action parameters
        /// </summary>
        /// <param name="controllerName">controller name</param>
        /// <param name="actionName">action Name</param>
        /// <param name="permissionName">permission Name</param>
        /// <returns>hass access or not</returns>
        public static bool HasAccess(string controllerName, string actionName = "", string permissionName = Constants.ACTION_VIEW)
        {
            bool authorize = false;

            // if super admin then no rights need to check
            if (ProjectSession.SuperAdmin)
            {
                return true;
            }

            if (ProjectSession.UserId > 0)
            {
                List<PageAccess> lstRights = (List<PageAccess>)ProjectSession.UserRoleRights;
                PageAccess rights = new PageAccess();
                rights = lstRights.Where(x => x.ActionName.ToLower() == actionName.ToLower()).FirstOrDefault();
                if (rights != null)
                {
                    if (Constants.ACTION_VIEW.ToLower() == permissionName.ToLower())
                    {
                        if (rights.IsView != null && rights.IsView != false)
                        {
                            authorize = true;
                        }
                    }
                    else if (Constants.ACTION_ADDUPDATE.ToLower() == permissionName.ToLower())
                    {
                        if (rights.IsAddUpdate != null && rights.IsAddUpdate != false)
                        {
                            authorize = true;
                        }
                    }
                    else if (Constants.ACTION_DELETE.ToLower() == permissionName.ToLower())
                    {
                        if (rights.IsDelete != null && rights.IsDelete != false)
                        {
                            authorize = true;
                        }
                    }
                    else
                    {
                        authorize = false;
                    }
                }

                return authorize;
            }
            else
            {
                return false;
            }
        }
    }
}