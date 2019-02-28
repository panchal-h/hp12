//-----------------------------------------------------------------------
// <copyright file="HomeController.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using DataTables.Mvc;
    using Infrastructure;
    using Infrastructure.Code;
    using Infrastructure.Filters;
    using Models;
    using Services;
    using SmartLibrary.Admin.Pages;

    /// <summary>Home Controller.</summary>
    /// <CreatedBy>Tirthak Shah.</CreatedBy>
    /// <CreatedDate>14-Aug-2018.</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class HomeController : BaseController
    {
        private CommonBL commonBL;

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// BookController
        /// </summary>
        public HomeController()
        {
            if (this.commonBL == null)
            {
                this.commonBL = new CommonBL();
            }
        }

        #endregion Constructor

        /// <summary>
        /// Home Page.
        /// </summary>
        /// <returns>Home View.</returns>
        [SkipAuthorization]
        public ActionResult Index()
        {
            return this.View();
        }

        /// <summary>
        /// View Page
        /// </summary>
        /// <returns>Return View</returns>
        /// <param name="borrowedBookId">borrowedBookId</param>      
        /// <param name="spaceBookingId">spaceBookingId</param>      
        [ActionName(Actions.AllActivities)]
        [HttpGet]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.AllActivities)]
        public ActionResult AllActivities(string borrowedBookId = null, string spaceBookingId = null)
        {
            this.ViewBag.BorrowedBookId = borrowedBookId == null ? null : EncryptionDecryption.DecryptByTripleDES(borrowedBookId);
            this.ViewBag.SpaceBookingId = spaceBookingId == null ? null : EncryptionDecryption.DecryptByTripleDES(spaceBookingId);
            return this.View();
        }

        /// <summary>
        ///  list of Todays Activities with search criteria
        /// </summary>
        /// <param name="requestModel">the requestModel</param>
        /// <param name="requestType">the requestType</param>
        /// <param name="fromDate">the fromDate</param>
        /// <param name="toDate">the toDate</param>
        /// <param name="searchText">searchText</param>
        /// <param name="customerId">customerId</param>      
        /// <param name="filterId">filterId</param>      
        /// <param name="status">status</param>      
        /// <returns>List of Todays Activity</returns>
        [HttpPost]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.AllActivities)]
        [ActionName(Actions.AllActivitiesList)]
        [NoAntiForgeryCheck]
        public JsonResult AllActivitiesList([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, string requestType, DateTime? fromDate, DateTime? toDate, string searchText = "", int? customerId = null, int? filterId = null, string status = "")
        {
            if ((filterId ?? 0) > 0)
            {
                BookDataBL bookDataBl = new BookDataBL();
                if (requestType == SystemEnumList.RequestTypeTodayActivity.BookDetails.GetDescription())
                {
                    List<BorrowedBook> returnList = bookDataBl.Search<BorrowedBook>(new BorrowedBook() { ID = filterId.Value }) ?? new List<BorrowedBook>();
                    return this.Json(new DataTablesResponse(requestModel.Draw, returnList, returnList.FirstOrDefault().TotalRecords, returnList.FirstOrDefault().TotalRecords), JsonRequestBehavior.AllowGet);
                }
                else
                {
                    List<SpaceBooking> returnList = bookDataBl.Search<SpaceBooking>(new SpaceBooking() { ID = filterId.Value }) ?? new List<SpaceBooking>();
                    return this.Json(new DataTablesResponse(requestModel.Draw, returnList, returnList.FirstOrDefault().TotalRecords, returnList.FirstOrDefault().TotalRecords), JsonRequestBehavior.AllowGet);
                }
            }

            if (requestType == SystemEnumList.RequestTypeTodayActivity.BookDetails.GetDescription())
            {
                List<BorrowedBook> returnList = (List<BorrowedBook>)this.commonBL.GetTodaysActivities(requestType, fromDate, toDate, SystemEnumList.ActiveStatus.Active.GetHashCode(), customerId, searchText, requestModel.Start + 1, requestModel.Start + requestModel.Length, requestModel.Columns.ElementAt(requestModel.OrderColumn).Data, requestModel.OrderDir, status);
                int totalRecord = 0;
                int filteredRecord = 0;
                if (returnList != null && returnList.Count > 0)
                {
                    totalRecord = returnList.FirstOrDefault().TotalRecords;
                    filteredRecord = returnList.FirstOrDefault().TotalRecords;
                }

                return this.Json(new DataTablesResponse(requestModel.Draw, returnList, filteredRecord, totalRecord), JsonRequestBehavior.AllowGet);
            }
            else
            {
                List<SpaceBooking> returnList = (List<SpaceBooking>)this.commonBL.GetTodaysActivities(requestType, fromDate, toDate, SystemEnumList.ActiveStatus.Active.GetHashCode(), customerId, searchText, requestModel.Start + 1, requestModel.Start + requestModel.Length, requestModel.Columns.ElementAt(requestModel.OrderColumn).Data, requestModel.OrderDir, status);
                int totalRecord = 0;
                int filteredRecord = 0;
                if (returnList != null && returnList.Count > 0)
                {
                    totalRecord = returnList.FirstOrDefault().TotalRecords;
                    filteredRecord = returnList.FirstOrDefault().TotalRecords;
                }

                return this.Json(new DataTablesResponse(requestModel.Draw, returnList, filteredRecord, totalRecord), JsonRequestBehavior.AllowGet);
            }
        }
    }
}
