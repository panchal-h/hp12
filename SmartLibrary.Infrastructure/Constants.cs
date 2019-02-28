//-----------------------------------------------------------------------
// <copyright file="staticants.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure
{
    /// <summary>
    ///  This class is for staticants.
    /// </summary>
    /// <CreatedBy>Dhruvi Shah.</CreatedBy>
    /// <CreatedDate>5-Sept-2018.</CreatedDate>
    public static class Constants
    {
        /// <summary>
        /// Maximum file size in bytes.
        /// </summary>
        public static int MAXIMUM_FILE_UPLOAD_SIZE_BYTES
        {
            get
            {
                return 5242880;
            }
        }

        /// <summary>
        /// Maximum file size in kilo bytes.
        /// </summary>
        public static int MAXIMUM_FILE_UPLOAD_SIZE_KILOBYTES
        {
            get
            {
                return 5120;
            }
        }

        /// <summary>
        /// Maximum file size in mb.
        /// </summary>
        public static int MAXIMUM_FILE_UPLOAD_SIZE_MEGABYTES
        {
            get
            {
                return 5;
            }
        }

        /// <summary>
        /// datatables GridPageSize.
        /// </summary>
        public static int GridPageSize
        {
            get
            {
                return 20;
            }
        }

        /// <summary>
        /// ACTION_View.
        /// </summary>
        public static string ACTION_VIEW
        {
            get
            {
                return "View";
            }
        }

        /// <summary>
        /// ACTION_ADDUpdate.
        /// </summary>
        public static string ACTION_ADDUPDATE
        {
            get
            {
                return "Add_Update";
            }
        }

        /// <summary>
        /// ACTION_DELETE.
        /// </summary>
        public static string ACTION_DELETE { get { return "Delete"; } }

        /// <summary>
        /// Company Name
        /// </summary>
        public static string COMPANY_NAME { get { return "Dubai Economy Smart Library"; } }

        /// <summary>
        /// Forgot Password
        /// </summary>
        public static string FORGOT_PASSWORD { get { return "Forgot Password"; } }

        /// <summary>
        /// Invite Customer
        /// </summary>
        public static string INVITE_CUSTOMER { get { return "Invite Customer"; } }

        /// <summary>
        /// Invite Customer
        /// </summary>
        public static string INVITE_CUSTOMER_HEADER { get { return "Welcome To The Smart Library"; } }

        /// <summary>
        /// Confirm Book Borrow
        /// </summary>
        public static string CONFIRM_BOOK_BORROW { get { return "Confirm Book Borrow"; } }

        /// <summary>
        /// Confirm Book Borrow
        /// </summary>
        public static string CONFIRM_BOOK_BORROW_HEADER { get { return "Your Book Is Confirmed"; } }

        /// <summary>
        /// Cancel Book Borrow
        /// </summary>
        public static string CANCEL_BOOK_BORROW_HEADER { get { return "Your Request Is Cancelled"; } }

        /// <summary>
        /// Request of Room Booking
        /// </summary>
        public static string ROOM_BOOKING_REQUEST { get { return "Room Booking Request"; } }

        /// <summary>
        /// Request of Room Booking
        /// </summary>
        public static string ROOM_BOOKING_REQUEST_FOR_ADMIN { get { return "Request of Room Booking "; } }

        /// <summary>
        /// Approval of Room Booking
        /// </summary>
        public static string ROOM_BOOKING_APPROVE { get { return "Approval of Room Booking"; } }

        /// <summary>
        /// Approval of Room Booking
        /// </summary>
        public static string ROOM_BOOKING_APPROVE_HEADER { get { return "Your Booking Is Confirmed"; } }

        /// <summary>
        /// Cancellation of Room Booking
        /// </summary>
        public static string ROOM_BOOKING_CANCEL { get { return "Cancellation of Room Booking"; } }

        /// <summary>
        /// Cancellation of Room Booking
        /// </summary>
        public static string ROOM_BOOKING_CANCEL_HEADER { get { return "Your Booking Is Cancelled"; } }

        /// <summary>
        /// Reschedule of Room Booking
        /// </summary>
        public static string ROOM_BOOKING_RESCHEDULE { get { return "Reschedule of Room Booking"; } }

        /// <summary>
        /// Reschedule of Room Booking
        /// </summary>
        public static string ROOM_BOOKING_RESCHEDULE_HEADER { get { return "Room Booking Reschedule"; } }

        /// <summary>
        /// Book Overdue
        /// </summary>
        public static string BOOK_OVERDUE { get { return "Your Book is Overdue!"; } }

        /// <summary>
        /// Borrow Book Request
        /// </summary>
        public static string BORROWBOOK_REQUEST_FOR_ADMIN { get { return "Borrow Book Request"; } }

        /// <summary>
        /// Borrow Book Request
        /// </summary>
        public static string MESSAGE_NOTIFICATION { get { return "Message From Admin"; } }

        /// <summary>
        /// Borrow Book Request
        /// </summary>
        public static string MESSAGE_NOTIFICATION_HEADER { get { return "You Have A Message!"; } }

        /// <summary>
        /// Book Available
        /// </summary>
        public static string BOOK_AVAILABLE { get { return "Book Available"; } }
    }
}
