//-----------------------------------------------------------------------
// <copyright file="IOManager.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.HtmlControls;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;

    /// <summary>
    /// This class is used to define all IO related operation
    /// </summary>
    /// <CreatedBy>Hardik Panchal</CreatedBy>
    /// <CreatedDate>14-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class IOManager
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="IOManager" /> class.
        /// </summary>
        public IOManager()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Upload the File
        /// </summary>
        /// <param name="directoryPath">directory Path</param>
        /// <param name="fileUpload">File Upload</param>
        /// <param name="fileName">File Name</param>
        /// <returns>Return File Upload status</returns>
        public static bool UploadFile(string directoryPath, FileUpload fileUpload, string fileName = "")
        {
            try
            {
                if (fileUpload.HasFile)
                {
                    if (!System.IO.Directory.Exists(directoryPath))
                    {
                        System.IO.Directory.CreateDirectory(directoryPath);
                    }

                    if (fileName == string.Empty)
                    {
                        fileName = fileUpload.FileName.Replace("%20", "_");
                    }

                    if (System.IO.File.Exists(directoryPath + "/" + fileName))
                    {
                        System.IO.File.Delete(directoryPath + "/" + fileName);
                    }

                    fileUpload.SaveAs(directoryPath + "/" + fileName);
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Upload the File
        /// </summary>
        /// <param name="directoryPath">directory Path</param>
        /// <param name="fileUpload">file Upload</param>
        /// <param name="fileName">File Name</param>
        /// <returns>Return File Upload status</returns>
        public static bool UploadFile(string directoryPath, HttpPostedFile fileUpload, string fileName = "")
        {
            try
            {
                if (fileUpload.ContentLength > 0)
                {
                    if (!System.IO.Directory.Exists(directoryPath))
                    {
                        System.IO.Directory.CreateDirectory(directoryPath);
                    }

                    if (fileName == string.Empty)
                    {
                        fileName = fileUpload.FileName.Replace("%20", "_");
                    }

                    if (System.IO.File.Exists(directoryPath + "/" + fileName))
                    {
                        System.IO.File.Delete(directoryPath + "/" + fileName);
                    }

                    fileUpload.SaveAs(directoryPath + "/" + fileName);
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Create Directory
        /// </summary>
        /// <param name="directory">directory Name</param>
        /// <returns>Return Created Directory Status</returns>
        public static bool CreateDirectory(string directory)
        {
            try
            {
                if (!System.IO.Directory.Exists(directory))
                {
                    System.IO.Directory.CreateDirectory(directory);
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Create File
        /// </summary>
        /// <param name="fileName">file Name</param>
        /// <returns>Return File Created Status</returns>
        public static bool CreateFile(string fileName)
        {
            try
            {
                if (!System.IO.File.Exists(fileName))
                {
                    System.IO.File.Create(fileName).Close();
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Delete the supplied File
        /// </summary>
        /// <param name="fileName">file Name</param>
        /// <returns>Return File Delete Status</returns>
        public static bool DeleteFile(string fileName)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(fileName) && System.IO.File.Exists(fileName))
                {
                    System.IO.File.Delete(fileName);
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Rename the supplied File
        /// </summary>
        /// <param name="oldFileName">old file Name</param>
        /// <param name="newFilename">new File name</param>
        /// <returns>Return File Rename Status</returns>
        public static bool RenameFile(string oldFileName, string newFilename)
        {
            try
            {
                if (File.Exists(newFilename))
                {
                    System.IO.File.Delete(newFilename);
                }

                System.IO.File.Move(oldFileName, newFilename);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Read the File and return the file content
        /// </summary>
        /// <param name="fileName">file Name</param>
        /// <returns>Return File Data</returns>
        public static string ReadFileData(string fileName)
        {
            string fileData = string.Empty;
            if (System.IO.File.Exists(fileName))
            {
                using (System.IO.StreamReader streamContent = new System.IO.StreamReader(fileName))
                {
                    fileData = streamContent.ReadToEnd();
                }
            }

            return fileData;
        }

        /// <summary>
        /// Function converts map path file in byte array
        /// </summary>
        /// <param name="filename">file name</param>
        /// <returns>Return file data as byte</returns>
        public static byte[] StreamFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            byte[] imageData = new byte[fs.Length];
            fs.Read(imageData, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return imageData;
        }

        /// <summary>
        /// Write Data into File
        /// </summary>
        /// <param name="filepath">file path</param>
        /// <param name="content">File content</param>
        /// <returns>Write data to file</returns>
        public static bool WriteToFile(string filepath, string content)
        {
            try
            {
                File.WriteAllText(filepath, content);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Delete all files from directory.
        /// </summary>
        /// <param name="directoryName">Directory Name</param>
        /// <returns>Return Files deleted Status</returns>
        public static bool DeleteAllfilesFromDirectory(string directoryName)
        {
            try
            {
                if (Directory.Exists(directoryName))
                {
                    string[] files = Directory.GetFiles(directoryName);
                    foreach (string file in files)
                    {
                        if (File.Exists(file) && File.GetCreationTime(file) < DateTime.Today)
                        {
                            File.Delete(file);
                        }
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        #endregion
    }
}