//-----------------------------------------------------------------------
// <copyright file="Constants.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure
{
    /// <summary>
    ///  This class is for Constants.
    /// </summary>
    /// <CreatedBy>Dhruvi Shah.</CreatedBy>
    /// <CreatedDate>5-Sept-2018.</CreatedDate>
    public static class Constants
    {
        /// <summary>
        /// Maximum file size in bytes.
        /// </summary>
        public const int MAXIMUM_FILE_UPLOAD_SIZE_BYTES = 5242880;

        /// <summary>
        /// Maximum file size in kilo bytes.
        /// </summary>
        public const int MAXIMUM_FILE_UPLOAD_SIZE_KILOBYTES = 5120;

        /// <summary>
        /// Maximum file size in mb.
        /// </summary>
        public const int MAXIMUM_FILE_UPLOAD_SIZE_MEGABYTES = 5;

        /// <summary>
        /// datatables GridPageSize.
        /// </summary>
        public const int GridPageSize = 20;

        /// <summary>
        /// ACTION_View.
        /// </summary>
        public const string ACTION_VIEW = "View";

        /// <summary>
        /// ACTION_ADDUpdate.
        /// </summary>
        public const string ACTION_ADDUPDATE = "Add_Update";

        /// <summary>
        /// ACTION_DELETE.
        /// </summary>
        public const string ACTION_DELETE = "Delete";

        /// <summary>
        /// Company Name
        /// </summary>
        public const string COMPANY_NAME = "Dubai Economy Smart Library";

        /// <summary>
        /// Forgot Password
        /// </summary>
        public const string FORGOT_PASSWORD = "Forgot Password";

        /// <summary>
        /// Invite Customer
        /// </summary>
        public const string INVITE_CUSTOMER = "Invite Customer";

        /// <summary>
        /// Invite Customer
        /// </summary>
        public const string INVITE_CUSTOMER_HEADER = "Welcome To The Smart Library";

        /// <summary>
        /// Confirm Book Borrow
        /// </summary>
        public const string CONFIRM_BOOK_BORROW = "Confirm Book Borrow";

        /// <summary>
        /// Confirm Book Borrow
        /// </summary>
        public const string CONFIRM_BOOK_BORROW_HEADER = "Your Book Is Confirmed";

        /// <summary>
        /// Cancel Book Borrow
        /// </summary>
        public const string CANCEL_BOOK_BORROW_HEADER = "Your Request Is Cancelled";

        /// <summary>
        /// Request of Room Booking
        /// </summary>
        public const string ROOM_BOOKING_REQUEST = "Room Booking Request";

        /// <summary>
        /// Request of Room Booking
        /// </summary>
        public const string ROOM_BOOKING_REQUEST_FOR_ADMIN = "Request of Room Booking ";

        /// <summary>
        /// Approval of Room Booking
        /// </summary>
        public const string ROOM_BOOKING_APPROVE = "Approval of Room Booking";

        /// <summary>
        /// Approval of Room Booking
        /// </summary>
        public const string ROOM_BOOKING_APPROVE_HEADER = "Your Booking Is Confirmed";

        /// <summary>
        /// Cancellation of Room Booking
        /// </summary>
        public const string ROOM_BOOKING_CANCEL = "Cancellation of Room Booking";

        /// <summary>
        /// Cancellation of Room Booking
        /// </summary>
        public const string ROOM_BOOKING_CANCEL_HEADER = "Your Booking Is Cancelled";

        /// <summary>
        /// Reschedule of Room Booking
        /// </summary>
        public const string ROOM_BOOKING_RESCHEDULE = "Reschedule of Room Booking";

        /// <summary>
        /// Reschedule of Room Booking
        /// </summary>
        public const string ROOM_BOOKING_RESCHEDULE_HEADER = "Room Booking Reschedule";

        /// <summary>
        /// Book Overdue
        /// </summary>
        public const string BOOK_OVERDUE = "Your Book is Overdue!";

        /// <summary>
        /// Borrow Book Request
        /// </summary>
        public const string BORROWBOOK_REQUEST_FOR_ADMIN = "Borrow Book Request";

        /// <summary>
        /// Borrow Book Request
        /// </summary>
        public const string MESSAGE_NOTIFICATION = "Message From Admin";

        /// <summary>
        /// Borrow Book Request
        /// </summary>
        public const string MESSAGE_NOTIFICATION_HEADER = "You Have A Message!";

        /// <summary>
        /// Book Available
        /// </summary>
        public const string BOOK_AVAILABLE = "Book Available";
    }
}
