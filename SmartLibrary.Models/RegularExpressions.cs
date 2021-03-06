﻿//-----------------------------------------------------------------------
// <copyright file="RegularExpressions.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Regular Expressions
    /// </summary>
    /// <CreatedBy> Tirthak Shah</CreatedBy>
    /// <CreatedDate>14-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class RegularExpressions
    {
        /// <summary>
        /// Email address regular expression
        /// </summary>
        public static string Email { get { return @"[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?"; } }

        /// <summary>
        /// Html tag bracket regular expression
        /// </summary>
        public static string HtmlTag { get { return @"[^<>]*"; } }

        /// <summary>
        /// The country code
        /// </summary>
        public static string CountryCode { get { return @"[+](\d{0,3}[-]?\d{1,3})"; } }

        /// <summary>
        /// User Name tag bracket + whiteSpace regular expression
        /// </summary>
        public static string UserName { get { return @"[^\s<>]*"; } }

        /// <summary>
        /// Multiple email address regular expression
        /// </summary>
        public static string MultilineEmail { get { return @"((\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)|(['\&quot;];][^\<\>'\&quot;];]*['\&quot;];]\s*\<\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\>))([;|;|,]\s*((\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)|(['\&quot;];][^\<\>'\&quot;];]*['\&quot;];]\s*\<\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\>)))*"; } }

        /// <summary>
        /// Url Without Protocol regular expression
        /// </summary>
        ////1.  /((([A-Za-z]{3,9}:(?:\/\/)?)(?:[\-;:&=\+\$,\w]+@)?[A-Za-z0-9\.\-]+|(?:www\.|[\-;:&=\+\$,\w]+@)[A-Za-z0-9\.\-]+)((?:\/[\+~%\/\.\w\-_]*)?\??(?:[\-\+=&;%@\.\w_]*)#?(?:[\.\!\/\\\w]*))?)/
        //// 2. ^(http:\/\/|https:\/\/)?(www.)?([a-zA-Z0-9]+).[a-zA-Z0-9]*.[a-z]{3}.?([a-z]+)?$
        ////public static string UrlWithoutProtocol { get { return @"^(http:\/\/|https:\/\/)?[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$"; } }
        //// public static string UrlWithoutProtocol { get { return @"((([A-Za-z]{3,9}:(?:\/\/)?)(?:[\-;:&=\+\$,\w]+@)?[A-Za-z0-9\.\-]+|(?:www\.|[\-;:&=\+\$,\w]+@)[A-Za-z0-9\.\-]+)((?:\/[\+~%\/\.\w\-_]*)?\??(?:[\-\+=&;%@\.\w_]*)#?(?:[\.\!\/\\\w]*))?)"; } }
        public static string UrlWithoutProtocol { get { return @"^((https?|ftp):\/\/)?(((([a-zA-Z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-fA-F]{2})|[!\$&'\(\)\*\+,;=]|:)*@)?(((\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5]))|([a-zA-Z][\-a-zA-Z0-9]*)|((([a-zA-Z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-zA-Z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-zA-Z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-zA-Z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-zA-Z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-zA-Z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-zA-Z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-zA-Z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?)(:\d*)?)(\/((([a-zA-Z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-fA-F]{2})|[!\$&'\(\)\*\+,;=]|:|@)+(\/(([a-zA-Z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-fA-F]{2})|[!\$&'\(\)\*\+,;=]|:|@)*)*)?)?(\?((([a-zA-Z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-fA-F]{2})|[!\$&'\(\)\*\+,;=]|:|@)|[\uE000-\uF8FF]|\/|\?)*)?(\#((([a-zA-Z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-fA-F]{2})|[!\$&'\(\)\*\+,;=]|:|@)|\/|\?)*)?$"; } }

        /// <summary>
        /// US Date Format expression
        /// </summary>
        public static string USDateFormat { get { return @"{0: MM/dd/yyyy}"; } }

        /// <summary>
        /// The UAE contact number
        /// </summary>
        public static string UAEContactNumber { get { return @"^(\+971)(?:2|3|4|6|7|9|50|51|52|55|56)[0-9]{7}$"; } }

        /// <summary>
        /// US Date Format String
        /// </summary>
        public static string USDateFormatString { get { return "MM/dd/yyyy"; } }
    }
}
