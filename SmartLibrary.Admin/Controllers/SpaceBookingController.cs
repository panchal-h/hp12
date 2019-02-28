// <copyright file="SpaceBookingController.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Admin.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using DataTables.Mvc;
    using Infrastructure;
    using Infrastructure.Filters;
    using Models;
    using Pages;
    using Services;
    using SmartLibrary.Models;

    /// <summary>
    /// SpaceBooking Controller
    /// </summary>
    public class SpaceBookingController : BaseController
    {
        private MasterDataBL masterDataBL;

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceBookingController"/> class.
        /// MasterController
        /// </summary>
        public SpaceBookingController()
        {
            if (this.masterDataBL == null)
            {
                this.masterDataBL = new MasterDataBL();
            }
        }

        #endregion Constructor

        /// <summary>
        /// Space Booking List
        /// </summary>
        /// <returns>List of SpaceBookings</returns>
        [ActionName(Actions.LibraryRoomBookings)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.LibraryRoomBookings)]
        public ActionResult LibraryRoomBookings()
        {
            return this.View(Views.ManageSpaceBooking);
        }

        /// <summary>
        ///  list of Space with search criteria
        /// </summary>
        /// <param name="requestModel">the requestModel</param>
        /// <param name="searchdata">searchdata</param>
        /// <param name="statusId">StatusId</param>
        /// <returns>List of Spaces</returns>
        [HttpPost]
        [ActionName(Actions.LibraryRoomBookings)]
        [NoAntiForgeryCheck]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.LibraryRoomBookings)]
        public JsonResult SpaceBookings([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, string searchdata = "", int? statusId = null)
        {
            List<SpaceBooking> spaceBookingList;

            SpaceBooking model = new SpaceBooking()
            {
                StatusId = statusId,
                SpaceName = searchdata,
                StartRowIndex = requestModel.Start + 1,
                EndRowIndex = requestModel.Start + requestModel.Length,
                SortDirection = requestModel.OrderDir,
                SortExpression = requestModel.Columns.ElementAt(requestModel.OrderColumn).Data
            };

            spaceBookingList = this.masterDataBL.Search(model);
            int totalRecord = 0;
            int filteredRecord = 0;
            if (spaceBookingList != null && spaceBookingList.Count > 0)
            {
                totalRecord = spaceBookingList.FirstOrDefault().TotalRecords;
                filteredRecord = spaceBookingList.FirstOrDefault().TotalRecords;
            }

            return this.Json(new DataTablesResponse(requestModel.Draw, spaceBookingList, filteredRecord, totalRecord), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// BookSpace booking requests.
        /// </summary>
        /// <param name="spaceBooking">The SpaceBooking.</param>
        /// <returns>Return Space booking requests</returns>
        [HttpPost]
        [ActionName(Actions.SpaceBookingRequests)]
        public ActionResult SpaceBookingRequests(SpaceBooking spaceBooking)
        {
            List<SpaceBookingRequest> spaceBookings = new List<SpaceBookingRequest>();
            if (!string.IsNullOrEmpty(spaceBooking.BookingDate) && spaceBooking.SpaceId.HasValue)
            {
                SpaceBookingRequest model = new SpaceBookingRequest();
                model.FromDate = DateTime.ParseExact(spaceBooking.BookingDate, ProjectConfiguration.DateFormat, System.Globalization.CultureInfo.InvariantCulture).Date;
                model.ToDate = model.FromDate.Value.Date.AddDays(1);
                model.SpaceId = spaceBooking.SpaceId;
                spaceBookings = this.masterDataBL.Search(model);
            }

            return this.PartialView(PartialViews.SpaceBookingRequests, spaceBookings);
        }

        /// <summary>
        /// BookSpace booking request timings.
        /// </summary>
        /// <param name="spaceBooking">The SpaceBooking.</param>
        /// <returns>Return Space booking request timings</returns>
        [HttpPost]
        [ActionName(Actions.GetSpaceBookingRequestTimings)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.LibraryRoomBookings)]
        public JsonResult GetSpaceBookingRequestTimings(SpaceBooking spaceBooking)
        {
            List<SpaceBookingRequest> spaceBookings = new List<SpaceBookingRequest>();
            if (!string.IsNullOrEmpty(spaceBooking.BookingDate) && spaceBooking.SpaceId.HasValue)
            {
                SpaceBookingRequest model = new SpaceBookingRequest();
                model.FromDate = DateTime.ParseExact(spaceBooking.BookingDate, ProjectConfiguration.DateFormat, System.Globalization.CultureInfo.InvariantCulture).Date;
                model.ToDate = model.FromDate.Value.Date.AddDays(1);
                model.SpaceId = spaceBooking.SpaceId;
                spaceBookings = this.masterDataBL.Search(model);
            }

            var spaceBookingRequestTimings = spaceBookings
                                            .Where(s => s.FromDate != null && s.ToDate != null)
                                            .Select(s => new { From = s.FromDate.Value.ToString("HH:mm"), To = s.ToDate.Value.ToString("HH:mm") })
                                            .ToList();
            return this.Json(spaceBookingRequestTimings, JsonRequestBehavior.DenyGet);
        }
    }
}