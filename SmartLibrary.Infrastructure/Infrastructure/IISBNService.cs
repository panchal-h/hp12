//-----------------------------------------------------------------------
// <copyright file="IISBNService.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Interface for ISBN service
    /// </summary>
    public interface IISBNService
    {
        /// <summary>
        /// Interface for ISBN service
        /// </summary>
        /// <param name="isbnNumber">ISBN Number for which Books information to be fetch.</param>
        /// <returns>Returns an Object of </returns>
        BookModel GetBookDetailFromISBN(string isbnNumber);
    }
}
