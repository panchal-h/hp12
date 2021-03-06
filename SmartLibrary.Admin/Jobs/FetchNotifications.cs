﻿// <auto-generated/>
// <copyright file="FetchNotifications.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Admin.Jobs
{
    using Quartz;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Threading.Tasks;

    /// <summary>
    /// Used to schedule Notifications.
    /// </summary>
    /// <CreatedBy>Dipal Patel</CreatedBy>
    /// <CreatedDate>28-sep-2018.</CreatedDate>
    public class FetchNotifications : IJob
    {
        /// <summary>
        /// Static boolean variable
        /// </summary>
        private static bool isRunning = false;

        /// <summary>
        /// Static ArchiveLogs
        /// </summary>
        private static readonly FetchNotifications Instance = new FetchNotifications();

        /// <summary>
        /// bookDataBL instance
        /// </summary>
        SmartLibrary.Services.BookDataBL bookDataBL = new Services.BookDataBL();

        private string logFileName;

        /// <summary>
        /// Execute
        /// </summary>
        /// <param name="context">context</param>
        void IJob.Execute(IJobExecutionContext context)
        {
            Run();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchNotifications"/> class.
        /// Prevents a default instance of the <see cref="ProcessTrades"/> class from being created.
        /// </summary>
        public FetchNotifications()
        {
            this.logFileName = "NotificationLogs_" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
        }

        /// <summary>
        /// Run
        /// </summary>
        public void Run()
        {
            if (!isRunning)
            {
                this.Main();
            }
        }

        public void Main()
        {

            isRunning = true;
            try
            {
                Infrastructure.LogWritter.WriteErrorFile("Job Started: " + isRunning.ToString() + ", TimeStamp: " + DateTime.Now.ToString(), true, "FetchNotifications_");
                int status = bookDataBL.SchedulerRunforAllPendingRequests(DateTime.Now);
                Infrastructure.LogWritter.WriteErrorFile("SchedulerRunforAllPendingRequests status=" + status.ToString(), true, "FetchNotifications_");
                SmartLibrary.Services.NotificationFactory.NotificationsSchedular();
            }
            catch (Exception ex)
            {
                Infrastructure.LogWritter.WriteErrorFile("Job Exception: " + ex.ToString(), true, "FetchNotifications_");
            }
            finally
            {
                isRunning = false;
            }
            Infrastructure.LogWritter.WriteErrorFile("Job Ended: " + isRunning.ToString() + ", TimeStamp: " + DateTime.Now.ToString(), true, "FetchNotifications_");
            Infrastructure.LogWritter.WriteErrorFile(Environment.NewLine + Environment.NewLine + Environment.NewLine, true, "FetchNotifications_");
        }
    }
}