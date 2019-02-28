// <copyright file="UserDataBL.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Infrastructure;
    using SmartLibrary.Models;

    /// <summary>
    /// This class is used to Define Database object for Save, Search, Delete
    /// </summary>
    /// <CreatedBy>Dhruvi Shah</CreatedBy>
    /// <CreatedDate>4-Sep-2018</CreatedDate>
    public class UserDataBL
    {
        #region :: User ::

        /// <summary>
        /// Save Users
        /// </summary>
        /// <param name="user">user</param>
        /// <returns>Id</returns>
        public int SaveUser(User user)
        {
            using (ServiceContext service = new ServiceContext(false, "Email"))
            {
                return service.Save<User>(user);
            }
        }

        /// <summary>
        /// Get User List
        /// </summary>
        /// <param name="model">model</param>
        /// <returns> return List Of Users to display in grid </returns>
        public List<User> GetUsersList(User model)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.Search<User>(model, model.StartRowIndex, model.EndRowIndex, model.SortExpression, model.SortDirection).ToList();
            }
        }

        /// <summary>
        /// Delete User
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>Delete Users</returns>
        public int DeleteUser(int id)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.Delete<User>(id);
            }
        }

        /// <summary>
        /// Select User 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>get user</returns>
        public User SelectUser(int id)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.SelectObject<User>(id);
            }
        }

        #endregion

        #region :: Role ::

        /// <summary>
        /// Save Role
        /// </summary>
        /// <param name="role">role</param>
        /// <returns>Id</returns>
        public int SaveRole(Role role)
        {
            using (ServiceContext service = new ServiceContext(false, "Name"))
            {
                if (role.Id > 0)
                {
                    role.ModifiedBy = ProjectSession.UserId;
                    role.ModifiedDate = DateTime.Now;
                }
                else
                {
                    role.CreatedBy = ProjectSession.UserId;
                    role.CreatedDate = DateTime.Now;
                }

                return service.Save<Role>(role);
            }
        }

        /// <summary>
        /// Get Role List
        /// </summary>
        /// <param name="model">model</param>
        /// <returns> return List Of Role to display in grid </returns>
        public List<Role> GetRoleList(Role model)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.Search<Role>(model, model.StartRowIndex, model.EndRowIndex, model.SortExpression, model.SortDirection).ToList();
            }
        }

        /// <summary>
        /// Delete Role
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>Delete Roles</returns>
        public int DeleteRole(int id)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.Delete<Role>(id);
            }
        }

        /// <summary>
        /// Select Role 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>get role</returns>
        public Role SelectRole(int id)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.SelectObject<Role>(id);
            }
        }
        #endregion

        #region :: Page Access ::

        /// <summary>
        /// Save Page Access
        /// </summary>
        /// <param name="pageaccess">pageaccess</param>
        /// <returns>Id</returns>
        public int SavePageAccess(PageAccess pageaccess)
        {
            using (ServiceContext service = new ServiceContext(false))
            {
                return service.Save<PageAccess>(pageaccess);
            }
        }
              
        /// <summary>
        /// Delete PageAccess
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>Delete Page Access</returns>
        public int DeletePageAccess(int id)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.Delete<PageAccess>(id);
            }
        }     
        #endregion
    }
}
