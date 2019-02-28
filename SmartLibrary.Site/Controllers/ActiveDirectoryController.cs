// <copyright file="ActiveDirectoryController.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Site.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Mvc;
    using Infrastructure;
    using Infrastructure.Code;
    using Pages;
    using Resources;
    using Services;
    using SmartLibrary.Models;
    using static Infrastructure.SystemEnumList;

    /// <summary>
    /// ADController
    /// </summary>
    public class ActiveDirectoryController : Controller
    {
        #region Class variables

        private CommonBL commonBL;
        private MemberDataBL memberDataBL;

        #endregion Class Variables

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveDirectoryController"/> class.
        /// AccountController.
        /// </summary>
        public ActiveDirectoryController()
        {
            this.commonBL = new CommonBL();
            this.memberDataBL = new MemberDataBL();
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
            if (this.Request.Cookies["SmartLibrarySiteAD"] != null)
            {
                HttpCookie cookie = this.Request.Cookies["SmartLibrarySiteAD"];

                loginModel.RememberMe = ConvertTo.ToBoolean(cookie.Values.Get("SiteIsRememberAD"));
                if (loginModel.RememberMe)
                {
                    if (cookie.Values.Get("SiteEmailAD") != null)
                    {
                        loginModel.Email = cookie.Values.Get("SiteEmailAD");
                    }

                    if (cookie.Values.Get("SitePasswordAD") != null)
                    {
                        loginModel.Password = EncryptionDecryption.DecryptByTripleDES(cookie.Values.Get("SitePasswordAD"));
                    }
                }
            }

            loginModel.ReturnUrl = returnUrl;
            return this.View(Views.StaffLogin, loginModel);
        }

        /// <summary>
        /// Login the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>Returns the page as per the login crieteria. </returns>
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

                    Login customerLogin = this.commonBL.GetCustomerLoginwithEmail(adResponse.Email);
                    if (customerLogin != null && customerLogin.Customerdata != null)
                    {
                        if (customerLogin.Customerdata.Active.ToBoolean() == false)
                        {
                            this.AddToastMessage(Resources.General.Error, Account.InactiveUserMessage, Infrastructure.SystemEnumList.MessageBoxType.Error);
                            return this.View(Views.StaffLogin, model);
                        }

                        this.SetCookies(model, customerLogin.Customerdata.Language);

                        ProjectSession.CustomerId = customerLogin.Customerdata.Id;
                        ProjectSession.UserId = customerLogin.Customerdata.Id;
                        ProjectSession.CustomerLanguageId = customerLogin.Customerdata.Language;
                        ProjectSession.UserPortalLanguageId = customerLogin.Customerdata.Language ?? SystemEnumList.Language.English.GetHashCode();
                        ProjectSession.CustomerProfileImagePath = customerLogin.Customerdata.ProfileImagePath;
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
                        var adUserDetail = this.commonBL.GetADuserDataWithPCNo(model.Email);

                        if (adUserDetail == null)
                        {
                            this.AddToastMessage(Resources.General.Error, Account.InvalidCredenitals, Infrastructure.SystemEnumList.MessageBoxType.Error);
                            model.Password = EncryptionDecryption.DecryptByTripleDES(model.Password);
                            return this.View(Views.StaffLogin, model);
                        }

                        if (string.IsNullOrEmpty(adUserDetail.Data.Email))
                        {
                            this.AddToastMessage(Resources.General.Error, Account.EmailNotExist, Infrastructure.SystemEnumList.MessageBoxType.Error);
                            model.Password = EncryptionDecryption.DecryptByTripleDES(model.Password);
                            return this.View(Views.StaffLogin, model);
                        }

                        var customerdata = new Customer()
                        {
                            Email = adUserDetail.Data.Email,
                            FirstName = adUserDetail.Data.Name,
                            LastName = string.Empty,
                            Active = true,
                            Language = ConvertTo.ToShort(Language.English.GetHashCode()),
                            LoginType = ConvertTo.ToInteger(LoginType.Staff.GetHashCode()),
                            PCNumber = adUserDetail.Data.PCNumber,
                        };

                        int saveStatus = this.memberDataBL.SaveCustomer(customerdata);
                        if (saveStatus > 0)
                        {
                            Login customerData = this.commonBL.GetCustomerLoginwithEmail(adResponse.Email);

                            ProjectSession.CustomerId = customerData.Customerdata.Id;
                            ProjectSession.UserId = customerData.Customerdata.Id;
                            ProjectSession.CustomerLanguageId = customerData.Customerdata.Language;
                            ProjectSession.UserPortalLanguageId = customerData.Customerdata.Language ?? SystemEnumList.Language.English.GetHashCode();
                            ProjectSession.CustomerProfileImagePath = customerData.Customerdata.ProfileImagePath;
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
                    }
                }
                else
                {
                    model.Password = EncryptionDecryption.EncryptByTripleDES(model.Password);
                    Login response = this.commonBL.GetCustomerLogin(model);
                    if (response != null && response.Customerdata != null)
                    {
                        if (response.Customerdata.Active.ToBoolean() == false)
                        {
                            this.AddToastMessage(Resources.General.Error, Account.InactiveUserMessage, Infrastructure.SystemEnumList.MessageBoxType.Error);
                            return this.View(Views.StaffLogin, model);
                        }

                        this.SetCookies(model, response.Customerdata.Language);
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
                EncryptedPassword = user.EncryptedPassword,
                FirstName = user.FirstName,
                LastName = user.LastName,
                LoginType = user.LoginType,
                Gender = user.Gender,
                Phone = user.Phone
            };

            if (ProjectConfiguration.IsActiveDirectory)
            {
                var registerResponse = this.commonBL.ActiveDirectoryRegisterResponse(activeDirectoryRegister);
                var isUserExist = registerResponse?.Data?.IsUserExists;
                if (registerResponse != null && registerResponse.Status == SystemEnumList.ApiStatus.Success.GetDescription() && isUserExist != null && !isUserExist.Value)
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
                    user.Password = string.Empty; //// We're not allowed to store password in our DB.
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

                this.AddToastMessage(Account.CreateAccount, registerResponse?.Message?.SetArguments(Resources.General.Customer) ?? Messages.ErrorMessage, Infrastructure.SystemEnumList.MessageBoxType.Error);
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
            user.Password = string.Empty; //// We're not allowed to store password in our DB.
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
        /// Staff Direct Login.
        /// </summary>
        /// <param name="returnUrl">Return Url.</param>
        /// <param name="userName">User Name.</param>
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

            Login customerLogin = this.commonBL.GetCustomerLoginwithEmail(adResponse.Email);
            if (customerLogin != null && customerLogin.Customerdata != null)
            {
                if (customerLogin.Customerdata.Active.ToBoolean() == false)
                {
                    this.AddToastMessage(Resources.General.Error, Account.InactiveUserMessage, Infrastructure.SystemEnumList.MessageBoxType.Error);
                    return this.RedirectToAction(Actions.StaffLogin);
                }

                ProjectSession.CustomerId = customerLogin.Customerdata.Id;
                ProjectSession.UserId = customerLogin.Customerdata.Id;
                ProjectSession.CustomerLanguageId = customerLogin.Customerdata.Language;
                ProjectSession.UserPortalLanguageId = customerLogin.Customerdata.Language ?? SystemEnumList.Language.English.GetHashCode();
                ProjectSession.CustomerProfileImagePath = customerLogin.Customerdata.ProfileImagePath;
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
                return this.RedirectToAction(Actions.StaffLogin);
            }

            return this.RedirectToAction(Actions.ActiveDirectoryLogin);
        }

        /// <summary>
        /// Set Cookies
        /// </summary>
        /// <param name="model">Login Model</param>
        /// <param name="language">Language</param>
        public void SetCookies(Login model, short? language)
        {
            if (model.RememberMe)
            {
                System.Web.HttpCookie cookie = new System.Web.HttpCookie("SmartLibrarySiteAD");
                cookie.Values.Add("SiteEmailAD", model.Email);
                cookie.Values.Add("SitePasswordAD", EncryptionDecryption.EncryptByTripleDES(model.Password));
                cookie.Values.Add("SiteIsRememberAD", Convert.ToString(model.RememberMe));
                cookie.Values.Add("SiteLanguageIdAD", Convert.ToString(language));
                cookie.Expires = DateTime.Now.AddMonths(1);
                cookie.HttpOnly = true;
                this.Response.Cookies.Add(cookie);
            }
            else
            {
                this.Response.Cookies["SmartLibrarySiteAD"].Expires = DateTime.Now.AddMonths(-1);
            }
        }
    }
}