// <copyright file="AccountController.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Site.Controllers
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Security;
    using Infrastructure.Code;
    using Infrastructure.Filters;
    using Infrastructure.HtmlHelpers;
    using Resources;
    using Services;
    using SmartLibrary.EmailServices;
    using SmartLibrary.Infrastructure;
    using SmartLibrary.Models;
    using SmartLibrary.Site.Classes;
    using SmartLibrary.Site.Pages;

    /// <summary>
    /// Used to Account Controller.
    /// </summary>
    /// <CreatedBy>Dhruvi Shah.</CreatedBy>
    /// <CreatedDate>19-sep-2018.</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public class AccountController : Controller
    {
        #region Class variables

        private CommonBL commonBL;
        private MemberDataBL memberDataBL;

        #endregion Class Variables

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountController"/> class.
        /// AccountController.
        /// </summary>
        public AccountController()
        {
            this.commonBL = new CommonBL();
            this.memberDataBL = new MemberDataBL();
        }

        /// <summary>
        /// Action for login page.
        /// </summary>
        /// <param name="returnUrl">the Return Url</param>
        /// <returns>View of the Login page</returns>
        [ActionName(Actions.Index)]
        public ActionResult Index(string returnUrl)
        {
            if (ProjectSession.CustomerId > 0)
            {
                return new RedirectResult(this.Url.Action(Actions.BookGrid, Controllers.Book));
            }

            Login loginModel = new Login();
            if (this.Request.Cookies["SmartLibrarySite"] != null)
            {
                HttpCookie cookie = this.Request.Cookies["SmartLibrarySite"];
                loginModel.RememberMe = ConvertTo.ToBoolean(cookie.Values.Get("SiteIsRemember"));
                if (loginModel.RememberMe)
                {
                    if (cookie.Values.Get("SiteEmail") != null)
                    {
                        loginModel.Email = cookie.Values.Get("SiteEmail");
                    }

                    if (cookie.Values.Get("SitePassword") != null)
                    {
                        loginModel.Password = EncryptionDecryption.DecryptByTripleDES(cookie.Values.Get("SitePassword"));
                    }
                }
            }

            loginModel.ReturnUrl = returnUrl;
            return this.View(Views.Index, loginModel);
        }

        /// <summary>
        /// Login the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Returns the page as per the login crieteria. </returns>
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

                    Login customerLogin = this.commonBL.GetCustomerLoginwithEmail(adResponse.UserName);
                    if (customerLogin != null && customerLogin.Customerdata != null)
                    {
                        if (customerLogin.Customerdata != null && customerLogin.Customerdata.Active.ToBoolean() == false)
                        {
                            this.AddToastMessage(Resources.General.Error, Account.InactiveCustomerMessage, Infrastructure.SystemEnumList.MessageBoxType.Error);
                            return this.View(Views.Index, model);
                        }

                        if (model.RememberMe)
                        {
                            HttpCookie cookie = new HttpCookie("SmartLibrarySite");
                            cookie.Values.Add("SiteEmail", model.Email);
                            cookie.Values.Add("SitePassword", EncryptionDecryption.EncryptByTripleDES(model.Password));
                            cookie.Values.Add("SiteIsRemember", Convert.ToString(model.RememberMe));
                            cookie.Values.Add("SiteLanguageId", Convert.ToString(customerLogin.Customerdata.Language));
                            cookie.Expires = DateTime.Now.AddMonths(1);
                            cookie.HttpOnly = true;
                            this.Response.Cookies.Add(cookie);
                        }
                        else
                        {
                            this.Response.Cookies["SmartLibrarySite"].Expires = DateTime.Now.AddMonths(-1);
                        }

                        ProjectSession.CustomerId = customerLogin.Customerdata.Id;
                        ProjectSession.UserId = customerLogin.Customerdata.Id;
                        ProjectSession.CustomerLanguageId = customerLogin.Customerdata.Language;
                        ProjectSession.UserPortalLanguageId = customerLogin.Customerdata.Language ?? SystemEnumList.Language.English.GetHashCode();
                        ProjectSession.CustomerProfileImagePath = customerLogin.Customerdata.ProfileImagePath;
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

                model.Password = EncryptionDecryption.EncryptByTripleDES(model.Password);
                Login response = this.commonBL.GetCustomerLogin(model);
                if (response != null && response.Customerdata != null)
                {
                    if (response.Customerdata != null && response.Customerdata.Active.ToBoolean() == false)
                    {
                        this.AddToastMessage(Resources.General.Error, Account.InactiveCustomerMessage, Infrastructure.SystemEnumList.MessageBoxType.Error);
                        return this.View(Views.Index, model);
                    }

                    if (model.RememberMe)
                    {
                        HttpCookie cookie = new HttpCookie("SmartLibrarySite");
                        cookie.Values.Add("SiteEmail", model.Email);
                        cookie.Values.Add("SitePassword", model.Password);
                        cookie.Values.Add("SiteIsRemember", Convert.ToString(model.RememberMe));
                        cookie.Values.Add("SiteLanguageId", Convert.ToString(response.Customerdata.Language));
                        cookie.Expires = DateTime.Now.AddMonths(1);
                        cookie.HttpOnly = true;
                        this.Response.Cookies.Add(cookie);
                    }
                    else
                    {
                        this.Response.Cookies["SmartLibrarySite"].Expires = DateTime.Now.AddMonths(-1);
                    }

                    ProjectSession.CustomerId = response.Customerdata.Id;
                    ProjectSession.UserId = response.Customerdata.Id;
                    ProjectSession.CustomerLanguageId = response.Customerdata.Language;
                    ProjectSession.UserPortalLanguageId = response.Customerdata.Language ?? SystemEnumList.Language.English.GetHashCode();
                    ProjectSession.CustomerProfileImagePath = response.Customerdata.ProfileImagePath;

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
            ResetPassword resetPasswordModel = new ResetPassword();
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

                        var user = this.memberDataBL.GetCustomerList(new Customer { Id = id }).FirstOrDefault();
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
        public ActionResult ResetPassword(ResetPassword resetPassword)
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

            var userModel = this.memberDataBL.GetCustomerList(new Customer()
            {
                Id = resetPassword.Id
            }).FirstOrDefault();

            if (userModel != null && userModel.Id > 0)
            {
                if (ProjectConfiguration.IsActiveDirectory)
                {
                    ActiveDirectoryRegister activeDirectoryChangePassword = new ActiveDirectoryRegister()
                    {
                        Email = userModel.Email,
                        Password = EncryptionDecryption.DecryptByTripleDES(userModel.Password),
                        NewPassword = resetPassword.NewPassword,
                        ConfirmPassword = resetPassword.ConfirmPassword
                    };

                    var changePasswordResponse = this.commonBL.ActiveDirectoryChangePasswordResponse(activeDirectoryChangePassword);

                    if (changePasswordResponse == null || changePasswordResponse.Status != SystemEnumList.ApiStatus.Success.GetDescription())
                    {
                        this.AddToastMessage(Resources.General.Error, changePasswordResponse?.Message ?? Messages.ErrorMessage.SetArguments(Resources.General.Member), Infrastructure.SystemEnumList.MessageBoxType.Error);
                        return this.View(Views.ResetPassword, resetPassword);
                    }
                }

                if (resetPassword.NewPassword == resetPassword.ConfirmPassword)
                {
                    userModel.Password = Infrastructure.EncryptionDecryption.EncryptByTripleDES(resetPassword.NewPassword);
                    bool response = this.commonBL.ChangePassword(userModel.Id, userModel.Password, Infrastructure.SystemEnumList.ChangePasswordFor.Customer.GetDescription());
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
            Customer customerModel = this.memberDataBL.GetCustomerList(new Customer()).Where(m => m.Email == model.Email).FirstOrDefault();

            if (customerModel != null)
            {
                string resetPasswordParameter = string.Format("{0}#{1}", customerModel.Id, DateTime.Now.AddMinutes(ProjectConfiguration.ResetPasswordExpireTime).ToString(ProjectConfiguration.EmailDateTimeFormat));
                string encryptResetPasswordParameter = EncryptionDecryption.EncryptByTripleDES(resetPasswordParameter);
                string encryptResetPasswordUrl = string.Format("{0}?q={1}", ProjectConfiguration.SiteUrlBase + Controllers.Account + "/" + Actions.ResetPassword, encryptResetPasswordParameter);
                EmailViewModel emailModel = new EmailViewModel()
                {
                    Email = customerModel.Email,
                    Name = customerModel.FirstName + " " + customerModel.LastName,
                    ResetUrl = encryptResetPasswordUrl,
                    LanguageId = ConvertTo.ToInteger(ProjectSession.UserPortalLanguageId)
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
        /// Logout this instance.
        /// </summary>
        /// <returns>Remove all data from session and return to login page.</returns>
        [ActionName(Actions.Logout)]
        public ActionResult Logout()
        {
            var loginType = ProjectSession.LoginType;
            this.Session.Abandon();
            this.Session.Clear();
            if (loginType == SystemEnumList.LoginType.Guest.GetHashCode())
            {
                return this.RedirectToAction(Site.Pages.Actions.Index, Site.Pages.Controllers.Account);
            }
            else if (loginType == SystemEnumList.LoginType.Staff.GetHashCode())
            {
                return this.RedirectToAction(Site.Pages.Actions.StaffLogin, Site.Pages.Controllers.ActiveDirectory);
            }

            return this.RedirectToAction(Site.Pages.Actions.ActiveDirectoryLogin, Site.Pages.Controllers.ActiveDirectory);
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
            if (ProjectSession.CustomerId <= 0)
            {
                isExpired = true;
                this.AddToastMessage(SmartLibrary.Resources.General.SessionExpired, SmartLibrary.Resources.Account.SessionTimeOut, SystemEnumList.MessageBoxType.Info, true);
                return this.Json(new { IsExpired = isExpired, returnUrl = returnUrl });
            }

            return this.Json(new { IsExpired = isExpired });
        }

        /// <summary>
        /// Sign Up page.
        /// </summary>
        /// <param name="q">q.</param>
        /// /// <param name="pcnumber">pcnumber.</param>
        /// <returns>View.</returns>
        [ActionName(Actions.StaffSignUp)]
        public ActionResult StaffSignUp(string q, string pcnumber)
        {
            Customer user = new Customer();
            if (q == null)
            {
                return this.RedirectToAction(Actions.ActiveDirectoryLogin, Controllers.ActiveDirectory);
            }

            string emailDecrypt = EncryptionDecryption.DecryptByTripleDES(q);
            string pcNoDecrypt = EncryptionDecryption.DecryptByTripleDES(pcnumber);
            if (string.IsNullOrEmpty(emailDecrypt))
            {
                return this.RedirectToAction(Actions.ActiveDirectoryLogin, Controllers.ActiveDirectory);
            }

            var response = this.commonBL.GetADuserDataWithPCNo(pcNoDecrypt);

            if (response == null && response.Status != SystemEnumList.ApiStatus.Success.GetDescription())
            {
                this.AddToastMessage(Account.CreateAccount, response.Message, Infrastructure.SystemEnumList.MessageBoxType.Error);
                return this.RedirectToAction(Actions.ActiveDirectoryLogin, Controllers.ActiveDirectory);
            }

            if (response.Status == SystemEnumList.ApiStatus.Success.GetDescription())
            {
                user.FirstName = response.Data.Name;
                user.Email = response.Data.Email;
                user.LoginType = SystemEnumList.LoginType.Staff.GetHashCode();
                user.PCNumber = response.Data.PCNumber;
                user.Active = true;
                user.Language = 2;
                int saveStatus = this.memberDataBL.SaveCustomer(user);
                var msgBox = Infrastructure.SystemEnumList.MessageBoxType.Success;
                if (saveStatus > 0)
                {
                    return this.RedirectToAction(Actions.StaffLogin, Controllers.ActiveDirectory);
                }
                else
                {
                    if (saveStatus == -2)
                    {
                        this.AddToastMessage(Account.CreateAccount, Messages.DuplicateMessage.SetArguments(Resources.General.Customer), Infrastructure.SystemEnumList.MessageBoxType.Error);
                        return this.View(Views.SignUp, user);
                    }
                    else
                    {
                        this.AddToastMessage(Account.CreateAccount, Messages.ErrorMessage.SetArguments(Resources.General.Customer), Infrastructure.SystemEnumList.MessageBoxType.Error);
                        return this.RedirectToAction(Actions.StaffLogin, Controllers.ActiveDirectory);
                    }
                }
            }

            this.AddToastMessage(Account.CreateAccount, response.Message, Infrastructure.SystemEnumList.MessageBoxType.Error);
            return this.RedirectToAction(Actions.ActiveDirectoryLogin, Controllers.ActiveDirectory);
        }

        /// <summary>
        /// Sign Up page.
        /// </summary>
        /// <param name="q">q.</param>
        /// <param name="loginType">loginType.</param>
        /// /// <param name="pcnumber">pcnumber.</param>
        /// <returns>View.</returns>
        [ActionName(Actions.SignUp)]
        public ActionResult SignUp(string q, string loginType, string pcnumber)
        {
            if (q == null)
            {
                return this.RedirectToAction(Views.Index);
            }

            string emailDecrypt = EncryptionDecryption.DecryptByTripleDES(q);
            string pcNoDecrypt = EncryptionDecryption.DecryptByTripleDES(pcnumber);
            var decryptLoginType = EncryptionDecryption.DecryptByTripleDES(loginType);
            if (string.IsNullOrEmpty(emailDecrypt))
            {
                return this.RedirectToAction(Actions.Index, Controllers.Account);
            }

            Customer objCustomer = this.memberDataBL.GetCustomerList(new Customer()).Where(x => x.Email == emailDecrypt).FirstOrDefault();
            if (objCustomer == null)
            {
                objCustomer = new Customer();
                objCustomer.Email = emailDecrypt;
                objCustomer.LoginType = Convert.ToInt32(decryptLoginType);
                objCustomer.PCNumber = pcNoDecrypt;
                return this.View(Views.SignUp, objCustomer);
            }

            this.AddToastMessage(Account.CreateAccount, Messages.MemberAlreadyRegistered, Infrastructure.SystemEnumList.MessageBoxType.Error);
            return this.RedirectToAction(Actions.Index, Controllers.Account);
        }

        /// <summary>
        /// Manages the UserProfile.
        /// </summary>
        /// <param name="user">The User.</param>
        /// <param name="file">The HttpPostedFileBase.</param>
        /// <param name="loginType">loginType.</param>
        /// <returns>Save User profile.</returns>
        [ActionName(Actions.SignUp)]
        [HttpPost]
        public ActionResult SignUp(Customer user, HttpPostedFileBase file, string loginType)
        {
            int loginTypeId = 0;
            if (user.LoginType == null && int.TryParse(EncryptionDecryption.DecryptByTripleDES(loginType), out loginTypeId))
            {
                user.LoginType = loginTypeId;
            }

            this.ModelState.Clear();
            this.TryValidateModel(user);
            if (loginTypeId == SystemEnumList.LoginType.Guest.GetHashCode())
            {
                this.ModelState.Remove(nameof(user.PCNumber));
            }

            if (!this.ModelState.IsValid)
            {
                return this.View(Views.SignUp, user);
            }

            ActiveDirectoryRegister activeDirectoryRegister = new ActiveDirectoryRegister()
            {
                Email = user.Email,
                Password = user.Password,
                FirstName = user.FirstName,
                LastName = user.LastName,
                LoginType = user.LoginType,
                Gender = user.Gender,
                Phone = user.Phone
            };

            if (ProjectConfiguration.IsActiveDirectory)
            {
                var registerResponse = this.commonBL.ActiveDirectoryRegisterResponse(activeDirectoryRegister);
                var isUserExist = registerResponse.Data?.IsUserExists;
                if (registerResponse.Status == SystemEnumList.ApiStatus.Success.GetDescription() && isUserExist != null && !isUserExist.Value)
                {
                    user.AGUserId = registerResponse.Data.UserId;
                    if (file != null)
                    {
                        byte[] fileContent = null;
                        var reader = new System.IO.BinaryReader(file.InputStream);
                        fileContent = reader.ReadBytes(file.ContentLength); ////Get file data byte array
                        string errorMsg = CommonValidation.ValidateFileTypeProperMessage(file.FileName, fileContent, Constants.MAXIMUM_FILE_UPLOAD_SIZE_BYTES, new[] { SystemEnumList.FileExtension.Jpeg, SystemEnumList.FileExtension.Png, SystemEnumList.FileExtension.Jpg });
                        if (!string.IsNullOrEmpty(errorMsg))
                        {
                            this.AddToastMessage(Resources.General.Error, errorMsg, SystemEnumList.MessageBoxType.Error);
                            return this.View(Views.SignUp, user);
                        }
                    }

                    if (file != null)
                    {
                        var profileImage = Guid.NewGuid().ToString() + System.IO.Path.GetExtension(file.FileName);
                        var imagepath = this.Server.MapPath("~/" + ProjectConfiguration.UserProfileImagePath + "/");
                        file.SaveAs(imagepath + profileImage);
                        user.ProfileImagePath = profileImage;
                    }

                    var encryptedPassword = EncryptionDecryption.EncryptByTripleDES(user.Password);
                    user.Password = encryptedPassword;
                    user.PCNumber = EncryptionDecryption.DecryptByTripleDES(user.PCNumber);
                    int saveStatus = this.memberDataBL.SaveCustomer(user);
                    string msg = string.Empty;
                    var msgBox = Infrastructure.SystemEnumList.MessageBoxType.Success;
                    if (saveStatus > 0)
                    {
                        msg = Account.AccountCreatedSuccessfully;
                    }
                    else
                    {
                        if (saveStatus == -2)
                        {
                            this.AddToastMessage(Account.CreateAccount, Messages.DuplicateMessage.SetArguments(Resources.General.Customer), Infrastructure.SystemEnumList.MessageBoxType.Error);
                            return this.View(Views.SignUp, user);
                        }
                        else
                        {
                            this.AddToastMessage(Account.CreateAccount, Messages.ErrorMessage.SetArguments(Resources.General.Customer), Infrastructure.SystemEnumList.MessageBoxType.Error);
                            return this.View(Views.SignUp, user);
                        }
                    }

                    this.AddToastMessage(Account.CreateAccount, msg, msgBox);
                    if (user.LoginType == SystemEnumList.LoginType.Guest.GetHashCode())
                    {
                        return this.RedirectToAction(Actions.Index, Controllers.Account);
                    }
                    else if (user.LoginType == SystemEnumList.LoginType.Staff.GetHashCode())
                    {
                        return this.RedirectToAction(Actions.StaffLogin, Controllers.ActiveDirectory);
                    }
                    else
                    {
                        return this.RedirectToAction(Actions.ActiveDirectoryLogin, Controllers.ActiveDirectory);
                    }
                }

                this.AddToastMessage(Account.CreateAccount, registerResponse.Message.SetArguments(Resources.General.Customer), Infrastructure.SystemEnumList.MessageBoxType.Error);
                return this.View(Views.SignUp, user);
            }

            if (file != null)
            {
                byte[] fileContent = null;
                var reader = new System.IO.BinaryReader(file.InputStream);
                fileContent = reader.ReadBytes(file.ContentLength); ////Get file data byte array
                string errorMsg = CommonValidation.ValidateFileTypeProperMessage(file.FileName, fileContent, Constants.MAXIMUM_FILE_UPLOAD_SIZE_BYTES, new[] { SystemEnumList.FileExtension.Jpeg, SystemEnumList.FileExtension.Png, SystemEnumList.FileExtension.Jpg });
                if (!string.IsNullOrEmpty(errorMsg))
                {
                    this.AddToastMessage(Resources.General.Error, errorMsg, SystemEnumList.MessageBoxType.Error);
                    return this.View(Views.SignUp, user);
                }
            }

            if (file != null)
            {
                var profileImage = Guid.NewGuid().ToString() + System.IO.Path.GetExtension(file.FileName);
                var imagepath = this.Server.MapPath("~/" + ProjectConfiguration.UserProfileImagePath + "/");
                file.SaveAs(imagepath + profileImage);
                user.ProfileImagePath = profileImage;
            }

            var passwordEncrypted = EncryptionDecryption.EncryptByTripleDES(user.Password);
            user.Password = passwordEncrypted;
            int status = this.memberDataBL.SaveCustomer(user);
            string message = string.Empty;
            var messagebox = Infrastructure.SystemEnumList.MessageBoxType.Success;
            if (status > 0)
            {
                message = Account.AccountCreatedSuccessfully;
            }
            else
            {
                if (status == -2)
                {
                    this.AddToastMessage(Account.CreateAccount, Messages.DuplicateMessage.SetArguments(Resources.General.Customer), Infrastructure.SystemEnumList.MessageBoxType.Error);
                    return this.View(Views.SignUp, user);
                }
                else
                {
                    this.AddToastMessage(Account.CreateAccount, Messages.ErrorMessage.SetArguments(Resources.General.Customer), Infrastructure.SystemEnumList.MessageBoxType.Error);
                    return this.View(Views.SignUp, user);
                }
            }

            this.AddToastMessage(Account.CreateAccount, message, messagebox);
            if (user.LoginType == SystemEnumList.LoginType.Guest.GetHashCode())
            {
                return this.RedirectToAction(Actions.Index, Controllers.Account);
            }
            else if (user.LoginType == SystemEnumList.LoginType.Staff.GetHashCode())
            {
                return this.RedirectToAction(Actions.StaffLogin, Controllers.ActiveDirectory);
            }
            else
            {
                return this.RedirectToAction(Actions.ActiveDirectoryLogin, Controllers.ActiveDirectory);
            }
        }

        /// <summary>
        ///  Set Language
        /// </summary>
        /// <param name="languageId">User language Id</param>
        /// <returns>Is success</returns>
        [HttpPost]
        [ActionName(Actions.SetLanguage)]
        public JsonResult SetLanguage()
        {
            ProjectSession.UserPortalLanguageId = ProjectSession.UserPortalLanguageId == SystemEnumList.Language.Arabic.GetHashCode() ? SystemEnumList.Language.English.GetHashCode() : SystemEnumList.Language.Arabic.GetHashCode();
            int userId = ProjectSession.CustomerId.ToInteger();
            var userProfile = this.memberDataBL.SelectCustomer(userId);
            userProfile.Language = ConvertTo.ToShort(ProjectSession.UserPortalLanguageId);
            int status = this.memberDataBL.SaveCustomer(userProfile);
            if (status > 0)
            {
                return this.Json(new { success = true });
            }
            else
            {
                var message = Messages.ErrorMessage.SetArguments(Resources.General.User);
                var messagebox = Infrastructure.SystemEnumList.MessageBoxType.Error;
                this.AddToastMessage(Account.MyProfile, message, messagebox);
                return this.Json(new { success = true });
            }
        }
    }
}