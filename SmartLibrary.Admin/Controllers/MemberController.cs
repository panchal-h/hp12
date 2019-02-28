// <copyright file="MemberController.cs" company="Caspian Pacific Tech">
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
    using DataTables.Mvc;
    using EmailServices;
    using Infrastructure;
    using Infrastructure.Code;
    using Infrastructure.Filters;
    using Models;
    using OfficeOpenXml;
    using Resources;
    using Services;
    using SmartLibrary.Admin.Pages;
    using SmartLibrary.Models;
    using static Infrastructure.SystemEnumList;

    /// <summary>
    /// Used to Member Controller.
    /// </summary>
    /// <CreatedBy>Bhoomi Shah.</CreatedBy>
    /// <CreatedDate>10-sep-2018.</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class MemberController : BaseController
    {
        private MemberDataBL memberDataBL;
        private CommonBL commonDataBL;
        private MasterDataBL masterDataBL;

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberController"/> class.
        /// MemberController
        /// </summary>
        public MemberController()
        {
            if (this.memberDataBL == null)
            {
                this.memberDataBL = new MemberDataBL();
            }

            if (this.commonDataBL == null)
            {
                this.commonDataBL = new CommonBL();
            }

            if (this.masterDataBL == null)
            {
                this.masterDataBL = new MasterDataBL();
            }
        }

        #endregion Constructor

        #region Customers

        /// <summary>
        /// CustomerList this instance.
        /// </summary>
        /// <returns>List of CustomerList</returns>
        [ActionName(Actions.CustomerList)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Customer)]
        public ActionResult CustomerList()
        {
            this.ViewData["CurrentPageAccessRight"] = this.PageAccessRight;
            return this.View(Views.CustomerList);
        }

        /// <summary>
        ///  list of customer with search criteria
        /// </summary>
        /// <param name="requestModel">the requestModel</param>
        /// <param name="searchdata">search</param>
        /// <returns>List of Customer</returns>
        [HttpPost]
        [ActionName(Actions.CustomerList)]
        [NoAntiForgeryCheck]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Customer)]
        public JsonResult CustomerList([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, string searchdata = "")
        {
            List<Customer> customerList = new List<Customer>();

            Customer model = new Customer()
            {
                FirstName = searchdata,
                LastName = searchdata,
                Email = searchdata,
                StartRowIndex = requestModel.Start + 1,
                EndRowIndex = requestModel.Start + requestModel.Length,
                SortDirection = requestModel.OrderDir,
                SortExpression = requestModel.Columns.ElementAt(requestModel.OrderColumn).Data
            };

            customerList = this.memberDataBL.GetCustomerList(model);
            int totalRecord = 0;
            int filteredRecord = 0;
            if (customerList != null && customerList.Count > 0)
            {
                totalRecord = customerList.FirstOrDefault().TotalRecords;
                filteredRecord = customerList.FirstOrDefault().TotalRecords;
                foreach (var customer in customerList)
                {
                    customer.IdEncrypted = EncryptionDecryption.EncryptByTripleDES(customer.Id.ToString());
                }
            }

            return this.Json(new DataTablesResponse(requestModel.Draw, customerList, filteredRecord, totalRecord), JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region CustomerGrid

        /// <summary>
        /// View Customer
        /// </summary>
        /// <returns>Return View</returns>
        [HttpGet]
        [ActionName(Actions.CustomerGrid)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Customer)]
        public ActionResult CustomerGrid()
        {
            this.ViewData["CurrentPageAccessRight"] = this.PageAccessRight;
            List<Customer> customerList = new List<Customer>();
            Customer model = new Customer()
            {
                StartRowIndex = 1,
                EndRowIndex = ProjectConfiguration.PageSizeGrid,
            };
            customerList = this.memberDataBL.GetCustomerList(model);
            foreach (var customer in customerList)
            {
                customer.IdEncrypted = EncryptionDecryption.EncryptByTripleDES(customer.Id.ToString());
            }

            int totalRecord = customerList.FirstOrDefault()?.TotalRecords ?? 0;
            this.ViewBag.TotalPage = Math.Ceiling((float)totalRecord / 20);
            return this.View(Views.CustomerGrid, customerList);
        }

        /// <summary>
        ///  list of Customer with search criteria
        /// </summary>
        /// <param name="baseModel">model</param>
        /// <returns>List of customers</returns>
        [HttpPost]
        [ActionName(Actions.CustomerGrid)]
        [NoAntiForgeryCheck]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Customer)]
        public ActionResult CustomerGrid(BaseViewModel baseModel)
        {
            List<Customer> customerList = new List<Customer>();
            Customer model = new Customer()
            {
                FirstName = baseModel.Searchtext,
                LastName = baseModel.Searchtext,
                Email = baseModel.Searchtext,
                StartRowIndex = ((baseModel.CurrentPage - 1) * ProjectConfiguration.PageSizeGrid) + 1,
                EndRowIndex = baseModel.CurrentPage * ProjectConfiguration.PageSizeGrid,
            };
            customerList = this.memberDataBL.GetCustomerList(model);

            int totalRecord = 0;
            int filteredRecord = 0;
            if (customerList != null && customerList.Count > 0)
            {
                totalRecord = customerList.FirstOrDefault().TotalRecords;
                filteredRecord = customerList.FirstOrDefault().TotalRecords;
                foreach (var customer in customerList)
                {
                    customer.IdEncrypted = EncryptionDecryption.EncryptByTripleDES(customer.Id.ToString());
                }
            }

            this.ViewBag.TotalPage = Math.Ceiling((float)totalRecord / ProjectConfiguration.PageSizeGrid);
            return this.PartialView(PartialViews.CustomerGrid, customerList);
        }

        #endregion

        #region Invite Customer

        /// <summary>
        /// Invite Customer
        /// </summary>
        /// <returns>Partial view</returns>
        [HttpGet]
        [ActionName(Actions.InviteCustomer)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Customer)]
        public ActionResult InviteCustomer()
        {
            return this.PartialView(PartialViews.InviteCustomer);
        }

        /// <summary>
        /// Invite Customer
        /// </summary>
        /// <param name="email">email</param>
        /// <returns>Json result</returns>
        [HttpPost]
        [ActionName(Actions.InviteCustomer)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Customer)]
        public JsonResult InviteCustomer(string email)
        {
            Customer objCustomer = this.memberDataBL.GetCustomerList(new Customer()).Where(x => x.Email == email).FirstOrDefault();
            var encryptLoginType = EncryptionDecryption.EncryptByTripleDES(LoginType.Guest.GetHashCode().ToString());
            if (objCustomer == null)
            {
                string signUpParameter = string.Format("{0}", email);
                string encryptsignUpParameter = EncryptionDecryption.EncryptByTripleDES(signUpParameter);
                string signUpURL = string.Format("{0}?q={1}&loginType={2}", ProjectConfiguration.FrontEndSiteUrl + Controllers.ActiveDirectory + "/" + Actions.SignUp, encryptsignUpParameter, encryptLoginType);
                EmailViewModel emailModel = new EmailViewModel()
                {
                    Email = email,
                    ResetUrl = signUpURL,
                    LanguageId = ConvertTo.ToInteger(ProjectSession.AdminPortalLanguageId)
                };
                if (UserMail.SendInviteMail(emailModel))
                {
                    return this.Json(new { status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.EmailSent, title = Infrastructure.SystemEnumList.Title.Member.GetDescription(), JsonRequestBehavior.AllowGet });
                }
                else
                {
                    return this.Json(new { status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.ErrorMessage, title = Infrastructure.SystemEnumList.Title.Member.GetDescription(), JsonRequestBehavior.AllowGet });
                }
            }
            else
            {
                return this.Json(new { status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.MemberAlreadyRegistered, title = Infrastructure.SystemEnumList.Title.Member.GetDescription(), JsonRequestBehavior.AllowGet });
            }
        }
        #endregion

        #region Download

        /// <summary>
        ///  Export to excel 
        /// </summary>
        /// <param name="searchdata">search</param>
        /// <returns>List of Customer export to excel</returns>
        [HttpGet]
        [ActionName(Actions.CustomersExportToExcel)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Customer)]
        public ActionResult CustomersExportToExcel(string searchdata = "")
        {
            DataTable customers = new DataTable();
            Customer model = new Customer()
            {
                FirstName = searchdata,
                LastName = searchdata,
                Email = searchdata
            };

            var customerList = this.memberDataBL.GetCustomerList(model).Select(x => new { x.FirstName, x.LastName, x.Email, x.Gender, x.Phone }).ToList();
            customers = ConvertTo.ToDataTable(customerList.ToList());
            customers.Columns.Add("strGender", typeof(string));
            foreach (DataRow row in customers?.Rows)
            {
                bool active = row["Gender"].ToBoolean();

                if (active)
                {
                    row["strGender"] = "Female";
                }
                else
                {
                    row["strGender"] = "Male";
                }
            }

            customers.Columns.Remove("Gender");
            byte[] bytes;
            string filename;
            try
            {
                ////this.Response.Clear();
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet workSheet = package.Workbook.Worksheets.Add("Member");

                    workSheet.Cells["A1"].LoadFromDataTable(customers, true);
                    var reg = customers.Rows.Count;
                    workSheet.Cells["A1"].Value = "FirstName";
                    workSheet.Cells["B1"].Value = "LastName";
                    workSheet.Cells["C1"].Value = "Email";
                    workSheet.Cells["D1"].Value = "Phone";
                    workSheet.Cells["E1"].Value = "Gender";

                    filename = "Member_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".xlsx";
                    bytes = package.GetAsByteArray();
                    return this.File(bytes, "application/application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", filename);
                }
            }
            catch (Exception ex)
            {
                return this.Json(new object[] { false, ex.Message.ToString() }, JsonRequestBehavior.AllowGet);
            }

            return this.File(bytes, "application/application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", filename);
        }
        #endregion

        #region History

        /// <summary>
        /// CustomerList this instance.
        /// </summary>
        /// <param name="data">the encrypted Id</param>
        /// <returns>List of CustomerList</returns>
        [ActionName(Actions.HistoryOfMember)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Customer)]
        [HttpGet]
        public ActionResult HistoryOfMember(string data = "")
        {
            this.ViewData["CurrentPageAccessRight"] = this.PageAccessRight;

            string decryptedVal = EncryptionDecryption.DecryptByTripleDES(data);
            if (decryptedVal != string.Empty)
            {
                this.ViewData["ID"] = data;

                Customer model = new Customer()
                {
                    Id = decryptedVal.ToInteger()
                };

                var customer = this.memberDataBL.GetCustomerList(model).FirstOrDefault();
                this.ViewBag.MemberName = customer.FirstName + " " + customer.LastName;
                return this.View(Views.HistoryOfMember);
            }
            else
            {
                return this.RedirectToAction(Actions.CustomerList, Controllers.Member);
            }
        }

        /// <summary>
        ///  list of Book Genres with search criteria
        /// </summary>
        /// <param name="requestModel">the requestModel</param>
        /// <param name="searchdata">search</param>
        /// <param name="data">the encrypted id</param>
        /// <param name="historyType">type of history</param>
        /// <returns>List of BookGenres</returns>
        [HttpPost]
        [ActionName(Actions.HistoryOfMember)]
        [NoAntiForgeryCheck]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Customer)]
        public JsonResult HistoryOfMember([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, string searchdata = "", string data = "", int historyType = 1)
        {
            int id = ConvertTo.ToInteger(EncryptionDecryption.DecryptByTripleDES(data));
            int totalRecord = 0;
            int filteredRecord = 0;
            if (historyType == 1)
            {
                List<BorrowedBook> borrowedBookList = new List<BorrowedBook>();
                borrowedBookList = this.commonDataBL.GetBookDetailsOfCustomer(id, searchdata, requestModel.Start + 1, requestModel.Start + requestModel.Length, requestModel.Columns.ElementAt(requestModel.OrderColumn).Data, requestModel.OrderDir);
                if (borrowedBookList != null && borrowedBookList.Count > 0)
                {
                    totalRecord = borrowedBookList.FirstOrDefault().TotalRecords;
                    filteredRecord = borrowedBookList.FirstOrDefault().TotalRecords;
                }

                return this.Json(new DataTablesResponse(requestModel.Draw, borrowedBookList, filteredRecord, totalRecord), JsonRequestBehavior.AllowGet);
            }
            else
            {
                List<SpaceBooking> spaceList = new List<SpaceBooking>();
                spaceList = this.commonDataBL.GetSpaceDetailsOfCustomer(id, searchdata, requestModel.Start + 1, requestModel.Start + requestModel.Length, requestModel.Columns.ElementAt(requestModel.OrderColumn).Data, requestModel.OrderDir);
                if (spaceList != null && spaceList.Count > 0)
                {
                    totalRecord = spaceList.FirstOrDefault().TotalRecords;
                    filteredRecord = spaceList.FirstOrDefault().TotalRecords;
                }

                return this.Json(new DataTablesResponse(requestModel.Draw, spaceList, filteredRecord, totalRecord), JsonRequestBehavior.AllowGet);
            }
        }

        /// <summary>
        /// Status change of space booking
        /// </summary>
        /// <param name="statusId">statusId.</param>
        /// <param name="spaceBookingId">spaceBookingId.</param>
        /// <param name="comment">comment</param>
        /// <returns>Approve/Reject BorrowedBook</returns>
        [HttpPost]
        [ActionName(Actions.ApproveCancelSpaceBooking)]
        [NoAntiForgeryCheck]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Customer)]
        public JsonResult ApproveCancelSpaceBooking(int statusId, int spaceBookingId = 0, string comment = null)
        {
            string msg = string.Empty;
            try
            {
                if (statusId == SystemEnumList.SpaceBookingStatus.Approved.GetHashCode())
                {
                    msg = SystemEnumList.SpaceBookingStatus.Approved.GetDescription();
                }
                else if (statusId == SystemEnumList.SpaceBookingStatus.Cancel.GetHashCode())
                {
                    msg = SystemEnumList.SpaceBookingStatus.Cancel.GetDescription();
                }
                else if (statusId == SystemEnumList.SpaceBookingStatus.Pending.GetHashCode())
                {
                    msg = SystemEnumList.SpaceBookingStatus.Pending.GetDescription();
                }

                SpaceBooking spacebooking = this.masterDataBL.SelectObject<SpaceBooking>(spaceBookingId);
                spacebooking.StatusId = statusId;
                string spaceName = spacebooking.SpaceName;
                spacebooking.SpaceName = null;
                if (statusId == SystemEnumList.SpaceBookingStatus.Cancel.GetHashCode())
                {
                    spacebooking.Comment = comment;
                }

                int id = this.masterDataBL.Save<SpaceBooking>(spacebooking, checkForDuplicate: false);
                if (id > 0)
                {
                    if (statusId == SystemEnumList.SpaceBookingStatus.Approved.GetHashCode())
                    {
                        EmailViewModel emailModel = new EmailViewModel()
                        {
                            Email = spacebooking.CustomerEmail,
                            Name = spacebooking.CustomerName,
                            People = spacebooking.NoOfPeople.ToString(),
                            RoomName = spaceName,
                            Date = spacebooking.FromDate.ToDate().ToString(ProjectConfiguration.DateFormat, System.Globalization.CultureInfo.InvariantCulture),
                            Fromtime = spacebooking.FromDate.ToDate().ToString("hh:mm tt", System.Globalization.CultureInfo.InvariantCulture),
                            Totime = spacebooking.ToDate.ToDate().ToString("hh:mm tt", System.Globalization.CultureInfo.InvariantCulture),
                            LanguageId = ConvertTo.ToInteger(ProjectSession.AdminPortalLanguageId)
                        };
                        UserMail.RoomBookingApprove(emailModel);
                        NotificationFactory.AddNotification(NotificationType.SpaceBookingApprove, spacebooking);
                    }
                    else if (statusId == SystemEnumList.SpaceBookingStatus.Cancel.GetHashCode())
                    {
                        EmailViewModel emailModel = new EmailViewModel()
                        {
                            Email = spacebooking.CustomerEmail,
                            Name = spacebooking.CustomerName,
                            People = spacebooking.NoOfPeople.ToString(),
                            RoomName = spaceName,
                            Date = spacebooking.FromDate.ToDate().ToString(ProjectConfiguration.DateFormat, System.Globalization.CultureInfo.InvariantCulture),
                            Fromtime = spacebooking.FromDate.ToDate().ToString("hh:mm tt", System.Globalization.CultureInfo.InvariantCulture),
                            Totime = spacebooking.ToDate.ToDate().ToString("hh:mm tt", System.Globalization.CultureInfo.InvariantCulture),
                            LanguageId = ConvertTo.ToInteger(ProjectSession.AdminPortalLanguageId)
                        };
                        UserMail.RoomBookingCancel(emailModel);
                        NotificationFactory.AddNotification(NotificationType.SpaceBookingReject, spacebooking);
                    }
                    else if (statusId == SystemEnumList.SpaceBookingStatus.Pending.GetHashCode())
                    {
                        NotificationFactory.AddNotification(NotificationType.SpaceBookingPending, spacebooking);
                    }

                    return this.Json(new { success = true, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.ApproveSpaceBookingStatus.SetArguments(msg), title = Infrastructure.SystemEnumList.Title.Space.GetDescription(), JsonRequestBehavior.AllowGet });
                }
                else
                {
                    msg = Messages.ErrorMessage.SetArguments(General.BookSpace);
                    if (id == -3)
                    {
                        var spaceCapacity = new MasterDataBL().GetSpaceList(new Space() { ID = spaceBookingId })?.FirstOrDefault()?.Capacity ?? 0;
                        msg = Messages.NoOfAttendeeExceedCapacity.SetArguments(spaceCapacity, General.NoOfPeople);
                    }
                    else if (id == -4)
                    {
                        msg = Messages.BookingAreaUnavailable;
                    }

                    return this.Json(new { success = false, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = msg, title = Infrastructure.SystemEnumList.Title.Space.GetDescription(), JsonRequestBehavior.AllowGet });
                }
            }
            catch (Exception ex)
            {
                return this.Json(new { success = false, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.ErrorMessage.SetArguments(msg), title = Infrastructure.SystemEnumList.Title.Space.GetDescription(), JsonRequestBehavior.AllowGet });
            }
        }

        /// <summary>
        /// Book the Space.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Book a Space modal</returns>
        [ActionName(Actions.RescheduleBookSpace)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Space)]
        public ActionResult RescheduleBookSpace(int id = 0)
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
        /// Book the Space.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Space Status modal</returns>
        [ActionName(Actions.ViewSpaceStatus)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Space)]
        public ActionResult ViewSpaceStatus(int id = 0)
        {
            SpaceBooking model = new SpaceBooking();
            model.ID = id;
            if (id > 0)
            {
                model = this.masterDataBL.Search(model).FirstOrDefault();
            }

            return this.PartialView(PartialViews.ViewSpaceStatus, model);
        }

        /// <summary>
        /// Manages the BookSpace booking.
        /// </summary>
        /// <param name="spaceBooking">The SpaceBooking.</param>
        /// <returns>Save BookSpace booking</returns>
        [ActionName(Actions.RescheduleBookSpace)]
        [HttpPost]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Space)]
        public JsonResult RescheduleBookSpace(SpaceBooking spaceBooking)
        {
            int rescheduldid = spaceBooking.ID;
            spaceBooking.ID = 0;
            try
            {
                if (this.ModelState.IsValid)
                {
                    string comment = spaceBooking.Comment;
                    spaceBooking.Comment = string.Empty;

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

                    int status = this.masterDataBL.AddSpaceBooking(spaceBooking, SystemEnumList.SpaceBookingStatus.Approved.GetHashCode().ToInteger());
                    string message = string.Empty;
                    if (status > 0)
                    {
                        message = Messages.SpaceBookingReschedule;

                        SpaceBooking oldspacebooking = this.masterDataBL.SelectObject<SpaceBooking>(rescheduldid);
                        string oldSpaceName = oldspacebooking.SpaceName;
                        oldspacebooking.StatusId = ConvertTo.ToInteger(SystemEnumList.SpaceBookingStatus.Rescheduled.GetHashCode());
                        oldspacebooking.RescheduleId = status;
                        oldspacebooking.Reschedule = true;
                        oldspacebooking.SpaceName = null;
                        oldspacebooking.Comment = comment;
                        int id = this.masterDataBL.Save<SpaceBooking>(oldspacebooking, checkForDuplicate: false);

                        if (id > 0)
                        {
                            spaceBooking.ID = status;
                            NotificationFactory.AddNotification(NotificationType.SpaceBookingReschedule, spaceBooking);

                            SpaceBooking newSpaceBooking = this.masterDataBL.SelectObject<SpaceBooking>(status);
                            EmailViewModel emailModel = new EmailViewModel()
                            {
                                Email = newSpaceBooking.CustomerEmail,
                                Name = newSpaceBooking.CustomerName,
                                OldroomName = oldSpaceName,
                                OldDate = oldspacebooking.FromDate.ToDate().ToString(ProjectConfiguration.DateFormat, System.Globalization.CultureInfo.InvariantCulture),
                                OldFromtime = oldspacebooking.FromDate.ToDate().ToString("HH:mm", System.Globalization.CultureInfo.InvariantCulture),
                                OldTotime = oldspacebooking.ToDate.ToDate().ToString("HH:mm", System.Globalization.CultureInfo.InvariantCulture),
                                OldPeople = oldspacebooking.NoOfPeople.ToString(),
                                RoomName = newSpaceBooking.SpaceName,
                                People = spaceBooking.NoOfPeople.ToString(),
                                Date = spaceBooking.BookingDate.ToDate().ToString(ProjectConfiguration.DateFormat, System.Globalization.CultureInfo.InvariantCulture),
                                Fromtime = spaceBooking.FromDate.ToDate().ToString("hh:mm tt", System.Globalization.CultureInfo.InvariantCulture),
                                Totime = spaceBooking.ToDate.ToDate().ToString("hh:mm tt", System.Globalization.CultureInfo.InvariantCulture),
                                LanguageId = ConvertTo.ToInteger(ProjectSession.AdminPortalLanguageId)
                            };
                            UserMail.RoomBookingReschedule(emailModel);
                            return this.Json(new { resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = message, title = General.BookSpace }, JsonRequestBehavior.DenyGet);
                        }
                        else
                        {
                            int deletedId = this.masterDataBL.Delete<SpaceBooking>(status);
                            return this.Json(new { success = false, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.ErrorMessage.SetArguments(General.BookSpace), title = Infrastructure.SystemEnumList.Title.Space.GetDescription(), JsonRequestBehavior.AllowGet });
                        }
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

        #endregion

        #region ::Edit Customer::

        /// <summary>
        /// Customer Edit .
        /// </summary>
        /// <param name="id">the Id</param>
        /// <returns>Partial view of edit customer.</returns>
        [ActionName(Actions.EditCustomer)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Customer)]
        [HttpGet]
        public ActionResult EditCustomer(int id = 0)
        {
            Customer model = new Customer();
            if (id < 0)
            {
                return this.View(Views.CustomerGrid);
            }

            model = this.memberDataBL.SelectCustomer(id);
            return this.PartialView(PartialViews.EditCustomer, model);
        }

        /// <summary>
        /// Manages the User.
        /// </summary>
        /// <param name="user">The User.</param>
        /// <returns>Edit Customer</returns>
        [ActionName(Actions.EditCustomer)]
        [HttpPost]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Customer)]
        public JsonResult EditCustomer(Customer user)
        {
            if (user.LoginType == SystemEnumList.LoginType.Guest.GetHashCode() && !string.IsNullOrEmpty(user.AGUserId))
            {
                ActiveDirectoryRegister activeDirectoryUpdate = new ActiveDirectoryRegister()
                {
                    Email = user.Email,
                    Password = user.Password,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    FullName = user.FirstName + string.Empty + user.LastName,
                    UserId = user.AGUserId,
                    LanguageId = user.Language ?? SystemEnumList.Language.Arabic.GetHashCode()
                };
                var updateResponse = this.commonDataBL.ActiveDirectoryUpdateResponse(activeDirectoryUpdate);
                if (updateResponse == null || updateResponse.Status != SystemEnumList.ApiStatus.Success.GetDescription())
                {
                    return this.Json(new { resultData = 0, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = updateResponse?.Message ?? Messages.ErrorMessage.SetArguments(General.Member), title = Infrastructure.SystemEnumList.Title.Member.GetDescription(), JsonRequestBehavior.DenyGet });
                }
            }

            var userData = this.memberDataBL.SelectCustomer(user.Id);
            userData.FirstName = user.FirstName;
            userData.LastName = user.LastName;
            userData.Phone = user.Phone;
            userData.Gender = user.Gender;
            userData.Language = user.Language;
            int status = this.memberDataBL.SaveCustomer(userData, userData.Id);
            string message = string.Empty;
            if (status > 0)
            {
                message = Messages.UpdateMessage.SetArguments(General.Member);
            }
            else
            {
                if (status == -2)
                {
                    message = Messages.DuplicateMessage.SetArguments(General.Member);
                }
                else
                {
                    message = Messages.ErrorMessage.SetArguments(General.Member);
                }

                return this.Json(new { resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = message, title = Infrastructure.SystemEnumList.Title.Member.GetDescription(), JsonRequestBehavior.DenyGet });
            }

            return this.Json(new { resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = message, title = Infrastructure.SystemEnumList.Title.Member.GetDescription(), JsonRequestBehavior.DenyGet });
        }

        #endregion
    }
}