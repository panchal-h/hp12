//-----------------------------------------------------------------------
// <copyright file="DisplayNameFromFunctionAttribute.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure.DataAnnotations
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Reflection;
    using System.Web;

    /// <summary>
    /// Display Name From Function Attribute
    /// </summary>
    public class DisplayNameFromFunctionAttribute : DisplayNameAttribute
    {
        /// <summary>
        /// Function Name
        /// </summary>
        private string functionName;

        /// <summary>
        /// Type value
        /// </summary>
        private Type type;

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayNameFromFunctionAttribute" /> class.
        /// </summary>
        /// <param name="type">type value</param>
        /// <param name="functionName">function Name</param>
        public DisplayNameFromFunctionAttribute(Type type, string functionName)
        {
            this.type = type;
            this.functionName = functionName;
        }

        /// <summary>
        /// Gets Display Name
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return this.type.GetMethod(this.functionName, BindingFlags.NonPublic | BindingFlags.Instance)
                            .Invoke(Activator.CreateInstance(this.type), null)
                            .ToString();
            }
        }
    }
}