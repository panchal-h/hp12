// <copyright file="BookController.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Site.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
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
    using static Infrastructure.SystemEnumList;

    /// <summary>
    /// BookController
    /// </summary>
    public class BookController : BaseController
    {
        private BookDataBL bookDataBL;
        private CommonBL commonBL;
        private MasterDataBL masterDataBL;
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

        #region ::BookList::

        /// <summary>
        /// Books list.
        /// </summary>
        /// <returns>List of Books</returns>
        [ActionName(Actions.BookList)]
        public ActionResult BookList()
        {
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
        /// <param name="favourite">favourite</param>
        /// <returns>List of Book</returns>
        [HttpPost]
        [ActionName(Actions.BookList)]
        [NoAntiForgeryCheck]
        public JsonResult BookList([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, string genre = null, string sector = null, string location = null, string searchdata = "", bool? favourite = null)
        {
            List<Book> bookList = new List<Book>();

            Book model = new Book()
            {
                BookName = searchdata,
                Authors = searchdata,
                CustomerId = ProjectSession.CustomerId,
                StartRowIndex = requestModel.Start + 1,
                EndRowIndex = requestModel.Start + requestModel.Length,
                SortDirection = requestModel.OrderDir,
                SortExpression = requestModel.Columns.ElementAt(requestModel.OrderColumn).Data,
                Active = Convert.ToBoolean(SystemEnumList.ActiveStatus.Active.GetHashCode()),
                IsOnlyFavourite = favourite
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

        #endregion

        #region ::BookDetails::

        /// <summary>
        /// Book Detail Side Bar
        /// </summary>
        /// <param name="bookId">bookId.</param>
        /// <param name="statusId"> statusId.</param>      
        /// <returns>Book Details</returns>
        [HttpGet]
        [ActionName(Actions.BookDetailSideBar)]
        public ActionResult BookDetailSideBar(int bookId = 0, int? statusId = null)
        {
            Book retmodel = new Book();
            if (bookId > 0)
            {
                retmodel = this.commonBL.GetBookDetailsComplete(bookId, ProjectSession.CustomerId);
                ////retmodel.BorrowedBookList = this.commonBL.GetBookBorrowedDetails(bookId, statusId);
                retmodel.Description = HttpUtility.HtmlDecode(retmodel.Description);
                retmodel.CurrentBookStatus = this.commonBL.GetCurrentBookStatus(bookId, SystemEnumList.ActiveStatus.Active.GetHashCode());
                retmodel.BookPendingEntry = this.commonBL.CheckBookPendingEntry(bookId, ProjectSession.CustomerId);
                retmodel.StatusId = this.commonBL.GetCheckBookBorrowStatus(bookId, ProjectSession.CustomerId);
                retmodel.IdEncrypted = EncryptionDecryption.EncryptByTripleDES(retmodel.ID.ToString());
            }

            return this.PartialView(PartialViews.BookDetailSideBar, retmodel);
        }

        /// <summary>
        /// Book Detail View
        /// </summary>
        /// <param name="bookId">bookId.</param>       
        /// <returns>Book Details</returns>
        [HttpGet]
        [ActionName(Actions.BookDetailView)]
        public ActionResult BookDetailView(string bookId = null)
        {
            Book retmodel;
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
                retmodel.StatusId = this.commonBL.GetCheckBookBorrowStatus(id, ProjectSession.CustomerId);
            }
            else
            {
                return this.Redirect(returnUrl);
            }

            retmodel.CommentList = this.bookDataBL.Search<BookDiscussion>(new BookDiscussion() { BookId = decryptedVal.ToInteger(), StartRowIndex = 1, EndRowIndex = ProjectConfiguration.CommentSize });

            int totalRecord = retmodel.CommentList?.FirstOrDefault()?.TotalRecords ?? 0;
            this.ViewBag.TotalComments = totalRecord;
            this.ViewBag.TotalPage = Math.Ceiling((float)totalRecord / ProjectConfiguration.CommentSize);

            retmodel.ReturnUrl = returnUrl;
            List<SelectListItem> lstStatus = CommonBL.GetListForDropdown<Statuses>(searchCriteria: new SmartLibrary.Models.Statuses() { StatusGroupID = 1 });
            lstStatus.Insert(0, new SelectListItem() { Text = "All", Value = "-1" });
            this.ViewBag.StatusList = lstStatus;
            this.ViewBag.ActiveList = Enum.GetValues(typeof(ActiveStatus)).Cast<ActiveStatus>().Select(x => new SelectListItem { Text = x.ToString(), Value = ((int)x).ToString() }).ToList();

            return this.View(retmodel);
        }

        /// <summary>
        /// Comment List view
        /// </summary>
        /// <param name="currentPage">CurrentPage.</param>       
        /// <param name="bookId">Book Id</param>
        /// <param name="pagesize">pagesize</param>
        /// <returns>Book Details</returns>
        [HttpPost]
        [ActionName(Actions.CommentList)]
        public ActionResult CommentList(int? currentPage, int? bookId, int? pagesize)
        {
            List<BookDiscussion> commentList ;

            BookDiscussion model = new BookDiscussion()
            {
                StartRowIndex = ((currentPage - 1) * pagesize) + 1,
                EndRowIndex = currentPage * pagesize,
                BookId = ConvertTo.ToInteger(bookId)
            };

            commentList = this.bookDataBL.Search<BookDiscussion>(model);

            int totalRecord = 0;
            if (commentList != null && commentList.Count > 0)
            {
                totalRecord = commentList.FirstOrDefault().TotalRecords;
            }

            if (pagesize != 1)
            {
                this.ViewBag.TotalPage = Math.Ceiling((float)totalRecord / ConvertTo.ToInteger(pagesize));
            }

            return this.PartialView(PartialViews.CommentList, commentList);
        }
        #endregion

        #region ::BookGrid::

        /// <summary>
        /// View BookGrid
        /// </summary>
        /// <returns>Return GridView</returns>
        [HttpGet]
        [ActionName(Actions.BookGrid)]
        public ActionResult BookGrid()
        {
            List<Book> bookList = new List<Book>();
            Book model = new Book()
            {
                StartRowIndex = 1,
                EndRowIndex = ProjectConfiguration.PageSizeGrid,
                SortExpression = "ImagePath",
                SortDirection = "desc",
                Active = Convert.ToBoolean(SystemEnumList.ActiveStatus.Active.GetHashCode()),
                CustomerId = ProjectSession.CustomerId
            };
            bookList = this.bookDataBL.Search(model);
            int totalRecord = bookList?.FirstOrDefault()?.TotalRecords ?? 0;
            this.ViewBag.TotalPage = Math.Ceiling((float)totalRecord / ProjectConfiguration.PageSizeGrid);

            return this.View(Views.BookGrid, bookList);
        }

        /// <summary>
        ///  list of BookGrid with search criteria
        /// </summary>
        /// <param name="baseModel">model</param>
        /// <param name="genre">the genre</param>
        /// <param name="sector">the sector</param>
        /// <param name="location">the location</param>
        /// <param name="favourite">favourite</param>
        /// <returns>List of Books</returns>
        [HttpPost]
        [ActionName(Actions.BookGrid)]
        [NoAntiForgeryCheck]
        public ActionResult BookGrid(BaseViewModel baseModel, string genre = null, string sector = null, string location = null, bool? favourite = null)
        {
            List<Book> bookList ;
            Book model = new Book()
            {
                ID = baseModel.Id,
                BookName = baseModel.Searchtext,
                Authors = baseModel.Searchtext,
                StartRowIndex = ((baseModel.CurrentPage - 1) * ProjectConfiguration.PageSizeGrid) + 1,
                EndRowIndex = baseModel.CurrentPage * ProjectConfiguration.PageSizeGrid,
                SortExpression = baseModel.SortExpression,
                SortDirection = baseModel.SortDirection,
                Active = Convert.ToBoolean(SystemEnumList.ActiveStatus.Active.GetHashCode()),
                CustomerId = ProjectSession.CustomerId,
                IsOnlyFavourite = favourite
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
            if (bookList != null && bookList.Count > 0)
            {
                totalRecord = bookList.FirstOrDefault().TotalRecords;
            }

            this.ViewBag.TotalPage = Math.Ceiling((float)totalRecord / ProjectConfiguration.PageSizeGrid);
            return this.PartialView(PartialViews.BookGrid, bookList);
        }

        #endregion

        #region ::Book functionality::

        /// <summary>
        /// Add Book Interest
        /// </summary>
        /// <param name="bookId">the book Id</param>
        /// <returns>the result</returns>
        [HttpPost]
        [ActionName(Actions.AddBookInterest)]
        public JsonResult AddBookInterest(int bookId = 0)
        {
            BookInterest model = new BookInterest()
            {
                CustomerId = ProjectSession.CustomerId,
                BookId = bookId,
                InterestedDate = DateTime.Now
            };

            int result = this.bookDataBL.Save(model, true, false, 0, "CustomerId", "BookId");
            if (result > 0)
            {
                return this.Json(new { success = true, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.AddBookInterest, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.DenyGet });
            }
            else
            {
                return this.Json(new { success = false, message = Messages.ErrorMessage.SetArguments(General.BookInterest), status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), title = Infrastructure.SystemEnumList.Title.Book.GetDescription() });
            }
        }

        /// <summary>
        /// Remove Book Interest
        /// </summary>
        /// <param name="bookId">the book Id</param>
        /// <returns>the result</returns>
        [HttpPost]
        [ActionName(Actions.RemoveBookInterest)]
        public JsonResult RemoveBookInterest(int bookId = 0)
        {
            BookInterest model = new BookInterest()
            {
                CustomerId = ProjectSession.CustomerId,
                BookId = bookId,
            };
            model = this.bookDataBL.Search(model).FirstOrDefault();
            if (model.ID > 0)
            {
                int result = this.bookDataBL.Delete<BookInterest>(model.ID);
                if (result == 0)
                {
                    return this.Json(new { success = true, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.RemoveBookInterest, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.DenyGet });
                }
                else
                {
                    return this.Json(new { success = false, message = Messages.ErrorMessage.SetArguments(General.BookInterest), status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), title = Infrastructure.SystemEnumList.Title.Book.GetDescription() });
                }
            }

            return this.Json(new { success = false, message = Messages.ErrorMessage.SetArguments(General.BookInterest), status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), title = Infrastructure.SystemEnumList.Title.Book.GetDescription() });
        }

        /// <summary>
        /// Get Current Book Status
        /// </summary>
        /// <param name="bookId">the book Id</param>
        /// <returns>the result</returns>
        [HttpGet]
        [ActionName(Actions.CurrentBookStatus)]
        public JsonResult CurrentBookStatus(int bookId = 0)
        {
            int result = this.commonBL.GetCurrentBookStatus(bookId, SystemEnumList.ActiveStatus.Active.GetHashCode());
            if (result > 0)
            {
                return this.Json(new { data = result, success = true, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.BookStatus, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.DenyGet });
            }
            else
            {
                return this.Json(new { data = string.Empty, success = false, message = Messages.ErrorMessage.SetArguments(SmartLibrary.Resources.Books.BookInActive), status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), title = Infrastructure.SystemEnumList.Title.Book.GetDescription() });
            }
        }

        /// <summary>
        /// Borrow Book
        /// </summary>
        /// <param name="pickUpDate">pickUpDate</param>
        /// <param name="bookId">the book Id</param>
        /// <param name="period">period</param>
        /// <returns>the result</returns>
        [HttpPost]
        [ActionName(Actions.BorrowBook)]
        public JsonResult BorrowBook(DateTime pickUpDate, int bookId = 0, string period = null)
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
                    CustomerId = ProjectSession.CustomerId,
                    BookId = bookId,
                    PickUpDate = pickUpDate,
                    ReturnDate = pickUpDate.AddDays(bookperiodValue),
                    Active = Convert.ToBoolean(SystemEnumList.ActiveStatus.Active.GetHashCode()),
                    CreatedBy = ProjectSession.CustomerId,
                    CreatedDate = DateTime.Now,
                    BookPeriod = period,
                    StatusId = SystemEnumList.BorrowBookStatus.Pending.GetHashCode(),
                    Returned = false
                };

                bool isPendingEntry = this.commonBL.CheckBookPendingEntry(bookId, ProjectSession.CustomerId);

                if (!isPendingEntry)
                {
                    int result = this.bookDataBL.SaveBorrowBook(model);
                    if (result > 0)
                    {
                        SmartLibrary.Services.NotificationFactory.AddNotification(NotificationType.BookBorrow, result);

                        List<User> lstAdmin = this.masterDataBL.Search<User>(new User() { Active = true }).ToList();
                        BorrowedBook borrowModel = this.bookDataBL.GetBookDetail<BorrowedBook>(result);
                        foreach (var item in lstAdmin)
                        {
                            EmailViewModel emailModel = new EmailViewModel()
                            {
                                Email = item.Email,
                                Name = borrowModel.CustomerName,
                                BookName = borrowModel.BookName,
                                Author = borrowModel.AuthorName,
                                Date = borrowModel.PickUpDate.ToDate().ToString(ProjectConfiguration.DateFormat, System.Globalization.CultureInfo.InvariantCulture),
                                Duration = bookperiodValue.ToString(),
                                LanguageId = ConvertTo.ToInteger(ProjectSession.UserPortalLanguageId)
                            };
                            UserMail.BookBorrowRequestForAdmin(emailModel);
                        }

                        return this.Json(new { success = true, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.BorrowBookAdd, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.DenyGet });
                    }
                    else
                    {
                        return this.Json(new { success = false, message = Messages.BorrowBookError, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), title = Infrastructure.SystemEnumList.Title.Book.GetDescription() });
                    }
                }
                else
                {
                    return this.Json(new { success = false, message = Messages.AlreadyBookBorrowed, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), title = Infrastructure.SystemEnumList.Title.Book.GetDescription() });
                }

                return this.Json(new { success = false, message = Messages.BorrowBookError, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), title = Infrastructure.SystemEnumList.Title.Book.GetDescription() });
            }
            catch (Exception ex)
            {
                return this.Json(new { success = false, message = Messages.BorrowBookError, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), title = Infrastructure.SystemEnumList.Title.Book.GetDescription() });
            }
        }

        /// <summary>
        /// Add Book Cooment
        /// </summary>
        /// <param name="comment">the comment</param>
        /// <param name="bookId">the book Id</param>
        /// <returns>the result</returns>
        [HttpPost]
        [ActionName(Actions.AddComment)]
        public JsonResult AddComment(string comment, int bookId = 0)
        {
            if (!string.IsNullOrEmpty(comment) && !string.IsNullOrWhiteSpace(comment))
            {
                BookDiscussion model = new BookDiscussion()
                {
                    BookId = bookId,
                    CustomerId = ProjectSession.CustomerId,
                    MessageDescription = comment,
                    IsFromAdmin = false,
                    UserId = null,
                    Approved = true
                };
                int result = this.bookDataBL.Save(model, checkForDuplicate: false, combinationCheckRequired: false);
                if (result > 0)
                {
                    return this.Json(new { success = true, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.AddComment, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.DenyGet });
                }
                else
                {
                    return this.Json(new { success = false, message = Messages.ErrorMessage.SetArguments(General.Comment), status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), title = Infrastructure.SystemEnumList.Title.Book.GetDescription() });
                }
            }
            else
            {
                return this.Json(new { resultData = string.Empty, status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), message = Messages.BlankComment, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.DenyGet });
            }
        }

        #endregion

        /// <summary>
        /// Book History this instance.
        /// </summary>
        /// <param name="data">the encrypted Id</param>
        /// <returns>List of CustomerList</returns>
        [ActionName(Actions.BookProfile)]
        [HttpGet]
        public ActionResult BookHistory()
        {
            return this.View(Views.BookProfile);
        }

        /// <summary>
        ///  list of Book Genres with search criteria
        /// </summary>
        /// <param name="requestModel">the requestModel</param>
        /// <param name="searchdata">search</param>
        /// <param name="data">the encrypted id</param>
        /// <returns>List of BookGenres</returns>
        [HttpPost]
        [ActionName(Actions.BookProfile)]
        [NoAntiForgeryCheck]
        public JsonResult HistoryOfMember([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, string searchdata = "", string data = "")
        {
            int id = ProjectSession.CustomerId;
            int totalRecord = 0;
            int filteredRecord = 0;

            List<BorrowedBook> borrowedBookList = this.commonBL.GetBookDetailsOfCustomer(id, searchdata, requestModel.Start + 1, requestModel.Start + requestModel.Length, requestModel.Columns.ElementAt(requestModel.OrderColumn).Data, requestModel.OrderDir);
            if (borrowedBookList != null && borrowedBookList.Count > 0)
            {
                totalRecord = borrowedBookList.FirstOrDefault().TotalRecords;
                filteredRecord = borrowedBookList.FirstOrDefault().TotalRecords;
            }

            return this.Json(new DataTablesResponse(requestModel.Draw, borrowedBookList, filteredRecord, totalRecord), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Add Notify Me
        /// </summary>
        /// <param name="bookId">the book Id</param>
        /// <returns>the result</returns>
        [HttpPost]
        [ActionName(Actions.AddNotifyMe)]
        public JsonResult AddNotifyMe(int bookId = 0)
        {
            BookNotification model = new BookNotification()
            {
                CustomerId = ProjectSession.CustomerId,
                BookId = bookId,
                IsNotify = true
            };

            int result = this.bookDataBL.Save(model, false, false);
            if (result > 0)
            {
                return this.Json(new { success = true, status = Infrastructure.SystemEnumList.MessageBoxType.Success.GetDescription(), message = Messages.NotifyMeMessage, title = Infrastructure.SystemEnumList.Title.Book.GetDescription(), JsonRequestBehavior.DenyGet });
            }
            else
            {
                return this.Json(new { success = false, message = Messages.ErrorMessage.SetArguments(General.NotifyMe), status = Infrastructure.SystemEnumList.MessageBoxType.Error.GetDescription(), title = Infrastructure.SystemEnumList.Title.Book.GetDescription() });
            }
        }
    }
}