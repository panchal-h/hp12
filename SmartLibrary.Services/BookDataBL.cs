// <copyright file="BookDataBL.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Services
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Threading.Tasks;
    using System.Web;
    using Infrastructure;
    using SmartLibrary.Models;

    /// <summary>
    /// This class is used to Define Database object for Save, Search, Delete
    /// </summary>
    /// <CreatedBy>Karan Patel</CreatedBy>
    /// <CreatedDate>10-Sep-2018</CreatedDate>
    public class BookDataBL
    {
        #region :: Generic CRUD ::

        /// <summary>
        /// Save Book
        /// </summary>
        /// <param name="book">book</param>
        /// <returns>Id</returns>
        public int SaveBook(Book book)
        {
                book.Description = HttpUtility.HtmlEncode(book.Description);
                return this.Save(book, false, true, 0, "BookName", "ISBNNo");
        }
        #endregion

        #region :: Generic CRUD ::

        /// <summary>
        /// Save the Current Model
        /// </summary>
        /// <typeparam name="TEntity">Model Type</typeparam>
        /// <param name="entity">Model Object</param>
        /// <param name="combinationCheckRequired">Combination Check Required</param>
        /// <param name="checkForDuplicate">checkForDuplicate</param>
        /// <param name="customerId">customerId</param>
        /// <param name="columns">column Name array to check duplicate, Maximum 3 columns</param>
        /// <returns>Id</returns>
        public int Save<TEntity>(TEntity entity, bool combinationCheckRequired = true, bool checkForDuplicate = true, int? customerId = 0, params string[] columns)
        {
            using (ServiceContext service = new ServiceContext(combinationCheckRequired, checkForDuplicate, columns))
            {
                if ((int)entity.GetType().GetProperty("ID").GetValue(entity) > 0)
                {
                    this.SetPropertyValue(entity, "ModifiedBy", ProjectSession.UserId);
                    this.SetPropertyValue(entity, "ModifiedDate", DateTime.Now);
                }
                else
                {
                    if (customerId > 0)
                    {
                        this.SetPropertyValue(entity, "CreatedBy", customerId);
                    }
                    else
                    {
                        this.SetPropertyValue(entity, "CreatedBy", ProjectSession.UserId);
                    }
                  
                    this.SetPropertyValue(entity, "CreatedDate", DateTime.Now);
                }

                return service.Save<TEntity>(entity);
            }
        }

        /// <summary>
        /// Return the list of model for given search criteria
        /// </summary>
        /// <typeparam name="TEntity">Model Type</typeparam>
        /// <param name="model">model</param>
        /// <returns> return List Of BookGenre to display in grid </returns>
        public List<TEntity> Search<TEntity>(TEntity model)
        {
            using (ServiceContext service = new ServiceContext())
            {
                BaseModel baseModel = (BaseModel)((object)model);
                return service.Search<TEntity>(model, baseModel.StartRowIndex, baseModel.EndRowIndex, baseModel.SortExpression, baseModel.SortDirection).ToList();
            }
        }

        /// <summary>
        /// Delete BookGenre
        /// </summary>
        /// <typeparam name="TEntity">Model Type</typeparam>
        /// <param name="id">id</param>
        /// <returns>IsDelete</returns>
        public int Delete<TEntity>(int id)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.Delete<TEntity>(id);
            }
        }

        /// <summary>
        /// Delete BookGenre
        /// </summary>
        /// <typeparam name="TEntity">Model Type</typeparam>
        /// <param name="id">id</param>
        /// <returns>IsDelete</returns>
        public TEntity GetBookDetail<TEntity>(int id)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.SelectObject<TEntity>(id);
            }
        }

        /// <summary>
        /// Save Book Borrow
        /// </summary>
        /// <param name="borrowedbook">borrowedbook</param>
        /// <returns>Id</returns>
        public int SaveBorrowBook(BorrowedBook borrowedbook)
        {       
            return this.Save(borrowedbook, false, false, borrowedbook.CustomerId);
        }

        /// <summary>
        /// Scheduler Run for All Pending Requests
        /// </summary>
        /// <param name="schedulerDate">schedulerDate</param>          
        /// <returns>return Status</returns>
        public int SchedulerRunforAllPendingRequests(DateTime schedulerDate)
        {
            int retVal = 0;
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.SchedulerRunforAllPendingRequests(schedulerDate);
                if (ds?.Tables.Count > 0)
                {
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        retVal = ConvertTo.ToInteger(ds.Tables[0].Rows[0][0]);
                    }
                }

                return retVal;
            }
        }

        /// <summary>
        /// Delete Book comment
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>IsDelete</returns>
        public int DeleteBookComments(int id)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.Delete<BookDiscussion>(id);
            }
        }

        /// <summary>
        /// Delete BookGenre
        /// </summary>
        /// <param name="entity">entity object</param>
        /// <param name="propertyName">Property Name to be set</param>
        /// <param name="value">value to assign</param>
        private void SetPropertyValue(object entity, string propertyName, object value)
        {
            if (entity.GetType().GetProperty(propertyName) != null)
            {
                entity.GetType().GetProperty(propertyName).SetValue(entity, value);
            }
        }

        #endregion
    }
}
