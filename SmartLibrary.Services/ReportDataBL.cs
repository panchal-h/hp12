// <copyright file="ReportDataBL.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Services
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Infrastructure;

    /// <summary>
    /// Reports
    /// </summary>
    /// <CreatedBy>Bhargav Aboti</CreatedBy>
    /// <CreatedDate>04-Oct-2018</CreatedDate>
    public class ReportDataBL
    {
        /// <summary>
        ///  Report Count.
        /// </summary>
        /// <param name="reportfor">Reportfor</param>
        /// <returns>Report result.</returns>
        public DataSet GetCountForReport()
        {
            int retVal = 0;
            using (CustomContext service = new CustomContext())
            {
                DataSet ds = service.GetCountForReport();
                if (ds?.Tables.Count > 0)
                {
                    if (ds.Tables[0]?.Rows.Count > 0)
                    {
                        retVal = ConvertTo.ToInteger(ds.Tables[0].Rows[0][0]);
                    }
                }

                return ds;
            }
        }
    }
}
