//-----------------------------------------------------------------------
// <copyright file="ServiceContext.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Services
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SmartLibrary.DataContext;
    using SmartLibrary.Models;

    /// <summary>
    /// Service Context
    /// </summary>
    public class ServiceContext : DBContext
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceContext"/> class.
        /// </summary>
        public ServiceContext()
        {
            this.PagingInformation = new Pagination() { PageSize = this.DefaultPageSize, PagerSize = this.DefaultPagerSize };
            this.CheckForDuplicate = false;
            this.DatabaseConnectionName = SmartLibrary.Infrastructure.ProjectSession.DatabaseName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceContext"/> class for checking duplicate value for one column.
        /// </summary>
        /// <param name="columns">column Name array to check duplicate, Maximum 3 columns</param>
        /// <param name="combinationCheckRequired">Combination Check Required</param>
        public ServiceContext(bool combinationCheckRequired = true, params string[] columns)
        {
            this.PagingInformation = new Pagination() { PageSize = this.DefaultPageSize, PagerSize = this.DefaultPagerSize };

            this.CheckForDuplicate = true;
            this.Col1Name = columns.Count() > 0 ? columns[0] : string.Empty;
            this.Col2Name = columns.Count() > 1 ? columns[1] : string.Empty;
            this.Col3Name = columns.Count() > 2 ? columns[2] : string.Empty;
            this.CombinationCheckRequired = combinationCheckRequired;

            this.DatabaseConnectionName = SmartLibrary.Infrastructure.ProjectSession.DatabaseName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceContext"/> class for checking duplicate value for one column.
        /// </summary>
        /// <param name="columns">column Name array to check duplicate, Maximum 3 columns</param>
        /// <param name="checkForDuplicate">checkForDuplicate</param>
        /// <param name="combinationCheckRequired">Combination Check Required</param>
        public ServiceContext(bool combinationCheckRequired = true, bool checkForDuplicate = true, params string[] columns)
        {
            this.PagingInformation = new Pagination() { PageSize = this.DefaultPageSize, PagerSize = this.DefaultPagerSize };
            this.CheckForDuplicate = checkForDuplicate;
            this.Col1Name = columns.Count() > 0 ? columns[0] : string.Empty;
            this.Col2Name = columns.Count() > 1 ? columns[1] : string.Empty;
            this.Col3Name = columns.Count() > 2 ? columns[2] : string.Empty;
            this.CombinationCheckRequired = combinationCheckRequired;
            this.DatabaseConnectionName = SmartLibrary.Infrastructure.ProjectSession.DatabaseName;
        }
        #endregion

        #region role

        /// <summary>
        /// SearchRole
        /// </summary>
        /// <param name="model">model</param>
        /// <param name="pageSize">pageSize</param>
        /// <param name="currentIndex">currentIndex</param>
        /// <param name="sortExpression">sortExpression</param>
        /// <param name="sortDirection">sortDirection</param>
        /// <returns>List of Roles</returns>
        public IList<Role> SearchRole(Role model, int? pageSize, int? currentIndex, string sortExpression, string sortDirection)
        {
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();

            parameters.Add(new DBParameters() { Name = "Id", Value = model.Id, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "Name", Value = model.Name != null ? model.Name.Trim() : null, DBType = DbType.String });
            parameters.Add(new DBParameters() { Name = "Active", Value = model.Active, DBType = DbType.Boolean });
            parameters.Add(new DBParameters() { Name = "StartRowIndex", Value = currentIndex + 1, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "EndRowIndex", Value = currentIndex + pageSize, DBType = DbType.Int32 });

            if (!string.IsNullOrEmpty(sortExpression) && !string.IsNullOrEmpty(sortDirection))
            {
                parameters.Add(new DBParameters() { Name = "SortExpression", Value = sortExpression, DBType = DbType.String });
                parameters.Add(new DBParameters() { Name = "SortDirection", Value = sortDirection, DBType = DbType.String });
            }

            return this.ExecuteProcedure<Role>("USPRoleSearch", parameters);
        }

        /// <summary>
        /// Deletes the role.
        /// </summary>
        /// <param name="id">The page identifier.</param>
        /// <returns>return Status</returns>
        public bool DeleteRole(int? id)
        {
            try
            {
                System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
                parameters.Add(new DBParameters() { Name = "Id", Value = id, DBType = DbType.Int64 });

                this.ExecuteProcedure("USPRoleDelete", ExecuteType.ExecuteNonQuery, parameters);
                return true;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return false;
            }
        }

        /// <summary>
        /// get page access based on role
        /// </summary>
        /// <param name="roleId">roleId </param>
        /// <returns>list of page access</returns>
        public IList<PageAccess> GetPageAccessBasedOnRole(int roleId)
        {
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "RoleId", Value = roleId, DBType = DbType.Int32 });
            return this.ExecuteProcedure<PageAccess>("CUSPGetPageAccessesBasedOnRole", parameters);
        }

        /// <summary>
        /// Mark Notification As Read.
        /// </summary>
        /// <param name="ids">Comma separated Ids of notifications.</param>
        /// <returns>return Status</returns>
        public bool MarkNotificationAsRead(string ids)
        {
            try
            {
                System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
                parameters.Add(new DBParameters() { Name = "ID", Value = ids, DBType = DbType.String });
                this.ExecuteProcedure("CUSPMarkNotificationAsRead", ExecuteType.ExecuteNonQuery, parameters);
                return true;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return false;
            }
        }

        /// <summary>
        /// Mark Message As Read.
        /// </summary>
        /// <param name="isSendByAdmin">isSendByAdmin.</param>
        /// <param name="customerId">customerId.</param>
        /// <returns>return Status</returns>
        public bool MarkMessageAsRead(bool isSendByAdmin, int customerId = 0)
        {
            try
            {
                System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
                parameters.Add(new DBParameters() { Name = "CustomerId", Value = customerId, DBType = DbType.Int32 });
                parameters.Add(new DBParameters() { Name = "IsSendByAdmin", Value = isSendByAdmin, DBType = DbType.Boolean });
                this.ExecuteProcedure("CUSPMarkMessageAsRead", ExecuteType.ExecuteNonQuery, parameters);
                return true;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return false;
            }
        }

        #endregion
    }
}
