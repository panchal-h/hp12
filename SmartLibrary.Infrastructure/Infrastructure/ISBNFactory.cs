//-----------------------------------------------------------------------
// <copyright file="ISBNFactory.cs" company="Caspian Pacific Tech">
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
    /// Class for ISBN service object factory.
    /// </summary>
    public static class ISBNFactory
    {
        /// <summary>
        /// Interface for ISBN service
        /// </summary>
        /// <param name="isbnNumber">ISBN Number for which Books information to be fetch.</param>
        /// <returns>Returns an Object of </returns>
        public static IISBNService GetISBNServiceProvider()
        {
            switch (ProjectConfiguration.ActiveISBNAPI.ToUpper())
            {
                case "GOOGLEBOOKAPI":
                    return new GoogleISBNService();
                default:
                    return null;
            }

            return null;
        }
    }
}
