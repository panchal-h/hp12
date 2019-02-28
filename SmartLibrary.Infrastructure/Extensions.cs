// <copyright file="Extensions.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Web;

    /// <summary>
    /// All custom extensions which can be used to check.
    /// </summary>
    /// <CreatedBy>Dipal Patel</CreatedBy>
    /// <CreatedDate>30-Aug-2017</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewedBy></ReviewedBy>
    /// <ReviewedDate></ReviewedDate>
    public static class Extensions
    {
        #region Extension methods

        /// <summary>
        /// Split String, based on provided character
        /// </summary>
        /// <param name="value">main string</param>
        /// <param name="sap">string to split with</param>
        /// <param name="returnType">return type</param>
        /// <returns>return the array of the split string</returns>
        public static System.Collections.ArrayList Split(this string value, char sap, int returnType)
        {
            System.Collections.ArrayList l = new System.Collections.ArrayList();

            char[] charSeparators = new char[] { sap }; //// [,] or [-] or what ever
            string[] result = value.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

            switch (returnType)
            {
                case 1: ////int
                    foreach (string r in result)
                    {
                        l.Add(r.ToInteger());
                    }

                    break;

                case 2: ////string
                    foreach (string r in result)
                    {
                        l.Add(r);
                    }

                    break;
                case 3: ////date
                    foreach (string r in result)
                    {
                        l.Add(r.ToDate());
                    }

                    break;
                default:
                    break;
            }

            return l;
        }

        /// <summary>
        /// check for the Is Empty
        /// </summary>
        /// <param name="value">value to check</param>
        /// <returns>return boolean</returns>
        public static bool IsEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        /// <summary>
        /// Check for Is null or not
        /// </summary>
        /// <param name="source">source value</param>
        /// <returns>Return boolean</returns>
        public static bool IsNull(this object source)
        {
            return source == null;
        }

        /// <summary>
        /// Check Date is between from and to date  or not
        /// </summary>
        /// <param name="date">date value</param>
        /// <param name="fromDate">from Date</param>
        /// <param name="toDate">To Date</param>
        /// <returns>Return Boolean</returns>
        public static bool Between(this DateTime date, DateTime fromDate, DateTime toDate)
        {
            return date.Ticks >= fromDate.Ticks && date.Ticks <= toDate.Ticks;
        }

        /// <summary>
        /// Converts string to enum object
        /// </summary>
        /// <typeparam name="T">Type of enum</typeparam>
        /// <param name="value">String value to convert</param>
        /// <returns>Returns enum object</returns>
        public static T ToEnum<T>(this string value)
            where T : struct
        {
            return (T)System.Enum.Parse(typeof(T), value, true);
        }

        /// <summary>
        /// Set Max String length
        /// </summary>
        /// <param name="value">current value</param>
        /// <param name="len">argument one</param>
        /// <returns>return format string</returns>
        public static string SetMaxStringlength(this string value, int len)
        {
            if (value.Length > len)
            {
                value = value.Substring(0, len) + "...";
            }

            return value;
        }

        /// <summary>
        /// Set Argument to current string
        /// </summary>
        /// <param name="value">current value</param>
        /// <param name="args">arguments Value</param>
        /// <returns>return format string</returns>
        public static string SetArguments(this string value, params object[] args)
        {
            return string.Format(value, args);
        }

        /// <summary>
        /// Distinct By Extended Method
        /// </summary>
        /// <typeparam name="T">class entity</typeparam>
        /// <param name="list">List Value</param>
        /// <param name="propertySelector">distinct property</param>
        /// <returns>Distinct List Value</returns>
        public static IEnumerable<T> DistinctBy<T>(this IEnumerable<T> list, Func<T, object> propertySelector)
        {
            return list.GroupBy(propertySelector).Select(x => x.First());
        }

        /// <summary>
        /// String encode process
        /// </summary>
        /// <param name="text">text value</param>
        /// <returns>returns string</returns>
        public static string ToEncode(this string text)
        {
            string encodedString = text.Trim();
            Regex regex = new Regex(@"\\u([0-9a-z]{4})", RegexOptions.IgnoreCase);
            text = regex.Replace(encodedString, match => char.ConvertFromUtf32(int.Parse(match.Groups[1].Value, System.Globalization.NumberStyles.HexNumber)));
            text = text.Replace("’", "'");
            text = text.Replace("£", "&pound;");
            encodedString = Regex.Replace(text, @"[^\u0000-\u007F]", " ");
            return encodedString;
        }

        /// <summary>
        /// String encode process
        /// </summary>
        /// <param name="text">text value</param>
        /// <returns>returns string</returns>
        public static string ToHTMLEncode(this string text)
        {
            string encodedString = text.Trim();
            HttpUtility.HtmlEncode(encodedString).Replace("&lt;br /&gt;", "<br />").Replace("&lt;br/&gt;", "<br />");
            return encodedString;
        }

        /// <summary>
        /// Convert xml string to data table
        /// </summary>
        /// <param name="xmlString">xml string</param>
        /// <returns>returns data table</returns>
        public static DataTable FromXMLStringToDataTable(this string xmlString)
        {
            DataSet ds;
            using (StringReader stringReader = new StringReader(xmlString))
            {
                ds = new DataSet();
                ds.ReadXml(stringReader);
            }

            DataTable dt = new DataTable();
            if (ds.Tables.Count > 0)
            {
                dt = ds.Tables[0];
            }

            return dt;
        }

        /////// <summary>
        /////// Convert Data table to XML string
        /////// </summary>
        /////// <param name="dt">dt value</param>
        /////// <returns>returns xml string</returns>
        ////public static string ToXML(this DataTable dt)
        ////{
        ////    if (dt.TableName == string.Empty)
        ////    {
        ////        dt.TableName = "tempTable";
        ////    }

        ////    MemoryStream str = new MemoryStream();
        ////    dt.WriteXml(str, true);
        ////    str.Seek(0, SeekOrigin.Begin);
        ////    StreamReader sr = new StreamReader(str);
        ////    string xmlstr = null;
        ////    xmlstr = sr.ReadToEnd();

        ////    return xmlstr;
        ////}

        /// <summary>
        /// Convert Data table to XML string
        /// </summary>
        /// <param name="dt">dt value</param>
        /// <returns>returns xml string</returns>
        public static string ToXML(this DataTable dt)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "Package";
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            foreach (DataColumn dc in ds.Tables[0].Columns)
            {
                dc.ColumnMapping = MappingType.Attribute;

                if (dc.DataType == typeof(DateTime))
                {
                    dc.DateTimeMode = DataSetDateTime.Unspecified;
                }
            }

            ds.WriteXml(sw);
            ds.Tables[0].Dispose();
            ds.Dispose();

            string strXML = sb.ToString().Replace("’", "'");
            return strXML;
        }

        /// <summary>
        /// Get Enumeration Display Name
        /// </summary>
        /// <param name="value">Enumeration Value</param>
        /// <returns>Display Name</returns>
        public static string GetDisplayName(this Enum value)
        {
            return EnumHelper.GetName(value.GetType(), value.ToString());
        }

        /// <summary>
        /// Get exception chain
        /// </summary>
        /// <param name="exception">exception value</param>
        /// <returns>returns Exception</returns>
        public static IEnumerable<Exception> GetExceptionChain(this Exception exception)
        {
            if (exception == null)
            {
                throw new ArgumentNullException("exception");
            }

            for (var current = exception; current != null; current = current.InnerException)
            {
                yield return current;
            }
        }

        /// <summary>
        /// Get Enumeration Description
        /// </summary>
        /// <typeparam name="T">T</typeparam>
        /// <param name="source">source</param>
        /// <returns>Description Value</returns>
        public static string GetDescription<T>(this T source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return source.ToString();
            }
        }

        /// <summary>
        /// Validate Field
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="fieldType">Field Type</param>
        /// <returns>return validation status</returns>
        public static bool ValidateField(this string value, string fieldType)
        {
            bool isValid = false;
            fieldType = string.IsNullOrEmpty(fieldType) ? string.Empty : fieldType.ToLower();
            if (fieldType == "bool")
            {
                fieldType = "boolean";
            }

            switch (fieldType)
            {
                case "string":
                    isValid = !string.IsNullOrEmpty(value);
                    break;
                case "integer":
                    int intValue = 0;
                    isValid = int.TryParse(value, out intValue);
                    break;
                case "decimal":
                    decimal decimalValue = 0;
                    isValid = decimal.TryParse(value, out decimalValue);
                    break;
                case "boolean":
                    bool booleanValue = false;
                    isValid = bool.TryParse(value, out booleanValue);
                    break;
                default:
                    isValid = !string.IsNullOrEmpty(value);
                    break;
            }

            return isValid;
        }

        /// <summary>
        /// Validate Field
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="length">length</param>
        /// <returns>return string</returns>
        public static string GetFixedStringByLength(this string value, int length)
        {
            string ret = value;

            if (!string.IsNullOrEmpty(value) && length > 0 && value.String().Length > length)
            {
                ret = value.String().Substring(0, length) + "...";
            }

            return ret;
        }
        #endregion
    }
}
