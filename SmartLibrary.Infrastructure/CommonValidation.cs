//-----------------------------------------------------------------------
// <copyright file="CommonValidation.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    /// <summary>
    ///  Contains common validations
    /// </summary>
    /// <CreatedBy>Dipal Patel</CreatedBy>
    /// <CreatedDate>30-Aug-2017</CreatedDate>
    public static class CommonValidation
    {
        /// <summary>
        /// The byte arrays found below (called magic numbers) represent the first several bytes of the associated file type. These leading bytes are universal and can be accurately and reliably used to determine the type of file, even if the visible extension has changed. Maintenance: If the FileExtension enum is changed, the magic numbers list must be updated accordingly.The ValidateFileType method will throw an exception if any FileExtension passed in is not in the list of magic numbers. When adding a new file extension, get the magic number byte array for the added extension here: https://en.wikipedia.org/wiki/List_of_file_signatures
        /// </summary>
        [SuppressMessage("Microsoft.StyleCop.CSharp.SpacingRules", "*", Justification = "Risky to change manually")]
        private static List<KeyValuePair<SystemEnumList.FileExtension, byte[]>> magicNumbers = new List<KeyValuePair<SystemEnumList.FileExtension, byte[]>>
        {
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Gif, new byte[] { 0x47, 0x49, 0x46, 0x38, 0x39, 0x61 }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Gif, new byte[] { 0x47, 0x49, 0x46, 0x38, 0x37, 0x61 }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Jpg, new byte[] { 0xFF, 0xD8 }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Jpeg, new byte[] { 0xFF, 0xD8 }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Png, new byte[] { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Pdf, new byte[] { 0x25, 0x50, 0x44, 0x46 }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Tiff, new byte[] { 0x49, 0x49, 0x2A, 0x00 }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Tif, new byte[] { 0x49, 0x49, 0x2A, 0x00 }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Mtiff, new byte[] { 0x49, 0x49, 0x2A, 0x00 }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Tiff, new byte[] { 0x4D, 0x4D, 0x00, 0x2A }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Tif, new byte[] { 0x4D, 0x4D, 0x00, 0x2A }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Mtiff, new byte[] { 0x4D, 0x4D, 0x00, 0x2A }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Xml, new byte[] { 0x3C, 0x3F, 0x78, 0x6D, 0x6C, 0x20 }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Mp3, new byte[] { 0xFF, 0xFB }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Doc, new byte[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Docx, new byte[] { 0x50, 0x4B, 0x03, 0x04 }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Docx, new byte[] { 0x50, 0x4B, 0x05, 0x06 }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Docx, new byte[] { 0x50, 0x4B, 0x07, 0x08 }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Xls, new byte[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Xlsx, new byte[] { 0x50, 0x4B, 0x03, 0x04 }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Xlsx, new byte[] { 0x50, 0x4B, 0x05, 0x06 }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Xlsx, new byte[] { 0x50, 0x4B, 0x07, 0x08 }),
            new KeyValuePair<SystemEnumList.FileExtension, byte[]>(SystemEnumList.FileExtension.Csv, new byte[] { 0x46, 0x4F, 0x52, 0x4D })
        };

        /// <summary>
        /// Returns true if email address matches regular expression
        /// </summary>
        /// <param name="emailAddress">emailAddress value</param>
        /// <returns>return boolean</returns>
        public static bool IsValidEmailAddress(string emailAddress)
        {
            if (ConvertTo.IsVoid(emailAddress))
            {
                return false;
            }

            System.Text.RegularExpressions.Regex regEx = new Regex("^\\w+([a-zA-Z0-9!#$%^&*\\-+._=])*@([\\w-]+\\.)+[\\w-]+$", RegexOptions.IgnoreCase);

            bool match = regEx.IsMatch(emailAddress);

            return match;
        }

        /// <summary>
        /// Returns true if all characters are numbers
        /// </summary>
        /// <param name="number">number value</param>
        /// <returns>return boolean</returns>
        public static bool IsValidNumber(string number)
        {
            if (ConvertTo.IsVoid(number))
            {
                return false;
            }

            System.Text.RegularExpressions.Regex regEx = new Regex("^[0-9]*$", RegexOptions.IgnoreCase);

            bool match = regEx.IsMatch(number);

            return match;
        }

        /// <summary>
        /// returns true if file type is valid and underlying byte array matches file type
        /// </summary>
        /// <param name="fileName">fileName value</param>
        /// <param name="fileContent">file Content value</param>
        /// <param name="maxFileSize">maxFileSize value</param>
        /// <param name="validExtensions">validExtensions value</param>
        /// <returns>return boolean</returns>
        public static bool ValidateFileType(string fileName, byte[] fileContent, int maxFileSize, params SystemEnumList.FileExtension[] validExtensions)
        {
            var name = Path.GetFileNameWithoutExtension(fileName);
            var extension = Path.GetExtension(fileName).TrimStart('.').ToLower();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(extension))
            {
                throw new Exception("File Name must have a value and an extension");
            }

            if (fileContent == null || !fileContent.Any())
            {
                throw new Exception("File Content cannot be null or empty");
            }

            if (fileContent.Length > maxFileSize)
            {
                return false;
            }

            ////If the file type is not in the valid list it is always invalid
            if (validExtensions.All(ext => ext.ToString().ToLower() != extension))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// returns true if file type is valid and underlying byte array matches file type
        /// </summary>
        /// <param name="fileName">fileName value</param>
        /// <param name="fileContent">file Content value</param>
        /// <param name="maxFileSize">maxFileSize value</param>
        /// <param name="validExtensions">validExtensions value</param>
        /// <returns>return string</returns>
        public static string ValidateFileTypeProperMessage(string fileName, byte[] fileContent, int maxFileSize, params SystemEnumList.FileExtension[] validExtensions)
        {
            var name = Path.GetFileNameWithoutExtension(fileName);
            var extension = Path.GetExtension(fileName).TrimStart('.').ToLower();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(extension))
            {
                return SmartLibrary.Resources.Messages.ValidValueandExtension;
            }

            if (fileContent == null || !fileContent.Any())
            {
                return SmartLibrary.Resources.Messages.FileContentNull;
            }

            if (fileContent.Length > maxFileSize)
            {
                var fileinMb = maxFileSize / (1024 * 1024);
                return SmartLibrary.Resources.Messages.FileSizeError.SetArguments(fileinMb);
            }

            ////If the file type is not in the valid list it is always invalid
            if (validExtensions.All(ext => ext.ToString().ToLower() != extension))
            {
                return SmartLibrary.Resources.Messages.InValidFileExtension;
            }

            return string.Empty;
        }

        /// <summary>
        /// Returns true if all complexity match for the password
        /// </summary>
        /// <param name="password">password value</param>
        /// <returns>return boolean</returns>
        public static bool IsValidPasswordComplexity(string password)
        {
            System.Text.RegularExpressions.Regex regEx = new Regex(@"^(?=(.*\d){1})(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z\d]).{8,}$");
            return regEx.IsMatch(password);
        }

        /// <summary>
        /// CheckAlphaNumeric
        /// </summary>
        /// <param name="val">value</param>
        /// <returns>return boolean</returns>
        public static bool CheckAlphaNumeric(string val)
        {
            System.Text.RegularExpressions.Regex regEx = new Regex(@"^[a-zA-Z0-9]+$", RegexOptions.IgnoreCase);
            return regEx.IsMatch(val);
        }

        /// <summary>
        /// CheckNumeric
        /// </summary>
        /// <param name="val">value</param>
        /// <returns>return boolean</returns>
        public static bool CheckNumeric(string val)
        {
            System.Text.RegularExpressions.Regex regEx = new Regex(@"^[0-9]+$", RegexOptions.IgnoreCase);
            return regEx.IsMatch(val);
        }

        /// <summary>
        /// CheckAlpha
        /// </summary>
        /// <param name="val">value</param>
        /// <returns>return boolean</returns>
        public static bool CheckAlpha(string val)
        {
            System.Text.RegularExpressions.Regex regEx = new Regex(@"^[a-zA-Z]+$", RegexOptions.IgnoreCase);
            return regEx.IsMatch(val);
        }

        /// <summary>
        /// CheckLengthAndSetMessage
        /// </summary>
        /// <param name="val">value</param>
        /// <param name="length">length</param>
        /// <returns>return boolean</returns>
        public static bool CheckLength(string val, int length)
        {
            bool ret = false;
            if (!string.IsNullOrEmpty(val) && val.Length == length)
            {
                ret = true;
            }

            return ret;
        }

        /// <summary>
        /// CheckMaxLength
        /// </summary>
        /// <param name="val">value</param>
        /// <param name="length">length</param>
        /// <returns>return boolean</returns>
        public static bool CheckMaxLength(string val, int length)
        {
            bool ret = false;
            if (!string.IsNullOrEmpty(val) && val.Length > length)
            {
                ret = true;
            }

            return ret;
        }

        /// <summary>
        /// CheckMaxLength
        /// </summary>
        /// <param name="val">value</param>
        /// <param name="length">length</param>
        /// <returns>return boolean</returns>
        public static bool CheckMinLength(string val, int length)
        {
            bool ret = false;
            if (!string.IsNullOrEmpty(val) && val.Length >= length)
            {
                ret = true;
            }

            return ret;
        }

        /// <summary>
        /// ContainsHTML
        /// </summary>
        /// <param name="checkString">checkString</param>
        /// <returns>return boolean</returns>
        public static bool ContainsHTML(string checkString)
        {
            return Regex.IsMatch(checkString, "<(.|\n)*?>");
        }

        /// <summary>
        /// mobile validation
        /// </summary>
        /// <param name="mobile">mobile</param>
        /// <returns>res</returns>
        public static bool CheckMobileValidation(string mobile)
        {
            bool res = false;
            int length = mobile.Length;
            var first = mobile.Substring(0, 1);
            if (length < 10)
            {
                res = false;
            }
            else if (length == 11 && first != '0'.String())
            {
                res = false;
            }
            else if (length == 10 && first == '0'.String())
            {
                res = false;
            }
            else
            {
                res = true;
            }

            return res;
        }

        /// <summary>
        /// Birth date validation
        /// </summary>
        /// <param name="birthday">birthday</param>
        /// <returns>res</returns>
        public static bool ValidateBirthDate(DateTime birthday)
        {
            DateTime today = DateTime.Now;
            DateTime validDate = new DateTime(today.Year - 18, today.Month, today.Day);
            int result = DateTime.Compare(validDate.Date, birthday.Date);
            if (result == 1 || result == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// CheckAtLeastOneNumeric
        /// </summary>
        /// <param name="val">value</param>
        /// <returns>return boolean</returns>
        public static bool CheckAtLeastOneNumeric(string val)
        {
            return val.Any(char.IsDigit);
        }

        /// <summary>
        /// CheckHours_Shift
        /// </summary>
        /// <param name="val">value</param>
        /// <returns>return boolean</returns>
        public static bool CheckHours_Shift(string val)
        {
            if (val.ToInteger() < 1 || val.ToInteger() > 24)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// CheckHours_Shift
        /// </summary>
        /// <param name="val">value</param>
        /// <returns>return boolean</returns>
        public static bool CheckShiftPerDay(string val)
        {
            if (val.ToInteger() < 1 || val.ToInteger() > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// CheckShiftPerDay_Hours_Shift
        /// </summary>
        /// <param name="hoursShift">hoursShift</param>
        /// <param name="shiftPerDay">shiftPerDay</param>
        /// <returns>return boolean</returns>
        public static bool CheckHoursShift_ShiftPerDay(string hoursShift, string shiftPerDay)
        {
            return hoursShift.ToInteger() * shiftPerDay.ToInteger() > 24;
        }

        /// <summary>
        /// CheckHours_Shift
        /// </summary>
        /// <param name="val">value</param>
        /// <returns>return boolean</returns>
        public static bool CheckDays_Week(string val)
        {
            if (val.ToInteger() < 1 || val.ToInteger() > 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// CheckShiftStartTime
        /// </summary>
        /// <param name="val">value</param>
        /// <returns>return boolean</returns>
        public static bool CheckShiftStartTime(string val)
        {
            // We can not use val.Split(':')[0].ToInteger() because it will return 0 in case of invalid data and in out case 0 is valid input. So it will always return true if we use .ToInteger()
            int hrs = -1, min = -1;
            return val.Split(':').Length == 2
                   && int.TryParse(val.Split(':')[0].Trim(), out hrs)
                   && hrs >= 0
                   && hrs < 24
                   && int.TryParse(val.Split(':')[1].Trim(), out min)
                   && min >= 0
                   && min < 60;
        }

        /// <summary>
        /// CheckDayOfWeek
        /// </summary>
        /// <param name="val">value</param>
        /// <returns>return boolean</returns>
        public static bool CheckDayOfWeek(string val)
        {
            return val.Trim().Length > 1 && Enum.GetNames(typeof(SystemEnumList.DaysOfWeek)).Any(x => x.ToLower().StartsWith(val.Trim().ToLower()));
        }

        /// <summary>
        /// CheckShiftStartTime
        /// </summary>
        /// <param name="startDayOfWeek">startDayOfWeek</param>
        /// <param name="daysWeek">daysWeek</param>
        /// <returns>return boolean</returns>
        public static bool CheckDayOfWeek_Days_Week(string startDayOfWeek, string daysWeek)
        {
            return Enum.GetNames(typeof(SystemEnumList.DaysOfWeek)).ToList().FindIndex(x => x.ToLower().StartsWith(startDayOfWeek.Trim().ToLower())) + daysWeek.ToInteger() > 7;
        }
    }
}
