// <copyright file="EmailViewModel.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Model For Email Template
    /// </summary>
    public class EmailViewModel
    {
        /// <summary>
        /// Gets or sets the LanguageId value.
        /// </summary>
        public int LanguageId { get; set; }

        /// <summary>
        /// Gets or sets the Email value.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the Duration value.
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// Gets or sets the AdminMessage value.
        /// </summary>
        public string AdminMessage { get; set; }

        /// <summary>
        /// Gets or sets the Name value.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ResetUrl value.
        /// </summary>
        public string ResetUrl { get; set; }

        /// <summary>
        /// Gets or sets the BookName value.
        /// </summary>
        public string BookName { get; set; }

        /// <summary>
        /// Gets or sets the Author value.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the RoomName value.
        /// </summary>
        public string RoomName { get; set; }

        /// <summary>
        /// Gets or sets the Date value.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Gets or sets the Fromtime value.
        /// </summary>
        public string Fromtime { get; set; }

        /// <summary>
        /// Gets or sets the Totime value.
        /// </summary>
        public string Totime { get; set; }

        /// <summary>
        /// Gets or sets the People value.
        /// </summary>
        public string People { get; set; }

        /// <summary>
        /// Gets or sets the OldroomName value.
        /// </summary>
        public string OldroomName { get; set; }

        /// <summary>
        /// Gets or sets the OldDate value.
        /// </summary>
        public string OldDate { get; set; }

        /// <summary>
        /// Gets or sets the OldFromtime value.
        /// </summary>
        public string OldFromtime { get; set; }

        /// <summary>
        /// Gets or sets the OldTotime value.
        /// </summary>
        public string OldTotime { get; set; }

        /// <summary>
        /// Gets or sets the OldPeople value.
        /// </summary>
        public string OldPeople { get; set; }

        /// <summary>
        /// Gets or sets the IsFromJob value.
        /// </summary>
        public bool? IsFromJob { get; set; }

        /// <summary>
        /// Gets or sets the OverdueMessage value.
        /// </summary>
        public string OverdueMessage { get; set; }

        /// <summary>
        /// Gets or sets the Sender value.
        /// </summary>
        ////public string Sender { get; set; }
    }
}
