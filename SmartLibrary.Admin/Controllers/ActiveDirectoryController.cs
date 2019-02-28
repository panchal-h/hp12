// <copyright file="ActiveDirectoryController.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Admin.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Mvc;
    using Infrastructure;
    using Infrastructure.Code;
    using Newtonsoft.Json;
    using Pages;
    using Resources;
    using RestSharp;
    using Services;
    using SmartLibrary.Models;

    /// <summary>
    /// Active Directory Controller
    /// </summary>
    public class ActiveDirectoryController : Controller
    {
        #region Class variables

        private CommonBL commonBL;
        private UserDataBL userDataBL;

        #endregion Class Variables

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDirectoryController"/> class.
        /// AccountController.
        /// </summary>
        public ActiveDirectoryController()
        {
            this.commonBL = new CommonBL();
            this.userDataBL = new UserDataBL();
        }

        /// <summary>
        /// Active Directory Login.
        /// </summary>
        /// <returns>Login Page</returns>
        /// <param name="model">Return Url.</param>
        public ActionResult ActiveDirectoryLogin(Login model)
        {
            return this.View(model);
        }

        /// <summary>
        /// Staff Login.
        /// </summary>
        /// <param name="returnUrl">Return Url.</param>
        /// <returns>Staff Login Page</returns>
        [ActionName(Actions.StaffLogin)]
        public ActionResult StaffLogin(string returnUrl)
        {
            Login loginModel = new Login();
            if (this.Request.Cookies["SmartLibraryAD"] != null)
            {
                System.Web.HttpCookie cookie = this.Request.Cookies["SmartLibraryAD"];

                loginModel.RememberMe = ConvertTo.ToBoolean(cookie.Values.Get("LoginIsRemember"));
                if (loginModel.RememberMe)
                {
                    if (cookie.Values.Get("LoginEmail") != null)
                    {
                        loginModel.Email = cookie.Values.Get("LoginEmail");
                    }

                    if (cookie.Values.Get("LoginPassword") != null)
                    {
                        loginModel.Password = EncryptionDecryption.DecryptByTripleDES(cookie.Values.Get("LoginPassword"));
                    }
                }
            }

            loginModel.ReturnUrl = returnUrl;
            return this.View(Views.StaffLogin, loginModel);
        }

        /// <summary>
        /// Use to index.
        /// </summary>
        /// <param name="model">model value.</param>
        /// <returns>return action result.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName(Actions.StaffLogin)]
        public ActionResult StaffLogin(Login model)
        {
            if (this.ModelState.IsValid)
            {
                if (ProjectConfiguration.IsActiveDirectory)
                {
                    var adResponse = this.commonBL.ActiveDirectoryResponse(model);
                    if (adResponse == null || adResponse.Status?.ToLower() == "failure" || !string.IsNullOrEmpty(adResponse.Error_description) || !string.IsNullOrEmpty(adResponse.Error))
                    {
                        this.AddToastMessage(Resources.General.Error, Account.InvalidCredenitals, Infrastructure.SystemEnumList.MessageBoxType.Error);
                        model.Password = EncryptionDecryption.DecryptByTripleDES(model.Password);
                        return this.View(Views.StaffLogin, model);
                    }

                    if (string.IsNullOrEmpty(adResponse.UserName) && string.IsNullOrEmpty(adResponse.Email))
                    {
                        this.AddToastMessage(Resources.General.Error, Messages.EmailNotExistInAD, Infrastructure.SystemEnumList.MessageBoxType.Error);
                        model.Password = EncryptionDecryption.DecryptByTripleDES(model.Password);
                        return this.View(Views.StaffLogin, model);
                    }

                    Login userLogin = this.commonBL.GetUserLoginwithEmail(adResponse.Email);
                    if (userLogin != null && userLogin.Userdata != null)
                    {
                        if (userLogin.Userdata.Active.ToBoolean() == false)
                        {
                            this.AddToastMessage(Resources.General.Error, Account.InactiveUserMessage, Infrastructure.SystemEnumList.MessageBoxType.Error);
                            return this.View(Views.StaffLogin, model);
                        }

                        if (model.RememberMe)
                        {
                            System.Web.HttpCookie cookie = new System.Web.HttpCookie("SmartLibraryAD");
                            cookie.Values.Add("LoginEmail", model.Email);
                            cookie.Values.Add("LoginPassword", EncryptionDecryption.EncryptByTripleDES(model.Password));
                            cookie.Values.Add("LoginIsRemember", Convert.ToString(model.RememberMe));
                            cookie.Expires = DateTime.Now.AddMonths(1);
                            cookie.HttpOnly = true;
                            this.Response.Cookies.Add(cookie);
                        }
                        else
                        {
                            this.Response.Cookies["SmartLibraryAD"].Expires = DateTime.Now.AddMonths(-1);
                        }

                        ProjectSession.AdminPortalLanguageId = userLogin.Userdata.Language ?? SystemEnumList.Language.English.GetHashCode();
                        ProjectSession.UserId = userLogin.Userdata.Id;
                        ProjectSession.UserRole = userLogin.Userdata.RoleId;
                        ProjectSession.UserRoleRights = this.commonBL.GetPageAccessBasedOnUserRole(userLogin.Userdata.RoleId);
                        ProjectSession.SuperAdmin = userLogin.Userdata.SuperAdmin ?? false;
                        ProjectSession.LoginType = SystemEnumList.LoginType.Staff.GetHashCode();

                        if (!string.IsNullOrEmpty(model.ReturnUrl))
                        {
                            if (this.Url.IsLocalUrl(model.ReturnUrl))
                            {
                                return this.Redirect(model.ReturnUrl);
                            }
                        }

                        return this.RedirectToAction(Actions.BookGrid, Controllers.Book);
                    }
                    else
                    {
                        this.AddToastMessage(Resources.General.Error, Account.InvalidCredenitals, Infrastructure.SystemEnumList.MessageBoxType.Error);
                        model.Password = EncryptionDecryption.DecryptByTripleDES(model.Password);
                        return this.View(Views.StaffLogin, model);
                    }
                }
                else
                {
                    model.Password = EncryptionDecryption.EncryptByTripleDES(model.Password);
                    Login response = this.commonBL.GetUserLogin(model);
                    if (response != null && response.Userdata != null)
                    {
                        if (response.Userdata.Active.ToBoolean() == false)
                        {
                            this.AddToastMessage(Resources.General.Error, Account.InactiveUserMessage, Infrastructure.SystemEnumList.MessageBoxType.Error);
                            return this.View(Views.StaffLogin, model);
                        }

                        if (model.RememberMe)
                        {
                            System.Web.HttpCookie cookie = new System.Web.HttpCookie("SmartLibraryAD");
                            cookie.Values.Add("LoginEmail", model.Email);
                            cookie.Values.Add("LoginPassword", EncryptionDecryption.EncryptByTripleDES(model.Password));
                            cookie.Values.Add("LoginIsRemember", Convert.ToString(model.RememberMe));
                            cookie.Expires = DateTime.Now.AddMonths(1);
                            cookie.HttpOnly = true;
                            this.Response.Cookies.Add(cookie);
                        }
                        else
                        {
                            this.Response.Cookies["SmartLibraryAD"].Expires = DateTime.Now.AddMonths(-1);
                        }

                        ProjectSession.AdminPortalLanguageId = response.Userdata.Language ?? SystemEnumList.Language.English.GetHashCode();
                        ProjectSession.UserId = response.Userdata.Id;
                        ProjectSession.UserRole = response.Userdata.RoleId;
                        ProjectSession.UserRoleRights = this.commonBL.GetPageAccessBasedOnUserRole(response.Userdata.RoleId);
                        ProjectSession.SuperAdmin = response.Userdata.SuperAdmin ?? false;
                        if (!string.IsNullOrEmpty(model.ReturnUrl))
                        {
                            if (this.Url.IsLocalUrl(model.ReturnUrl))
                            {
                                return this.Redirect(model.ReturnUrl);
                            }
                        }

                        return this.RedirectToAction(Actions.BookGrid, Controllers.Book);
                    }
                    else
                    {
                        this.AddToastMessage(Resources.General.Error, Account.InvalidCredenitals, Infrastructure.SystemEnumList.MessageBoxType.Error);
                        model.Password = EncryptionDecryption.DecryptByTripleDES(model.Password);
                        return this.View(Views.StaffLogin, model);
                    }
                }
            }
            else if (string.IsNullOrEmpty(model.Email))
            {
                this.ViewBag.ErrorMessage = SmartLibrary.Resources.Messages.RequiredFieldMessage.SetArguments(SmartLibrary.Resources.Account.InvalidEmailAddress);
            }
            else if (string.IsNullOrEmpty(model.Password))
            {
                this.ViewBag.ErrorMessage = Messages.RequiredFieldMessage.SetArguments(SmartLibrary.Resources.Account.Password);
            }

            return this.View(Views.StaffLogin, model);
        }

        /// <summary>
        /// Staff Direct Login.
        /// </summary>
        /// <param name="returnUrl">Return Url.</param>
        /// <param name="userName">userName.</param>
        /// <returns>return action result.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName(Actions.StaffDirectLogin)]
        public ActionResult StaffDirectLogin(string returnUrl, string userName)
        {
            var adResponse = this.commonBL.ActiveDirectoryDirectLogin(userName.ToString());
            if (adResponse == null || adResponse.Status?.ToLower() == "failure" || !string.IsNullOrEmpty(adResponse.Error_description) || !string.IsNullOrEmpty(adResponse.Error))
            {
                this.AddToastMessage(Resources.General.Error, string.IsNullOrEmpty(adResponse.Message) ? Account.InvalidCredenitals : adResponse.Message, Infrastructure.SystemEnumList.MessageBoxType.Error);
                return this.RedirectToAction(Actions.StaffLogin);
            }

            if (string.IsNullOrEmpty(adResponse.UserName) && string.IsNullOrEmpty(adResponse.Email))
            {
                this.AddToastMessage(Resources.General.Error, Messages.EmailNotExistInAD, Infrastructure.SystemEnumList.MessageBoxType.Error);
                return this.RedirectToAction(Actions.StaffLogin);
            }

            Login userLogin = this.commonBL.GetUserLoginwithEmail(adResponse.Email);
            if (userLogin != null && userLogin.Userdata != null)
            {
                if (userLogin.Userdata.Active.ToBoolean() == false)
                {
                    this.AddToastMessage(Resources.General.Error, Account.InactiveUserMessage, Infrastructure.SystemEnumList.MessageBoxType.Error);
                    return this.RedirectToAction(Actions.StaffLogin);
                }

                ProjectSession.AdminPortalLanguageId = userLogin.Userdata.Language ?? SystemEnumList.Language.English.GetHashCode();
                ProjectSession.UserId = userLogin.Userdata.Id;
                ProjectSession.UserRole = userLogin.Userdata.RoleId;
                ProjectSession.UserRoleRights = this.commonBL.GetPageAccessBasedOnUserRole(userLogin.Userdata.RoleId);
                ProjectSession.SuperAdmin = userLogin.Userdata.SuperAdmin ?? false;
                ProjectSession.LoginType = SystemEnumList.LoginType.Staff.GetHashCode();

                if (!string.IsNullOrEmpty(returnUrl))
                {
                    if (this.Url.IsLocalUrl(returnUrl))
                    {
                        return this.Redirect(returnUrl);
                    }
                }

                return this.RedirectToAction(Actions.BookGrid, Controllers.Book);
            }
            else
            {
                this.AddToastMessage(Resources.General.Error, Account.InvalidCredenitals, Infrastructure.SystemEnumList.MessageBoxType.Error);
                return this.View(Views.StaffLogin);
            }

            return this.RedirectToAction(Actions.ActiveDirectoryLogin);
        }
    }
}