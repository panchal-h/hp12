// <copyright file="SpaceBookingController.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Site.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Mvc;
    using DataTables.Mvc;
    using EmailServices;
    using Infrastructure;
    using Infrastructure.Filters;
    using Models;
    using Pages;
    using Resources;
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

        #region ::Space Booking::

        /// <summary>
        ///  Space Booking List
        /// </summary>
        /// <returns>List of SpaceBookings</returns>
        public ActionResult Index()
        {
            return this.View(Views.ManageSpaceBooking);
        }

        /// <summary>
        /// Space Booking List
        /// </summary>
        /// <returns>List of SpaceBookings</returns>
        [ActionName(Actions.LibraryRoomBookings)]
        public ActionResult LibraryRoomBookings()
        {
            return this.View(Views.ManageSpaceBooking);
        }

        /// <summary>
        ///  list of Space with search criteria
        /// </summary>
        /// <param name="requestModel">the requestModel</param>
        /// <param name="searchdata">searchdata</param>
        /// <returns>List of Spaces</returns>
        [HttpPost]
        [ActionName(Actions.LibraryRoomBookings)]
        [NoAntiForgeryCheck]
        public JsonResult SpaceBookings([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, string searchdata = "")
        {
            List<SpaceBooking> spaceBookingList = new List<SpaceBooking>();

            SpaceBooking model = new SpaceBooking()
            {
                CustomerId = ProjectSession.CustomerId,
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
        /// Book the Space.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Book a Space modal</returns>
        [ActionName(Actions.BookSpace)]
        public ActionResult BookSpace(int id = 0)
        {
            SpaceBooking model = new SpaceBooking();
            model.ID = id;
            if (id > 0)
            {
                model = this.masterDataBL.Search(model).FirstOrDefault();
            }

            return this.PartialView(PartialViews.BookSpace, model);
        }

        /// <summary>
        /// Manages the BookSpace booking.
        /// </summary>
        /// <param name="spaceBooking">The SpaceBooking.</param>
        /// <returns>Save BookSpace booking</returns>
        [ActionName(Actions.BookSpace)]
        [HttpPost]
        public JsonResult BookSpace(SpaceBooking spaceBooking)
        {
            try
            {
                if (this.ModelState.IsValid)
                {
                    spaceBooking.FromDate = DateTime.ParseExact(spaceBooking.BookingDate + " " + spaceBooking.FromTime, ProjectConfiguration.DateTimeFormat, System.Globalization.CultureInfo.InvariantCulture);
                    spaceBooking.ToDate = DateTime.ParseExact(spaceBooking.BookingDate + " " + spaceBooking.ToTime, ProjectConfiguration.DateTimeFormat, System.Globalization.CultureInfo.InvariantCulture);

                    if (spaceBooking.FromDate <= DateTime.Now)
                    {
                        return this.Json(new { resultData = 0, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.SpaceBookingTimeMessage }, JsonRequestBehavior.DenyGet);
                    }

                    if (spaceBooking.ToDate <= spaceBooking.FromDate)
                    {
                        return this.Json(new { resultData = 0, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.TimeCompareMessage.SetArguments(General.ToTime, General.FromTime) }, JsonRequestBehavior.DenyGet);
                    }

                    int status = this.masterDataBL.AddSpaceBooking(spaceBooking, SystemEnumList.SpaceBookingStatus.Pending.GetHashCode().ToInteger());
                    string message = string.Empty;
                    if (status > 0)
                    {
                        SmartLibrary.Services.NotificationFactory.AddNotification(SystemEnumList.NotificationType.SpaceBooking, status);
                        SpaceBooking space = this.masterDataBL.SelectObject<SpaceBooking>(status);

                        EmailViewModel emailModel = new EmailViewModel()
                        {
                            Email = space.CustomerEmail,
                            Name = space.CustomerName,
                            People = space.NoOfPeople.ToString(),
                            RoomName = space.SpaceName,
                            Date = spaceBooking.BookingDate.ToDate().ToString(ProjectConfiguration.DateFormat, System.Globalization.CultureInfo.InvariantCulture),
                            Fromtime = spaceBooking.FromTime.ToDate().ToString("hh:mm tt", System.Globalization.CultureInfo.InvariantCulture),
                            Totime = spaceBooking.ToTime.ToDate().ToString("hh:mm tt", System.Globalization.CultureInfo.InvariantCulture),
                            LanguageId = ConvertTo.ToInteger(ProjectSession.UserPortalLanguageId)
                        };
                        UserMail.RoomBookingRequest(emailModel);

                        List<User> lstAdmin = this.masterDataBL.Search<User>(new User() { Active = true }).ToList();

                        foreach (var item in lstAdmin)
                        {
                            EmailViewModel emailModelAdmin = new EmailViewModel()
                            {
                                Email = item.Email,
                                Name = space.CustomerName,
                                People = spaceBooking.NoOfPeople.ToString(),
                                RoomName = space.SpaceName,
                                Date = spaceBooking.BookingDate.ToDate().ToString(ProjectConfiguration.DateFormat, System.Globalization.CultureInfo.InvariantCulture),
                                Fromtime = spaceBooking.FromTime.ToDate().ToString("hh:mm tt", System.Globalization.CultureInfo.InvariantCulture),
                                Totime = spaceBooking.ToTime.ToDate().ToString("hh:mm tt", System.Globalization.CultureInfo.InvariantCulture),
                                LanguageId = ConvertTo.ToInteger(ProjectSession.UserPortalLanguageId)
                            };
                            UserMail.RoomBookingRequestToAdmin(emailModelAdmin);
                        }

                        if (spaceBooking.ID > 0)
                        {
                            message = Messages.UpdateMessage.SetArguments(General.BookSpace);
                        }
                        else
                        {
                            message = Messages.SaveMessage.SetArguments(General.BookSpace);
                        }

                        return this.Json(new { resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = message, title = General.BookSpace }, JsonRequestBehavior.DenyGet);
                    }
                    else if (status == -3)
                    {
                        var spaceCapacity = new MasterDataBL().GetSpaceList(new Space() { ID = spaceBooking.SpaceId.Value })?.FirstOrDefault()?.Capacity ?? 0;
                        message = Messages.NoOfAttendeeExceedCapacity.SetArguments(spaceCapacity, General.NoOfPeople);
                    }
                    else if (status == -4)
                    {
                        message = Messages.BookingAreaUnavailable;
                    }
                    else
                    {
                        message = Messages.DuplicateMessage.SetArguments(General.BookSpace);
                    }

                    return this.Json(new { resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = message }, JsonRequestBehavior.DenyGet);
                }
                else
                {
                    string errorMsg = string.Empty;
                    foreach (ModelState modelState in this.ViewData.ModelState.Values)
                    {
                        foreach (ModelError error in modelState.Errors)
                        {
                            if (!string.IsNullOrEmpty(errorMsg))
                            {
                                errorMsg = errorMsg + " , ";
                            }

                            errorMsg = errorMsg + error.ErrorMessage;
                        }
                    }

                    return this.Json(new { resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = errorMsg }, JsonRequestBehavior.DenyGet);
                }
            }
            catch (Exception ex)
            {
                return this.Json(new { resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = ex.Message == null ? ex.InnerException.Message : ex.Message }, JsonRequestBehavior.DenyGet);
            }
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

        #endregion
    }
}
