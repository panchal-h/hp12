//-----------------------------------------------------------------------
// <copyright file="LogWritter.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure
{
    using System;
    using System.IO;
    using System.Text;
    using System.Web;

    /// <summary>
    /// This class is used to write log files.
    /// </summary>
    /// <CreatedBy>Dipal Patel</CreatedBy>
    /// <CreatedDate>01-Sep-2017</CreatedDate>
    public class LogWritter
    {
        #region Methods

        /// <summary>
        /// write log files for exception
        /// </summary>
        /// <param name="ex">ex value</param>
        /// <param name="userName">userName value</param>
        public static void WriteErrorFile(Exception ex, string userName = "")
        {
            if (ex != null && !string.IsNullOrEmpty(ex.Message) && !ex.Message.Contains("Thread was being aborted."))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("DateTime = " + DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + System.Environment.NewLine);
                sb.Append("UserName = " + userName + System.Environment.NewLine);
                sb.Append("ExceptionMesage = " + ex.Message + System.Environment.NewLine);

                if (ex.InnerException != null)
                {
                    sb.Append("Inner Exception = " + ex.InnerException + System.Environment.NewLine);
                }

                sb.Append("Exception Source = " + ex.Source + System.Environment.NewLine);
                sb.Append("ExceptionStack = " + ex.StackTrace + System.Environment.NewLine);
                WriteErrorFile(sb.ToString(), true);
            }
        }

        /// <summary>
        /// write log files for error text
        /// </summary>
        /// <param name="textTowrite">Text To write value</param>
        /// <param name="isNewLine">is NewLine value</param>
        /// <param name="fileName">optional fileName</param>
        public static void WriteErrorFile(string textTowrite, bool isNewLine, string fileName = "error_")
        {
            try
            {
                fileName += DateTime.Now.ToString("ddMMyyyy") + ".txt";

                // IOManager.CreateDirectory(HttpContext.Current.Server.MapPath("~/Error"));
                // Check for Error directory exists or not, if not then create.
                if (!System.IO.Directory.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Error")))
                {
                    System.IO.Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Error"));
                }

                string txtFolderPath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Error");
                string txtPath = txtFolderPath + "/" + fileName;

                if (IOManager.CreateFile(txtPath))
                {
                    File.AppendAllText(txtPath, System.Environment.NewLine + textTowrite);

                    if (isNewLine)
                    {
                        File.AppendAllText(txtPath, "---------------------------------------------");
                    }
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
            }
        }

        #endregion
    }
}
