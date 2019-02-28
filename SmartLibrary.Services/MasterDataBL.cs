// <copyright file="MasterDataBL.cs" company="Caspian Pacific Tech">
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
    using Infrastructure;
    using SmartLibrary.Models;

    /// <summary>
    /// This class is used to Define Database object for Save, Search, Delete
    /// </summary>
    /// <CreatedBy>Tirthak Shah</CreatedBy>
    /// <CreatedDate>30-Aug-2018</CreatedDate>
    public class MasterDataBL
    {
        #region :: page ::

        /// <summary>
        /// Save Page
        /// </summary>
        /// <param name="page">Page</param>
        /// <returns>Id</returns>
        public int SavePage(Page page)
        {
            using (ServiceContext service = new ServiceContext(false, "Name"))
            {
                if (page.Id > 0)
                {
                    page.ModifiedBy = ProjectSession.UserId;
                    page.ModifiedDate = DateTime.Now;
                }
                else
                {
                    page.CreatedBy = ProjectSession.UserId;
                    page.CreatedDate = DateTime.Now;
                }

                return service.Save<Page>(page);
            }
        }

        /// <summary>
        /// GetPageList
        /// </summary>
        /// <param name="model">model</param>
        /// <returns> return List Of page to display in grid </returns>
        public List<Page> GetPageList(Page model)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.Search<Page>(model, model.StartRowIndex, model.EndRowIndex, model.SortExpression, model.SortDirection).ToList();
            }
        }

        /// <summary>
        /// DeletepageList
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>Delete page</returns>
        public int DeletePage(int id)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.Delete<Page>(id);
            }
        }
        #endregion

        #region :: Book Location ::

        /// <summary>
        /// Save Location
        /// </summary>
        /// <param name="location">Page</param>
        /// <returns>Id</returns>
        public int SaveBookLocation(BookLocation location)
        {
            using (ServiceContext service = new ServiceContext(false, "Name"))
            {
                if (location.ID > 0)
                {
                    location.ModifiedBy = ProjectSession.UserId;
                    location.ModifiedDate = DateTime.Now;
                }
                else
                {
                    location.CreatedBy = ProjectSession.UserId;
                    location.CreatedDate = DateTime.Now;
                }

                return service.Save<BookLocation>(location);
            }
        }

        /// <summary>
        /// GetLocationList
        /// </summary>
        /// <param name="location">model</param>
        /// <returns> return List Of page to display in grid </returns>
        public List<BookLocation> GetLocationList(BookLocation location)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.Search<BookLocation>(location, location.StartRowIndex, location.EndRowIndex, location.SortExpression, location.SortDirection).ToList();
            }
        }

        /// <summary>
        /// DeleteLocationList
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>Delete Location</returns>
        public int DeleteBookLocation(int id)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.Delete<BookLocation>(id);
            }
        }
        #endregion

        #region :: BookGenre ::

        /// <summary>
        /// Save BookGenre
        /// </summary>
        /// <param name="bookGenre">BookGenre</param>
        /// <returns>Id</returns>
        public int SaveBookGenre(BookGenre bookGenre)
        {
            using (ServiceContext service = new ServiceContext(false, "Name"))
            {
                if (bookGenre.ID > 0)
                {
                    bookGenre.ModifiedBy = ProjectSession.UserId;
                    bookGenre.ModifiedDate = DateTime.Now;
                }
                else
                {
                    bookGenre.CreatedBy = ProjectSession.UserId;
                    bookGenre.CreatedDate = DateTime.Now;
                }

                return service.Save<BookGenre>(bookGenre);
            }
        }

        /// <summary>
        /// GetBookGenreList
        /// </summary>
        /// <param name="model">model</param>
        /// <returns> return List Of BookGenre to display in grid </returns>
        public List<BookGenre> GetBookGenreList(BookGenre model)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.Search<BookGenre>(model, model.StartRowIndex, model.EndRowIndex, model.SortExpression, model.SortDirection).ToList();
            }
        }

        /// <summary>
        /// Delete BookGenre
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>IsDelete</returns>
        public int DeleteBookGenre(int id)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.Delete<BookGenre>(id);
            }
        }
        #endregion

        #region ::Space::

        /// <summary>
        /// Save Space
        /// </summary>
        /// <param name="space">Space</param>
        /// <returns>Id</returns>
        public int SaveSpace(Space space)
        {
            using (ServiceContext service = new ServiceContext(false, "Name"))
            {
                if (space.ID > 0)
                {
                    space.ModifiedBy = ProjectSession.UserId;
                    space.ModifiedDate = DateTime.Now;
                }
                else
                {
                    space.CreatedBy = ProjectSession.UserId;
                    space.CreatedDate = DateTime.Now;
                }

                return service.Save<Space>(space);
            }
        }

        /// <summary>
        /// Get Space
        /// </summary>
        /// <param name="model">model</param>
        /// <returns> return List Of Space to display in grid </returns>
        public List<Space> GetSpaceList(Space model)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.Search<Space>(model, model.StartRowIndex, model.EndRowIndex, model.SortExpression, model.SortDirection).ToList();
            }
        }

        /// <summary>
        /// Delete Spaces
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>IsDelete</returns>
        public int DeleteSpace(int id)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.Delete<Space>(id);
            }
        }
        #endregion

        #region ::Customer::

        /// <summary>
        /// Save Customer
        /// </summary>
        /// <param name="customer">Customer</param>
        /// <returns>Id</returns>
        public int SaveCustomer(Customer customer)
        {
            using (ServiceContext service = new ServiceContext(false, "Name"))
            {
                if (customer.Id > 0)
                {
                    customer.ModifiedBy = ProjectSession.UserId;
                    customer.ModifiedDate = DateTime.Now;
                }
                else
                {
                    customer.CreatedBy = ProjectSession.UserId;
                    customer.CreatedDate = DateTime.Now;
                }

                return service.Save<Customer>(customer);
            }
        }

        /// <summary>
        /// Get Customer
        /// </summary>
        /// <param name="model">model</param>
        /// <returns> return List Of Customer to display </returns>
        public List<Customer> GetCustomerList(Customer model)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.Search<Customer>(model, model.StartRowIndex, model.EndRowIndex, model.SortExpression, model.SortDirection).ToList();
            }
        }

        /// <summary>
        /// Delete Customers
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>IsDelete</returns>
        public int DeleteCustomer(int id)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.Delete<Customer>(id);
            }
        }
        #endregion

        #region :: Space Booking ::

        /// <summary>
        /// Add Space Booking
        /// </summary>
        /// <param name="spaceBooking">spaceBooking</param>
        /// <param name="statusId">Status Id</param>
        /// <returns>Id</returns>
        public int AddSpaceBooking(SpaceBooking spaceBooking, int? statusId)
        {
            using (ServiceContext service = new ServiceContext())
            {
                spaceBooking.StatusId = statusId.ToInteger();
                spaceBooking.CustomerId = ProjectSession.CustomerId > 0 ? ProjectSession.CustomerId : spaceBooking.CustomerId;
                return service.Save<SpaceBooking>(spaceBooking, "CUSPSpaceBookingsSave");
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
                    this.SetPropertyValue(entity, "ModifiedDate", DateTime.Now);
                }
                else
                {
                    this.SetPropertyValue(entity, "CreatedBy", ProjectSession.UserId);
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
            return this.Save(borrowedbook, false, false);
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
