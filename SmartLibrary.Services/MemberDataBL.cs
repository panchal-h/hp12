// <copyright file="MemberDataBL.cs" company="Caspian Pacific Tech">
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
    using Models;

    /// <summary>
    /// This class is used to Define Database object for Save, Search, Delete
    /// </summary>
    /// <CreatedBy>Bhoomi Shah</CreatedBy>
    /// <CreatedDate>10-Sep-2018</CreatedDate>
    public class MemberDataBL
    {
        #region ::Customer::

        /// <summary>
        /// Save Customer
        /// </summary>
        /// <param name="customer">Customer</param>
        /// <param name="customerId">customerId</param>
        /// <returns>Id</returns>
        public int SaveCustomer(Customer customer, int customerId = 0)
        {
            using (ServiceContext service = new ServiceContext(false, "Email"))
            {
                if (customer.Id > 0)
                {
                    customer.ModifiedBy = customerId > 0 ? customerId : ProjectSession.CustomerId;
                    customer.ModifiedDate = DateTime.Now;
                }
                else
                {
                    ////customer.CreatedBy = ProjectSession.CustomerId; 
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
        /// Select Customer 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>get customer</returns>
        public Customer SelectCustomer(int id)
        {
            using (ServiceContext service = new ServiceContext())
            {
                return service.SelectObject<Customer>(id);
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
    }
}
