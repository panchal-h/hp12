// <copyright file="SkipAuthorizationAttribute.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Infrastructure.Filters
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Skip Authorization Check Attribute
    /// </summary>
    public class SkipAuthorizationAttribute : ValidationAttribute
    {
    }
}
