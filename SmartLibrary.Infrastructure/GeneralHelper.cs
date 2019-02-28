//-----------------------------------------------------------------------
// <copyright file="GeneralHelper.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    /// <summary>
    /// Used to General
    /// </summary>
    public class GeneralHelper
    {
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
        /// Get Time Selection List
        /// </summary>
        /// <param name="pleaseSelectText">pleaseSelectText</param>
        /// <returns>List</returns>
        public static List<SelectListItem> GetTimeSelectionList(string pleaseSelectText = "")
        {
            int step = ProjectConfiguration.StepForTimepicker.ToInteger();
            int fromValue = (ProjectConfiguration.StartTimeForTimepicker.Split(':')[0].ToInteger() * 60) + ProjectConfiguration.StartTimeForTimepicker.Split(':')[1].ToInteger();
            int toValue = (ProjectConfiguration.EndTimeForTimepicker.Split(':')[0].ToInteger() * 60) + ProjectConfiguration.EndTimeForTimepicker.Split(':')[1].ToInteger();

            List<SelectListItem> itemList = new List<SelectListItem>();
            if (!string.IsNullOrEmpty(pleaseSelectText))
            {
                itemList.Add(new SelectListItem { Value = string.Empty, Text = pleaseSelectText });
            }

            for (int i = fromValue; i <= toValue; i += step)
            {
                string time = Math.Floor(1.0 * i / 60).ToString("00") + ":" + (i % 60).ToString("00");
                itemList.Add(new SelectListItem { Value = time, Text = time });
            }

            return itemList;
        }
    }
}
