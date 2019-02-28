﻿// <auto-generated/>

using SmartLibrary.EmailServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace SmartLibrary.Admin
{
    public partial class EmailTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tbl.Visible = false;
            if (Request.QueryString["Key"] != null && Request.QueryString["Key"] == "admin123")
            {
                tbl.Visible = true;
            }

            lblError.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtEmailTemplate.Text.Trim() != "" && txtEmailTo.Text.Trim() != "")
            {
                bool sent = UserMail.SendTestEmail(txtEmailTemplate.Text.Trim(), txtEmailTo.Text.Trim());

                if (sent)
                {
                    lblError.Text = "Email Sent Successfully.";
                }
                else
                {
                    lblError.Text = "There is an error while sending email.";
                }
            }
        }

        protected void btnSubmitAll_Click(object sender, EventArgs e)
        {
            if (txtEmailTo.Text.Trim() != "")
            {
                string directoryPath = @"D:\Projects\Smart Library\Source Code\trunk\SmartLibrary.Admin\EmailTemplates";
                bool sent = false;
                string[] fileEntries = Directory.GetFiles(directoryPath);
                foreach (string fileName in fileEntries)
                {
                    if (!fileName.Contains("MasterEmailTemplate"))
                    {
                        sent = UserMail.SendTestEmail(fileName.Replace(directoryPath, "").Replace("\\", "").Replace(".html", ""), txtEmailTo.Text.Trim());
                    }
                }

                if (sent)
                {
                    lblError.Text = "Email Sent Successfully.";
                }
                else
                {
                    lblError.Text = "There is an error while sending email.";
                }
            }
        }
    }
}