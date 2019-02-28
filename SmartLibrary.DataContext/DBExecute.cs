////-----------------------------------------------------------------------
// <copyright file="DBExecute.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
    using SmartLibrary;

    /// <summary>
    /// This class is used to define Execute Database query
    /// </summary>
    /// <CreatedBy>Hardik Panchal</CreatedBy>
    /// <CreatedDate>14-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public abstract class DBExecute
    {
        /// <summary>
        /// SQL server name
        /// </summary>    
        public const string MasterDatabaseName = "SmartLibraryEntities";

        /// <summary>
        /// Gets or sets Database Connection Name
        /// </summary>
        public string DatabaseConnectionName { get; set; }

        /// <summary>
        /// Gets Database Connection
        /// </summary>
        public string DatabaseConnection
        {
            get
            {
                return this.GetConnectionString();
            }
        }

        /// <summary>
        /// Gets Default Page Size
        /// </summary>
        public int DefaultPageSize
        {
            get
            {
                return 10;
            }
        }

        /// <summary>
        /// Gets Default Page Size
        /// </summary>
        public int DefaultPagerSize
        {
            get
            {
                return 5;
            }
        }

        /// <summary>
        /// Gets or sets Pagination Information
        /// </summary>
        public virtual Pagination PagingInformation { get; set; }

        /// <summary>
        /// Execute Procedure for custom methods
        /// </summary>
        /// <param name="procedureName">procedure name</param>
        /// <param name="executeType">execute type</param>
        /// <param name="parameters">parameter list</param>
        /// <returns>return procedure output</returns>
        public virtual object ExecuteProcedure(string procedureName, ExecuteType executeType, System.Collections.ObjectModel.Collection<DBParameters> parameters)
        {
            return DBClient.ExecuteProcedure(procedureName, executeType, parameters, this.DatabaseConnection);
        }

        /// <summary>
        /// Execute Procedure for custom methods
        /// </summary>
        /// <typeparam name="TEntity">Entity Type which require to be return as list</typeparam>
        /// <param name="procedureName">procedure name</param>
        /// <param name="parameters">parameter list</param>
        /// <returns>return procedure output</returns>
        public virtual IList<TEntity> ExecuteProcedure<TEntity>(string procedureName, System.Collections.ObjectModel.Collection<DBParameters> parameters)
        {
            var list = DBClient.ExecuteProcedure<TEntity>(procedureName, parameters, this.DatabaseConnection);
            if (list != null && list.Count() > 0)
            {
                this.SetPaginationInformation(Convert.ToInt32(GetPropertyValue(list[0], "TotalRecords"), CultureInfo.InvariantCulture));
            }

            return list;
        }

        /// <summary>
        /// Get Property Value of given Property Name
        /// </summary>
        /// <typeparam name="TEntity">Entity Type</typeparam>
        /// <param name="entity">Model to Extract</param>
        /// <param name="propertyName">property name</param>
        /// <returns>Table Name</returns>
        protected static string GetPropertyValue<TEntity>(TEntity entity, string propertyName)
        {
            try
            {
                PropertyInfo info = entity.GetType().GetProperties().FirstOrDefault(prop => prop.Name.ToLower(System.Globalization.CultureInfo.CurrentCulture) == propertyName.ToLower(System.Globalization.CultureInfo.CurrentCulture));

                if (info != null)
                {
                    if (info.PropertyType == typeof(string))
                    {
                        return Convert.ToString(info.GetValue(entity, null), CultureInfo.InvariantCulture).Trim();
                    }

                    return Convert.ToString(info.GetValue(entity, null), CultureInfo.InvariantCulture);
                }

                return string.Empty;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Gets or sets Start Row Index for Current Page
        /// </summary>
        /// <param name="pageNo">page no</param>
        /// <returns>return start row index</returns>
        protected int StartRowIndex(int? pageNo)
        {
            if (pageNo.HasValue && pageNo > 0)
            {
                this.PagingInformation.PageNo = pageNo.Value;
                return ((pageNo.Value - 1) * this.PagingInformation.PageSize) + 1;
            }

            return 0;
        }

        /// <summary>
        /// End Row Index for Current Page
        /// </summary>
        /// <param name="pageNo">page no</param>
        /// <returns>returns end row index</returns>
        protected int EndRowIndex(int? pageNo)
        {
            if (pageNo.HasValue && pageNo > 0)
            {
                return ((pageNo.Value - 1) * this.PagingInformation.PageSize) + this.PagingInformation.PageSize;
            }

            return 0;
        }

        /// <summary>
        /// Set Pagination Information
        /// </summary>
        /// <param name="totalRecords">total records</param>
        private void SetPaginationInformation(int totalRecords)
        {
            this.PagingInformation.TotalRecords = totalRecords;
            this.PagingInformation.TotalPages = (this.PagingInformation.TotalRecords / this.PagingInformation.PageSize) + ((this.PagingInformation.TotalRecords % this.PagingInformation.PageSize > 0) ? 1 : 0);
            this.PagingInformation.HasPreviousPage = this.PagingInformation.PageNo > this.PagingInformation.PagerSize;
            int currentPagerNo = this.PagingInformation.PageNo / (this.PagingInformation.PagerSize + (this.PagingInformation.PageNo % this.PagingInformation.PagerSize > 0 ? 1 : 0));
            int currentPagerRecords = currentPagerNo * this.PagingInformation.PagerSize;
            this.PagingInformation.HasNextPage = this.PagingInformation.TotalPages > this.PagingInformation.PagerSize ? ((this.PagingInformation.TotalPages % this.PagingInformation.PagerSize) == 0 ? (currentPagerRecords < this.PagingInformation.TotalPages - (this.PagingInformation.TotalPages % this.PagingInformation.PagerSize)) : (currentPagerRecords <= this.PagingInformation.TotalPages - (this.PagingInformation.TotalPages % this.PagingInformation.PagerSize))) : false;
        }

        /// <summary>
        /// Get Connection String
        /// </summary>
        /// <returns>Return Connection String Value</returns>
        private string GetConnectionString()
        {
            if (this.DatabaseConnectionName == MasterDatabaseName)
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings[this.DatabaseConnectionName].ConnectionString;
            }
            else
            {               
                return string.Empty;
            }
        }
    }
}
