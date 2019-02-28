//-----------------------------------------------------------------------
// <copyright file="General.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Admin.Classes
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using SmartLibrary.Infrastructure;

    /// <summary>
    /// Used to General
    /// </summary>
    /// <CreatedBy>Tirthak Shah</CreatedBy>
    /// <CreatedDate>14-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class General
    {
        #region Static Variables

        /// <summary>
        /// Gets Grid File Max Sizes 5MB
        /// </summary>
        public static long FileSize_5MB
        {
            get
            {
                return 5242880;
            }
        }

        /// <summary>
        /// Gets File size 20
        /// </summary>
        public static long FileSize_20MB
        {
            get
            {
                return 20971520;
            }
        }

        /// <summary>
        /// Gets Grid File Max Sizes 5MB
        /// </summary>
        public static string FileSize5MB
        {
            get
            {
                return "5MB";
            }
        }

        /// <summary>
        /// Gets File size 20
        /// </summary>
        public static string FileSize20MB
        {
            get
            {
                return "20MB";
            }
        }

        /// <summary>
        /// Gets Allowed Video Format
        /// </summary>
        public static string AllowedVideoFormat
        {
            get
            {
                return "*.mp4";
            }
        }

        /// <summary>
        /// Gets Allowed Image Format
        /// </summary>
        public static string AllowedImageFormat
        {
            get
            {
                return "*.png, *.jpg, *.jpeg";
            }
        }
        #endregion

        #region EmailMessage

        /// <summary>
        /// Gets Overdued message for email
        /// </summary>
        public static string OverduedMessage
        {
            get
            {
                return "Which has been Overdued";
            }
        }

        #endregion

        #region General Methods

        /// <summary>
        /// This method is used to Get random string of specified length
        /// </summary>
        /// <param name="length">length value</param>
        /// <returns>Return random string</returns>
        public static string GetRandomString(int length)
        {
            string charset = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(charset, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// This method is used to Generate OTP
        /// </summary>
        /// <param name="length">length value</param>
        /// <param name="isNumeric">is Numeric value</param>
        /// <returns>Generate OTP string</returns>
        public static string GenerateOTP(int length, bool isNumeric = true)
        {
            string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string small_alphabets = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "1234567890";

            string characters = alphabets + small_alphabets + numbers;

            if (isNumeric)
            {
                characters = numbers;
            }

            string otp = string.Empty;

            for (int i = 0; i < length; i++)
            {
                string character = string.Empty;
                do
                {
                    int index = new Random().Next(0, characters.Length);
                    character = characters.ToCharArray()[index].ToString();
                }
                while (otp.IndexOf(character) != -1);
                otp += character;
            }

            return otp;
        }

        /// <summary>
        /// This method is used to Get Age
        /// </summary>
        /// <param name="birthDate">birth Date</param>
        /// <returns>age value</returns>
        public static int GetAge(DateTime birthDate)
        {
            //// Save today's date.
            var today = DateTime.Today;

            //// Calculate the age.
            int age = today.Year - birthDate.Year;

            //// Go back to the year the person was born in case of a leap year
            if (birthDate > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        /// <summary>
        /// Copies the file.
        /// </summary>
        /// <param name="oldPath">The old path.</param>
        /// <param name="newpath">The new path.</param>
        /// <param name="newFileName">New name of the file.</param>
        /// <param name="extension">The extension.</param>
        public static void CopyFile(string oldPath, string newpath, string newFileName, string extension)
        {
            FileInfo file = new FileInfo(oldPath);
            if (file.Exists)
            {
                if (!Directory.Exists(newpath))
                {
                    Directory.CreateDirectory(newpath);
                }

                file.CopyTo(string.Format("{0}{1}{2}", newpath, newFileName, extension));
            }
        }

        /// <summary>
        /// use to get Culture Info
        /// </summary>
        /// <param name="languageId">The language identifier.</param>
        /// <returns>
        /// culture info
        /// </returns>
        public static CultureInfo GetCultureInfo(int languageId)
        {
            if (languageId == SystemEnumList.Language.Arabic.GetHashCode())
            {
                return CultureInfo.GetCultureInfo("ar-ae");
            }
            else
            {
                return CultureInfo.GetCultureInfo("en-US");
            }
        }

        /// <summary>
        /// Gets the name of the culture.
        /// </summary>
        /// <param name="languageId">The language identifier.</param>
        /// <returns>Culture Name</returns>
        public static string GetCultureName(int languageId)
        {
            if (languageId == SystemEnumList.Language.Arabic.GetHashCode())
            {
                return "ar-ae";
            }
            else
            {
                return "en-US";
            }
        }

        #endregion
    }
}