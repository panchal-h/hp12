// <copyright file="BookController.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
namespace SmartLibrary.Admin.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text.RegularExpressions;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Mvc;
    using DataTables.Mvc;
    using EmailServices;
    using Infrastructure;
    using Infrastructure.Code;
    using Infrastructure.Filters;
    using Models;
    using OfficeOpenXml;
    using Pages;
    using Resources;
    using Services;
    using SmartLibrary.Models;
    using static Infrastructure.SystemEnumList;

    /// <summary>
    /// BookController
    /// </summary>
    public class BookController : BaseController
    {
        private BookDataBL bookDataBL;
        private CommonBL commonBL;
        private MasterDataBL masterDataBL;
        private StringWriter myWriter = new StringWriter();
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BookController"/> class.
        /// BookController
        /// </summary>
        public BookController()
        {
            if (this.bookDataBL == null)
            {
                this.bookDataBL = new BookDataBL();
            }

            if (this.commonBL == null)
            {
                this.commonBL = new CommonBL();
            }

            if (this.masterDataBL == null)
            {
                this.masterDataBL = new MasterDataBL();
            }
        }

        #endregion Constructor

        /// <summary>
        /// Books list.
        /// </summary>
        /// <returns>List of Books</returns>
        [ActionName(Actions.BookList)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Book)]
        public ActionResult BookList()
        {
            this.ViewData["CurrentPageAccessRight"] = this.PageAccessRight;

            return this.View(Views.BookList);
        }

        /// <summary>
        ///  list of Books with search criteria
        /// </summary>
        /// <param name="requestModel">the requestModel</param>
        /// <param name="genre">the genre</param>
        /// <param name="sector">the sector</param>
        /// <param name="location">the location</param>
        /// <param name="searchdata">search</param>
        /// <param name="active">active</param>
        /// <returns>List of Book</returns>
        [HttpPost]
        [ActionName(Actions.BookList)]
        [NoAntiForgeryCheck]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Book)]
        public JsonResult BookList([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, string genre = null, string sector = null, string location = null, string searchdata = "", int active = 1)
        {
            List<Book> bookList = new List<Book>();

            Book model = new Book()
            {
                BookName = searchdata,
                Authors = searchdata,
                StartRowIndex = requestModel.Start + 1,
                EndRowIndex = requestModel.Start + requestModel.Length,
                SortDirection = requestModel.OrderDir,
                SortExpression = requestModel.Columns.ElementAt(requestModel.OrderColumn).Data,
                Active = Convert.ToBoolean(active)
            };
            if (!string.IsNullOrEmpty(genre))
            {
                model.StrBookGenre = genre;
            }

            if (!string.IsNullOrEmpty(sector))
            {
                model.StrBookSector = sector;
            }

            if (!string.IsNullOrEmpty(location))
            {
                model.StrBookLocation = location;
            }

            bookList = this.bookDataBL.Search<Book>(model);
            int totalRecord = 0;
            int filteredRecord = 0;
            if (bookList != null && bookList.Count > 0)
            {
                totalRecord = bookList.FirstOrDefault().TotalRecords;
                filteredRecord = bookList.FirstOrDefault().TotalRecords;
            }

            return this.Json(new DataTablesResponse(requestModel.Draw, bookList, filteredRecord, totalRecord), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Manages the Book.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Manage Individual Book</returns>
        [HttpGet]
        [ActionName(Actions.AddEditBook)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Book)]
        public ActionResult AddEditBook(int id = 0)
        {
            Book model = new Book() { ID = id };
            if (id > 0)
            {
                model = this.bookDataBL.Search(model).FirstOrDefault();
            }

            return this.PartialView(PartialViews.ManageBook, model);
        }

        /// <summary>
        /// Manages the Book.
        /// </summary>
        /// <param name="book">The Book.</param>
        /// <param name="image">Image base 64 string.</param>
        /// <param name="isImageUpdated">isImageUpdated</param>
        /// <returns>Save Book</returns>
        [HttpPost]
        [ActionName(Actions.AddEditBook)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Book)]
        public JsonResult AddEditBook(Book book, string image, bool isImageUpdated)
        {
            try
            {
                if (this.ModelState.IsValid && (isImageUpdated || !string.IsNullOrEmpty(book.ImagePath)))
                {
                    string oldImagePath = string.Empty;
                    if (isImageUpdated)
                    {
                        oldImagePath = book.ImagePath.String();
                        book.ImagePath = this.SaveImage(book.ImagePath, image);
                    }

                    int status = this.bookDataBL.SaveBook(book);
                    string message = string.Empty;
                    string messageBoxType = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription();
                    if (status > 0)
                    {
                        if (isImageUpdated)
                        {
                            this.MoveImage(book.ImagePath, oldImagePath);
                        }

                        if (book.ID > 0)
                        {
                            message = Messages.UpdateMessage.SetArguments(General.Book);
                        }
                        else
                        {
                            message = Messages.SaveMessage.SetArguments(General.Book);
                        }
                    }
                    else
                    {
                        if (isImageUpdated)
                        {
                            this.DeleteImageFromPath(book.ImagePath, ProjectConfiguration.ApplicationRootPath + ProjectConfiguration.BookImagesTempPath);
                            this.DeleteImageFromPath("s-" + book.ImagePath, ProjectConfiguration.ApplicationRootPath + ProjectConfiguration.BookImagesTempPath);
                        }

                        if (status == -2)
                        {
                            messageBoxType = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription();
                            message = Messages.DuplicateMessage.SetArguments(General.Book);
                        }
                        else if (status == -3)
                        {
                            Book model = this.bookDataBL.Search(new Book { ID = book.ID }).FirstOrDefault();
                            if (model == null)
                            {
                                message = Messages.ErrorMessage.SetArguments(General.Book);
                            }
                            else
                            {
                                message = Messages.InvalidBookTotalQuantityMessage.SetArguments(model.TotalQuantity - model.CurrentQuantity, Resources.Books.Quantity);
                            }

                            messageBoxType = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription();
                        }
                        else if (status == -4)
                        {
                            message = Messages.ErrorMessage.SetArguments(General.Book);
                            messageBoxType = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription();
                        }
                        else
                        {
                            message = Messages.NoInactiveMessage.SetArguments(General.Book);
                            messageBoxType = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription();
                        }
                    }

                    return this.Json(new { resultData = status, status = messageBoxType, message = message, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.DenyGet });
                }
                else
                {
                    string errorMsg = string.Empty;
                    if (!isImageUpdated && string.IsNullOrEmpty(book.ImagePath))
                    {
                        errorMsg = Resources.Messages.RequiredBookCoverImage;
                    }

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

                    return this.Json(new { resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = errorMsg, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.DenyGet });
                }
            }
            catch (Exception ex)
            {
                return this.Json(new { resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = ex.Message == null ? ex.InnerException.Message : ex.Message, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.DenyGet });
            }
        }

        /// <summary>
        /// Manages the Book.
        /// </summary>
        /// <param name="isbn">isbn</param>
        /// <returns>Save Book</returns>
        [HttpGet]
        [ActionName(Actions.GetBookByISBN)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Book)]
        public JsonResult GetBookByISBN(string isbn)
        {
            string errorMsg = string.Empty;
            BookModel bookModel = null;
            try
            {
                if (this.ModelState.IsValid)
                {
                    IISBNService iISBNService = ISBNFactory.GetISBNServiceProvider();
                    bookModel = iISBNService.GetBookDetailFromISBN(isbn);
                    errorMsg = bookModel == null ? Resources.Messages.NoRecordFound : Resources.Messages.ISBNFetchSuccess;
                }
                else
                {
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
                }
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message == null ? ex.InnerException.Message : ex.Message;
            }

            return this.Json(
                new
                {
                    bookModel = bookModel,
                    status = bookModel == null ? SystemEnumList.MessageBoxType.Error.GetDescription() : SystemEnumList.MessageBoxType.Success.GetDescription(),
                    message = errorMsg,
                    title = string.Empty,
                }, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Book Detail Side Bar
        /// </summary>
        /// <param name="bookId">bookId.</param>
        /// <param name="statusId"> statusId.</param>      
        /// <returns>Book Details</returns>
        [HttpGet]
        [ActionName(Actions.BookDetailSideBar)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Book)]
        public ActionResult BookDetailSideBar(int bookId = 0, int? statusId = null)
        {
            this.ViewData["CurrentPageAccessRight"] = this.PageAccessRight;
            Book retmodel = new Book();
            DateTime today = DateTime.Today;
            if (bookId > 0)
            {
                retmodel.ID = bookId;
                retmodel = this.commonBL.GetBookDetailsComplete(bookId);
                retmodel.BorrowedBookList = this.commonBL.GetBookBorrowedDetails(bookId, statusId);
                retmodel.ActiveBorrowers = this.commonBL.GetBookBorrowedDetails(bookId, SystemEnumList.BorrowBookStatus.Approved.GetHashCode()).Where(x => x.PickUpDate.ToDate().Date <= today).ToList();
                retmodel.Description = HttpUtility.HtmlDecode(retmodel.Description);
                retmodel.IdEncrypted = EncryptionDecryption.EncryptByTripleDES(retmodel.ID.ToString());
                retmodel.CurrentBookStatus = this.commonBL.GetCurrentBookStatus(bookId, SystemEnumList.ActiveStatus.Active.GetHashCode());
                retmodel.BookPendingEntry = this.commonBL.CheckBookPendingEntry(bookId, ProjectSession.CustomerId);
            }

            return this.PartialView(PartialViews.BookDetailSideBar, retmodel);
        }

        /// <summary>
        /// Book Detail View
        /// </summary>
        /// <param name="bookId">bookId.</param>       
        /// <param name="q">query string parameter.</param>       
        /// <returns>Book Details</returns>
        [HttpGet]
        [ActionName(Actions.BookDetailView)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Book)]
        public ActionResult BookDetailView(string bookId = null, string q = null)
        {
            this.ViewData["CurrentPageAccessRight"] = this.PageAccessRight;
            Book retmodel = new Book();
            string returnUrl = string.Empty;
            if (this.Request.UrlReferrer != null)
            {
                returnUrl = this.Request.UrlReferrer.AbsoluteUri;
            }
            else
            {
                returnUrl = this.HttpContext.Request.Url.OriginalString.Replace(this.HttpContext.Request.Url.PathAndQuery, string.Empty);
                if (this.HttpContext.Request.ApplicationPath.Length > 2)
                {
                    returnUrl = returnUrl + this.HttpContext.Request.ApplicationPath;
                }

                returnUrl = returnUrl + "/" + Controllers.Book + "/" + Actions.BookList;
            }

            string decryptedVal = EncryptionDecryption.DecryptByTripleDES(bookId);
            this.ViewBag.query = EncryptionDecryption.DecryptByTripleDES(q);
            if (decryptedVal != string.Empty)
            {
                int id = decryptedVal.ToInteger();
                retmodel = this.commonBL.GetBookDetailsComplete(id);
                retmodel.IdEncrypted = bookId;
                retmodel.CurrentBookStatus = this.commonBL.GetCurrentBookStatus(id, SystemEnumList.ActiveStatus.Active.GetHashCode());
                retmodel.BookPendingEntry = this.commonBL.CheckBookPendingEntry(id, ProjectSession.CustomerId);
            }
            else
            {
                return this.Redirect(returnUrl);
            }

            retmodel.ReturnUrl = returnUrl;
            retmodel.Description = HttpUtility.HtmlDecode(retmodel.Description);
            this.ViewBag.ActiveList = Enum.GetValues(typeof(ActiveStatus)).Cast<ActiveStatus>().Select(x => new SelectListItem { Text = x.ToString(), Value = ((int)x).ToString() }).ToList();
            return this.View(retmodel);
        }

        /// <summary>
        /// Book Detail View
        /// </summary>
        /// <param name="bookId">bookId.</param>       
        /// <returns>Book Details</returns>
        [HttpGet]
        [ActionName(Actions.BookDetailViewReload)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Book)]
        public ActionResult BookDetailViewReload(string bookId = null)
        {
            this.ViewData["CurrentPageAccessRight"] = this.PageAccessRight;
            Book retmodel = new Book();
            string returnUrl = string.Empty;
            if (this.Request.UrlReferrer != null)
            {
                returnUrl = this.Request.UrlReferrer.AbsoluteUri;
            }
            else
            {
                returnUrl = this.HttpContext.Request.Url.OriginalString.Replace(this.HttpContext.Request.Url.PathAndQuery, string.Empty);
                if (this.HttpContext.Request.ApplicationPath.Length > 2)
                {
                    returnUrl = returnUrl + this.HttpContext.Request.ApplicationPath;
                }

                returnUrl = returnUrl + "/" + Controllers.Book + "/" + Actions.BookList;
            }

            string decryptedVal = EncryptionDecryption.DecryptByTripleDES(bookId);
            if (decryptedVal != string.Empty)
            {
                int id = decryptedVal.ToInteger();
                retmodel = this.commonBL.GetBookDetailsComplete(id, ProjectSession.CustomerId);
                retmodel.Description = HttpUtility.HtmlDecode(retmodel.Description);
                retmodel.CurrentBookStatus = this.commonBL.GetCurrentBookStatus(id, SystemEnumList.ActiveStatus.Active.GetHashCode());
                retmodel.BookPendingEntry = this.commonBL.CheckBookPendingEntry(id, ProjectSession.CustomerId);
                retmodel.BorrowedBookList = this.commonBL.GetBookBorrowedDetails(id, null);
            }
            else
            {
                return this.Redirect(returnUrl);
            }

            return this.PartialView(PartialViews.BookDetailViewReload, retmodel);
        }

        /// <summary>
        /// Borrow Book
        /// </summary>
        /// <param name="pickUpDate">pickUpDate</param>
        /// <param name="bookId">the book Id</param>
        /// <param name="period">period</param>
        /// <param name="customerId">customerId</param>
        /// <returns>the result</returns>
        [HttpPost]
        [ActionName(Actions.BorrowBook)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Book)]
        public JsonResult BorrowBook(DateTime pickUpDate, int bookId = 0, string period = null, int customerId = 0)
        {
            try
            {
                int bookperiodValue = 0;

                if (period == SystemEnumList.BookPeriod.OneWeek.GetDescription())
                {
                    bookperiodValue = SystemEnumList.BookPeriod.OneWeek.GetHashCode();
                }
                else if (period == SystemEnumList.BookPeriod.TwoWeek.GetDescription())
                {
                    bookperiodValue = SystemEnumList.BookPeriod.TwoWeek.GetHashCode();
                }
                else
                {
                    bookperiodValue = SystemEnumList.BookPeriod.OneMonth.GetHashCode();
                }

                BorrowedBook model = new BorrowedBook()
                {
                    CustomerId = customerId,
                    BookId = bookId,
                    PickUpDate = pickUpDate,
                    ReturnDate = pickUpDate.AddDays(bookperiodValue),
                    BookPeriod = period,
                    Active = Convert.ToBoolean(SystemEnumList.ActiveStatus.Active.GetHashCode()),
                    CreatedBy = customerId,
                    CreatedDate = DateTime.Now,
                    StatusId = SystemEnumList.BorrowBookStatus.Pending.GetHashCode(),
                    Returned = false,
                    IsCreatedByAdmin = true,
                    CreatedByAdminId = ProjectSession.UserId
                };

                bool isPendingEntry = this.commonBL.CheckBookPendingEntry(bookId, customerId);
                if (!isPendingEntry)
                {
                    int borrowedId = this.bookDataBL.SaveBorrowBook(model);
                    if (borrowedId > 0)
                    {
                        int result = this.commonBL.AcceptCancelBookBorrowRequest(bookId, ProjectSession.UserId, SystemEnumList.BorrowBookStatus.Approved.GetHashCode(), borrowedId, bookperiodValue);
                        if (result > 0)
                        {
                            NotificationFactory.AddNotification(NotificationType.BookBorrowedByAdmin, borrowedId);
                            BorrowedBook borrowModel = this.bookDataBL.GetBookDetail<BorrowedBook>(borrowedId);

                            EmailViewModel emailModel = new EmailViewModel()
                            {
                                Email = borrowModel.BorrowerEmail,
                                Name = borrowModel.CustomerName,
                                BookName = borrowModel.BookName,
                                Author = borrowModel.AuthorName,
                                Date = borrowModel.PickUpDate.ToDate().ToString(ProjectConfiguration.DateFormat, System.Globalization.CultureInfo.InvariantCulture),
                                LanguageId = ConvertTo.ToInteger(ProjectSession.AdminPortalLanguageId)
                            };
                            UserMail.ConfirmBookBorrow(emailModel);
                            return this.Json(new { success = true, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.BorrowBookAddforCustomer, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.DenyGet });
                        }
                        else
                        {
                            if (result == -1)
                            {
                                return this.Json(new { success = false, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.BookNotAvailable, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.DenyGet });
                            }
                            else
                            {
                                return this.Json(new { success = false, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.ErrorApproveRejectBorrowedBook.SetArguments(SystemEnumList.BorrowBookStatus.Approved.GetDescription()), title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.DenyGet });
                            }
                        }
                    }
                    else
                    {
                        return this.Json(new { success = false, message = Messages.BorrowBookError, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), title = Infrastructure.SystemEnumList.Title.Book.GetDescription() });
                    }
                }
                else
                {
                    return this.Json(new { success = false, message = Messages.AlreadyBookBorrowedforCustomer, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), title = Infrastructure.SystemEnumList.Title.Book.GetDescription() });
                }

                return this.Json(new { success = false, message = Messages.BorrowBookError, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), title = Infrastructure.SystemEnumList.Title.Book.GetDescription() });
            }
            catch (Exception ex)
            {
                return this.Json(new { success = false, message = Messages.BorrowBookError, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), title = Infrastructure.SystemEnumList.Title.Book.GetDescription() });
            }
        }

        #region ::BookGrid::

        /// <summary>
        /// View BookGrid
        /// </summary>
        /// <returns>Return GridView</returns>
        [HttpGet]
        [ActionName(Actions.BookGrid)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Book)]
        public ActionResult BookGrid()
        {
            this.ViewData["CurrentPageAccessRight"] = this.PageAccessRight;
            List<Book> bookList = new List<Book>();
            Book model = new Book()
            {
                StartRowIndex = 1,
                EndRowIndex = ProjectConfiguration.PageSizeGrid,
                SortExpression = "ImagePath",
                SortDirection = "desc",
                Active = Convert.ToBoolean(SystemEnumList.ActiveStatus.Active.GetHashCode())
            };
            bookList = this.bookDataBL.Search(model);
            int totalRecord = bookList?.FirstOrDefault()?.TotalRecords ?? 0;
            this.ViewBag.TotalPage = Math.Ceiling((float)totalRecord / 20);

            return this.View(Views.BookGrid, bookList);
        }

        /// <summary>
        ///  list of BookGrid with search criteria
        /// </summary>
        /// <param name="baseModel">model</param>
        /// <param name="genre">the genre</param>
        /// <param name="sector">the sector</param>
        /// <param name="location">the location</param>
        /// <param name="active">active</param>
        /// <returns>List of Books</returns>
        [HttpPost]
        [ActionName(Actions.BookGrid)]
        [NoAntiForgeryCheck]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Book)]
        public ActionResult BookGrid(BaseViewModel baseModel, string genre = null, string sector = null, string location = null, int active = 1)
        {
            List<Book> bookList = new List<Book>();
            Book model = new Book()
            {
                ID = baseModel.Id,
                BookName = baseModel.Searchtext,
                Authors = baseModel.Searchtext,
                Active = Convert.ToBoolean(active),
                StartRowIndex = ((baseModel.CurrentPage - 1) * ProjectConfiguration.PageSizeGrid) + 1,
                EndRowIndex = baseModel.CurrentPage * ProjectConfiguration.PageSizeGrid,
                SortExpression = baseModel.SortExpression,
                SortDirection = baseModel.SortDirection
            };
            if (!string.IsNullOrEmpty(genre))
            {
                model.StrBookGenre = genre;
            }

            if (!string.IsNullOrEmpty(sector))
            {
                model.StrBookSector = sector;
            }

            if (!string.IsNullOrEmpty(location))
            {
                model.StrBookLocation = location;
            }

            bookList = this.bookDataBL.Search(model);

            int totalRecord = 0;
            int filteredRecord = 0;
            if (bookList != null && bookList.Count > 0)
            {
                totalRecord = bookList.FirstOrDefault().TotalRecords;
                filteredRecord = bookList.FirstOrDefault().TotalRecords;
            }

            this.ViewBag.TotalPage = Math.Ceiling((float)totalRecord / ProjectConfiguration.PageSizeGrid);
            return this.PartialView(PartialViews.BookGrid, bookList);
        }

        /// <summary>
        /// ChangeStatus
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Manage Individual Book View</returns>
        [HttpPost]
        [ActionName(Actions.ChangeBookStatus)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Book)]
        public JsonResult ChangeBookStatus(int id = 0)
        {
            Book model = new Book();
            model.ID = id;
            if (id > 0)
            {
                model = this.bookDataBL.Search(model).FirstOrDefault();
            }

            model.Active = !model.Active;

            int result = this.bookDataBL.SaveBook(model);
            if (result > 0)
            {
                return this.Json(new { success = true, status = model.Active });
            }
            else if (result == -1)
            {
                return this.Json(new { resultData = result, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.NoInactiveMessage.SetArguments(General.Books), title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.DenyGet });
            }
            else
            {
                return this.Json(new { success = false, message = Messages.ErrorMessage.SetArguments(General.Books) });
            }
        }

        /// <summary>
        /// Approved/Reject Borrow Book
        /// </summary>
        /// <param name="borrowid">borrowid.</param>
        /// <param name="statusId">statusId.</param>
        /// <param name="bookId">bookId.</param>
        /// <param name="bookperiod">bookperiod.</param>
        /// <returns>Approve/Reject BorrowedBook</returns>
        [HttpPost]
        [ActionName(Actions.ApproveRejectBorrowedBook)]
        [NoAntiForgeryCheck]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Book)]
        public JsonResult ApproveRejectBorrowedBook(int borrowid = 0, int statusId = 2, int bookId = 0, string bookperiod = null)
        {
            string msg = string.Empty;
            try
            {
                int bookperiodValue = 0;

                if (bookperiod == SystemEnumList.BookPeriod.OneWeek.GetDescription())
                {
                    bookperiodValue = SystemEnumList.BookPeriod.OneWeek.GetHashCode();
                }
                else if (bookperiod == SystemEnumList.BookPeriod.TwoWeek.GetDescription())
                {
                    bookperiodValue = SystemEnumList.BookPeriod.TwoWeek.GetHashCode();
                }
                else
                {
                    bookperiodValue = SystemEnumList.BookPeriod.OneMonth.GetHashCode();
                }

                if (statusId == SystemEnumList.BorrowBookStatus.Approved.GetHashCode())
                {
                    msg = SystemEnumList.BorrowBookStatus.Approved.GetDescription();
                }
                else if (statusId == SystemEnumList.BorrowBookStatus.Cancel.GetHashCode())
                {
                    msg = SystemEnumList.BorrowBookStatus.Cancel.GetDescription();
                }
                else if (statusId == SystemEnumList.BorrowBookStatus.Pending.GetHashCode())
                {
                    msg = SystemEnumList.BorrowBookStatus.Pending.GetDescription();
                }

                int result = this.commonBL.AcceptCancelBookBorrowRequest(bookId, ProjectSession.UserId, statusId, borrowid, bookperiodValue);
                if (result > 0)
                {
                    if (statusId == SystemEnumList.BorrowBookStatus.Approved.GetHashCode())
                    {
                        NotificationFactory.AddNotification(NotificationType.BookApprove, borrowid);
                        BorrowedBook borrowModel = this.bookDataBL.GetBookDetail<BorrowedBook>(borrowid);
                        EmailViewModel emailModel = new EmailViewModel()
                        {
                            Email = borrowModel.BorrowerEmail,
                            Name = borrowModel.CustomerName,
                            BookName = borrowModel.BookName,
                            Author = borrowModel.AuthorName,
                            Date = borrowModel.PickUpDate.ToDate().ToString(ProjectConfiguration.DateFormat, System.Globalization.CultureInfo.InvariantCulture),
                            LanguageId = ConvertTo.ToInteger(ProjectSession.AdminPortalLanguageId)
                        };
                        UserMail.ConfirmBookBorrow(emailModel);
                    }
                    else if (statusId == SystemEnumList.BorrowBookStatus.Cancel.GetHashCode())
                    {
                        NotificationFactory.AddNotification(NotificationType.BookCancel, borrowid);
                        BorrowedBook borrowModel = this.bookDataBL.GetBookDetail<BorrowedBook>(borrowid);
                        EmailViewModel emailModel = new EmailViewModel()
                        {
                            Email = borrowModel.BorrowerEmail,
                            Name = borrowModel.CustomerName,
                            BookName = borrowModel.BookName,
                            Author = borrowModel.AuthorName,
                            Date = borrowModel.PickUpDate.ToDate().ToString(ProjectConfiguration.DateFormat, System.Globalization.CultureInfo.InvariantCulture),
                            LanguageId = ConvertTo.ToInteger(ProjectSession.AdminPortalLanguageId)
                        };
                        UserMail.CancelBookBorrow(emailModel);
                    }
                    else if (statusId == SystemEnumList.BorrowBookStatus.Pending.GetHashCode())
                    {
                        NotificationFactory.AddNotification(NotificationType.BookPending, borrowid);
                    }

                    return this.Json(new { success = true, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.ApproveRejectBorrowedBook.SetArguments(msg), title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.AllowGet });
                }
                else
                {
                    if (result == -1)
                    {
                        return this.Json(new { success = false, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.BookNotAvailable, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.AllowGet });
                    }
                    else if (result == -2)
                    {
                        return this.Json(new { success = false, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.ErrorApproveRejectBorrowedBook.SetArguments(msg), title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.AllowGet });
                    }
                    else if (result == -3)
                    {
                        return this.Json(new { success = false, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.CurrentQtyCannotbeMoreThanTotalQuantity.SetArguments(msg), title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.AllowGet });
                    }
                    else if (result == -4)
                    {
                        return this.Json(new { success = false, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.AlreadyBookBorrowedforCustomer.SetArguments(msg), title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.AllowGet });
                    }
                    else if (result == -5)
                    {
                        return this.Json(new { success = false, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.AlreadyBookIsPending.SetArguments(msg), title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.AllowGet });
                    }
                    else
                    {
                        return this.Json(new { success = false, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.ErrorApproveRejectBorrowedBook.SetArguments(msg), title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.AllowGet });
                    }
                }
            }
            catch (Exception ex)
            {
                return this.Json(new { success = false, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.ErrorApproveRejectBorrowedBook.SetArguments(msg), title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.AllowGet });
            }
        }

        /// <summary>
        /// Return  Book
        /// </summary>
        /// <param name="borrowid">borrowid.</param>             
        /// <returns>return Borrowed Book </returns>
        [HttpGet]
        [ActionName(Actions.ReturnBook)]
        [NoAntiForgeryCheck]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Book)]
        public ActionResult ReturnBook(int borrowid = 0)
        {
            BorrowedBook model = new BorrowedBook { ID = borrowid };
            if (borrowid > 0)
            {
                model = this.bookDataBL.Search<BorrowedBook>(model).FirstOrDefault();
            }

            return this.PartialView(PartialViews.ReturnBook, model);
        }

        /// <summary>
        /// Return  Book
        /// </summary>
        /// <param name="returnDate">returnDate.</param>
        /// <param name="borrowid">borrowid.</param>     
        /// <param name="bookId">bookId.</param>
        /// <param name="returnNotes">returnNotes.</param>
        /// <returns>Approve/Reject BorrowedBook</returns>
        [HttpPost]
        [ActionName(Actions.ReturnBook)]
        [NoAntiForgeryCheck]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Book)]
        public JsonResult ReturnBook(DateTime returnDate, int borrowid = 0, int bookId = 0, string returnNotes = null)
        {
            string msg = string.Empty;
            try
            {
                int result = this.commonBL.BookReturn(bookId, ProjectSession.UserId, borrowid, returnNotes, returnDate);
                if (result > 0)
                {
                    NotificationFactory.AddNotification(NotificationType.BookReturn, borrowid);
                    List<BookNotification> bookNotifications = this.masterDataBL.Search<BookNotification>(new BookNotification() { BookId = bookId, IsNotify = true }).ToList();
                    foreach (var bookNotification in bookNotifications)
                    {
                        NotificationFactory.AddNotification(NotificationType.BookAvailable, bookNotification);
                        bookNotification.IsNotify = false;
                        this.masterDataBL.Save<BookNotification>(bookNotification, checkForDuplicate: false);
                        EmailViewModel emailModel = new EmailViewModel()
                        {
                            Email = bookNotification.Email,
                            Name = bookNotification.CustomerName,
                            Author = bookNotification.AuthorName,
                            BookName = bookNotification.BookName,
                            LanguageId = ConvertTo.ToInteger(ProjectSession.AdminPortalLanguageId)
                        };
                        UserMail.NotifyCustomerForBook(emailModel);
                    }

                    return this.Json(new { success = true, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.BookReturnSuccess, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.AllowGet });
                }
                else
                {
                    if (result == -1)
                    {
                        return this.Json(new { success = false, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.BookReturnError, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.AllowGet });
                    }
                    else if (result == -2)
                    {
                        return this.Json(new { success = false, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.CurrentQtyCannotbeMoreThanTotalQuantity, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.AllowGet });
                    }
                    else if (result == -3)
                    {
                        return this.Json(new { success = false, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.BookInvalidCurrentQuantity, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.AllowGet });
                    }
                    else
                    {
                        return this.Json(new { success = false, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.BookReturnError, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.AllowGet });
                    }
                }
            }
            catch (Exception ex)
            {
                return this.Json(new { success = false, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.BookReturnError, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.AllowGet });
            }
        }

        /// <summary>
        ///  list of BorrowerDetails with search criteria
        /// </summary>
        /// <param name="requestModel">the requestModel</param>
        /// <param name="searchText">searchText</param>
        /// <param name="id">id</param>
        /// <param name="active">active</param>
        /// <param name="status">status</param>
        /// <returns>List of Customer</returns>
        [HttpPost]
        [ActionName(Actions.BorrowerDetails)]
        [NoAntiForgeryCheck]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Book)]
        public JsonResult BorrowerDetails([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, string searchText = "", int id = 0, int active = 1, int? status = null)
        {
            List<BorrowedBook> borrowers = new List<BorrowedBook>();
            borrowers = this.commonBL.GetBookBorrowedDetails(id, status, active, requestModel.Start + 1, requestModel.Start + requestModel.Length, requestModel.Columns.ElementAt(requestModel.OrderColumn).Data, requestModel.OrderDir, searchText);
            int totalRecord = 0;
            int filteredRecord = 0;
            if (borrowers != null && borrowers.Count > 0)
            {
                totalRecord = borrowers.FirstOrDefault().TotalRecords;
                filteredRecord = borrowers.FirstOrDefault().TotalRecords;
            }

            return this.Json(new DataTablesResponse(requestModel.Draw, borrowers, filteredRecord, totalRecord), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        ///  list of Comments with search criteria
        /// </summary>
        /// <param name="requestModel">the requestModel</param>
        /// <param name="searchText">searchText</param>
        /// <param name="bookid">bookid</param>    
        /// <returns>List of Comments</returns>
        [HttpPost]
        [ActionName(Actions.BookComments)]
        [NoAntiForgeryCheck]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Book)]
        public JsonResult BookComments([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, string searchText = "", int bookid = 0)
        {
            List<BookDiscussion> comments = new List<BookDiscussion>();
            comments = this.commonBL.GetBookComments(bookid, searchText, requestModel.Start + 1, requestModel.Start + requestModel.Length, requestModel.Columns.ElementAt(requestModel.OrderColumn).Data, requestModel.OrderDir);
            int totalRecord = 0;
            int filteredRecord = 0;
            if (comments != null && comments.Count > 0)
            {
                totalRecord = comments.FirstOrDefault().TotalRecords;
                filteredRecord = comments.FirstOrDefault().TotalRecords;
            }

            return this.Json(new DataTablesResponse(requestModel.Draw, comments, filteredRecord, totalRecord), JsonRequestBehavior.AllowGet);
        }

        #endregion

        /// <summary>
        ///  Export to excel 
        /// </summary>
        /// <param name="genre">genre</param>
        /// <param name="sector">sector</param>
        /// <param name="location">location</param>
        /// <param name="searchdata">search</param>
        /// <returns>List of Customer export to excel</returns>
        [HttpGet]
        [ActionName(Actions.BookExportToExcel)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_VIEW, ActionName = Actions.Book)]
        public ActionResult BookExportToExcel(string genre = null, string sector = null, string location = null, string searchdata = "")
        {
            DataTable books = new DataTable();

            Book model = new Book()
            {
                BookName = searchdata,
                Authors = searchdata,
            };
            if (!string.IsNullOrEmpty(genre))
            {
                model.StrBookGenre = genre;
            }

            if (!string.IsNullOrEmpty(sector))
            {
                model.StrBookSector = sector;
            }

            if (!string.IsNullOrEmpty(location))
            {
                model.StrBookLocation = location;
            }

            var bookList = this.bookDataBL.Search<Book>(model).Select(x => new
            {
                x.BookName,
                x.ISBNNo,
                x.Description,
                x.Authors,
                x.BookGenre,
                x.BookLocation,
                x.BookSector,
                x.Active,
            });

            books = ConvertTo.ToDataTable(bookList.ToList());
            books.Columns.Add("strActive", typeof(string));

            foreach (DataRow row in books?.Rows)
            {
                bool active = row["Active"].ToBoolean();

                if (active)
                {
                    row["strActive"] = "Active";
                }
                else
                {
                    row["strActive"] = "InActive";
                }
            }

            books.Columns.Remove("Active");
            byte[] bytes;
            string filename;
            try
            {
                ////this.Response.Clear();
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet workSheet = package.Workbook.Worksheets.Add("Books");

                    workSheet.Cells["A1"].LoadFromDataTable(books, true);
                    var reg = books.Rows.Count;
                    workSheet.Cells["A1"].Value = "BookName";
                    workSheet.Cells["B1"].Value = "ISBNNo";
                    workSheet.Cells["C1"].Value = "Description";
                    workSheet.Cells["D1"].Value = "Authors";
                    workSheet.Cells["E1"].Value = "BookGenre";
                    workSheet.Cells["F1"].Value = "BookLocation";
                    workSheet.Cells["G1"].Value = "Active";

                    filename = "Book_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".xlsx";
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

        /// <summary>
        ///  Mail to Overdue book borrow
        /// </summary>
        /// <param name="borrowerId">borrower Id</param>
        /// <returns>the result</returns>
        [HttpGet]
        [ActionName(Actions.OverDueMail)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_ADDUPDATE, ActionName = Actions.Book)]
        public JsonResult OverDueMail(int borrowerId)
        {
            BorrowedBook borrowModel = this.bookDataBL.GetBookDetail<BorrowedBook>(borrowerId);
            EmailViewModel emailModel = new EmailViewModel()
            {
                Email = borrowModel.BorrowerEmail,
                Name = borrowModel.CustomerName,
                BookName = borrowModel.BookName,
                Author = borrowModel.AuthorName,
                LanguageId = ConvertTo.ToInteger(ProjectSession.AdminPortalLanguageId),
                IsFromJob = false,
                Date = borrowModel.ReturnDate.ToDate().ToString(ProjectConfiguration.DateFormat, System.Globalization.CultureInfo.InvariantCulture),
            };
            if (UserMail.OverdueBookReminder(emailModel))
            {
                return this.Json(new { success = true, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.EmailSent, title = Infrastructure.SystemEnumList.Title.Book.GetDescription() }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return this.Json(new { success = false, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.EmailSentFailed, title = Infrastructure.SystemEnumList.Title.Book.GetDescription() }, JsonRequestBehavior.AllowGet);
            }
        }

        /// <summary>
        /// Deletes the Comment.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Delete Individual</returns>
        [ActionName(Actions.DeleteComments)]
        [PageAccessAttribute(PermissionName = Constants.ACTION_DELETE, ActionName = Actions.Book)]
        [HttpPost]
        public JsonResult DeleteComments(int id = 0)
        {
            try
            {
                int status = this.bookDataBL.DeleteBookComments(id);
                if (status == 0)
                {
                    return this.Json(new { success = true, resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.DeleteMessage.SetArguments(General.Comment), title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.AllowGet });
                }
                else
                {
                    return this.Json(new { success = false, resultData = status, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.DeleteErrorMessage.SetArguments(General.Comment), title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.AllowGet });
                }
            }
            catch (Exception ex)
            {
                return this.Json(new { success = false, resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = ex.Message == null ? ex.InnerException.Message : ex.Message, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.AllowGet });
            }
        }

        /// <summary>
        /// Save Image
        /// </summary>
        /// <param name="imagePath">Image Path</param>
        /// <param name="image">Image</param>
        /// <returns>Image String</returns>
        private string SaveImage(string imagePath, string image)
        {
            // Fetch image name without extension.
            imagePath = string.IsNullOrEmpty(imagePath) || string.IsNullOrEmpty(imagePath.Split('.')[0]) ? Guid.NewGuid().ToString("n") : imagePath.Split('.')[0];
            string imageType = string.Empty;
            string bookImageTempDirectory = ProjectConfiguration.ApplicationRootPath + ProjectConfiguration.BookImagesTempPath;

            // Match with Base64 Image Pattern and fetch image extension and image string.
            Regex base64ImagePattern = new Regex(@"^data\:(?<type>image\/(png|tiff|tif|mtiff|jpg|jpeg|gif));base64,(?<data>[A-Z0-9\+\/\=]+)$", RegexOptions.Compiled | RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);
            Match match = base64ImagePattern.Match(image);
            if (match.Success)
            {
                image = match.Groups["data"].Value;
                imageType = "." + match.Groups["type"].Value.Split('/')[1];
            }
            else
            {
                var imageParts = image.Split(new string[] { ";base64," }, StringSplitOptions.None);
                image = imageParts.Last();
                imageType = "." + (imageParts.Length == 2 ? imageParts[0].Split('/')[1] : SystemEnumList.FileExtension.Png.ToString());
            }

            // Check for BookImages directory exists or not, if not then create.
            if (!System.IO.Directory.Exists(bookImageTempDirectory))
            {
                System.IO.Directory.CreateDirectory(bookImageTempDirectory);
            }

            // Delete image which might have same name but different extension.
            this.DeleteImageFromPath(imagePath, bookImageTempDirectory);
            this.DeleteImageFromPath("s-" + imagePath, bookImageTempDirectory);
            ////var files = Directory.GetFiles(bookImageTempDirectory, imagePath + ".*").ToList();
            ////files.AddRange(Directory.GetFiles(bookImageTempDirectory, imagePath + "-s.*").ToList());
            ////foreach (string imageName in files)
            ////{
            ////    System.IO.File.Delete(Path.Combine(bookImageTempDirectory, imageName));
            ////}

            imagePath = Guid.NewGuid().ToString("n");
            Image imageObject;
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(image)))
            {
                imageObject = Image.FromStream(ms);
            }

            // System.IO.File.WriteAllBytes(Path.Combine(bookImageDirectory, imagePath + imageType), Convert.FromBase64String(image));
            ((Image)new Bitmap(imageObject)).Save(Path.Combine(bookImageTempDirectory, imagePath + imageType));
            if (imageObject.Size.Width > 150 && imageObject.Size.Height > 200)
            {
                ((Image)new Bitmap(imageObject, new Size(129, 154))).Save(Path.Combine(bookImageTempDirectory, "s-" + imagePath + imageType));
            }
            else
            {
                ((Image)new Bitmap(imageObject)).Save(Path.Combine(bookImageTempDirectory, "s-" + imagePath + imageType));
            }

            return imagePath + imageType;
        }

        /// <summary>
        /// Move Image
        /// </summary>
        /// <param name="imagePath">Image Path</param>
        /// <param name="oldImagePath">Old Image Path</param>
        private void MoveImage(string imagePath, string oldImagePath)
        {
            string bookImageTempDirectory = ProjectConfiguration.ApplicationRootPath + ProjectConfiguration.BookImagesTempPath;
            string bookImageDirectory = ProjectConfiguration.ApplicationRootPath + ProjectConfiguration.BookImagesPath;

            // Delete old image.
            if (System.IO.Directory.Exists(bookImageDirectory) && !string.IsNullOrEmpty(oldImagePath))
            {
                this.DeleteImageFromPath(oldImagePath, bookImageDirectory);
                this.DeleteImageFromPath("s-" + oldImagePath, bookImageDirectory);
            }

            // Check for BookImages directory exists or not, if not then create.
            if (System.IO.Directory.Exists(bookImageTempDirectory))
            {
                // Check for BookImages directory exists or not, if not then create.
                if (!System.IO.Directory.Exists(bookImageDirectory))
                {
                    System.IO.Directory.CreateDirectory(bookImageDirectory);
                }

                var imagesPath = new string[] { imagePath, "s-" + imagePath };
                imagesPath.ToList().ForEach(image =>
                {
                    if (System.IO.File.Exists(Path.Combine(bookImageTempDirectory, image)))
                    {
                        System.IO.File.Move(Path.Combine(bookImageTempDirectory, image), Path.Combine(bookImageDirectory, image));
                    }
                });
            }
        }

        /// <summary>
        /// Delete an Image from path
        /// </summary>
        /// <param name="imageName">Image Name</param>
        /// <param name="path">Path</param>
        private void DeleteImageFromPath(string imageName, string path)
        {
            var files = Directory.GetFiles(path, imageName.Split('.')[0] + ".*").ToList();
            foreach (string image in files)
            {
                System.IO.File.Delete(Path.Combine(path, image));
            }
        }
    }
}