// <copyright file="BookInterest.cs" company="Caspian Pacific Tech">
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
    using Infrastructure;

    /// <summary>
    /// This class is used to Define Model for Table - Book Interest
    /// </summary>
    /// <CreatedBy>Bhoomi Shah</CreatedBy>
    /// <CreatedDate>19-Sep-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    [Table("BookInterests")]
    public sealed class BookInterest : BaseModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MappingAttribute(MapName = "ID")]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the UserId value.
        /// </summary>
        public int? CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the BookId value.
        /// </summary>
        public int? BookId { get; set; }

        /// <summary>
        /// Gets or sets the InterestedDate value.
        /// </summary>
        public DateTime? InterestedDate { get; set; }
        #endregion
    }
}
