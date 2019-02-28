//-----------------------------------------------------------------------
// <copyright file="EnumHelper.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Reflection;
    using System.Web.Mvc;

    /// <summary>
    /// System Enum values
    /// </summary>
    /// <CreatedBy>Dhruvi Shah</CreatedBy>
    /// <CreatedDate>5-Sep-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewedBy></ReviewedBy>
    /// <ReviewedDate></ReviewedDate>
    public static class EnumHelper
    {
        #region Methods

        /// <summary>
        /// Get the SystemEnumList from given Enum type
        /// </summary>
        /// <param name="enumType">Enum Type like typeof(EnumType)</param>
        /// <param name="selectedtext">selectedtext</param>
        /// /// <param name="pleaseSelectText">pleaseSelectText</param>
        /// <returns>List of Enum with Name Value pair</returns>
        public static IEnumerable<SelectListItem> GetItems(this System.Type enumType, string selectedtext, string pleaseSelectText = "")
        {
            if (!typeof(Enum).IsAssignableFrom(enumType))
            {
                throw new ArgumentException("Type must be enum");
            }

            var names = Enum.GetNames(enumType);
            var values = Enum.GetValues(enumType).Cast<int>();

            var items = names.Zip(values, (name, value) => new SelectListItem { Text = GetName(enumType, name), Value = value.ToString(), Selected = GetName(enumType, name) == selectedtext ? true : false }).ToList();

            if (!string.IsNullOrEmpty(pleaseSelectText))
            {
                items.Insert(0, new SelectListItem() { Text = pleaseSelectText, Value = string.Empty });
            }

            return items.ToList();
        }

        /// <summary>
        /// Get Enum Name
        /// </summary>
        /// <param name="enumType">enum Type</param>
        /// <param name="name">Enum Name Value</param>
        /// <returns>Return Enum name</returns>
        public static string GetName(Type enumType, string name)
        {
            var result = name;

            var attribute = enumType.GetField(name).GetCustomAttributes(inherit: false).OfType<DisplayAttribute>().FirstOrDefault();
            if (attribute != null)
            {
                result = attribute.GetName();
            }

            return result;
        }

        /// <summary>
        /// Get GetDescription
        /// </summary>
        /// <param name="enumType">enum Type</param>
        /// <param name="name">Enum Name Value</param>
        /// <returns>Return Enum name</returns>
        public static string GetDescription(Type enumType, string name)
        {
            var description = name;

            var memInfo = enumType.GetMember(name);

            if (memInfo != null)
            {
                var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                description = ((DescriptionAttribute)attributes[0]).Description;
            }

            return description;
        }

        /// <summary>
        /// Gets the items as string value.
        /// </summary>
        /// <param name="enumType">Type of the enum.</param>
        /// <param name="getDescription">getDescription.</param>
        /// <returns>return list item</returns>
        public static IEnumerable<SelectListItem> GetItemsAsStringVal(this System.Type enumType, bool getDescription = false)
        {
            if (!typeof(Enum).IsAssignableFrom(enumType))
            {
                throw new ArgumentException("Type must be enum");
            }

            var names = Enum.GetNames(enumType);
            IEnumerable<SelectListItem> items = null;

            if (getDescription)
            {
                items = names.Zip(names, (name, value) => new SelectListItem { Text = GetDescription(enumType, name), Value = GetDescription(enumType, name).ToString() });
            }
            else
            {
                items = names.Zip(names, (name, value) => new SelectListItem { Text = GetName(enumType, name), Value = name.ToString() });
            }

            return items.ToList<SelectListItem>();
        }

        /// <summary>
        /// GetControllerName
        /// </summary>
        /// <param name="value">value</param>
        /// <returns>string</returns>
        public static string GetControllerName(this Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            ControllerNameAttribute[] attributes =
                (ControllerNameAttribute[])fi.GetCustomAttributes(
                typeof(ControllerNameAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
            {
                return attributes[0].ControllerName;
            }
            else
            {
                return string.Empty;
            }
        }       

        #endregion
    }
}
