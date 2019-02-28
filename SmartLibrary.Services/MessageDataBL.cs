// <copyright file="MessageDataBL.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Threading.Tasks;
    using System.Web;
    using Infrastructure;
    using SmartLibrary.Models;

    /// <summary>
    /// Messages
    /// </summary>
    /// <CreatedBy>Karan Patel</CreatedBy>
    /// <CreatedDate>01-Oct-2018</CreatedDate>
    public class MessageDataBL
    {
        #region :: Messages ::

        /// <summary>
        ///  list of chat users
        /// </summary>
        /// <param name="message">message</param>
        /// <returns>List of messages</returns>
        public List<Message> GetChatList(Message message)
        {
            using (CustomContext service = new CustomContext())
            {
                return service.SearchByProcedure<Message>("CUSPMessageUsers", message).ToList();
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
            using (ServiceContext service = new ServiceContext())
            {
                return service.MarkMessageAsRead(isSendByAdmin, customerId);
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
        /// Get only one object from id
        /// </summary>
        /// <typeparam name="TEntity">Model Type</typeparam>
        /// <param name="id">id</param>
        /// <returns>IsDelete</returns>
        public TEntity SelectObject<TEntity>(int id)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.SelectObject<TEntity>(id);
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
