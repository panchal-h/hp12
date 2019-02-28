//-----------------------------------------------------------------------
// <copyright file="CustomContext.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Services
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Globalization;
    using System.Linq;
    using Infrastructure;
    using SmartLibrary.DataContext;
    using SmartLibrary.Models;

    /// <summary>
    /// CustomContext
    /// </summary>
    public sealed class CustomContext : ServiceContext
    {
        /// <summary>
        /// Login method
        /// </summary>      
        /// <param name="email">email</param>
        /// <param name="password">password</param>
        /// <returns> return login response</returns>
        public DataSet UserLogin(string email, string password)
        {
            /*Add Parameters*/
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "Email", Value = email, DBType = DbType.String });
            parameters.Add(new DBParameters() { Name = "Password", Value = password, DBType = DbType.String });

            /*Convert Dataset to Model List object*/
            return (DataSet)this.ExecuteProcedure("CUSPUserLogin", ExecuteType.ExecuteDataSet, parameters);
        }

        /// <summary>
        /// Login method for customer
        /// </summary>      
        /// <param name="email">email</param>
        /// <param name="password">password</param>
        /// <returns> return login response</returns>
        public DataSet CustomerLogin(string email, string password)
        {
            /*Add Parameters*/
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "Email", Value = email, DBType = DbType.String });
            parameters.Add(new DBParameters() { Name = "Password", Value = password, DBType = DbType.String });

            /*Convert Dataset to Model List object*/
            return (DataSet)this.ExecuteProcedure("CUSPCustomerLogin", ExecuteType.ExecuteDataSet, parameters);
        }

        /// <summary>
        /// Login method for customer
        /// </summary>      
        /// <param name="email">email</param>
        /// <returns> return login response</returns>
        public DataSet CustomerLoginwithEmail(string email)
        {
            /*Add Parameters*/
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "UserEmail", Value = email, DBType = DbType.String });

            /*Convert Dataset to Model List object*/
            return (DataSet)this.ExecuteProcedure("CUSPCustomerLoginWithEmail", ExecuteType.ExecuteDataSet, parameters);
        }

        /// <summary>
        /// Login method for customer
        /// </summary>      
        /// <param name="email">email</param>
        /// <returns> return login response</returns>
        public DataSet UserLoginwithEmail(string email)
        {
            /*Add Parameters*/
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "UserEmail", Value = email, DBType = DbType.String });

            /*Convert Dataset to Model List object*/
            return (DataSet)this.ExecuteProcedure("CUSPUserLoginWithEmail", ExecuteType.ExecuteDataSet, parameters);
        }

        /// <summary>
        /// GetPageAccessBasedOnUserRole
        /// </summary>
        /// <param name="roleId">roleId</param>
        /// <returns>page access list</returns>
        public DataSet GetPageAccessBasedOnUserRole(int? roleId)
        {
            /*Add Parameters*/
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "RoleId", Value = roleId, DBType = DbType.Int32 });
            /*Convert Dataset to Model List object*/
            return (DataSet)this.ExecuteProcedure("CUSPGetPageAccessBasedOnUserRole", ExecuteType.ExecuteDataSet, parameters);
        }

        /// <summary>
        /// ChangeUserPassword
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="password">password</param>
        /// <param name="spfor">spfor</param>
        /// <returns>bool</returns>
        public bool ChangeUserPassword(int id, string password, string spfor)
        {
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "Id", Value = id, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "NewPassword", Value = password, DBType = DbType.String });
            parameters.Add(new DBParameters() { Name = "SPFor", Value = spfor, DBType = DbType.String });
            this.ExecuteProcedure("CUSPChangePassword", ExecuteType.ExecuteDataSet, parameters);
            return true;
        }

        /// <summary>
        /// DeletePageAccessBasedOnUserRole
        /// </summary>
        /// <param name="roleId">roleId</param>
        /// <returns>page access list</returns>
        public DataSet DeletePageAccessBasedOnUserRole(int? roleId)
        {
            /*Add Parameters*/
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "RoleId", Value = roleId, DBType = DbType.Int32 });
            /*Convert Dataset to Model List object*/
            return (DataSet)this.ExecuteProcedure("CUSPDeletePageAccessBasedOnRole", ExecuteType.ExecuteDataSet, parameters);
        }

        /// <summary>
        /// Check the Reference 
        /// </summary>
        /// <param name="tabletype">table type</param>
        /// <param name="primarykey">primary key</param>
        /// <returns>dataset of reference table with count </returns>
        public DataSet CheckReferenceOfPrimaryKey(int tabletype, int primarykey)
        {
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "TableType", Value = tabletype, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "PrimaryKey", Value = primarykey, DBType = DbType.Int32 });

            return (DataSet)this.ExecuteProcedure("CUSPCheckForForeignKeyConstriant", ExecuteType.ExecuteDataSet, parameters);
        }

        /// <summary>
        /// Masters the drop-down bind.
        /// </summary>
        /// <param name="masterDropDownType">Type of the master drop down.</param>
        /// <param name="isActive">The is active.</param>
        /// <param name="filterId">The filter identifier.</param>
        /// <param name="isAddBlank">need this pram for select2 plug-in</param>
        /// <param name="filterText">the filter text</param>
        /// <param name="filterBool">the filter boolean</param>
        /// <returns>List of items</returns>
        public IList<MasterDropdown> MasterDropdownBind(int masterDropDownType, bool? isActive = null, int? filterId = null, bool isAddBlank = false, string filterText = "", bool? filterBool = null)
        {
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "MasterDropDownType", Value = masterDropDownType, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "Active", Value = isActive, DBType = DbType.Boolean });
            parameters.Add(new DBParameters() { Name = "FilterID", Value = filterId, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "FilterText", Value = filterText, DBType = DbType.String });
            if (filterBool.HasValue)
            {
                parameters.Add(new DBParameters() { Name = "FilterBool", Value = filterBool, DBType = DbType.Boolean });
            }

            var result = this.ExecuteProcedure<MasterDropdown>("CUSPMasterDropdownBind", parameters);
            if (isAddBlank)
            {
                result.Insert(0, new MasterDropdown() { ID = string.Empty, Name = string.Empty });
            }

            return result;
        }

        /// <summary>
        /// Get Book Borrowed Details
        /// </summary>
        /// <param name="bookId">bookId</param>
        /// <param name="statusId">statusId</param>
        /// <param name="active">active</param>
        /// <param name="startRowIndex">startRowIndex</param>
        /// <param name="endRowIndex">endRowIndex</param>
        /// <param name="sortExpression">sortExpression</param>
        /// <param name="sortDirection">sortDirection</param>
        /// <param name="searchText">searchText</param>
        /// <returns>Get Books Borrowed Details</returns>
        public DataSet GetBookBorrowedDetails(int bookId, int? statusId = null, int? active = 1, int? startRowIndex = null, int? endRowIndex = null, string sortExpression = null, string sortDirection = null, string searchText = null)
        {
            /*Add Parameters*/
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "BookId", Value = bookId, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "StatusId", Value = statusId, DBType = DbType.Int32 });

            if (active != null)
            {
                parameters.Add(new DBParameters() { Name = "Active", Value = active, DBType = DbType.Int32 });
            }

            if (startRowIndex != null && endRowIndex != null)
            {
                parameters.Add(new DBParameters() { Name = "StartRowIndex", Value = startRowIndex, DBType = DbType.Int32 });
                parameters.Add(new DBParameters() { Name = "EndRowIndex", Value = endRowIndex, DBType = DbType.Int32 });
            }

            if (!string.IsNullOrEmpty(sortExpression) && !string.IsNullOrEmpty(sortDirection))
            {
                parameters.Add(new DBParameters() { Name = "SortExpression", Value = sortExpression, DBType = DbType.String });
                parameters.Add(new DBParameters() { Name = "SortDirection", Value = sortDirection, DBType = DbType.String });
            }

            if (!string.IsNullOrEmpty(searchText))
            {
                parameters.Add(new DBParameters() { Name = "SearchText", Value = searchText, DBType = DbType.String });
            }

            /*Convert Dataset to Model List object*/
            return (DataSet)this.ExecuteProcedure("CUSPGetBookBorrowedDetails", ExecuteType.ExecuteDataSet, parameters);
        }

        /// <summary>
        /// Get Book Details Complete
        /// </summary>
        /// <param name="bookId">bookId</param>       
        /// <param name="customerId">Customer Id</param>
        /// <returns>Get BooksDetails</returns>
        public DataSet GetBookDetailsComplete(int bookId, int? customerId = null)
        {
            /*Add Parameters*/
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "BookId", Value = bookId, DBType = DbType.Int32 });
            if (customerId != null)
            {
                parameters.Add(new DBParameters() { Name = "CustomerId", Value = customerId, DBType = DbType.Int32 });
            }

            /*Convert Dataset to Model List object*/
            return (DataSet)this.ExecuteProcedure("CUSPLatestBookBorrower", ExecuteType.ExecuteDataSet, parameters);
        }

        /// <summary>
        /// Get Book Details of Customer
        /// </summary>
        /// <param name="customerId">customerId</param>       
        /// <param name="searchText">searchText</param>
        /// <param name="startRowIndex">startRowIndex</param>
        /// <param name="endRowIndex">endRowIndex</param>
        /// <param name="sortExpression">Sort Expression</param>
        /// <param name="sortDirection">Sort Direction</param>
        /// <returns>Get BooksDetails</returns>
        public DataSet GetBookDetailsOfCustomer(int customerId, string searchText, int? startRowIndex, int? endRowIndex, string sortExpression, string sortDirection)
        {
            /*Add Parameters*/
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "CustomerID", Value = customerId, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "SearchText", Value = searchText, DBType = DbType.String });
            if (startRowIndex != null && endRowIndex != null)
            {
                parameters.Add(new DBParameters() { Name = "StartRowIndex", Value = startRowIndex, DBType = DbType.Int32 });
                parameters.Add(new DBParameters() { Name = "EndRowIndex", Value = endRowIndex, DBType = DbType.Int32 });
            }

            if (!string.IsNullOrEmpty(sortExpression) && !string.IsNullOrEmpty(sortDirection))
            {
                parameters.Add(new DBParameters() { Name = "SortExpression", Value = sortExpression, DBType = DbType.String });
                parameters.Add(new DBParameters() { Name = "SortDirection", Value = sortDirection, DBType = DbType.String });
            }

            /*Convert Dataset to Model List object*/
            return (DataSet)this.ExecuteProcedure("CUSPBookHistoryOfCustomer", ExecuteType.ExecuteDataSet, parameters);
        }

        /// <summary>
        /// Get Book Details of Customer
        /// </summary>
        /// <param name="customerId">customerId</param>   
        /// <param name="searchText">searchText</param>
        /// <param name="startRowIndex">startRowIndex</param>
        /// <param name="endRowIndex">endRowIndex</param>
        /// <param name="sortExpression">Sort Expression</param>
        /// <param name="sortDirection">Sort Direction</param>
        /// <returns>Get Space Details</returns>
        public DataSet GetSpaceDetailsOfCustomer(int customerId, string searchText, int? startRowIndex, int? endRowIndex, string sortExpression, string sortDirection)
        {
            /*Add Parameters*/
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "CustomerID", Value = customerId, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "SearchText", Value = searchText, DBType = DbType.String });
            if (startRowIndex != null && endRowIndex != null)
            {
                parameters.Add(new DBParameters() { Name = "StartRowIndex", Value = startRowIndex, DBType = DbType.Int32 });
                parameters.Add(new DBParameters() { Name = "EndRowIndex", Value = endRowIndex, DBType = DbType.Int32 });
            }

            if (!string.IsNullOrEmpty(sortExpression) && !string.IsNullOrEmpty(sortDirection))
            {
                parameters.Add(new DBParameters() { Name = "SortExpression", Value = sortExpression, DBType = DbType.String });
                parameters.Add(new DBParameters() { Name = "SortDirection", Value = sortDirection, DBType = DbType.String });
            }

            /*Convert Dataset to Model List object*/
            return (DataSet)this.ExecuteProcedure("CUSPSpaceHistoryOfCustomer", ExecuteType.ExecuteDataSet, parameters);
        }

        /// <summary>
        /// Get Current book status
        /// </summary>
        /// <param name="bookId">bookId</param>   
        /// <param name="active">active</param>      
        /// <returns>return book status</returns>
        public DataSet GetCurrentBookStatus(int bookId, int? active)
        {
            /*Add Parameters*/
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "BookId", Value = bookId, DBType = DbType.Int32 });
            if (active != null)
            {
                parameters.Add(new DBParameters() { Name = "Active", Value = active, DBType = DbType.Int32 });
            }

            /*Convert Dataset to Model List object*/
            return (DataSet)this.ExecuteProcedure("CUSPGetCurrentBookStatus", ExecuteType.ExecuteDataSet, parameters);
        }

        /// <summary>
        /// Accept Cancel Book Borrow Request
        /// </summary>
        /// <param name="bookId">bookId</param>   
        /// <param name="userId">userId</param>    
        /// <param name="statusId">statusId</param>    
        /// <param name="borrowId">borrowId</param>   
        /// <param name="bookperiod">bookperiod</param>  
        /// <returns>return status</returns>
        public DataSet AcceptCancelBookBorrowRequest(int bookId, int userId, int statusId, int borrowId, int bookperiod)
        {
            /*Add Parameters*/
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "BookId", Value = bookId, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "UserId", Value = userId, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "StatusId", Value = statusId, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "BorrowId", Value = borrowId, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "ActivityDate", Value = DateTime.Now, DBType = DbType.DateTime });
            parameters.Add(new DBParameters() { Name = "BookPeriodValue", Value = bookperiod, DBType = DbType.Int32 });
            /*Convert Dataset to Model List object*/
            return (DataSet)this.ExecuteProcedure("CUSPAcceptCancelBookBorrowRequest", ExecuteType.ExecuteDataSet, parameters);
        }

        /// <summary>
        /// Book Return
        /// </summary>
        /// <param name="bookId">bookId</param>   
        /// <param name="userId">userId</param>             
        /// <param name="borrowId">borrowId</param>   
        /// <param name="returnNotes">returnNotes</param>   
        /// <param name="returnDate">returnDate</param>  
        /// <returns>return status</returns>
        public DataSet BookReturn(int bookId, int userId, int borrowId, string returnNotes, DateTime returnDate)
        {
            /*Add Parameters*/
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "BookId", Value = bookId, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "UserId", Value = userId, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "BorrowId", Value = borrowId, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "returnNotes", Value = returnNotes, DBType = DbType.String });
            parameters.Add(new DBParameters() { Name = "ActivityDate", Value = returnDate, DBType = DbType.DateTime });
            /*Convert Dataset to Model List object*/
            return (DataSet)this.ExecuteProcedure("CUSPBookReturn", ExecuteType.ExecuteDataSet, parameters);
        }

        /// <summary>
        /// Check Book Pending Entry
        /// </summary>
        /// <param name="bookId">bookId</param>   
        /// <param name="customerId">customerId</param>           
        /// <returns>return status</returns>
        public DataSet CheckBookPendingEntry(int bookId, int customerId)
        {
            /*Add Parameters*/
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "BookId", Value = bookId, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "CustomerId", Value = customerId, DBType = DbType.Int32 });
            /*Convert Dataset to Model List object*/
            return (DataSet)this.ExecuteProcedure("CUSPCheckBookPendingEntry", ExecuteType.ExecuteDataSet, parameters);
        }

        /// <summary>
        /// GetCheckBookBorrowStatus
        /// </summary>
        /// <param name="bookId">bookId</param>   
        /// <param name="customerId">customerId</param>           
        /// <returns>return status</returns>
        public DataSet GetCheckBookBorrowStatus(int bookId, int customerId)
        {
            /*Add Parameters*/
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "BookId", Value = bookId, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "CustomerId", Value = customerId, DBType = DbType.Int32 });
            /*Convert Dataset to Model List object*/
            return (DataSet)this.ExecuteProcedure("CUSPCheckBookBorrowStatus", ExecuteType.ExecuteDataSet, parameters);
        }
        
        /// <summary>
        /// Get Book Comments
        /// </summary>
        /// <param name="bookId">bookId</param>   
        /// <param name="searchText">searchText</param>
        /// <param name="startRowIndex">startRowIndex</param>
        /// <param name="endRowIndex">endRowIndex</param>
        /// <param name="sortExpression">Sort Expression</param>
        /// <param name="sortDirection">Sort Direction</param>
        /// <returns>Get Book Discussions</returns>
        public DataSet GetBookDiscussions(int bookId, string searchText, int? startRowIndex, int? endRowIndex, string sortExpression, string sortDirection)
        {
            /*Add Parameters*/
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "BookId", Value = bookId, DBType = DbType.Int32 });
            parameters.Add(new DBParameters() { Name = "SearchText", Value = searchText, DBType = DbType.String });
            if (startRowIndex != null && endRowIndex != null)
            {
                parameters.Add(new DBParameters() { Name = "StartRowIndex", Value = startRowIndex, DBType = DbType.Int32 });
                parameters.Add(new DBParameters() { Name = "EndRowIndex", Value = endRowIndex, DBType = DbType.Int32 });
            }

            if (!string.IsNullOrEmpty(sortExpression) && !string.IsNullOrEmpty(sortDirection))
            {
                parameters.Add(new DBParameters() { Name = "SortExpression", Value = sortExpression, DBType = DbType.String });
                parameters.Add(new DBParameters() { Name = "SortDirection", Value = sortDirection, DBType = DbType.String });
            }

            /*Convert Dataset to Model List object*/
            return (DataSet)this.ExecuteProcedure("CUSPBookDiscussions", ExecuteType.ExecuteDataSet, parameters);
        }

        /// <summary>
        /// Get Todays Activities
        /// </summary>
        /// <param name="requestType">requestType</param>
        /// <param name="fromDate">fromDate</param>
        /// <param name="toDate">toDate</param>
        /// <param name="active">active</param>
        /// <param name="customerId">customerId</param>
        /// <param name="searchText">searchText</param>
        /// <param name="startRowIndex">startRowIndex</param>
        /// <param name="endRowIndex">endRowIndex</param>
        /// <param name="sortExpression">Sort Expression</param>
        /// <param name="sortDirection">Sort Direction</param>
        /// <param name="status">status</param>      
        /// <returns>Return today's activities</returns>
        public DataSet GetTodaysActivities(string requestType, DateTime? fromDate, DateTime? toDate, int active = 1, int? customerId = null, string searchText = null, int? startRowIndex = null, int? endRowIndex = null, string sortExpression = "", string sortDirection = "", string status = "")
        {
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "Type", Value = requestType, DBType = DbType.String });
            parameters.Add(new DBParameters() { Name = "Active", Value = active, DBType = DbType.Int32 });

            if (fromDate != null)
            {
                parameters.Add(new DBParameters() { Name = "FromDate", Value = fromDate, DBType = DbType.DateTime });
            }

            if (toDate != null)
            {
                parameters.Add(new DBParameters() { Name = "ToDate", Value = toDate, DBType = DbType.DateTime });
            }

            if (customerId != null)
            {
                parameters.Add(new DBParameters() { Name = "CustomerId", Value = customerId, DBType = DbType.Int32 });
            }

            if (!string.IsNullOrEmpty(status))
            {
                parameters.Add(new DBParameters() { Name = "status", Value = status, DBType = DbType.String });
            }

            parameters.Add(new DBParameters() { Name = "SearchText", Value = searchText, DBType = DbType.String });
            if (startRowIndex != null && endRowIndex != null)
            {
                parameters.Add(new DBParameters() { Name = "StartRowIndex", Value = startRowIndex, DBType = DbType.Int32 });
                parameters.Add(new DBParameters() { Name = "EndRowIndex", Value = endRowIndex, DBType = DbType.Int32 });
            }

            if (!string.IsNullOrEmpty(sortExpression) && !string.IsNullOrEmpty(sortDirection))
            {
                parameters.Add(new DBParameters() { Name = "SortExpression", Value = sortExpression, DBType = DbType.String });
                parameters.Add(new DBParameters() { Name = "SortDirection", Value = sortDirection, DBType = DbType.String });
            }

            return (DataSet)this.ExecuteProcedure("CUSPGetTodaysActivities", ExecuteType.ExecuteDataSet, parameters);
        }

        /// <summary>
        /// get records from custom procedure
        /// </summary>
        /// <typeparam name="TEntity">Entity Type which require to be return as list</typeparam>
        /// <param name="procedureName">procedureName </param>
        /// <param name="parameter">parameter </param>
        /// <returns>list of data</returns>
        public IList<TEntity> SearchByProcedure<TEntity>(string procedureName, object parameter)
        {
            System.Collections.ObjectModel.Collection<DBParameters> parameters = AddParameters(parameter, true);
            return this.ExecuteProcedure<TEntity>(procedureName, parameters);
        }

        /// <summary>
        /// Check Book Pending Entry
        /// </summary>
        /// <param name="reportfor">reportfor</param>   
        /// <returns>return ReportCount</returns>
        public DataSet GetCountForReport()
        {
            /*Add Parameters*/
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            ////parameters.Add(new DBParameters() { Name = "ReportFor", Value = reportfor, DBType = DbType.Int32 });
            /*Convert Dataset to Model List object*/
            return (DataSet)this.ExecuteProcedure("CUSPReports", ExecuteType.ExecuteDataSet, parameters);
        }

        /// <summary>
        /// Scheduler Run for All Pending Requests
        /// </summary>
        /// <param name="schedulerDate">schedulerDate</param>          
        /// <returns>return Status</returns>
        public DataSet SchedulerRunforAllPendingRequests(DateTime schedulerDate)
        {
            /*Add Parameters*/
            System.Collections.ObjectModel.Collection<DBParameters> parameters = new System.Collections.ObjectModel.Collection<DBParameters>();
            parameters.Add(new DBParameters() { Name = "SchedulerDate", Value = schedulerDate, DBType = DbType.DateTime });            
            /*Convert Dataset to Model List object*/
            return (DataSet)this.ExecuteProcedure("CUSPCancelPendingRequestByScheduler", ExecuteType.ExecuteDataSet, parameters);
        }
    }
}