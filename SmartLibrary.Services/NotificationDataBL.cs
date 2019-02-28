// <copyright file="NotificationDataBL.cs" company="Caspian Pacific Tech">
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
    /// Notifications
    /// </summary>
    /// <CreatedBy>Karan Patel</CreatedBy>
    /// <CreatedDate>26-Sep-2018</CreatedDate>
    public class NotificationDataBL
    {
        #region :: Notifications ::

        /// <summary>
        /// Save notifications
        /// </summary>
        /// <param name="notifications">notifications</param>
        /// <returns>Id</returns>
        public int SaveNotification(Notification notifications)
        {
            using (ServiceContext service = new ServiceContext(false, false))
            {
                return service.Save<Notification>(notifications);
            }
        }

        /// <summary>
        /// Mark Notification As Read.
        /// </summary>
        /// <param name="ids">Comma separated Ids of notifications.</param>
        /// <returns>return Status</returns>
        public bool MarkNotificationAsRead(string ids)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.MarkNotificationAsRead(ids);
            }
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
        /// <param name="columns">column Name array to check duplicate, Maximum 3 columns</param>
        /// <returns>Id</returns>
        public int Save<TEntity>(TEntity entity, bool combinationCheckRequired = true, bool checkForDuplicate = true, params string[] columns)
        {
            using (ServiceContext service = new ServiceContext(combinationCheckRequired, checkForDuplicate, columns))
            {
                if ((int)entity.GetType().GetProperty("ID").GetValue(entity) > 0)
                {
                    this.SetPropertyValue(entity, "ModifiedBy", ProjectSession.UserId);
                }
                else
                {
                    this.SetPropertyValue(entity, "CreatedBy", ProjectSession.UserId);
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
        /// Set Property Value
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
