// <copyright file="MasterController.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
namespace SmartLibrary.Admin.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using DataTables.Mvc;
    using Infrastructure;
    using Infrastructure.Code;
    using Infrastructure.Filters;
    using Models;
    using Pages;
    using Resources;
    using Services;
    using SmartLibrary.Models;

    /// <summary>
    /// MasterController
    /// </summary>
    public partial class MasterController : BaseController
    {
        private MasterDataBL masterDataBL;

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="MasterController"/> class.
        /// MasterController
        /// </summary>
        public MasterController()
        {
            if (this.masterDataBL == null)
            {
                this.masterDataBL = new MasterDataBL();
            }
        }

        #endregion Constructor

        #region BookGenres

        /// <summary>
        /// BookGenres this instance.
        /// </summary>
        /// <returns>List of BookGenres</returns>
        [ActionName(Actions.BookGenre)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.BookGenre)]
        public ActionResult BookGenre()
        {
            this.ViewData["CurrentPageAccessRight"] = this.PageAccessRight;
            return this.View(Views.BookGenre);
        }

        /// <summary>
        ///  list of Book Genres with search criteria
        /// </summary>
        /// <param name="requestModel">the requestModel</param>
        /// <param name="searchdata">search</param>
        /// <returns>List of BookGenres</returns>
        [HttpPost]
        [ActionName(Actions.BookGenre)]
        [NoAntiForgeryCheck]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.BookGenre)]
        public JsonResult BookGenre([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, string searchdata = "")
        {
            List<BookGenre> bookGenreList;

            BookGenre model = new BookGenre()
            {
                Name = searchdata,
                StartRowIndex = requestModel.Start + 1,
                EndRowIndex = requestModel.Start + requestModel.Length,
                SortDirection = requestModel.OrderDir,
                SortExpression = requestModel.Columns.ElementAt(requestModel.OrderColumn).Data
            };

            bookGenreList = this.masterDataBL.GetBookGenreList(model);
            int totalRecord = 0;
            int filteredRecord = 0;
            if (bookGenreList != null && bookGenreList.Count > 0)
            {
                totalRecord = bookGenreList.FirstOrDefault().TotalRecords;
                filteredRecord = bookGenreList.FirstOrDefault().TotalRecords;
            }

            return this.Json(new DataTablesResponse(requestModel.Draw, bookGenreList, filteredRecord, totalRecord), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Manages the BookGenres.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Manage Individual Genre View</returns>
        [HttpGet]
        [ActionName(Actions.AddEditBookGenre)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.BookGenre)]
        public ActionResult AddEditBookGenre(int id = 0)
        {
            BookGenre model = new BookGenre();
            model.ID = id;
            if (id > 0)
            {
                model = this.masterDataBL.GetBookGenreList(model).FirstOrDefault();
            }
            else
            {
                model.Active = true;
            }

            return this.PartialView(PartialViews.AddEditBookGenre, model);
        }

        /// <summary>
        /// Manages the BookGenres.
        /// </summary>
        /// <param name="book">The BookGenres.</param>
        /// <returns>Save BookGenres</returns>
        [ActionName(Actions.AddEditBookGenre)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.BookGenre)]
        [HttpPost]
        public JsonResult AddEditBookGenre(BookGenre book)
        {
            try
            {
                if (this.ModelState.IsValid)
                {
                    int status = this.masterDataBL.SaveBookGenre(book);
                    string message = string.Empty;
                    string messageBoxType = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription();
                    if (status > 0)
                    {
                        if (book.ID > 0)
                        {
                            message = Messages.UpdateMessage.SetArguments(General.BookGenre);
                        }
                        else
                        {
                            message = Messages.SaveMessage.SetArguments(General.BookGenre);
                        }
                    }
                    else
                    {
                        messageBoxType = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription();
                        message = Messages.DuplicateMessage.SetArguments(General.BookGenre);
                    }

                    return this.Json(new { resultData = status, status = messageBoxType, message = message, title = Infrastructure.SystemEnumList.Title.BookGenre.GetDescription(), JsonRequestBehavior.DenyGet });
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

                    return this.Json(new { resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = errorMsg, title = Infrastructure.SystemEnumList.Title.BookGenre.GetDescription(), JsonRequestBehavior.DenyGet });
                }
            }
            catch (Exception ex)
            {
                return this.Json(new { resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = ex.Message == null ? ex.InnerException.Message : ex.Message, title = Infrastructure.SystemEnumList.Title.BookGenre.GetDescription(), JsonRequestBehavior.DenyGet });
            }
        }

        /// <summary>
        /// Deletes the BookGenres.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Delete Individual</returns>
        [ActionName(Actions.DeleteBookGenre)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_DELETE, ActionName = Actions.BookGenre)]
        [HttpPost]
        public JsonResult DeleteBookGenres(int id = 0)
        {
            try
            {
                int status = this.masterDataBL.DeleteBookGenre(id);
                if (status == 0)
                {
                    return this.Json(new { success = true, resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.DeleteMessage.SetArguments(General.BookGenre), title = Infrastructure.SystemEnumList.Title.BookGenre.GetDescription(), JsonRequestBehavior.AllowGet });
                }
                else
                {
                    return this.Json(new { success = false, resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.DeleteErrorMessage.SetArguments(General.BookGenre), title = Infrastructure.SystemEnumList.Title.BookGenre.GetDescription(), JsonRequestBehavior.AllowGet });
                }
            }
            catch (Exception ex)
            {
                return this.Json(new { success = false, resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = ex.Message == null ? ex.InnerException.Message : ex.Message, title = Infrastructure.SystemEnumList.Title.BookGenre.GetDescription(), JsonRequestBehavior.AllowGet });
            }
        }

        /// <summary>
        /// ChangeStatus
        /// </summary>
        /// <param name="status">The Status</param>
        /// <param name="id">The identifier.</param>
        /// <returns>Manage Individual Genre View</returns>
        [HttpPost]
        [ActionName(Actions.ChangeBookGenreStatus)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.BookGenre)]
        public JsonResult ChangeBookGenreStatus(bool status, int id = 0)
        {
            BookGenre model = new BookGenre();
            model.ID = id;
            if (id > 0)
            {
                model = this.masterDataBL.GetBookGenreList(model).FirstOrDefault();
            }

            model.Active = status;
            model.ModifiedBy = ProjectSession.UserId;
            model.ModifiedDate = DateTime.Now;

            int result = this.masterDataBL.SaveBookGenre(model);
            if (result > 0)
            {
                return this.Json(new { success = true });
            }
            else
            {
                return this.Json(new { success = false, message = Messages.ErrorMessage.SetArguments(General.BookGenre) });
            }
        }

        #endregion

        #region Spaces

        /// <summary>
        /// Space this instance.
        /// </summary>
        /// <returns>List of Space</returns>
        [ActionName(Actions.Space)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Space)]
        public ActionResult Space()
        {
            this.ViewData["CurrentPageAccessRight"] = this.PageAccessRight;
            return this.View(Views.Space);
        }

        /// <summary>
        ///  list of Space with search criteria
        /// </summary>
        /// <param name="requestModel">the requestModel</param>
        /// <param name="searchdata">searchdata</param>
        /// <returns>List of Spaces</returns>
        [HttpPost]
        [ActionName(Actions.Space)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Space)]
        [NoAntiForgeryCheck]
        public JsonResult Space([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, string searchdata = "")
        {
            List<Space> spaceList;

            Space model = new Space()
            {
                Name = searchdata,
                StartRowIndex = requestModel.Start + 1,
                EndRowIndex = requestModel.Start + requestModel.Length,
                SortDirection = requestModel.OrderDir,
                SortExpression = requestModel.Columns.ElementAt(requestModel.OrderColumn).Data
            };

            spaceList = this.masterDataBL.GetSpaceList(model);
            int totalRecord = 0;
            int filteredRecord = 0;
            if (spaceList != null && spaceList.Count > 0)
            {
                totalRecord = spaceList.FirstOrDefault().TotalRecords;
                filteredRecord = spaceList.FirstOrDefault().TotalRecords;
            }

            return this.Json(new DataTablesResponse(requestModel.Draw, spaceList, filteredRecord, totalRecord), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Manages the Space.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Manage Individual Space View</returns>
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Space)]
        [ActionName(Actions.AddEditSpace)]
        public ActionResult AddEditSpace(int id = 0)
        {
            Space model = new Space();
            model.ID = id;
            if (id > 0)
            {
                model = this.masterDataBL.GetSpaceList(model).FirstOrDefault();
            }
            else
            {
                model.Active = true;
            }

            return this.PartialView(PartialViews.AddEditSpace, model);
        }

        /// <summary>
        /// Manages the Space.
        /// </summary>
        /// <param name="space">The Space.</param>
        /// <returns>Save Space</returns>
        [ActionName(Actions.AddEditSpace)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Space)]
        [HttpPost]
        public JsonResult AddEditSpace(Space space)
        {
            try
            {
                if (this.ModelState.IsValid)
                {
                    int status = this.masterDataBL.SaveSpace(space);
                    string message = string.Empty;
                    string messageBoxType = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription();
                    if (status > 0)
                    {
                        if (space.ID > 0)
                        {
                            message = Messages.UpdateMessage.SetArguments(General.Space);
                        }
                        else
                        {
                            message = Messages.SaveMessage.SetArguments(General.Space);
                        }
                    }
                    else
                    {
                        messageBoxType = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription();
                        message = Messages.DuplicateMessage.SetArguments(General.Space);
                    }

                    return this.Json(new { resultData = status, status = messageBoxType, message = message, title = Infrastructure.SystemEnumList.Title.Space.GetDescription(), JsonRequestBehavior.DenyGet });
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

                    return this.Json(new { resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = errorMsg, title = Infrastructure.SystemEnumList.Title.Space.GetDescription(), JsonRequestBehavior.DenyGet });
                }
            }
            catch (Exception ex)
            {
                return this.Json(new { resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = ex.Message == null ? ex.InnerException.Message : ex.Message, title = Infrastructure.SystemEnumList.Title.Space.GetDescription(), JsonRequestBehavior.DenyGet });
            }
        }

        /// <summary>
        /// Deletes the Space.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Delete Individual</returns>
        [ActionName(Actions.DeleteSpace)]
        [HttpPost]
        [PageAccessAttribute(PermissionName = Constants.ACTION_DELETE, ActionName = Actions.Space)]
        public ActionResult DeleteSpace(int id = 0)
        {
            try
            {
                int status = this.masterDataBL.DeleteSpace(id);
                if (status == 0)
                {
                    return this.Json(new { success = true, resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.DeleteMessage.SetArguments(General.Space), title = Infrastructure.SystemEnumList.Title.Space.GetDescription(), JsonRequestBehavior.AllowGet });
                }
                else
                {
                    return this.Json(new { success = false, resultData = status, status = SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.DeleteErrorMessage.SetArguments(General.Space), title = Infrastructure.SystemEnumList.Title.Space.GetDescription(), JsonRequestBehavior.AllowGet });
                }
            }
            catch (Exception ex)
            {
                return this.Json(new { success = false, resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = ex.Message == null ? ex.InnerException.Message : ex.Message, title = Infrastructure.SystemEnumList.Title.Space.GetDescription(), JsonRequestBehavior.AllowGet });
            }
        }

        /// <summary>
        /// ChangeStatus
        /// </summary>
        /// <param name="status">The Status</param>
        /// <param name="id">The identifier.</param>
        /// <returns>Manage Individual Space View</returns>
        [HttpPost]
        [ActionName(Actions.ChangeSpaceStatus)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Space)]
        public JsonResult ChangeSpaceStatus(bool status, int id = 0)
        {
            Space model = new Space();
            model.ID = id;
            if (id > 0)
            {
                model = this.masterDataBL.GetSpaceList(model).FirstOrDefault();
            }

            model.Active = status;
            model.ModifiedBy = ProjectSession.UserId;
            model.ModifiedDate = DateTime.Now;

            int result = this.masterDataBL.SaveSpace(model);
            if (result > 0)
            {
                return this.Json(new { success = true });
            }
            else
            {
                return this.Json(new { success = false, message = Messages.ErrorMessage.SetArguments(General.Space) });
            }
        }
        #endregion

        #region Page

        /// <summary>
        /// View Page
        /// </summary>
        /// <returns>Return View</returns>
        [ActionName(Actions.Pages)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Pages)]
        [HttpGet]
        public ActionResult Pages()
        {
            this.ViewData["CurrentPageAccessRight"] = this.PageAccessRight;
            return this.View(Views.Page);
        }

        /// <summary>
        ///  list of pages with search criteria
        /// </summary>
        /// <param name="requestModel">the requestModel</param>
        /// <param name="searchdata">Search String</param>
        /// <returns>List of Pages</returns>
        [HttpPost]
        [ActionName(Actions.Pages)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Pages)]
        [NoAntiForgeryCheck]
        public JsonResult Pages([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, string searchdata = "")
        {
            List<Page> pageList;

            Page model = new Page()
            {
                Name = searchdata,
                StartRowIndex = requestModel.Start + 1,
                EndRowIndex = requestModel.Start + requestModel.Length,
                SortDirection = requestModel.OrderDir,
                SortExpression = requestModel.Columns.ElementAt(requestModel.OrderColumn).Data
            };

            pageList = this.masterDataBL.GetPageList(model);
            int totalRecord = 0;
            int filteredRecord = 0;
            if (pageList != null && pageList.Count > 0)
            {
                totalRecord = pageList.FirstOrDefault().TotalRecords;
                filteredRecord = pageList.FirstOrDefault().TotalRecords;
            }

            return this.Json(new DataTablesResponse(requestModel.Draw, pageList, filteredRecord, totalRecord), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Manages the Pages.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Manage Pages</returns>
        [HttpGet]
        [ActionName(Actions.AddEditPages)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Pages)]
        public ActionResult AddEditPages(int id = 0)
        {
            Page model = new Page();
            model.Id = id;
            if (id > 0)
            {
                model = this.masterDataBL.GetPageList(model).FirstOrDefault();
            }
            else
            {
                model.Active = true;
            }

            return this.PartialView(PartialViews.AddEditPage, model);
        }

        /// <summary>
        /// Manages the Pages.
        /// </summary>
        /// <param name="page">The Page.</param>
        /// <returns>Save Page</returns>
        [ActionName(Actions.AddEditPages)]
        [HttpPost]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Pages)]
        public JsonResult AddEditPages(Page page)
        {
            try
            {
                if (this.ModelState.IsValid)
                {
                    int status = this.masterDataBL.SavePage(page);
                    string message = string.Empty;
                    string messageBoxType = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription();
                    if (status > 0)
                    {
                        if (page.Id > 0)
                        {
                            message = Messages.UpdateMessage.SetArguments(General.Page);
                        }
                        else
                        {
                            message = Messages.SaveMessage.SetArguments(General.Page);
                        }
                    }
                    else
                    {
                        messageBoxType = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription();
                        message = Messages.DuplicateMessage.SetArguments(General.Page);
                    }

                    return this.Json(new { resultData = status, status = messageBoxType, message = message, title = Infrastructure.SystemEnumList.Title.Page.GetDescription(), JsonRequestBehavior.DenyGet });
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

                    return this.Json(new { resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = errorMsg, title = Infrastructure.SystemEnumList.Title.Page.GetDescription(), JsonRequestBehavior.DenyGet });
                }
            }
            catch (Exception ex)
            {
                return this.Json(new { resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = ex.Message == null ? ex.InnerException.Message : ex.Message, title = Infrastructure.SystemEnumList.Title.Page.GetDescription(), JsonRequestBehavior.DenyGet });
            }
        }

        /// <summary>
        /// Deletes the page.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Delete page</returns>
        [ActionName(Actions.DeletePages)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_DELETE, ActionName = Actions.Pages)]
        [HttpPost]
        public JsonResult DeletePages(int id = 0)
        {
            try
            {
                int status = this.masterDataBL.DeletePage(id);
                if (status == 0)
                {
                    return this.Json(new { success = true, resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.DeleteMessage.SetArguments(General.Page), title = Infrastructure.SystemEnumList.Title.Page.GetDescription(), JsonRequestBehavior.AllowGet });
                }
                else
                {
                    return this.Json(new { success = false, resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.DeleteErrorMessage.SetArguments(General.Page), title = Infrastructure.SystemEnumList.Title.Page.GetDescription(), JsonRequestBehavior.AllowGet });
                }
            }
            catch (Exception ex)
            {
                return this.Json(new { success = false, resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = ex.Message == null ? ex.InnerException.Message : ex.Message, title = Infrastructure.SystemEnumList.Title.Page.GetDescription(), JsonRequestBehavior.AllowGet });
            }
        }

        /// <summary>
        /// ChangeStatus
        /// </summary>
        /// <param name="status">The Status</param>
        /// <param name="id">The identifier.</param>
        /// <returns>Manage Individual Page View</returns>
        [HttpPost]
        [ActionName(Actions.ChangePageStatus)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Pages)]
        public JsonResult ChangePageStatus(bool status, int id = 0)
        {
            Page model = new Page();
            model.Id = id;
            if (id > 0)
            {
                model = this.masterDataBL.GetPageList(model).FirstOrDefault();
            }

            model.Active = status;
            model.ModifiedBy = ProjectSession.UserId;
            model.ModifiedDate = DateTime.Now;

            int result = this.masterDataBL.SavePage(model);
            if (result > 0)
            {
                return this.Json(new { success = true });
            }
            else
            {
                return this.Json(new { success = false, message = Messages.ErrorMessage.SetArguments(General.Page) });
            }
        }

        #endregion

        #region BookLocations

        /// <summary>
        /// View Book Location
        /// </summary>
        /// <returns>Return View</returns>
        [ActionName(Actions.BookLocation)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.BookLocation)]
        public ActionResult BookLocation()
        {
            this.ViewData["CurrentPageAccessRight"] = this.PageAccessRight;
            return this.View(Views.BookLocation);
        }

        /// <summary>
        ///  list of Book Location with search criteria
        /// </summary>
        /// <param name="requestModel">model</param>
        /// <param name="searchData">search</param>
        /// <returns>List of BookLocation</returns>
        [HttpPost]
        [ActionName(Actions.BookLocation)]
        [NoAntiForgeryCheck]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.BookLocation)]
        public JsonResult BookLocation([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, string searchData = "")
        {
            List<BookLocation> bookLocationList;
            BookLocation model = new BookLocation()
            {
                Name = searchData,
                StartRowIndex = requestModel.Start + 1,
                EndRowIndex = requestModel.Start + requestModel.Length,
                SortDirection = requestModel.OrderDir,
                SortExpression = requestModel.Columns.ElementAt(requestModel.OrderColumn).Data
            };

            bookLocationList = this.masterDataBL.GetLocationList(model);
            int totalRecord = 0;
            int filteredRecord = 0;
            if (bookLocationList != null && bookLocationList.Count > 0)
            {
                totalRecord = bookLocationList.FirstOrDefault().TotalRecords;
                filteredRecord = bookLocationList.FirstOrDefault().TotalRecords;
            }

            return this.Json(new DataTablesResponse(requestModel.Draw, bookLocationList, filteredRecord, totalRecord), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Manage Book Location
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>Partial view</returns>
        [ActionName(Actions.AddEditBookLocation)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.BookLocation)]
        public ActionResult AddEditBookLocation(int id = 0)
        {
            BookLocation model = new BookLocation();
            model.ID = id;
            if (id > 0)
            {
                model = this.masterDataBL.GetLocationList(model).FirstOrDefault();
            }
            else
            {
                model.Active = true;
            }

            return this.PartialView(PartialViews.AddEditBookLocation, model);
        }

        /// <summary>
        /// Manage Book Location
        /// </summary>
        /// <param name="bookLocation">bookLocation</param>
        /// <returns>Json</returns>
        [HttpPost]
        [ActionName(Actions.AddEditBookLocation)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.BookLocation)]
        public JsonResult AddEditBookLocation(BookLocation bookLocation)
        {
            try
            {
                if (this.ModelState.IsValid)
                {
                    int status = this.masterDataBL.SaveBookLocation(bookLocation);
                    string message = string.Empty;
                    string messageBoxType = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription();
                    if (status > 0)
                    {
                        if (bookLocation.ID > 0)
                        {
                            message = Messages.UpdateMessage.SetArguments(General.BookLocation);
                        }
                        else
                        {
                            message = Messages.SaveMessage.SetArguments(General.BookLocation);
                        }
                    }
                    else
                    {
                        messageBoxType = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription();
                        message = Messages.DuplicateMessage.SetArguments(General.BookLocation);
                    }

                    return this.Json(new { resultData = status, status = messageBoxType, message = message, title = Infrastructure.SystemEnumList.Title.BookLocation.GetDescription(), JsonRequestBehavior.DenyGet });
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

                    return this.Json(new { resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = errorMsg, title = Infrastructure.SystemEnumList.Title.BookLocation.GetDescription(), JsonRequestBehavior.DenyGet });
                }
            }
            catch (Exception ex)
            {
                return this.Json(new { resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = ex.Message == null ? ex.InnerException.Message : ex.Message, title = Infrastructure.SystemEnumList.Title.BookLocation.GetDescription(), JsonRequestBehavior.DenyGet });
            }
        }

        /// <summary>
        /// Deletes the BookLocation.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Delete Individual BookLocation</returns>
        [HttpPost]
        [ActionName(Actions.DeleteBookLocation)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_DELETE, ActionName = Actions.BookLocation)]
        public JsonResult DeleteBookLocation(int id = 0)
        {
            try
            {
                int status = this.masterDataBL.DeleteBookLocation(id);
                if (status == 0)
                {
                    return this.Json(new { resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.DeleteMessage.SetArguments(General.BookLocation), title = Infrastructure.SystemEnumList.Title.BookLocation.GetDescription(), JsonRequestBehavior.AllowGet });
                }
                else
                {
                    return this.Json(new { resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.DeleteErrorMessage.SetArguments(General.BookLocation), title = Infrastructure.SystemEnumList.Title.BookLocation.GetDescription(), JsonRequestBehavior.AllowGet });
                }
            }
            catch (Exception ex)
            {
                return this.Json(new { resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = ex.Message == null ? ex.InnerException.Message : ex.Message, title = Infrastructure.SystemEnumList.Title.BookLocation.GetDescription(), JsonRequestBehavior.AllowGet });
            }
        }

        /// <summary>
        /// ChangeStatus
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Manage Individual Location View</returns>
        [HttpPost]
        [ActionName(Actions.ChangeLocationStatus)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.BookLocation)]
        public JsonResult ChangeLocationStatus(int id = 0)
        {
            BookLocation model = new BookLocation();
            model.ID = id;
            if (id > 0)
            {
                model = this.masterDataBL.GetLocationList(model).FirstOrDefault();
            }

            if (model.Active == true)
            {
                model.Active = false;
            }
            else
            {
                model.Active = true;
            }

            int result = this.masterDataBL.SaveBookLocation(model);
            if (result > 0)
            {
                return this.Json(new { success = true });
            }
            else
            {
                return this.Json(new { success = false, message = Messages.ErrorMessage.SetArguments(General.BookLocation) });
            }
        }

        #endregion

    }
}