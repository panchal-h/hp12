// <copyright file="BookNotification.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This class is used to Define Entity for Table - BookNotification
    /// </summary>
    /// <CreatedBy>Bhoomi</CreatedBy>
    /// <CreatedDate>17-Oct-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    [Table("BookNotification")]
    public sealed class BookNotification : BaseModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the BookId value.
        /// </summary>
        public int? BookId { get; set; }

        /// <summary>
        /// Gets or sets the BookName value.
        /// </summary>
        [NotMapped]
        public string BookName { get; set; }

        /// <summary>
        /// Gets or sets the AuthorName value.
        /// </summary>
        [NotMapped]
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or sets the CustomerId value.
        /// </summary>
        public int? CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the CustomerName value.
        /// </summary>
        [NotMapped]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the Email value.
        /// </summary>
        [NotMapped]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the IsNotify value.
        /// </summary>
        public bool? IsNotify { get; set; }

        /// <summary>
        /// Gets or sets the CreatedDate value.
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the ModifiedDate value.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
        #endregion
    }
}
