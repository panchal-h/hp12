//-----------------------------------------------------------------------
// <copyright file="DBParameters.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// This class to define default properties for Parameters for SQL Command
    /// </summary>
    /// <CreatedBy>Hardik Panchal</CreatedBy>
    /// <CreatedDate>14-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public sealed class DBParameters
    {
        #region Properties

        /// <summary>
        /// Gets or sets Parameter Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Parameter Value
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets Parameter DBType
        /// </summary>
        public DbType DBType { get; set; }

        #endregion
    }
}
