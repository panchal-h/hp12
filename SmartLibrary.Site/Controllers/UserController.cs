// <copyright file="UserController.cs" company="Caspian Pacific Tech">
// Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>

namespace SmartLibrary.Site.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using EmailServices;
    using Infrastructure;
    using Infrastructure.Code;
    using Models;
    using Pages;
    using Resources;
    using Services;
    using SmartLibrary.Models;

    /// <summary>
    /// UserController
    /// </summary>
    public class UserController : BaseController
    {
        private MemberDataBL memberDataBL;
        private CommonBL commonBL;
        private MasterDataBL masterBL;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class.
        /// UserController
        /// </summary>
        public UserController()
        {
            if (this.memberDataBL == null)
            {
                this.memberDataBL = new MemberDataBL();
                this.commonBL = new CommonBL();
                this.masterBL = new MasterDataBL();
            }
        }

        /// <summary>
        /// User Profile.
        /// </summary>
        /// <param name="id">id.</param>
        /// <returns>Profile details of User</returns>
        [ActionName(Actions.MyProfile)]
        public ActionResult MyProfile()
        {
            Customer model = new Customer();
            model.Id = ProjectSession.CustomerId.ToInteger();
            model = this.memberDataBL.GetCustomerList(model).FirstOrDefault();
            MyProfileViewModel customerProfile = new MyProfileViewModel();
            customerProfile.Id = model.Id;
            customerProfile.ProfileImagePath = model.ProfileImagePath;
            customerProfile.FirstName = model.FirstName;
            customerProfile.LastName = model.LastName;
            customerProfile.Email = model.Email;
            customerProfile.Phone = model.Phone;
            customerProfile.Gender = model.Gender;
            customerProfile.Language = model.Language;

            return this.View(Views.Profile, customerProfile);
        }

        /// <summary>
        /// Manages the UserProfile.
        /// </summary>
        /// <param name="user">The User.</param>
        /// <param name="file">The HttpPostedFileBase.</param>
        /// <returns>Save User profile.</returns>
        [ActionName(Actions.MyProfile)]
        [HttpPost]
        public ActionResult MyProfile(MyProfileViewModel user, HttpPostedFileBase file)
        {
            try
            {
                if (!this.ModelState.IsValid)
                {
                    return this.View(Views.Profile, user);
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
                        return this.View(Views.Profile, user);
                    }
                }
                
                int userId = ProjectSession.CustomerId.ToInteger();
                var userProfile = this.memberDataBL.SelectCustomer(userId);
                if (file != null)
                {
                    var profileImage = Guid.NewGuid().ToString() + System.IO.Path.GetExtension(file.FileName);
                    var imagepath = this.Server.MapPath("~/" + ProjectConfiguration.UserProfileImagePath + "/");
                    file.SaveAs(imagepath + profileImage);
                    userProfile.ProfileImagePath = profileImage;
                }

                userProfile.FirstName = user.FirstName;
                userProfile.LastName = user.LastName;
                userProfile.Phone = user.Phone;
                userProfile.Language = user.Language;
                userProfile.Gender = user.Gender;
                int status = this.memberDataBL.SaveCustomer(userProfile);
                string message = string.Empty;
                var messagebox = Infrastructure.SystemEnumList.MessageBoxType.Success;
                if (status > 0)
                {
                    ProjectSession.UserPortalLanguageId = user.Language.ToInteger();
                    CultureInfo cultureInfo = new CultureInfo(SmartLibrary.Site.Classes.General.GetCultureName(ProjectSession.UserPortalLanguageId), true);
                    cultureInfo.DateTimeFormat.FullDateTimePattern = ProjectConfiguration.DateTimeFormat;
                    cultureInfo.DateTimeFormat.ShortDatePattern = ProjectConfiguration.DateFormat;
                    System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
                    System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
                    message = Account.ProfileUpdatedSuccessfully;
                }
                else
                {
                    if (status == -2)
                    {
                        message = Messages.DuplicateMessage.SetArguments(Resources.General.User);
                        messagebox = Infrastructure.SystemEnumList.MessageBoxType.Error;
                    }
                    else
                    {
                        message = Messages.ErrorMessage.SetArguments(Resources.General.User);
                        messagebox = Infrastructure.SystemEnumList.MessageBoxType.Error;
                    }
                }

                if (user.Password.ToStringTrim() != string.Empty || user.NewPassword.ToStringTrim() != string.Empty || user.ConfirmPassword.ToStringTrim() != string.Empty)
                {
                    if (user.Password.ToStringTrim() != string.Empty && user.NewPassword.ToStringTrim() != string.Empty && user.ConfirmPassword.ToStringTrim() != string.Empty)
                    {
                        if (userProfile != null && userId > 0)
                        {
                            if (userProfile.Password == Infrastructure.EncryptionDecryption.EncryptByTripleDES(user.Password))
                            {
                                if (user.NewPassword == user.ConfirmPassword)
                                {
                                    userProfile.Password = Infrastructure.EncryptionDecryption.EncryptByTripleDES(user.NewPassword);
                                    bool response = this.commonBL.ChangePassword(userId, userProfile.Password, Infrastructure.SystemEnumList.ChangePasswordFor.Customer.GetDescription());
                                    if (response)
                                    {
                                        message = Account.ProfileUpdatedSuccessfully;
                                    }
                                    else
                                    {
                                        this.AddToastMessage(Resources.General.Error, Messages.ChangePasswordError, Infrastructure.SystemEnumList.MessageBoxType.Error);
                                        return this.RedirectToAction(Actions.MyProfile, Controllers.User);
                                    }
                                }
                                else
                                {
                                    this.AddToastMessage(Resources.General.Error, Account.NewPasswordAndConfirmPasswordNotMatch, SystemEnumList.MessageBoxType.Error);
                                    return this.RedirectToAction(Actions.MyProfile, Controllers.User);
                                }
                            }
                            else
                            {
                                this.AddToastMessage(Resources.General.Error, Account.CurrentPasswordNotMatch, Infrastructure.SystemEnumList.MessageBoxType.Error);
                                return this.RedirectToAction(Actions.MyProfile, Controllers.User);
                            }
                        }
                        else
                        {
                            this.AddToastMessage(Resources.General.Error, Account.UserNotExist, Infrastructure.SystemEnumList.MessageBoxType.Error);
                            return this.RedirectToAction(Actions.MyProfile, Controllers.User);
                        }
                    }
                    else
                    {
                        this.AddToastMessage(Account.MyProfile, Messages.AllPasswordRequired, Infrastructure.SystemEnumList.MessageBoxType.Error);
                        return this.View(Views.Profile, user);
                    }
                }

                this.AddToastMessage(Account.MyProfile, message, messagebox);
                return this.RedirectToAction(Actions.MyProfile, Controllers.User);
            }
            catch (Exception ex)
            {
                this.AddToastMessage(Account.MyProfile, ex.ToString(), Infrastructure.SystemEnumList.MessageBoxType.Error);
                return this.View(Views.Profile, user);
            }
        }

        /// <summary>
        /// Change Password Page.
        /// </summary>
        /// <returns>View Change Password.</returns>
        [ActionName(Actions.ChangePassword)]
        public ActionResult ChangePassword()
        {
            if (ProjectSession.LoginType != SystemEnumList.LoginType.Guest.GetHashCode())
            {
                return this.RedirectToAction(Actions.BookGrid, Controllers.Book);
            }

            if (!string.IsNullOrEmpty(ConvertTo.String(ProjectSession.CustomerId)))
            {
                int userId = ProjectSession.CustomerId.ToInteger();
                using (Services.ServiceContext changePasswordService = new Services.ServiceContext(true))
                {
                    var userModel = changePasswordService.Search(new SmartLibrary.Models.Customer()
                    {
                        Id = userId
                    }).FirstOrDefault();

                    if (userModel != null && userModel.Id > 0)
                    {
                        SmartLibrary.Models.ChangePassword changePassword = new SmartLibrary.Models.ChangePassword();
                        changePassword.Id = userModel.Id;
                        return this.View(Views.ChangePassword, changePassword);
                    }
                }
            }

            return this.View(Views.ChangePassword);
        }

        /// <summary>
        /// Change Password Page.
        /// </summary>
        /// <param name="changePassword">change Password model.</param>
        /// <returns>View Change Password.</returns>
        [ActionName(Actions.ChangePassword)]
        [HttpPost]
        public ActionResult ChangePassword(SmartLibrary.Models.ChangePassword changePassword)
        {
            using (Services.ServiceContext changePasswordService = new Services.ServiceContext(true))
            {
                if (changePassword == null || ConvertTo.ToInteger(changePassword.Id) <= 0)
                {
                    this.ViewBag.ChangePasswordMessage = SmartLibrary.Resources.Account.UserNotExist;
                    return this.View(Views.ChangePassword, changePassword);
                }

                var userModel = changePasswordService.Search(new SmartLibrary.Models.Customer()
                {
                    Id = changePassword.Id,
                }).FirstOrDefault();

                if (userModel != null && userModel.Id > 0)
                {
                    if (ProjectConfiguration.IsActiveDirectory)
                    {
                        ActiveDirectoryRegister activeDirectoryChangePassword = new ActiveDirectoryRegister()
                        {
                            Email = userModel.Email,
                            Password = changePassword.CurrentPassword,
                            NewPassword = changePassword.NewPassword,
                            ConfirmPassword = changePassword.ConfirmPassword,
                            EncryptedPassword = changePassword.EncryptedCurrentPassword,
                            EncryptedNewPassword = changePassword.EncryptedNewPassword,
                            EncryptedConfirmPassword = changePassword.EncryptedConfirmPassword
                        };

                        var changePasswordResponse = this.commonBL.ActiveDirectoryChangePasswordResponse(activeDirectoryChangePassword);

                        if (changePasswordResponse == null || changePasswordResponse.Status != SystemEnumList.ApiStatus.Success.GetDescription())
                        {
                            this.AddToastMessage(Resources.General.Error, changePasswordResponse?.Message ?? Messages.ErrorMessage.SetArguments(General.Member), Infrastructure.SystemEnumList.MessageBoxType.Error);
                            return this.View(Views.ChangePassword, changePassword);
                        }
                    }
                }
                else
                {
                    this.AddToastMessage(Resources.General.Error, Account.UserNotExist, Infrastructure.SystemEnumList.MessageBoxType.Error);
                    return this.View(Views.ChangePassword, changePassword);
                }

                this.AddToastMessage(Resources.General.Success, Account.PasswordChangedSuccessfully, Infrastructure.SystemEnumList.MessageBoxType.Success);
                return new RedirectResult(this.Url.Action(Views.BookGrid, Controllers.Book));
            }
        }
    }
}