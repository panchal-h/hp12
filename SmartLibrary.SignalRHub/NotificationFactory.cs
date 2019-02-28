// <copyright file="NotificationFactory.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Services
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Infrastructure;
    using SignalRHub;
    using Models;
    using Services;
    using System.Collections.Generic;
    using EmailServices;
    using static Infrastructure.SystemEnumList;

    /// <summary>
    /// NotificationFactory
    /// </summary>
    /// <CreatedBy>Karan Patel</CreatedBy>
    /// <CreatedDate>26-Sep-2018</CreatedDate>
    public class NotificationFactory
    {
        /// <summary>
        /// AddNotification
        /// </summary>
        /// <param name="notificationType">notificationType</param>
        /// <param name="notificationData">notificationData</param>
        public static void AddNotification(SystemEnumList.NotificationType notificationType, object notificationData)
        {
            try
            {
                Notification notification = new Notification()
                {
                    IsRead = false,
                    NotificationTypeId = (int)notificationType
                };

                bool isAddNotification = false;
                NotificationDataBL notificationDataBL = new NotificationDataBL();

                switch (notificationType)
                {
                    case SystemEnumList.NotificationType.BookBorrow:
                    case SystemEnumList.NotificationType.BookApprove:
                    case SystemEnumList.NotificationType.BookCancel:
                    case SystemEnumList.NotificationType.BookPending:
                    case SystemEnumList.NotificationType.BookReturnDelay:
                    case SystemEnumList.NotificationType.BookReturnReminder:
                    case SystemEnumList.NotificationType.BookReturnTodayReminder:
                    case SystemEnumList.NotificationType.BookBorrowedByAdmin:
                    case SystemEnumList.NotificationType.BookReturn:
                        BorrowedBook borrowedBook = null;
                        if (notificationData is BorrowedBook)
                        {
                            borrowedBook = (BorrowedBook)notificationData;
                        }
                        else
                        {
                            borrowedBook = notificationDataBL.Search<BorrowedBook>(new BorrowedBook() { ID = (int)notificationData }).FirstOrDefault();
                        }
                        if (borrowedBook != null && borrowedBook.ID > 0 && borrowedBook.CustomerId > 0)
                        {
                            if (notificationType == SystemEnumList.NotificationType.BookBorrow)
                            {
                                notification.IsAdmin = true;
                                notification.UserId = 0;
                            }
                            else
                            {
                                notification.IsAdmin = false;
                                notification.UserId = borrowedBook.CustomerId;
                            }
                            notification.BorrowedBookId = borrowedBook.ID;
                            notification.NotificationStartDate = DateTime.Now.Date;
                            if (notificationType == SystemEnumList.NotificationType.BookReturnDelay || notificationType == SystemEnumList.NotificationType.BookReturnReminder || notificationType == SystemEnumList.NotificationType.BookReturnTodayReminder)
                            {
                                notification.NotificationEndDate = DateTime.Now.Date;
                            }
                            else
                            {
                                notification.NotificationEndDate = borrowedBook.ReturnDate;
                            }
                            isAddNotification = true;
                        }
                        break;

                    case SystemEnumList.NotificationType.SpaceBooking:
                    case SystemEnumList.NotificationType.SpaceBookingApprove:
                    case SystemEnumList.NotificationType.SpaceBookingReject:
                    case SystemEnumList.NotificationType.SpaceBookingReschedule:
                        SpaceBooking spaceBooking = null;
                        if (notificationData is SpaceBooking)
                        {
                            spaceBooking = (SpaceBooking)notificationData;
                        }
                        else
                        {
                            spaceBooking = notificationDataBL.Search<SpaceBooking>(new SpaceBooking() { ID = (int)notificationData }).FirstOrDefault();
                        }
                        if (spaceBooking != null && spaceBooking.ID > 0 && spaceBooking.CustomerId > 0)
                        {
                            if (notificationType == SystemEnumList.NotificationType.SpaceBooking)
                            {
                                notification.IsAdmin = true;
                                notification.UserId = 0;
                            }
                            else
                            {
                                notification.IsAdmin = false;
                                notification.UserId = spaceBooking.CustomerId;
                            }
                            notification.SpaceBookingId = spaceBooking.ID;
                            notification.NotificationStartDate = DateTime.Now.Date;
                            notification.NotificationEndDate = spaceBooking.FromDate?.Date.AddDays(1);
                            isAddNotification = true;
                        }
                        break;
                    case SystemEnumList.NotificationType.BookAvailable:
                        BookNotification bookNotification = (BookNotification)notificationData;
                        notification.IsAdmin = false;
                        notification.UserId = bookNotification.CustomerId;
                        notification.BookId = bookNotification.BookId;
                        notification.NotificationStartDate = DateTime.Now.Date;
                        isAddNotification = true;
                        break;
                    default:
                        break;
                }

                LogWritter.WriteErrorFile("AddNotification isAddNotification: " + isAddNotification.ToString(), true, "FetchNotifications_");
                if (isAddNotification)
                {
                    var result = notificationDataBL.SaveNotification(notification);
                    LogWritter.WriteErrorFile("AddNotification result: " + result.ToString(), true, "FetchNotifications_");
                    // if (result > 0)
                    // {
                    //     Task.Run(() =>
                    //     {
                    //         new SendNotification().RefreshNotificationCount(SignalRConnections.connections.Values.SelectMany(x => x).ToList());
                    //     });
                    // }
                }
            }
            catch (Exception ex)
            {
                LogWritter.WriteErrorFile("AddNotification Exception: " + ex.ToString(), true, "FetchNotifications_");
            }
        }

        /// <summary>
        /// Create notification for return days remaining and return is due.
        /// </summary>
        /// <returns>return Status</returns>
        public static void NotificationsSchedular()
        {
            LogWritter.WriteErrorFile("NotificationsSchedular started: ", true, "FetchNotifications_");
            NotificationDataBL notificationDataBL = new NotificationDataBL();
            var dayCount = ProjectConfiguration.ReturnBookRemainingDayCount > 0 ? ProjectConfiguration.ReturnBookRemainingDayCount : 5;
            var borrowedBooks = notificationDataBL.Search<BorrowedBook>(new BorrowedBook()
            {
                Returned = false,
                StatusId = SystemEnumList.BorrowBookStatus.Approved.GetHashCode()
            }).Where(b => b.ReturnDate.HasValue && b.ReturnDate.Value.Date <= DateTime.Now.AddDays(dayCount)).ToList();

            LogWritter.WriteErrorFile("NotificationsSchedular borrowedBooks count = " + borrowedBooks.Count.ToString(), true, "FetchNotifications_");
            if (borrowedBooks.Count == 0)
            {
                return;
            }

            List<int> notificationTypes = new List<int>()
            {
                SystemEnumList.NotificationType.BookReturnDelay.GetHashCode(),
                SystemEnumList.NotificationType.BookReturnTodayReminder.GetHashCode(),
                SystemEnumList.NotificationType.BookReturnReminder.GetHashCode()
            };
            var notificationsExist = notificationDataBL.Search<Notification>(new Notification()
            {
                IsAdmin = false,
                NotificationStartDate = DateTime.Now.Date
            }).Any(n => n.NotificationTypeId.HasValue && n.NotificationStartDate.HasValue && notificationTypes.Contains(n.NotificationTypeId.Value) && n.NotificationStartDate.Value.Date.Equals(DateTime.Now.Date));

            if (notificationsExist)
            {
                LogWritter.WriteErrorFile("NotificationsSchedular Notifications Already Exists", true, "FetchNotifications_");
                return;
            }

            LogWritter.WriteErrorFile("NotificationsSchedular BorrowedBooks Add Notifications Start", true, "FetchNotifications_");

            borrowedBooks.ForEach(borrowedBook =>
            {
                SystemEnumList.NotificationType notificationType = SystemEnumList.NotificationType.BookReturnReminder;
                EmailViewModel emailModel = new EmailViewModel()
                {
                    Email = borrowedBook.BorrowerEmail,
                    Name = borrowedBook.CustomerName,
                    BookName = borrowedBook.BookName,
                    Author = borrowedBook.AuthorName,
                    LanguageId = Language.English.GetHashCode(),
                    IsFromJob = true,
                    Date = borrowedBook.ReturnDate.ToDate().ToString(ProjectConfiguration.DateFormat, System.Globalization.CultureInfo.InvariantCulture),
                    OverdueMessage = string.Empty
                };

                if (borrowedBook.ReturnDate.Value.Date.Equals(DateTime.Now.Date))
                {
                    notificationType = SystemEnumList.NotificationType.BookReturnTodayReminder;
                    emailModel.OverdueMessage = " , Which has to Return Today";
                    UserMail.OverdueBookReminderWithDays(emailModel);
                }
                else if (borrowedBook.ReturnDate.Value.Date < DateTime.Now.Date)
                {
                    notificationType = SystemEnumList.NotificationType.BookReturnDelay;
                    UserMail.OverdueBookReminder(emailModel);
                }
                else
                {
                    var daysLeft = (borrowedBook.ReturnDate.Value.Date - DateTime.Now.Date).TotalDays;
                    emailModel.OverdueMessage = ", Which you have to return after " + daysLeft + " days";
                    UserMail.OverdueBookReminderWithDays(emailModel);
                }

                LogWritter.WriteErrorFile($"BorrowedBook details: [CustomerName={borrowedBook.CustomerName}, BookName={borrowedBook.BookName}, ID={borrowedBook.ID}]", true, "FetchNotifications_");
                AddNotification(notificationType, borrowedBook);

            });

            LogWritter.WriteErrorFile("NotificationsSchedular ended: ", true, "FetchNotifications_");
        }
    }
}
