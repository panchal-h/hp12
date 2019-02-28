// <copyright file="BorrowedBook.cs" company="Caspian Pacific Tech">
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

    /// <summary>
    /// This class is used to Define Model for Table - BorrowedBook
    /// </summary>
    /// <CreatedBy>Dhruvi Shah</CreatedBy>
    /// <CreatedDate>13-Sep-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    [Table("BorrowedBooks")]
    public sealed class BorrowedBook : BaseModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the ID value.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MappingAttribute(MapName = "BorrowId")]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the PickUpDate value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]     
        [Display(Name = "PickUp Date", ResourceType = typeof(Resources.General))]
        [MappingAttribute(MapName = "PickUpDate")]
        [DataType(DataType.Date)]
        public DateTime? PickUpDate { get; set; }

        /// <summary>
        /// Gets or sets the ReturnDate value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Display(Name = "Return Date", ResourceType = typeof(Resources.General))]
        [MappingAttribute(MapName = "ReturnDate")]
        [DataType(DataType.Date)]
        public DateTime? ReturnDate { get; set; }

        /// <summary>
        /// Gets or sets the ActualPickUpDate value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Display(Name = "Actual PickUp Date", ResourceType = typeof(Resources.Books))]
        [MappingAttribute(MapName = "ActualPickUpDate")]
        [DataType(DataType.Date)]
        public DateTime? ActualPickUpDate { get; set; }

        /// <summary>
        /// Gets or sets the ActualReturnDate value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Display(Name = "Actual Return Date", ResourceType = typeof(Resources.Books))]
        [MappingAttribute(MapName = "ActualReturnDate")]
        [DataType(DataType.Date)]
        public DateTime? ActualReturnDate { get; set; }

        /// <summary>
        /// Gets or sets the Returned value.
        /// </summary>
        [MappingAttribute(MapName = "Returned")]
        public bool? Returned { get; set; }

        /// <summary>
        /// Gets or sets the StatusId value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Display(Name = "Status", ResourceType = typeof(Resources.General))]
        [MappingAttribute(MapName = "StatusId")]
        public int? StatusId { get; set; }

        /// <summary>
        /// Gets or sets the BookDetailId value.
        /// </summary>
        public int? BookDetailId { get; set; }

        /// <summary>
        /// Gets or sets the BookId value.
        /// </summary>
        [MappingAttribute(MapName = "BookId")]
        public int? BookId { get; set; }

        /// <summary>
        /// Gets or sets the Book Name.
        /// </summary>
        [MappingAttribute(MapName = "BookName")]
        public string BookName { get; set; }

        /// <summary>
        /// Gets or sets the StatusId value.
        /// </summary>
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = "RequiredFieldMessage")]
        [Display(Name = "Customer", ResourceType = typeof(Resources.General))]
        [MappingAttribute(MapName = "CustomerId")]
        public int? CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the IsCreatedByAdmin value.
        /// </summary>
        [Display(Name = "IsCreatedByAdmin")]
        public bool? IsCreatedByAdmin { get; set; }

        /// <summary>
        /// Gets or sets the CreatedByAdminId value.
        /// </summary>
        [MappingAttribute(MapName = "CreatedByAdminId")]
        public int? CreatedByAdminId { get; set; }

        /// <summary>
        /// Gets or sets the Active value.
        /// </summary>
        [Display(Name = "Active", ResourceType = typeof(Resources.General))]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or sets the ReturnNotes value.
        /// </summary>
        [Display(Name = "Notes")]
        [MappingAttribute(MapName = "ReturnNotes")]
        public string ReturnNotes { get; set; }

        /// <summary>
        /// Gets or sets the Book Period value.
        /// </summary>
        [Display(Name = "Period")]
        [MappingAttribute(MapName = "BookPeriod")]
        public string BookPeriod { get; set; }

        /// <summary>
        /// Gets or sets the Status value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "Status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the BorrowerName value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "BorrowerName")]
        public string BorrowerName { get; set; }

        /// <summary>
        /// Gets or sets the Author Name value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "Author")]
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or sets the BorrowerEmail value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "BorrowerEmail")]
        public string BorrowerEmail { get; set; }
       
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
        [MappingAttribute(MapName = "CreatedDate")]
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
        /// Gets or sets the ProfileImagePath value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "ProfileImagePath")]
        public string ProfileImagePath { get; set; }

        /// <summary>
        /// Gets or sets the BookStatus value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "BookStatus")]
        public string BookStatus { get; set; }

        /// <summary>
        /// Gets or sets the SKUCode value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "SKUCode")]
        public string SKUCode { get; set; }

        /// <summary>
        /// Gets or sets the CustomerName value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "CustomerName")]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the ISBNNo value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "ISBNNo")]
        public string ISBNNo { get; set; }

        /// <summary>
        /// Gets or sets the ImagePath value.
        /// </summary>
        [NotMapped]
        [MappingAttribute(MapName = "ImagePath")]
        public string ImagePath { get; set; }
        #endregion
    }
}
