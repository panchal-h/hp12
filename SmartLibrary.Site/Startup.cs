//-----------------------------------------------------------------------
// <copyright file="Startup.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using Microsoft.Owin;

[assembly: OwinStartupAttribute(typeof(SmartLibrary.Site.Startup))]
namespace SmartLibrary.Site
{
    using Microsoft.Owin;
    using Owin;

    /// <summary>
    /// Start up
    /// </summary>
    public partial class Startup
    {
        /// <summary>
        /// Configuration
        /// </summary>
        /// <param name="app">app</param>
        public void Configuration(IAppBuilder app)
        {
            ////System.AppDomain.CurrentDomain.Load(typeof(SmartLibrary.SignalRHub.NotificationHub).Assembly.FullName);
            app.MapSignalR();
        }
    }
}
