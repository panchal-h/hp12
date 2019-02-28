//-----------------------------------------------------------------------
// <copyright file="BaseModel.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

[assembly: System.CLSCompliant(true)]

namespace SmartLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using Infrastructure;

    /// <summary>
    /// This class is used to Define common Model Properties for all other model classes
    /// </summary>
    /// <CreatedBy>Hardik Panchal</CreatedBy>
    /// <CreatedDate>14-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    [Serializable]
    public abstract class BaseModel : ICloneable, IDisposable
    {
        #region Variable Declaration

        /// <summary>
        /// dispose Property
        /// </summary>
        private bool disposed;

        #endregion

        #region Finalizer

        /// <summary>
        /// Finalizes an instance of the <see cref="BaseModel"/> class.
        /// Finalizes an instance of the <see cref="BaseModel"/> class
        /// </summary>
        ~BaseModel()
        {
            this.Dispose(false);
        }

        #endregion

        #region Property

        /// <summary>
        /// Gets or sets Total Records
        /// </summary>
        [DataMember]
        [NotMapped]
        [MappingAttribute(MapName = "TotalRecords")]
        public int TotalRecords { get; set; }

        /// <summary>
        /// Gets or sets a Start Row Index
        /// </summary>
        [DataMember]
        [NotMapped]
        public int? StartRowIndex { get; set; }

        /// <summary>
        /// Gets or sets an End Row Index
        /// </summary>
        [DataMember]
        [NotMapped]
        public int? EndRowIndex { get; set; }

        /// <summary>
        /// Gets or sets Row Index
        /// </summary>
        [DataMember]
        [NotMapped]
        public long RowIndex { get; set; }

        /// <summary>
        /// Gets or sets a Sort Expression
        /// </summary>
        [DataMember]
        [NotMapped]
        public string SortExpression { get; set; }

        /// <summary>
        /// Gets or sets a Sort Direction
        /// </summary>
        [DataMember]
        [NotMapped]
        public string SortDirection { get; set; }

        /// <summary>
        /// Gets or sets the Querystring value.
        /// </summary>
        [DataMember]
        [NotMapped]
        public string Querystring { get; set; }

        /// <summary>
        /// Gets or sets the IdEncrypted value.
        /// </summary>
        [DataMember]
        [NotMapped]
        public string IdEncrypted { get; set; }

        /// <summary>
        /// Gets or sets the MultipleQuerystring value.
        /// </summary>
        [DataMember]
        [NotMapped]
        public string MultipleQuerystring { get; set; }

        /// <summary>
        /// Gets or sets the SearchText value.
        /// </summary>
        [DataMember]
        [NotMapped]
        public string SearchText { get; set; }

        #endregion

        #region Dispose Methods

        /// <summary>
        /// Clone Method
        /// </summary>
        /// <returns>return clone of current object</returns>
        object ICloneable.Clone()
        {
            return this.CloneImplementation();
        }

        /// <summary>
        /// The dispose method that implements IDisposable.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// The virtual dispose method that allows
        /// classes inherited from this one to dispose their resources.
        /// </summary>
        /// <param name="disposing">disposing value</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources here.
                }

                // Dispose unmanaged resources here.
            }

            this.disposed = true;
        }

        #endregion

        #region Clone Methods

        /// <summary>
        /// Clone Method
        /// </summary>
        /// <returns>return clone of current object</returns>
        protected object Clone()
        {
            return this.CloneImplementation();
        }

        /// <summary>
        /// Creating clone of current object
        /// </summary>
        /// <returns>return clone of current object</returns>
        protected virtual BaseModel CloneImplementation()
        {
            var copy = (BaseModel)this.MemberwiseClone();
            return copy;
        }

        #endregion
    }
}
