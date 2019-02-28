//-----------------------------------------------------------------------
// <copyright file="GoogleISBNService.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Google.Apis.Books.v1;
    using Google.Apis.Services;

    /// <summary>
    /// Google Book API for ISBN service.
    /// </summary>
    public class GoogleISBNService : IISBNService
    {
        /// <summary>
        /// Retrieve Book Details From ISBN
        /// </summary>
        /// <param name="isbnNumber">ISBN Number for which Books information to be fetch.</param>
        /// <returns>Returns an Object</returns>
        public BookModel GetBookDetailFromISBN(string isbnNumber)
        {
            try
            {
                BooksService service = new BooksService(new BaseClientService.Initializer
                {
                    ApplicationName = "BooksAPI",
                    ApiKey = ProjectConfiguration.GoogleBookService_APIKey
                });

                var result = service.Volumes.List($"isbn:{isbnNumber}").Execute()?.Items?.FirstOrDefault();
                if (result?.VolumeInfo != null)
                {
                    ////DateTime dt;
                    ////DateTime.TryParseExact(result.VolumeInfo.PublishedDate, new string[] { "yyyy-MM-dd", "yyyy-MM", "yyyy" }, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out dt);

                    return new BookModel
                    {
                        BookName = result.VolumeInfo.Title,
                        ISBNNo = isbnNumber,
                        Image = ConvertTo.ImageToBase64(result.VolumeInfo.ImageLinks?.Thumbnail),
                        Description = result.VolumeInfo.Description,
                        Authors = string.Join(", ", result.VolumeInfo.Authors ?? new[] { result.VolumeInfo.Publisher.String() }),
                        Publisher = result.VolumeInfo.Publisher,
                        ////PublishDate = dt == default(DateTime) ? (DateTime?)null : dt
                    };
                }
            }
            catch (Exception e)
            {
            }

            return null;
        }
    }
}
