// <copyright file="AccountController.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Admin.Controllers
{
    using System;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Security;
    using Infrastructure.Code;
    using Infrastructure.Filters;
    using Resources;
    using Services;
    using SmartLibrary.Admin.Classes;
    using SmartLibrary.Admin.Models;
    using SmartLibrary.Admin.Pages;
    using SmartLibrary.EmailServices;
    using SmartLibrary.Infrastructure;
    using SmartLibrary.Models;

    /// <summary>
    /// Used to Account Controller.
    /// </summary>
    /// <CreatedBy>Dhruvi Shah.</CreatedBy>
    /// <CreatedDate>4-sep-2018.</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class AccountController : Controller
    {
        #region Class variables

        private CommonBL commonBL;
        private UserDataBL userDataBL;

        #endregion Class Variables

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class.
        /// AccountController.
        /// </summary>
        public AccountController()
        {
            this.commonBL = new CommonBL();
            this.userDataBL = new UserDataBL();
        }

        /// <summary>
        /// Login Page.
        /// </summary>
        /// <param name="returnUrl">Return Url.</param>
        /// <returns>View Login.</returns>
        [ActionName(Actions.Index)]
        public ActionResult Index(string returnUrl)
        {
            if (ProjectSession.UserId > 0)
            {
                return new RedirectResult(this.Url.Action(Actions.AllActivities, Controllers.Home));
            }

            Login loginModel = new Login();
            if (this.Request.Cookies["SmartLibrary"] != null)
            {
                HttpCookie cookie = this.Request.Cookies["SmartLibrary"];

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
            return this.View(Views.Index, loginModel);
        }

        /// <summary>
        /// Use to index.
        /// </summary>
        /// <param name="model">model value.</param>
        /// <returns>return action result.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName(Actions.Index)]
        public ActionResult Index(Login model)
        {
            if (this.ModelState.IsValid)
            {
                if (ProjectConfiguration.IsActiveDirectory)
                {
                    var adResponse = this.commonBL.FormAuthenticationGuestLogin(model);
                    if (adResponse == null || adResponse.Status?.ToLower() == "failure" || !string.IsNullOrEmpty(adResponse.Error_description) || !string.IsNullOrEmpty(adResponse.Error))
                    {
                        this.AddToastMessage(Resources.General.Error, Account.InvalidCredenitals, Infrastructure.SystemEnumList.MessageBoxType.Error);
                        model.Password = EncryptionDecryption.DecryptByTripleDES(model.Password);
                        return this.View(Views.Index, model);
                    }

                    if (string.IsNullOrEmpty(adResponse.UserName))
                    {
                        this.AddToastMessage(Resources.General.Error, Messages.EmailNotExistInAD, Infrastructure.SystemEnumList.MessageBoxType.Error);
                        model.Password = EncryptionDecryption.DecryptByTripleDES(model.Password);
                        return this.View(Views.Index, model);
                    }

                    Login userLogin = this.commonBL.GetUserLoginwithEmail(adResponse.UserName);
                    if (userLogin != null && userLogin.Userdata != null)
                    {
                        if (userLogin.Userdata != null && userLogin.Userdata.Active.ToBoolean() == false)
                        {
                            this.AddToastMessage(Resources.General.Error, Account.InactiveUserMessage, Infrastructure.SystemEnumList.MessageBoxType.Error);
                            return this.View(Views.Index, model);
                        }

                        if (model.RememberMe)
                        {
                            HttpCookie cookie = new HttpCookie("SmartLibrary");
                            cookie.Values.Add("LoginEmail", model.Email);
                            cookie.Values.Add("LoginPassword", EncryptionDecryption.EncryptByTripleDES(model.Password));
                            cookie.Values.Add("LoginIsRemember", Convert.ToString(model.RememberMe));
                            cookie.Expires = DateTime.Now.AddMonths(1);
                            cookie.HttpOnly = true;
                            this.Response.Cookies.Add(cookie);
                        }
                        else
                        {
                            this.Response.Cookies["SmartLibrary"].Expires = DateTime.Now.AddMonths(-1);
                        }

                        ProjectSession.AdminPortalLanguageId = userLogin.Userdata.Language ?? SystemEnumList.Language.English.GetHashCode();
                        ProjectSession.UserId = userLogin.Userdata.Id;
                        ProjectSession.UserRole = userLogin.Userdata.RoleId;
                        ProjectSession.UserRoleRights = this.commonBL.GetPageAccessBasedOnUserRole(userLogin.Userdata.RoleId);
                        ProjectSession.SuperAdmin = userLogin.Userdata.SuperAdmin ?? false;
                        ProjectSession.LoginType = SystemEnumList.LoginType.Guest.GetHashCode();
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
                        return this.View(Views.Index, model);
                    }
                }

                Login response = this.commonBL.GetUserLogin(model);
                if (response != null && response.Userdata != null)
                {
                    if (response.Userdata != null && response.Userdata.Active.ToBoolean() == false)
                    {
                        this.AddToastMessage(Resources.General.Error, Account.InactiveUserMessage, Infrastructure.SystemEnumList.MessageBoxType.Error);
                        return this.View(Views.Index, model);
                    }

                    if (model.RememberMe)
                    {
                        HttpCookie cookie = new HttpCookie("SmartLibrary");
                        cookie.Values.Add("LoginEmail", model.Email);
                        cookie.Values.Add("LoginPassword", EncryptionDecryption.EncryptByTripleDES(model.Password));
                        cookie.Values.Add("LoginIsRemember", Convert.ToString(model.RememberMe));
                        cookie.Expires = DateTime.Now.AddMonths(1);
                        cookie.HttpOnly = true;
                        this.Response.Cookies.Add(cookie);
                    }
                    else
                    {
                        this.Response.Cookies["SmartLibrary"].Expires = DateTime.Now.AddMonths(-1);
                    }

                    ProjectSession.AdminPortalLanguageId = response.Userdata.Language ?? SystemEnumList.Language.English.GetHashCode();
                    ProjectSession.UserId = response.Userdata.Id;
                    ProjectSession.UserRole = response.Userdata.RoleId;
                    ProjectSession.UserRoleRights = this.commonBL.GetPageAccessBasedOnUserRole(response.Userdata.RoleId);
                    ProjectSession.SuperAdmin = response.Userdata.SuperAdmin ?? false;
                    ProjectSession.LoginType = SystemEnumList.LoginType.Guest.GetHashCode();
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
                    return this.View(Views.Index, model);
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

            return this.View(Views.Index, model);
        }

        /// <summary>
        /// Reset Password Page.
        /// </summary>
        /// <param name="q">query parameter.</param>
        /// <returns>View Reset Password.</returns>
        [ActionName(Actions.ResetPassword)]
        public ActionResult ResetPassword(string q)
        {
            SmartLibrary.Models.ResetPassword resetPasswordModel = new SmartLibrary.Models.ResetPassword();
            if (!string.IsNullOrEmpty(q))
            {
                try
                {
                    string parameterString = EncryptionDecryption.DecryptByTripleDES(q);
                    var parameters = parameterString.Split('#');

                    if (parameters != null && parameters.Count() == 2)
                    {
                        DateTime urlExpiredTime = DateTime.ParseExact(parameters[1], ProjectConfiguration.EmailDateTimeFormat, System.Globalization.CultureInfo.InvariantCulture);
                        int id = parameters[0].ToInteger();

                        if (DateTime.Now > urlExpiredTime)
                        {
                            this.AddToastMessage(Resources.General.Error, Messages.UrlExpiredMessage, SystemEnumList.MessageBoxType.Error);
                            return this.RedirectToAction(Actions.Index, Controllers.Account);
                        }

                        // Business.Models.User user = service.Search(new Business.Models.User { Id = id }).FirstOrDefault();
                        User user = this.userDataBL.GetUsersList(new User { Id = id }).FirstOrDefault();
                        if (user != null && user.Id > 0)
                        {
                            resetPasswordModel.Id = user.Id;
                        }
                        else
                        {
                            this.AddToastMessage(Resources.General.Error, Messages.UserAccountNotmatched, SystemEnumList.MessageBoxType.Error);
                            return this.RedirectToAction(Actions.Index, Controllers.Account);
                        }
                    }
                    else
                    {
                        this.AddToastMessage(Resources.General.Error, Messages.InvalidUrlMessage, SystemEnumList.MessageBoxType.Error);
                        return this.RedirectToAction(Actions.Index, Controllers.Account);
                    }
                }
                catch (Exception)
                {
                    return this.RedirectToAction(Actions.Index, Controllers.Account);
                }
            }
            else
            {
                this.ViewBag.ResetPasswordMessage = Messages.InvalidUrlMessage;
                return this.RedirectToAction(Actions.Index, Controllers.Account);
            }

            return this.View(Views.ResetPassword, resetPasswordModel);
        }

        /// <summary>
        /// Reset Password Page.
        /// </summary>
        /// <param name="resetPassword">change Password model.</param>
        /// <returns>View Change Password.</returns>
        [ActionName(Actions.ResetPassword)]
        [HttpPost]
        public ActionResult ResetPassword(SmartLibrary.Models.ResetPassword resetPassword)
        {
            if (resetPassword == null || ConvertTo.ToInteger(resetPassword.Id) <= 0)
            {
                this.AddToastMessage(Resources.General.Error, Account.UserNotExist, SystemEnumList.MessageBoxType.Error);
                return this.View(Views.ResetPassword, resetPassword);
            }

            if (resetPassword.NewPassword != resetPassword.ConfirmPassword)
            {
                this.AddToastMessage(Resources.General.Error, Account.NewPasswordAndConfirmPasswordNotMatch, SystemEnumList.MessageBoxType.Error);
                return this.View(Views.ResetPassword, resetPassword);
            }

            var userModel = this.userDataBL.GetUsersList(new User()
            {
                Id = resetPassword.Id
            }).FirstOrDefault();

            if (userModel != null && userModel.Id > 0)
            {
                userModel.Password = EncryptionDecryption.EncryptByTripleDES(resetPassword.NewPassword);
                bool response = this.commonBL.ChangePassword(userModel.Id, userModel.Password, Infrastructure.SystemEnumList.ChangePasswordFor.User.GetDescription());
                if (response)
                {
                    this.AddToastMessage(Resources.General.Success, Account.PasswordChangedSuccessfully, Infrastructure.SystemEnumList.MessageBoxType.Success);
                    return new RedirectResult(this.Url.Action(Views.Index, Controllers.Account));
                }
                else
                {
                    this.AddToastMessage(Resources.General.Error, Messages.ChangePasswordError, Infrastructure.SystemEnumList.MessageBoxType.Error);
                    return this.View(Views.ResetPassword, resetPassword);
                }
            }
            else
            {
                this.AddToastMessage(Resources.General.Error, Account.UserNotExist, Infrastructure.SystemEnumList.MessageBoxType.Error);
                return this.View(Views.ResetPassword, resetPassword);
            }
        }

        /// <summary>
        /// Forgot Password Page.
        /// </summary>
        /// <returns>View Forgot Password.</returns>
        [ActionName(Actions.ForgotPassword)]
        public ActionResult ForgotPassword()
        {
            return this.View(Views.ForgotPassword);
        }

        /// <summary>
        /// Forgot Password Page.
        /// </summary>
        /// <param name="model">the user.</param>
        /// <returns>View Forgot Password.</returns>
        [ActionName(Actions.ForgotPassword)]
        [HttpPost]
        public ActionResult ForgotPassword(Login model)
        {
            User userModel = this.userDataBL.GetUsersList(new User()).Where(m => m.Email == model.Email).FirstOrDefault();

            if (userModel != null)
            {
                string resetPasswordParameter = string.Format("{0}#{1}", userModel.Id, DateTime.Now.AddMinutes(ProjectConfiguration.ResetPasswordExpireTime).ToString(ProjectConfiguration.EmailDateTimeFormat));
                string encryptResetPasswordParameter = EncryptionDecryption.EncryptByTripleDES(resetPasswordParameter);
                string encryptResetPasswordUrl = string.Format("{0}?q={1}", ProjectConfiguration.SiteUrlBase + Controllers.Account + "/" + Actions.ResetPassword, encryptResetPasswordParameter);
                EmailViewModel emailModel = new EmailViewModel()
                {
                    Email = userModel.Email,
                    Name = userModel.FirstName + " " + userModel.LastName,
                    ResetUrl = encryptResetPasswordUrl,
                    LanguageId = ConvertTo.ToInteger(ProjectSession.AdminPortalLanguageId)
                };
                if (UserMail.SendForgotPassword(emailModel))
                {
                    this.AddToastMessage(Resources.General.Success, Messages.EmailSent, SystemEnumList.MessageBoxType.Success);
                    return this.RedirectToAction(Actions.Index, Controllers.Account);
                }
                else
                {
                    this.AddToastMessage(Resources.General.Error, Messages.PasswordEmailSendFail, SystemEnumList.MessageBoxType.Error);
                    return this.View(Views.ForgotPassword, model);
                }
            }
            else
            {
                this.AddToastMessage(Resources.General.Error, Messages.UserAccountNotmatched, SystemEnumList.MessageBoxType.Error);
                return this.View(Views.ForgotPassword, model);
            }
        }

        /// <summary>
        /// use to log out.
        /// </summary>
        /// <returns>return action result.</returns>
        [ActionName(Admin.Pages.Actions.Logout)]
        public ActionResult Logout()
        {
            var loginType = ProjectSession.LoginType;
            this.Session.Abandon();
            this.Session.Clear();
            if (loginType == SystemEnumList.LoginType.Guest.GetHashCode())
            {
                return this.RedirectToAction(Admin.Pages.Actions.Index, Admin.Pages.Controllers.Account);
            }
            else if (loginType == SystemEnumList.LoginType.Staff.GetHashCode())
            {
                return this.RedirectToAction(Admin.Pages.Actions.StaffLogin, Admin.Pages.Controllers.ActiveDirectory);
            }

            return this.RedirectToAction(Admin.Pages.Actions.ActiveDirectoryLogin, Admin.Pages.Controllers.ActiveDirectory);
        }

        /// <summary>
        /// Session time out.
        /// </summary>
        /// <returns>View Login.</returns>
        [ActionName(Actions.SessionExpired)]
        public ActionResult SessionExpired()
        {
            return this.View(Views.SessionExpired);
        }

        /// <summary>
        /// Access Denied.
        /// </summary>
        /// <returns>View Access Denied.</returns>
        [ActionName(Actions.AccessDenied)]
        public ActionResult AccessDenied()
        {
            return this.View(Views.AccessDenied);
        }

        /// <summary>
        /// Access Denied Ajax.
        /// </summary>
        /// <returns>Partial View Access Denied.</returns>
        [ActionName(Actions.AccessDeniedAjax)]
        public ActionResult AccessDeniedAjax()
        {
            return this.PartialView(PartialViews.AccessDenied);
        }

        /// <summary>
        ///  Check Session Expired from Client Side (Java Script).
        /// </summary>
        /// <returns>Is Expired.</returns>
        [HttpPost]
        [NoAntiForgeryCheck]
        [ActionName(Actions.IsSessionExpired)]
        public JsonResult IsSessionExpired()
        {
            string returnUrl = string.Empty;
            returnUrl = this.Url.Action(Actions.ActiveDirectoryLogin, Controllers.ActiveDirectory);
            var isExpired = false;
            if (ProjectSession.UserId <= 0)
            {
                isExpired = true;
                this.AddToastMessage(SmartLibrary.Resources.General.SessionExpired, SmartLibrary.Resources.Account.SessionTimeOut, SystemEnumList.MessageBoxType.Info, true);
                return this.Json(new { IsExpired = isExpired, returnUrl = returnUrl });
            }

            return this.Json(new { IsExpired = isExpired });
        }
    }
}