// <copyright file="Book.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Infrastructure;
    using Infrastructure.DataAnnotations;
    using static Infrastructure.SystemEnumList;

    /// <summary>
    /// This class is used to Define Model for Table - Books
    /// </summary>
    /// <CreatedBy>Tirthak Shah</CreatedBy>
    /// <CreatedDate>06-Sep-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    [Table("Books")]
    public sealed class Book : BaseModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MappingAttribute(MapName = "ID")]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the BookName value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [StringLength(200, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "StringLengthMessage")]
        [RestrictSpecialCharacters]
        [Display(Name = "Title", ResourceType = typeof(Resources.General))]
        [MappingAttribute(MapName = "BookName")]
        public string BookName { get; set; }

        /// <summary>
        /// Gets or sets the ISBNNo value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [ISBN]
        [StringLength(13, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "StringLengthMessage")]
        [Display(Name = "ISBN", ResourceType = typeof(Resources.Books))]
        [MappingAttribute(MapName = "ISBNNo")]
        public string ISBNNo { get; set; }

        /// <summary>
        /// Gets or sets the ImagePath value.
        /// </summary>
        [StringLength(500, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "StringLengthMessage")]
        [MappingAttribute(MapName = "ImagePath")]
        public string ImagePath { get; set; }

        /// <summary>
        /// Gets or sets the Description value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Display(Name = "Description", ResourceType = typeof(Resources.General))]
        [MappingAttribute(MapName = "Description")]
        [System.Web.Mvc.AllowHtml]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Authors value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [StringLength(500, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "StringLengthMessage")]
        [RestrictSpecialCharacters]
        [Display(Name = "Authors", ResourceType = typeof(Resources.Books))]
        [MappingAttribute(MapName = "Authors")]
        public string Authors { get; set; }

        /// <summary>
        /// Gets or sets the Publisher value.
        /// </summary>
        // [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [StringLength(200, MinimumLength = 6, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "StringLengthMessage")]
        [Display(Name = "Publisher", ResourceType = typeof(Resources.Books))]
        [MappingAttribute(MapName = "Publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the PublishDate value.
        /// </summary>
        // [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Display(Name = "PublishDate", ResourceType = typeof(Resources.Books))]
        [MappingAttribute(MapName = "PublishDate")]
        [DataType(DataType.Date)]
        public DateTime? PublishDate { get; set; }

        /// <summary>
        /// Gets or sets the FromAPI value.
        /// </summary>
        [MappingAttribute(MapName = "FromAPI")]
        public bool? FromAPI { get; set; }

        /// <summary>
        /// Gets or sets the TotalQuantity value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Display(Name = "Quantity", ResourceType = typeof(Resources.Books))]
        [Range(1, 100, ErrorMessageResourceName = "InvalidRangeMessage", ErrorMessageResourceType = typeof(Resources.Messages))]
        [RegularExpression(@"^[0-9]*$", ErrorMessageResourceName = "InvalidInputMessage", ErrorMessageResourceType = typeof(Resources.Messages))]
        [MappingAttribute(MapName = "TotalQuantity")]
        public int? TotalQuantity { get; set; }

        /// <summary>
        /// Gets or sets the CurrentQuantity value.
        /// </summary>
        [MappingAttribute(MapName = "CurrentQuantity")]
        public int? CurrentQuantity { get; set; }

        /// <summary>
        /// Gets or sets the BookLocationId value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Display(Name = "Location", ResourceType = typeof(Resources.Books))]
        public int? BookLocationId { get; set; }

        /////// <summary>
        /////// Gets or sets the BookSectorId value.
        /////// </summary>
        ////[Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        ////[Display(Name = "Section", ResourceType = typeof(Resources.Books))]
        ////public int? BookSectorId { get; set; }

        /// <summary>
        /// Gets or sets the BookGenreId value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Display(Name = "Genre", ResourceType = typeof(Resources.Books))]
        public int? BookGenreId { get; set; }

        /// <summary>
        /// Gets or sets the Active value.
        /// </summary>
        [Display(Name = "Active", ResourceType = typeof(Resources.General))]
        [MappingAttribute(MapName = "Active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or sets the BookGenre Name value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "BookGenre")]
        public string BookGenre { get; set; }

        /// <summary>
        /// Gets or sets the BookSector Name value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "BookSector")]
        public string BookSector { get; set; }

        /// <summary>
        /// Gets or sets the BookLocation Name value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "BookLocation")]
        public string BookLocation { get; set; }

        /// <summary>
        /// Gets or sets the strBookLocation Name value.
        /// </summary>
        public string StrBookLocation { get; set; }

        /// <summary>
        /// Gets or sets the strBookSector Name value.
        /// </summary>
        public string StrBookSector { get; set; }

        /// <summary>
        /// Gets or sets the strBookLocation Name value.
        /// </summary>
        public string StrBookGenre { get; set; }

        /// <summary>
        /// Gets or sets the Interested Name value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "Interested")]
        public int Interested { get; set; }

        /// <summary>
        /// Gets or sets the Interested Name value.
        /// </summary>
        [MappingAttribute(MapName = "CustomerId")]
        public int? CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the CustomerInterest Name value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "CustomerInterest")]
        public int? CustomerInterest { get; set; }

        /// <summary>
        /// Gets or sets the Interested Name value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "StatusName")]
        public string StatusName { get; set; }

        /// <summary>
        /// Gets or sets the Status Name value.
        /// </summary>
        [NotMapped]
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the Quantity Name value.
        /// </summary>
        [NotMapped]
        public string Quantity { get; set; }

        /// <summary>
        /// Gets or sets the CreatedBy value.
        /// </summary>
        public int? CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the CreatedBy Name value.
        /// </summary>
        [NotMapped]
        public string CreatedByName { get; set; }

        /// <summary>
        /// Gets or sets the CreatedDate value.
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the ModifiedBy value.
        /// </summary>
        public int? ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets the ModifiedBy Name value.
        /// </summary>
        [NotMapped]
        public string ModifiedByName { get; set; }

        /// <summary>
        /// Gets or sets the ModifiedDate value.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the BorrowedBookList value.
        /// </summary>
        [NotMapped]
        public List<BorrowedBook> BorrowedBookList { get; set; }

        /// <summary>
        /// Gets or sets the ActiveBorrowers value.
        /// </summary>
        [NotMapped]
        public List<BorrowedBook> ActiveBorrowers { get; set; }

        /// <summary>
        /// Gets or sets the LatestBorrower Name value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "LatestBorrower")]
        public string LatestBorrower { get; set; }

        /// <summary>
        /// Gets or sets the ReturnUrl Name value.
        /// </summary>
        [NotMapped]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Gets or sets the CurrentBookStatus value.
        /// </summary>
        [NotMapped]
        public int CurrentBookStatus { get; set; }

        /// <summary>
        /// Gets or sets the StatusId value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "StatusId")]
        public int StatusId { get; set; }

        /// <summary>
        /// Gets or sets the list of comment value.
        /// </summary>
        [NotMapped]
        public List<BookDiscussion> CommentList { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets the Book Pending Entry value.
        /// </summary>
        [NotMapped]
        public bool BookPendingEntry { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets the favourite books only.
        /// </summary>
        public bool? IsOnlyFavourite { get; set; }

        /// <summary>
        /// Gets or sets the Value of Is Notify Me.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "IsNotify")]
        public bool? IsNotify { get; set; }
        #endregion
    }
}
