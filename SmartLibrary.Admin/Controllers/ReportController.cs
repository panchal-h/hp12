// <copyright file="ReportController.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Admin.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Infrastructure;
    using Infrastructure;
    using Infrastructure.Filters;
    using Models;
    using Newtonsoft.Json;
    using Pages;
    using Services;
    using SmartLibrary.Models;

    /// <summary>Report Controller.</summary>
    /// <CreatedBy>Bhargav Aboti.</CreatedBy>
    /// <CreatedDate>04-Oct-2018.</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class ReportController : BaseController
    {
        private ReportDataBL reportdataBL;
        private MasterDataBL masterdataBL;

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportController"/> class.
        /// ReportController
        /// </summary>
        public ReportController()
        {
            if (this.reportdataBL == null)
            {
                this.reportdataBL = new ReportDataBL();
            }

            if (this.masterdataBL == null)
            {
                this.masterdataBL = new MasterDataBL();
            }
        }

        #endregion Constructor

        /// <summary>
        /// Report Page.
        /// </summary>
        /// <returns>Report View.</returns>
        [ActionName(Actions.ManageReport)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.ManageReport)]
        public ActionResult ManageReport()
        {
            return this.View();
        }

        /// <summary>
        /// Report Count.
        /// </summary>
        /// <returns>Details of Report.</returns>
        [HttpGet]
        [ActionName(Actions.ReportCount)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.ManageReport)]
        public JsonResult ReportCount()
        {
            ReportViewModel report = new ReportViewModel();
            var count = this.reportdataBL.GetCountForReport();

            report.TotalBooksBorrowed = count.Tables[0].Rows[0][0].ToInteger();
            report.TotalBooks = count.Tables[1].Rows[0][0].ToInteger();
            report.TotalRoomsBooked = count.Tables[2].Rows[0][0].ToInteger();
            report.TotalBooksBorrowedThroughLibrary = count.Tables[3].Rows[0][0].ToInteger();
            if (count.Tables[4].Rows.Count > 0)
            {
                count.Tables[4].Rows[0][1] = this.Url.Content($"~/{ProjectConfiguration.BookImagesPath}/{count.Tables[4].Rows[0][1]}");
            }

            report.PopularBook = count.Tables[4];

            if (count.Tables[5].Rows.Count > 0)
            {
                count.Tables[5].Rows[0][2] = this.Url.Content($"~/{ProjectConfiguration.UserProfileImagePath}/{count.Tables[5].Rows[0][2]}");
            }
            
            report.ActiveBorrower = count.Tables[5];
            if (count.Tables[8].Rows.Count > 0)
            {
                count.Tables[8].Rows[0][2] = this.Url.Content($"~/{ProjectConfiguration.UserProfileImagePath}/{count.Tables[8].Rows[0][2]}");
            }
            
            report.PopularUserBookingRoom = count.Tables[8];
            report.PopularAuthor = count.Tables[7];
            report.PopularGenre = count.Tables[6];
            report.PopularTime = count.Tables[9];
            int totalBookReturn = count.Tables[10].Rows[0][0].ToInteger();
            int returnOnTime = count.Tables[10].Rows[0][1].ToInteger();
            if (totalBookReturn > 0)
            {
                report.ReturnedBookOnTime = Math.Ceiling((Convert.ToDecimal(returnOnTime) / Convert.ToDecimal(totalBookReturn)) * 100);
                report.ReturnedBookDelay = 100 - report.ReturnedBookOnTime;
            }
            else
            {
                report.ReturnedBookOnTime = 0;
                report.ReturnedBookDelay = 0;
            }
            
            var list = JsonConvert.SerializeObject(
                report,
                Formatting.None,
                new JsonSerializerSettings()
    {
        ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
    });
            return this.Json(new { list }, JsonRequestBehavior.AllowGet);
        }
    }
}